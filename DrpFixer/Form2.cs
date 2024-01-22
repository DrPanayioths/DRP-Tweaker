using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrpFixer
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void RunDownloadedExecutable(string executablePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = executablePath;
            Process.Start(startInfo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.live.eu.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Valorant_Game.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }
    }
}
