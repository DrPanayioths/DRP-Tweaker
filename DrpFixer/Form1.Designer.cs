using System;
using System.Drawing;
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
        private System.Windows.Forms.ToolTip RedTip;
        private System.Windows.Forms.Label browsers;
        private System.Windows.Forms.Label launchers;
        private System.Windows.Forms.Button Ghostery;
        private System.Windows.Forms.Button Brave;
        private System.Windows.Forms.Button Chrome;
        private System.Windows.Forms.Button duckduckgob;
        private System.Windows.Forms.Label Utilitys;
        private System.Windows.Forms.Button Discorda;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Epicg = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.EA = new System.Windows.Forms.Button();
            this.Lunar = new System.Windows.Forms.Button();
            this.TheCreator = new System.Windows.Forms.Label();
            this.TipHoverare = new System.Windows.Forms.ToolTip(this.components);
            this.Ghostery = new System.Windows.Forms.Button();
            this.RedTip = new System.Windows.Forms.ToolTip(this.components);
            this.Chrome = new System.Windows.Forms.Button();
            this.browsers = new System.Windows.Forms.Label();
            this.launchers = new System.Windows.Forms.Label();
            this.Brave = new System.Windows.Forms.Button();
            this.duckduckgob = new System.Windows.Forms.Button();
            this.Utilitys = new System.Windows.Forms.Label();
            this.Discorda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Epicg
            // 
            this.Epicg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Epicg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Epicg.FlatAppearance.BorderSize = 2;
            this.Epicg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Epicg.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Epicg.ForeColor = System.Drawing.Color.DarkCyan;
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
            this.Steam.FlatAppearance.BorderSize = 2;
            this.Steam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Steam.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam.ForeColor = System.Drawing.Color.DarkCyan;
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
            this.EA.FlatAppearance.BorderSize = 2;
            this.EA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EA.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EA.ForeColor = System.Drawing.Color.DarkCyan;
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
            this.Lunar.FlatAppearance.BorderSize = 2;
            this.Lunar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lunar.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunar.ForeColor = System.Drawing.Color.DarkCyan;
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
            // Ghostery
            // 
            this.Ghostery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ghostery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ghostery.FlatAppearance.BorderSize = 2;
            this.Ghostery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ghostery.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghostery.ForeColor = System.Drawing.Color.DarkCyan;
            this.Ghostery.Location = new System.Drawing.Point(238, 48);
            this.Ghostery.Name = "Ghostery";
            this.Ghostery.Size = new System.Drawing.Size(107, 41);
            this.Ghostery.TabIndex = 9;
            this.Ghostery.Text = "Ghostery";
            this.Ghostery.UseVisualStyleBackColor = true;
            this.Ghostery.Click += new System.EventHandler(this.ghostery_click);
            // 
            // Chrome
            // 
            this.Chrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chrome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Chrome.FlatAppearance.BorderSize = 2;
            this.Chrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chrome.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chrome.ForeColor = System.Drawing.Color.DarkCyan;
            this.Chrome.Location = new System.Drawing.Point(12, 48);
            this.Chrome.Name = "Chrome";
            this.Chrome.Size = new System.Drawing.Size(107, 41);
            this.Chrome.TabIndex = 7;
            this.Chrome.Text = "Chrome";
            this.RedTip.SetToolTip(this.Chrome, "No Privacy");
            this.Chrome.UseVisualStyleBackColor = true;
            this.Chrome.Click += new System.EventHandler(this.Chrome_click);
            // 
            // browsers
            // 
            this.browsers.AutoSize = true;
            this.browsers.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsers.ForeColor = System.Drawing.Color.Black;
            this.browsers.Location = new System.Drawing.Point(7, 18);
            this.browsers.Name = "browsers";
            this.browsers.Size = new System.Drawing.Size(78, 27);
            this.browsers.TabIndex = 5;
            this.browsers.Text = "Browsers:";
            // 
            // launchers
            // 
            this.launchers.AutoSize = true;
            this.launchers.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchers.ForeColor = System.Drawing.Color.Black;
            this.launchers.Location = new System.Drawing.Point(7, 357);
            this.launchers.Name = "launchers";
            this.launchers.Size = new System.Drawing.Size(89, 27);
            this.launchers.TabIndex = 6;
            this.launchers.Text = "Launchers:";
            this.launchers.Click += new System.EventHandler(this.label2_Click);
            // 
            // Brave
            // 
            this.Brave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Brave.FlatAppearance.BorderSize = 2;
            this.Brave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brave.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brave.ForeColor = System.Drawing.Color.DarkCyan;
            this.Brave.Location = new System.Drawing.Point(125, 48);
            this.Brave.Name = "Brave";
            this.Brave.Size = new System.Drawing.Size(107, 41);
            this.Brave.TabIndex = 8;
            this.Brave.Text = "Brave";
            this.Brave.UseVisualStyleBackColor = true;
            this.Brave.Click += new System.EventHandler(this.Brave_Click);
            // 
            // duckduckgob
            // 
            this.duckduckgob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duckduckgob.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.duckduckgob.FlatAppearance.BorderSize = 2;
            this.duckduckgob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duckduckgob.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duckduckgob.ForeColor = System.Drawing.Color.DarkCyan;
            this.duckduckgob.Location = new System.Drawing.Point(351, 48);
            this.duckduckgob.Name = "duckduckgob";
            this.duckduckgob.Size = new System.Drawing.Size(107, 41);
            this.duckduckgob.TabIndex = 10;
            this.duckduckgob.Text = "DuckDuckGO";
            this.duckduckgob.UseVisualStyleBackColor = true;
            this.duckduckgob.Click += new System.EventHandler(this.duck_click);
            // 
            // Utilitys
            // 
            this.Utilitys.AutoSize = true;
            this.Utilitys.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilitys.ForeColor = System.Drawing.Color.Black;
            this.Utilitys.Location = new System.Drawing.Point(7, 267);
            this.Utilitys.Name = "Utilitys";
            this.Utilitys.Size = new System.Drawing.Size(69, 27);
            this.Utilitys.TabIndex = 11;
            this.Utilitys.Text = "Utilities:";
            // 
            // Discorda
            // 
            this.Discorda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discorda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Discorda.FlatAppearance.BorderSize = 2;
            this.Discorda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discorda.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discorda.ForeColor = System.Drawing.Color.DarkCyan;
            this.Discorda.Location = new System.Drawing.Point(12, 297);
            this.Discorda.Name = "Discorda";
            this.Discorda.Size = new System.Drawing.Size(107, 41);
            this.Discorda.TabIndex = 12;
            this.Discorda.Text = "Discord";
            this.Discorda.UseVisualStyleBackColor = true;
            this.Discorda.Click += new System.EventHandler(this.dis_clicka); 
            // 
            // drpdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Discorda);
            this.Controls.Add(this.Utilitys);
            this.Controls.Add(this.duckduckgob);
            this.Controls.Add(this.Ghostery);
            this.Controls.Add(this.Brave);
            this.Controls.Add(this.Chrome);
            this.Controls.Add(this.launchers);
            this.Controls.Add(this.browsers);
            this.Controls.Add(this.TheCreator);
            this.Controls.Add(this.Lunar);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.Epicg);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.Name = "drpdownloader";
            this.Opacity = 0.5D;
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
            string downloadPath = Path.Combine(downfolder, "EpicGames-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }





            private void Steam_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Steam-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }



        private void EA_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "EA-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }



        private void Lunar_Clicke(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://launcherupdates.lunarclientcdn.com/Lunar%20Client%20v3.2.0.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "LunarClient-Setup.exe");
            client.DownloadFile(url, downloadPath);

        }



        private void ghostery_click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://get.ghosterybrowser.com/download/win";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Ghostery-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }

        private void Brave_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://laptop-updates.brave.com/latest/winx64";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Brave-setup.exe");
            client.DownloadFile(url, downloadPath);
        }

        private void Chrome_click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BC5149556-D401-3DFA-4DD1-B3BAF1B23264%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Chrome-setup.exe");
            client.DownloadFile(url, downloadPath);
        }


        private void duck_click(object sender,EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://staticcdn.duckduckgo.com/windows-desktop-browser/DuckDuckGo.appinstaller";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "DuckDGO-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }

        private void dis_clicka(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9028/DiscordSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Discord-Setup.exe");
            client.DownloadFile(url, downloadPath);
        }


    }
    }
