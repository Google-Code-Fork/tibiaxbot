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
        public Client client;
        public Player player;
        public Tibia.Objects.Console console;

        public WASD()
        {
            InitializeComponent();
        }

        private void WASD_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnable_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
