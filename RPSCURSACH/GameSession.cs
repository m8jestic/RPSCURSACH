﻿using System;
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
        
        Database db = new Database();
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
                ChoosenSignRight.Visible = true;
            }
            else if( randomNumber == 2) 
            {
                compChoice = "Paper";
                ChoosenSignRight.Image = Properties.Resources.Paper;
                ChoosenSignRight.Visible = true;
            }
            else if (randomNumber == 3) 
            {
                compChoice = "Scissors";
                ChoosenSignRight.Image = Properties.Resources.Scissors;
                ChoosenSignRight.Visible = true;
            }
        }


        private void RockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            ChoosenSignLeft.Image = Properties.Resources.Rock;
            ChoosenSignLeft.Visible = true;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            ChoosenSignLeft.Image = Properties.Resources.Paper;
            ChoosenSignLeft.Visible = true;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            ChoosenSignLeft.Image = Properties.Resources.Scissors;
            ChoosenSignLeft.Visible = true;
            RockButton.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerRound -= 1;
            countDownLabel.Text = timerRound.ToString();
            if(timerRound == 5)
            {
                ChoosenSignRight.Image = null;
                ChoosenSignLeft.Image = null;
                ChoosenSignLeft.Visible = false;
                ChoosenSignRight.Visible = false;
                RockButton.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
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
                playerChoice = "";
                compChoice = "";
                countRound += 1;
                LabelRoundCount.Text = countRound.ToString();
                Count_Left.Text = scoreLeft.ToString();
                Count_Right.Text = scoreRight.ToString();
                countDownTimer.Enabled = false;
                if (!CheckGame()) 
                {
                    countDownTimer.Enabled = true;
                    timerRound = 6;
                }
            }
        }
        public bool CheckGame()
        {
            if(scoreLeft == 3 | scoreRight == 3) 
            {
                if (scoreLeft > scoreRight)
                {
                    db.InsertInTheHistory(scoreLeft, scoreRight, countRound, "Победа");
                    db.UpdateTheStatisticsWin();
                    MessageBox.Show($"Игра окончена, вы победили со счетом {scoreLeft}:{scoreRight}");
                    this.Close();
                }
                else
                {
                    db.InsertInTheHistory(scoreLeft,scoreRight, countRound, "Поражение");
                    db.UpdateTheStatisticsLose();
                    MessageBox.Show($"Игра окончена, вы проиграли со счетом {scoreLeft}:{scoreRight}");
                    this.Close();
                }
                return true;
            }
            return false;
        }
    }
}
