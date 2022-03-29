using BaseLib;

namespace DiscordWatch
{
    internal class DiscordWatchProject : BaseProject
    {
        public string ProjectName = "DiscordWatch";

        public DWSettings Settings;
        public DiscordWatchProject() : base()
        {
            string pathToIniSettings = BaseLib.Settings.MakeSettingsPath(ProjectName);
            Settings = new DWSettings(pathToIniSettings);
        }
    }
}
