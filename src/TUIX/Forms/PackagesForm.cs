using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class PackagesForm : Form
    {
        private string fPackagesLocal = Helpers.Strings.Data.DataRootDir + "packages.app";

        public PackagesForm()
        {
            InitializeComponent();

            GetPackagesLocal();
            RequestPackagesRemote();
        }

        private void PackagesForm_Leave(object sender, EventArgs e) => System.IO.File.WriteAllLines(fPackagesLocal, listInstall.Items.Cast<string>().ToArray());

        public void GetPackagesLocal()
        {
            if (!File.Exists(fPackagesLocal))
                File.Create(fPackagesLocal).Dispose();

            string[] appsInstall = File.ReadAllLines(fPackagesLocal);

            foreach (var currentApp in appsInstall)
            {
                if (!currentApp.StartsWith("#") && (!string.IsNullOrEmpty(currentApp)))
                {
                    listInstall.Items.Add(currentApp.ToString());
                }
            }
        }

        public void RequestPackagesRemote()
        {
            try
            {
                List<string> remoteApps = new List<string>();
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/builtbybel/TweakUIX/main/features/packages.git");
                string app;

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var sr = new StreamReader(content))
                {
                    while ((app = sr.ReadLine()) != null)
                    {
                        {
                            if (!app.StartsWith("#") && (!string.IsNullOrEmpty(app)))
                            {
                                remoteApps.Add(app);
                                listAvailable.Items.Add(app);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listInstall.Items.Count != 0)
            {
                if (listInstall.SelectedItem == null) listInstall.SelectedIndex = 0;
                while (listInstall.SelectedItem != null)
                {
                    listInstall.Items.Remove(listInstall.SelectedItem);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listAvailable.Items.Count != 0)
            {
                if (listAvailable.SelectedItem == null) listAvailable.SelectedIndex = 0;
                while (listAvailable.SelectedItem != null)
                {
                    if (!listInstall.Items.Contains(listAvailable.Text))
                    {
                        listInstall.Items.Add(listAvailable.Text);
                        listAvailable.Items.Remove(listAvailable.SelectedItem);
                    }
                    else { MessageBox.Show("App is already on your install list."); return; }
                }
            }
        }
    }
}