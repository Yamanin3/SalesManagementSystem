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
using SalesManagementSystem.Static_Classes;

namespace SalesManagementSystem
{
    public partial class Login_Form : Form
    {
        private int status;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(191, 205, 219);
            this.button2.BackColor = Color.FromArgb(191, 205, 219);
            this.BackColor = System.Drawing.Color.FromArgb(215, 228, 242);
            AC.openConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Focus();

            AC.openConnection();

            if ((string.IsNullOrEmpty(this.textBox1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())))
            {

                MessageBox.Show("会員IDとパスワードを入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (this.textBox1.CanSelect)
                {
                    this.textBox1.Select();
                }

                this.textBox1.SelectAll();
                this.textBox2.Text = string.Empty;

                return;

            }

            AC.sql = "select 会員ID, パスワード, 会員名, ステータス from 会員マスタ where 会員ID = @id and パスワード = @pa;";
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.cmd.Parameters.AddWithValue("@id", textBox1.Text.Trim().ToString());
            AC.cmd.Parameters.AddWithValue("@pa", Sha256hash.ToHash(textBox2.Text.Trim().ToString()));

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.currentFullName = AC.rd[2].ToString();
                    status = int.Parse(AC.rd[3].ToString());
                    MessageBox.Show("ようこそ " + AC.currentFullName + "さん", "ログイン成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;

                this.Hide();

                Form menuForm = new MainMenuForm();
                menuForm.Show();


            }
            else if(status != 0)
            {
                MessageBox.Show("会員IDかパスワードが違います。もう一度やり直してください。", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (this.textBox1.CanSelect)
                {
                    this.textBox1.Select();
                }
            }
            else
            {
                MessageBox.Show("会員IDかパスワードが違います。もう一度やり直してください。", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (this.textBox1.CanSelect)
                {
                    this.textBox1.Select();
                }
            }
            this.textBox1.SelectAll();
            this.textBox2.Text = string.Empty;

            AC.rd.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AC.closeConnection();
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

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }
    }
}
