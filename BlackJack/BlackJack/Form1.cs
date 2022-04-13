using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BlackJack
{
    public partial class BlackJack : Form
    {
        public static string[] CardArray = { };
        
        public static string[] usedCardsArray = { };
        public static int counter;

        public static double userTotal;
        public static double userCard1;
        public static double userCard2;
        public static string userCard1String;
        public static string userCard2String;

        public static string valuesTogether;
        public static string newCardString;


        public static double cpuCard1;
        public static double cpuCard2;
        public static string cpuCard1String;
        public static string cpuCard2String;

        public static double cpuTotal;
        public static double cpuCard;

        public BlackJack()
        {
            InitializeComponent();

        }

        static double userCardOne()
        {

            double userCard1 = hit();

            return userCard1;
        }

        static double userCardTwo()
        {

            Task.Delay(1).Wait();

            double userCard2 = hit();


            return userCard2;
        }
        static double cpuCardOne()
        {

            Task.Delay(2).Wait();
            double cpuCard1 = hit();


            return cpuCard1;
        }

        static double cpuCardTwo()
        {

            Task.Delay(3).Wait();

            double cpuCard2 = hit();


            return cpuCard2;
        }



        static double hit()
        {
            int Randomsuit;
            int Randomvalue;
            double returnValue;
            string STRnumber;
            string STRsuit;
            
            string valuesTogether;

            string[] numberArray = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
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

                valuesTogether = STRnumber + " of " + STRsuit;

                if (usedCardsArray.Length ==52)
                {
                    while (true)
                    {
                        
                    }
                }
                else if (!(usedCardsArray.Contains(valuesTogether)))
                {
                    Array.Resize(ref usedCardsArray, usedCardsArray.Length + 1);
                    usedCardsArray[usedCardsArray.Length-1] = valuesTogether;
                    break;

                }
                else if (usedCardsArray.Contains(valuesTogether))
                {

                }
            }

            if (Randomvalue==0)
            {
                    newCardString = "A";
                    returnValue=11;
            }

            else if (Randomvalue <= 9)
            {
                    newCardString=(Randomvalue+1).ToString();
                    returnValue = Randomvalue + 1;
            }
            else
            {   
                    if (Randomvalue==9)
                    {
                       newCardString="10";
                    }
                    else if(Randomvalue==10)
                    {
                        newCardString="J";
                    }
                    else if (Randomvalue==11)
                    {
                        newCardString="Q";
                    }
                    else if (Randomvalue==12)
                    {
                        newCardString="K";
                    }

                    returnValue = 10;
            }

            return returnValue;
        }

        


        ///////////////////////////////////////////////////////////////////////////////////////////////x    x   ///////////////////////////////////////


        private void Form1_Load(object sender, EventArgs e)
        {

            Array.Resize(ref usedCardsArray,0);
            playAGAIN.Hide();
            btnHIT.Hide();
            btnSTAND.Hide();
            restart.Hide();


        }
        private void btnHIT_Click(object sender, EventArgs e)
        {

            Task.Delay(75).Wait();
            double newCard = hit();

            

            if (userTotal > 21 && newCard == 11)
            {
                newCard = 1;
                userTotal = userTotal + newCard;

            } 
            else if (userTotal >21 && (userCard1 == 11 || userCard2 == 11))
            {
                userTotal = userTotal - 10;
            } else
            {
                userTotal = userTotal + newCard;
            }


            Task.Delay(75).Wait();

            lblUSERSUM.Text = userTotal.ToString();

            label4.Text=label4.Text+ " | "+newCardString;

            if (userTotal > 21)
            {
                btnHIT.Hide();
                winORLOSE.Text = "You lose lol";
                btnHIT.Hide();
                btnSTAND.Hide();
                playAGAIN.Show();
            }

            else if (userTotal==21)
            {
                btnHIT.Hide();
                btnSTAND.Hide();

                cpuTotal=cpuCard1+cpuCard2;
                label3.Text = label3.Text+" | "+cpuCard2.ToString();
                lblSUMCPU.Text=cpuTotal.ToString();

                if (cpuTotal > 21)
                {
                    winORLOSE.Text = "You win!";
                }
                else if (cpuTotal > userTotal)
                {
                    winORLOSE.Text = "You lose!";
                }
                else if (cpuTotal == userTotal)
                {
                    winORLOSE.Text = "It's a push!";
                }
                else if(cpuTotal < userTotal)
                {
                    winORLOSE.Text = "You win!";
                }
                else
                {
                    
                }

                playAGAIN.Show();

            }
            else
            {
                
            }
        }


        private void btnDEAL_Click(object sender, EventArgs e)
        {
            btnDEAL.Hide();
            btnHIT.Show();
            btnSTAND.Show();

            userCard1 = userCardOne();
            userCard1String=newCardString;
            userCard2 = userCardTwo();
            userCard2String=newCardString;

            cpuCard1 = cpuCardOne();
            cpuCard1String=newCardString;
            cpuCard2 = cpuCardTwo();
            cpuCard2String=newCardString;
            cpuTotal=cpuCard1+cpuCard2;

            userTotal = userCard1+userCard2;



            Task.Delay(5).Wait();

            string cpuHit = hit().ToString();

            label3.Text=cpuCard1String;
            label4.Text=userCard1String+" | "+userCard2String;

            lblUSERSUM.Text = userTotal.ToString();
            lblSUMCPU.Text = (cpuTotal-cpuCard2).ToString();

            if (userTotal==21&&cpuTotal==21)
            {
                winORLOSE.Text="Its a push!";

                playAGAIN.Show();
                btnHIT.Hide();
                btnSTAND.Hide();
            }

            if (userTotal==21)
            {
                winORLOSE.Text="Blackjack! You win!";

                playAGAIN.Show();
                btnHIT.Hide();
                btnSTAND.Hide();
            }

            else if (cpuTotal==21)
            {
                btnHIT.Hide();
                btnSTAND.Hide();

                label3.Text = label3.Text+" | "+cpuCard2String;
                lblSUMCPU.Text=cpuTotal.ToString();

                if (cpuTotal > 21)
                {
                    winORLOSE.Text = "You win!";
                }
                else if (cpuTotal > userTotal)
                {
                    winORLOSE.Text = "You lose!";
                }
                else if (cpuTotal == userTotal)
                {
                    winORLOSE.Text = "It's a push!";
                }
                else if (cpuTotal < userTotal)
                {
                    winORLOSE.Text = "You win!";
                }
                else
                {

                }

                playAGAIN.Show();

            }
        }
        private void btnSTAND_Click(object sender, EventArgs e)
        {
            btnHIT.Hide();
            btnSTAND.Hide();

            lblSUMCPU.Text = cpuTotal.ToString();

            label3.Text = label3.Text+ " | " + cpuCard2String;

            Task.Delay(1000).Wait();
                      

            while (true)
            {
                if (cpuTotal < 17)
                {
                    
                    cpuCard = hit();

                    cpuTotal = cpuTotal + cpuCard;
                    // 23

                    if (cpuTotal > 21 && cpuCard == 11)
                    {
                        cpuTotal = cpuTotal - 10;

                    }
                    else if (cpuTotal > 21 && (cpuCard1 == 11 || cpuCard2 == 11))
                    {
                        cpuTotal = cpuTotal - 10;
                    }
                    else
                    {
                        
                    }


                    lblSUMCPU.Text = cpuTotal.ToString();


                    label3.Text = label3.Text + " | " + newCardString.ToString();



                    Task.Delay(1000).Wait();
                }
                else
                {
                    break;
                }
               
            }


            if (cpuTotal > 21)
            {
                winORLOSE.Text = "You win!";
            }
            else if (cpuTotal > userTotal)
            {
                winORLOSE.Text = "You lose!";
            }
            else if (cpuTotal == userTotal)
            {
                winORLOSE.Text = "It's a push!";
            }
            else if(cpuTotal<userTotal)
            {
                winORLOSE.Text = "You win!";
            }
            else
            {

            }

            


            btnHIT.Hide();
            btnSTAND.Hide();
            playAGAIN.Show();


        }
        private void lblSUM_Click(object sender, EventArgs e)
        {

        }

        private void winORLOSE_Click(object sender, EventArgs e)
        {

        }

        private void playAGAIN_Click(object sender, EventArgs e)
        {
            winORLOSE.Text="";
            lblSUMCPU.Text = "";
            lblUSERSUM.Text = "";
            label3.Text = "";
            label4.Text = "";
            cpuTotal = 0;
            cpuCard1 = 0;
            cpuCard2 = 0;
            playAGAIN.Hide();
            btnDEAL.Show();


        }

        private void lblSUMCPU_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void club10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}





// if card 1 == card 2
// show split
// divide user total by 2

// put into for loop

// show hand 1
// play blackjack

// show hand 2
// play blackjack