using System;
using System.IO;
using System.Windows.Forms;

namespace TweakUIX.Helpers
{
    internal class Strings
    {
        public static class Data
        {
            public static string DataRootDir = Application.StartupPath +
                                                @"\app\";
            public static string PluginsRootDir = Application.StartupPath +
                                                @"\app\plugins\";
        }

        public static class Uri
        {
            public const string URL_ASSEMBLY = "https://raw.githubusercontent.com/builtbybel/TweakUIX/main/src/TUIX/Properties/AssemblyInfo.cs";
            public const string URL_TWITTER = "https://twitter.com/builtbybel";
            public const string URL_DONATE = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=donate@builtbybel.com&lc=US&item_name=%20Builtbybel&no_note=0&cn=&currency_code=USD&bn=PP-DonationsBF:btn_donateCC_LG.gif:NonHosted";
            public const string URL_GITREPO = "https://github.com/builtbybel/TweakUIX";
            public const string URL_GITLATEST = URL_GITREPO + "/releases/latest";
        }

        public static class Paths
        {

            public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);
            public static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            public static string AppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            public static string LocalAppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            public static string ShellWT = LocalAppDataDir +
                                            @"\Microsoft\WindowsApps\wt.exe";

            public static string ShellCommandPrompt = SysDir +
                                            @"Windows\System32\cmd.exe";

            public static string ShellPS = SysDir +
                                            @"Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
        }

        // Create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"app");
            if (!dirExists)
                Directory.CreateDirectory(@"app");
        }
    }
}