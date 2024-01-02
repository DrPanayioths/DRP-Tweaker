using System;

namespace DrpFixer
{
    partial class drpdownloader
    {
        private System.Windows.Forms.Button Epicg;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button Origin;
        private System.Windows.Forms.Button EA;

        private void InitializeComponent()
        {
            this.Epicg = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.Origin = new System.Windows.Forms.Button();
            this.EA = new System.Windows.Forms.Button();
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
            // Origin
            // 
            this.Origin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Origin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Origin.Location = new System.Drawing.Point(238, 387);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(107, 41);
            this.Origin.TabIndex = 2;
            this.Origin.Text = "Origin";
            this.Origin.UseVisualStyleBackColor = true;
            this.Origin.Click += new System.EventHandler(this.Origin_Clicker);
            // 
            // EA
            // 
            this.EA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EA.Location = new System.Drawing.Point(351, 387);
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(107, 41);
            this.EA.TabIndex = 3;
            this.EA.Text = "EA";
            this.EA.UseVisualStyleBackColor = true;
            this.EA.Click += new System.EventHandler(this.ea_Clicke);
            // 
            // drpdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.Epicg);
            this.Name = "drpdownloader";
            this.ShowIcon = false;
            this.Text = "DRP Downloader (Provided By DrPanayioths)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.drpdownloader_Load);
            this.ResumeLayout(false);

        }

        private void Epic_Click(object sender, EventArgs e)
        {

        }
        private void Steam_Clicker(object sender, EventArgs e)
        {

        }
        private void Origin_Clicker(object sender, EventArgs e)
        {

        }
        private void ea_Clicke(object sender, EventArgs e)
        {

        }




    }
}
