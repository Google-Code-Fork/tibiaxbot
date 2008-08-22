using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace TibiaXBot.Updater
{
    public partial class UpdateInfo : Form
    {
        string version;
        string newversion;
        string server_update;
        string server_update_info;
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            server_update_info = ""; //Address(info,txt)
            string loc = Application.StartupPath + "info.txt";
            WebClient wc = new WebClient();
            wc.DownloadFile(server_update_info,loc);
            version = Application.ProductVersion;
            newversion = (new StreamReader(loc)).ToString();
            cver.Text = version;
            nver.Text = newversion;
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            server_update = ""; //Address(update.exe)
            string loc = Application.StartupPath + "update.exe";
            WebClient wc = new WebClient();
            wc.DownloadFile(server_update,loc);
            Process.Start(loc);
            
        }
    }
}
