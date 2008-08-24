/*
 *     TibiaXBot is a bot made for tibia, it has many new unique features
    that none has used before (Or not very much).
    Copyright (C) 2008  Jesper_Kladden & Aluwama.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with TibiaXBot.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tibia;
using Tibia.Objects;

namespace TibiaXBot
{
    public partial class Main : Form
    {

        public Player player;
        public Tibia.Objects.Console console;
        public Form frmWASD;
        public Form frmOutFit;
        public Form frmSpammer;
        public Form frmAbout;
        public Form frmMapviewer;
        public Form frmSplash;
        public Client client = Tibia.Util.ClientChooser.ShowBox();


        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmWASD = new WASD(client);
            frmSpammer = new Spammer.Spammer(client);
            frmOutFit = new Outfit(client);
            frmAbout = new About();
            frmMapviewer = new Mapviewer(client);
            frmSplash = new Splash();
            buttonSpammer.Enabled = false;
            buttonOutfit.Enabled = false;
            buttonIpchanger.Enabled = false;
            buttonWASD.Enabled = false;
            contextTray.Enabled = false;
            frmSplash.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWASD.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSpammer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOutFit.ShowDialog();
            
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWASD.ShowDialog();
        }

        private void spammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpammer.ShowDialog();
        }

        private void outfitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmOutFit.ShowDialog();
        }

        private void iPChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tibia.Util.ClientChooser.ShowBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tibia.Util.ClientChooser.ShowBox();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAbout.ShowDialog();
        }

        private void b3mouseenter(object sender, EventArgs e)
        {
            buttonOutfit.BackgroundImage = Image.FromFile("Resources/button_hover.bmp");
        }

        private void b3mouseleave(object sender, EventArgs e)
        {
            buttonOutfit.BackgroundImage = Image.FromFile("Resources/button.bmp");
        }

        private void b1mouseleave(object sender, EventArgs e)
        {
            buttonWASD.BackgroundImage = Image.FromFile("Resources/button.bmp");
        }

        private void b1mouseenter(object sender, EventArgs e)
        {
            buttonWASD.BackgroundImage = Image.FromFile("Resources/button_hover.bmp");
        }

        private void b2mouseenter(object sender, EventArgs e)
        {
            buttonSpammer.BackgroundImage = Image.FromFile("Resources/button_hover.bmp");
        }

        private void b2mouseleave(object sender, EventArgs e)
        {
            buttonSpammer.BackgroundImage = Image.FromFile("Resources/button.bmp");
        }

        private void b4mouseenter(object sender, EventArgs e)
        {
            buttonIpchanger.BackgroundImage = Image.FromFile("Resources/button_hover.bmp");
        }

        private void b4mouseleave(object sender, EventArgs e)
        {
            buttonIpchanger.BackgroundImage = Image.FromFile("Resources/button.bmp");
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowDialog();

        }

        private void contextTray_Opening(object sender, CancelEventArgs e)
        {
        
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmAbout.ShowDialog();
        }

        private void wASDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmWASD.ShowDialog();
        }

        private void spammerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSpammer.ShowDialog();
        }

        private void Outfits_Click(object sender, EventArgs e)
        {
            frmOutFit.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = false;
        }

        private void tibiaMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapviewer.ShowDialog();
        }

        private void timerIfLoggedin_Tick(object sender, EventArgs e)
        {
            if (client.LoggedIn)
            {
                buttonOutfit.Enabled = true;
                buttonIpchanger.Enabled = true;
                buttonWASD.Enabled = true;
                buttonSpammer.Enabled = true;
                contextTray.Enabled = true;
                timerIfLoggedin.Enabled = false;
              
            }
        
        }
    }
}
