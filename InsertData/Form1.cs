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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ShowDataBtn
            this.Hide();
            showdata showDta = new showdata();
            showDta.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            exportTocars expToCar = new exportTocars();
            expToCar.ShowDialog();

        }
        SqlConnection con = new SqlConnection(@"Data Source=ARKAR\SQLEXPRESS;Initial Catalog=testImport;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (VouncherTextbox.Text == "" || dateTimePicker.Text == "" || MDYNameTextBox.Text == ""
                    || YGNNametextBox.Text == "" || QuantitytextBox.Text == "" || QuantitytextBox.Text == ""
                    || LabeltextBox.Text == "" || PricetextBox.Text == "" || ParticulartextBox.Text == ""
                    || AmounttextBox.Text == "" || MDYShorttextBox.Text == "" || MDYLabourtextBox.Text == ""
                    || YGNLabouttextBox.Text == "" || RemarktextBox.Text == "")
                {
                    MessageBox.Show("All Fields Are required to enter");
                }
                else
                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into MDY_Ledger_List_Table$ values( ' " + VouncherTextbox.Text + " ','" + MDYNameTextBox.Text + "','" + YGNNametextBox.Text + "',' " + QuantitytextBox.Text + " ','" + QuantitytextBox.Text + "','" + LabeltextBox.Text + "',' " + PricetextBox.Text + " ',N'" + ParticulartextBox.Text + "','" + AmounttextBox.Text + "',' " + MDYShorttextBox.Text + " ','" + MDYLabourtextBox.Text + "','" + PaidcheckBox.Checked.ToString() + "',' " + YGNLabouttextBox.Text + " ','" + RemarktextBox.Text + "','" + dateTimePicker.Value.ToShortDateString() + "' )", con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
