using System;
using System.Windows.Forms;

namespace ExpMethod {
    public static class Helper {
        /// <summary>
        /// 为字符串追加格式化字符串，并在结尾换行。
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="format">格式字符串</param>
        /// <param name="args">格式内容</param>
        /// <returns>追加后的字符串</returns>
        public static string AppendLine(this string _input, string format, params object[] args) {
            return _input + string.Format(format, args) + Environment.NewLine;
        }
    }
}

namespace osuSBNoteMaker {
    public static class Common {
        public static string[] skinFile = { "hitcircleF", "hitcircleoverlayF", "approachcircleF", "black" };
    }
    /// <summary>
    /// 表示击打物件
    /// </summary>
    public struct HitObject {
        public int x;
        public int y;
        public int hitTime;
        public ObjectType type;
        /// <summary>
        /// 构造物件
        /// </summary>
        /// <param name="x1">x坐标</param>
        /// <param name="y1">y坐标</param>
        /// <param name="hitTime1">击打时间</param>
        /// <param name="type1">物件种类</param>
        public HitObject(int x1, int y1, int hitTime1, ObjectType type1) {
            x = x1;
            y = y1;
            hitTime = hitTime1;
            type = type1;
        }
    }

    public struct Setting {
        public double? ics;
        public double? iar;
        public bool inverse;
        public bool useBlackBG;
        /// <summary>
        /// 自定义设置
        /// </summary>
        /// <param name="cs">指定CS，null为原始CS</param>
        /// <param name="ar">指定AR，null为原始AR</param>
        /// <param name="inverse1">指定是否翻转(HR)</param>
        /// <param name="useBlackBG">指定是否使用黑色背景</param>
        public Setting(double? cs, double? ar, bool inverse1 = false, bool useBlackBG1 = false) {
            ics = cs;
            iar = ar;
            inverse = inverse1;
            useBlackBG = useBlackBG1;
        }
        public void Default() {
            ics = null;
            iar = null;
            inverse = false;
            useBlackBG = false;
        }
    }
    public enum ObjectType {
        Circle,
        Slider,
        Spinner,
    }

}