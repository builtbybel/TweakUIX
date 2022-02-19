
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
            this.gbView = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPluginInfo = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.listPlugs = new System.Windows.Forms.CheckedListBox();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.gbView.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbView
            // 
            this.gbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbView.BackColor = System.Drawing.SystemColors.Control;
            this.gbView.Controls.Add(this.lblHeader);
            this.gbView.Controls.Add(this.lblPluginInfo);
            this.gbView.Controls.Add(this.progress);
            this.gbView.Controls.Add(this.listPlugs);
            this.gbView.Controls.Add(this.richStatus);
            this.gbView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbView.Location = new System.Drawing.Point(3, 5);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(514, 520);
            this.gbView.TabIndex = 3;
            this.gbView.TabStop = false;
            this.gbView.Text = "Plugins for Tweak UI";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(15, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(483, 38);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "You will find here plugin files for TweakUIX.\r\nTo install new plugins goto Menu >" +
    " Add features\r\n\r\n";
            // 
            // lblPluginInfo
            // 
            this.lblPluginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginInfo.AutoEllipsis = true;
            this.lblPluginInfo.ForeColor = System.Drawing.Color.Black;
            this.lblPluginInfo.Location = new System.Drawing.Point(15, 309);
            this.lblPluginInfo.Name = "lblPluginInfo";
            this.lblPluginInfo.Size = new System.Drawing.Size(489, 194);
            this.lblPluginInfo.TabIndex = 9;
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(12, 19);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(489, 5);
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
            this.listPlugs.Location = new System.Drawing.Point(15, 72);
            this.listPlugs.Name = "listPlugs";
            this.listPlugs.Size = new System.Drawing.Size(486, 225);
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
            this.richStatus.Size = new System.Drawing.Size(496, 185);
            this.richStatus.TabIndex = 1;
            this.richStatus.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(436, 3);
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
            this.btnApply.Location = new System.Drawing.Point(3, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(99, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply selected";
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
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(529, 623);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.gbView);
            this.Name = "PluginsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PluginsForm";
            this.gbView.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.CheckedListBox listPlugs;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPluginInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlBottom;
    }
}