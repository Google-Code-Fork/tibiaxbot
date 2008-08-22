using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace TibiaXBot.Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            WebClient wc = new WebClient();
            string path = Application.StartupPath;
            string version = Application.ProductVersion;
            int tapiver = 24;
            string svinfo = "http://www.gnu.org/licenses/lgpl.txt"; //"Server Info File(version.txt)";
            string svdownload = "Server Download File(tibiaxbot.exe)";
            string tapidownload = "Tibiaapi downloaf file(tibiaapi.dll)";            
            wc.DownloadFile(svinfo, (path + "newversion.txt"));
            File.OpenText((path + "newversion.txt")).Close();
        }
    }
}
