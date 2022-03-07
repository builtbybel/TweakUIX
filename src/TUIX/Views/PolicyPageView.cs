using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class PolicyPageView : UserControl
    {
        public PolicyPageView() =>   InitializeComponent();
        

        private void btnRun_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "gpedit.msc";
            Process.Start(startInfo);
        }
    }
}
