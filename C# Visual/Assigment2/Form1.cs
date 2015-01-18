using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment2
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software by Kristian Wahlroos - 2014", "Software information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddNewMovie_Click(object sender, EventArgs e)
        {
            Adding addForm = new Adding();
            addForm.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Show();
        }
    }
}
