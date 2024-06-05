using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Timers;


namespace RPSCURSACH
{
    public partial class MultiplayerGameSession : Form
    {
        private int countRound = 1;
        private int timerRound = 7;
        public string playerChoice = "";
        public string enemyChoice = "";
        public Image enemySign;
        public int scoreLeft = 0;
        public int scoreRight = 0;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client = null;
        Database db = new Database();


        public MultiplayerGameSession(bool isHost, string ip = null)
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            if (isHost) 
            {
                System.Timers.Timer t = new System.Timers.Timer(20000);
                t.AutoReset = false;
                t.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                t.Start();
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                try
                { 
                    sock = server.AcceptSocket();
                    t.Stop();
                }
                catch (SocketException ex) when (ex.ErrorCode == 10004)
                {
                    this.Close();
                    t.Stop();
                    return;
                }
            }
            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            sock = null;
            server.Stop();
            MessageBox.Show("Превышено время ожидания соперника");
            this.Close();
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckGame())
            {
                return;
            }
            ReceiveMove();
        }
        private bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }


        private void FreezeSigns()
        {
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }
        private void UnfreezeSigns()
        {
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
        private void buttonRock_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            ChoosenSignLeft.Image = Properties.Resources.Rock;
            byte[] num = { 1 };
            sock.Send(num);
            FreezeSigns();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            ChoosenSignLeft.Image = Properties.Resources.Paper;
            byte[] num = { 2 };
            sock.Send(num);
           // MessageReceiver.RunWorkerAsync();
            FreezeSigns();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            ChoosenSignLeft.Image = Properties.Resources.Scissors;
            byte[] num = { 3 };
            sock.Send(num);
           // MessageReceiver.RunWorkerAsync();
            FreezeSigns();
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerRound -= 1;
            countDownLabel.Text = timerRound.ToString();
            if (timerRound == 6)
            {
                ChoosenSignRight.Image = null;
                ChoosenSignLeft.Image = null;
            }
            if (timerRound == 1)
            {
                MessageReceiver.RunWorkerAsync();
                try
                {
                    if (!SocketConnected(sock))
                    {
                        countDownTimer.Enabled = false;
                        MessageBox.Show("Соединение разорвано");
                        sock.Close();
                        server.Stop();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            if (timerRound < 1)
            {
               
                ChoosenSignRight.Image = enemySign;
                countDownTimer.Enabled = false;
                if(playerChoice == enemyChoice)
                {

                }
               else if (enemyChoice == "")
                {
                    scoreLeft += 1;
                }
                else if (playerChoice == "")
                {
                    scoreRight += 1;
                }
                else
                {
                    if (enemyChoice == "Rock" & playerChoice == "Scissors" | enemyChoice == "Paper" & playerChoice == "Rock" | enemyChoice == "Scissors" & playerChoice == "Paper")
                    {
                        scoreRight += 1;

                    }
                    else if (playerChoice == "Rock" & enemyChoice == "Scissors" | playerChoice == "Paper" & enemyChoice == "Rock" | playerChoice == "Scissors" & enemyChoice == "Paper")
                    {
                        scoreLeft += 1;
                    }
                }
                playerChoice = "";
                enemyChoice = "";
                countRound += 1;
                LabelRoundCount.Text = countRound.ToString();
                Count_Left.Text = scoreLeft.ToString();
                Count_Right.Text = scoreRight.ToString();
                if (!CheckGame())
                {
                    countDownTimer.Enabled = false;
                    UnfreezeSigns();
                    countDownTimer.Enabled = true;
                    timerRound = 7;
                }
            }
        }
        public bool CheckGame()
        {
            if (scoreLeft == 3 | scoreRight == 3)
            {
                if (scoreLeft > scoreRight)
                {
                    db.InsertInTheHistory(scoreLeft, scoreRight, countRound, "Победа");
                    db.UpdateTheStatisticsWin();
                    MessageBox.Show($"Игра окончена, вы победили со счетом {scoreLeft}:{scoreRight}");
                    sock.Close();
                    this.Close();
                }
                else
                {
                    db.InsertInTheHistory(scoreLeft, scoreRight, countRound, "Поражение");
                    db.UpdateTheStatisticsLose();
                    MessageBox.Show($"Игра окончена, вы проиграли со счетом {scoreLeft}:{scoreRight}");
                    sock.Close ();
                    this.Close();
                }
                return true;
            }
            return false;
        }
        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
            {
                enemyChoice = "Rock";
                enemySign = Properties.Resources.Rock;
                
            }
            else if (buffer[0] == 2) 
            {
                enemyChoice = "Paper";
                enemySign =Properties.Resources.Paper;
            }     
            else if (buffer[0] == 3)
            {
                enemyChoice = "Scissors";
                enemySign = Properties.Resources.Scissors;
            }
            else if (buffer[0] == 4)
            {
                enemyChoice = "";
                enemySign = ChoosenSignRight.Image;
            }

        }

        private void MultiplayerGameSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            countDownTimer.Enabled = false;
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            sock.Close();


        }

    }
}
