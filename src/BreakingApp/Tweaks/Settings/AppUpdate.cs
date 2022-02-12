namespace BreakingApp.Tweaks.Settings
{
    internal class AppUpdate : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private Helpers.Utils appUpdate = new Helpers.Utils();

        public override string ID()
        {
            return "Check for App updates";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckTweak()
        {
            appUpdate.CheckForUpdates();
            return false;
        }

        public override bool DoTweak()
        {
            appUpdate.CheckForUpdates();
            return true;
        }

        public override bool UndoTweak()
        {
            logger.Log("- Nothing to undo here.");
            return true;
        }
    }
}