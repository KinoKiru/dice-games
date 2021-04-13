
using System;

namespace DobbelSpellen
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gbComputer = new System.Windows.Forms.GroupBox();
            this.tbComputer = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWinnaar = new System.Windows.Forms.PictureBox();
            this.Speloverzicht = new System.Windows.Forms.ListBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.radHoger = new System.Windows.Forms.RadioButton();
            this.radLager = new System.Windows.Forms.RadioButton();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnComputerfoto = new System.Windows.Forms.Button();
            this.btnSpelerfoto = new System.Windows.Forms.Button();
            this.tbDag = new System.Windows.Forms.TextBox();
            this.tbMaand = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbJaar = new System.Windows.Forms.TextBox();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.lblDag = new System.Windows.Forms.Label();
            this.lblMaand = new System.Windows.Forms.Label();
            this.lblJaar = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.gbSpeler = new System.Windows.Forms.GroupBox();
            this.tbSpeler = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnGooi = new System.Windows.Forms.Button();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblSpeler = new System.Windows.Forms.Label();
            this.tbPuntenSpeler = new System.Windows.Forms.TextBox();
            this.tbPuntenComputer = new System.Windows.Forms.TextBox();
            this.lblWinnaar = new System.Windows.Forms.Label();
            this.lbResultaten = new System.Windows.Forms.ListBox();
            this.gbComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinnaar)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbSpeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbComputer
            // 
            this.gbComputer.Controls.Add(this.tbComputer);
            this.gbComputer.Controls.Add(this.pictureBox2);
            this.gbComputer.Controls.Add(this.pictureBox3);
            this.gbComputer.Controls.Add(this.pictureBox1);
            this.gbComputer.Location = new System.Drawing.Point(19, 12);
            this.gbComputer.Name = "gbComputer";
            this.gbComputer.Size = new System.Drawing.Size(338, 253);
            this.gbComputer.TabIndex = 0;
            this.gbComputer.TabStop = false;
            this.gbComputer.Text = "Computer";
            // 
            // tbComputer
            // 
            this.tbComputer.Location = new System.Drawing.Point(130, 217);
            this.tbComputer.Name = "tbComputer";
            this.tbComputer.ReadOnly = true;
            this.tbComputer.Size = new System.Drawing.Size(79, 20);
            this.tbComputer.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(228, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picWinnaar
            // 
            this.picWinnaar.Location = new System.Drawing.Point(780, 299);
            this.picWinnaar.Name = "picWinnaar";
            this.picWinnaar.Size = new System.Drawing.Size(150, 186);
            this.picWinnaar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWinnaar.TabIndex = 2;
            this.picWinnaar.TabStop = false;
            // 
            // Speloverzicht
            // 
            this.Speloverzicht.FormattingEnabled = true;
            this.Speloverzicht.Items.AddRange(new object[] {
            "Speloverzicht  Hoger - Lager",
            "",
            "Worpen:  Speler:     Computer:"});
            this.Speloverzicht.Location = new System.Drawing.Point(19, 301);
            this.Speloverzicht.Name = "Speloverzicht";
            this.Speloverzicht.Size = new System.Drawing.Size(347, 186);
            this.Speloverzicht.TabIndex = 3;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Location = new System.Drawing.Point(16, 285);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(129, 13);
            this.lblStand.TabIndex = 4;
            this.lblStand.Text = "Aantal punten en worpen:";
            // 
            // radHoger
            // 
            this.radHoger.AutoSize = true;
            this.radHoger.Checked = true;
            this.radHoger.Location = new System.Drawing.Point(497, 285);
            this.radHoger.Name = "radHoger";
            this.radHoger.Size = new System.Drawing.Size(54, 17);
            this.radHoger.TabIndex = 5;
            this.radHoger.TabStop = true;
            this.radHoger.Text = "Hoger";
            this.radHoger.UseVisualStyleBackColor = true;
            // 
            // radLager
            // 
            this.radLager.AutoSize = true;
            this.radLager.Location = new System.Drawing.Point(586, 285);
            this.radLager.Name = "radLager";
            this.radLager.Size = new System.Drawing.Size(52, 17);
            this.radLager.TabIndex = 6;
            this.radLager.Text = "Lager";
            this.radLager.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnOpslaan);
            this.gbInfo.Controls.Add(this.btnComputerfoto);
            this.gbInfo.Controls.Add(this.btnSpelerfoto);
            this.gbInfo.Controls.Add(this.tbDag);
            this.gbInfo.Controls.Add(this.tbMaand);
            this.gbInfo.Controls.Add(this.tbNaam);
            this.gbInfo.Controls.Add(this.tbJaar);
            this.gbInfo.Controls.Add(this.lblGeboortedatum);
            this.gbInfo.Controls.Add(this.lblDag);
            this.gbInfo.Controls.Add(this.lblMaand);
            this.gbInfo.Controls.Add(this.lblJaar);
            this.gbInfo.Controls.Add(this.lblNaam);
            this.gbInfo.Location = new System.Drawing.Point(780, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(338, 268);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(91, 234);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(152, 23);
            this.btnOpslaan.TabIndex = 21;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnComputerfoto
            // 
            this.btnComputerfoto.Location = new System.Drawing.Point(91, 202);
            this.btnComputerfoto.Name = "btnComputerfoto";
            this.btnComputerfoto.Size = new System.Drawing.Size(152, 26);
            this.btnComputerfoto.TabIndex = 17;
            this.btnComputerfoto.Text = "Open Computer Foto";
            this.btnComputerfoto.UseVisualStyleBackColor = true;
            this.btnComputerfoto.Click += new System.EventHandler(this.btnComputerfoto_Click);
            // 
            // btnSpelerfoto
            // 
            this.btnSpelerfoto.Location = new System.Drawing.Point(91, 170);
            this.btnSpelerfoto.Name = "btnSpelerfoto";
            this.btnSpelerfoto.Size = new System.Drawing.Size(152, 26);
            this.btnSpelerfoto.TabIndex = 16;
            this.btnSpelerfoto.Text = "Open speler foto";
            this.btnSpelerfoto.UseVisualStyleBackColor = true;
            this.btnSpelerfoto.Click += new System.EventHandler(this.btnSpelerfoto_Click);
            // 
            // tbDag
            // 
            this.tbDag.Location = new System.Drawing.Point(91, 144);
            this.tbDag.Name = "tbDag";
            this.tbDag.Size = new System.Drawing.Size(152, 20);
            this.tbDag.TabIndex = 17;
            // 
            // tbMaand
            // 
            this.tbMaand.Location = new System.Drawing.Point(91, 111);
            this.tbMaand.Name = "tbMaand";
            this.tbMaand.Size = new System.Drawing.Size(152, 20);
            this.tbMaand.TabIndex = 18;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(91, 23);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(152, 20);
            this.tbNaam.TabIndex = 19;
            // 
            // tbJaar
            // 
            this.tbJaar.Location = new System.Drawing.Point(91, 77);
            this.tbJaar.Name = "tbJaar";
            this.tbJaar.Size = new System.Drawing.Size(152, 20);
            this.tbJaar.TabIndex = 16;
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(88, 61);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(83, 13);
            this.lblGeboortedatum.TabIndex = 17;
            this.lblGeboortedatum.Text = "Geboortedatum:";
            // 
            // lblDag
            // 
            this.lblDag.AutoSize = true;
            this.lblDag.Location = new System.Drawing.Point(38, 147);
            this.lblDag.Name = "lblDag";
            this.lblDag.Size = new System.Drawing.Size(30, 13);
            this.lblDag.TabIndex = 18;
            this.lblDag.Text = "Dag:";
            // 
            // lblMaand
            // 
            this.lblMaand.AutoSize = true;
            this.lblMaand.Location = new System.Drawing.Point(38, 114);
            this.lblMaand.Name = "lblMaand";
            this.lblMaand.Size = new System.Drawing.Size(43, 13);
            this.lblMaand.TabIndex = 19;
            this.lblMaand.Text = "Maand:";
            // 
            // lblJaar
            // 
            this.lblJaar.AutoSize = true;
            this.lblJaar.Location = new System.Drawing.Point(38, 80);
            this.lblJaar.Name = "lblJaar";
            this.lblJaar.Size = new System.Drawing.Size(30, 13);
            this.lblJaar.TabIndex = 20;
            this.lblJaar.Text = "Jaar:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(38, 26);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 16;
            this.lblNaam.Text = "Naam:";
            // 
            // gbSpeler
            // 
            this.gbSpeler.Controls.Add(this.tbSpeler);
            this.gbSpeler.Controls.Add(this.pictureBox5);
            this.gbSpeler.Controls.Add(this.pictureBox6);
            this.gbSpeler.Controls.Add(this.pictureBox4);
            this.gbSpeler.Location = new System.Drawing.Point(397, 12);
            this.gbSpeler.Name = "gbSpeler";
            this.gbSpeler.Size = new System.Drawing.Size(338, 253);
            this.gbSpeler.TabIndex = 8;
            this.gbSpeler.TabStop = false;
            this.gbSpeler.Text = "Speler: ";
            // 
            // tbSpeler
            // 
            this.tbSpeler.Location = new System.Drawing.Point(130, 217);
            this.tbSpeler.Name = "tbSpeler";
            this.tbSpeler.ReadOnly = true;
            this.tbSpeler.Size = new System.Drawing.Size(79, 20);
            this.tbSpeler.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(129, 121);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(228, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnGooi
            // 
            this.btnGooi.Enabled = false;
            this.btnGooi.Location = new System.Drawing.Point(526, 321);
            this.btnGooi.Name = "btnGooi";
            this.btnGooi.Size = new System.Drawing.Size(80, 19);
            this.btnGooi.TabIndex = 9;
            this.btnGooi.Text = "Gooi";
            this.btnGooi.UseVisualStyleBackColor = true;
            this.btnGooi.Click += new System.EventHandler(this.btnGooi_Click);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(459, 373);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(92, 13);
            this.lblComputer.TabIndex = 10;
            this.lblComputer.Text = "Punten Computer:";
            // 
            // lblSpeler
            // 
            this.lblSpeler.AutoSize = true;
            this.lblSpeler.Location = new System.Drawing.Point(583, 373);
            this.lblSpeler.Name = "lblSpeler";
            this.lblSpeler.Size = new System.Drawing.Size(77, 13);
            this.lblSpeler.TabIndex = 11;
            this.lblSpeler.Text = "Punten Speler:";
            // 
            // tbPuntenSpeler
            // 
            this.tbPuntenSpeler.Location = new System.Drawing.Point(586, 399);
            this.tbPuntenSpeler.Name = "tbPuntenSpeler";
            this.tbPuntenSpeler.ReadOnly = true;
            this.tbPuntenSpeler.Size = new System.Drawing.Size(89, 20);
            this.tbPuntenSpeler.TabIndex = 12;
            // 
            // tbPuntenComputer
            // 
            this.tbPuntenComputer.Location = new System.Drawing.Point(462, 399);
            this.tbPuntenComputer.Name = "tbPuntenComputer";
            this.tbPuntenComputer.ReadOnly = true;
            this.tbPuntenComputer.Size = new System.Drawing.Size(89, 20);
            this.tbPuntenComputer.TabIndex = 13;
            // 
            // lblWinnaar
            // 
            this.lblWinnaar.AutoSize = true;
            this.lblWinnaar.Location = new System.Drawing.Point(777, 283);
            this.lblWinnaar.Name = "lblWinnaar";
            this.lblWinnaar.Size = new System.Drawing.Size(47, 13);
            this.lblWinnaar.TabIndex = 14;
            this.lblWinnaar.Text = "Winnaar";
            // 
            // lbResultaten
            // 
            this.lbResultaten.FormattingEnabled = true;
            this.lbResultaten.Location = new System.Drawing.Point(961, 299);
            this.lbResultaten.Name = "lbResultaten";
            this.lbResultaten.Size = new System.Drawing.Size(157, 186);
            this.lbResultaten.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 500);
            this.Controls.Add(this.lbResultaten);
            this.Controls.Add(this.lblWinnaar);
            this.Controls.Add(this.tbPuntenComputer);
            this.Controls.Add(this.tbPuntenSpeler);
            this.Controls.Add(this.lblSpeler);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.btnGooi);
            this.Controls.Add(this.gbSpeler);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.radLager);
            this.Controls.Add(this.radHoger);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.Speloverzicht);
            this.Controls.Add(this.picWinnaar);
            this.Controls.Add(this.gbComputer);
            this.Name = "Form3";
            this.Text = "Hoger - Lager";
            this.gbComputer.ResumeLayout(false);
            this.gbComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinnaar)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSpeler.ResumeLayout(false);
            this.gbSpeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbComputer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picWinnaar;
        private System.Windows.Forms.ListBox Speloverzicht;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.RadioButton radHoger;
        private System.Windows.Forms.RadioButton radLager;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbComputer;
        private System.Windows.Forms.GroupBox gbSpeler;
        private System.Windows.Forms.TextBox tbSpeler;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnGooi;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblSpeler;
        private System.Windows.Forms.TextBox tbPuntenSpeler;
        private System.Windows.Forms.TextBox tbPuntenComputer;
        private System.Windows.Forms.Label lblWinnaar;
        private System.Windows.Forms.TextBox tbDag;
        private System.Windows.Forms.TextBox tbMaand;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbJaar;
        private System.Windows.Forms.Label lblGeboortedatum;
        private System.Windows.Forms.Label lblDag;
        private System.Windows.Forms.Label lblMaand;
        private System.Windows.Forms.Label lblJaar;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnComputerfoto;
        private System.Windows.Forms.Button btnSpelerfoto;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.ListBox lbResultaten;
    }
}