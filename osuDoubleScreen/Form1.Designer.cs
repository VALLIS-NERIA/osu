namespace osuSBNoteMaker {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.osuFile = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.osbFile = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioHR = new System.Windows.Forms.RadioButton();
            this.radioEZ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAR = new System.Windows.Forms.NumericUpDown();
            this.checkDefaultSkin = new System.Windows.Forms.CheckBox();
            this.checkBlackBG = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // osuFile
            // 
            this.osuFile.AllowDrop = true;
            this.osuFile.Location = new System.Drawing.Point(12, 13);
            this.osuFile.Name = "osuFile";
            this.osuFile.ReadOnly = true;
            this.osuFile.Size = new System.Drawing.Size(260, 21);
            this.osuFile.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(278, 14);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(77, 20);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "打开(&O)...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // osbFile
            // 
            this.osbFile.AllowDrop = true;
            this.osbFile.Location = new System.Drawing.Point(12, 41);
            this.osbFile.Name = "osbFile";
            this.osbFile.Size = new System.Drawing.Size(260, 21);
            this.osbFile.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(278, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(77, 21);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // logBox
            // 
            this.logBox.AcceptsReturn = true;
            this.logBox.Location = new System.Drawing.Point(6, 20);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.logBox.Size = new System.Drawing.Size(134, 121);
            this.logBox.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "osu! beatmap|*.osu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCustom);
            this.groupBox1.Controls.Add(this.radioNone);
            this.groupBox1.Controls.Add(this.radioHR);
            this.groupBox1.Controls.Add(this.radioEZ);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod";
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(48, 42);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(59, 16);
            this.radioCustom.TabIndex = 3;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Checked = true;
            this.radioNone.Location = new System.Drawing.Point(6, 20);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(47, 16);
            this.radioNone.TabIndex = 2;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            this.radioNone.CheckedChanged += new System.EventHandler(this.radioNone_CheckedChanged);
            // 
            // radioHR
            // 
            this.radioHR.AutoSize = true;
            this.radioHR.Location = new System.Drawing.Point(6, 42);
            this.radioHR.Name = "radioHR";
            this.radioHR.Size = new System.Drawing.Size(35, 16);
            this.radioHR.TabIndex = 1;
            this.radioHR.Text = "HR";
            this.radioHR.UseVisualStyleBackColor = true;
            this.radioHR.CheckedChanged += new System.EventHandler(this.radioHR_CheckedChanged);
            // 
            // radioEZ
            // 
            this.radioEZ.AutoSize = true;
            this.radioEZ.Location = new System.Drawing.Point(60, 20);
            this.radioEZ.Name = "radioEZ";
            this.radioEZ.Size = new System.Drawing.Size(35, 16);
            this.radioEZ.TabIndex = 0;
            this.radioEZ.Text = "EZ";
            this.radioEZ.UseVisualStyleBackColor = true;
            this.radioEZ.CheckedChanged += new System.EventHandler(this.radioEZ_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "AR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "CS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownCS);
            this.groupBox2.Controls.Add(this.numericUpDownAR);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(129, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 65);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // numericUpDownCS
            // 
            this.numericUpDownCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownCS.DecimalPlaces = 1;
            this.numericUpDownCS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCS.InterceptArrowKeys = false;
            this.numericUpDownCS.Location = new System.Drawing.Point(36, 40);
            this.numericUpDownCS.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDownCS.Name = "numericUpDownCS";
            this.numericUpDownCS.ReadOnly = true;
            this.numericUpDownCS.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownCS.TabIndex = 12;
            // 
            // numericUpDownAR
            // 
            this.numericUpDownAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAR.DecimalPlaces = 1;
            this.numericUpDownAR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAR.InterceptArrowKeys = false;
            this.numericUpDownAR.Location = new System.Drawing.Point(36, 18);
            this.numericUpDownAR.Maximum = new decimal(new int[] {
            119,
            0,
            0,
            65536});
            this.numericUpDownAR.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownAR.Name = "numericUpDownAR";
            this.numericUpDownAR.ReadOnly = true;
            this.numericUpDownAR.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownAR.TabIndex = 11;
            // 
            // checkDefaultSkin
            // 
            this.checkDefaultSkin.AutoSize = true;
            this.checkDefaultSkin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkDefaultSkin.Location = new System.Drawing.Point(6, 20);
            this.checkDefaultSkin.Name = "checkDefaultSkin";
            this.checkDefaultSkin.Size = new System.Drawing.Size(120, 16);
            this.checkDefaultSkin.TabIndex = 12;
            this.checkDefaultSkin.Text = "使用默认皮肤资源";
            this.checkDefaultSkin.UseVisualStyleBackColor = true;
            // 
            // checkBlackBG
            // 
            this.checkBlackBG.AutoSize = true;
            this.checkBlackBG.Checked = true;
            this.checkBlackBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBlackBG.Location = new System.Drawing.Point(6, 42);
            this.checkBlackBG.Name = "checkBlackBG";
            this.checkBlackBG.Size = new System.Drawing.Size(96, 16);
            this.checkBlackBG.TabIndex = 13;
            this.checkBlackBG.Text = "使用黑色背景";
            this.checkBlackBG.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkDefaultSkin);
            this.groupBox3.Controls.Add(this.checkBlackBG);
            this.groupBox3.Location = new System.Drawing.Point(226, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 65);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.logBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 147);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(254, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 12);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By Kvantuma Rozo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(165, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 147);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "说明";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 121);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1.本工具仅供娱乐；\r\n2.单Hidden效果很奇怪；\r\n3.不建议大幅修改AR；\r\n4.EZHD/HDFL有奇效；\r\n5.皮肤用白色note+空白数字；\r\n6." +
    "别忘了关掉背景暗化；";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.osbFile);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.osuFile);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox osuFile;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox osbFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioHR;
        private System.Windows.Forms.RadioButton radioEZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownCS;
        private System.Windows.Forms.NumericUpDown numericUpDownAR;
        private System.Windows.Forms.CheckBox checkDefaultSkin;
        private System.Windows.Forms.CheckBox checkBlackBG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

