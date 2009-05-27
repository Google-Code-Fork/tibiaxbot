namespace TibiaXBot
{
    partial class Outfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outfit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRainbow = new System.Windows.Forms.CheckBox();
            this.buttonAddonNone = new System.Windows.Forms.RadioButton();
            this.buttonEnable = new System.Windows.Forms.CheckBox();
            this.buttonAddonBoth = new System.Windows.Forms.RadioButton();
            this.comboboxOutfits = new System.Windows.Forms.ComboBox();
            this.buttonAddonOne = new System.Windows.Forms.RadioButton();
            this.buttonAddonTwo = new System.Windows.Forms.RadioButton();
            this.timerRainbow = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRainbow);
            this.groupBox1.Controls.Add(this.buttonAddonNone);
            this.groupBox1.Controls.Add(this.buttonEnable);
            this.groupBox1.Controls.Add(this.buttonAddonBoth);
            this.groupBox1.Controls.Add(this.comboboxOutfits);
            this.groupBox1.Controls.Add(this.buttonAddonOne);
            this.groupBox1.Controls.Add(this.buttonAddonTwo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outfits";
            // 
            // buttonRainbow
            // 
            this.buttonRainbow.AutoSize = true;
            this.buttonRainbow.Enabled = false;
            this.buttonRainbow.Location = new System.Drawing.Point(63, 92);
            this.buttonRainbow.Name = "buttonRainbow";
            this.buttonRainbow.Size = new System.Drawing.Size(68, 17);
            this.buttonRainbow.TabIndex = 4;
            this.buttonRainbow.Text = "Rainbow";
            this.buttonRainbow.UseVisualStyleBackColor = true;
            this.buttonRainbow.CheckedChanged += new System.EventHandler(this.buttonRainbow_CheckedChanged);
            // 
            // buttonAddonNone
            // 
            this.buttonAddonNone.AutoSize = true;
            this.buttonAddonNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddonNone.Location = new System.Drawing.Point(63, 69);
            this.buttonAddonNone.Name = "buttonAddonNone";
            this.buttonAddonNone.Size = new System.Drawing.Size(51, 17);
            this.buttonAddonNone.TabIndex = 2;
            this.buttonAddonNone.TabStop = true;
            this.buttonAddonNone.Text = "None";
            this.buttonAddonNone.UseVisualStyleBackColor = true;
            this.buttonAddonNone.CheckedChanged += new System.EventHandler(this.buttonAddonNone_CheckedChanged);
            // 
            // buttonEnable
            // 
            this.buttonEnable.AutoSize = true;
            this.buttonEnable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEnable.Location = new System.Drawing.Point(6, 92);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(59, 17);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.CheckedChanged += new System.EventHandler(this.buttonEnable_CheckedChanged);
            // 
            // buttonAddonBoth
            // 
            this.buttonAddonBoth.AutoSize = true;
            this.buttonAddonBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddonBoth.Location = new System.Drawing.Point(6, 69);
            this.buttonAddonBoth.Name = "buttonAddonBoth";
            this.buttonAddonBoth.Size = new System.Drawing.Size(47, 17);
            this.buttonAddonBoth.TabIndex = 3;
            this.buttonAddonBoth.TabStop = true;
            this.buttonAddonBoth.Text = "Both";
            this.buttonAddonBoth.UseVisualStyleBackColor = true;
            this.buttonAddonBoth.CheckedChanged += new System.EventHandler(this.buttonAddonBoth_CheckedChanged);
            // 
            // comboboxOutfits
            // 
            this.comboboxOutfits.FormattingEnabled = true;
            this.comboboxOutfits.Location = new System.Drawing.Point(6, 19);
            this.comboboxOutfits.Name = "comboboxOutfits";
            this.comboboxOutfits.Size = new System.Drawing.Size(123, 21);
            this.comboboxOutfits.TabIndex = 3;
            this.comboboxOutfits.SelectedIndexChanged += new System.EventHandler(this.comboboxOutfits_SelectedIndexChanged);
            // 
            // buttonAddonOne
            // 
            this.buttonAddonOne.AutoSize = true;
            this.buttonAddonOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddonOne.Location = new System.Drawing.Point(6, 46);
            this.buttonAddonOne.Name = "buttonAddonOne";
            this.buttonAddonOne.Size = new System.Drawing.Size(44, 17);
            this.buttonAddonOne.TabIndex = 0;
            this.buttonAddonOne.TabStop = true;
            this.buttonAddonOne.Text = "First";
            this.buttonAddonOne.UseVisualStyleBackColor = true;
            this.buttonAddonOne.CheckedChanged += new System.EventHandler(this.buttonAddonOne_CheckedChanged);
            // 
            // buttonAddonTwo
            // 
            this.buttonAddonTwo.AutoSize = true;
            this.buttonAddonTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddonTwo.Location = new System.Drawing.Point(63, 46);
            this.buttonAddonTwo.Name = "buttonAddonTwo";
            this.buttonAddonTwo.Size = new System.Drawing.Size(62, 17);
            this.buttonAddonTwo.TabIndex = 1;
            this.buttonAddonTwo.TabStop = true;
            this.buttonAddonTwo.Text = "Second";
            this.buttonAddonTwo.UseVisualStyleBackColor = true;
            this.buttonAddonTwo.CheckedChanged += new System.EventHandler(this.buttonAddonTwo_CheckedChanged);
            // 
            // timerRainbow
            // 
            this.timerRainbow.Interval = 500;
            this.timerRainbow.Tick += new System.EventHandler(this.timerRainbow_Tick_1);
            // 
            // Outfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(153, 139);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Outfit";
            this.Text = "Outfit";
            this.Load += new System.EventHandler(this.Outfit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox buttonEnable;
        private System.Windows.Forms.RadioButton buttonAddonNone;
        private System.Windows.Forms.RadioButton buttonAddonTwo;
        private System.Windows.Forms.RadioButton buttonAddonOne;
        private System.Windows.Forms.RadioButton buttonAddonBoth;
        private System.Windows.Forms.ComboBox comboboxOutfits;
        private System.Windows.Forms.CheckBox buttonRainbow;
        private System.Windows.Forms.Timer timerRainbow;
    }
}