using System;

namespace DrpFixer
{
    partial class drpdownloader
    {
        private System.Windows.Forms.Button Epicg;

        private void InitializeComponent()
        {
            this.Epicg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.Epicg.Click += new System.EventHandler(this.Epicg_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(125, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Steam";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(238, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Origin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(351, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "EA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // drpdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Epicg);
            this.Name = "drpdownloader";
            this.ShowIcon = false;
            this.Text = "DRP Downloader (Provided By DrPanayioths)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.drpdownloader_Load);
            this.ResumeLayout(false);

        }

        private void Epicg_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
