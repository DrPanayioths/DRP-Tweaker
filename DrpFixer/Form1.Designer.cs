using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Diagnostics;

namespace DrpFixer
{
    partial class drpdownloader
    {
        private System.Windows.Forms.Button Epicg;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button EA;
        private System.Windows.Forms.Button Lunar;
        private System.ComponentModel.IContainer components;
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
        private System.Windows.Forms.Button VS;
        private System.Windows.Forms.Button VsCode;
        private System.Windows.Forms.Button powerp;
        private System.Windows.Forms.Button Keyboarddd;
        private System.Windows.Forms.Button keybord;
        private Button computenchn;
        private Button spotfPrem;
        private Button vencord;
        private System.Windows.Forms.Label label1;
        private Button scrshots;
        private Button Photoshop;
        private Button videdtior;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Epicg = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.EA = new System.Windows.Forms.Button();
            this.Lunar = new System.Windows.Forms.Button();
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
            this.VS = new System.Windows.Forms.Button();
            this.VsCode = new System.Windows.Forms.Button();
            this.powerp = new System.Windows.Forms.Button();
            this.Keyboarddd = new System.Windows.Forms.Button();
            this.keybord = new System.Windows.Forms.Button();
            this.computenchn = new System.Windows.Forms.Button();
            this.spotfPrem = new System.Windows.Forms.Button();
            this.vencord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scrshots = new System.Windows.Forms.Button();
            this.Photoshop = new System.Windows.Forms.Button();
            this.videdtior = new System.Windows.Forms.Button();
            this.Viber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Signal = new System.Windows.Forms.Button();
            this.element = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Epicg
            // 
            this.Epicg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Epicg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Epicg.FlatAppearance.BorderSize = 2;
            this.Epicg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Epicg.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Epicg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Epicg.Location = new System.Drawing.Point(3, 446);
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
            this.Steam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Steam.Location = new System.Drawing.Point(116, 446);
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
            this.EA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EA.Location = new System.Drawing.Point(229, 446);
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
            this.Lunar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Lunar.Location = new System.Drawing.Point(342, 446);
            this.Lunar.Name = "Lunar";
            this.Lunar.Size = new System.Drawing.Size(107, 41);
            this.Lunar.TabIndex = 3;
            this.Lunar.Text = "Lunar Client";
            this.TipHoverare.SetToolTip(this.Lunar, "By MoonsWorth");
            this.Lunar.UseVisualStyleBackColor = true;
            this.Lunar.Click += new System.EventHandler(this.Lunar_Clicke);
            // 
            // Ghostery
            // 
            this.Ghostery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ghostery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ghostery.FlatAppearance.BorderSize = 2;
            this.Ghostery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ghostery.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghostery.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.Chrome.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.launchers.Location = new System.Drawing.Point(-2, 416);
            this.launchers.Name = "launchers";
            this.launchers.Size = new System.Drawing.Size(89, 27);
            this.launchers.TabIndex = 6;
            this.launchers.Text = "Launchers:";
            // 
            // Brave
            // 
            this.Brave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Brave.FlatAppearance.BorderSize = 2;
            this.Brave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brave.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brave.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.duckduckgob.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.Utilitys.Location = new System.Drawing.Point(-2, 326);
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
            this.Discorda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Discorda.Location = new System.Drawing.Point(3, 356);
            this.Discorda.Name = "Discorda";
            this.Discorda.Size = new System.Drawing.Size(107, 41);
            this.Discorda.TabIndex = 12;
            this.Discorda.Text = "Discord";
            this.Discorda.UseVisualStyleBackColor = true;
            this.Discorda.Click += new System.EventHandler(this.dis_clicka);
            // 
            // VS
            // 
            this.VS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VS.FlatAppearance.BorderSize = 2;
            this.VS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VS.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS.ForeColor = System.Drawing.Color.RoyalBlue;
            this.VS.Location = new System.Drawing.Point(116, 356);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(107, 41);
            this.VS.TabIndex = 13;
            this.VS.Text = "Visual Studio";
            this.VS.UseVisualStyleBackColor = true;
            this.VS.Click += new System.EventHandler(this.vs_clicka);
            // 
            // VsCode
            // 
            this.VsCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VsCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VsCode.FlatAppearance.BorderSize = 2;
            this.VsCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VsCode.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsCode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.VsCode.Location = new System.Drawing.Point(229, 356);
            this.VsCode.Name = "VsCode";
            this.VsCode.Size = new System.Drawing.Size(107, 41);
            this.VsCode.TabIndex = 14;
            this.VsCode.Text = "VS Code";
            this.VsCode.UseVisualStyleBackColor = true;
            this.VsCode.Click += new System.EventHandler(this.Vsc_clcik);
            // 
            // powerp
            // 
            this.powerp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.powerp.FlatAppearance.BorderSize = 2;
            this.powerp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerp.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerp.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.powerp.Location = new System.Drawing.Point(734, 343);
            this.powerp.Name = "powerp";
            this.powerp.Size = new System.Drawing.Size(93, 66);
            this.powerp.TabIndex = 15;
            this.powerp.Text = "Ultimate Performance Power";
            this.powerp.UseVisualStyleBackColor = true;
            this.powerp.Click += new System.EventHandler(this.dnsrunner_Click);
            // 
            // Keyboarddd
            // 
            this.Keyboarddd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Keyboarddd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Keyboarddd.FlatAppearance.BorderSize = 2;
            this.Keyboarddd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keyboarddd.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyboarddd.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Keyboarddd.Location = new System.Drawing.Point(635, 421);
            this.Keyboarddd.Name = "Keyboarddd";
            this.Keyboarddd.Size = new System.Drawing.Size(93, 66);
            this.Keyboarddd.TabIndex = 16;
            this.Keyboarddd.Text = "Mouse Optimization";
            this.Keyboarddd.UseVisualStyleBackColor = true;
            this.Keyboarddd.Click += new System.EventHandler(this.Mouseopt_Click);
            // 
            // keybord
            // 
            this.keybord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keybord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.keybord.FlatAppearance.BorderSize = 2;
            this.keybord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keybord.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keybord.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.keybord.Location = new System.Drawing.Point(734, 421);
            this.keybord.Name = "keybord";
            this.keybord.Size = new System.Drawing.Size(93, 66);
            this.keybord.TabIndex = 17;
            this.keybord.Text = "Keyboard Optimization";
            this.keybord.UseVisualStyleBackColor = true;
            this.keybord.Click += new System.EventHandler(this.keybord_click);
            // 
            // computenchn
            // 
            this.computenchn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.computenchn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.computenchn.FlatAppearance.BorderSize = 2;
            this.computenchn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computenchn.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computenchn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.computenchn.Location = new System.Drawing.Point(536, 421);
            this.computenchn.Name = "computenchn";
            this.computenchn.Size = new System.Drawing.Size(93, 66);
            this.computenchn.TabIndex = 18;
            this.computenchn.Text = "Computer Enchance";
            this.computenchn.UseVisualStyleBackColor = true;
            this.computenchn.Click += new System.EventHandler(this.computenchn_Click);
            // 
            // spotfPrem
            // 
            this.spotfPrem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spotfPrem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.spotfPrem.FlatAppearance.BorderSize = 2;
            this.spotfPrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spotfPrem.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spotfPrem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.spotfPrem.Location = new System.Drawing.Point(734, 8);
            this.spotfPrem.Name = "spotfPrem";
            this.spotfPrem.Size = new System.Drawing.Size(93, 66);
            this.spotfPrem.TabIndex = 19;
            this.spotfPrem.Text = "Spotify Premium";
            this.spotfPrem.UseVisualStyleBackColor = true;
            this.spotfPrem.Click += new System.EventHandler(this.spotfPrem_Click);
            // 
            // vencord
            // 
            this.vencord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vencord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vencord.FlatAppearance.BorderSize = 2;
            this.vencord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vencord.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.vencord.Location = new System.Drawing.Point(342, 356);
            this.vencord.Name = "vencord";
            this.vencord.Size = new System.Drawing.Size(107, 41);
            this.vencord.TabIndex = 20;
            this.vencord.Text = "Vencord Discord";
            this.vencord.UseVisualStyleBackColor = true;
            this.vencord.Click += new System.EventHandler(this.vencord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Design:";
            // 
            // scrshots
            // 
            this.scrshots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrshots.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scrshots.FlatAppearance.BorderSize = 2;
            this.scrshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrshots.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrshots.ForeColor = System.Drawing.Color.RoyalBlue;
            this.scrshots.Location = new System.Drawing.Point(3, 270);
            this.scrshots.Name = "scrshots";
            this.scrshots.Size = new System.Drawing.Size(107, 41);
            this.scrshots.TabIndex = 22;
            this.scrshots.Text = "ScreenShots";
            this.scrshots.UseVisualStyleBackColor = true;
            this.scrshots.Click += new System.EventHandler(this.scrshots_Click);
            // 
            // Photoshop
            // 
            this.Photoshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Photoshop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Photoshop.FlatAppearance.BorderSize = 2;
            this.Photoshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Photoshop.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Photoshop.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Photoshop.Location = new System.Drawing.Point(116, 270);
            this.Photoshop.Name = "Photoshop";
            this.Photoshop.Size = new System.Drawing.Size(107, 41);
            this.Photoshop.TabIndex = 23;
            this.Photoshop.Text = "Photoshop";
            this.Photoshop.UseVisualStyleBackColor = true;
            this.Photoshop.Click += new System.EventHandler(this.Photoshop_Click);
            // 
            // videdtior
            // 
            this.videdtior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videdtior.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.videdtior.FlatAppearance.BorderSize = 2;
            this.videdtior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videdtior.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videdtior.ForeColor = System.Drawing.Color.RoyalBlue;
            this.videdtior.Location = new System.Drawing.Point(229, 270);
            this.videdtior.Name = "videdtior";
            this.videdtior.Size = new System.Drawing.Size(107, 41);
            this.videdtior.TabIndex = 24;
            this.videdtior.Text = "Video Editor";
            this.videdtior.UseVisualStyleBackColor = true;
            this.videdtior.Click += new System.EventHandler(this.videdtior_Click);
            // 
            // Viber
            // 
            this.Viber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viber.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Viber.FlatAppearance.BorderSize = 2;
            this.Viber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viber.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Viber.Location = new System.Drawing.Point(116, 186);
            this.Viber.Name = "Viber";
            this.Viber.Size = new System.Drawing.Size(107, 41);
            this.Viber.TabIndex = 28;
            this.Viber.Text = "Viber";
            this.Viber.UseVisualStyleBackColor = true;
            this.Viber.Click += new System.EventHandler(this.Viber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Communication:";
            // 
            // Signal
            // 
            this.Signal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Signal.FlatAppearance.BorderSize = 2;
            this.Signal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signal.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Signal.Location = new System.Drawing.Point(3, 186);
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(107, 41);
            this.Signal.TabIndex = 29;
            this.Signal.Text = "Signal";
            this.Signal.UseVisualStyleBackColor = true;
            this.Signal.Click += new System.EventHandler(this.Signal_Click);
            // 
            // element
            // 
            this.element.Cursor = System.Windows.Forms.Cursors.Hand;
            this.element.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.element.FlatAppearance.BorderSize = 2;
            this.element.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.element.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.element.ForeColor = System.Drawing.Color.RoyalBlue;
            this.element.Location = new System.Drawing.Point(229, 186);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(107, 41);
            this.element.TabIndex = 30;
            this.element.Text = "Element";
            this.element.UseVisualStyleBackColor = true;
            this.element.Click += new System.EventHandler(this.element_Click);
            // 
            // drpdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 493);
            this.Controls.Add(this.element);
            this.Controls.Add(this.Signal);
            this.Controls.Add(this.Viber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videdtior);
            this.Controls.Add(this.Photoshop);
            this.Controls.Add(this.scrshots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vencord);
            this.Controls.Add(this.spotfPrem);
            this.Controls.Add(this.computenchn);
            this.Controls.Add(this.keybord);
            this.Controls.Add(this.Keyboarddd);
            this.Controls.Add(this.powerp);
            this.Controls.Add(this.VsCode);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.Discorda);
            this.Controls.Add(this.Utilitys);
            this.Controls.Add(this.duckduckgob);
            this.Controls.Add(this.Ghostery);
            this.Controls.Add(this.Brave);
            this.Controls.Add(this.Chrome);
            this.Controls.Add(this.launchers);
            this.Controls.Add(this.browsers);
            this.Controls.Add(this.Lunar);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.Epicg);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.Name = "drpdownloader";
            this.ShowIcon = false;
            this.Text = "DRP Tweaker (Provided By DrPanayioths)";
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
            RunDownloadedExecutable(downloadPath);
        }





