using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrpFixer
{
    public partial class drpdownloader : Form
    {
        public drpdownloader()
        {
            InitializeComponent();
        }

        private void drpdownloader_Load(object sender, EventArgs e)
        {

        }

        private void dnsrunner_Click(object sender, EventArgs e)
        {
            var process = new Process();
            var dns = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = false,
                Arguments = @"/C powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61"
            };

            process.StartInfo = dns;
            process.Start();
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
