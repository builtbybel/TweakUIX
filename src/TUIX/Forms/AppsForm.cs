using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class AppsForm : Form
    {
        private string fAppsLocal = Helpers.Strings.Data.DataRootDir + "uninstaller.app";

        private readonly string _featureAddTemplate = "We recommend you installing the following feature:" +
                                "\n\t- Template for debloating Windows 10 and Windows 11" +
                                "\n(To do this, simply click on \"Add features > Install\")";

        private List<string> removeAppsSystem = new List<string>();
        private readonly PowerShell powerShell = PowerShell.Create();

        public AppsForm() => InitializeComponent();

        private void AppsForm_Shown(object sender, EventArgs e) => this.Shown += new EventHandler(AppsForm_Shown);

        private void AppsForm_Load(object sender, EventArgs e)
        {
            this.GetAppsLocal();           // Retrieve local apps in removal list
            this.InitializeAppsSystem();   // Retrieve hidden systemapps from resource file
            this.InitializeApps();         // Yet just the normal....

        }

        public void GetAppsLocal()
        {
            if (!File.Exists(fAppsLocal))
            {
                MessageBox.Show("Apps removal list is empty.\n\n" + _featureAddTemplate);
                return;
            }

            string[] appsInstall = File.ReadAllLines(fAppsLocal);

            foreach (var currentApp in appsInstall)
            {
                if (!currentApp.StartsWith("#") && (!string.IsNullOrEmpty(currentApp)))
                {
                    listRemove.Items.Add(currentApp.ToString());
                }
            }
            RefreshApps();
        }

        private void InitializeApps()
        {
            listApps.Items.Clear();
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                // Show ONLY NON-SYSTEM apps by comparing found apps with systemapps.txt
                if (removeAppsSystem != null) if ((removeAppsSystem.Any(current.Contains)) & !checkAppsSystem.Checked) continue;

                if (listApps.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                listApps.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            // Compare left and rights apps list and remove differences
            string compare = listApps.Items.ToString();
            foreach (string item in listRemove.Items) if (item.Any(compare.Contains)) listApps.Items.Remove(item);

            RefreshApps();
        }

        private void InitializeAppsSystem()
        {
            StreamReader Database = null;

            try
            {
                Helpers.Strings.CreateDataDir();
                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
            }
            catch (FileNotFoundException) // Create file if it doesnt exisits
            {
                StreamWriter sw = File.CreateText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
                sw.Write(Properties.Resources.systemApps);    // Populate it with built in preset
                sw.Close();

                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
            }
            finally
            {
                if (Database.Peek() > 0) // Exists and not empty
                {
                    string buff;
                    while ((buff = Database.ReadLine()) != null)
                    {
                        removeAppsSystem.Add(buff);
                    }
                };
                Database.Close();
            }
        }

        private void RefreshApps()
        {
            int installed = listApps.Items.Count;
            int remove = listRemove.Items.Count;
            groupInstalled.Text = installed.ToString() + " apps installed";
            groupBin.Text = "Recycle bin" + " (" + remove.ToString() + ")";

            if (installed == 0)
                btnMoveAll.Enabled =
                btnMove.Enabled =
                false;
            else
                btnMoveAll.Enabled =
                btnMove.Enabled =
                true;

            if (remove == 0)
                btnRestoreAll.Enabled =
                btnRestore.Enabled =
                false;
            else
                btnRestoreAll.Enabled =
                btnRestore.Enabled =
                true;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (listApps.Items.Count != 0)
            {
                if (listApps.SelectedItem == null) listApps.SelectedIndex = 0;
                while (listApps.SelectedItem != null)
                {
                    listRemove.Items.Add(listApps.SelectedItem);
                    listApps.Items.Remove(listApps.SelectedItem);
                }
                RefreshApps();
            }
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listApps.Items)
            {
                listRemove.Items.Add(item);
            }
            listApps.Items.Clear();
            RefreshApps();
        }

        private void btnRestoreAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listRemove.Items)
            {
                listApps.Items.Add(item);
            }
            listRemove.Items.Clear();
            RefreshApps();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (listRemove.Items.Count != 0)
            {
                if (listRemove.SelectedItem == null) listRemove.SelectedIndex = 0;
                while (listRemove.SelectedItem != null)
                {
                    listApps.Items.Add(listRemove.SelectedItem);
                    listRemove.Items.Remove(listRemove.SelectedItem);
                }
                RefreshApps();
            }
        }

        private void checkAppsSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAppsSystem.Checked)
            {
                MessageBox.Show("Be picky about which System applications to uninstall." +
                "\n\nYou can uninstall most of the built-in apps, even ones that don't normally offer an \"Uninstall\" option." +
                "\n\nNote, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. " +
                "as these apps are needed for the Windows 11 \"Experience\" and for other programs. If you try, you’ll see an error message saying the removal failed.");

                InitializeAppsSystem();
                InitializeApps();
            }
            else InitializeApps();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.sc.Panel2.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.sc.Panel2.Controls.Add(mainForm.INavPage);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listApps.Items.Clear();
            listRemove.Items.Clear();

            GetAppsLocal();
            AppsForm_Leave(sender, e);
            InitializeAppsSystem();
            InitializeApps();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;

            if (f.ShowDialog() == DialogResult.OK)

            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    listRemove.Items.Clear();

                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listRemove.Items.Add(line);
                        RefreshApps();
                        string compare = listApps.Items.ToString();
                        foreach (string item in listRemove.Items) if (item.Any(compare.Contains)) listApps.Items.Remove(item);
                    }

                    RefreshApps();

                    MessageBox.Show("We've synced your import list with the apps in Recycle bin.\n" +
                        "Please note, that some of these apps may not be installed on your system.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddFeature_Click(object sender, EventArgs e)
        {
            using (var form = new FeaturesForm())

            {
               
                form.ShowDialog();
                btnRefresh_Click(null, null);
            }
        }

        private void AppsForm_Leave(object sender, EventArgs e) => System.IO.File.WriteAllLines(fAppsLocal, listRemove.Items.Cast<string>().ToArray());
    }
}