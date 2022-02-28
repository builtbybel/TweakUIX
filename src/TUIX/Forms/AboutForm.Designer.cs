
namespace TweakUIX
{
    partial class AboutForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.richInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnAppUpdate);
            this.groupBox.Controls.Add(this.richInfo);
            this.groupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Location = new System.Drawing.Point(2, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(524, 188);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "About Tweak UIX";
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnAppUpdate.Location = new System.Drawing.Point(378, 149);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnAppUpdate.TabIndex = 12;
            this.btnAppUpdate.Text = "Check for updates...";
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
            this.richInfo.Size = new System.Drawing.Size(503, 114);
            this.richInfo.TabIndex = 11;
            this.richInfo.Text = "";
            this.richInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richInfo_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 538);
            this.Controls.Add(this.groupBox);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richInfo;
        private System.Windows.Forms.Button btnAppUpdate;
    }
}