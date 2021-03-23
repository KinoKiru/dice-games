using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobbelSpellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hier maak ik de Menu links die verwijzen naar de andere form,
        /// ook laat ik de home form terug komen nadat je de externe form hebt gesloten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Menu links
        private void play21ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // de variable Play is nu de Form2, de home form hide ik daarna laat ik Play zien en dan als die weggeklikt is laat ik weer home zien
            Form2 Play21 = new Form2();
            this.Hide();
            Play21.ShowDialog();
            this.Show();
        }

        private void hogerOfLagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 HogerofLager = new Form3();
            this.Hide();
            HogerofLager.ShowDialog();
            this.Show();
        }

        private void bonusDobbelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 bonusDobbel = new Form4();
            this.Hide();
            bonusDobbel.ShowDialog();
            this.Show();
        }

        private void raadHetWoordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 raadHetWoord = new Form5();
            this.Hide();
            raadHetWoord.ShowDialog();
            this.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // als op about us wordt geklikt linkt hij door naar form 6
            Form6 aboutUs = new Form6();
            this.Hide();
            aboutUs.ShowDialog();
            this.Show();
        }
        #endregion


    }
}
