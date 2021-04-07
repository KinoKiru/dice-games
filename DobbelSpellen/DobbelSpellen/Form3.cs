using System;
using System.Drawing;
using System.Windows.Forms;

namespace DobbelSpellen
{
    public partial class Form3 : Form
    {
        private int AantalWorpen = 0;
        private int PuntenComputer;
        private int PuntenSpeler;
        private int Rondes = 0;
        private int[] beurtComputer;
        private int[] beurtSpeler;
        private Image imageSpeler;
        private Image imageComputer;
        private DateTime Geboortedatum;
        private int Winnaar;

        public Form3()
        {
            InitializeComponent();
            PuntenComputer = 0;
            PuntenSpeler = 0;
        }

        public void ToonDobbelStenenComputer(int[] worp)
        {
            this.pictureBox1.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[0]));
            this.pictureBox2.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[1]));
            this.pictureBox3.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[2]));
        }

        public void ToonDobbelStenenSpeler(int[] worp)
        {
            this.pictureBox4.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[0]));
            this.pictureBox5.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[1]));
            this.pictureBox6.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[2]));
        }


        private void btnGooi_Click(object sender, EventArgs e)
        {
            if (AantalWorpen < 6)
            {

                beurtComputer = Gooien.GooiDobbelStenen();
                beurtSpeler = Gooien.GooiDobbelStenen();

                ToonDobbelStenenComputer(beurtComputer);
                ToonDobbelStenenSpeler(beurtSpeler);


                // Bepaal de worp waarde van de computer
                int totaalComputer = 0;
                foreach (int steen in beurtComputer)
                {
                    totaalComputer += steen;
                }
                tbComputer.Text = totaalComputer.ToString();

                // Bepaal de worp waarde van de speler
                int totaalSpeler = 0;
                foreach (int steen in beurtSpeler)
                {
                    totaalSpeler += steen;
                }
                tbSpeler.Text = totaalSpeler.ToString();

                int verschil = Math.Abs(totaalComputer - totaalSpeler);

                if (radHoger.Checked)
                {
                    if (totaalComputer < totaalSpeler)
                    {
                        // punten naar speler
                        PuntenSpeler += verschil;
                        tbPuntenSpeler.Text = Convert.ToString(PuntenSpeler);
                    }
                    else
                    {
                        // punten naar computer
                        PuntenComputer += verschil;
                        tbPuntenComputer.Text = Convert.ToString(PuntenComputer);
                    }
                }
                else
                {
                    if (totaalComputer < totaalSpeler)
                    {
                        // punten naar speler
                        PuntenSpeler += verschil;
                    }
                    else
                    {
                        // punten naar computer
                        PuntenComputer += verschil;
                    }
                }
                AantalWorpen++;
            }
            else
            {
                // Bepalen wie de winnaar is
                btnGooi.Enabled = false;
            }

            tbPuntenComputer.Text = PuntenComputer.ToString();
            tbPuntenSpeler.Text = PuntenSpeler.ToString();


            Speloverzicht.Items.Add(string.Format("Worp {0}\t{1}\t{2}", AantalWorpen, PuntenSpeler, PuntenComputer));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void btnSpelerfoto_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                path = of.FileName;
                imageSpeler = Image.FromFile(path);
            }
        }

        private void btnComputerfoto_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                path = of.FileName;
                imageComputer = Image.FromFile(path);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNaam.Text != "" && tbJaar.Text != "" && tbMaand.Text != "" && tbDag.Text != "" && btnComputerfoto != null && btnSpelerfoto != null)
                {
                    btnGooi.Enabled = true;
                }
                else
                    MessageBox.Show("Vul alle gegevens in!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picWinnaar_Click(object sender, EventArgs e)
        {

        }
    }
}

