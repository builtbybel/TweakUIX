using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TweakUIX.Tweaks.Desktop
{
    internal class WidgetsRemove : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Uninstall Widgets";
        }

        public override string Info()
        {
            return "The Widgets app runs in the background even with the option turned off.\nThis will uninstall the Widgets app package.";
        }

        public override bool CheckTweak()
        {
            var appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages", "MicrosoftWindows.Client.WebExperience_cw5n1h2txyewy");

            if (!Directory.Exists(appPath))
            {
                return false;
            }

            return true;
        }

        public override bool DoTweak()
        {
            try
            {
                using (var client = new WebClient())
                {
                    logger.Log("- Uninstalling Widgets app");
                    WindowsHelper.RunWT("winget uninstall \"windows web experience pack\"");
                    logger.Log("Done.");
                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                using (var client = new WebClient())
                {
                    logger.Log("- Installing Widgets app...\nWe've opened the download link in the Microsoft Store.\n\nPlease install the package \"Windows Web Experience Pack\". ");
                    Process.Start("ms-windows-store://pdp/?ProductId=9MSSGKG348SP");

                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }
    }
}