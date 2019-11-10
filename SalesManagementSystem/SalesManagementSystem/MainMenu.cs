using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form customerlistForm = new CustomerListForm();
            customerlistForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form memberlistForm = new MemberListForm();
            memberlistForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form on_orderlistForm = new On_orderListForm();
            on_orderlistForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form productlistForm = new ProductListForm();
            productlistForm.Show();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form arrivallistForm = new ArrivalListForm();
            arrivallistForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form requestlistForm = new RequestListForm();
            requestlistForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form stocklistForm = new StockListForm();
            stocklistForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loadlistForm = new LoadListForm();
            loadlistForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form issuelistForm = new IssueListForm();
            issuelistForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form shiplistForm = new ShipListForm();
            shiplistForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form saleslistForm = new SalesListForm();
            saleslistForm.Show();
        }
    }
}
