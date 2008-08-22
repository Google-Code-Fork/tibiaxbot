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
    public partial class Mapviewer : Form
    {
        public Client client;
        public Tibia.Util.MapViewer mv;
        public Player player;

        public Mapviewer(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Mapviewer_Load(object sender, EventArgs e)
        {
            player = client.GetPlayer();
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
    }
}
