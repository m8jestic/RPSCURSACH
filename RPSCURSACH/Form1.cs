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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dialogResult = new GameSession().ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            DialogResult dialogResult = new ConnectionForm().ShowDialog();

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создал студент группы 741-1 Ёрхов Матвей Вадимович\nФБ\nИспользование без согласия правообладателя преследуется по закону. Все права защищены.", "ТУСУР ЧЕМПИОН");
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dialogResult = new StatisticsForm().ShowDialog();
            this.Show();
        }
    }
}
