using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweakUIX.ITreeNode;
using TweakUIX.Theming;

namespace TweakUIX
{
    public partial class MainForm : Form
    {
        private Helpers.OsHelper osInfo = new Helpers.OsHelper();

        private int progression = 0;
        private int progressionIncrease = 0;
        private bool bLoadTemplate = false;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        public Control INavPage;

        public MainForm()
        {
            this.InitializeComponent();

            INavPage = sc.Panel2.Controls[0]; // Default NavContent
            this.SetStyle();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Bunny73();                 // Init tweaks
            this.Bear35();                  // Init templates
            this.Piglet1(true);             // Starter plugin (optional)
        }

        // Some UI nicety
        private void SetStyle()
        {
            this.Size = new Size(800, 600);

            // Enables double-buffering here in sc.panel2 using reflection
            typeof(Panel).InvokeMember("DoubleBuffered",
             BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
             null, sc.Panel2, new object[] { true });

            // Some app info....
            lblInfo.Text = "Version " + Program.GetCurrentVersionTostring()
                                + "\n\nFor " + osInfo.GetChassisType() + "\x20"
                                + osInfo.IsWin11() + "\x20"
                                + osInfo.GetVersion() + "\x20"
                                + osInfo.Is64Bit();
            richStatus.Text = "Select a setting from the tree list at left or load a predefined template for Tweakomatic."
                              + "\n\nTo get help, click the ? in the upper right corner of the dialog."
                              + "\nThe help will appear in the \"Description \" box.";
        }

        private void SetView(Control tweakPage)
        {
            var control = tweakPage as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            sc.Panel2.Controls.Clear();
            sc.Panel2.Controls.Add(tweakPage);
        }

        private void tweaksTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "About":
                    this.SetView(new AboutPageView());                   // Set about view
                    break;

                case "Policy":
                    this.SetView(new PolicyPageView());                  // Set policy view
                    break; ;

                case "Desktop Icons":
                    this.SetView(new DesktopIconsPageView());            // Set desktop view
                    break; ;

                case "Drive Letters":
                    this.SetView(new DriveLettersPageView());            // Set drive letters view
                    break; ;

                case "*Plugins":
                    this.SetView(new PluginsPageView());                 // Set plugins view
                    break;

                default:                                                 // Set default view
                    sc.Panel2.Controls.Clear();
                    if (INavPage != null) sc.Panel2.Controls.Add(INavPage);
                    break;
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            TreeNode tn = tweaksTree.SelectedNode;

            if (tn == null)
            {
                this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);
                return;
            }
            switch (tn.Text)
            {
                case "*Block Windows telemetry with WindowsSpyBlocker":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "spy.txt");
                    break;

                case "*Uninstall broken Windows updates":
                    Process.Start("notepad.exe", Helpers.Strings.Data.DataRootDir + "brokenKB.app");
                    break;

                case "*Apps and Features":
                case "*Remove bloatware apps (community list)":
                    this.SetView(new AppsPageView());                   // Set apps & features view
                    break;

                case "*Packages":
                case "*Install essential apps":
                    this.SetView(new PackagesPageView());               // Set packages view
                    break;

                case "*Plugins":
                    menuFeatures.PerformClick();
                    break;

