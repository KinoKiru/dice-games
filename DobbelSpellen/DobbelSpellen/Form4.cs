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

        //Array met 4 indexnummers
        private int[] spelerEenPunten = new int[4];
        private int[] spelerTweePunten = new int[4];

        //Randomizer
        private Random objRandom = new Random();

        //deze houdt de rondes bij
        private int rondes = 1;

        //dit is de bonus voor speler 1
        private int bonus1 = 0;
        //dit is de bonus voor speler 2
        private int bonus2 = 0;

        // dit berekend de totaal waarde uit met de bonus
        private int totaalPuntenVierRondesSpeler1 = 0;
        private int totaalPuntenVierrondesSpeler2 = 0;

        // als er toch iets fout gaat is dit de path voor de error
        private string errorImagePath = "";

        //dit is is de path voor de eerste player
        private string playerOneImagePath = "";

        //dit is de path voor de tweede player
        private string playerTwoImagePath = "";

        private int x = 0;

        // dit pakt de tijd als je hem opstart
        private DateTime nu;

        //als je de 4 rondes heb gehad pakt hij de tijd
        private DateTime recent;

        // deze bools gaan pas op true als alle info is ingevuld
        private bool spelerEenCheck = false;
        private bool spelerTweeCheck = false;

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
            for (int i = 0; i < 4; i++)
            {
                spelerEenPunten[i] = objRandom.Next(1, 7); //Trekt getallen van 1 tot en met 6
                spelerTweePunten[i] = objRandom.Next(1, 7); // 
            }
        }

        /// <summary>
        /// als speler 1 wint dan kont zijn fot tevoren via deze methode
        /// </summary>
        public void VerkrijgFotoSpelereen()
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
        public void VerkrijgFotoSpelerTwee()
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
                // hier voeg ik de keuzes toe
                cbOnderBonus.Items.Add(i + 1);
                cmbBonus.Items.Add(i + 1);
            }

        }

        /// <summary>
        /// hier laat ik de dices zien die getrokken zijn
        /// </summary>
        private void ShowDices()
        {
            // hier pak ik de path naar de foto map, en dan pak ik de value van de array punt en dan gooi ik die in de text box
            pb1.Image = Image.FromFile(path + spelerEenPunten[0] + ".jpg");
            pb2.Image = Image.FromFile(path + spelerEenPunten[1] + ".jpg");
            pb3.Image = Image.FromFile(path + spelerEenPunten[2] + ".jpg");
            pb4.Image = Image.FromFile(path + spelerEenPunten[3] + ".jpg");
            pbOnder1.Image = Image.FromFile(path + spelerTweePunten[0] + ".jpg");
            pbOnder2.Image = Image.FromFile(path + spelerTweePunten[1] + ".jpg");
            pbOnder3.Image = Image.FromFile(path + spelerTweePunten[2] + ".jpg");
            pbOnder4.Image = Image.FromFile(path + spelerTweePunten[3] + ".jpg");
        }

        /// <summary>
        /// hier bereken ik de bonus door na te gaan of de getallen overeen komen
        /// </summary>
        private void BerekenBonus()
        {
            int bonussp2 = cbOnderBonus.SelectedIndex + 1;
            int bonussp1 = cmbBonus.SelectedIndex + 1;


            for (int i = 0; i < spelerEenPunten.Length; i++)
            {
                // hier vergelijk ik je keuze voor je bonus met je dobbel
                if (bonussp1 == spelerEenPunten[i]) { bonus1++; } else if (bonussp2 == spelerTweePunten[i]) { bonus2++; }
            };
        }

        /// <summary>
        /// dit telt alle punten op(bonus + wat je gedobbelt hebt) en laat vervolgens de winnaar zien
        /// </summary>
        private void BerekenTotaalPunten()
        {
            int som1 = 0;
            int som2 = 0;

            for (int i = 0; i < spelerEenPunten.Length; i++)
            {
                som1 += spelerEenPunten[i];
                som2 += spelerTweePunten[i];
            };

            // dit is voor 1 ronde wat je bij elkaar optelt
            int totaal1 = som1 + bonus1;
            int totaal2 = som2 + bonus2;
            // hier doe ik het += zodat je de 4 rondes bij elkaar optelt
            totaalPuntenVierRondesSpeler1 += totaal1;
            totaalPuntenVierrondesSpeler2 += totaal2;

            tbPunten.Text = totaal1.ToString();
            tbOnderPunten.Text = totaal2.ToString();
            // hier voeg ik de punten toe van 1 ronde 
            lbpuntentelling.Items.Add("Bonus: " + bonus1 + " " + (totaal1 - bonus1) + " " + totaal1);
            lbOnderpuntentelling.Items.Add("Bonus: " + bonus2 + " " + (totaal2 - bonus2) + " " + totaal2);

            if (x == 3)
            {
                try
                {
                    TimeSpan totaaltime = recent - nu;
                    // als de punten hoger zijn van speler 1 dan laat hij de totaal score zien van de 4 rondes en de punten verschil daarvan 
                    if (totaalPuntenVierRondesSpeler1 > totaalPuntenVierrondesSpeler2)
                    {
                        recent = DateTime.Now;
                        lbWinnaar.Items.Clear();
                        pbWinaar.Image = Image.FromFile(playerOneImagePath);
                        lbWinnaar.Items.Add("winnaar: " + tbNaam.Text + "\r\n");
                        lbWinnaar.Items.Add("Geboortedatum: " + dateTimePicker1.Value + "\r\n");
                        lbWinnaar.Items.Add("Gewonnen met " + (totaalPuntenVierRondesSpeler1 - totaalPuntenVierrondesSpeler2) + " punten verschil" + "\r\n");
                        lbWinnaar.Items.Add("Speeltijd: " + totaaltime + "\r\n");
                        lbOnderpuntentelling.Items.Add("Totaal punten: " + totaalPuntenVierrondesSpeler2);
                        lbpuntentelling.Items.Add("Totaal punten: " + totaalPuntenVierRondesSpeler1);

                    }
                    else if (totaalPuntenVierrondesSpeler2 > totaalPuntenVierRondesSpeler1)
                    {
                        lbWinnaar.Items.Clear();
                        pbWinaar.Image = Image.FromFile(playerTwoImagePath);
                        lbWinnaar.Items.Add("winnaar: " + tbNaam2.Text + "\r\n");
                        lbWinnaar.Items.Add("Geboortedatum: " + dateTimePicker2.Value + "\r\n");
                        lbWinnaar.Items.Add("Gewonnen met " + (totaalPuntenVierrondesSpeler2 - totaalPuntenVierRondesSpeler1) + " punten verschil" + "\r\n");
                        lbWinnaar.Items.Add("Speeltijd: " + totaaltime + "\r\n");
                        lbOnderpuntentelling.Items.Add("Totaal punten: " + totaalPuntenVierrondesSpeler2);
                        lbpuntentelling.Items.Add("Totaal punten: " + totaalPuntenVierRondesSpeler1);
                    };
                }
                finally //  hier zet ik alles op 0 zodat je weer opnieuw kan beginnen
                {
                    totaal1 = 0;
                    totaal2 = 0;
                   
                    x = 0;
                    totaalPuntenVierRondesSpeler1 = 0;
                    totaalPuntenVierrondesSpeler2 = 0;
                }
            }
            else
            {// als je nog geen 5 rondjes hebt gedaan gaat de counter met 1 omhoog
                x++;
                bonus1 = 0;
                bonus2 = 0;
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
            VerkrijgFotoSpelereen();
        }
        private void btnSelecteer2_Click(object sender, EventArgs e)
        {
            VerkrijgFotoSpelerTwee();
        }
        #endregion
        #region data opslaan
        private void btnOpslaan2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNaam2.Text != "" & playerTwoImagePath != "")
                {
                    spelerTweeCheck = true;
                }

                lbOnderpuntentelling.Items.Clear();
               



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void tbOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNaam.Text != "" & playerOneImagePath != "") { spelerEenCheck = true; }


                lbpuntentelling.Items.Clear();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion
        #region Vul picturebox
        private void Form4_Load(object sender, EventArgs e)
        { // dit vult de pictureboxen met de mogelijkheden van de dobbelstenen
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
                BerekenBonus();
                BerekenTotaalPunten();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // als alles is ingevuld dan kan je pas verder hier pas hij ook toe wat je hebt opgeslagen 
            if (spelerEenCheck == true & spelerTweeCheck == true)
            {
                gbSpeler2.Text = tbNaam2.Text;
                gbPlayer1.Text = tbNaam.Text;
                lbpuntentelling.Items.Add("Spel overzicht van: " + tbNaam.Text);
                lbpuntentelling.Items.Add("Bonus:   Ogen:   Totaal:");
                lbOnderpuntentelling.Items.Add("Spel overzicht van: " + tbNaam2.Text);
                lbOnderpuntentelling.Items.Add("Bonus:   Ogen:   Totaal:");
                btnGa.Enabled = true;
            }
            // als bijde spelers info missen krijg je eenb foutmelding
            else if (spelerTweeCheck == false & spelerEenCheck == false) { MessageBox.Show("Gelieve vul alle info in voor Allebei de spelers"); }
            // als speler 1 info mist dan krijg je een melding
            else if (spelerEenCheck == false)
            {
                MessageBox.Show("Gelieve vul alle info in voor speler een");
            }// als speler 2 info mist krijg je een melding
            else if (spelerTweeCheck == false)
            {
                MessageBox.Show("Gelieve vul alle info in voor speler twee");
            } 
        }
        #endregion
    }
}
