using System;
using System.Drawing;
using System.Windows.Forms;

namespace DobbelSpellen
{
    public partial class Form3 : Form
    {
        // start getal array
        private int AantalWorpen = 0;
        // hier haal je de punten computer
        private int PuntenComputer;
        // hier haal de de punten speler
        private int PuntenSpeler;
        // zodat ze beurten hebben die gelijk lopen
        private int[] beurtComputer;
        private int[] beurtSpeler;
        // hier haal je de computer locatie foto op
        string ComputerFoto = "";
        // hier haal je de speler locatie foto op
        string SpelerFoto = "";
        // dit pakt de tijd als je hem opstart
        private DateTime nu;
        //als je de 6 rondes heb gehad pakt hij de tijd
        private DateTime recent;

        public Form3()
        {
            // punten, initialiseren en speeltijd zetten
            InitializeComponent();
            PuntenComputer = 0;
            PuntenSpeler = 0;
            nu = DateTime.Now;
        }

        public void ToonDobbelStenenComputer(int[] worp)
        {
            // laden plaatjes, 1 t/m 3
            this.pictureBox1.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[0]));
            this.pictureBox2.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[1]));
            this.pictureBox3.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[2]));
        }

        public void ToonDobbelStenenSpeler(int[] worp)
        {
            // laden plaatjes, 4 t/m 6
            this.pictureBox4.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[0]));
            this.pictureBox5.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[1]));
            this.pictureBox6.Image = Image.FromFile(string.Format("photo\\dice_{0}.jpg", worp[2]));
        }

        private void btnGooi_Click(object sender, EventArgs e)
        {
            AantalWorpen++;
            if (AantalWorpen <= 6)
            {
                // zodat ze gegooid ze gegooid worden
                beurtComputer = Gooien.GooiDobbelStenen();
                beurtSpeler = Gooien.GooiDobbelStenen();

                // tonen van de dobbelstenen, zodat het word opgeschreven
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
                // bepalen van het verschil
                int verschil = Math.Abs(totaalComputer - totaalSpeler);

                if (radHoger.Checked)
                {
                    // hoger is geselecteerd
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
                tbPuntenComputer.Text = PuntenComputer.ToString();
                tbPuntenSpeler.Text = PuntenSpeler.ToString();

                // de resultaten worden getoont in de listbox
                Speloverzicht.Items.Add(string.Format("Worp {0}\t{1}\t{2}", AantalWorpen, PuntenSpeler, PuntenComputer));
            }
            else
            {
                // Als er 6 keer gegooid is zet de gooi button uit
                if (AantalWorpen == 6)
                {
                    btnGooi.Enabled = false;
                }
                // Bepalen wie de winnaar is
                if (PuntenSpeler < PuntenComputer)
                {
                    // de resultaten worden getoont in de listbox
                    Speloverzicht.Items.Add(string.Format("Computer " + " " + "heeft gewonnen met " + (PuntenComputer - PuntenSpeler) + " punten" + "\r\n"));
                    recent = DateTime.Now;
                    picWinnaar.Image = Image.FromFile(ComputerFoto);
                    // de resultaten worden getoont in de listbox
                    lbResultaten.Items.Add(string.Format("Winnaar: Computer\n"));
                    lbResultaten.Items.Add(string.Format("Gewonnen met " + (PuntenComputer - PuntenSpeler) + " punten" + "\r\n"));
                    lbResultaten.Items.Add(string.Format("Speeltijd: " + (recent - nu)));
                }               
                else if (PuntenSpeler > PuntenComputer)
                {
                    // de resultaten worden getoont in de listbox
                    Speloverzicht.Items.Add(tbNaam.Text + " " + "heeft gewonnen met: " + (PuntenSpeler - PuntenComputer) + " Punten" + "\r\n");
                    recent = DateTime.Now;
                    picWinnaar.Image = Image.FromFile(SpelerFoto);
                    // de resultaten worden getoont in de listbox
                    lbResultaten.Items.Add(string.Format("Winnaar: " + tbNaam.Text + "\r\n"));
                    lbResultaten.Items.Add(string.Format("Geboortedatum: " + tbDag.Text + "-" + tbMaand.Text + "-" + tbJaar.Text + "\r\n"));
                    lbResultaten.Items.Add(string.Format("Gewonnen met " + (PuntenSpeler - PuntenComputer) + " Punten" + "\r\n"));
                    lbResultaten.Items.Add(string.Format("Speeltijd: " + (recent - nu)));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // hier gebeurd niks mee
            throw new NotImplementedException();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // hier gebeurd niks mee
            throw new NotImplementedException();
        }

        private void btnSpelerfoto_Click(object sender, EventArgs e)
        {
            try
            {
                // dit opent de folder zodat je een file kan selecteren
                OpenFileDialog pathTo = new OpenFileDialog();
                // je kan hier alleen jpgs jpegs en pngs gebruiken
                pathTo.Filter = "Image Files | *.jpg; *.jpeg; *.png;";
                pathTo.FilterIndex = 1;
                // je kan maar 1 file kiezen geen meerderen
                pathTo.Multiselect = false;

                if (pathTo.ShowDialog() == DialogResult.OK)
                {
                // deze if kan nooit fout gaan want je kan namelijk alleen maar fotos selecteren
                    SpelerFoto = pathTo.FileName;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnComputerfoto_Click(object sender, EventArgs e)
        {
            try
            {
                // dit opent de folder zodat je een file kan selecteren
                OpenFileDialog pathTo = new OpenFileDialog();
                // je kan hier alleen jpgs jpegs en pngs gebruiken
                pathTo.Filter = "Image Files | *.jpg; *.jpeg; *.png;";
                pathTo.FilterIndex = 1;
                // je kan maar 1 file kiezen geen meerderen
                pathTo.Multiselect = false;

                if (pathTo.ShowDialog() == DialogResult.OK)
                {
                // deze if kan nooit fout gaan want je kan namelijk alleen maar fotos selecteren
                    ComputerFoto = pathTo.FileName;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                // opsla button code, als de volgende dingen niet worden ingevult kun je niet verder 
                if (tbNaam.Text != string.Empty && tbJaar.Text != string.Empty && tbMaand.Text != string.Empty && tbDag.Text != string.Empty)
                {
                    btnGooi.Enabled = true;
                }
                else
                {
                    // bericht als er niks word ingevult
                    MessageBox.Show("Vul alle gegevens in!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

