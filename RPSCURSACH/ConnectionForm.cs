using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSCURSACH
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void OKIP_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiplayerGameSession mgs = new MultiplayerGameSession(false, IPTextBox.Text);
            if (!mgs.IsDisposed) 
            {
                mgs.ShowDialog();
            }
            this.Close();
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiplayerGameSession mgs = new MultiplayerGameSession(true);
                if (!mgs.IsDisposed)
                {
                    mgs.ShowDialog();
                }
            this.Close();
        }
    }
}

