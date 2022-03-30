using BaseLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using SysWinLib;

namespace DiscordWatch
{
    public partial class Form1 : Form
    {
        private Logger _logger;
        private List<string> _desktopWindowNames = new List<string>();
        private List<SystemWindow> _sysWindows = new List<SystemWindow>();
        private List<string> _windowsSkipList = new List<string>();

        private DiscordWatchProject _project;
        private DWSettings _settings;

        private bool _isStarting = true;

        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void Startup()
        { 
            _project = new DiscordWatchProject();
            _settings = _project.Settings;
            LoadSettings();
            RefreshWindowTitles();
            cbWindowTitles.Text = _settings.WindowTitle;
            _isStarting = false;
        }

        private void LoadSettings()
        {
            leftUpDown.Value = _settings.MonitorAreaLeft;
            topUpDown.Value = _settings.MonitorAreaTop;
            widthUpDown.Value = _settings.MonitorAreaWidth;
            heightUpDown.Value = _settings.MonitorAreaHeight;
            targetWidthUpDown.Value = _settings.TargetWidth;
            targetHeightUpDown.Value = _settings.TargetHeight;  
            chkEnableAlert.Checked = _settings.EnableAlert;
            textAlertSoundFile.Text = _settings.PathToAlertFile;
            textImageSaveFolder.Text = _settings.ImageSaveFolder;
            timerIntervalUpDown.Value = _settings.TimerInterval;

            cbWindowTitles.Text = _settings.WindowTitle;
            BaseUtils.GeometryFromString(_settings.WindowGeometry, this);
        }

        private void BtnRefreshWindowTitles_Click(object sender, EventArgs e)
        {
            string selectedWindowTitle = cbWindowTitles.Text;
            RefreshWindowTitles();
            int index = cbWindowTitles.Items.IndexOf(selectedWindowTitle);
            cbWindowTitles.SelectedIndex = index;

        }

        private void RefreshWindowTitles()
        {
            cbWindowTitles.Items.Clear();
            if (_windowsSkipList == null || _windowsSkipList.Count == 0)
            {
                _windowsSkipList = WinUtils.WindowSkipList();
            }
            _sysWindows = WinUtils.GetVisibleWindowList(_windowsSkipList);
            foreach (SystemWindow w in _sysWindows)
            {
                cbWindowTitles.Items.Add(w.Title);
            }
        }

        private void cbWindowTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.WindowTitle = cbWindowTitles.Text;

            SystemWindow w = (SystemWindow)WinUtils.GetSystemWindowByExactTitle(cbWindowTitles.Text);
            DisplayScreenshot(w);
        }

        private Bitmap _discordScreenshot = null;
        private void DisplayScreenshot(SystemWindow w)
        {
            int step = 10;
            try
            {
                pbScreenShot.Image = null;
                pbScreenShot.Refresh();

                step = 20;
                _discordScreenshot = WinUtils.WindowImageFast(w);
                step = 30;
                if (_discordScreenshot != null)
                {
                    step = 40;
                    pbScreenShot.Image = (Bitmap)_discordScreenshot.Clone();
                    pbScreenShot.Refresh();
                }
                step = 50;
                RefreshSubImage();
            }
            catch (Exception ex)
            {
                string s = $"DisplayScreenshot(w) @[{step}] EXCEPTION [{ex.Message}]";
                MessageBox.Show(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_isStarting) return; 

            _settings.MonitorAreaLeft = (int) leftUpDown.Value;
            _settings.MonitorAreaTop = (int)topUpDown.Value;
            _settings.MonitorAreaWidth = (int)widthUpDown.Value;
            _settings.MonitorAreaHeight = (int)heightUpDown.Value;

            RefreshSubImage();
        }

        private void RefreshSubImage()
        { 

            int l = (int)leftUpDown.Value;
            int t = (int)topUpDown.Value;
            int w = (int)widthUpDown.Value;
            int h = (int)heightUpDown.Value;

            Rectangle r = new Rectangle(l, t, w, h);
            
            pbSubImage.Image = null;
            pbSubImage.Refresh();

            Bitmap copy = (Bitmap) pbScreenShot.Image;
            if (copy != null)
            {
                Bitmap subImage = copy.Clone(r, copy.PixelFormat);
                pbSubImage.Image = subImage;
                pbSubImage.Refresh();

                
            }

        }

        private void BtnRefreshSubImage_Click(object sender, EventArgs e)
        {
            leftUpDown_ValueChanged(sender, e);
        }

        private void chkEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int) timerIntervalUpDown.Value * 1000;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = (chkEnableTimer.Checked);

