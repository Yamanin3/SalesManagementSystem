using System;
using System.Data;
using System.Drawing;
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
            MaximizeBox = false;
            buttonLogin.BackColor = Color.FromArgb(191, 205, 219);
            buttonExit.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
            pictureBox2.Controls.Add(pictureBox5); //ピクチャーボックスの背景を透過させる(プロパティ:BackColorがTransparentになっていること)
            AC.openConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AC.openConnection();

            if (string.IsNullOrEmpty(textBoxMID.Text.Trim()) || string.IsNullOrEmpty(textBoxMpass.Text.Trim()))
            {
                MessageBox.Show("社員IDとパスワードを入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (textBoxMID.CanSelect) textBoxMID.Select();

                textBoxMID.SelectAll();
                textBoxMpass.Text = string.Empty;

                return;
            }

            AC.sql = "select 社員ID, パスワード, 社員名, ステータス from 社員マスタ where 社員ID = @id and パスワード = @pa;";
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.cmd.Parameters.AddWithValue("@id", textBoxMID.Text.Trim());
            AC.cmd.Parameters.AddWithValue("@pa", Sha256hash.ToHash(textBoxMpass.Text.Trim()));

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.currentFullName = AC.rd[2].ToString();
                    status = int.Parse(AC.rd[3].ToString());
                    MessageBox.Show("ようこそ " + AC.currentFullName + "さん", "ログイン成功", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                AC.currentID = int.Parse(textBoxMID.Text);

                textBoxMID.Text = string.Empty;
                textBoxMpass.Text = string.Empty;

                Hide();

                Form menuForm = new MainMenuForm();
                menuForm.Show();
            }
            else if (status != 0)
            {
                MessageBox.Show("社員IDかパスワードが違います。もう一度やり直してください。", "データ入力エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                if (textBoxMID.CanSelect) textBoxMID.Select();
            }
            else
            {
                MessageBox.Show("社員IDかパスワードが違います。もう一度やり直してください。", "データ入力エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                if (textBoxMID.CanSelect) textBoxMID.Select();
            }

            textBoxMID.SelectAll();
            textBoxMpass.Text = string.Empty;

            AC.rd.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin.PerformClick();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin.PerformClick();
        }

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            textBoxMID.Focus();
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }
    }
}