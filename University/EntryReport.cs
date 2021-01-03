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
    public partial class EntryReport : Form
    {
        public EntryReport()
        {
            InitializeComponent();
        }

        private void EntryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aliDataSet.مشخصات_طرح' table. You can move, or remove it, as needed.
            this.مشخصات_طرحTableAdapter.Fill(this.aliDataSet.مشخصات_طرح);

        }
    }
}
