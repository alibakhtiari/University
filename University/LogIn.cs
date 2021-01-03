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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            portalSelect.Text = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            portalSelect.Text = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (portalSelect.Text)
            {
                case "MainWindowOpener":
                    this.Hide();
                    Main f2 = new Main();
                    f2.Show();
                    break;
                case "EntryReportOpener":
                    this.Hide();
                    EntryForm f3 = new EntryForm();
                    f3.Show();
                    break;
            }
        }

    }
}
