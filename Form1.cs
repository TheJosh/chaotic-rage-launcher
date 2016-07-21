/**
 * Copyright (c) 2016 Josh Heidenreich <josh.sickmate@gmail.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the LICENSE file for more details.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace ChaoticRageLauncher
{
    public partial class Form1 : Form
    {
        private List<string> log;


        public Form1()
        {
            InitializeComponent();
            log = new List<string>();
        }




        private void load()
        {
            labBinary.Text = Properties.Settings.Default.Binary;
            labWorkingDir.Text = Properties.Settings.Default.WorkingDir;
            updateWorkingDir();
            comMode.SelectedIndex = 0;
        }

        private void save()
        {
            Properties.Settings.Default.Binary = labBinary.Text;
            Properties.Settings.Default.WorkingDir = labWorkingDir.Text;
            Properties.Settings.Default.Save();
        }

        private void updateWorkingDir()
        {
            var wd = labWorkingDir.Text;

            string[] dirs = Directory.GetDirectories(wd + "/data");
            comMod.Items.Clear();
            foreach (string d in dirs) {
                string e = Path.GetFileName(d);
                if (e != "i18n" && e != "intro") {
                    comMod.Items.Add(e);
                }
            }
            comMod.SelectedIndex = 0;
        }

        private void rebuildCommandLine()
        {
            string cmd = "";

            if (comMode.SelectedIndex == -1) comMode.SelectedIndex = 0;

            switch (comMode.Items[comMode.SelectedIndex].ToString()) {
                case "Arcade":
                    cmd += "--arcade " + txtArcadeGame.Text + "," + txtArcadeMap.Text + "," + txtArcadeUnit.Text;
                    break;

                case "Campaign":
                    cmd += "--campaign " + txtCampaign.Text;
                    break;

                case "Join":
                    cmd += "--join " + txtJoin.Text;
                    break;
            }

            if (comVideo.SelectedIndex >= 0) {
                cmd += " --video " + comVideo.Items[comVideo.SelectedIndex].ToString();
            }

            if (comWindowMode.SelectedIndex == 0) {
                cmd += " --window";
                if (txtWindowX.Text != "" && txtWindowY.Text != "") {
                    cmd += "=" + txtWindowX.Text + "," + txtWindowY.Text;
                }
            } else if (comWindowMode.SelectedIndex == 1) {
                cmd += " --fullscreen";
            }

            if (comAudio.SelectedIndex >= 0) {
                cmd += " --audio " + comAudio.Items[comAudio.SelectedIndex].ToString();
            }

            if (chkHost.Checked) {
                cmd += " --host";
            }

            if (chkThrottle.Checked) {
                cmd += " --throttle";
            }

            if (comMod.Items[comMod.SelectedIndex].ToString() != "cr") {
                cmd += " --mod " + comMod.Items[comMod.SelectedIndex].ToString();
            }

            foreach (object group in lstDbgGroups.SelectedItems) {
                cmd += " --debug " + group.ToString();
            }

            if (chkDebugLine.Checked) {
                cmd += " --debug-lineno";
            }

            if (chkNoMouse.Checked) {
                cmd += " --no-mouse-grab";
            }

            if (chkLoopLimit.Checked) {
                cmd += " --loop-limit " + txtLoopLimit.Text;
            }

            if (chkProfile.Checked && chkProfile.Tag != null) {
                cmd += " --profile " + chkProfile.Tag;
            }

            if (chkDebugFile.Checked && chkDebugFile.Tag != null) {
                cmd += " --debug-file " + chkDebugFile.Tag;
            }

            txtCommandLine.Text = cmd;
        }




        private void btnFindBinary_Click(object sender, EventArgs e)
        {
            diaFindBinary.FileName = labBinary.Text;
            if (diaFindBinary.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                labBinary.Text = diaFindBinary.FileName;
            }
        }

        private void btnWorkingDir_Click(object sender, EventArgs e)
        {
            diaWorkingDir.SelectedPath = labWorkingDir.Text;
            if (diaWorkingDir.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                labWorkingDir.Text = diaWorkingDir.SelectedPath;
                updateWorkingDir();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }

        private void general_SelectedIndexChanged(object sender, EventArgs e)
        {
            rebuildCommandLine();
        }

        private void general_TextChanged(object sender, EventArgs e)
        {
            rebuildCommandLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            log.Clear();
            timLog.Enabled = true;

            Process process = new Process();
            process.StartInfo.FileName = labBinary.Text;
            process.StartInfo.WorkingDirectory = labWorkingDir.Text;
            process.StartInfo.Arguments = txtCommandLine.Text;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.ErrorDataReceived += new DataReceivedEventHandler(outputLineReceived);
            process.OutputDataReceived += new DataReceivedEventHandler(outputLineReceived);
            process.Exited += new EventHandler(process_Exited);
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        }

        void process_Exited(object sender, EventArgs e)
        {
            timLog.Enabled = false;
        }

        private void outputLineReceived(object sender, DataReceivedEventArgs e)
        {
            log.Add(e.Data);
        }

        private void general_CheckedChanged(object sender, EventArgs e)
        {
            rebuildCommandLine();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (diaProfile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                chkProfile.Checked = true;
                chkProfile.Tag = diaProfile.FileName;
                rebuildCommandLine();
            }
        }

        private void btnDebugFile_Click(object sender, EventArgs e)
        {
            if (diaDebugFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                chkDebugFile.Checked = true;
                chkDebugFile.Tag = diaDebugFile.FileName;
                rebuildCommandLine();
            }
        }

        private void timLog_Tick(object sender, EventArgs e)
        {
            string ss = "";
            foreach (string s in log) {
                ss += s + "\r\n";
            }
            txtLog.Text = ss;
        }
    }
}
