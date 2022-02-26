using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            richInfo.Text="PowerToys/Tweak UI Replica"
                     + "\n\tVersion " + Program.GetCurrentVersionTostring()
                     + "\n\tAurora release, MIT"
                     + "\n\tGithub: https://github.com/builtbybel/TweakUIX"
                     + "\n\t(C) 2022 Builtbybel (https://twitter.com/builtbybel)"
                     + "\n\n\t(This is NOT a product made by Microsoft nor related to them.)";
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}
