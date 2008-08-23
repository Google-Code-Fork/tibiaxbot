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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Outfits = new System.Windows.Forms.ToolStripMenuItem();
            this.spammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tibiaMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIpchanger = new System.Windows.Forms.Button();
            this.buttonOutfit = new System.Windows.Forms.Button();
            this.buttonSpammer = new System.Windows.Forms.Button();
            this.buttonWASD = new System.Windows.Forms.Button();
            this.timerIfLoggedin = new System.Windows.Forms.Timer(this.components);
            this.contextTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextTray;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "TibiaXBot";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // contextTray
            // 
            this.contextTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Outfits,
            this.spammerToolStripMenuItem,
            this.wASDToolStripMenuItem,
            this.tibiaMapToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextTray.Name = "contextTray";
            this.contextTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextTray.Size = new System.Drawing.Size(131, 136);
            this.contextTray.Opening += new System.ComponentModel.CancelEventHandler(this.contextTray_Opening);
            // 
            // Outfits
            // 
            this.Outfits.Name = "Outfits";
            this.Outfits.Size = new System.Drawing.Size(130, 22);
            this.Outfits.Text = "Outfits";
            this.Outfits.Click += new System.EventHandler(this.Outfits_Click);
            // 
            // spammerToolStripMenuItem
            // 
            this.spammerToolStripMenuItem.Name = "spammerToolStripMenuItem";
            this.spammerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.spammerToolStripMenuItem.Text = "Spammer";
            this.spammerToolStripMenuItem.Click += new System.EventHandler(this.spammerToolStripMenuItem_Click_1);
            // 
            // wASDToolStripMenuItem
            // 
            this.wASDToolStripMenuItem.Name = "wASDToolStripMenuItem";
            this.wASDToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.wASDToolStripMenuItem.Text = "WASD";
            this.wASDToolStripMenuItem.Click += new System.EventHandler(this.wASDToolStripMenuItem_Click_1);
            // 
            // tibiaMapToolStripMenuItem
            // 
            this.tibiaMapToolStripMenuItem.Name = "tibiaMapToolStripMenuItem";
            this.tibiaMapToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tibiaMapToolStripMenuItem.Text = "Tibia Map";
            this.tibiaMapToolStripMenuItem.Click += new System.EventHandler(this.tibiaMapToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_2);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonIpchanger
            // 
            this.buttonIpchanger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIpchanger.BackgroundImage")));
            this.buttonIpchanger.FlatAppearance.BorderSize = 0;
            this.buttonIpchanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIpchanger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIpchanger.Location = new System.Drawing.Point(103, 43);
            this.buttonIpchanger.Name = "buttonIpchanger";
            this.buttonIpchanger.Size = new System.Drawing.Size(80, 25);
            this.buttonIpchanger.TabIndex = 4;
            this.buttonIpchanger.Text = "IPChanger";
            this.buttonIpchanger.UseVisualStyleBackColor = true;
            this.buttonIpchanger.MouseLeave += new System.EventHandler(this.b4mouseleave);
            this.buttonIpchanger.Click += new System.EventHandler(this.button4_Click);
            this.buttonIpchanger.MouseEnter += new System.EventHandler(this.b4mouseenter);
            // 
            // buttonOutfit
            // 
            this.buttonOutfit.BackColor = System.Drawing.Color.Transparent;
            this.buttonOutfit.BackgroundImage = global::TibiaXBot.Properties.Resources.button;
            this.buttonOutfit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOutfit.FlatAppearance.BorderSize = 0;
            this.buttonOutfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonOutfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutfit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOutfit.Location = new System.Drawing.Point(12, 12);
            this.buttonOutfit.Name = "buttonOutfit";
            this.buttonOutfit.Size = new System.Drawing.Size(80, 25);
            this.buttonOutfit.TabIndex = 2;
            this.buttonOutfit.Text = "Outfit";
            this.buttonOutfit.UseVisualStyleBackColor = false;
            this.buttonOutfit.MouseLeave += new System.EventHandler(this.b3mouseleave);
            this.buttonOutfit.Click += new System.EventHandler(this.button3_Click);
            this.buttonOutfit.MouseEnter += new System.EventHandler(this.b3mouseenter);
            // 
            // buttonSpammer
            // 
            this.buttonSpammer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpammer.BackgroundImage")));
            this.buttonSpammer.FlatAppearance.BorderSize = 0;
            this.buttonSpammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpammer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSpammer.Location = new System.Drawing.Point(12, 43);
            this.buttonSpammer.Name = "buttonSpammer";
            this.buttonSpammer.Size = new System.Drawing.Size(80, 25);
            this.buttonSpammer.TabIndex = 1;
            this.buttonSpammer.Text = "Spammer";
            this.buttonSpammer.UseVisualStyleBackColor = true;
            this.buttonSpammer.MouseLeave += new System.EventHandler(this.b2mouseleave);
            this.buttonSpammer.Click += new System.EventHandler(this.button2_Click);
            this.buttonSpammer.MouseEnter += new System.EventHandler(this.b2mouseenter);
            // 
            // buttonWASD
            // 
            this.buttonWASD.BackgroundImage = global::TibiaXBot.Properties.Resources.button;
            this.buttonWASD.FlatAppearance.BorderSize = 0;
            this.buttonWASD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWASD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWASD.Location = new System.Drawing.Point(103, 12);
            this.buttonWASD.Name = "buttonWASD";
            this.buttonWASD.Size = new System.Drawing.Size(80, 25);
            this.buttonWASD.TabIndex = 0;
            this.buttonWASD.Text = "WASD";
            this.buttonWASD.UseVisualStyleBackColor = true;
            this.buttonWASD.MouseLeave += new System.EventHandler(this.b1mouseleave);
            this.buttonWASD.Click += new System.EventHandler(this.button1_Click);
            this.buttonWASD.MouseEnter += new System.EventHandler(this.b1mouseenter);
            // 
            // timerIfLoggedin
            // 
            this.timerIfLoggedin.Enabled = true;
            this.timerIfLoggedin.Tick += new System.EventHandler(this.timerIfLoggedin_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(195, 75);
            this.Controls.Add(this.buttonIpchanger);
            this.Controls.Add(this.buttonOutfit);
            this.Controls.Add(this.buttonSpammer);
            this.Controls.Add(this.buttonWASD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "TibiaXBot";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.contextTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWASD;
        private System.Windows.Forms.Button buttonSpammer;
        private System.Windows.Forms.Button buttonOutfit;
        private System.Windows.Forms.Button buttonIpchanger;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextTray;
        private System.Windows.Forms.ToolStripMenuItem Outfits;
        private System.Windows.Forms.ToolStripMenuItem spammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wASDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tibiaMapToolStripMenuItem;
        private System.Windows.Forms.Timer timerIfLoggedin;
    }
}

