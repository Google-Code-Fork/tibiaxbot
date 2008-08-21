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
using System.Threading;

namespace Spammer
{
    public partial class Spammer : Form
    {
        Tibia.Objects.Console console;
        Player player;
        public Client client;
        public int index = 0;
        public Spammer frmMain;
        public Form frmGuild;

        public Spammer(Client client)
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            console = new Tibia.Objects.Console(client);
            client = Tibia.Util.ClientChooser.ShowBox();
        }

        private void buttonGetPlayers_Click(object sender, EventArgs e)
        { }

        private void timerActivate_Tick(object sender, EventArgs e)
        {
            timerActivate.Interval = (int)numericInterval.Value;
            Send(sender, e);
        }

        private void Send(object sender, EventArgs e)
        {
            if (index == listboxPlayersOnline.Items.Count)
            {
                index = 0;
                listboxPlayersOnline.Items.Clear();
                buttonGetPlayers_Click(sender, e);
            }
            textboxSpamText.Text = textboxSpamText.Text.Replace("<name>", listboxPlayersOnline.Items[index].ToString());
            console.Say(textboxSpamText.Text, listboxPlayersOnline.Items[index].ToString());
            textboxSpamText.Text = textboxSpamText.Text.Replace(listboxPlayersOnline.Items[index].ToString(), "<name>");
            label4.Text = listboxPlayersOnline.Items[index].ToString();
            index++;


        }

        private void buttonActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonActivate.Checked)
            {
                timerActivate.Enabled = true;
            }
            else
            {
                timerActivate.Enabled = false;
            }
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {

            textMSGSent.Text = index.ToString();


            label6.Text = listboxPlayersOnline.Items.Count.ToString();




        }

        private void listboxPlayersOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxPlayersOnline.Items.Clear();
        }

        private void isClientLoggedInActivateHereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void httpwwwtibiatekcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tibiatek.com/");

        }

        private void httptpforumsorgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tpforums.org/");
        }

        private void httptibiaapigooglecodecomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tibiaapi.googlecode.com/");
        }

        private void openGuildBroadCasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuild.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timerAutoUpdateOnlineList.Enabled = true;
            }
            else
            {
                timerAutoUpdateOnlineList.Enabled = false;
            }
        }

        private void timerAutoUpdateOnlineList_Tick(object sender, EventArgs e)
        {
            listboxPlayersOnline.Items.Clear();
            
                player = client.GetPlayer();
                Website.WhoIsOnline(textPlayerWorld.Text, delegate(List<Website.CharOnline> i)
                {
                    listboxPlayersOnline.Invoke(new EventHandler(delegate
                    {
                        for (int o = 0; o < i.Count(); o++)
                            listboxPlayersOnline.Items.Add(i[o].Name);
                    }));
                });
            }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGetPlayers_Click_1(object sender, EventArgs e)
        {
                        player = client.GetPlayer();
            Website.WhoIsOnline(textPlayerWorld.Text, delegate(List<Website.CharOnline> i)
            {
                listboxPlayersOnline.Invoke(new EventHandler(delegate
                    {
                        for (int o = 0; o < i.Count(); o++)
                            listboxPlayersOnline.Items.Add(i[o].Name);
                    }));
            });
        
        }

        private void buttonGetPlayers_MouseEnter(object sender, EventArgs e)
        {
            buttonGetPlayers.BackgroundImage = Image.FromFile("Resources/button_hover.bmp");
        }
        }
    }

