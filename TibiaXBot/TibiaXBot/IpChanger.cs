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
    public partial class IpChanger : Form
    {
        private Client client;
        public IpChanger()
        {
            InitializeComponent();
        }

        private void b_change_Click(object sender, EventArgs e)
        {
            client = Tibia.Util.ClientChooser.ShowBox();
            client.SetOT(tb_ip.Text, (short.Parse(tb_port.Text)));
        }
    }
}
