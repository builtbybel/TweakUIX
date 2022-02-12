using Microsoft.Win32;

namespace BreakingApp.Tweaks.Apps
{
    internal class Call : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\phoneCall";
        private const string desiredValue = "Deny";

        public override string ID()
        {
            return "App access to call";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return !(
               RegistryHelper.StringEquals(keyName, "Value", desiredValue)
             );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "Value", desiredValue, RegistryValueKind.String);

                logger.Log("- App access to call has been successfully disabled.");
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
                Registry.SetValue(keyName, "Value", "Allow", RegistryValueKind.String);
                logger.Log("- App access to call has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}