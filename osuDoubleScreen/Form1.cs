using System;
using System.Windows.Forms;

namespace osuSBNoteMaker {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Osu osu;
        Setting settings = new Setting();
        decimal oar = 0.0M, ocs = 0.0M;
        private void buttonStart_Click(object sender, EventArgs e) {
            CreateSetting();
            osu.Make(settings);
        }

        private void CreateSetting() {
            settings.iar = (double)numericUpDownAR.Value;
            settings.ics = (double)numericUpDownCS.Value;
            settings.inverse = radioHR.Checked ? true : false;
            settings.useBlackBG = checkBlackBG.Checked ? true : false;
        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            osuFile.Text = openFileDialog1.FileName;
            try {
                osbFile.Text = osuFile.Text.Substring(0, osuFile.Text.LastIndexOf(" [")) + ".osb";
                osu = new Osu(osuFile.Text, osbFile.Text, logBox);
                if (osu.Init()) {
                    numericUpDownAR.Value = oar = (decimal)osu.ar;
                    numericUpDownCS.Value = ocs = (decimal)osu.cs;
                    buttonStart.Enabled = true;
                }
            }
            catch {

            }
        }

        private void Info(decimal ar, decimal cs) {
            numericUpDownAR.Value = ar;
            numericUpDownCS.Value = cs;
            numericUpDownAR.Refresh();
            numericUpDownCS.Refresh();
        }

        private void UnLockInfo() {
            numericUpDownAR.ReadOnly = false;
            numericUpDownCS.ReadOnly = false;
            numericUpDownAR.InterceptArrowKeys = true;
            numericUpDownCS.InterceptArrowKeys = true;
        }

        private void LockInfo() {
            numericUpDownAR.ReadOnly = true;
            numericUpDownCS.ReadOnly = true;
            numericUpDownAR.InterceptArrowKeys = false;
            numericUpDownCS.InterceptArrowKeys = false;
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e) {
            if (radioCustom.Checked) {
                UnLockInfo();
            }
        }

        private void radioNone_CheckedChanged(object sender, EventArgs e) {
            if (radioNone.Checked) {
                LockInfo();
                Info(oar, ocs);
            }
            else {
                UnLockInfo();
            }
        }



        private void radioEZ_CheckedChanged(object sender, EventArgs e) {
            if (radioEZ.Checked)
                Info(oar / 2, ocs / 2);
        }

        private void radioHR_CheckedChanged(object sender, EventArgs e) {
            if (radioHR.Checked)
                Info((oar * 1.4M) > 10M ? 10M : (oar * 1.4M), ocs * 1.3M);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://osu.ppy.sh/u/4247826");
        }

    }
}

