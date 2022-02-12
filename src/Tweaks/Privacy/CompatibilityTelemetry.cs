using Microsoft.Win32;
using System;

namespace BreakingApp.Tweaks.Privacy
{
    internal class CompatibilityTelemetry : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe";
        private const string desiredValue = @"%windir%\System32\taskkill.exe";

        public override string ID()
        {
            return "Compatibility Telemetry";
        }

        public override string Info()
        {
            return "This process is periodically collecting a variety of technical data about your computer and its performance and sending it to Microsoft for its Windows Customer Experience Improvement Program.";
        }

        public override bool CheckTweak()
        {
            return !(
          RegistryHelper.StringEquals(keyName, "Debugger", desiredValue)
           );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "Debugger", desiredValue, RegistryValueKind.String);
                logger.Log("- Compatibility Telemetry has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable compatibility telemetry: {0}", ex.Message); }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                var RegKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe", true);
                RegKey.DeleteValue("Debugger");

                logger.Log("- Compatibility Telemetry has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}