namespace TweakUIX
{
    partial class AppsPageView
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
            this.groupBin = new System.Windows.Forms.GroupBox();
            this.listRemove = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddFeature = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.groupInstalled = new System.Windows.Forms.GroupBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.listApps = new System.Windows.Forms.ListBox();
            this.btnRestore = new System.Windows.Forms.Button();
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
            this.groupBin.Location = new System.Drawing.Point(3, 3);
            this.groupBin.Name = "groupBin";
            this.groupBin.Size = new System.Drawing.Size(411, 267);
            this.groupBin.TabIndex = 29;
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(421, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFeature.ForeColor = System.Drawing.Color.Black;
            this.btnAddFeature.Location = new System.Drawing.Point(420, 51);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(81, 23);
            this.btnAddFeature.TabIndex = 27;
            this.btnAddFeature.Text = "Add feature\r\n";
            this.btnAddFeature.UseVisualStyleBackColor = true;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(420, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(421, 121);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(80, 23);
            this.btnRestoreAll.TabIndex = 24;
            this.btnRestoreAll.Text = "Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // groupInstalled
            // 
            this.groupInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInstalled.Controls.Add(this.checkAppsSystem);
            this.groupInstalled.Controls.Add(this.listApps);
            this.groupInstalled.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupInstalled.Location = new System.Drawing.Point(3, 276);
            this.groupInstalled.Name = "groupInstalled";
            this.groupInstalled.Size = new System.Drawing.Size(411, 269);
            this.groupInstalled.TabIndex = 30;
            this.groupInstalled.TabStop = false;
            this.groupInstalled.Text = "Installed apps";
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Red;
            this.checkAppsSystem.Location = new System.Drawing.Point(11, 240);
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
            this.listApps.Size = new System.Drawing.Size(394, 208);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(421, 144);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 23);
            this.btnRestore.TabIndex = 22;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(420, 382);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(80, 23);
            this.btnMoveAll.TabIndex = 25;
            this.btnMoveAll.Text = "Move all";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(420, 405);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(80, 23);
            this.btnMove.TabIndex = 21;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(334, 551);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AppsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.groupInstalled);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnOK);
            this.Name = "AppsPageView";
            this.Size = new System.Drawing.Size(542, 577);
            this.Leave += new System.EventHandler(this.AppsPageView_Leave);
            this.groupBin.ResumeLayout(false);
            this.groupInstalled.ResumeLayout(false);
            this.groupInstalled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBin;
        private System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddFeature;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.GroupBox groupInstalled;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnOK;
    }
}
