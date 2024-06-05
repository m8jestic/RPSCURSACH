namespace RPSCURSACH
{
    partial class GameSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSession));
            this.label1 = new System.Windows.Forms.Label();
            this.Count_Left = new System.Windows.Forms.Label();
            this.Count_Right = new System.Windows.Forms.Label();
            this.LabelNotImportant = new System.Windows.Forms.Label();
            this.LabelRoundCount = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownLabel = new System.Windows.Forms.Label();
            this.ChoosenSignRight = new System.Windows.Forms.PictureBox();
            this.ChoosenSignLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RockButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(465, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // Count_Left
            // 
            this.Count_Left.AutoSize = true;
            this.Count_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Left.Location = new System.Drawing.Point(433, 68);
            this.Count_Left.Name = "Count_Left";
            this.Count_Left.Size = new System.Drawing.Size(26, 29);
            this.Count_Left.TabIndex = 6;
            this.Count_Left.Text = "0";
            // 
            // Count_Right
            // 
            this.Count_Right.AutoSize = true;
            this.Count_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Right.Location = new System.Drawing.Point(490, 68);
            this.Count_Right.Name = "Count_Right";
            this.Count_Right.Size = new System.Drawing.Size(26, 29);
            this.Count_Right.TabIndex = 7;
            this.Count_Right.Text = "0";
            // 
            // LabelNotImportant
            // 
            this.LabelNotImportant.AutoSize = true;
            this.LabelNotImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNotImportant.Location = new System.Drawing.Point(424, 107);
            this.LabelNotImportant.Name = "LabelNotImportant";
            this.LabelNotImportant.Size = new System.Drawing.Size(82, 29);
            this.LabelNotImportant.TabIndex = 9;
            this.LabelNotImportant.Text = "Раунд";
            // 
            // LabelRoundCount
            // 
            this.LabelRoundCount.AutoSize = true;
            this.LabelRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRoundCount.Location = new System.Drawing.Point(512, 107);
            this.LabelRoundCount.Name = "LabelRoundCount";
            this.LabelRoundCount.Size = new System.Drawing.Size(26, 29);
            this.LabelRoundCount.TabIndex = 10;
            this.LabelRoundCount.Text = "1";
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
            this.countDownLabel.Location = new System.Drawing.Point(455, 29);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(26, 29);
            this.countDownLabel.TabIndex = 11;
            this.countDownLabel.Text = "5";
            // 
            // ChoosenSignRight
            // 
            this.ChoosenSignRight.Location = new System.Drawing.Point(843, 153);
            this.ChoosenSignRight.Name = "ChoosenSignRight";
            this.ChoosenSignRight.Size = new System.Drawing.Size(113, 104);
            this.ChoosenSignRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChoosenSignRight.TabIndex = 4;
            this.ChoosenSignRight.TabStop = false;
            this.ChoosenSignRight.Visible = false;
            // 
            // ChoosenSignLeft
            // 
            this.ChoosenSignLeft.Location = new System.Drawing.Point(30, 153);
            this.ChoosenSignLeft.Name = "ChoosenSignLeft";
            this.ChoosenSignLeft.Size = new System.Drawing.Size(107, 104);
            this.ChoosenSignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChoosenSignLeft.TabIndex = 3;
            this.ChoosenSignLeft.TabStop = false;
            this.ChoosenSignLeft.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RPSCURSACH.Properties.Resources.Scissors;
            this.pictureBox3.Location = new System.Drawing.Point(652, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPSCURSACH.Properties.Resources.Paper;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RockButton
            // 
            this.RockButton.Image = global::RPSCURSACH.Properties.Resources.Rock;
            this.RockButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("RockButton.InitialImage")));
            this.RockButton.Location = new System.Drawing.Point(140, 304);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(161, 140);
            this.RockButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RockButton.TabIndex = 0;
            this.RockButton.TabStop = false;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // GameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPSCURSACH.Properties.Resources.gKnhoBc6vRs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 504);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.LabelRoundCount);
            this.Controls.Add(this.LabelNotImportant);
            this.Controls.Add(this.Count_Right);
            this.Controls.Add(this.Count_Left);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoosenSignRight);
            this.Controls.Add(this.ChoosenSignLeft);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RockButton);
            this.Name = "GameSession";
            this.Text = "Игровая сессия";
            this.Load += new System.EventHandler(this.GameSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenSignLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RockButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ChoosenSignLeft;
        private System.Windows.Forms.PictureBox ChoosenSignRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Count_Left;
        private System.Windows.Forms.Label Count_Right;
        private System.Windows.Forms.Label LabelNotImportant;
        private System.Windows.Forms.Label LabelRoundCount;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label countDownLabel;
    }
}