namespace DiscordWatch
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.cbWindowTitles = new System.Windows.Forms.ComboBox();
            this.BtnRefreshWindowTitles = new System.Windows.Forms.Button();
            this.pbScreenShot = new System.Windows.Forms.PictureBox();
            this.pbSubImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftUpDown = new System.Windows.Forms.NumericUpDown();
            this.topUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRefreshSubImage = new System.Windows.Forms.Button();
            this.timerIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.chkEnableTimer = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textSubImageHash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.targetWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textAlertSoundFile = new System.Windows.Forms.TextBox();
            this.chkEnableAlert = new System.Windows.Forms.CheckBox();
            this.BtnSelectSoundFile = new System.Windows.Forms.Button();
            this.BtnTestAlert = new System.Windows.Forms.Button();
            this.BtnSelectImageSaveFolder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textImageSaveFolder = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnOpenSaveFolder = new System.Windows.Forms.Button();
            this.lblLastChecked = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetWidthUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Location = new System.Drawing.Point(4, 10);
            this.lblWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(98, 20);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "Window Title";
            // 
            // cbWindowTitles
            // 
            this.cbWindowTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWindowTitles.FormattingEnabled = true;
            this.cbWindowTitles.Location = new System.Drawing.Point(109, 8);
            this.cbWindowTitles.Name = "cbWindowTitles";
            this.cbWindowTitles.Size = new System.Drawing.Size(416, 28);
            this.cbWindowTitles.TabIndex = 1;
            this.cbWindowTitles.SelectedIndexChanged += new System.EventHandler(this.cbWindowTitles_SelectedIndexChanged);
            // 
            // BtnRefreshWindowTitles
            // 
            this.BtnRefreshWindowTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshWindowTitles.Location = new System.Drawing.Point(531, 10);
            this.BtnRefreshWindowTitles.Name = "BtnRefreshWindowTitles";
            this.BtnRefreshWindowTitles.Size = new System.Drawing.Size(182, 28);
            this.BtnRefreshWindowTitles.TabIndex = 2;
            this.BtnRefreshWindowTitles.Text = "Refresh Window Titles";
            this.BtnRefreshWindowTitles.UseVisualStyleBackColor = true;
            this.BtnRefreshWindowTitles.Click += new System.EventHandler(this.BtnRefreshWindowTitles_Click);
            // 
            // pbScreenShot
            // 
            this.pbScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreenShot.Location = new System.Drawing.Point(6, 42);
            this.pbScreenShot.Name = "pbScreenShot";
            this.pbScreenShot.Size = new System.Drawing.Size(707, 552);
            this.pbScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenShot.TabIndex = 3;
            this.pbScreenShot.TabStop = false;
            // 
            // pbSubImage
            // 
            this.pbSubImage.Location = new System.Drawing.Point(10, 39);
            this.pbSubImage.Name = "pbSubImage";
            this.pbSubImage.Size = new System.Drawing.Size(703, 503);
            this.pbSubImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubImage.TabIndex = 4;
            this.pbSubImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // leftUpDown
            // 
            this.leftUpDown.Location = new System.Drawing.Point(52, 6);
            this.leftUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.leftUpDown.Name = "leftUpDown";
            this.leftUpDown.Size = new System.Drawing.Size(55, 26);
            this.leftUpDown.TabIndex = 6;
            this.leftUpDown.Value = new decimal(new int[] {
            387,
            0,
            0,
            0});
            this.leftUpDown.ValueChanged += new System.EventHandler(this.leftUpDown_ValueChanged);
            // 
            // topUpDown
            // 
            this.topUpDown.Location = new System.Drawing.Point(161, 6);
            this.topUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.topUpDown.Name = "topUpDown";
            this.topUpDown.Size = new System.Drawing.Size(55, 26);
            this.topUpDown.TabIndex = 8;
            this.topUpDown.Value = new decimal(new int[] {
            644,
            0,
            0,
            0});
            this.topUpDown.ValueChanged += new System.EventHandler(this.leftUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(457, 7);
            this.heightUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(55, 26);
            this.heightUpDown.TabIndex = 12;
            this.heightUpDown.Value = new decimal(new int[] {
            148,
            0,
            0,
            0});
            this.heightUpDown.ValueChanged += new System.EventHandler(this.leftUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(306, 6);
            this.widthUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(55, 26);
            this.widthUpDown.TabIndex = 10;
            this.widthUpDown.Value = new decimal(new int[] {
            211,
            0,
            0,
            0});
            this.widthUpDown.ValueChanged += new System.EventHandler(this.leftUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Width";
            // 
            // BtnRefreshSubImage
            // 
            this.BtnRefreshSubImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshSubImage.Location = new System.Drawing.Point(546, 8);
            this.BtnRefreshSubImage.Name = "BtnRefreshSubImage";
            this.BtnRefreshSubImage.Size = new System.Drawing.Size(167, 28);
            this.BtnRefreshSubImage.TabIndex = 13;
            this.BtnRefreshSubImage.Text = "Refresh Sub Image";
            this.BtnRefreshSubImage.UseVisualStyleBackColor = true;
            this.BtnRefreshSubImage.Click += new System.EventHandler(this.BtnRefreshSubImage_Click);
            // 
            // timerIntervalUpDown
            // 
            this.timerIntervalUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timerIntervalUpDown.Location = new System.Drawing.Point(631, 601);
            this.timerIntervalUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.timerIntervalUpDown.Name = "timerIntervalUpDown";
            this.timerIntervalUpDown.Size = new System.Drawing.Size(80, 26);
            this.timerIntervalUpDown.TabIndex = 15;
            this.timerIntervalUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timerIntervalUpDown.ValueChanged += new System.EventHandler(this.timerIntervalUpDown_ValueChanged);
            // 
            // chkEnableTimer
            // 
            this.chkEnableTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnableTimer.AutoSize = true;
            this.chkEnableTimer.Location = new System.Drawing.Point(428, 601);
            this.chkEnableTimer.Name = "chkEnableTimer";
            this.chkEnableTimer.Size = new System.Drawing.Size(197, 24);
            this.chkEnableTimer.TabIndex = 16;
            this.chkEnableTimer.Text = "Timer Interval (seconds)";
            this.chkEnableTimer.UseVisualStyleBackColor = true;
            this.chkEnableTimer.CheckedChanged += new System.EventHandler(this.chkEnableTimer_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textSubImageHash
            // 
            this.textSubImageHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSubImageHash.Location = new System.Drawing.Point(151, 548);
            this.textSubImageHash.Name = "textSubImageHash";
            this.textSubImageHash.Size = new System.Drawing.Size(539, 26);
            this.textSubImageHash.TabIndex = 17;
            this.textSubImageHash.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "SubImage Hash";
            // 
            // targetHeightUpDown
            // 
            this.targetHeightUpDown.Location = new System.Drawing.Point(309, 600);
            this.targetHeightUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.targetHeightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetHeightUpDown.Name = "targetHeightUpDown";
            this.targetHeightUpDown.Size = new System.Drawing.Size(80, 26);
            this.targetHeightUpDown.TabIndex = 22;
            this.targetHeightUpDown.Value = new decimal(new int[] {
            148,
            0,
            0,
            0});
            this.targetHeightUpDown.ValueChanged += new System.EventHandler(this.targetHeightUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Target Height";
            // 
            // targetWidthUpDown
            // 
            this.targetWidthUpDown.Location = new System.Drawing.Point(109, 599);
            this.targetWidthUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.targetWidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetWidthUpDown.Name = "targetWidthUpDown";
            this.targetWidthUpDown.Size = new System.Drawing.Size(80, 26);
            this.targetWidthUpDown.TabIndex = 20;
            this.targetWidthUpDown.Value = new decimal(new int[] {
            211,
            0,
            0,
            0});
            this.targetWidthUpDown.ValueChanged += new System.EventHandler(this.targetWidthUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Target Width";
            // 
            // textAlertSoundFile
            // 
            this.textAlertSoundFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlertSoundFile.Location = new System.Drawing.Point(150, 583);
            this.textAlertSoundFile.Name = "textAlertSoundFile";
            this.textAlertSoundFile.Size = new System.Drawing.Size(430, 26);
            this.textAlertSoundFile.TabIndex = 24;
            this.textAlertSoundFile.TextChanged += new System.EventHandler(this.textAlertSoundFile_TextChanged);
            // 
            // chkEnableAlert
            // 
            this.chkEnableAlert.AutoSize = true;
            this.chkEnableAlert.Location = new System.Drawing.Point(29, 581);
            this.chkEnableAlert.Name = "chkEnableAlert";
            this.chkEnableAlert.Size = new System.Drawing.Size(115, 24);
            this.chkEnableAlert.TabIndex = 23;
            this.chkEnableAlert.Text = "Enable Alert";
            this.chkEnableAlert.UseVisualStyleBackColor = true;
            this.chkEnableAlert.CheckedChanged += new System.EventHandler(this.chkEnableAlert_CheckedChanged);
            // 
            // BtnSelectSoundFile
            // 
            this.BtnSelectSoundFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectSoundFile.Location = new System.Drawing.Point(586, 580);
            this.BtnSelectSoundFile.Name = "BtnSelectSoundFile";
            this.BtnSelectSoundFile.Size = new System.Drawing.Size(27, 28);
            this.BtnSelectSoundFile.TabIndex = 25;
            this.BtnSelectSoundFile.Text = "..";
            this.BtnSelectSoundFile.UseVisualStyleBackColor = true;
            this.BtnSelectSoundFile.Click += new System.EventHandler(this.BtnSelectSoundFile_Click);
            // 
            // BtnTestAlert
            // 
            this.BtnTestAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTestAlert.Location = new System.Drawing.Point(619, 581);
            this.BtnTestAlert.Name = "BtnTestAlert";
            this.BtnTestAlert.Size = new System.Drawing.Size(71, 28);
            this.BtnTestAlert.TabIndex = 26;
            this.BtnTestAlert.Text = "Test";
            this.BtnTestAlert.UseVisualStyleBackColor = true;
            this.BtnTestAlert.Click += new System.EventHandler(this.BtnTestAlert_Click);
            // 
            // BtnSelectImageSaveFolder
            // 
            this.BtnSelectImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectImageSaveFolder.Location = new System.Drawing.Point(586, 615);
            this.BtnSelectImageSaveFolder.Name = "BtnSelectImageSaveFolder";
            this.BtnSelectImageSaveFolder.Size = new System.Drawing.Size(27, 28);
            this.BtnSelectImageSaveFolder.TabIndex = 29;
            this.BtnSelectImageSaveFolder.Text = "..";
            this.BtnSelectImageSaveFolder.UseVisualStyleBackColor = true;
            this.BtnSelectImageSaveFolder.Click += new System.EventHandler(this.BtnSelectImageSaveFolder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 618);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Image Save Folder";
            // 
            // textImageSaveFolder
            // 
            this.textImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textImageSaveFolder.Location = new System.Drawing.Point(150, 615);
            this.textImageSaveFolder.Name = "textImageSaveFolder";
            this.textImageSaveFolder.Size = new System.Drawing.Size(430, 26);
            this.textImageSaveFolder.TabIndex = 27;
            this.textImageSaveFolder.TextChanged += new System.EventHandler(this.textImageSaveFolder_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 695);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLastChecked);
            this.tabPage1.Controls.Add(this.pbScreenShot);
            this.tabPage1.Controls.Add(this.BtnRefreshWindowTitles);
            this.tabPage1.Controls.Add(this.lblWindowTitle);
            this.tabPage1.Controls.Add(this.cbWindowTitles);
            this.tabPage1.Controls.Add(this.timerIntervalUpDown);
            this.tabPage1.Controls.Add(this.chkEnableTimer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.targetHeightUpDown);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.targetWidthUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnOpenSaveFolder);
            this.tabPage2.Controls.Add(this.pbSubImage);
            this.tabPage2.Controls.Add(this.BtnSelectImageSaveFolder);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.leftUpDown);
            this.tabPage2.Controls.Add(this.textImageSaveFolder);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnTestAlert);
            this.tabPage2.Controls.Add(this.topUpDown);
            this.tabPage2.Controls.Add(this.BtnSelectSoundFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textAlertSoundFile);
            this.tabPage2.Controls.Add(this.chkEnableAlert);
            this.tabPage2.Controls.Add(this.widthUpDown);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textSubImageHash);
            this.tabPage2.Controls.Add(this.heightUpDown);
            this.tabPage2.Controls.Add(this.BtnRefreshSubImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnOpenSaveFolder
            // 
            this.BtnOpenSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenSaveFolder.Location = new System.Drawing.Point(619, 618);
            this.BtnOpenSaveFolder.Name = "BtnOpenSaveFolder";
            this.BtnOpenSaveFolder.Size = new System.Drawing.Size(71, 28);
            this.BtnOpenSaveFolder.TabIndex = 30;
            this.BtnOpenSaveFolder.Text = "Open";
            this.BtnOpenSaveFolder.UseVisualStyleBackColor = true;
            // 
            // lblLastChecked
            // 
            this.lblLastChecked.AutoSize = true;
            this.lblLastChecked.Location = new System.Drawing.Point(605, 630);
            this.lblLastChecked.Name = "lblLastChecked";
            this.lblLastChecked.Size = new System.Drawing.Size(93, 20);
            this.lblLastChecked.TabIndex = 23;
            this.lblLastChecked.Text = "Last Check:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 695);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetWidthUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.ComboBox cbWindowTitles;
        private System.Windows.Forms.Button BtnRefreshWindowTitles;
        private System.Windows.Forms.PictureBox pbScreenShot;
        private System.Windows.Forms.PictureBox pbSubImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown leftUpDown;
        private System.Windows.Forms.NumericUpDown topUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRefreshSubImage;
        private System.Windows.Forms.NumericUpDown timerIntervalUpDown;
        private System.Windows.Forms.CheckBox chkEnableTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textSubImageHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown targetHeightUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown targetWidthUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAlertSoundFile;
        private System.Windows.Forms.CheckBox chkEnableAlert;
        private System.Windows.Forms.Button BtnSelectSoundFile;
        private System.Windows.Forms.Button BtnTestAlert;
        private System.Windows.Forms.Button BtnSelectImageSaveFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textImageSaveFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnOpenSaveFolder;
        private System.Windows.Forms.Label lblLastChecked;
    }
}

