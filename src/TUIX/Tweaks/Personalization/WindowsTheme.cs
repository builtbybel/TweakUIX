using Microsoft.Win32;

namespace TweakUIX.Tweaks.Personalization
{
    internal class WindowsTheme : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Use Windows dark theme";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "SystemUsesLightTheme", desiredValue)
             );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "SystemUsesLightTheme", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Windows dark theme has been successfully enabled.");
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
                Registry.SetValue(keyName, "SystemUsesLightTheme", "1", RegistryValueKind.DWord);
                logger.Log("- Windows light theme has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}