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
        public Client client;
        public Player player;
        public Tibia.Objects.Console console;
        public Form frmWASD;
        public Form frmOutFit;
        public Form frmSpammer;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            client = Tibia.Util.ClientChooser.ShowBox();
            frmWASD = new WASD();
            frmSpammer = new Spammer.Spammer();
            frmOutFit = new Outfit();
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
    }
}
