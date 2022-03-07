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
    public partial class AboutPageView : UserControl
    {
        private Helpers.Utils appUpdate = new Helpers.Utils();

        public AboutPageView()
        {
            InitializeComponent();

            var buildDateTime = Properties.Resources.buildDate;
            richInfo.Text = "PowerToys/Tweak UI Replica"
                     + "\n\tVersion " + Program.GetCurrentVersionTostring()
                     + "\n\tAurora release, MIT"
                     + "\n\tGithub: https://github.com/builtbybel/TweakUIX"
                     + "\n\tBuiltbybel (https://twitter.com/builtbybel)"
                     + "\n\tBuild on " + buildDateTime
                     + "\n\n\t(This is NOT a product made by Microsoft nor related to them.)";
        }

        private void AboutPageView_Load(object sender, EventArgs e)
        {
            if (!Helpers.Utils.IsInet()) linkAppInfo.Text = "\nNO INTERNET CONNECTION ESTABLISHED.\nSome app infos could not be fetched...";
            else picture1.ImageLocation = "https://github.com/builtbybel/TweakUIX/blob/main/assets/tweakui.png?raw=true";
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnAppUpdate_Click(object sender, EventArgs e) => appUpdate.CheckForUpdates();

        private void linkAppInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.builtbybel.com/blog/19-apps/47-powertoys-tweakui-is-back-for-windows-10-and-windows-11");
    }
}
