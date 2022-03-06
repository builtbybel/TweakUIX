namespace TweakUIX.Tweaks
{
    public abstract class TweaksBase
    {
        /// <summary>
        /// Name of the Tweak
        /// </summary>
        /// <returns>The Tweak name</returns>
        public abstract string ID();

        /// <summary>
        /// Tooltip text of tweaks
        /// </summary>
        /// <returns>The tweaks tooltip</returns>
        public abstract string Info();

        /// <summary>
        /// Checks whether tweaks should be applied
        /// </summary>
        /// <returns>Returns true if the tweak should be applied, false otherwise.</returns>
        public abstract bool CheckTweak();

        /// <summary>
        /// Apply Tweak
        /// </summary>
        /// <returns>Returns true if the tweak was successfull, false otherwise.</returns>
        public abstract bool DoTweak();

        /// <summary>
        /// Undo Tweak
        /// </summary>
        /// <returns>Returns true if the tweak was successfull, false otherwise.</returns>
        public abstract bool UndoTweak();
    }
}