                default:
                    this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);
                    break;
            }
        }

        public void Bunny73()
        {
            // Why does Tweak UIX have functions called BEAR, BUNNY and PIGLET?
            // Just for fun........Thanks @Raymond, the father of Tweak UI https://devblogs.microsoft.com/oldnewthing/20030818-00/?p=42873

            tweaksTree.Nodes.Clear();
            tweaksTree.BeginUpdate();

            // Set logger to target richStatus
            logger.SetTarget(richStatus);

            // root node
            System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode("Tweak UI")
            {
                Checked = false,
            };

            System.Windows.Forms.TreeNode about = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            });

            System.Windows.Forms.TreeNode policy = new System.Windows.Forms.TreeNode("Policy", new System.Windows.Forms.TreeNode[] {
            });

            System.Windows.Forms.TreeNode explorer = new System.Windows.Forms.TreeNode("Explorer", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Explorer.FileExplorer()),
                new TweaksNode(new Tweaks.Explorer.HiddenFileFolder()),
                new TweaksNode(new Tweaks.Explorer.HiddenFileExt()),
            });

            System.Windows.Forms.TreeNode taskbar = new System.Windows.Forms.TreeNode("Taskbar and Start menu", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Taskbar.TaskbarAl()),
                new TweaksNode(new Tweaks.Taskbar.TaskbarSi()),
                new TweaksNode(new Tweaks.Taskbar.TaskbarMM()),
                new TweaksNode(new Tweaks.Taskbar.TaskbarSearch()),
                new TweaksNode(new Tweaks.Taskbar.TaskbarChat()),
                new TweaksNode(new Tweaks.Taskbar.TaskView()),
                new TweaksNode(new Tweaks.Taskbar.MostUsedApps()),
            }); CheckNodes(taskbar);

            System.Windows.Forms.TreeNode desktop = new System.Windows.Forms.TreeNode("Desktop", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Desktop.AppsTheme()),
                new TweaksNode(new Tweaks.Desktop.WindowsTheme()),
                new TweaksNode(new Tweaks.Desktop.Transparency()),
                new TweaksNode(new Tweaks.Desktop.SnapAssistFlyout()),
                new TweaksNode(new Tweaks.Desktop.Widgets()),
                new TweaksNode(new Tweaks.Desktop.WidgetsRemove()),
            }); CheckNodes(desktop);

            System.Windows.Forms.TreeNode system = new System.Windows.Forms.TreeNode("My Computer", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.System.RestorePoint()),
                new TweaksNode(new Tweaks.System.Fax()),
                new TweaksNode(new Tweaks.System.XPSWriter()),
                new TweaksNode(new Tweaks.System.RemoveW11Watermark()),
                new TweaksNode(new Tweaks.System.EnableWSL()),
                new TweaksNode(new Tweaks.System.InstallWSA()),
                new TweaksNode(new Tweaks.System.HyperV()),
                new TweaksNode(new Tweaks.System.TeamsAutostart()),
        }); ;

            System.Windows.Forms.TreeNode paranoia = new System.Windows.Forms.TreeNode("Paranoia", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Paranoia.CleanMgr()),
                new TweaksNode(new Tweaks.Paranoia.WindowsSpyBlocker()),
                new TweaksNode(new Tweaks.Paranoia.ShutUp11()),
            });

            System.Windows.Forms.TreeNode update = new System.Windows.Forms.TreeNode("Windows Update", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Update.Wuauserv()),
                new TweaksNode(new Tweaks.Update.Wusa()),
            });

            System.Windows.Forms.TreeNode gaming = new System.Windows.Forms.TreeNode("Gaming", new System.Windows.Forms.TreeNode[] {
                new TweaksNode(new Tweaks.Gaming.GameDVR()),
                new TweaksNode(new Tweaks.Gaming.PowerThrottling()),
                new TweaksNode(new Tweaks.Gaming.VisualFX()),
            });

            System.Windows.Forms.TreeNode privacy = new System.Windows.Forms.TreeNode("Privacy (disable)", new System.Windows.Forms.TreeNode[] {
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
            }); ;

            System.Windows.Forms.TreeNode apps = new System.Windows.Forms.TreeNode("Apps permissions (disable)", new System.Windows.Forms.TreeNode[] {
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

            System.Windows.Forms.TreeNode appsFeatures = new System.Windows.Forms.TreeNode("*Apps and Features", new System.Windows.Forms.TreeNode[] {
                 new TweaksNode(new Tweaks.App.Uninstaller()),
                 new TweaksNode(new Tweaks.App.InBoxApps()),
            })
            {
                ToolTipText = "Right-click on entry to configure this app",
            };

            System.Windows.Forms.TreeNode installer = new System.Windows.Forms.TreeNode("*Packages", new System.Windows.Forms.TreeNode[] {
                 new TweaksNode(new Tweaks.App.Packages()),
            })
            {
                ToolTipText = "Right-click on entry to configure this app",
            };

            System.Windows.Forms.TreeNode plugins = new System.Windows.Forms.TreeNode("*Plugins", new System.Windows.Forms.TreeNode[] {
            })
            {
                //ForeColor = Color.Gray,
                Checked = false,
            };

            root.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
            {
                about,
                policy,
                explorer,
                taskbar,
                desktop,
                system,
                paranoia,
                update,
                gaming,
                privacy,
                apps,
                appsFeatures,
                installer,
                plugins,
            });

            tweaksTree.Nodes.Add(root);

            // Extend X pages
            system.Nodes.Add("hidenseek", "Hide and Seek");
            system.Nodes["hidenseek"].Nodes.Add("Desktop Icons");
            system.Nodes["hidenseek"].Nodes.Add("Drive Letters");

            // Some tweaksTree nicety
            RemoveTreeNodeCheckmarks();
            foreach (System.Windows.Forms.TreeNode tn in tweaksTree.Nodes) { tn.Expand(); }
            tweaksTree.SelectedNode = tweaksTree.Nodes[0].Nodes[0]; // Preselect about tree

            tweaksTree.EndUpdate();
        }

        private void Bear35()
        {
            cbTemplate.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(Helpers.Strings.Data.DataRootDir, "*.tuix");
                cbTemplate.Items.AddRange(files.Select((string filePath) => Path.GetFileNameWithoutExtension(filePath)).ToArray());
            }
            catch { MessageBox.Show("No template files found."); }
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

        private void tweaksTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tweaksTree.BeginUpdate();

            foreach (System.Windows.Forms.TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            RemoveTreeNodeCheckmarks();
            tweaksTree.EndUpdate();
        }

        // Remove checkmarks
        private void RemoveTreeNodeCheckmarks()
        {
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[0]);     // About
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[1]);     // Policy
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[13]);    // Plugins

            // Hide and Seek tree
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[5].Nodes[8]);
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[5].Nodes[8].Nodes[0]);
            TreeNodeTheming.RemoveCheckmarks(tweaksTree, tweaksTree.Nodes[0].Nodes[5].Nodes[8].Nodes[1]);
        }

        // Check favored parent node including all child nodes
        public void CheckNodes(System.Windows.Forms.TreeNode startNode)
        {
            startNode.Checked = true;

            foreach (System.Windows.Forms.TreeNode node in startNode.Nodes)

                CheckNodes(node);
        }

        private List<TweaksNode> CollectTweaksNodes()
        {
            List<TweaksNode> selectedTweaks = new List<TweaksNode>();

            foreach (System.Windows.Forms.TreeNode treeNode in tweaksTree.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(TweaksNode))
                {
                    selectedTweaks.Add((TweaksNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedTweaks.Count);

            return selectedTweaks;
        }

        private async void ApplyTweaks(List<TweaksNode> treeNodes)
        {
            btnApply.Enabled = false;
            btnUndo.Enabled = false;
            tweaksTree.Enabled = false;

            foreach (TweaksNode node in treeNodes)
            {
                var tweak = node.Tweak;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => tweak.DoTweak()).ConfigureAwait(true);

                groupBox.Text = "Applying " + node.Text;

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
                var tweak = node.Tweak;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => tweak.UndoTweak()).ConfigureAwait(true);

                groupBox.Text = "Undo " + node.Text;

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
            foreach (System.Windows.Forms.TreeNode trNode in trNodeCollection)
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
                var tweak = node.Tweak;
                ListViewItem detail = new ListViewItem(tweak.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => tweak.CheckTweak()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                groupBox.Text = "Check " + node.Text;
                tweaksTree.SelectedNode = node;
                tweaksTree.Focus();

                if (shouldPerform)
                {
                    logger.Log("Should be applied: {0}", node.Text);
                    // logger.Log("- {0}", node.Text);

                    performTweaksCount += 1;
                }
                else
                {
                    node.Checked = false; //uncheck all applied
                                          // logger.Log("Already applied: {0}", node.Text);
                }
            }

            DoProgress(100);

            // Add summary
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Results =======\n");
            sum.Append($"{selectedTweaks.Count} issues has been checked.\r\n");
            sum.Append($"{selectedTweaks.Count - performTweaksCount} tweaks already applied (we've unchecked it).\r\n");
            sum.Append(Environment.NewLine);
            sum.Append($"{performTweaksCount} tweaks needs to be applied (just a recommendation).\r\n");
            logger.Log(sum.ToString(), "");

            groupBox.Text = performTweaksCount + " of " + selectedTweaks.Count + " issues requires attention.";
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
            foreach (System.Windows.Forms.TreeNode child in nodes)
            {
                child.BackColor = Color;
                if (child.Nodes != null && child.Nodes.Count > 0)
                    ResetColorNode(child.Nodes, Color);
            }
        }

        private void btnTemplateLoad_Click(object sender, EventArgs e)
        {
            bLoadTemplate = true;
            Piglet1(false);
        }

        private void Piglet1(bool isStarter = false)
        {
            string filePath = Helpers.Strings.Data.DataRootDir + "startup.tuix";

            if (isStarter && File.Exists(filePath))
            {
                SelectTweaksNodes(tweaksTree.Nodes, false);
                richStatus.Clear();
                logger.Log("The following startup configuration has been loaded:");

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        foreach (System.Windows.Forms.TreeNode treeNode in tweaksTree.Nodes.All())
                        {
                            if (treeNode.Text.Contains(line))
                            {
                                treeNode.BackColor = Color.Yellow;
                                treeNode.Checked = true;
                                tweaksTree.SelectedNode = treeNode;
                            }
                        }
                        logger.Log("- " + line);
                    }
                    if (new FileInfo(filePath).Length == 0) logger.Log("- Empty configuration loaded.");
                }
            }

            if (bLoadTemplate)
            {
                ResetColorNode(tweaksTree.Nodes, Color.Transparent);
                SelectTweaksNodes(tweaksTree.Nodes, false);
                tweaksTree.ExpandAll();
                tweaksTree.Nodes[0].EnsureVisible();

                try
                {
                    using (StreamReader reader = new StreamReader(Helpers.Strings.Data.DataRootDir + cbTemplate.Text + ".tuix"))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            foreach (System.Windows.Forms.TreeNode treeNode in tweaksTree.Nodes.All())
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
        }

        private void btnTemplateSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;
            f.FileName = "TweakUIX-template";
            f.Filter = "TweakUIX files *.tuix|*.tuix";

            if (f.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(f.OpenFile()))
                {
                    foreach (System.Windows.Forms.TreeNode treeNode in tweaksTree.Nodes.All())
                    {
                        if (!treeNode.Checked)
                            continue;
                        writer.WriteLine(string.Format("{0}", treeNode.Text));
                    }

                    writer.Close();
                }
                MessageBox.Show("Template has been successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bear35();
            }
        }

        private void menuExpand_Click(object sender, EventArgs e) => tweaksTree.Nodes[0].ExpandAll();

        private void menuCheck_Click(object sender, EventArgs e) => SelectTweaksNodes(tweaksTree.Nodes, true);

        private void textSearch_Click(object sender, EventArgs e)
        { textSearch.Clear(); ResetColorNode(tweaksTree.Nodes, Color.Transparent); }

        private void menuSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            dlg.DefaultExt = ".txt";
            dlg.FileName = "tuix_log";
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

        // Search nodes recursive
        private bool SearchTreeNodes(IEnumerable nodes, string searchFor)
        {
            foreach (System.Windows.Forms.TreeNode node in nodes)
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

        private void menuFeatures_Click(object sender, EventArgs e)
        {
            using (var form = new FeaturesForm())

            {
                form.ShowDialog();
            }
        }

        private void menuSendLog_Click(object sender, EventArgs e)
        {
            string header = this.Text + "\x20" + Program.GetCurrentVersionTostring();
            string body = "Copy paste your log to get help...";
            string uri = $"{Helpers.Strings.Uri.URL_GITREPO}/issues/new?labels=report&title={header}&body={body}";

            Process.Start(uri);
        }

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string helpfile = Helpers.Strings.Data.DataRootDir + "help.txt";
            richStatus.Focus();

            if (!richStatus.Focused) { MessageBox.Show("Not supported in this view."); return; }
            if (File.Exists(helpfile))
                richStatus.Text = File.ReadAllText(helpfile);
            else MessageBox.Show("Feature not available. Add it via Options > \"Add features\".");

            e.Cancel = true;
        }

        private void menuAppConfigure_Click(object sender, EventArgs e) => btnOptions.PerformClick();

        private void richStatus_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void menuProjectURI_Click(object sender, EventArgs e) => Process.Start(Helpers.Strings.Uri.URL_GITREPO);

        private void lnkRunTweakomatic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(@"tweakomatic.exe")) Process.Start(@"tweakomatic.exe");
            else MessageBox.Show("Tweakomatic not found.\nYou can get it from here: https://github.com/builtbybel/Tweakomatic");
        }
    }
}