﻿using System;
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
    public partial class MsgBox : Form
    {
        public MsgBox(string message, string buttonText1)
        {
            InitializeComponent();
            label1.Text = message;
            button1.Text = buttonText1;
        }

        private void MsgBox_Load(object sender, EventArgs e )
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
