using ExpMethod;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace osuSBNoteMaker {
    public class Osu {

        int approachTime = 1050;//AR. 6 by default
        double csScale = 0.57;//CS. 4 by default
        public double cs = 4.0, ar = 6.0;

        string R = "255";
        string G = "255";
        string B = "255";

        string osuPath = null;
        string osbPath = null;

        TextBox logBox=null;
        Setting settings;

        FileStream fsosu = null;
        StreamReader srosu = null;
        FileStream fsSB = null;
        StreamWriter swSB = null;

        public Osu(string path, TextBox textBox1) {
            osuPath = path;
            logBox = textBox1;
            osbPath = osuPath.Substring(0, osuPath.LastIndexOf(" [")) + ".osb";

        }

        public Osu(string path,string bpath, TextBox textBox1) {
            osuPath = path;
            logBox = textBox1;
            osbPath = bpath;
        }


        /// <summary>
        /// 打开.osu文件，读取AR和CS同时进行基本的格式检查
        /// </summary>
        /// <returns>是否是合法的.osu文件</returns>
        public bool Init() {
            fsosu = new FileStream(osuPath, FileMode.Open, FileAccess.Read);
            srosu = new StreamReader(fsosu, Encoding.Default);
            fsosu.Seek(0, SeekOrigin.Begin);
            logBox.AppendText("File opened." + Environment.NewLine);
            bool a = false, b = false, c = false;
            int version = 12, od = 5;
            while (srosu.Peek() >= 0) {
                string content = srosu.ReadLine();
                if (content.StartsWith("osu file format v")) {
                    string[] data = content.Split('v');
                    version = Convert.ToInt32(data[1]);
                }
                else if (content.StartsWith("CircleSize")) {
                    a = true;
                    string[] data = content.Split(':');
                    cs = Convert.ToDouble(data[1]);
                    csScale = Convert.ToDouble((0.8503125 - cs * 0.07015625).ToString("0.00"));
                    logBox.AppendText("CS:" + cs.ToString() + "   ");
                }
                else if (content.StartsWith("ApproachRate") || (version < 8 && content.StartsWith("OverallDifficulty"))) {
                    b = true;
                    string[] data = content.Split(':');
                    ar =  Convert.ToDouble(data[1]);
                    approachTime = 1800 - (int)(150 * ar);
                    logBox.AppendText("AR:" + ar.ToString() + Environment.NewLine);
                }
                else if (content.StartsWith("[HitObjects]")) {
                    c = true;
                    if (a && b) {
                        srosu.Close();
                        fsosu.Close();
                        return true;
                    }
                }
            }
            srosu.Close();
            fsosu.Close();
            MessageBox.Show("文件不合法！");
            return false;
        }

        /// <summary>
        /// 将.osu中的note转为SB脚本
        /// </summary>
        /// <param name="se">设置集</param>
        /// <returns>是否成功</returns>
        public bool Make(Setting se) {

            fsosu = new FileStream(osuPath, FileMode.Open, FileAccess.Read);
            srosu = new StreamReader(fsosu, Encoding.Default);
            //fsosu.Seek(0, SeekOrigin.Begin);
            //设置
            settings = se;
            if (settings.ics.HasValue) {
                cs = settings.ics.Value;
                csScale = Convert.ToDouble((0.8503125 - cs * 0.07015625).ToString("0.00"));
            }
            if (settings.iar.HasValue) {
                ar = settings.iar.Value;
                approachTime = 1800 - (int)(150 * ar);
            }

            //准备工作
            string path = System.IO.Path.GetDirectoryName(osuPath);
            logBox.AppendText("解压皮肤资源..." + Environment.NewLine);
            for (int i = 0; i < Common.skinFile.Count(); i++) {
                string s = Common.skinFile[i];
                if (!File.Exists(path + "\\" + s + ".png")) {
                    GetSkinResource(i).Save(path + "\\" + s + ".png");
                }
            }
            //备份osb
            if (File.Exists(osbPath)) {
                for (int i = 0; i < 100; i++)
                    if (!File.Exists(osbPath + ".bak" + i.ToString())) {
                        logBox.AppendText("已有osb文件被备份为bak" + i.ToString() + Environment.NewLine);
                        File.Move(osbPath, osbPath + ".bak" + i.ToString());
                        break;
                    }
            }
            //打开文件，写入文件头
            fsSB = new FileStream(osbPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            swSB = new StreamWriter(fsSB, Encoding.Default);
            swSB.WriteLine("//Powered by osuSBNoteMaker");
            swSB.WriteLine("[Events]");
            //黑色背景
            if (settings.useBlackBG) {
                swSB.WriteLine("Sprite,Background,Centre,\"{0}.png\",320,240", Common.skinFile[3]);
                swSB.WriteLine(" C,0,-1000,3000000,0,0,0");
            }
            fsSB.Seek(0, SeekOrigin.End);
            //开始转换note
            logBox.AppendText("Working..." + Environment.NewLine);
            string[] data;
            string content = srosu.ReadLine();
            while (!content.StartsWith("[HitObjects]")) {
                content = srosu.ReadLine();
            }
            while (srosu.Peek() >= 0) {
                content = srosu.ReadLine();
                data = content.Split(',');
                HitObject note = new HitObject(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), GetObjectType(Convert.ToInt32(data[3])));
                swSB.WriteLine(makesb(note));
            }
            logBox.AppendText("完成!" + Environment.NewLine);
            swSB.Close();
            fsSB.Close();
            srosu.Close();
            fsosu.Close();
            return true;
        }

        /// <summary>
        /// 分析.osu中代表note种类的数值
        /// </summary>
        /// <param name="objType">数字形式的代码</param>
        /// <returns>note种类</returns>
        private ObjectType GetObjectType(int objType) {
            ObjectType type = ObjectType.Circle;
            if ((objType & 8) == 8) {
                type = ObjectType.Spinner;
            }
            else if ((objType & 2) == 2) {
                type = ObjectType.Slider;
            }
            else if ((objType & 1) == 1) {
                type = ObjectType.Circle;
            }
            else {
                throw new System.FormatException("Invalid note type");
            }
            return type;
        }

        /// <summary>
        /// 为给定的note生成SB脚本
        /// </summary>
        /// <param name="note">要生成的note</param>
        /// <returns>对应的SB脚本代码</returns>
        private string makesb(HitObject note) {

            int ix=note.x;
            int iy = settings.inverse ? 384 - note.y : note.y;
            int ihitTime=note.hitTime;
            ObjectType type = note.type;
            
            string x = (ix + 64).ToString();
            string y = (iy + 56).ToString();
            string objTime = (ihitTime - approachTime).ToString();
            string arTime = approachTime.ToString();
            string lifeTime = (approachTime + 150).ToString();
            string objScale = csScale.ToString();
            string s = null;
            string endl = Environment.NewLine;
            if (type == ObjectType.Circle) {
                //hitcircle
                s = s.AppendLine("Sprite,Foreground,Centre,\"{2}.png\",{0},{1}", x, y, Common.skinFile[0]);
                s = s.AppendLine("  L,{0},1 ", objTime);
                s = s.AppendLine("  F,0,0,150,0,1");
                s = s.AppendLine("  C,0,0,0,{0},{1},{2}", R, G, B);
                s = s.AppendLine("  S,0,0,{0},{1}", arTime, objScale);
                s = s.AppendLine("  F,0,150,{0},1", arTime);
                s = s.AppendLine("  F,0,{0},{1},1,0", arTime, lifeTime);
                //hitcircleoverlay
                s = s.AppendLine("Sprite,Foreground,Centre,\"{2}.png\",{0},{1}", x, y, Common.skinFile[1]);
                s = s.AppendLine("  L,{0},1 ", objTime);
                s = s.AppendLine("  F,0,0,150,0,1");
                s = s.AppendLine("  S,0,0,{0},{1}", arTime, objScale);
                s = s.AppendLine("  F,0,150,{0},1", arTime);
                s = s.AppendLine("  F,0,{0},{1},1,0", arTime, lifeTime);
            }
            //approachcircle
            s = s.AppendLine("Sprite,Foreground,Centre,\"{2}.png\",{0},{1}", x, y, Common.skinFile[2]);
            s = s.AppendLine("  L,{0},1 ", objTime);
            s = s.AppendLine("  F,0,0,{0},0,1", arTime);
            s = s.AppendLine("  S,0,0,{0},2.1,{1}", arTime, objScale);
            s = s.AppendLine("  C,0,0,0,{0},{1},{2}", R, G, B);
            s = s.AppendLine("  F,0,{0},{1},1,0", arTime, lifeTime);
            return s;
        }

        private Bitmap GetSkinResource(int index) {
            switch (index) {
                case 0:
                    return Properties.Resources.hitcircle;
                case 1:
                    return Properties.Resources.hitcircleoverlay;
                case 2:
                    return Properties.Resources.approachcircle;
                case 3:
                    return Properties.Resources.black;
                default:
                    throw new System.IO.FileNotFoundException("没有这个资源");
            }
        }

    }
}
