using Login_form.Static_Classes;
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
            Form customerlistForm = new CustomerListForm();
            customerlistForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form memberlistForm = new MemberListForm();
            memberlistForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form on_orderlistForm = new On_orderListForm();
            on_orderlistForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form productlistForm = new ProductListForm();
            productlistForm.ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form in_stockForm = new In_stockListForm();
            in_stockForm.ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form requestlistForm = new RequestListForm();
            requestlistForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form stocklistForm = new StockListForm();
            stocklistForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form loadedlistForm = new LoadedListForm();
            loadedlistForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form issuelistForm = new IssueListForm();
            issuelistForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form shiplistForm = new ShipListForm();
            shiplistForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form saleslistForm = new SalesListForm();
            saleslistForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = new Login_Form();
            loginForm.ShowDialog();
        }
    }
}