        private void Steam_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Steam-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }



        private void EA_Clicker(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "EA-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }



        private void Lunar_Clicke(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://launcherupdates.lunarclientcdn.com/Lunar%20Client%20v3.2.0.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "LunarClient-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }



        private void ghostery_click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://get.ghosterybrowser.com/download/win";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Ghostery-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }

        private void Brave_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://laptop-updates.brave.com/latest/winx64";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Brave-setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }

        private void Chrome_click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BC5149556-D401-3DFA-4DD1-B3BAF1B23264%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Chrome-setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }


        private void duck_click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://staticcdn.duckduckgo.com/windows-desktop-browser/DuckDuckGo.appinstaller";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "DuckDGO-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }

        private void dis_clicka(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9028/DiscordSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadPath = Path.Combine(downfolder, "Discord-Setup.exe");
            client.DownloadFile(url, downloadPath);
            RunDownloadedExecutable(downloadPath);
        }

        private void Vsc_clcik(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "VScode-Setup");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }

        private void vs_clicka(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://aka.ms/vs/17/release/vs_community.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "VS-Setup");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }
        private void vencord_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            string url = "https://github.com/ArmCord/ArmCord/releases/download/v3.2.5/ArmCord.Setup.3.2.5.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Discvencord-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }

        private void scrshots_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://github.com/ShareX/ShareX/releases/download/v15.0.0/ShareX-15.0.0-setup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "ScreenShare-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }

        private void Photoshop_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://download.kde.org/stable/krita/5.2.2/krita-x64-5.2.2-setup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Photoshop-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);

        }

        private void RunDownloadedExecutable(string executablePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = executablePath;
            Process.Start(startInfo);
        }

        private void Runmsi(string executablePath)
        {
            Process.Start(executablePath);
        }

        private void videdtior_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://mirrors.dotsrc.org/blender/release/Blender4.0/blender-4.0.2-windows-x64.msi";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "VideoEdit-Setup.msi");
            client.DownloadFile(url, downloadpath);
            Runmsi(downloadpath);


        }

        private Button Viber;
        private System.Windows.Forms.Label label2;
        private Button Signal;
        private Button element;
    }
}

