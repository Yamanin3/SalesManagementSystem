using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_form.Static_Classes;
using System.Data.OleDb;

namespace SalesManagementSystem
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
            // IDカラムを隠す
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           

<<<<<<< HEAD
                DataGridViewRow row = cell.OwningRow;
                textBox1.Text = row.Cells[1].Value.ToString();
                顧客textBox.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
                textBox4.Text = row.Cells[6].Value.ToString();
                textBox5.Text = row.Cells[7].Value.ToString();
                textBox6.Text = row.Cells[8].Value.ToString();
                textBox7.Text = row.Cells[9].Value.ToString();

            }
=======
            
>>>>>>> 600d9f2a652efe2e65641edfc251cd2978edc4fd
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AC.openConnection();
            AC.sql = "update 顧客マスタ set 顧客名 = " + 顧客textBox.Text + " where 顧客ID = 1";
            AC.cmd.CommandText = AC.sql;
            AC.cmd.ExecuteNonQuery();
            AC.closeConnection();

        }

    }
}
