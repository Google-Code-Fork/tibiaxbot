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
    public partial class Spammer : Form
    {
        public Client client;
        public Player player;
        public Tibia.Objects.Console console;

        public Spammer()
        {
            InitializeComponent();
        }

        private void Spammer_Load(object sender, EventArgs e)
        {

        }
    }
}
