namespace RPSCURSACH
{
    partial class MultiplayerGameSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRock = new System.Windows.Forms.PictureBox();
            this.buttonPaper = new System.Windows.Forms.PictureBox();
            this.buttonScissors = new System.Windows.Forms.PictureBox();
            this.ChoosenSignLeft = new System.Windows.Forms.PictureBox();
            this.ChoosenSignRight = new System.Windows.Forms.PictureBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownLabel = new System.Windows.Forms.Label();
            this.Count_Left = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelRoundCount = new System.Windows.Forms.Label();
            this.Count_Right = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignRight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.BackgroundImage = global::RPSCURSACH.Properties.Resources.Rock;
            this.buttonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRock.Location = new System.Drawing.Point(213, 327);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(114, 110);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.TabStop = false;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackgroundImage = global::RPSCURSACH.Properties.Resources.Paper;
            this.buttonPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaper.Location = new System.Drawing.Point(391, 327);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(118, 110);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.TabStop = false;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackgroundImage = global::RPSCURSACH.Properties.Resources.Scissors;
            this.buttonScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScissors.Location = new System.Drawing.Point(576, 327);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(121, 110);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.TabStop = false;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // ChoosenSignLeft
            // 
            this.ChoosenSignLeft.Location = new System.Drawing.Point(60, 139);
            this.ChoosenSignLeft.Name = "ChoosenSignLeft";
            this.ChoosenSignLeft.Size = new System.Drawing.Size(105, 95);
            this.ChoosenSignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChoosenSignLeft.TabIndex = 3;
            this.ChoosenSignLeft.TabStop = false;
            // 
            // ChoosenSignRight
            // 
            this.ChoosenSignRight.Location = new System.Drawing.Point(737, 139);
            this.ChoosenSignRight.Name = "ChoosenSignRight";
            this.ChoosenSignRight.Size = new System.Drawing.Size(103, 95);
            this.ChoosenSignRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChoosenSignRight.TabIndex = 4;
            this.ChoosenSignRight.TabStop = false;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // countDownLabel
            // 
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDownLabel.Location = new System.Drawing.Point(426, 38);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(26, 29);
            this.countDownLabel.TabIndex = 5;
            this.countDownLabel.Text = "5";
            // 
            // Count_Left
            // 
            this.Count_Left.AutoSize = true;
            this.Count_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Left.Location = new System.Drawing.Point(401, 85);
            this.Count_Left.Name = "Count_Left";
            this.Count_Left.Size = new System.Drawing.Size(26, 29);
            this.Count_Left.TabIndex = 6;
            this.Count_Left.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(386, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Раунд";
            // 
            // LabelRoundCount
            // 
            this.LabelRoundCount.AutoSize = true;
            this.LabelRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRoundCount.Location = new System.Drawing.Point(474, 131);
            this.LabelRoundCount.Name = "LabelRoundCount";
            this.LabelRoundCount.Size = new System.Drawing.Size(26, 29);
            this.LabelRoundCount.TabIndex = 10;
            this.LabelRoundCount.Text = "1";
            // 
            // Count_Right
            // 
            this.Count_Right.AutoSize = true;
            this.Count_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Right.Location = new System.Drawing.Point(458, 85);
            this.Count_Right.Name = "Count_Right";
            this.Count_Right.Size = new System.Drawing.Size(26, 29);
            this.Count_Right.TabIndex = 12;
            this.Count_Right.Text = "0";
            // 
            // MultiplayerGameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPSCURSACH.Properties.Resources._7be96c37c10b95e3233187850f1f11d9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 492);
            this.Controls.Add(this.Count_Right);
            this.Controls.Add(this.LabelRoundCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Count_Left);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.ChoosenSignRight);
            this.Controls.Add(this.ChoosenSignLeft);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Name = "MultiplayerGameSession";
            this.Text = "Игра по сети";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiplayerGameSession_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonRock;
        private System.Windows.Forms.PictureBox buttonPaper;
        private System.Windows.Forms.PictureBox buttonScissors;
        private System.Windows.Forms.PictureBox ChoosenSignLeft;
        private System.Windows.Forms.PictureBox ChoosenSignRight;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Label Count_Left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelRoundCount;
        private System.Windows.Forms.Label Count_Right;
    }
}