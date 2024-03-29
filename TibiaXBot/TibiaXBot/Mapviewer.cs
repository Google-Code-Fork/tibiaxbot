﻿using System;
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
    public partial class Mapviewer : Form
    {
        public Client client;
        public Tibia.Util.MapViewer mv;
        public Player player;
        public int currentfloor = 7;
        public string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tibia\\Automap\\";

        public Mapviewer(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Mapviewer_Load(object sender, EventArgs e)
        {
            player = client.GetPlayer();
            mapViewer1.Directory = directory;
            mapViewer1.LoadMap();
            mapViewer1.SetMapCenter(player.Location);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            mapViewer1.Zoom(2.0);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            mapViewer1.Zoom(0.5);
        }



        private void boxMapviewer_Click(object sender, EventArgs e)
        {

        }

        private void mapViewer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentfloor++;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            currentfloor--;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mapViewer1.SetLevel(currentfloor);
            Floor.Text = currentfloor.ToString();
        }
    }
}
