namespace TweakUIX
{
    partial class PluginsPageView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richHelp = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTweak = new System.Windows.Forms.Label();
            this.lblTweakCategory = new System.Windows.Forms.Label();
            this.lblComponentCategory = new System.Windows.Forms.Label();
            this.comboTweaks = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.richPluginInfo = new System.Windows.Forms.RichTextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.listPlugs = new System.Windows.Forms.CheckedListBox();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.groupBoxPlugins = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPlugins.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(519, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scriptomatic";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richHelp
            // 
            this.richHelp.BackColor = System.Drawing.SystemColors.Info;
            this.richHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richHelp.Location = new System.Drawing.Point(3, 471);
            this.richHelp.Name = "richHelp";
            this.richHelp.ReadOnly = true;
            this.richHelp.Size = new System.Drawing.Size(513, 71);
            this.richHelp.TabIndex = 10;
            this.richHelp.Text = "";
            this.richHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richHelp_LinkClicked);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(10, 174);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(503, 281);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblTweak);
            this.tabPage2.Controls.Add(this.lblTweakCategory);
            this.tabPage2.Controls.Add(this.lblComponentCategory);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.comboTweaks);
            this.tabPage2.Controls.Add(this.comboCategory);
            this.tabPage2.Controls.Add(this.richHelp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plus Pack";
            // 
            // lblTweak
            // 
            this.lblTweak.AutoSize = true;
            this.lblTweak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweak.Location = new System.Drawing.Point(21, 156);
            this.lblTweak.Name = "lblTweak";
            this.lblTweak.Size = new System.Drawing.Size(229, 13);
            this.lblTweak.TabIndex = 16;
            this.lblTweak.Text = "Select an individual tweak from this list";
            // 
            // lblTweakCategory
            // 
            this.lblTweakCategory.AutoSize = true;
            this.lblTweakCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweakCategory.Location = new System.Drawing.Point(21, 91);
            this.lblTweakCategory.Name = "lblTweakCategory";
            this.lblTweakCategory.Size = new System.Drawing.Size(217, 13);
            this.lblTweakCategory.TabIndex = 15;
            this.lblTweakCategory.Text = "Select a tweak category from this list";
            // 
            // lblComponentCategory
            // 
            this.lblComponentCategory.AutoSize = true;
            this.lblComponentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentCategory.Location = new System.Drawing.Point(21, 27);
            this.lblComponentCategory.Name = "lblComponentCategory";
            this.lblComponentCategory.Size = new System.Drawing.Size(264, 13);
            this.lblComponentCategory.TabIndex = 13;
            this.lblComponentCategory.Text = "Select a manageable component from this list";
            // 
            // comboTweaks
            // 
            this.comboTweaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTweaks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTweaks.FormattingEnabled = true;
            this.comboTweaks.Location = new System.Drawing.Point(10, 107);
            this.comboTweaks.Name = "comboTweaks";
            this.comboTweaks.Size = new System.Drawing.Size(489, 21);
            this.comboTweaks.TabIndex = 12;
            this.comboTweaks.SelectedIndexChanged += new System.EventHandler(this.listPlusPackTweaks);
            // 
            // comboCategory
            // 
            this.comboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(10, 43);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(489, 21);
            this.comboCategory.TabIndex = 11;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.listPlusPackCategory);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(23, 66);
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
            this.btnCancel.Location = new System.Drawing.Point(411, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.Controls.Add(this.richPluginInfo);
            this.groupBoxInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxInfo.Location = new System.Drawing.Point(6, 236);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(506, 208);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Description";
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
            this.richPluginInfo.Size = new System.Drawing.Size(485, 173);
            this.richPluginInfo.TabIndex = 11;
            this.richPluginInfo.Text = "You will find here plugin files for TweakUIX.\nTo install new plugins goto Options" +
    " > Add features.\n\n";
            this.richPluginInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richPluginInfo_LinkClicked);
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
            // groupBoxPlugins
            // 
            this.groupBoxPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlugins.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxPlugins.Controls.Add(this.progress);
            this.groupBoxPlugins.Controls.Add(this.listPlugs);
            this.groupBoxPlugins.Controls.Add(this.richStatus);
            this.groupBoxPlugins.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxPlugins.Location = new System.Drawing.Point(6, 4);
            this.groupBoxPlugins.Name = "groupBoxPlugins";
            this.groupBoxPlugins.Size = new System.Drawing.Size(506, 226);
            this.groupBoxPlugins.TabIndex = 13;
            this.groupBoxPlugins.TabStop = false;
            this.groupBoxPlugins.Text = "Plugins for Tweak UI";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBoxPlugins);
            this.tabPage1.Controls.Add(this.groupBoxInfo);
            this.tabPage1.Controls.Add(this.pnlBottom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plugins";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Location = new System.Drawing.Point(3, 450);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(513, 92);
            this.pnlBottom.TabIndex = 14;
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
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(527, 571);
            this.tab.TabIndex = 1;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // PluginsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab);
            this.Name = "PluginsPageView";
            this.Size = new System.Drawing.Size(542, 577);
            this.Load += new System.EventHandler(this.PluginsPageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxPlugins.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richHelp;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.RichTextBox richPluginInfo;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckedListBox listPlugs;
        private System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.GroupBox groupBoxPlugins;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboTweaks;
        private System.Windows.Forms.Label lblTweakCategory;
        private System.Windows.Forms.Label lblComponentCategory;
        private System.Windows.Forms.Label lblTweak;
    }
}
