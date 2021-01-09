using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        
        public void button3_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            portalSelect.Text = s;
            MainWindowOpener.BackColor = Color.Yellow;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            portalSelect.Text = s;
        }
        private void button1_Click(object sender, EventArgs e) {
            LogInNow();
        }

        private void LogInNow()
        {
            
            //String str = "Data Source=localhost\\sqlexpress;Initial Catalog=master; Integrated Security=True";
            String str = "Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Administrator\source\repos\alibakhtiari\University\University\Ali.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from UserProfile where LogInUser=@LogInUser and LogInPass =@LogInPass", con);
            cmd.Parameters.AddWithValue("@LogInUser", textBox1.Text);
            cmd.Parameters.AddWithValue("@LogInPass", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0 & portalSelect.Text != "")
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
            else if (dt.Rows.Count > 0 & portalSelect.Text == "")
            {
                MessageBox.Show("لطفا زیر پورتال مورد نظر را انتخاب کنید.");
            }
            else
            {
                //MessageBox.Show("نام کاربری یا رمز عبور صحیح نمی باشد.");
                MsgBox frm = new MsgBox("نام کاربری یا رمز عبور صحیح نمی باشد.", "قبول");
                frm.ShowDialog();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInNow();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInNow();
            }
        }
    }
}
