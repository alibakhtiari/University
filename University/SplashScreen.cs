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

        
        public int fortimerinterval1;
        public string[] LoadingModules = { "برقراری ارتباط با سرور", "برقراری ارتباط با بانک اطلاعاتی", "بارگذاری ShamsiDate.dll ", "بارگذاری FormViewer.dll", "بارگذاری EntryForm.dll", "بارگذاری EntryReport.dll", "نهایی سازی اجرای برنامه" };
        public int i = 0;
        public int h, k = 0;
        private void stTimer()
        {
            Random rand = new Random();
            fortimerinterval1 = rand.Next(300, 500);
            StatusTimer.Interval = fortimerinterval1;
            StatusTimer.Enabled = true;
            StatusTimer.Start();
        }
        private void opener()
        {
            if (h == 1 & k == 1)
            {
                LogIn mf = new LogIn();
                mf.Show();
                this.Hide();
            }
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            if (panel2.Width <= 100)
            {
                panel2.Width += 3;
            }
            else if (panel2.Width <= 200)
            {
                panel2.Width += 15;
            }
            else if (panel2.Width <= 400)
            {
                panel2.Width += 8;
            }
            else if (panel2.Width < 600)
            {
                panel2.Width += 20;
            }
            else if (panel2.Width >= 600) { 
                UpdateTimer.Stop();
                h = 1;
                opener();
            }
        }
        private void StatusTimer_Tick(object sender, EventArgs e)

        {
     
            SplashScreenStatus.Text = "در حال " + LoadingModules[i];
            stTimer();
            i++;
            if (i >= 7)
            {
                StatusTimer.Stop();
                k = 1;
                
                
            }


        }

    }
}
