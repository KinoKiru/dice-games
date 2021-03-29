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
    public partial class Form4 : Form
    {
        /// <summary>
        /// Hier maak ik meerdere global variabele
        /// </summary>
        #region Global variable
        //global variable
        private string path;

        //Array met 6 indexnummers
        private int[] getallen = new int[8];

        //Randomizer
        private Random objRandom = new Random();

        //deze houdt de rondes bij
        private int rondes = 1;

        //dit is de bonus voor speler 1
        private int bonus1 = 0;
        //dit is de bonus voor speler 2
        private int bonus2 = 0;

        private int ttotaal = 0;
        private int ttotaal2 = 0;

        private string errorImagePath = "";

        private string playerOneImagePath = "";

        private string playerTwoImagePath = "";

        private int x = 0;

        private DateTime nu ;

        private DateTime recent;

        #endregion

        public Form4()
        {
            // de GetPath verkrijgt het pad naar de photo map
            GetPath();

            InitializeComponent();

            // de start methode geeft de combobox values
            start();
        }

        // hier staan de methodes voor de hele form
        #region Methodes

        /// <summary>
        /// Hier zoek ik naar de path naar dit programma naar de fotos voor de dice
        /// </summary>
        private void GetPath()
        {
            path = Application.StartupPath;
            path = path.Substring(0, path.Length - 9);
            path += "photo\\dice_";
            errorImagePath = (path + "cross" + ".jpg");

        }




        /// <summary>
        /// hier maak ik de random getallen
        /// </summary>
        public void PullRandomNumbers()
        {
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = objRandom.Next(1, 7); //Trekt getallen van 1 tot en met 6

            }
        }

        /// <summary>
        /// als speler 1 wint dan kont zijn fot tevoren via deze methode
        /// </summary>
        public void SelecteerFotos()
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
                    playerOneImagePath = pathTo.FileName;
                }
                // deze if kan nooit fout gaan want je kan namelijk alleen maar fotos selecteren

            }
            catch (Exception) { pbWinaar.Image = Image.FromFile(errorImagePath); }

        }

        /// <summary>
        /// Als speler 2 wint dan word zo de foto getoond 
        /// </summary>
        public void SelecteerFotos2()
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
                    playerTwoImagePath = pathTo.FileName;
                }
                // deze if kan nooit fout gaan want je kan namelijk alleen maar fotos selecteren

            }
            catch (Exception) { pbWinaar.Image = Image.FromFile(errorImagePath); }

        }


        /// <summary>
        /// dit voegt de bonus optie value toe
        /// </summary>
        public void start()
        {
            for (int i = 0; i < 6; i++)
            {
                getallen[i] = i + 1;
                cbOnderBonus.Items.Add(getallen[i]);
                cmbBonus.Items.Add(getallen[i]);
            }
           
        }

        /// <summary>
        /// hier laat ik de dices zien die getrokken zijn
        /// </summary>
        private void ShowDices()
        {
            pb1.Image = Image.FromFile(path + getallen[0] + ".jpg");
            pb2.Image = Image.FromFile(path + getallen[1] + ".jpg");
            pb3.Image = Image.FromFile(path + getallen[2] + ".jpg");
            pb4.Image = Image.FromFile(path + getallen[3] + ".jpg");
            pbOnder1.Image = Image.FromFile(path + getallen[4] + ".jpg");
            pbOnder2.Image = Image.FromFile(path + getallen[5] + ".jpg");
            pbOnder3.Image = Image.FromFile(path + getallen[6] + ".jpg");
            pbOnder4.Image = Image.FromFile(path + getallen[7] + ".jpg");
        }

        /// <summary>
        /// hier bereken ik de bonus door na te gaan of de getallen overeen komen
        /// </summary>
        private void bonus()
        {
            int bonussp2 = cbOnderBonus.SelectedIndex + 1;
            int bonussp1 = cmbBonus.SelectedIndex + 1;


            for (int i = 0; i <= 4; i++)
            {
                if (bonussp1 == getallen[i]) { bonus1++; }
            };

            for (int i = 4; i < 8; i++)
            {
                if (bonussp2 == getallen[i]) { bonus2++; }
            };
        }

        /// <summary>
        /// dit telt alle punten op en laat vervolgens de winnaar zien
        /// </summary>
        private void totaalpunten()
        {
            int som1 = 0;
            int som2 = 0;

            for (int i = 0; i < 4; i++)
            {
                som1 += getallen[i];
            };

            for (int i = 4; i < 8; i++)
            {
                som2 += getallen[i];
            };
        
            int totaal1 = som1 + bonus1;
            int totaal2 = som2 + bonus2;
            ttotaal += totaal1;
            ttotaal2 += totaal2;

            tbPunten.Text = totaal1.ToString();
            tbOnderPunten.Text = totaal2.ToString();
            lbpuntentelling.Items.Add("Bonus: " +bonus1 + " " + (totaal1 - bonus1) + " " + totaal1);
            lbOnderpuntentelling.Items.Add("Bonus: " +bonus2 + " " + (totaal2 - bonus2) + " " + totaal2);
            
            if (x == 3)
            {
                try
                {
                   
                    if (ttotaal > ttotaal2)
                    {
                        recent = DateTime.Now;
                        lbWinnaar.Items.Clear();
                        pbWinaar.Image = Image.FromFile(playerOneImagePath);
                        lbWinnaar.Items.Add("winnaar: " + tbNaam.Text  + "\r\n");
                        lbWinnaar.Items.Add("Geboortedatum: " + dateTimePicker1.Value + "\r\n");
                        lbWinnaar.Items.Add("Gewonnen met " + (ttotaal - ttotaal2) + " punten verschil" + "\r\n");
                        lbWinnaar.Items.Add("Speeltijd: " +(recent - nu) + "\r\n");
                        lbOnderpuntentelling.Items.Add("Totaal punten: " + ttotaal2);
                        lbpuntentelling.Items.Add("Totaal punten: " + ttotaal);

                    }
                    else if (ttotaal2 > ttotaal)
                    {
                        lbWinnaar.Items.Clear();
                        pbWinaar.Image = Image.FromFile(playerTwoImagePath);
                        lbWinnaar.Items.Add("winnaar: " + tbNaam2.Text + "\r\n");
                        lbWinnaar.Items.Add("Geboortedatum: " + dateTimePicker2.Value + "\r\n");
                        lbWinnaar.Items.Add("Gewonnen met " + (ttotaal2 - ttotaal) + " punten verschil" + "\r\n");
                        lbWinnaar.Items.Add("Speeltijd: " + (recent - nu) + "\r\n");
                        lbOnderpuntentelling.Items.Add("Totaal punten: " + ttotaal2);
                        lbpuntentelling.Items.Add("Totaal punten: " + ttotaal);
                    };
                }
                finally //  hier zet ik alles op 0 zodat je weer opnieuw kan beginnen
                {
                    totaal1 = 0;
                    totaal2 = 0;
                    bonus1 = 0;
                    bonus2 = 0;
                    x = 0;
                    ttotaal = 0;
                    ttotaal2 = 0;
                }
            }
            else
            {// als je nog geen 5 rondjes hebt gedaan gaat de counter met 1 omhoog
                x++;
            }

        }

     
        #endregion


        /// <summary>
        /// Hier zijn alle Controls die op de form staan, en het load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region controls
        #region Foto selectieknop
        private void tbSelecteer_Click(object sender, EventArgs e)
        {
            SelecteerFotos();
        }
        private void btnSelecteer2_Click(object sender, EventArgs e)
        {
            SelecteerFotos2();
        }
        #endregion
        #region data opslaan
        private void btnOpslaan2_Click(object sender, EventArgs e)
        {
            try
            {
               
                lbOnderpuntentelling.Items.Clear();
                gbSpeler2.Text = tbNaam2.Text;
                lbOnderpuntentelling.Items.Add("Spel overzicht van: " + tbNaam2.Text);
                lbOnderpuntentelling.Items.Add("Bonus:   Ogen:   Totaal:");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void tbOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                lbpuntentelling.Items.Clear();
                gbPlayer1.Text = tbNaam.Text;
                lbpuntentelling.Items.Add("Spel overzicht van: " + tbNaam.Text);
                lbpuntentelling.Items.Add("Bonus:   Ogen:   Totaal:");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion
        #region Vul picturebox
        private void Form4_Load(object sender, EventArgs e)
        {
            pb1.Image = Image.FromFile(path + "1.jpg");
            pb2.Image = Image.FromFile(path + "2.jpg");
            pb3.Image = Image.FromFile(path + "3.jpg");
            pb4.Image = Image.FromFile(path + "4.jpg");
            pbOnder1.Image = Image.FromFile(path + "3.jpg");
            pbOnder2.Image = Image.FromFile(path + "4.jpg");
            pbOnder3.Image = Image.FromFile(path + "5.jpg");
            pbOnder4.Image = Image.FromFile(path + "6.jpg");
            nu = DateTime.Now;

        }
        #endregion

        private void btnGa_Click(object sender, EventArgs e)
        {
            try
            {
                PullRandomNumbers();
                ShowDices();
                tbRondes.Text = rondes++.ToString();
                bonus();
                totaalpunten();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region Naam check 
        /// <summary>
        /// Dit maakt de listbox leeg als je de text vervangen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNaam_TextChanged(object sender, EventArgs e)
        {
            if (tbNaam.Text != "" & tbNaam2.Text != "" & playerOneImagePath != "" & playerTwoImagePath != "")
            {
                this.btnGa.Enabled = true;
            }
           
        }
        #endregion

        #endregion

    }
}
