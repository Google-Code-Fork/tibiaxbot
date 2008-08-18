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
    public partial class Outfit : Form
    {
        public Client client;
        public Player player;
        public Tibia.Objects.Console console;

        public Outfit()
        {
            InitializeComponent();
        }

        private void Outfit_Load(object sender, EventArgs e)
        {

        }
    }
}
