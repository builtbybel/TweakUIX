using System.Management.Automation;

namespace BreakingApp.Tweaks.App
{
    internal class InBoxApps : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Remove all in-box apps";
        }

        public override string Info()
        {
            return "This will remove all built-in apps except Microsoft Store.";
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
            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage | where-object {$_.name –notlike “*store*”} | Remove-AppxPackage");

                try
                {
                    logger.Log("Removing apps. Please wait...");
                    script.Invoke();
                    logger.Log("Done. Windows is fresh and clean again.");
                }
                catch
                { }
            }

            return true;
        }

        public override bool UndoTweak()
        {
            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage -AllUsers| Foreach {Add-AppxPackage -DisableDevelopmentMode -Register “$($_.InstallLocation)\\AppXManifest.xml”}");

                try
                {
                    logger.Log("Re-installing all built-in apps...");
                    script.Invoke();
                    logger.Log("Done");
                    return true;
                }
                catch
                { }

                return false;
            }
        }
    }
}