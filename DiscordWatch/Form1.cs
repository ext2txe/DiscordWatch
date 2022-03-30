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

        private SystemWindow _wTarget = null;

        private bool _isStarting = true;
        private Stopwatch _stopwatch;

        private List<byte> colorList = new List<byte>();
        private string hash;

        private SHA1Managed _sha = new SHA1Managed();

        private string _lastHash = "";

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
            BaseUtils.GeometryFromString(_settings.WindowGeometry, this);

            leftUpDown.Value = _settings.MonitorAreaLeft;
            topUpDown.Value = _settings.MonitorAreaTop;
            widthUpDown.Value = _settings.MonitorAreaWidth;
            heightUpDown.Value = _settings.MonitorAreaHeight;
            
            targetWidthUpDown.Value = _settings.TargetWidth;
            targetHeightUpDown.Value = _settings.TargetHeight;
            chkSetTargetWindowSize.Checked = _settings.SetTargetWindowSize;
            if (_settings.SetTargetWindowSize)
            {
                BtnSetWindowSize_Click(null, null);
            }
            
            chkEnableAlert.Checked = _settings.EnableAlert;
            textAlertSoundFile.Text = _settings.PathToAlertFile;
            
            textImageSaveFolder.Text = _settings.ImageSaveFolder;
            timerIntervalUpDown.Value = _settings.TimerInterval;

            TextPathToTestImage.Text = _settings.PathToTextImage;

            cbWindowTitles.Text = _settings.WindowTitle;

            sampleXUpDown.Value = _settings.SampleAtX;
            r1UpDown.Value = _settings.Sample1R;
            g1UpDown.Value = _settings.Sample1G;
            b1UpDown.Value = _settings.Sample1B;
            tolerance1UpDown.Value = _settings.Sample1Tolerance;
            r2UpDown.Value = _settings.Sample2R;
            g2UpDown.Value = _settings.Sample2G;
            b2UpDown.Value = _settings.Sample2B;
            tolerance2UpDown.Value = _settings.Sample2Tolerance;

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

            _wTarget = (SystemWindow)WinUtils.GetSystemWindowByExactTitle(cbWindowTitles.Text);
            DisplayScreenshot(_wTarget);
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
            _wTarget = WinUtils.GetSystemWindowByExactTitle(cbWindowTitles.Text);
            DisplayScreenshot(_wTarget);
            Bitmap clone = (Bitmap)pbSubImage.Image.Clone();
            string hash = GetImageHash(clone);
            textSubImageHash.Text = hash;
            textSubImageHash.Refresh();
            lblLastChecked.Text = DateTime.Now.ToString("HHmmss.fff");
            lblLastChecked.Refresh();

            Point? pClickAt = Test2();

            if (pClickAt != null)
            {
                Point p = (Point)pClickAt;
                GenUtils.DoMouseClickInWindowAtXY(_wTarget, p.X, p.Y);
                string bmpFilename = $"{DateTime.Now.ToString("yyyyMMddhhmmss.fff")}_discord.jpg";
                bmpFilename = Path.Combine(_settings.ImageSaveFolder, bmpFilename);
                _discordScreenshot.Save(bmpFilename);
                _lastHash = hash;
                SoundAlert();
                chkEnableAlert.Checked = false;
            }

            if (!hash.Equals(_lastHash))
            {
                string bmpFilename = $"{DateTime.Now.ToString("yyyyMMddhhmmss.fff")}_discord#.jpg";
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

        #region Window Size events
        private void targetWidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.TargetWidth = pbScreenShot.Width;
        }

        private void targetHeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.TargetHeight = pbScreenShot.Height;
        }

        private void chkSetTargetWindowSize_CheckedChanged(object sender, EventArgs e)
        {
            _settings.SetTargetWindowSize = chkSetTargetWindowSize.Checked;
        }

        private void BtnSetWindowSize_Click(object sender, EventArgs e)
        {
            _wTarget = WinUtils.GetSystemWindowByTitle(cbWindowTitles.Text);
            if (_wTarget != null)
            {
                _wTarget.Size = new Size((int) targetWidthUpDown.Value, (int) targetHeightUpDown.Value);
            }
        }
        #endregion Window Size events

        #region test image events

        private void TextPathToTestImage_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(TextPathToTestImage.Text)) return;

            _settings.PathToTextImage = TextPathToTestImage.Text;
            LoadTestImage();
        }

        private void LoadTestImage()
        {
            int step = 10;
            try
            {
                Bitmap bmp = new Bitmap(_settings.PathToTextImage);
                pbTestImage.Image = bmp;
                pbTestImage.Refresh();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        private void BtnSelectTestImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = TextPathToTestImage.Text;
            if (open.ShowDialog() == DialogResult.OK)
            {
                TextPathToTestImage.Text = open.FileName;
                TextPathToTestImage.Refresh();
            }
        }

        private void BtnOpenTestImage_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TextPathToTestImage.Text)) return;

            Process.Start(TextPathToTestImage.Text);


        }
        #endregion test image events

        #region sample settings
        private void sampleXUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.SampleAtX = (int) sampleXUpDown.Value;
        }

        private void r1UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample1R = (int) r1UpDown.Value;
        }

        private void g1UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample1G = (int)g1UpDown.Value;
        }

        private void b1UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample1B = (int)b1UpDown.Value;
        }

        private void tolerance1UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample1Tolerance = (int)tolerance1UpDown.Value;
        }

        private void r2UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample2R = (int)r2UpDown.Value;
        }

        private void g2UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample2G = (int)g2UpDown.Value;
        }

        private void b2UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample2B = (int)b2UpDown.Value;
        }

        private void tolerance2UpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.Sample2Tolerance = (int)tolerance2UpDown.Value;
        }
        #endregion sample settings

        private void BtnSampleTest1_Click(object sender, EventArgs e)
        {
            Point? p = Test1();
            if (p != null)
            {
                MessageBox.Show($" Unread messages divider found at {((Point)p).Y}");
            }
            else
            {
                MessageBox.Show($" Unread messages divider NOT found");
            }
        }

        private Point? Test1()
        {
            int step = 10;
            try
            {
                Bitmap bmpTest = new Bitmap(TextPathToTestImage.Text);
                step = 20;
                if (chkEnableTimer.Checked)  // use live image
                {
                    bmpTest = WinUtils.WindowImageFast(_wTarget);
                }

                int x = _settings.SampleAtX;
                step = 30;
                Color referenceColor = Color.FromArgb(_settings.Sample1R, _settings.Sample1G, _settings.Sample1B);
                step = 40;
                for (int y=0; y < bmpTest.Height - 1; y++)
                {
                    step = 50;
                    Color sampleColor = bmpTest.GetPixel(x, y);
                    step = 60;
                    int difference = (int) BitmapUtils.GetDifference(sampleColor, referenceColor);
                    step = 70;
                    if (difference < _settings.Sample1Tolerance)
                    {
                        if (TestSampleAt(bmpTest, x + 20, y, referenceColor))
                        {
                            return new Point(x, y);
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                string s = $"Test1() @[{step}] EXCEPTION [{ex.Message}";
                throw new Exception(s);
            }
        }

        private bool TestSampleAt(Bitmap bmp, int x, int y, Color referenceColor)
        {
            int step = 10;
            try
            {
                step = 50;
                Color sampleColor = bmp.GetPixel(x, y);
                step = 60;
                int difference = (int)BitmapUtils.GetDifference(sampleColor, referenceColor);
                step = 70;
                if (difference < _settings.Sample1Tolerance)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string s = $"TestSampleAt() @[{step}] EXCEPTION [{ex.Message}";
                throw new Exception(s);
            }

        }

        private void BtnTest2_Click(object sender, EventArgs e)
        {
            Point? clickPoint = Test2();
            if (clickPoint != null)
            {
                Point p = (Point)clickPoint;
                MessageBox.Show($" Tada found at {p.X}.{p.Y}");
            }
            else
            {
                MessageBox.Show($" Tada NOT found");
            }
        }

        private Point? Test2()
        {
            int step = 10;
            try
            {
                Point? pTest1 = Test1();
                if (pTest1 == null) return null;

                Point pStart = (Point)pTest1;


                Bitmap bmpTest = new Bitmap(TextPathToTestImage.Text);
                step = 20;
                if (chkEnableTimer.Checked)  // use live image
                {
                    bmpTest = WinUtils.WindowImageFast(_wTarget);
                }
                int x = pStart.X;
                step = 30;
                Color referenceColor = Color.FromArgb(_settings.Sample2R, _settings.Sample2G, _settings.Sample2B);
                step = 40;
                for (int y = pStart.Y + 1; y < bmpTest.Height - 1; y++)
                {
                    step = 50;
                    Color sampleColor = bmpTest.GetPixel(x, y);
                    step = 60;
                    int difference = (int)BitmapUtils.GetDifference(sampleColor, referenceColor);
                    step = 70;
                    if (difference < _settings.Sample2Tolerance)
                    {
                        if (TestSampleAt(bmpTest, x, y+1, referenceColor))
                        {
                            return new Point(x,y);
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                string s = $"Test1() @[{step}] EXCEPTION [{ex.Message}";
                throw new Exception(s);
            }
        }
    }
}
