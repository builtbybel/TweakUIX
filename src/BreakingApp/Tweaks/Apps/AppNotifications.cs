using Microsoft.Win32;

namespace BreakingApp.Tweaks.Apps
{
    internal class AppNotifications : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PushNotifications";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "App notifications";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "ToastEnabled", desiredValue)
             );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "ToastEnabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- App notifications has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "ToastEnabled", "1", RegistryValueKind.DWord);
                logger.Log("- App notifications has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}