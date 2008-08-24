using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TibiaXBot
{
    public partial class Splash : Form
    {
        public Form frmMain;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                this.Close();
            }
            else
            {
                this.Opacity -= 0.05;
            }
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            frmMain = new Main();
            frmMain.ShowDialog();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(255, 0, 255);
            timer1.Start();
        }
    }
}
