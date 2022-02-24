using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TweakUIX
{
    public partial class FeaturesForm : Form
    {
        public FeaturesForm() => InitializeComponent();

        public string FormTitle
        {
            get => this.Text;
            set => this.Text = value;
        }

        private void FeaturesForm_Load(object sender, EventArgs e)
        {
            // Add required columns
            listView.Columns.Add("Name");
            listView.Columns.Add("Description");
            listView.Columns.Add("Developer");
            listView.Columns.Add("Link");

            try
            {
                XDocument doc = XDocument.Load(Helpers.Strings.Data.DataRootDir + "app.xml");

                foreach (var dm in doc.Descendants("Feature"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    dm.Element("id").Value,
                    dm.Element("description").Value,
                    dm.Element("dev").Value,
                    dm.Element("uri").Value,
                    });

                    listView.Items.Add(item);

                    listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }

                isFeatureInstalled();
            }
            catch { MessageBox.Show("Features not found.\nPlease download the package again."); }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            progress.Update();
            // this.Invoke((MethodInvoker)(() => lblStatus.Text = $"{e.ProgressPercentage}%"));
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            bool bNeedRestart = false;

            if (listView.CheckedItems.Count == 0)
            {
                MessageBox.Show("No feature selected.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder builder = new StringBuilder();

            foreach (ListViewItem eachItem in listView.CheckedItems)
            {
                List<string> list = new List<string>(eachItem.SubItems[3].Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));

                foreach (string url in list)
                {
                    progress.Visible = true;
                    using (WebClient client = new WebClient())
                    {
                        progress.Value = 0;
                        client.Credentials = CredentialCache.DefaultNetworkCredentials;
                        client.DownloadProgressChanged += Wc_DownloadProgressChanged;
                        Uri uri = new Uri(url);
                        string filename = System.IO.Path.GetFileName(uri.LocalPath);
                        string fileExt = System.IO.Path.GetExtension(eachItem.SubItems[3].Text);

                        try
                        {
                            if (fileExt == ".ps1")
                                await client.DownloadFileTaskAsync(uri, Helpers.Strings.Data.PluginsRootDir + filename);
                            else
                                await client.DownloadFileTaskAsync(uri, Helpers.Strings.Data.DataRootDir + filename

                        );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, listView.FocusedItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                builder.Append("\n- " + eachItem.SubItems[0].Text);

                // Restart required by filetypes
                if (eachItem.SubItems[3].Text.Contains(".tuix") 
                    || eachItem.SubItems[3].Text.Contains(".ps1") 
                    || eachItem.SubItems[3].Text.Contains(".xml"))
                {
                    builder.Append(" (Restart required.)");
                    bNeedRestart = true;
                }
            }

            MessageBox.Show("Features successfully installed:\n" + builder.ToString(), FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            isFeatureInstalled();

            if (bNeedRestart)
            {
                MessageBox.Show("We will restart the app to complete the installation of some features.");
                Application.Restart();
                Environment.Exit(0);
            }

            progress.Visible = false;
        }

        public void isFeatureInstalled()
        {
            foreach (ListViewItem item in listView.Items)
            {
                var feature = item.SubItems[3].Text;
                if (File.Exists(Helpers.Strings.Data.DataRootDir + feature.Split('/').Last()) || File.Exists(Helpers.Strings.Data.PluginsRootDir + feature.Split('/').Last()))
                    item.ForeColor = Color.Gray;
                else
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("explorer.exe", Helpers.Strings.Data.DataRootDir) { UseShellExecute = true });
    }
}