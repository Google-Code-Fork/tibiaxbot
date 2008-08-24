namespace TibiaXBot
{
    partial class WASD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WASD));
            this.buttonKeyboard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEnable = new System.Windows.Forms.CheckBox();
            this.buttonCheckBox = new System.Windows.Forms.RadioButton();
            this.timerWASD = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.AutoSize = true;
            this.buttonKeyboard.Location = new System.Drawing.Point(6, 19);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Size = new System.Drawing.Size(84, 17);
            this.buttonKeyboard.TabIndex = 1;
            this.buttonKeyboard.TabStop = true;
            this.buttonKeyboard.Text = "Insert/Home";
            this.buttonKeyboard.UseVisualStyleBackColor = true;
            this.buttonKeyboard.CheckedChanged += new System.EventHandler(this.buttonKeyboard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEnable);
            this.groupBox1.Controls.Add(this.buttonCheckBox);
            this.groupBox1.Controls.Add(this.buttonKeyboard);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How-To Enable/Disable";
            // 
            // buttonEnable
            // 
            this.buttonEnable.AutoSize = true;
            this.buttonEnable.Location = new System.Drawing.Point(73, 59);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(59, 17);
            this.buttonEnable.TabIndex = 3;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.CheckedChanged += new System.EventHandler(this.buttonEnable_CheckedChanged);
            // 
            // buttonCheckBox
            // 
            this.buttonCheckBox.AutoSize = true;
            this.buttonCheckBox.Location = new System.Drawing.Point(6, 42);
            this.buttonCheckBox.Name = "buttonCheckBox";
            this.buttonCheckBox.Size = new System.Drawing.Size(73, 17);
            this.buttonCheckBox.TabIndex = 2;
            this.buttonCheckBox.TabStop = true;
            this.buttonCheckBox.Text = "Checkbox";
            this.buttonCheckBox.UseVisualStyleBackColor = true;
            this.buttonCheckBox.CheckedChanged += new System.EventHandler(this.buttonCheckBox_CheckedChanged);
            // 
            // timerWASD
            // 
            this.timerWASD.Tick += new System.EventHandler(this.timerWASD_Tick);
            // 
            // WASD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(164, 106);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WASD";
            this.Text = "WASD";
            this.Load += new System.EventHandler(this.WASD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton buttonKeyboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buttonCheckBox;
        private System.Windows.Forms.CheckBox buttonEnable;
        private System.Windows.Forms.Timer timerWASD;
    }
}