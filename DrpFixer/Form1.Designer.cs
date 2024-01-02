using System;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace DrpFixer
{
    partial class drpdownloader
    {
        private System.Windows.Forms.Button Epicg;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button EA;
        private System.Windows.Forms.Button Lunar;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label TheCreator;
        private System.Windows.Forms.ToolTip TipHoverare;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Epicg = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.EA = new System.Windows.Forms.Button();
            this.Lunar = new System.Windows.Forms.Button();
            this.TheCreator = new System.Windows.Forms.Label();
            this.TipHoverare = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Epicg
            // 
            this.Epicg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Epicg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Epicg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Epicg.Location = new System.Drawing.Point(12, 387);
            this.Epicg.Name = "Epicg";
            this.Epicg.Size = new System.Drawing.Size(107, 41);
            this.Epicg.TabIndex = 0;
            this.Epicg.Text = "Epic Games";
            this.Epicg.UseVisualStyleBackColor = true;
            this.Epicg.Click += new System.EventHandler(this.Epic_Click);
            // 
            // Steam
            // 
            this.Steam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Steam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Steam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Steam.Location = new System.Drawing.Point(125, 387);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(107, 41);
            this.Steam.TabIndex = 1;
            this.Steam.Text = "Steam";
            this.Steam.UseVisualStyleBackColor = true;
            this.Steam.Click += new System.EventHandler(this.Steam_Clicker);
            // 
            // EA
            // 
            this.EA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EA.Location = new System.Drawing.Point(238, 387);
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(107, 41);
            this.EA.TabIndex = 2;
            this.EA.Text = "EA Client";
            this.TipHoverare.SetToolTip(this.EA, "By Electronic Arts");
            this.EA.UseVisualStyleBackColor = true;
            this.EA.Click += new System.EventHandler(this.EA_Clicker);
            // 
            // Lunar
            // 
            this.Lunar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lunar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Lunar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lunar.Location = new System.Drawing.Point(351, 387);
            this.Lunar.Name = "Lunar";
            this.Lunar.Size = new System.Drawing.Size(107, 41);
            this.Lunar.TabIndex = 3;
            this.Lunar.Text = "Lunar Client";
            this.TipHoverare.SetToolTip(this.Lunar, "By MoonsWorth");
            this.Lunar.UseVisualStyleBackColor = true;
            this.Lunar.Click += new System.EventHandler(this.Lunar_Clicke);
            // 
            // TheCreator
            // 
            this.TheCreator.AutoSize = true;
            this.TheCreator.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.TheCreator.ForeColor = System.Drawing.Color.Silver;
            this.TheCreator.Location = new System.Drawing.Point(678, 437);
            this.TheCreator.Name = "TheCreator";
            this.TheCreator.Size = new System.Drawing.Size(127, 15);
            this.TheCreator.TabIndex = 4;
            this.TheCreator.Text = "Provided By DrPanayioths";
            this.TheCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TheCreator.Click += new System.EventHandler(this.TheCreator_Click);
            // 
            // drpdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TheCreator);
            this.Controls.Add(this.Lunar);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.Epicg);
            this.Name = "drpdownloader";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.Text = "DRP Downloader (Provided By DrPanayioths)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.drpdownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Epic_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Lunar Client v3.2.0.exe");
            client.DownloadFile(url, downloadPath);
        }
            private void Steam_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Lunar Client v3.2.0.exe");
            client.DownloadFile(url, downloadPath);
        }
        private void EA_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Lunar Client v3.2.0.exe");
            client.DownloadFile(url, downloadPath);
        }
        private void Lunar_Clicke(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://launcherupdates.lunarclientcdn.com/Lunar%20Client%20v3.2.0.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Lunar Client v3.2.0.exe");
            client.DownloadFile(url, downloadPath);
            
        }
    }
}
