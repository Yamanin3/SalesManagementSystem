﻿using Login_form.Static_Classes;
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

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
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

        private void button10_Click(object sender, EventArgs e)
        {
            Form shiplistForm = new ShipListForm();
            shiplistForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form saleslistForm = new SalesListForm();
            saleslistForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            string msg = "本当にログアウトしますか？";
            string caption = "ログアウト";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                AC.closeConnection();
                this.Hide();
                Form loginForm = new Login_Form();
                loginForm.Show();
            }
            else { return; }
        }
    }
}
