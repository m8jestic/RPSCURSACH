using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSCURSACH
{
    public partial class GameSession : Form
    {
        private int countRound = 1;
        private int timerRound = 5;
        public string playerChoice = "";
        public string compChoice = "";
        public int scoreLeft = 0;
        public int scoreRight = 0;
        public GameSession()
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            
        }

       
        private void GameSession_Load(object sender, EventArgs e)
        {

        }


        public void getRandomNumber()
        {
            Random random = new Random();   
            var randomNumber= random.Next(1,4);
            
            if(randomNumber == 1)
            {
                compChoice = "Rock";
                ChoosenSignRight.Image = Properties.Resources.Rock;
            }
            else if( randomNumber == 2) 
            {
                compChoice = "Paper";
                ChoosenSignRight.Image = Properties.Resources.Paper;
            }
            else if (randomNumber == 3) 
            {
                compChoice = "Scissors";
                ChoosenSignRight.Image = Properties.Resources.Scissors;
            }
        }


        private void RockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            ChoosenSignLeft.Image = Properties.Resources.Rock;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            ChoosenSignLeft.Image = Properties.Resources.Paper;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            ChoosenSignLeft.Image = Properties.Resources.Scissors;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {

            timerRound -= 1;
            countDownLabel.Text = timerRound.ToString();
            ChoosenSignRight.Image = null;
            if (timerRound < 1)
            {
                getRandomNumber();
                countDownTimer.Enabled = false;
                if (compChoice == "")
                {
                    scoreLeft += 1;
                }
                else if (playerChoice == "")
                {
                    scoreRight += 1;
                }
                else
                {
                    if (compChoice == "Rock" & playerChoice =="Scissors" | compChoice =="Paper" & playerChoice == "Rock" | compChoice == "Scissors" & playerChoice == "Paper")
                    {
                        scoreRight += 1;
                       
                    }
                    else if(playerChoice == "Rock" & compChoice == "Scissors" | playerChoice == "Paper" & compChoice == "Rock" | playerChoice == "Scissors" & compChoice == "Paper")
                    {
                        scoreLeft += 1;
                    }
                }
                countRound += 1;
                LabelRoundCount.Text = countRound.ToString();
                Count_Left.Text = scoreLeft.ToString();
                Count_Right.Text = scoreRight.ToString();
                CheckGame();
                countDownTimer.Enabled = false;
                ChoosenSignLeft.Image = null;
                RockButton.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                countDownTimer.Enabled = true;
                timerRound = 5;
            }
        }
        public void CheckGame()
        {
            if(scoreLeft == 3 | scoreRight == 3) 
            {
                if (scoreLeft > scoreRight)
                {
                    MessageBox.Show($"Игра окончена, вы победили со счетом {scoreLeft}:{scoreRight}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Игра окончена, вы проиграли со счетом {scoreLeft}:{scoreRight}");
                    this.Close();
                }

            }
        }
    }
}
