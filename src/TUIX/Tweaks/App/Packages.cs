using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace TweakUIX.Tweaks.App
{
    internal class Packages : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private static string packagesList = Helpers.Strings.Data.DataRootDir + "packages.app";

        public override string ID()
        {
            return "*Install essential apps";
        }

        public override string Info()
        {
            return "Click [Check] to display a list of apps that will be installed.";
        }

        internal static string Normalize(string line)
        {
            return Regex.Replace(line, @"\s{2,}", " ");
        }

        public override bool CheckTweak()
        {
            try
            {
                logger.Log("The following apps will be installed:");

                string[] packages = File.ReadAllLines(packagesList);

                foreach (var currentPackage in packages)
                {
                    if (!currentPackage.StartsWith("#") && (!string.IsNullOrEmpty(currentPackage)))
                    {
                        logger.Log("- [App] " + currentPackage.ToString());
                    }
                }

                logger.Log("TIP: If you prefer other apps, then you can create your own essentials for your new Windows device on this page https://winstall.app" +
                           "\nCopy the IDs and add them to \"uninstaller.app\" in \"app\" folder of this application.");
            }
            catch
            {
                logger.Log("Feature not available. Add it via Options > \"Add features\" ");
            }

            return (File.Exists(packagesList));
        }

        private void InstallPackages(string package)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript(package);

                try
                {   // Invoke execution on pipeline
                    Collection<PSObject> PSOutput = powerShell.Invoke();

                    foreach (PSObject outputItem in PSOutput)
                    {
                        if (outputItem != null)
                        {
                            package = ($"{outputItem}");
                        }
                    }
                }
                catch (Exception ex)
                { logger.Log("Error installing package: {0}", ex.Message); }
            }
        }

        public override bool DoTweak()
        {
            try
            {
                logger.Log("The following packages will be installed:");

                string[] packages = File.ReadAllLines(packagesList);

                foreach (var currentPackage in packages)
                {
                    if (!currentPackage.StartsWith("#") && (!string.IsNullOrEmpty(currentPackage)))
                    {
                        using (PowerShell script = PowerShell.Create())
                        {
                            logger.Log($"\nInstalling {currentPackage}");
                            InstallPackages($"winget install --id={Normalize(currentPackage)} -e --accept-package-agreements --accept-source-agreements");
                        }
                    }
                }
                return true;
            }
            catch
            {
                logger.Log("- No packages found to be installed.");
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