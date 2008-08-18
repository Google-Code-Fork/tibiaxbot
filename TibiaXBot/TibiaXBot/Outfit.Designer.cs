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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listboxOutfits = new System.Windows.Forms.ListBox();
            this.buttonEnable = new System.Windows.Forms.CheckBox();
            this.Addons = new System.Windows.Forms.GroupBox();
            this.buttonAddonOne = new System.Windows.Forms.RadioButton();
            this.buttonAddonTwo = new System.Windows.Forms.RadioButton();
            this.buttonAddonNone = new System.Windows.Forms.RadioButton();
            this.buttonAddonBoth = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.Addons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxOutfits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outfits";
            // 
            // listboxOutfits
            // 
            this.listboxOutfits.FormattingEnabled = true;
            this.listboxOutfits.Location = new System.Drawing.Point(6, 19);
            this.listboxOutfits.Name = "listboxOutfits";
            this.listboxOutfits.Size = new System.Drawing.Size(111, 108);
            this.listboxOutfits.TabIndex = 0;
            // 
            // buttonEnable
            // 
            this.buttonEnable.AutoSize = true;
            this.buttonEnable.Location = new System.Drawing.Point(151, 132);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(59, 17);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            // 
            // Addons
            // 
            this.Addons.Controls.Add(this.buttonAddonBoth);
            this.Addons.Controls.Add(this.buttonAddonNone);
            this.Addons.Controls.Add(this.buttonAddonTwo);
            this.Addons.Controls.Add(this.buttonAddonOne);
            this.Addons.Location = new System.Drawing.Point(145, 12);
            this.Addons.Name = "Addons";
            this.Addons.Size = new System.Drawing.Size(91, 114);
            this.Addons.TabIndex = 2;
            this.Addons.TabStop = false;
            this.Addons.Text = "Addons";
            // 
            // buttonAddonOne
            // 
            this.buttonAddonOne.AutoSize = true;
            this.buttonAddonOne.Location = new System.Drawing.Point(6, 19);
            this.buttonAddonOne.Name = "buttonAddonOne";
            this.buttonAddonOne.Size = new System.Drawing.Size(45, 17);
            this.buttonAddonOne.TabIndex = 0;
            this.buttonAddonOne.TabStop = true;
            this.buttonAddonOne.Text = "One";
            this.buttonAddonOne.UseVisualStyleBackColor = true;
            // 
            // buttonAddonTwo
            // 
            this.buttonAddonTwo.AutoSize = true;
            this.buttonAddonTwo.Location = new System.Drawing.Point(6, 42);
            this.buttonAddonTwo.Name = "buttonAddonTwo";
            this.buttonAddonTwo.Size = new System.Drawing.Size(46, 17);
            this.buttonAddonTwo.TabIndex = 1;
            this.buttonAddonTwo.TabStop = true;
            this.buttonAddonTwo.Text = "Two";
            this.buttonAddonTwo.UseVisualStyleBackColor = true;
            // 
            // buttonAddonNone
            // 
            this.buttonAddonNone.AutoSize = true;
            this.buttonAddonNone.Location = new System.Drawing.Point(6, 88);
            this.buttonAddonNone.Name = "buttonAddonNone";
            this.buttonAddonNone.Size = new System.Drawing.Size(51, 17);
            this.buttonAddonNone.TabIndex = 2;
            this.buttonAddonNone.TabStop = true;
            this.buttonAddonNone.Text = "None";
            this.buttonAddonNone.UseVisualStyleBackColor = true;
            // 
            // buttonAddonBoth
            // 
            this.buttonAddonBoth.AutoSize = true;
            this.buttonAddonBoth.Location = new System.Drawing.Point(6, 65);
            this.buttonAddonBoth.Name = "buttonAddonBoth";
            this.buttonAddonBoth.Size = new System.Drawing.Size(47, 17);
            this.buttonAddonBoth.TabIndex = 3;
            this.buttonAddonBoth.TabStop = true;
            this.buttonAddonBoth.Text = "Both";
            this.buttonAddonBoth.UseVisualStyleBackColor = true;
            // 
            // Outfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 164);
            this.Controls.Add(this.Addons);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Outfit";
            this.Text = "Outfit";
            this.Load += new System.EventHandler(this.Outfit_Load);
            this.groupBox1.ResumeLayout(false);
            this.Addons.ResumeLayout(false);
            this.Addons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listboxOutfits;
        private System.Windows.Forms.CheckBox buttonEnable;
        private System.Windows.Forms.GroupBox Addons;
        private System.Windows.Forms.RadioButton buttonAddonNone;
        private System.Windows.Forms.RadioButton buttonAddonTwo;
        private System.Windows.Forms.RadioButton buttonAddonOne;
        private System.Windows.Forms.RadioButton buttonAddonBoth;
    }
}