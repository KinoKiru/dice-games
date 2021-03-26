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
            Random rmd = new Random();
            int randomfoto = rmd.Next(1, 3);
            if(randomfoto == 1)
            {
                picSpeler.Image = Foto1;
            }
            else
            {
                picSpeler.Image = Foto2;
            }
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
