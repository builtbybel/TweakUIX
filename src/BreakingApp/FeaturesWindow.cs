using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BreakingApp
{
    public partial class FeaturesWindow : Form
    {
        public FeaturesWindow() => InitializeComponent();

        private void FeaturesWindow_Load(object sender, EventArgs e)
        {
            // Add required columns
            listView.Columns.Add("Name");
            listView.Columns.Add("Description");
            listView.Columns.Add("Developer");
            listView.Columns.Add("Link");

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

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
            pBar.Update();
            // this.Invoke((MethodInvoker)(() => lblStatus.Text = $"{e.ProgressPercentage}%"));
        }

        public void isFeatureInstalled()
        {
            foreach (ListViewItem item in listView.Items)
            {
                var feature = item.SubItems[3].Text;
                if (File.Exists(Helpers.Strings.Data.DataRootDir + feature.Split('/').Last()))
                    item.ForeColor = Color.Gray;
                else
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count == 0)
            {
                MessageBox.Show("No feature selected.", btnInstall.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (ListViewItem eachItem in listView.CheckedItems)
            {
                List<string> list = new List<string>(eachItem.SubItems[3].Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine(list);
                foreach (string url in list)
                {
                    pBar.Visible = true;
                    using (WebClient client = new WebClient())
                    {
                        pBar.Value = 0;
                        client.Credentials = CredentialCache.DefaultNetworkCredentials;
                        client.DownloadProgressChanged += Wc_DownloadProgressChanged;
                        Uri uri = new Uri(url);
                        string filename = System.IO.Path.GetFileName(uri.LocalPath);

                        try
                        {
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

                MessageBox.Show(eachItem.SubItems[0].Text + " " + "installed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                isFeatureInstalled(); // Refresh

                pBar.Visible = false;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("explorer.exe", Helpers.Strings.Data.DataRootDir) { UseShellExecute = true });
    }
}