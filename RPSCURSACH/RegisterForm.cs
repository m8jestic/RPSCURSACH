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
    public partial class RegisterForm : Form
    {
        Database database = new Database();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Reg_Ok_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Length > 0 & textBox_Password.Text.Length > 0 & textBox_Password_Again.Text.Length > 0)
            {
                if (textBox_Password.Text == textBox_Password_Again.Text)
                {
                    if (database.Registration(textBox_Name.Text, textBox_Password.Text) == true)
                    {
                        this.Hide();
                        DialogResult dialogResult = new AuthForm().ShowDialog();
                        this.Close();
                    }
                        
                }
            }

        }

    }
}