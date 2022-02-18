using Microsoft.Win32;
using System;

namespace TweakUIX.Tweaks.Privacy
{
    internal class Biometrics : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Biometrics";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Windows Hello Biometrics";
        }

        public override string Info()
        {
            return "Windows Hello biometrics lets you sign in to your devices, apps, online services, and networks using your face, iris, or fingerprint.";
        }

        public override bool CheckTweak()
        {
            return !(
             RegistryHelper.IntEquals(keyName, "Enabled", desiredValue)
           );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Windows Hello Biometrics has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Windows Hello Biometrics {0}", ex.Message); }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", 1, RegistryValueKind.DWord);
                logger.Log("- Windows Hello Biometrics has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}