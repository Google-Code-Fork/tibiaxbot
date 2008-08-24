namespace Spammer
{
    partial class Spammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spammer));
            this.listboxPlayersOnline = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxSpamText = new System.Windows.Forms.RichTextBox();
            this.buttonActivate = new System.Windows.Forms.CheckBox();
            this.timerActivate = new System.Windows.Forms.Timer(this.components);
            this.textPlayerWorld = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMSGSent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timerAutoUpdateOnlineList = new System.Windows.Forms.Timer(this.components);
            this.buttonGetPlayers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxPlayersOnline
            // 
            this.listboxPlayersOnline.FormattingEnabled = true;
            this.listboxPlayersOnline.Location = new System.Drawing.Point(174, 35);
            this.listboxPlayersOnline.Name = "listboxPlayersOnline";
            this.listboxPlayersOnline.Size = new System.Drawing.Size(120, 160);
            this.listboxPlayersOnline.TabIndex = 0;
            this.listboxPlayersOnline.SelectedIndexChanged += new System.EventHandler(this.listboxPlayersOnline_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players Online:";
            // 
            // textboxSpamText
            // 
            this.textboxSpamText.Location = new System.Drawing.Point(9, 35);
            this.textboxSpamText.Name = "textboxSpamText";
            this.textboxSpamText.Size = new System.Drawing.Size(159, 65);
            this.textboxSpamText.TabIndex = 2;
            this.textboxSpamText.Text = "Write text here...";
            // 
            // buttonActivate
            // 
            this.buttonActivate.AutoSize = true;
            this.buttonActivate.Location = new System.Drawing.Point(9, 12);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(112, 17);
            this.buttonActivate.TabIndex = 3;
            this.buttonActivate.Text = "Activate Spammer";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.CheckedChanged += new System.EventHandler(this.buttonActivate_CheckedChanged);
            // 
            // timerActivate
            // 
            this.timerActivate.Interval = 3500;
            this.timerActivate.Tick += new System.EventHandler(this.timerActivate_Tick);
            // 
            // textPlayerWorld
            // 
            this.textPlayerWorld.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textPlayerWorld.FormattingEnabled = true;
            this.textPlayerWorld.Items.AddRange(new object[] {
            "Aldora",
            "Amera",
            "Antica",
            "Arcania",
            "Askara",
            "Astera",
            "Aurea",
            "Azura",
            "Balera",
            "Berylia",
            "Calmera",
            "Candia",
            "Celesta",
            "Chimera",
            "Danera",
            "Danubia",
            "Dolera",
            "Elera",
            "Elysia",
            "Empera",
            "Eternia",
            "Fortera",
            "Furora",
            "Galana",
            "Grimera",
            "Guardia",
            "Harmonia",
            "Hiberna",
            "Honera",
            "Inferna",
            "Iridia",
            "Isara",
            "Jamera",
            "Julera",
            "Keltera",
            "Kyra",
            "Libera",
            "Lucera",
            "Luminera",
            "Lunara",
            "Malvera",
            "Menera",
            "Morgana",
            "Mythera",
            "Nebula",
            "Neptera",
            "Nerana",
            "Nova",
            "Obsidia",
            "Ocera",
            "Pacera",
            "Pandoria",
            "Premia",
            "Pythera",
            "Refugia",
            "Rubera",
            "Samera",
            "Saphira",
            "Secura",
            "Selena",
            "Shanera",
            "Shivera",
            "Silvera",
            "Solera",
            "Tenebra",
            "Thoria",
            "Titania",
            "Trimera",
            "Valoria",
            "Vinera",
            "Xantera",
            "Xerena",
            "Zanera"});
            this.textPlayerWorld.Location = new System.Drawing.Point(300, 112);
            this.textPlayerWorld.Name = "textPlayerWorld";
            this.textPlayerWorld.Size = new System.Drawing.Size(158, 21);
            this.textPlayerWorld.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textMSGSent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(299, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Players Online:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Receiver:";
            // 
            // textMSGSent
            // 
            this.textMSGSent.AutoSize = true;
            this.textMSGSent.Location = new System.Drawing.Point(93, 23);
            this.textMSGSent.Name = "textMSGSent";
            this.textMSGSent.Size = new System.Drawing.Size(27, 13);
            this.textMSGSent.TabIndex = 1;
            this.textMSGSent.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Messages Sent:";
            // 
            // timerInfo
            // 
            this.timerInfo.Enabled = true;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Use <name> to send";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "the receiver\'s name.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "MSG Delay(MS):";
            // 
            // numericInterval
            // 
            this.numericInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericInterval.Location = new System.Drawing.Point(467, 139);
            this.numericInterval.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(79, 20);
            this.numericInterval.TabIndex = 12;
            this.numericInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericInterval.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Auto-Update Online Players List";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timerAutoUpdateOnlineList
            // 
            this.timerAutoUpdateOnlineList.Interval = 15000;
            this.timerAutoUpdateOnlineList.Tick += new System.EventHandler(this.timerAutoUpdateOnlineList_Tick);
            // 
            // buttonGetPlayers
            // 
            this.buttonGetPlayers.BackgroundImage = global::TibiaXBot.Properties.Resources.button;
            this.buttonGetPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGetPlayers.FlatAppearance.BorderSize = 0;
            this.buttonGetPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetPlayers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetPlayers.Location = new System.Drawing.Point(301, 139);
            this.buttonGetPlayers.Name = "buttonGetPlayers";
            this.buttonGetPlayers.Size = new System.Drawing.Size(175, 25);
            this.buttonGetPlayers.TabIndex = 14;
            this.buttonGetPlayers.Text = "Get Online Players";
            this.buttonGetPlayers.UseVisualStyleBackColor = true;
            this.buttonGetPlayers.Click += new System.EventHandler(this.buttonGetPlayers_Click_1);
            this.buttonGetPlayers.MouseHover += new System.EventHandler(this.buttonGetPlayers_MouseEnter);
            // 
            // Spammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(558, 200);
            this.Controls.Add(this.buttonGetPlayers);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericInterval);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPlayerWorld);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.textboxSpamText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxPlayersOnline);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spammer";
            this.Text = "Spammer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPlayersOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textboxSpamText;
        private System.Windows.Forms.CheckBox buttonActivate;
        private System.Windows.Forms.Timer timerActivate;
        private System.Windows.Forms.ComboBox textPlayerWorld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textMSGSent;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timerAutoUpdateOnlineList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetPlayers;
    }
}

