
namespace DobbelSpellen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.play21ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.play21ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hogerOfLagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bonusDobbelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raadHetWoordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.play21ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // play21ToolStripMenuItem1
            // 
            this.play21ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.play21ToolStripMenuItem2,
            this.hogerOfLagerToolStripMenuItem1,
            this.bonusDobbelToolStripMenuItem,
            this.raadHetWoordToolStripMenuItem1,
            this.aboutUsToolStripMenuItem1});
            this.play21ToolStripMenuItem1.Name = "play21ToolStripMenuItem1";
            this.play21ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.play21ToolStripMenuItem1.Text = "links";
            // 
            // play21ToolStripMenuItem2
            // 
            this.play21ToolStripMenuItem2.Name = "play21ToolStripMenuItem2";
            this.play21ToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.play21ToolStripMenuItem2.Text = "Play 21";
            this.play21ToolStripMenuItem2.Click += new System.EventHandler(this.play21ToolStripMenuItem2_Click);
            // 
            // hogerOfLagerToolStripMenuItem1
            // 
            this.hogerOfLagerToolStripMenuItem1.Name = "hogerOfLagerToolStripMenuItem1";
            this.hogerOfLagerToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.hogerOfLagerToolStripMenuItem1.Text = "Hoger of Lager";
            this.hogerOfLagerToolStripMenuItem1.Click += new System.EventHandler(this.hogerOfLagerToolStripMenuItem1_Click);
            // 
            // bonusDobbelToolStripMenuItem
            // 
            this.bonusDobbelToolStripMenuItem.Name = "bonusDobbelToolStripMenuItem";
            this.bonusDobbelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bonusDobbelToolStripMenuItem.Text = "Bonus Dobbel";
            this.bonusDobbelToolStripMenuItem.Click += new System.EventHandler(this.bonusDobbelToolStripMenuItem_Click);
            // 
            // raadHetWoordToolStripMenuItem1
            // 
            this.raadHetWoordToolStripMenuItem1.Name = "raadHetWoordToolStripMenuItem1";
            this.raadHetWoordToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.raadHetWoordToolStripMenuItem1.Text = "Raad het woord";
            this.raadHetWoordToolStripMenuItem1.Click += new System.EventHandler(this.raadHetWoordToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.aboutUsToolStripMenuItem1.Text = "About us";
            this.aboutUsToolStripMenuItem1.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem play21ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem play21ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hogerOfLagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bonusDobbelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raadHetWoordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem1;
    }
}