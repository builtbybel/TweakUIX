
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
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.listPlugs = new System.Windows.Forms.CheckedListBox();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.richPluginInfo = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.grpBox.Location = new System.Drawing.Point(3, 5);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(514, 226);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Plugins for Tweak UI";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(15, 19);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(492, 5);
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
            this.listPlugs.Size = new System.Drawing.Size(493, 180);
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
            this.richStatus.Size = new System.Drawing.Size(479, 0);
            this.richStatus.TabIndex = 1;
            this.richStatus.Text = "";
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
            this.richPluginInfo.Size = new System.Drawing.Size(493, 178);
            this.richPluginInfo.TabIndex = 11;
            this.richPluginInfo.Text = "You will find here plugin files for TweakUIX.\nTo install new plugins goto Menu > " +
    "Add features.\n\n";
            this.richPluginInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richPluginInfo_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(436, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(3, 48);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 531);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(529, 92);
            this.pnlBottom.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richPluginInfo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(3, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 213);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(529, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpBox);
            this.Name = "PluginsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Plugins";
            this.grpBox.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.CheckedListBox listPlugs;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.RichTextBox richPluginInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}