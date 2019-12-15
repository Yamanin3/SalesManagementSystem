using System;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Form customerlistForm = new CustomerListForm();
            customerlistForm.ShowDialog();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Form employeelistForm = new EmployeeListForm();
            employeelistForm.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form on_orderlistForm = new OrderListForm();
            on_orderlistForm.ShowDialog();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Form productlistForm = new ProductListForm();
            productlistForm.ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            buttonCustomer.BackColor = Color.FromArgb(191, 205, 219);
            buttonEmployee.BackColor = Color.FromArgb(191, 205, 219);
            buttonProduct.BackColor = Color.FromArgb(191, 205, 219);
            buttonOrder.BackColor = Color.FromArgb(191, 205, 219);
            buttonShip.BackColor = Color.FromArgb(191, 205, 219);
            buttonLoad.BackColor = Color.FromArgb(191, 205, 219);
            buttonOrdering.BackColor = Color.FromArgb(191, 205, 219);
            buttonStock.BackColor = Color.FromArgb(191, 205, 219);
            buttonSales.BackColor = Color.FromArgb(191, 205, 219);
            buttonLogout.BackColor = Color.FromArgb(191, 205, 219);
            buttonExit.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
            MaximizeBox = false;
        }

        private void buttonOrdering_Click(object sender, EventArgs e)
        {
            Form requestlistForm = new RequestListForm();
            requestlistForm.ShowDialog();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            Form stocklistForm = new StockListForm();
            stocklistForm.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Form loadedlistForm = new LoadedListForm();
            loadedlistForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }

        private void buttonShip_Click(object sender, EventArgs e)
        {
            Form shiplistForm = new ShipListForm();
            shiplistForm.ShowDialog();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Form saleslistForm = new SalesListForm();
            saleslistForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var msg = "本当にログアウトしますか？";
            var caption = "ログアウト";
            var buttons = MessageBoxButtons.YesNo;
            var ico = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                AC.closeConnection();
                Hide();
                Form loginForm = new Login_Form();
                loginForm.Show();
            }
            else
            {
            }
        }

    }
}