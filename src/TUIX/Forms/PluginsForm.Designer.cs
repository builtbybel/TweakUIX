
namespace TweakUIX
{
    partial class PluginsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.listPlugs = new System.Windows.Forms.CheckedListBox();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richPluginInfo = new System.Windows.Forms.RichTextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richHelp = new System.Windows.Forms.RichTextBox();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listTweaks = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.HotTrack = true;
            this.tab.Location = new System.Drawing.Point(-2, 1);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(527, 535);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.grpBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pnlBottom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plugins";
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpBox.Controls.Add(this.progress);
            this.grpBox.Controls.Add(this.listPlugs);
            this.grpBox.Controls.Add(this.richStatus);
            this.grpBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpBox.Location = new System.Drawing.Point(6, 4);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(506, 226);
            this.grpBox.TabIndex = 13;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Plugins for Tweak UI";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(15, 19);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(484, 5);
            this.progress.TabIndex = 6;
            this.progress.Visible = false;
            // 
            // listPlugs
            // 
            this.listPlugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlugs.BackColor = System.Drawing.SystemColors.Control;
            this.listPlugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPlugs.FormattingEnabled = true;
            this.listPlugs.Location = new System.Drawing.Point(15, 30);
            this.listPlugs.Name = "listPlugs";
            this.listPlugs.Size = new System.Drawing.Size(485, 180);
            this.listPlugs.TabIndex = 4;
            this.listPlugs.SelectedIndexChanged += new System.EventHandler(this.listPlugs_SelectedIndexChanged);
            // 
            // richStatus
            // 
            this.richStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richStatus.AutoWordSelection = true;
            this.richStatus.BackColor = System.Drawing.SystemColors.Control;
            this.richStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richStatus.HideSelection = false;
            this.richStatus.Location = new System.Drawing.Point(12, 72);
            this.richStatus.Name = "richStatus";
            this.richStatus.Size = new System.Drawing.Size(471, 0);
            this.richStatus.TabIndex = 1;
            this.richStatus.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richPluginInfo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(6, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 172);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // richPluginInfo
            // 
            this.richPluginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richPluginInfo.BackColor = System.Drawing.SystemColors.Control;
            this.richPluginInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richPluginInfo.Location = new System.Drawing.Point(15, 29);
            this.richPluginInfo.Name = "richPluginInfo";
            this.richPluginInfo.ReadOnly = true;
            this.richPluginInfo.Size = new System.Drawing.Size(485, 137);
            this.richPluginInfo.TabIndex = 11;
            this.richPluginInfo.Text = "You will find here plugin files for TweakUIX.\nTo install new plugins goto Menu > " +
    "Add features.\n\n";
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(3, 414);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(513, 92);
            this.pnlBottom.TabIndex = 14;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(0, 66);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(414, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.richHelp);
            this.tabPage2.Controls.Add(this.listCategory);
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced plugins";
            // 
            // richHelp
            // 
            this.richHelp.BackColor = System.Drawing.SystemColors.Info;
            this.richHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richHelp.Location = new System.Drawing.Point(3, 435);
            this.richHelp.Name = "richHelp";
            this.richHelp.ReadOnly = true;
            this.richHelp.Size = new System.Drawing.Size(513, 71);
            this.richHelp.TabIndex = 10;
            this.richHelp.Text = "";
            this.richHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richHelp_LinkClicked);
            // 
            // listCategory
            // 
            this.listCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listCategory.BackColor = System.Drawing.SystemColors.Control;
            this.listCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Location = new System.Drawing.Point(7, 16);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(154, 416);
            this.listCategory.TabIndex = 7;
            this.listCategory.SelectedIndexChanged += new System.EventHandler(this.listCategory_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(167, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listTweaks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(349, 428);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 8;
            // 
            // listTweaks
            // 
            this.listTweaks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTweaks.BackColor = System.Drawing.SystemColors.Control;
            this.listTweaks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTweaks.FormattingEnabled = true;
            this.listTweaks.Location = new System.Drawing.Point(7, 10);
            this.listTweaks.Name = "listTweaks";
            this.listTweaks.Size = new System.Drawing.Size(126, 416);
            this.listTweaks.TabIndex = 5;
            this.listTweaks.SelectedIndexChanged += new System.EventHandler(this.listTweaks_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(7, 10);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(192, 414);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(519, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scriptomatic";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(526, 538);
            this.Controls.Add(this.tab);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Plugins";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckedListBox listPlugs;
        private System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richPluginInfo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listTweaks;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox richHelp;
        private System.Windows.Forms.TabPage tabPage3;
    }
}