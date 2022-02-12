using System.Management.Automation;

namespace BreakingApp.Tweaks.App
{
    internal class UninstallerPreview : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Show installed apps ONLY";
        }

        public override string Info()
        {
            return "Click [Check] to display a list of apps that are installed on your system.";
        }

        public override bool CheckTweak()
        {
            try
            {
                logger.Log("The following apps are installed on your system:");

                using (PowerShell script = PowerShell.Create())
                {
                    script.AddScript("Get-AppxPackage | Select Name | Out-String -Stream");

                    string trimmed = string.Empty;
                    foreach (PSObject x in script.Invoke())
                    {
                        trimmed = x.ToString().Trim();
                        if (!string.IsNullOrEmpty(trimmed) && !trimmed.Contains("---"))
                        {
                            if (trimmed != "Name") logger.Log(trimmed);
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

        public override bool DoTweak()
        {
            logger.Log("This feature displays a list of installed only.");
            return false;
        }

        public override bool UndoTweak()
        {
            logger.Log("Nothing to undo here.");
            return true;
        }
    }
}