namespace TibiaXBot.Updater
{
    partial class UpdateInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nver = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_update = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installed Version";
            // 
            // cver
            // 
            this.cver.AutoSize = true;
            this.cver.Location = new System.Drawing.Point(8, 6);
            this.cver.Name = "cver";
            this.cver.Size = new System.Drawing.Size(13, 13);
            this.cver.TabIndex = 2;
            this.cver.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Version";
            // 
            // nver
            // 
            this.nver.AutoSize = true;
            this.nver.Location = new System.Drawing.Point(8, 24);
            this.nver.Name = "nver";
            this.nver.Size = new System.Drawing.Size(13, 13);
            this.nver.TabIndex = 4;
            this.nver.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cver);
            this.splitContainer1.Panel2.Controls.Add(this.nver);
            this.splitContainer1.Size = new System.Drawing.Size(151, 44);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 9;
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(2, 51);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 22);
            this.b_update.TabIndex = 10;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 76);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Update Info";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nver;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_update;

    }
}