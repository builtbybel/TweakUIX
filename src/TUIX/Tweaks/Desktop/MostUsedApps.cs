using Microsoft.Win32;
using System;

namespace TweakUIX.Tweaks.Desktop
{
    internal class MostUsedApps : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Explorer";
        private const int desiredValue = 2;

        public override string ID()
        {
            return "Hide most used apps in start menu";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "ShowOrHideMostUsedApps", desiredValue)
            );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "ShowOrHideMostUsedApps", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Most Used Apps has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Most Used Apps {0}", ex.Message); }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                var RegKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", true);
                RegKey.DeleteValue("ShowOrHideMostUsedApps");

                logger.Log("- Most Used Apps has been set to default behavior.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}