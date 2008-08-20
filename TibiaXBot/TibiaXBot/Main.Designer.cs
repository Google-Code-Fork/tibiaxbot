namespace TibiaXBot
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_Menu = new System.Windows.Forms.MenuStrip();
            this.tibiaXBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.m_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TibiaXBot.Properties.Resources.button;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(103, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "WASD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.b1mouseleave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.b1mouseenter);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Spammer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseLeave += new System.EventHandler(this.b2mouseleave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.b2mouseenter);
            // 
            // m_Menu
            // 
            this.m_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.m_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tibiaXBotToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.m_Menu.Size = new System.Drawing.Size(195, 24);
            this.m_Menu.TabIndex = 3;
            this.m_Menu.Text = "TibiaXBot.";
            // 
            // tibiaXBotToolStripMenuItem
            // 
            this.tibiaXBotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.tibiaXBotToolStripMenuItem.Name = "tibiaXBotToolStripMenuItem";
            this.tibiaXBotToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tibiaXBotToolStripMenuItem.Text = "TibiaXBot";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outfitToolStripMenuItem,
            this.spammerToolStripMenuItem,
            this.wASDToolStripMenuItem,
            this.iPChangerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // outfitToolStripMenuItem
            // 
            this.outfitToolStripMenuItem.Name = "outfitToolStripMenuItem";
            this.outfitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.outfitToolStripMenuItem.Text = "Outfit";
            this.outfitToolStripMenuItem.Click += new System.EventHandler(this.outfitToolStripMenuItem_Click);
            // 
            // spammerToolStripMenuItem
            // 
            this.spammerToolStripMenuItem.Name = "spammerToolStripMenuItem";
            this.spammerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.spammerToolStripMenuItem.Text = "Spammer";
            this.spammerToolStripMenuItem.Click += new System.EventHandler(this.spammerToolStripMenuItem_Click);
            // 
            // wASDToolStripMenuItem
            // 
            this.wASDToolStripMenuItem.Name = "wASDToolStripMenuItem";
            this.wASDToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.wASDToolStripMenuItem.Text = "WASD";
            this.wASDToolStripMenuItem.Click += new System.EventHandler(this.wASDToolStripMenuItem_Click);
            // 
            // iPChangerToolStripMenuItem
            // 
            this.iPChangerToolStripMenuItem.Name = "iPChangerToolStripMenuItem";
            this.iPChangerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.iPChangerToolStripMenuItem.Text = "IP Changer";
            this.iPChangerToolStripMenuItem.Click += new System.EventHandler(this.iPChangerToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(103, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "IPChanger";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseLeave += new System.EventHandler(this.b4mouseleave);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.b4mouseenter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::TibiaXBot.Properties.Resources.button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(12, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Outfit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.b3mouseleave);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.b3mouseenter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(195, 95);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_Menu;
            this.Name = "Main";
            this.Text = "TibiaXBot";
            this.Load += new System.EventHandler(this.Main_Load);
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem tibiaXBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outfitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wASDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPChangerToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

