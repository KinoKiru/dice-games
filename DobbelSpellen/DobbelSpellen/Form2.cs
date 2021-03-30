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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxField.Text))
            MessageBox.Show("Er is wat mis gegaan met de gegevens");
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnSelecteerFoto1.Image = Image.FromFile(@".png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnSelecteerFoto2.Image = Image.FromFile(@".png");
        }
    }
}
