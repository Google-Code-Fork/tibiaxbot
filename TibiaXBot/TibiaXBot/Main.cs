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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            client = Tibia.Util.ClientChooser.ShowBox();
        }
    }
}
