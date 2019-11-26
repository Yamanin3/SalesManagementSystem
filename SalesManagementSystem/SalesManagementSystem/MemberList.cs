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
    public partial class MemberListForm : Form
    {
        private int I;
        private double D;
        private long L;

        public MemberListForm()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {

            RefreshLoad();

        }

        private void RefreshLoad()
        {

            AC.sql = "select 会員ID, 会員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入会日, パスワード from 会員マスタ where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                dateTimePicker2.Text = "";
                textBox8.Text = "";
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    return;
                }
                else
                {

                    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    textBox8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message.ToString(), "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }


        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "選択された会員を削除しますか？";
                string caption = "会員の削除";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    AC.sql = "update 会員マスタ set ステータス = ? where 会員ID = @id";
                    AC.cmd.Parameters.Clear();
                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    AC.cmd.CommandText = AC.sql;
                    AC.cmd.ExecuteNonQuery();

                    RefreshLoad();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("会員の削除に失敗しました : " + ex.Message.ToString(), "会員の削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    try
                    {
                        string msg = "レコードを追加しますか？";
                        string caption = "レコードの追加";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {

                            AC.sql = "insert into 会員マスタ(会員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入会日, パスワード, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox8.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {

                                RefreshLoad();

                            }
                        }
                        else
                        {
                            return;
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの追加に失敗しました: " + ex.Message.ToString(), "データの追加", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            else
            {
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string msg = "レコードの編集を反映しますか？";
                        string caption = "レコードの編集";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {

                            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            AC.sql = "update 会員マスタ set 会員名 = ?, ふりがな = ?, 性別 = ?, 生年月日 = ?, 郵便番号 = ?, 住所 = ?, 電話番号 = ?, メールアドレス = ?, 入会日 = ?, パスワード = ? where 会員ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox8.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {

                                RefreshLoad();

                            }
                        }
                        else
                        {
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの編集に失敗しました: " + ex.Message.ToString(), "データの編集", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void MemberListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && int.TryParse(textBox4.Text, out I) != true)
            {
                textBox4.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            long L;
            if (!string.IsNullOrEmpty(textBox6.Text) && long.TryParse(textBox6.Text, out L) != true)
            {
                textBox6.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
