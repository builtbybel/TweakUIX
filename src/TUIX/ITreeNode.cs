using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TweakUIX.ITreeNode
{
    public static class ITreeNode
    {
        public static IEnumerable<System.Windows.Forms.TreeNode> All(this TreeNodeCollection nodes)
        {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));

            foreach (System.Windows.Forms.TreeNode n in nodes)
            {
                yield return n;

                foreach (System.Windows.Forms.TreeNode child in n.Nodes.All())
                {
                    yield return child;
                }
            }
        }
    }
}