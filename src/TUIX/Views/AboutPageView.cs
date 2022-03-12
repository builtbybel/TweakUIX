using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class AboutPageView : UserControl
    {
        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

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

        private void SetDesktopBackground(object sender, EventArgs e)
        {
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (f.ShowDialog() == DialogResult.OK)

                {
                    RegistryKey keyName = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                    keyName.SetValue(@"WallpaperStyle", 2.ToString());
                    keyName.SetValue(@"TileWallpaper", 0.ToString());

                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, f.FileName, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                }
            }
        }
    }
}