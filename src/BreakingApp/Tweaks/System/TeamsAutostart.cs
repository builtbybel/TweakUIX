using Microsoft.Win32;
using System;

namespace BreakingApp.Tweaks.System
{
    internal class TeamsAutostart : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private string desiredValue = string.Format("C:\\Users\\{0}\\AppData\\Local\\Microsoft\\Teams\\Update.exe --processStart \"Teams.exe\" --process-start-args \"--system-initiated", Environment.UserName);

        public override string ID()
        {
            return "Disable Microsoft Teams on Startup";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            string AppValue = "com.squirrel.Teams.Teams";

            if (Registry.GetValue(keyName, AppValue, null) == null)
            {
                logger.Log("Teams AutoStart is already disabled.");

                return false;
            }
            else
            {
                logger.Log("Teams AutoStart is enabled.");
                return true;
            }
        }

        public override bool DoTweak()
        {
            try
            {
                var RegKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                RegKey.DeleteValue("com.squirrel.Teams.Teams");

                logger.Log("- Teams AutoStart has been disabled.");
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
                Registry.SetValue(keyName, "com.squirrel.Teams.Teams", desiredValue, RegistryValueKind.String);

                logger.Log("- Teams AutoStart has been enabled again.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}