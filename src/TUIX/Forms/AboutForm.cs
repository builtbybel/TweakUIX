using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class AboutForm : Form
    {
        private Helpers.Utils appUpdate = new Helpers.Utils();

        public AboutForm()
        {
            InitializeComponent();

            var buildDateTime = Properties.Resources.buildDate;
            lblAssemblyInfo.Text = "Build on " + buildDateTime;
            richInfo.Text = "PowerToys/Tweak UI Replica"
                     + "\n\tVersion " + Program.GetCurrentVersionTostring()
                     + "\n\tAurora release, MIT"
                     + "\n\tGithub: https://github.com/builtbybel/TweakUIX"
                     + "\n\tBuiltbybel (https://twitter.com/builtbybel)"
                     + "\n\n\t(This is NOT a product made by Microsoft nor related to them.)";
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            if (!Helpers.Utils.IsInet()) lblAssemblyInfo.Text = "Some app infos could not be fetched.";
            else picture1.ImageLocation = "https://github.com/builtbybel/TweakUIX/blob/main/assets/header.png?raw=true";
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnAppUpdate_Click(object sender, EventArgs e) => appUpdate.CheckForUpdates();

        private void linkAppInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.builtbybel.com/blog/19-apps/47-powertoys-tweakui-is-back-for-windows-10-and-windows-11");

        private void picture1_Paint(object sender, PaintEventArgs e)
        {
            picture1.Controls.Add(linkAppInfo);
            picture1.Controls.Add(lblAssemblyInfo);
        }
    }
}