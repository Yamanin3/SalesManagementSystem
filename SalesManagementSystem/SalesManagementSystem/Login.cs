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

namespace SalesManagementSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            
            // 接続をオープンにする
            // Login_form.Static_Classes.AC.openConnection();

            // 接続をクローズする
            // Login_form.Static_Classes.AC.closeConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Focus();

            AC.openConnection();

            if ((string.IsNullOrEmpty(this.textBox1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())))
            {
                

                MessageBox.Show("会員名とパスワードを入力してください", "会員ログイン : データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (this.textBox1.CanSelect)
                {
                    this.textBox1.Select();
                }

                this.textBox1.SelectAll();
                this.textBox2.Text = string.Empty;

                return;

               }

            AC.sql = "select 会員名, パスワード from 会員マスタ where 会員名 = @us and パスワード = @pa;";
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.cmd.Parameters.AddWithValue("@us", this.textBox1.Text.Trim().ToString());
            AC.cmd.Parameters.AddWithValue("@pa", this.textBox2.Text.Trim().ToString());

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.currentFullName = AC.rd[0].ToString();
                    MessageBox.Show("ようこそ " + AC.currentFullName, "会員ログイン : ログイン成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;

                this.Hide();
   
                Form menuForm = new MainMenuForm();
                menuForm.Show();

                
            }
            else
            {
                MessageBox.Show("会員名かパスワードが違います。もう一度やり直してください。", "会員ログイン : ログイン失敗", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (this.textBox1.CanSelect)
                {
                    this.textBox1.Select();
                }
            }
            this.textBox1.SelectAll();
            this.textBox2.Text = string.Empty;

            AC.rd.Close();
            AC.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
