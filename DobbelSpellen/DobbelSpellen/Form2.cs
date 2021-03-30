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
 
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNaam1.Text))
            {
                MessageBox.Show("Er is wat mis gegaan met de gegevens");
            }
            else
            {
                btnStart.Enabled = false;
                btnspeel.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picSpeler.Image = new Bitmap(open.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picSpeler.Image = new Bitmap(open.FileName);
            }
        }
        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
