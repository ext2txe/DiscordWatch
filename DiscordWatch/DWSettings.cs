using BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWatch
{
    internal class DWSettings : Settings
    {
        public DWSettings(string iniPath) : base(iniPath)
        {

        }


        public int MonitorAreaLeft { get => GetInt("MonitorAreaLeft", 387); set => SetInt("MonitorAreaLeft", value); }
        public int MonitorAreaTop { get => GetInt("MonitorAreaTop", 644); set => SetInt("MonitorAreaTop", value); }
        public int MonitorAreaWidth { get => GetInt("MonitorAreaWidth", 211); set => SetInt("MonitorAreaWidth", value); }
        public int MonitorAreaHeight { get => GetInt("MonitorAreaHeight", 148); set => SetInt("MonitorAreaHeight", value); }

        public bool SetTargetWindowSize { get => GetBoolean("SetTargetWindowSize", false); set => SetBoolean("SetTargetWindowSize", value); }
        public int TargetWidth { get => GetInt("TargetWidth", 211); set => SetInt("TargetWidth", value); }
        public int TargetHeight { get => GetInt("TargetHeight", 148); set => SetInt("TargetHeight", value); }


        public string WindowTitle { get => GetString("WindowTitle"); set => SetString("WindowTitle", value); }
        public int TimerInterval { get => GetInt("TimerInterval", 60); set => SetInt("TimerInterval", value); }

        public bool EnableAlert { get => GetBoolean("EnableAlert", false); set => SetBoolean("EnableAlert", value); }
        public string PathToAlertFile { get => GetString("PathToAlertFile"); set => SetString("PathToAlertFile", value); }
        public string ImageSaveFolder { get => GetString("ImageSaveFolder"); set => SetString("ImageSaveFolder", value); }

        
        public string PathToTextImage { get => GetString("PathToTextImage"); set => SetString("PathToTextImage", value); }


        #region automation sample points

        /// <summary>
        /// check all samples in column x
        /// </summary>
        public int SampleAtX { get => GetInt("SampleAtX", 408); set => SetInt("SampleAtX", value); }

        public int Sample1R { get => GetInt("Sample1R", 237); set => SetInt("Sample1R", value); }
        public int Sample1G { get => GetInt("Sample1G", 66); set => SetInt("Sample1G", value); }
        public int Sample1B { get => GetInt("Sample1B", 69); set => SetInt("Sample1B", value); }
        public int Sample1Tolerance { get => GetInt("Sample1Tolerance", 25); set => SetInt("Sample1Tolerance", value); }

        public int Sample2R { get => GetInt("Sample2R", 160); set => SetInt("Sample2R", value); }
        public int Sample2G { get => GetInt("Sample2G", 4); set => SetInt("Sample2G", value); }
        public int Sample2B { get => GetInt("Sample2B", 30); set => SetInt("Sample2B", value); }
        public int Sample2Tolerance { get => GetInt("Sample2Tolerance", 25); set => SetInt("Sample2Tolerance", value); }


        #endregion automation sample points

    }
}
