namespace TweakUIX
{
    partial class AppsForm
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
            this.groupBin = new System.Windows.Forms.GroupBox();
            this.listRemove = new System.Windows.Forms.ListBox();
            this.btnAddFeature = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupInstalled = new System.Windows.Forms.GroupBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.listApps = new System.Windows.Forms.ListBox();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBin.SuspendLayout();
            this.groupInstalled.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBin
            // 
            this.groupBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBin.Controls.Add(this.listRemove);
            this.groupBin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBin.Location = new System.Drawing.Point(1, 9);
            this.groupBin.Name = "groupBin";
            this.groupBin.Size = new System.Drawing.Size(411, 267);
            this.groupBin.TabIndex = 19;
            this.groupBin.TabStop = false;
            this.groupBin.Text = "Recycle bin";
            // 
            // listRemove
            // 
            this.listRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemove.BackColor = System.Drawing.SystemColors.Control;
            this.listRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRemove.FormattingEnabled = true;
            this.listRemove.Location = new System.Drawing.Point(11, 19);
            this.listRemove.Name = "listRemove";
            this.listRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemove.Size = new System.Drawing.Size(394, 234);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFeature.ForeColor = System.Drawing.Color.Black;
            this.btnAddFeature.Location = new System.Drawing.Point(418, 57);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(81, 23);
            this.btnAddFeature.TabIndex = 17;
            this.btnAddFeature.Text = "Add feature\r\n";
            this.btnAddFeature.UseVisualStyleBackColor = true;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(418, 28);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 23);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(419, 127);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(80, 23);
            this.btnRestoreAll.TabIndex = 15;
            this.btnRestoreAll.Text = "Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(419, 150);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 23);
            this.btnRestore.TabIndex = 14;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(419, 86);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupInstalled
            // 
            this.groupInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInstalled.Controls.Add(this.checkAppsSystem);
            this.groupInstalled.Controls.Add(this.listApps);
            this.groupInstalled.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupInstalled.Location = new System.Drawing.Point(1, 282);
            this.groupInstalled.Name = "groupInstalled";
            this.groupInstalled.Size = new System.Drawing.Size(411, 212);
            this.groupInstalled.TabIndex = 20;
            this.groupInstalled.TabStop = false;
            this.groupInstalled.Text = "Installed apps";
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Red;
            this.checkAppsSystem.Location = new System.Drawing.Point(11, 183);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(114, 17);
            this.checkAppsSystem.TabIndex = 16;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // listApps
            // 
            this.listApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listApps.BackColor = System.Drawing.SystemColors.Control;
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.FormattingEnabled = true;
            this.listApps.Location = new System.Drawing.Point(11, 19);
            this.listApps.Name = "listApps";
            this.listApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listApps.Size = new System.Drawing.Size(394, 156);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(419, 352);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(80, 23);
            this.btnMoveAll.TabIndex = 15;
            this.btnMoveAll.Text = "Move all";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(419, 375);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(80, 23);
            this.btnMove.TabIndex = 12;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(419, 503);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(526, 538);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.groupBin);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.groupInstalled);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnOK);
            this.Name = "AppsForm";
            this.ShowIcon = false;
            this.Text = "Apps";
            this.Load += new System.EventHandler(this.AppsForm_Load);
            this.Shown += new System.EventHandler(this.AppsForm_Shown);
            this.Leave += new System.EventHandler(this.AppsForm_Leave);
            this.groupBin.ResumeLayout(false);
            this.groupInstalled.ResumeLayout(false);
            this.groupInstalled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBin;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.GroupBox groupInstalled;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddFeature;
        private System.Windows.Forms.Button btnRefresh;
    }
}