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
            customerlistForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form memberlistForm = new MemberListForm();
            memberlistForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form orderlistForm = new OrderListForm();
            orderlistForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form productlistForm = new ProductListForm();
            productlistForm.Show();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
