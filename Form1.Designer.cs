namespace ChaoticRageLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFindBinary = new System.Windows.Forms.Button();
            this.labBinary = new System.Windows.Forms.Label();
            this.diaFindBinary = new System.Windows.Forms.OpenFileDialog();
            this.btnWorkingDir = new System.Windows.Forms.Button();
            this.labWorkingDir = new System.Windows.Forms.Label();
            this.diaWorkingDir = new System.Windows.Forms.FolderBrowserDialog();
            this.comMode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJoin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCampaign = new System.Windows.Forms.TextBox();
            this.txtArcadeUnit = new System.Windows.Forms.TextBox();
            this.txtArcadeGame = new System.Windows.Forms.TextBox();
            this.txtArcadeMap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comMod = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkProfile = new System.Windows.Forms.CheckBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.txtLoopLimit = new System.Windows.Forms.TextBox();
            this.chkLoopLimit = new System.Windows.Forms.CheckBox();
            this.chkNoMouse = new System.Windows.Forms.CheckBox();
            this.chkDebugLine = new System.Windows.Forms.CheckBox();
            this.lstDbgGroups = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkThrottle = new System.Windows.Forms.CheckBox();
            this.chkHost = new System.Windows.Forms.CheckBox();
            this.diaProfile = new System.Windows.Forms.SaveFileDialog();
            this.chkDebugFile = new System.Windows.Forms.CheckBox();
            this.btnDebugFile = new System.Windows.Forms.Button();
            this.diaDebugFile = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comVideo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comAudio = new System.Windows.Forms.ComboBox();
            this.comWindowMode = new System.Windows.Forms.ComboBox();
            this.Mode = new System.Windows.Forms.Label();
            this.txtWindowX = new System.Windows.Forms.TextBox();
            this.txtWindowY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindBinary
            // 
            this.btnFindBinary.Location = new System.Drawing.Point(19, 30);
            this.btnFindBinary.Name = "btnFindBinary";
            this.btnFindBinary.Size = new System.Drawing.Size(96, 23);
            this.btnFindBinary.TabIndex = 0;
            this.btnFindBinary.Text = "Find binary...";
            this.btnFindBinary.UseVisualStyleBackColor = true;
            this.btnFindBinary.Click += new System.EventHandler(this.btnFindBinary_Click);
            // 
            // labBinary
            // 
            this.labBinary.AutoSize = true;
            this.labBinary.Location = new System.Drawing.Point(131, 35);
            this.labBinary.Name = "labBinary";
            this.labBinary.Size = new System.Drawing.Size(35, 13);
            this.labBinary.TabIndex = 1;
            this.labBinary.Text = "label1";
            // 
            // diaFindBinary
            // 
            this.diaFindBinary.Filter = "Executables|*.exe";
            // 
            // btnWorkingDir
            // 
            this.btnWorkingDir.Location = new System.Drawing.Point(19, 59);
            this.btnWorkingDir.Name = "btnWorkingDir";
            this.btnWorkingDir.Size = new System.Drawing.Size(96, 23);
            this.btnWorkingDir.TabIndex = 2;
            this.btnWorkingDir.Text = "Working dir...";
            this.btnWorkingDir.UseVisualStyleBackColor = true;
            this.btnWorkingDir.Click += new System.EventHandler(this.btnWorkingDir_Click);
            // 
            // labWorkingDir
            // 
            this.labWorkingDir.AutoSize = true;
            this.labWorkingDir.Location = new System.Drawing.Point(131, 64);
            this.labWorkingDir.Name = "labWorkingDir";
            this.labWorkingDir.Size = new System.Drawing.Size(35, 13);
            this.labWorkingDir.TabIndex = 3;
            this.labWorkingDir.Text = "label1";
            // 
            // comMode
            // 
            this.comMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMode.FormattingEnabled = true;
            this.comMode.Items.AddRange(new object[] {
            "Menu",
            "Arcade",
            "Campaign",
            "Join"});
            this.comMode.Location = new System.Drawing.Point(99, 36);
            this.comMode.Name = "comMode";
            this.comMode.Size = new System.Drawing.Size(160, 21);
            this.comMode.TabIndex = 4;
            this.comMode.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnWorkingDir);
            this.groupBox1.Controls.Add(this.btnFindBinary);
            this.groupBox1.Controls.Add(this.txtCommandLine);
            this.groupBox1.Controls.Add(this.labWorkingDir);
            this.groupBox1.Controls.Add(this.labBinary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executable";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(697, 25);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(96, 83);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.Text = "Launch!!!!";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command line";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(134, 88);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(540, 20);
            this.txtCommandLine.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comMod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtJoin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCampaign);
            this.groupBox2.Controls.Add(this.txtArcadeUnit);
            this.groupBox2.Controls.Add(this.txtArcadeGame);
            this.groupBox2.Controls.Add(this.txtArcadeMap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comMode);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Startup and game";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server";
            // 
            // txtJoin
            // 
            this.txtJoin.Location = new System.Drawing.Point(99, 167);
            this.txtJoin.Name = "txtJoin";
            this.txtJoin.Size = new System.Drawing.Size(160, 20);
            this.txtJoin.TabIndex = 14;
            this.txtJoin.Text = "127.0.0.1";
            this.txtJoin.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Campaign";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Game type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Map";
            // 
            // txtCampaign
            // 
            this.txtCampaign.Location = new System.Drawing.Point(99, 141);
            this.txtCampaign.Name = "txtCampaign";
            this.txtCampaign.Size = new System.Drawing.Size(160, 20);
            this.txtCampaign.TabIndex = 9;
            this.txtCampaign.Text = "pound";
            this.txtCampaign.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // txtArcadeUnit
            // 
            this.txtArcadeUnit.Location = new System.Drawing.Point(99, 115);
            this.txtArcadeUnit.Name = "txtArcadeUnit";
            this.txtArcadeUnit.Size = new System.Drawing.Size(160, 20);
            this.txtArcadeUnit.TabIndex = 8;
            this.txtArcadeUnit.Text = "robot";
            this.txtArcadeUnit.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // txtArcadeGame
            // 
            this.txtArcadeGame.Location = new System.Drawing.Point(99, 89);
            this.txtArcadeGame.Name = "txtArcadeGame";
            this.txtArcadeGame.Size = new System.Drawing.Size(160, 20);
            this.txtArcadeGame.TabIndex = 7;
            this.txtArcadeGame.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // txtArcadeMap
            // 
            this.txtArcadeMap.Location = new System.Drawing.Point(99, 63);
            this.txtArcadeMap.Name = "txtArcadeMap";
            this.txtArcadeMap.Size = new System.Drawing.Size(160, 20);
            this.txtArcadeMap.TabIndex = 6;
            this.txtArcadeMap.Text = "free_for_all";
            this.txtArcadeMap.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mode";
            // 
            // comMod
            // 
            this.comMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMod.FormattingEnabled = true;
            this.comMod.Location = new System.Drawing.Point(99, 193);
            this.comMod.Name = "comMod";
            this.comMod.Size = new System.Drawing.Size(160, 21);
            this.comMod.TabIndex = 0;
            this.comMod.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkDebugFile);
            this.groupBox4.Controls.Add(this.btnDebugFile);
            this.groupBox4.Controls.Add(this.chkProfile);
            this.groupBox4.Controls.Add(this.btnProfile);
            this.groupBox4.Controls.Add(this.txtLoopLimit);
            this.groupBox4.Controls.Add(this.chkLoopLimit);
            this.groupBox4.Controls.Add(this.chkNoMouse);
            this.groupBox4.Controls.Add(this.chkDebugLine);
            this.groupBox4.Controls.Add(this.lstDbgGroups);
            this.groupBox4.Location = new System.Drawing.Point(491, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 226);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debug";
            // 
            // chkProfile
            // 
            this.chkProfile.AutoSize = true;
            this.chkProfile.Location = new System.Drawing.Point(150, 148);
            this.chkProfile.Name = "chkProfile";
            this.chkProfile.Size = new System.Drawing.Size(55, 17);
            this.chkProfile.TabIndex = 6;
            this.chkProfile.Text = "Profile";
            this.chkProfile.UseVisualStyleBackColor = true;
            this.chkProfile.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(252, 144);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(62, 23);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "FILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // txtLoopLimit
            // 
            this.txtLoopLimit.Location = new System.Drawing.Point(252, 71);
            this.txtLoopLimit.Name = "txtLoopLimit";
            this.txtLoopLimit.Size = new System.Drawing.Size(62, 20);
            this.txtLoopLimit.TabIndex = 4;
            this.txtLoopLimit.Text = "1000";
            this.txtLoopLimit.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // chkLoopLimit
            // 
            this.chkLoopLimit.AutoSize = true;
            this.chkLoopLimit.Location = new System.Drawing.Point(150, 73);
            this.chkLoopLimit.Name = "chkLoopLimit";
            this.chkLoopLimit.Size = new System.Drawing.Size(70, 17);
            this.chkLoopLimit.TabIndex = 3;
            this.chkLoopLimit.Text = "Loop limit";
            this.chkLoopLimit.UseVisualStyleBackColor = true;
            this.chkLoopLimit.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // chkNoMouse
            // 
            this.chkNoMouse.AutoSize = true;
            this.chkNoMouse.Location = new System.Drawing.Point(150, 50);
            this.chkNoMouse.Name = "chkNoMouse";
            this.chkNoMouse.Size = new System.Drawing.Size(98, 17);
            this.chkNoMouse.TabIndex = 2;
            this.chkNoMouse.Text = "No mouse grab";
            this.chkNoMouse.UseVisualStyleBackColor = true;
            this.chkNoMouse.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // chkDebugLine
            // 
            this.chkDebugLine.AutoSize = true;
            this.chkDebugLine.Location = new System.Drawing.Point(150, 27);
            this.chkDebugLine.Name = "chkDebugLine";
            this.chkDebugLine.Size = new System.Drawing.Size(123, 17);
            this.chkDebugLine.TabIndex = 1;
            this.chkDebugLine.Text = "Include line numbers";
            this.chkDebugLine.UseVisualStyleBackColor = true;
            this.chkDebugLine.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // lstDbgGroups
            // 
            this.lstDbgGroups.FormattingEnabled = true;
            this.lstDbgGroups.Items.AddRange(new object[] {
            "aud",
            "coll",
            "data",
            "loop",
            "lua",
            "mod",
            "net",
            "phy",
            "terrain",
            "unit",
            "vid",
            "weap",
            "loadbones",
            "loadmesh"});
            this.lstDbgGroups.Location = new System.Drawing.Point(16, 27);
            this.lstDbgGroups.Name = "lstDbgGroups";
            this.lstDbgGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDbgGroups.Size = new System.Drawing.Size(119, 173);
            this.lstDbgGroups.TabIndex = 0;
            this.lstDbgGroups.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkThrottle);
            this.groupBox5.Controls.Add(this.chkHost);
            this.groupBox5.Location = new System.Drawing.Point(297, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 79);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Host game";
            // 
            // chkThrottle
            // 
            this.chkThrottle.AutoSize = true;
            this.chkThrottle.Location = new System.Drawing.Point(19, 50);
            this.chkThrottle.Name = "chkThrottle";
            this.chkThrottle.Size = new System.Drawing.Size(87, 17);
            this.chkThrottle.TabIndex = 1;
            this.chkThrottle.Text = "Throttle CPU";
            this.chkThrottle.UseVisualStyleBackColor = true;
            this.chkThrottle.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // chkHost
            // 
            this.chkHost.AutoSize = true;
            this.chkHost.Location = new System.Drawing.Point(19, 29);
            this.chkHost.Name = "chkHost";
            this.chkHost.Size = new System.Drawing.Size(80, 17);
            this.chkHost.TabIndex = 0;
            this.chkHost.Text = "Host server";
            this.chkHost.UseVisualStyleBackColor = true;
            this.chkHost.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // diaProfile
            // 
            this.diaProfile.Filter = "Text|*.txt";
            // 
            // chkDebugFile
            // 
            this.chkDebugFile.AutoSize = true;
            this.chkDebugFile.Location = new System.Drawing.Point(150, 112);
            this.chkDebugFile.Name = "chkDebugFile";
            this.chkDebugFile.Size = new System.Drawing.Size(86, 17);
            this.chkDebugFile.TabIndex = 8;
            this.chkDebugFile.Text = "Debug to file";
            this.chkDebugFile.UseVisualStyleBackColor = true;
            this.chkDebugFile.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // btnDebugFile
            // 
            this.btnDebugFile.Location = new System.Drawing.Point(252, 108);
            this.btnDebugFile.Name = "btnDebugFile";
            this.btnDebugFile.Size = new System.Drawing.Size(62, 23);
            this.btnDebugFile.TabIndex = 7;
            this.btnDebugFile.Text = "FILE";
            this.btnDebugFile.UseVisualStyleBackColor = true;
            this.btnDebugFile.Click += new System.EventHandler(this.btnDebugFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mod";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtWindowY);
            this.groupBox3.Controls.Add(this.txtWindowX);
            this.groupBox3.Controls.Add(this.Mode);
            this.groupBox3.Controls.Add(this.comWindowMode);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comAudio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comVideo);
            this.groupBox3.Location = new System.Drawing.Point(297, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 166);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interface";
            // 
            // comVideo
            // 
            this.comVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comVideo.FormattingEnabled = true;
            this.comVideo.Items.AddRange(new object[] {
            "opengl",
            "debug",
            "ascii",
            "null"});
            this.comVideo.Location = new System.Drawing.Point(62, 28);
            this.comVideo.Name = "comVideo";
            this.comVideo.Size = new System.Drawing.Size(110, 21);
            this.comVideo.TabIndex = 0;
            this.comVideo.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Video";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Audio";
            // 
            // comAudio
            // 
            this.comAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAudio.FormattingEnabled = true;
            this.comAudio.Items.AddRange(new object[] {
            "sdl",
            "null"});
            this.comAudio.Location = new System.Drawing.Point(62, 129);
            this.comAudio.Name = "comAudio";
            this.comAudio.Size = new System.Drawing.Size(110, 21);
            this.comAudio.TabIndex = 2;
            this.comAudio.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // comWindowMode
            // 
            this.comWindowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comWindowMode.FormattingEnabled = true;
            this.comWindowMode.Items.AddRange(new object[] {
            "window",
            "fullscreen"});
            this.comWindowMode.Location = new System.Drawing.Point(62, 55);
            this.comWindowMode.Name = "comWindowMode";
            this.comWindowMode.Size = new System.Drawing.Size(110, 21);
            this.comWindowMode.TabIndex = 4;
            this.comWindowMode.SelectedIndexChanged += new System.EventHandler(this.general_SelectedIndexChanged);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(16, 58);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(34, 13);
            this.Mode.TabIndex = 5;
            this.Mode.Text = "Mode";
            // 
            // txtWindowX
            // 
            this.txtWindowX.Location = new System.Drawing.Point(62, 85);
            this.txtWindowX.Name = "txtWindowX";
            this.txtWindowX.Size = new System.Drawing.Size(44, 20);
            this.txtWindowX.TabIndex = 6;
            this.txtWindowX.Text = "1024";
            this.txtWindowX.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // txtWindowY
            // 
            this.txtWindowY.Location = new System.Drawing.Point(112, 85);
            this.txtWindowY.Name = "txtWindowY";
            this.txtWindowY.Size = new System.Drawing.Size(44, 20);
            this.txtWindowY.TabIndex = 7;
            this.txtWindowY.Text = "768";
            this.txtWindowY.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 409);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chaotic Rage launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindBinary;
        private System.Windows.Forms.Label labBinary;
        private System.Windows.Forms.OpenFileDialog diaFindBinary;
        private System.Windows.Forms.Button btnWorkingDir;
        private System.Windows.Forms.Label labWorkingDir;
        private System.Windows.Forms.FolderBrowserDialog diaWorkingDir;
        private System.Windows.Forms.ComboBox comMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCampaign;
        private System.Windows.Forms.TextBox txtArcadeUnit;
        private System.Windows.Forms.TextBox txtArcadeGame;
        private System.Windows.Forms.TextBox txtArcadeMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJoin;
        private System.Windows.Forms.ComboBox comMod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstDbgGroups;
        private System.Windows.Forms.CheckBox chkDebugLine;
        private System.Windows.Forms.CheckBox chkNoMouse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkThrottle;
        private System.Windows.Forms.CheckBox chkHost;
        private System.Windows.Forms.TextBox txtLoopLimit;
        private System.Windows.Forms.CheckBox chkLoopLimit;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.CheckBox chkProfile;
        private System.Windows.Forms.SaveFileDialog diaProfile;
        private System.Windows.Forms.CheckBox chkDebugFile;
        private System.Windows.Forms.Button btnDebugFile;
        private System.Windows.Forms.SaveFileDialog diaDebugFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comAudio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comVideo;
        private System.Windows.Forms.ComboBox comWindowMode;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWindowY;
        private System.Windows.Forms.TextBox txtWindowX;
    }
}