            if (chkEnableTimer.Checked)
            {
                timer1_Tick(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SystemWindow w = WinUtils.GetSystemWindowByExactTitle(cbWindowTitles.Text);
            DisplayScreenshot(w);
            Bitmap clone = (Bitmap)pbSubImage.Image.Clone();
            string hash = GetImageHash(clone);
            textSubImageHash.Text = hash;
            textSubImageHash.Refresh();
            lblLastChecked.Text = DateTime.Now.ToString("HHmmss.fff");
            lblLastChecked.Refresh();

            if (!hash.Equals(_lastHash))
            {
                string bmpFilename = $"{DateTime.Now.ToString("yyyyMMddhhmmss.fff")}_discord.jpg";
                bmpFilename = Path.Combine(_settings.ImageSaveFolder, bmpFilename);
                _discordScreenshot.Save(bmpFilename);
                _lastHash = hash;
                SoundAlert();
            }
            timer1.Enabled = chkEnableTimer.Checked;
        }

        private void SoundAlert()
        {
            if (chkEnableAlert.Checked)
            {
                if (File.Exists(_settings.PathToAlertFile))
                {
                    BaseUtils.PlaySound(_settings.PathToAlertFile);
                }
            }
        }


        //private string MakeChecksumFileName(string fileName, Bitmap bmp)
        //{
        //    int step = 10;
        //    try
        //    {
        //        if (_stopwatch == null) _stopwatch = new Stopwatch();

        //        _stopwatch.Restart();
        //        string hash = GetImageHash(bmp);
        //        _stopwatch.Stop();

        //        string sampleText = GetTextFromFileName(fileName);
        //        string extension = Path.GetExtension(fileName);

        //        string checksumFileName = $"{hash}_{sampleText}{extension}";
        //        checksumFileName = Path.Combine(_checksumFolder, checksumFileName);

        //        return checksumFileName;
        //    }
        //    catch (Exception ex1)
        //    {
        //        string msg = $"MakeChecksumFileName(): @ [{step}]: EXCEPTION [{ex1.Message}]";
        //        throw new Exception(msg);

        //    }

        //}

        private Stopwatch _stopwatch;

        private List<byte> colorList = new List<byte>();
        private string hash;

        private SHA1Managed _sha = new SHA1Managed();

        private string _lastHash = "";
        private string GetImageHash(Bitmap bmpSource)
        {
            colorList.Clear();
            int i, j;
            using (Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16))) //create new image with 16x16 pixel
            {
                for (j = 0; j < bmpMin.Height; j++)
                {
                    for (i = 0; i < bmpMin.Width; i++)
                    {
                        colorList.Add(bmpMin.GetPixel(i, j).R);
                    }
                }
                //_sha = new SHA1Managed();
                byte[] checksum = _sha.ComputeHash(colorList.ToArray());
                hash = BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
            //bmpMin.Dispose();
            return hash;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerIntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.TimerInterval = (int) timerIntervalUpDown.Value;
            timer1.Interval = _settings.TimerInterval * 1000;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.WindowGeometry = BaseUtils.GeometryToString(this);

            _settings.MonitorAreaLeft = (int)leftUpDown.Value;
            _settings.MonitorAreaTop = (int)topUpDown.Value;
            _settings.MonitorAreaWidth = (int)widthUpDown.Value;
            _settings.MonitorAreaHeight = (int)heightUpDown.Value;

        }

        private void targetWidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.TargetWidth = pbScreenShot.Width;
        }

        private void targetHeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.TargetHeight = pbScreenShot.Height;
        }

        private void BtnSelectSoundFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = textAlertSoundFile.Text;
            if (open.ShowDialog() == DialogResult.OK)
            {
                textAlertSoundFile.Text = open.FileName;
                textAlertSoundFile.Refresh();
            }
        }

        private void chkEnableAlert_CheckedChanged(object sender, EventArgs e)
        {
            _settings.EnableAlert = chkEnableAlert.Checked;
        }

        private void BtnTestAlert_Click(object sender, EventArgs e)
        {
            if (File.Exists(_settings.PathToAlertFile))
            {
                BaseUtils.PlaySound(_settings.PathToAlertFile);
            }
        }

        private void textAlertSoundFile_TextChanged(object sender, EventArgs e)
        {
            _settings.PathToAlertFile = textAlertSoundFile.Text;
        }

        private void BtnSelectImageSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = textImageSaveFolder.Text;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textImageSaveFolder.Text = folder.SelectedPath;
                textImageSaveFolder.Refresh();
            }
        }

        private void textImageSaveFolder_TextChanged(object sender, EventArgs e)
        {
            _settings.ImageSaveFolder = textImageSaveFolder.Text;
        }
    }
}
