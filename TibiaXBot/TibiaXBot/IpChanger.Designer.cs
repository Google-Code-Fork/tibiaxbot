namespace TibiaXBot
{
    partial class IpChanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_change = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_change);
            this.groupBox1.Controls.Add(this.tb_port);
            this.groupBox1.Controls.Add(this.tb_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Changer";
            // 
            // b_change
            // 
            this.b_change.Location = new System.Drawing.Point(136, 46);
            this.b_change.Name = "b_change";
            this.b_change.Size = new System.Drawing.Size(53, 23);
            this.b_change.TabIndex = 4;
            this.b_change.Text = "Change";
            this.b_change.UseVisualStyleBackColor = true;
            this.b_change.Click += new System.EventHandler(this.b_change_Click);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(41, 45);
            this.tb_port.MaxLength = 6;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(33, 20);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "7171";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(41, 19);
            this.tb_ip.MaxLength = 25;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(147, 20);
            this.tb_ip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 139);
            this.button1.TabIndex = 1;
            this.button1.Text = "WE MUST THINK ABOUT THIS !!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IpChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IpChanger";
            this.Text = "Ip Changer";
            this.Load += new System.EventHandler(this.IpChanger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_change;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Button button1;
    }
}