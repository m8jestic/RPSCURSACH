namespace RPSCURSACH
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SingleplayerButton = new System.Windows.Forms.Button();
            this.LANButton = new System.Windows.Forms.Button();
            this.Statistics_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SingleplayerButton
            // 
            this.SingleplayerButton.Location = new System.Drawing.Point(302, 120);
            this.SingleplayerButton.Name = "SingleplayerButton";
            this.SingleplayerButton.Size = new System.Drawing.Size(200, 45);
            this.SingleplayerButton.TabIndex = 0;
            this.SingleplayerButton.Text = "Играть в одиночку";
            this.SingleplayerButton.UseVisualStyleBackColor = true;
            this.SingleplayerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LANButton
            // 
            this.LANButton.Location = new System.Drawing.Point(302, 201);
            this.LANButton.Name = "LANButton";
            this.LANButton.Size = new System.Drawing.Size(200, 46);
            this.LANButton.TabIndex = 1;
            this.LANButton.Text = "Играть с оппонентом (LAN)";
            this.LANButton.UseVisualStyleBackColor = true;
            this.LANButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Statistics_Button
            // 
            this.Statistics_Button.Location = new System.Drawing.Point(302, 279);
            this.Statistics_Button.Name = "Statistics_Button";
            this.Statistics_Button.Size = new System.Drawing.Size(200, 46);
            this.Statistics_Button.TabIndex = 2;
            this.Statistics_Button.Text = "Статистика";
            this.Statistics_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Statistics_Button);
            this.Controls.Add(this.LANButton);
            this.Controls.Add(this.SingleplayerButton);
            this.Name = "Form1";
            this.Text = "Камень, ножницы, бумага";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingleplayerButton;
        private System.Windows.Forms.Button LANButton;
        private System.Windows.Forms.Button Statistics_Button;
    }
}

