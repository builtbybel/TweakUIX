using System.Diagnostics;

namespace TweakUIX.Tweaks.Update
{
    internal class Wuauserv : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Check for Windows updates";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            return true;
        }

        public override bool DoTweak()
        {
            try
            {
                logger.Log("Checking for Windows updates...");
                Process.Start("ms-settings:windowsupdate-action");
                logger.Log("Done.");
                return true;
            }
            catch
            {
                logger.Log("- Windows Update check failed.");
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