using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJack : Form
    {

        public static string[] usedCardsArray = { };
        public static int counter;

        public static double userTotal = 0;
        public static double cpuTotal = 0;

        public static string[] cpuCard = { };

        public static string cpuCard1;
        public static double cpuCard2 = 0;


        public BlackJack()
        {
            InitializeComponent();
        }

        static double start()
        {
            double userTotal = 0;

            for (int i = 0; i < 2; i++)
            {
                double userCard = userCardStartofGame();

                userTotal = userTotal + userCard;
            }

            return userTotal;

        }



        static double hit()
        {
            int Randomsuit;
            int Randomvalue;
            double returnValue;
            string STRnumber;
            string STRsuit;

            string valuesTogether;

            string[] numberArray = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suitArray = { "hearts", "diamonds", "spades", "clubs" };

            Random r = new Random();

            while (true)
            {
                // SUIT PICKER
                Randomsuit = r.Next(0, 4);

                STRsuit = suitArray[Randomsuit];

                // NUMBER PICKER
                Randomvalue = r.Next(0, 13);

                STRnumber = numberArray[Randomvalue];

                if (Randomvalue <= 9)
                {
                    returnValue = Randomvalue + 1;
                }
                else
                {
                    returnValue = 10;
                }


                // TOGETHER

                valuesTogether = STRnumber + " of " + STRsuit;

                if (usedCardsArray.Length == 52)
                {
                    break;
                }
                else if (usedCardsArray.Contains(valuesTogether))
                {

                }
                else
                {
                    Array.Resize(ref usedCardsArray, usedCardsArray.Length + 1);
                    usedCardsArray[usedCardsArray.Length - 1] = valuesTogether;

                    return returnValue;
                }
                return returnValue;
            }
            return returnValue;
        }

        static double stand()
        {
            while (true)
            {

                if (cpuTotal < 21 && cpuTotal >= 17)
                {
                    return cpuTotal;
                }
                else if (cpuTotal < 16)
                {

                }

                while (true)
                {
                    double cpuCard = hit();
                    cpuTotal = cpuTotal + cpuCard;

                    if (cpuTotal == 21)
                    {

                        break;
                    }
                    else if (cpuTotal > 21)
                    {

                        break;
                    }
                    else if (cpuTotal < 21 && cpuTotal > 16)
                    {
                        return cpuTotal;
                      
                    }
                    return cpuTotal;
                } return cpuTotal;

                return cpuTotal;
            }
            return cpuTotal;
        }

        static double cpuDeal()
        {
            int Randomsuit;
            int Randomvalue;
            double returnValue;
            string STRnumber;
            string STRsuit;

            string valuesTogether;

            string[] numberArray = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suitArray = { "hearts", "diamonds", "spades", "clubs" };

            Random r = new Random();

            while (true)
            {
                // SUIT PICKER
                Randomsuit = r.Next(0, 4);

                STRsuit = suitArray[Randomsuit];

                // NUMBER PICKER
                Randomvalue = r.Next(0, 13);

                STRnumber = numberArray[Randomvalue];


                if (Randomvalue == 1)
                {
                    if (cpuTotal < 11)
                    {
                        return 10;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else if (Randomvalue <= 9)
                {
                    returnValue = Randomvalue + 1;
                }
                else
                {
                    returnValue = 10;
                }


                // TOGETHER

                valuesTogether = STRnumber + " of " + STRsuit;

                if (usedCardsArray.Length == 52)
                {
                    break;
                }
                else if (usedCardsArray.Contains(valuesTogether))
                {

                }
                else
                {
                    Array.Resize(ref usedCardsArray, usedCardsArray.Length + 1);
                    usedCardsArray[usedCardsArray.Length - 1] = valuesTogether;

                    cpuCard1 = STRnumber;

                    return returnValue;
                }
                cpuCard1 = STRnumber;
                return returnValue;
            }
            cpuCard1 = STRnumber;
            return returnValue;
        }

        static void cpuStand(double cpuTotal)
        {
            {
                if (cpuTotal > userTotal)
                {
                    Console.WriteLine("Dealer wins, you suck");
                    Console.WriteLine();
                }
                else if (userTotal > cpuTotal)
                {
                    Console.WriteLine("You win");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Its a tie");
                    Console.WriteLine();
                }
            }
        }

        static double userCardStartofGame()
        {

            int Randomsuit;
            int Randomvalue;
            double returnValue;
            string STRnumber;
            string STRsuit;

            string valuesTogether;

            string[] numberArray = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suitArray = { "hearts", "diamonds", "spades", "clubs" };

            Random r = new Random();

            while (true)
            {
                // SUIT PICKER
                Randomsuit = r.Next(0, 4);

                STRsuit = suitArray[Randomsuit];

                // NUMBER PICKER
                Randomvalue = r.Next(0, 13);

                STRnumber = numberArray[Randomvalue];

                if (Randomvalue <= 9)
                {
                    returnValue = Randomvalue + 1;
                }
                else
                {
                    returnValue = 10;
                }


                // TOGETHER

                valuesTogether = STRnumber + " of " + STRsuit;

                if (usedCardsArray.Length == 52)
                {
                    break;
                }
                else if (usedCardsArray.Contains(valuesTogether))
                {

                }
                else
                {
                    Array.Resize(ref usedCardsArray, usedCardsArray.Length + 1);
                    usedCardsArray[usedCardsArray.Length - 1] = valuesTogether;

                    return returnValue;
                }
                return returnValue;
            }
            return returnValue;
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  

        private void Form1_Load(object sender, EventArgs e)
        {
            playAGAIN.Hide();
            btnHIT.Hide();
            btnSTAND.Hide();
        }

        private void btnHIT_Click(object sender, EventArgs e)
        {
            double newCard = hit();

            userTotal = userTotal + newCard;

            lblUSERSUM.Text = userTotal.ToString();

            if (userTotal > 21)
            {
                btnHIT.Hide();
                winORLOSE.Text = "You lose lol";
                btnHIT.Hide();
                btnSTAND.Hide();
                playAGAIN.Show();
            }

        }

        private void btnDEAL_Click(object sender, EventArgs e)
        {
            btnDEAL.Hide();
            btnHIT.Show();
            btnSTAND.Show();
            userTotal = start();

            cpuTotal = cpuDeal();

            lblUSERSUM.Text = userTotal.ToString();

            label3.Text = cpuCard1;

            lblSUMCPU.Text = cpuTotal.ToString();

        }

        private void lblSUM_Click(object sender, EventArgs e)
        {

        }

        private void winORLOSE_Click(object sender, EventArgs e)
        {

        }

        private void playAGAIN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lblSUMCPU_Click(object sender, EventArgs e)
        {

        }

        private void btnSTAND_Click(object sender, EventArgs e)
        {
            while (cpuTotal<17)
            {
                cpuTotal = stand();

                lblSUMCPU.Text = cpuTotal.ToString();

                Task.Delay(1000).Wait();
            }
            

            if (cpuTotal > 21)
            {
                winORLOSE.Text = "You win lol";
            } 
            else if (cpuTotal > userTotal)
            {
                winORLOSE.Text = "You lose lol";
            }
            else if (cpuTotal == userTotal)
            {
                winORLOSE.Text = "It's a push";
            }
            else
            {
                winORLOSE.Text = "You win lol";
            }

            btnHIT.Hide();
            btnSTAND.Hide();    
            playAGAIN.Show();


        }

        private void dealerHand_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}




/* if(cpuTotal<11)
 {
      cpuTotal = cpuTotal + 11;
  }
  else
  {
       cpuTotal = cpuTotal +1; 
  }
*/