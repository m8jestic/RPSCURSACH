using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSCURSACH
{
    public partial class AuthForm : Form
    {
        Database database = new Database();
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button_Ok_Auth_Click(object sender, EventArgs e)
        {

            if (database.Authorisation(textBox_Login.Text, textBox_Password.Text) == true)
            {
                this.Hide();
                DialogResult dialogResult = new Form1().ShowDialog();
                this.Close();
            }

        }

        private void Auth_Registration_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dialogResult = new RegisterForm().ShowDialog();
            this.Show();
        }
    }
}
