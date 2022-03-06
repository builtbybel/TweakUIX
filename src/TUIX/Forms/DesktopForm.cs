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
    public partial class DesktopForm : Form
    {
        public DesktopForm()
        {
            InitializeComponent();
        }

        private void btnDesktopIcons_Click(object sender, EventArgs e)
        {
           var proc = @"C:\Windows\System32\rundll32.exe";
           var args= "shell32.dll,Control_RunDLL desk.cpl,,0";
                Process.Start(proc, args);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.sc.Panel2.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.sc.Panel2.Controls.Add(mainForm.INavPage);
        }
    }
}
