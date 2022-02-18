using BreakingApp.ITreeNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingApp
{
    public partial class MainForm : Form
    {
        private Helpers.OS osInfo = new Helpers.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public MainForm() => InitializeComponent();

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitializeTweaks();
            InitializeTemplates();

            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            this.Size = new Size(900, 700);

            menuAppInfo.Text = "(Version-" + Program.GetCurrentVersionTostring() + "-walter.release)";
            lblInfo.Text = "Version " + Program.GetCurrentVersionTostring() +
                                "\n\nFor " + osInfo.GetChassisType() + "\x20" +
                                osInfo.IsWin11() + "\x20"
                                + osInfo.GetVersion() + "\x20"
                                + osInfo.Is64Bit();

            richStatus.Text = "Select a setting from the tree list at left or load a predefined template." +
                            "\n\nWith this app you are able to change some settings, which aren't reachable within Windows 11." +
                             "\nIt is a simple tool with an even simpler UI based on Microsoft Powertoys/TweakUI." +
                             "\n\nMore information can be found here " + Helpers.Strings.Uri.URL_GITREPO;
        }

        public void InitializeTweaks()
        {
            tweaksTree.Nodes.Clear();
            tweaksTree.BeginUpdate();

            // Set logger to target richStatus
            logger.SetTarget(richStatus);

            // Root node
            TreeNode root = new TreeNode("Tweak UI")
            {
                Checked = false,
            };

            TreeNode settings = new TreeNode("Settings", new TreeNode[] {
                new TweaksNode(new Tweaks.Settings.AppUpdate()),
                new TweaksNode(new Tweaks.Settings.RestorePoint()),
            });

            TreeNode personalization = new TreeNode("Personalization", new TreeNode[] {
                new TweaksNode(new Tweaks.Personalization.AppsTheme()),
                new TweaksNode(new Tweaks.Personalization.WindowsTheme()),
                new TweaksNode(new Tweaks.Personalization.Transparency()),
                new TweaksNode(new Tweaks.Personalization.SnapAssistFlyout()),
                new TweaksNode(new Tweaks.Personalization.Widgets()),
                new TweaksNode(new Tweaks.Personalization.WidgetsRemove()),
                new TweaksNode(new Tweaks.Personalization.TaskbarAl()),
                new TweaksNode(new Tweaks.Personalization.TaskbarSi()),
                new TweaksNode(new Tweaks.Personalization.TaskbarMM()),
                new TweaksNode(new Tweaks.Personalization.TaskbarSearch()),
                new TweaksNode(new Tweaks.Personalization.TaskbarChat()),
                new TweaksNode(new Tweaks.Personalization.TaskView()),
                new TweaksNode(new Tweaks.Personalization.FileExplorer()),
                new TweaksNode(new Tweaks.Personalization.MostUsedApps()),
                new TweaksNode(new Tweaks.Personalization.HiddenFileFolder()),
                new TweaksNode(new Tweaks.Personalization.HiddenFileExt()),
            }); CheckNodes(personalization);

            TreeNode system = new TreeNode("System", new TreeNode[] {
                new TweaksNode(new Tweaks.System.Fax()),
                new TweaksNode(new Tweaks.System.XPSWriter()),
                new TweaksNode(new Tweaks.System.EnableWSL()),
                new TweaksNode(new Tweaks.System.InstallWSA()),
                new TweaksNode(new Tweaks.System.HyperV()),
                new TweaksNode(new Tweaks.System.TeamsAutostart()),
            }); CheckNodes(system);

            TreeNode paranoia = new TreeNode("Paranoia", new TreeNode[] {
                new TweaksNode(new Tweaks.Paranoia.CleanMgr()),
                new TweaksNode(new Tweaks.Paranoia.WindowsSpyBlocker()),
                new TweaksNode(new Tweaks.Paranoia.ShutUp11()),
            });

            TreeNode update = new TreeNode("Windows Update", new TreeNode[] {
                new TweaksNode(new Tweaks.Update.Wuauserv()),
                new TweaksNode(new Tweaks.Update.Wusa()),
            });

            TreeNode gaming = new TreeNode("Gaming", new TreeNode[] {
                new TweaksNode(new Tweaks.Gaming.GameDVR()),
                new TweaksNode(new Tweaks.Gaming.PowerThrottling()),
                new TweaksNode(new Tweaks.Gaming.VisualFX()),
            });

            TreeNode privacy = new TreeNode("Privacy (disable)", new TreeNode[] {
                new TweaksNode(new Tweaks.Privacy.DiagnosticData()),
                new TweaksNode(new Tweaks.Privacy.Telemetry()),
                new TweaksNode(new Tweaks.Privacy.CompatibilityTelemetry()),
                new TweaksNode(new Tweaks.Privacy.LocationTracking()),
                new TweaksNode(new Tweaks.Privacy.Advertising()),
                new TweaksNode(new Tweaks.Privacy.Feedback()),
                new TweaksNode(new Tweaks.Privacy.SuggestedContent()),
                new TweaksNode(new Tweaks.Privacy.Biometrics()),
                new TweaksNode(new Tweaks.Privacy.AppsAutoInstall()),
                new TweaksNode(new Tweaks.Privacy.WindowsTips()),
                new TweaksNode(new Tweaks.Privacy.TailoredExperiences()),
            });

            TreeNode apps = new TreeNode("Apps permissions (disable)", new TreeNode[] {
                new TweaksNode(new Tweaks.Apps.AppNotifications()),
                new TweaksNode(new Tweaks.Apps.Camera()),
                new TweaksNode(new Tweaks.Apps.Microphone()),
                new TweaksNode(new Tweaks.Apps.Call()),
                new TweaksNode(new Tweaks.Apps.Notifications()),
                new TweaksNode(new Tweaks.Apps.AccountInfo()),
                new TweaksNode(new Tweaks.Apps.Contacts()),
                new TweaksNode(new Tweaks.Apps.Calendar()),
                new TweaksNode(new Tweaks.Apps.CallHistory()),
                new TweaksNode(new Tweaks.Apps.Email()),
                new TweaksNode(new Tweaks.Apps.Tasks()),
                new TweaksNode(new Tweaks.Apps.Messaging()),
                new TweaksNode(new Tweaks.Apps.Motion()),
                new TweaksNode(new Tweaks.Apps.OtherDevices()),
                new TweaksNode(new Tweaks.Apps.BackgroundApps()),
                new TweaksNode(new Tweaks.Apps.TrackingApps()),
                new TweaksNode(new Tweaks.Apps.DiagnosticInformation()),
                new TweaksNode(new Tweaks.Apps.Documents()),
                new TweaksNode(new Tweaks.Apps.Pictures()),
                new TweaksNode(new Tweaks.Apps.Videos()),
                new TweaksNode(new Tweaks.Apps.Radios()),
                new TweaksNode(new Tweaks.Apps.FileSystem()),
                new TweaksNode(new Tweaks.Apps.EyeGaze()),
                new TweaksNode(new Tweaks.Apps.CellularData()),
            });

            TreeNode uninstaller = new TreeNode("*Uninstaller", new TreeNode[] {
                 new TweaksNode(new Tweaks.App.Uninstaller()),
                 new TweaksNode(new Tweaks.App.InBoxApps()),
            })
            {
                ToolTipText = "Right-click on entry to configure this app",
            };

            TreeNode installer = new TreeNode("*Packages", new TreeNode[] {
                 new TweaksNode(new Tweaks.App.Packages()),
            })
            {
                ToolTipText = "Right-click on entry to configure this app",
            };

            TreeNode plugins = new TreeNode("*Plugins", new TreeNode[] {
            })
            {
                ForeColor = Color.Gray,
                Checked = false,
            };

            root.Nodes.AddRange(new TreeNode[]
            {
                settings,
                personalization,
                system,
                paranoia,
                update,
                gaming,
                privacy,
                apps,
                uninstaller,
                installer,
                plugins,
            });

            tweaksTree.Nodes.Add(root);

            // Some tvw nicety
            foreach (TreeNode tn in tweaksTree.Nodes) { tn.Expand(); }
            tweaksTree.EndUpdate();
        }

        private void InitializeTemplates()
        {
            cbTemplate.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(Helpers.Strings.Data.DataRootDir, "*.break");
                cbTemplate.Items.AddRange(files.Select((string filePath) => Path.GetFileNameWithoutExtension(filePath)).ToArray());
            }
            catch { MessageBox.Show("No template files found."); }
        }

        private void tweaksTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tweaksTree.BeginUpdate();

            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            tweaksTree.EndUpdate();
        }

        // Search nodes recursive
        private bool SearchTreeNodes(IEnumerable nodes, string searchFor)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(searchFor))
                {
                    tweaksTree.SelectedNode = node;
                    node.BackColor = Color.Yellow;
                    tweaksTree.Focus();
                }
                if (SearchTreeNodes(node.Nodes, searchFor))
                    return true;
            }
            return false;
        }

        // Check favored parent node including all child nodes
        public void CheckNodes(TreeNode startNode)
        {
            startNode.Checked = true;

            foreach (TreeNode node in startNode.Nodes)

                CheckNodes(node);
        }

        private List<TweaksNode> CollectTweaksNodes()
        {
            List<TweaksNode> selectedTweaks = new List<TweaksNode>();

            foreach (TreeNode treeNode in tweaksTree.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(TweaksNode))
                {
                    selectedTweaks.Add((TweaksNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedTweaks.Count);

            return selectedTweaks;
        }

        private void Reset()
        {
            progression = 0;
            progressionIncrease = 0;

            progress.Value = 0;
            progress.Visible = true;
            richStatus.Text = "";
        }

        private void DoProgress(int value)
        {
            progression = value;
            progress.Value = progression;
        }

        private void IncrementProgress()
        {
            progression += progressionIncrease;
            progress.Value = progression;
        }

        private async void ApplyTweaks(List<TweaksNode> treeNodes)
        {
            btnApply.Enabled = false;
            btnUndo.Enabled = false;
            tweaksTree.Enabled = false;

            foreach (TweaksNode node in treeNodes)
            {
                var setting = node.Tweak;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => setting.DoTweak()).ConfigureAwait(true);

                gbView.Text = "Fixing " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);

            btnApply.Enabled = true;
            btnUndo.Enabled = true;
            tweaksTree.Enabled = true;
        }

        private async void UndoTweaks(List<TweaksNode> treeNodes)
        {
            btnUndo.Enabled = false;
            btnApply.Enabled = false;
            tweaksTree.Enabled = false;

            foreach (TweaksNode node in treeNodes)
            {
                var setting = node.Tweak;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => setting.UndoTweak()).ConfigureAwait(true);

                gbView.Text = "Undo " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);

            btnUndo.Enabled = true;
            btnApply.Enabled = true;
            tweaksTree.Enabled = true;
        }

        private void SelectTweaksNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectTweaksNodes(trNode.Nodes, isCheck);
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            Reset();
            int performTweaksCount = 0;
            sc.Panel2.Enabled = false;

            List<TweaksNode> selectedTweaks = CollectTweaksNodes();

            foreach (TweaksNode node in selectedTweaks)
            {
                var setting = node.Tweak;
                ListViewItem detail = new ListViewItem(setting.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => setting.CheckTweak()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                gbView.Text = "Check " + node.Text;
                tweaksTree.SelectedNode = node;
                tweaksTree.Focus();

                if (shouldPerform)
                {
                    logger.Log("Should be fixed: {0}", node.Text);
                    // logger.Log("- {0}", node.Text);

                    performTweaksCount += 1;
                }
                else
                {
                    node.Checked = false; //uncheck all fixed
                    // logger.Log("Already fixed: {0}", node.Text);
                }
            }

            DoProgress(100);

            // Add summary
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Results =======\n");
            sum.Append($"{selectedTweaks.Count} issues has been checked.\r\n");
            sum.Append($"{selectedTweaks.Count - performTweaksCount} issues already fixed (we've unchecked it).\r\n");
            sum.Append(Environment.NewLine);
            sum.Append($"{performTweaksCount} issues needs to be fixed (just a recommendation).\r\n");
            logger.Log(sum.ToString(), "");

            gbView.Text = performTweaksCount + " of " + selectedTweaks.Count + " settings requires attention.";
            sc.Panel2.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Reset();

            List<TweaksNode> performNodes = CollectTweaksNodes();
            ApplyTweaks(performNodes);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to revert all selected settings to default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<TweaksNode> performNodes = CollectTweaksNodes();
                UndoTweaks(performNodes);
            }
        }

        private void ResetColorNode(TreeNodeCollection nodes, Color Color)
        {
            foreach (TreeNode child in nodes)
            {
                child.BackColor = Color;
                if (child.Nodes != null && child.Nodes.Count > 0)
                    ResetColorNode(child.Nodes, Color);
            }
        }

        private void btnTemplateImport_Click(object sender, EventArgs e)
        {
            ResetColorNode(tweaksTree.Nodes, Color.Transparent);
            SelectTweaksNodes(tweaksTree.Nodes, false);
            tweaksTree.ExpandAll();
            tweaksTree.Nodes[0].EnsureVisible();

            try
            {
                using (StreamReader reader = new StreamReader(Helpers.Strings.Data.DataRootDir + cbTemplate.Text + ".break"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        foreach (TreeNode treeNode in tweaksTree.Nodes.All())
                        {
                            if (treeNode.Text.Contains(line))
                            {
                                treeNode.BackColor = Color.Yellow;
                                treeNode.Checked = true;
                                tweaksTree.SelectedNode = treeNode;
                            }
                        }
                    }
                    btnCheck.PerformClick();
                    logger.Log($"[{cbTemplate.Text} has been successfully loaded].\nWe have highlighted the configuration that would be enabled (no changes are done yet).");
                }
            }
            catch { MessageBox.Show("No template loaded."); }
        }

        private void btnTemplateExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;
            f.FileName = "breakingapp-template";
            f.Filter = "BreakingApp files *.break|*.break";

            if (f.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(f.OpenFile()))
                {
                    foreach (TreeNode treeNode in tweaksTree.Nodes.All())
                    {
                        if (!treeNode.Checked)
                            continue;
                        writer.WriteLine(String.Format("{0}", treeNode.Text));
                    }

                    writer.Close();
                }
                MessageBox.Show("Template has been successfully exported.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeTemplates(); // Refresh
            }
        }

        private void menuExpand_Click(object sender, EventArgs e)
        {
            menuExpand.Checked = !(menuExpand.Checked);

            tweaksTree.BeginUpdate();
            if (menuExpand.Checked == true)
            {
                tweaksTree.Nodes[0].ExpandAll();
                tweaksTree.Nodes[0].EnsureVisible();
            }
            else if (menuExpand.Checked == false)
                tweaksTree.Nodes[0].Collapse();

            tweaksTree.EndUpdate();
        }

        private void menuCheck_Click(object sender, EventArgs e)
        {
            menuCheck.Checked = !(menuCheck.Checked);

            if (menuCheck.Checked == true)
                SelectTweaksNodes(tweaksTree.Nodes, true);
            else
                SelectTweaksNodes(tweaksTree.Nodes, false);
        }

        private void menuSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            dlg.DefaultExt = ".txt";
            dlg.FileName = "breakingapp_log";
            dlg.RestoreDirectory = true;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, richStatus.Text, Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchFor = textSearch.Text.Trim().ToUpper();
                if (searchFor != "")
                {
                    if (tweaksTree.Nodes.Count > 0)
                    {
                        if (SearchTreeNodes(tweaksTree.Nodes, searchFor))
                        {
                            tweaksTree.SelectedNode.Expand();
                            tweaksTree.Focus();
                        }
                    }
                }
            }
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
            ResetColorNode(tweaksTree.Nodes, Color.Transparent);
        }

        private void tweaksTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tweaksTree.SelectedNode = tweaksTree.GetNodeAt(e.X, e.Y);

                // Configure .app-files marked with asterix
                if (tweaksTree.SelectedNode != null && tweaksTree.SelectedNode.Text.Contains("*"))
                {
                    contextMenuApp.Show(tweaksTree, e.Location);
                }
            }
        }

        private void tweaksTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tweaksTree.SelectedNode = tweaksTree.GetNodeAt(e.X, e.Y);
            if (tweaksTree.SelectedNode.Text.Contains("*"))

                btnOptions.Visible = true;
            else
                btnOptions.Visible = false;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            switch (tweaksTree.SelectedNode.Text)
            {
                case "*Block Windows telemetry with WindowsSpyBlocker":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "spy.txt");
                    break;

                case "*Uninstall broken Windows updates":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "brokenKB.app");
                    break;

                case "*Uninstaller":
                case "*Remove bloatware apps (community list)":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "uninstaller.app");
                    break;

                case "*Packages":
                case "*Install essential apps":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "packages.app");
                    break;

                default:
                    MessageBox.Show("No configuration options available.", tweaksTree.SelectedNode.Text);
                    break;
            }
        }

        private void menuFeatures_Click(object sender, EventArgs e)
        {
            using (var form = new FeaturesForm())

            {
                form.ShowDialog();
            }
        }

        private void menuAppConfigure_Click(object sender, EventArgs e) => btnOptions.PerformClick();

        private void richStatus_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnMenu_Click(object sender, EventArgs e) => this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuSendLog_Click(object sender, EventArgs e)
        {
            string header = this.Text + "\x20" + Program.GetCurrentVersionTostring() ;
            string body = "Copy paste your log to get help...";
            string uri = $"{Helpers.Strings.Uri.URL_GITREPO}/issues/new?labels=report&title={header}&body={body}";

            Process.Start(uri);
        }

        private void menuProjectURI_Click(object sender, EventArgs e) => Process.Start(Helpers.Strings.Uri.URL_GITREPO);

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfile = Helpers.Strings.Data.DataRootDir + "help.txt";
            if (File.Exists(helpfile))

                richStatus.Text = File.ReadAllText(helpfile);
            else
                richStatus.Text = "Feature not available. Add it via Menu > \"Add features\" ";
        }
    }
}