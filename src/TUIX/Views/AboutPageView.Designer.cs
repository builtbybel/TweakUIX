namespace TweakUIX
{
    partial class AboutPageView
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
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.richInfo = new System.Windows.Forms.RichTextBox();
            this.linkAppInfo = new System.Windows.Forms.LinkLabel();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnAppUpdate);
            this.groupBox.Controls.Add(this.richInfo);
            this.groupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Location = new System.Drawing.Point(21, 289);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(502, 203);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "About this App";
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnAppUpdate.Location = new System.Drawing.Point(366, 164);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnAppUpdate.TabIndex = 12;
            this.btnAppUpdate.Text = "Check for updates";
            this.btnAppUpdate.UseVisualStyleBackColor = true;
            this.btnAppUpdate.Click += new System.EventHandler(this.btnAppUpdate_Click);
            // 
            // richInfo
            // 
            this.richInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richInfo.BackColor = System.Drawing.SystemColors.Control;
            this.richInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInfo.Location = new System.Drawing.Point(15, 29);
            this.richInfo.Name = "richInfo";
            this.richInfo.ReadOnly = true;
            this.richInfo.Size = new System.Drawing.Size(481, 129);
            this.richInfo.TabIndex = 11;
            this.richInfo.Text = "";
            this.richInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richInfo_LinkClicked);
            // 
            // linkAppInfo
            // 
            this.linkAppInfo.AutoEllipsis = true;
            this.linkAppInfo.BackColor = System.Drawing.Color.Transparent;
            this.linkAppInfo.Location = new System.Drawing.Point(33, 13);
            this.linkAppInfo.Name = "linkAppInfo";
            this.linkAppInfo.Size = new System.Drawing.Size(393, 26);
            this.linkAppInfo.TabIndex = 21;
            this.linkAppInfo.TabStop = true;
            this.linkAppInfo.Text = "Remember this classic picture? \r\nClick here to learn more about this project...";
            this.linkAppInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAppInfo_LinkClicked);
            // 
            // picture1
            // 
            this.picture1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture1.ErrorImage = null;
            this.picture1.InitialImage = null;
            this.picture1.Location = new System.Drawing.Point(21, 57);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(502, 197);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 20;
            this.picture1.TabStop = false;
            this.tt.SetToolTip(this.picture1, "Click to change your desktop background image");
            this.picture1.Click += new System.EventHandler(this.SetWallper);
            // 
            // AboutPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.linkAppInfo);
            this.Controls.Add(this.picture1);
            this.Name = "AboutPageView";
            this.Size = new System.Drawing.Size(542, 577);
            this.Load += new System.EventHandler(this.AboutPageView_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnAppUpdate;
        private System.Windows.Forms.RichTextBox richInfo;
        private System.Windows.Forms.LinkLabel linkAppInfo;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.ToolTip tt;
    }
}
