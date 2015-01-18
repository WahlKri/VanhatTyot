using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
{
    public partial class Form1 : Form
    {
        List<Image> Kuvat = new List<Image>();
        int maxRound = 5;
        int rounds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kuvat.Add(Assigment1.Properties.Resources.Dice_1);
            Kuvat.Add(Assigment1.Properties.Resources.Dice_2);
            Kuvat.Add(Assigment1.Properties.Resources.Dice_3);
            Kuvat.Add(Assigment1.Properties.Resources.Dice_4);
            Kuvat.Add(Assigment1.Properties.Resources.Dice_5);
            Kuvat.Add(Assigment1.Properties.Resources.Dice_6);
        }

        private void btnThrowDice_Click(object sender, EventArgs e)
        {
            pBoxDice1.BackgroundImage = Kuvat[throwDice() - 1];
            rounds++;
            lblRounds.Text = "Round: " + rounds.ToString();
            myTimer.Start();
            lblName.Text = "Machine";
            i = 0;
        }

        public int throwDice() { 
            Random random = new Random();
            return random.Next(1,6+1);
        }

        int i = 0;

        private void myTimer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 2) {
                pBoxDice2.BackgroundImage = Kuvat[throwDice() - 1];
                myTimer.Stop();
                lblName.Text = "Player";
            }
        }

       
    }
}
