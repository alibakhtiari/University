using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >=600)
            {
                UpdateTimer.Stop();
                LogIn mf = new LogIn();
                mf.Show();
                this.Hide();

            }
        }
    }
}
