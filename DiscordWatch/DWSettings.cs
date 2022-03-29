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

        public int TargetWidth { get => GetInt("TargetWidth", 211); set => SetInt("TargetWidth", value); }
        public int TargetHeight { get => GetInt("TargetHeight", 148); set => SetInt("TargetHeight", value); }


        public string WindowTitle { get => GetString("WindowTitle"); set => SetString("WindowTitle", value); }
        public int TimerInterval { get => GetInt("TimerInterval", 60); set => SetInt("TimerInterval", value); }

        public bool EnableAlert { get => GetBoolean("EnableAlert", false); set => SetBoolean("EnableAlert", value); }
        public string PathToAlertFile { get => GetString("PathToAlertFile"); set => SetString("PathToAlertFile", value); }
    }
}
