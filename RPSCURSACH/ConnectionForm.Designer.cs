namespace RPSCURSACH
{
    partial class ConnectionForm
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
            this.OKIP_Button = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKIP_Button
            // 
            this.OKIP_Button.Location = new System.Drawing.Point(251, 109);
            this.OKIP_Button.Name = "OKIP_Button";
            this.OKIP_Button.Size = new System.Drawing.Size(75, 23);
            this.OKIP_Button.TabIndex = 0;
            this.OKIP_Button.Text = "OK";
            this.OKIP_Button.UseVisualStyleBackColor = true;
            this.OKIP_Button.Click += new System.EventHandler(this.OKIP_Button_Click);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(204, 69);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(174, 20);
            this.IPTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите IP адрес оппонента";
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(499, 12);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(75, 23);
            this.HostButton.TabIndex = 3;
            this.HostButton.Text = "Хост";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 168);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.OKIP_Button);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKIP_Button;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HostButton;
    }
}