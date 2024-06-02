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
    public partial class StatisticsForm : Form
    {
        Database database = new Database();
        public StatisticsForm()
        {
            InitializeComponent();
            FillTheStatistics();
            FillTheHistory();   
        }

        public void FillTheStatistics()
        {
           var stat = database.GetStatisticsData();
            labelWins.Text = stat[0].ToString();
            labelLoses.Text = stat[1].ToString();
            if (stat[0] != 0)
            {
                double percent = (double)stat[0] / (stat[0] + stat[1]);
                percent = Math.Round(percent, 3);   
                labelWinPercent.Text = $"{percent*100}%";
            }
            else
            {
                labelWinPercent.Text = "0%";
            }
        }
        public void FillTheHistory()
        {
            var d = database.GetHistory();
            dataGridView1.DataSource = d;

        }
    }
}
