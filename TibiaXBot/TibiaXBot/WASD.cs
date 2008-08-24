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
    public partial class WASD : Form
    {
        public Player player;
        public Tibia.Objects.Console console;
        public Client client;
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int keyCode);

        public WASD(Client client)
        {
            InitializeComponent();
            this.client = client;

        }
        private void WASD_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonEnable.Checked)
            {
                timerWASD.Enabled = true;
                KeyboardHook.Enable();
            }
            else
            {
                timerWASD.Enabled = false;
                KeyboardHook.Disable();
            }
        }

        private void buttonKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonKeyboard.Checked)
            {
                buttonEnable.Visible = false;
                buttonEnable.Checked = false;
                KeyboardHook.Disable();
                timerWASD.Enabled = true;
            }
            else
            {
                buttonEnable.Visible = true;
            }
        }

        private void buttonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonCheckBox.Checked)
            {
                buttonEnable.Enabled = true;
            }
            else
            {
                buttonEnable.Enabled = false;
            }
        }

        private void timerWASD_Tick(object sender, EventArgs e)
        {
            if (buttonKeyboard.Checked)
            {
                if (GetAsyncKeyState((int)Keys.Insert) !=0)
                {
                    KeyboardHook.Enable();
                }
                if (GetAsyncKeyState((int)Keys.Home) !=0)
                {
                    KeyboardHook.Disable();
                }
            }
                
                player = client.GetPlayer();
                
                KeyboardHook.Add(Keys.W, new KeyboardHook.KeyPressed(delegate
                {
                    player.Walk(Tibia.Constants.WalkDirection.Up);
                    return false;
                
                }));
                KeyboardHook.Add(Keys.A, new KeyboardHook.KeyPressed(delegate
                {
                    player.Walk(Tibia.Constants.WalkDirection.Left);
                    return false;

                }));
                KeyboardHook.Add(Keys.S, new KeyboardHook.KeyPressed(delegate
                {
                    player.Walk(Tibia.Constants.WalkDirection.Down);
                    return false;

                }));
                KeyboardHook.Add(Keys.D, new KeyboardHook.KeyPressed(delegate
                {
                    player.Walk(Tibia.Constants.WalkDirection.Right);
                    return false;

                }));     
        }
    }
}

