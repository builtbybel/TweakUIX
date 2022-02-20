using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class PluginsForm : Form
    {
        public PluginsForm()
        {
            InitializeComponent();
            InitializePlugins();
        }

        private void InitializePlugins()
        {
            listPlugs.Items.Clear();

            try
            {
                DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.PluginsRootDir);
                FileInfo[] listSettings = dirs.GetFiles("*.ps1");
                foreach (FileInfo fi in listSettings)
                {
                    listPlugs.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                    listPlugs.Enabled = true;
                }
            }
            catch { MessageBox.Show("No plugins directory found."); btnApply.Visible = false; btnCancel.Visible = false; }
        }

        public async void DoPlugin()
        {
            if (listPlugs.CheckedItems.Count == 0)
            {
                MessageBox.Show("No plugin selected.");
                return;
            }

            if (MessageBox.Show("Do you want to apply selected plugins", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < listPlugs.Items.Count; i++)
                {
                    if (listPlugs.GetItemChecked(i))
                    {
                        listPlugs.SelectedIndex = i;
                        string plugsDir = Helpers.Strings.Data.PluginsRootDir + "\\" + listPlugs.SelectedItem.ToString() + ".ps1";
                        var ps1File = plugsDir;

                        var equals = new[] { "Requires -RunSilent" };

                        var str = richPluginInfo.Text;
                        btnCancel.Visible = true;
                        progress.Visible = true;
                        progress.Style = ProgressBarStyle.Marquee;
                        progress.MarqueeAnimationSpeed = 30;

                        btnApply.Enabled = false;
                        grpBox.Text = "Processing " + listPlugs.Text;

                        if (equals.Any(str.Contains))                   // Silent
                        {
                            var startInfo = new ProcessStartInfo()
                            {
                                FileName = "powershell.exe",
                                Arguments = $"-executionpolicy bypass -file \"{ps1File}\"",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                            };

                            await Task.Run(() => { Process.Start(startInfo).WaitForExit(); });
                        }
                        else                                            // Create ConsoleWindow
                        {
                            var startInfo = new ProcessStartInfo()
                            {
                                FileName = "powershell.exe",
                                Arguments = $"-executionpolicy bypass -noexit -file \"{ps1File}\"",
                                UseShellExecute = false,
                            };

                            await Task.Run(() => { Process.Start(startInfo).WaitForExit(); });
                        }

                        btnApply.Enabled = true;
                        grpBox.Text = "";
                    }
                }

                progress.Visible = false;
                btnCancel.Visible = false;

                MessageBox.Show("Plugins have been successfully applied.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listPlugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string plugsDir = Helpers.Strings.Data.PluginsRootDir + "\\" + listPlugs.Text + ".ps1";

            try
            {
                using (StreamReader sr = new StreamReader(plugsDir, Encoding.Default))
                {
                    StringBuilder content = new StringBuilder();

                    while (!sr.EndOfStream)
                        content.AppendLine(sr.ReadLine());

                    richPluginInfo.Text = string.Join(Environment.NewLine, File.ReadAllLines(plugsDir).Where(s => s.StartsWith("###")).Select(s => s.Substring(3).Replace("###", "\n")));
                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String CurrentUser = Environment.UserName;
            Process[] allProcesses = Process.GetProcessesByName("powershell");
            if (null != allProcesses)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C TASKKILL /F /FI \"USERNAME eq " + CurrentUser + "\" /IM powershell.exe";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            btnCancel.Visible = false;
        }

        private void btnApply_Click(object sender, EventArgs e) => DoPlugin();

        private void richPluginInfo_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}