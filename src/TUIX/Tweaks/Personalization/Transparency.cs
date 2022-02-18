using Microsoft.Win32;
using System;

namespace TweakUIX.Tweaks.Personalization
{
    internal class Transparency : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Disable acrylic Fluent Design effects";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "EnableTransparency", desiredValue)
            );
        }

        public override bool DoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "EnableTransparency", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Transparency effects has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable transparency effects {0}", ex.Message); }

            return false;
        }

        public override bool UndoTweak()
        {
            try
            {
                Registry.SetValue(keyName, "EnableTransparency", 1, RegistryValueKind.DWord);
                logger.Log("- Transparency effects has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}