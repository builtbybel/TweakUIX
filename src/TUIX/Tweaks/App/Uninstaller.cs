using System.IO;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace TweakUIX.Tweaks.App
{
    internal class Uninstaller : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private static string appsList = Helpers.Strings.Data.DataRootDir + "uninstaller.app";

        public override string ID()
        {
            return "*Remove bloatware apps (community list)";
        }

        public override string Info()
        {
            return "Click [Check] to display a list of apps that will be removed.";
        }

        internal static string Normalize(string line)
        {
            return Regex.Replace(line, @"\s{2,}", " ");
        }

        public override bool CheckTweak()
        {
            try
            {
                logger.Log("The following apps will be uninstalled:");

                string[] apps = File.ReadAllLines(appsList);

                foreach (var currentApp in apps)
                {
                    if (!currentApp.StartsWith("#") && (!string.IsNullOrEmpty(currentApp)))
                    {
                        logger.Log("- [App] " + currentApp.ToString());
                    }
                }
            }
            catch
            {
                logger.Log("Feature not available. Add it via Options > \"Add features\" ");
            }

            return (File.Exists(appsList));
        }

        public override bool DoTweak()
        {
            try
            {
                logger.Log("The following apps will be uninstalled:");

                string[] app = File.ReadAllLines(appsList);

                foreach (var currentApp in app)
                {
                    if (!currentApp.StartsWith("#") && (!string.IsNullOrEmpty(currentApp)))
                    {
                        using (PowerShell script = PowerShell.Create())
                        {
                            script.AddScript($"Get-AppxPackage {Normalize(currentApp)} | Remove-AppxPackage");

                            try
                            {
                                logger.Log($"\nRemoving {currentApp}");
                                script.Invoke();
                            }
                            catch
                            { }
                        }
                    }
                }
                return true;
            }
            catch
            {
                logger.Log("- No bloatware apps found to be uninstalled.");
                return false;
            }
        }

        public override bool UndoTweak()
        {
            logger.Log("Nothing to undo here.");
            return true;
        }
    }
}