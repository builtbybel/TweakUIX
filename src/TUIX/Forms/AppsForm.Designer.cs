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
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.listRemove = new System.Windows.Forms.ListBox();
            this.groupInstalled = new System.Windows.Forms.GroupBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listApps = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBin.SuspendLayout();
            this.groupInstalled.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBin
            // 
            this.groupBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBin.Controls.Add(this.btnRestoreAll);
            this.groupBin.Controls.Add(this.btnRestore);
            this.groupBin.Controls.Add(this.listRemove);
            this.groupBin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBin.Location = new System.Drawing.Point(1, 9);
            this.groupBin.Name = "groupBin";
            this.groupBin.Size = new System.Drawing.Size(524, 267);
            this.groupBin.TabIndex = 19;
            this.groupBin.TabStop = false;
            this.groupBin.Text = "Recycle bin";
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(335, 238);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreAll.TabIndex = 15;
            this.btnRestoreAll.Text = "Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(416, 238);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 14;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
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
            this.listRemove.Size = new System.Drawing.Size(502, 208);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // groupInstalled
            // 
            this.groupInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInstalled.Controls.Add(this.checkAppsSystem);
            this.groupInstalled.Controls.Add(this.btnAddAll);
            this.groupInstalled.Controls.Add(this.btnBack);
            this.groupInstalled.Controls.Add(this.listApps);
            this.groupInstalled.Controls.Add(this.btnAdd);
            this.groupInstalled.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupInstalled.Location = new System.Drawing.Point(1, 282);
            this.groupInstalled.Name = "groupInstalled";
            this.groupInstalled.Size = new System.Drawing.Size(524, 248);
            this.groupInstalled.TabIndex = 20;
            this.groupInstalled.TabStop = false;
            this.groupInstalled.Text = "Installed apps";
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Red;
            this.checkAppsSystem.Location = new System.Drawing.Point(12, 208);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(114, 17);
            this.checkAppsSystem.TabIndex = 16;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAll.ForeColor = System.Drawing.Color.Black;
            this.btnAddAll.Location = new System.Drawing.Point(336, 207);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 15;
            this.btnAddAll.Text = "Add all";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(255, 207);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.listApps.Size = new System.Drawing.Size(502, 182);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(416, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 538);
            this.Controls.Add(this.groupBin);
            this.Controls.Add(this.groupInstalled);
            this.Name = "AppsForm";
            this.ShowIcon = false;
            this.Text = "Apps";
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.CheckBox checkAppsSystem;
    }
}