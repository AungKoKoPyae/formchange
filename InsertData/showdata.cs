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

namespace InsertData
{
    public partial class showdata : Form
    {
        public showdata()
        {
            InitializeComponent();
        }

        private void showdata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testImportDataSet._MDY_Ledger_List_Table_' table. You can move, or remove it, as needed.
            

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            goodslist goodslst = new goodslist();
            goodslst.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemlist itemlst = new itemlist();
            itemlst.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            incomegoods incomegood = new incomegoods();
            incomegood.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            exportTocars expcar = new exportTocars();
            expcar.ShowDialog();
        }
    }
}   
