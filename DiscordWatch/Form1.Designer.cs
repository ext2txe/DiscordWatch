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
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetWidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Location = new System.Drawing.Point(10, 18);
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
            this.cbWindowTitles.Location = new System.Drawing.Point(121, 16);
            this.cbWindowTitles.Name = "cbWindowTitles";
            this.cbWindowTitles.Size = new System.Drawing.Size(543, 28);
            this.cbWindowTitles.TabIndex = 1;
            this.cbWindowTitles.SelectedIndexChanged += new System.EventHandler(this.cbWindowTitles_SelectedIndexChanged);
            // 
            // BtnRefreshWindowTitles
            // 
            this.BtnRefreshWindowTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshWindowTitles.Location = new System.Drawing.Point(670, 14);
            this.BtnRefreshWindowTitles.Name = "BtnRefreshWindowTitles";
            this.BtnRefreshWindowTitles.Size = new System.Drawing.Size(182, 28);
            this.BtnRefreshWindowTitles.TabIndex = 2;
            this.BtnRefreshWindowTitles.Text = "Refresh Window Titles";
            this.BtnRefreshWindowTitles.UseVisualStyleBackColor = true;
            this.BtnRefreshWindowTitles.Click += new System.EventHandler(this.BtnRefreshWindowTitles_Click);
            // 
            // pbScreenShot
            // 
            this.pbScreenShot.Location = new System.Drawing.Point(12, 50);
            this.pbScreenShot.Name = "pbScreenShot";
            this.pbScreenShot.Size = new System.Drawing.Size(652, 552);
            this.pbScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenShot.TabIndex = 3;
            this.pbScreenShot.TabStop = false;
            // 
            // pbSubImage
            // 
            this.pbSubImage.Location = new System.Drawing.Point(687, 199);
            this.pbSubImage.Name = "pbSubImage";
            this.pbSubImage.Size = new System.Drawing.Size(486, 325);
            this.pbSubImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubImage.TabIndex = 4;
            this.pbSubImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // leftUpDown
            // 
            this.leftUpDown.Location = new System.Drawing.Point(756, 116);
            this.leftUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.leftUpDown.Name = "leftUpDown";
            this.leftUpDown.Size = new System.Drawing.Size(80, 26);
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
            this.topUpDown.Location = new System.Drawing.Point(907, 117);
            this.topUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.topUpDown.Name = "topUpDown";
            this.topUpDown.Size = new System.Drawing.Size(80, 26);
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
            this.label2.Location = new System.Drawing.Point(869, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(907, 161);
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
            this.heightUpDown.Size = new System.Drawing.Size(80, 26);
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
            this.label3.Location = new System.Drawing.Point(849, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(756, 160);
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
            this.widthUpDown.Size = new System.Drawing.Size(80, 26);
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
            this.label4.Location = new System.Drawing.Point(697, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Width";
            // 
            // BtnRefreshSubImage
            // 
            this.BtnRefreshSubImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshSubImage.Location = new System.Drawing.Point(1007, 162);
            this.BtnRefreshSubImage.Name = "BtnRefreshSubImage";
            this.BtnRefreshSubImage.Size = new System.Drawing.Size(167, 28);
            this.BtnRefreshSubImage.TabIndex = 13;
            this.BtnRefreshSubImage.Text = "Refresh Sub Image";
            this.BtnRefreshSubImage.UseVisualStyleBackColor = true;
            this.BtnRefreshSubImage.Click += new System.EventHandler(this.BtnRefreshSubImage_Click);
            // 
            // timerIntervalUpDown
            // 
            this.timerIntervalUpDown.Location = new System.Drawing.Point(589, 608);
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
            this.chkEnableTimer.AutoSize = true;
            this.chkEnableTimer.Location = new System.Drawing.Point(386, 608);
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
            this.textSubImageHash.Location = new System.Drawing.Point(804, 535);
            this.textSubImageHash.Name = "textSubImageHash";
            this.textSubImageHash.Size = new System.Drawing.Size(369, 26);
            this.textSubImageHash.TabIndex = 17;
            this.textSubImageHash.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "SubImage Hash";
            // 
            // targetHeightUpDown
            // 
            this.targetHeightUpDown.Location = new System.Drawing.Point(997, 51);
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
            this.label6.Location = new System.Drawing.Point(890, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Target Height";
            // 
            // targetWidthUpDown
            // 
            this.targetWidthUpDown.Location = new System.Drawing.Point(797, 50);
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
            this.label7.Location = new System.Drawing.Point(697, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Target Width";
            // 
            // textAlertSoundFile
            // 
            this.textAlertSoundFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlertSoundFile.Location = new System.Drawing.Point(804, 579);
            this.textAlertSoundFile.Name = "textAlertSoundFile";
            this.textAlertSoundFile.Size = new System.Drawing.Size(336, 26);
            this.textAlertSoundFile.TabIndex = 24;
            this.textAlertSoundFile.TextChanged += new System.EventHandler(this.textAlertSoundFile_TextChanged);
            // 
            // chkEnableAlert
            // 
            this.chkEnableAlert.AutoSize = true;
            this.chkEnableAlert.Location = new System.Drawing.Point(682, 580);
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
            this.BtnSelectSoundFile.Location = new System.Drawing.Point(1146, 578);
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
            this.BtnTestAlert.Location = new System.Drawing.Point(1102, 612);
            this.BtnTestAlert.Name = "BtnTestAlert";
            this.BtnTestAlert.Size = new System.Drawing.Size(71, 28);
            this.BtnTestAlert.TabIndex = 26;
            this.BtnTestAlert.Text = "Test";
            this.BtnTestAlert.UseVisualStyleBackColor = true;
            this.BtnTestAlert.Click += new System.EventHandler(this.BtnTestAlert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 695);
            this.Controls.Add(this.BtnTestAlert);
            this.Controls.Add(this.BtnSelectSoundFile);
            this.Controls.Add(this.textAlertSoundFile);
            this.Controls.Add(this.chkEnableAlert);
            this.Controls.Add(this.targetHeightUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.targetWidthUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSubImageHash);
            this.Controls.Add(this.chkEnableTimer);
            this.Controls.Add(this.timerIntervalUpDown);
            this.Controls.Add(this.BtnRefreshSubImage);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leftUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSubImage);
            this.Controls.Add(this.pbScreenShot);
            this.Controls.Add(this.BtnRefreshWindowTitles);
            this.Controls.Add(this.cbWindowTitles);
            this.Controls.Add(this.lblWindowTitle);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

