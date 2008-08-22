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
using Tibia.Constants;

namespace TibiaXBot
{
    public partial class Outfit : Form
    {

        public Client client;
        public Player player;
        public Tibia.Objects.Console console;


        public Outfit(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Outfit_Load(object sender, EventArgs e)
        {

            foreach (OutfitType type in Enum.GetValues(typeof(OutfitType)))

                comboboxOutfits.Items.Add(type);


        }

        private void buttonEnable_CheckedChanged(object sender, EventArgs e)
        {
            player = client.GetPlayer();
            if (buttonEnable.Checked)
            {
                comboboxOutfits.Enabled = false;
                player.Outfit = (OutfitType)comboboxOutfits.SelectedItem;
            }
            else
            {
                player.Outfit = OutfitType.GameMaster;
                comboboxOutfits.Enabled = true;

            }
        }

        private void buttonAddonOne_CheckedChanged(object sender, EventArgs e)
        {
            player = client.GetPlayer();
            if (buttonAddonOne.Checked)
            {
                player.Addon = Tibia.Constants.OutfitAddon.Addon1;
            }

        }

        private void buttonAddonTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonAddonTwo.Checked)
            {
                player.Addon = Tibia.Constants.OutfitAddon.Addon2;
            }

        }

        private void buttonAddonBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonAddonBoth.Checked)
            {
                player.Addon = Tibia.Constants.OutfitAddon.Both;
            }

        }

        private void buttonAddonNone_CheckedChanged(object sender, EventArgs e)
        {
            player.Addon = Tibia.Constants.OutfitAddon.None;
        }

        private void buttonRainbow_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonRainbow.Checked)
            {
                timerRainbow.Enabled = true;
            }
            else
            {
                timerRainbow.Enabled = false;
            }
        }

        private void timerRainbow_Tick(object sender, EventArgs e)
        {
            player.Color_Body = Tibia.Constants.OutfitColor.Black;
            player.Color_Feet = Tibia.Constants.OutfitColor.Blue;
            player.Color_Head = Tibia.Constants.OutfitColor.Brown;
            player.Color_Legs = Tibia.Constants.OutfitColor.Green;
            
            {
                player.Color_Body = Tibia.Constants.OutfitColor.Blue;
                player.Color_Feet = Tibia.Constants.OutfitColor.Brown;
                player.Color_Head = Tibia.Constants.OutfitColor.Green;
                player.Color_Legs = Tibia.Constants.OutfitColor.Black;
                {
                    player.Color_Body = Tibia.Constants.OutfitColor.Brown;
                    player.Color_Feet = Tibia.Constants.OutfitColor.Green;
                    player.Color_Head = Tibia.Constants.OutfitColor.Black;
                    player.Color_Legs = Tibia.Constants.OutfitColor.Blue;
                }
            }
        }

        private void timerRainbow_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
    

