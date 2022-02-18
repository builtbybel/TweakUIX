using TweakUIX.Tweaks;
using System.Windows.Forms;

namespace TweakUIX
{
    internal class TweaksNode : TreeNode
    {
        public TweaksBase Tweak { get; }

        public TweaksNode(TweaksBase tweak)
        {
            Tweak = tweak;
            Text = Tweak.ID();
            ToolTipText = Tweak.Info();
            //Checked = true;
        }
    }
}