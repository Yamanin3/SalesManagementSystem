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
            this.dataGridView1.Columns[0].Visible = false;
            AC.openConnection();
            AC.sql = "select * from 会員マスタ";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }
            else { 

                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }


        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                AC.dt.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                RefreshLoad();
            }
            else
            {
                try
                {
                    string msg = "レコードを削除しますか？";
                    string caption = "レコードの削除";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {


                        AC.cmd.Parameters.Clear();
                        AC.cmd.CommandText = "delete from 会員マスタ where 会員ID = @id;";
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
                    MessageBox.Show("データの削除に失敗しました : " + ex.Message.ToString(), "データの削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())))
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

                            AC.sql = "insert into 会員マスタ(会員番号, 会員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入会日, パスワード) Values(@number, @name, @hurigana, @sex, @date, @post, @address, @phone, @mail, @joindate, @pass)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@number", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@name", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@hurigana", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@sex", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("@date", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("@post", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@address", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@phone", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@mail", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("@joindate", OleDbType.Date).Value = dateTimePicker2.Text;
                            AC.cmd.Parameters.Add("@pass", OleDbType.VarWChar).Value = textBox8.Text;

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
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())))
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
                            AC.sql = "update 会員マスタ set 会員番号 = @number, 会員名 = @name, ふりがな = @hurigana, 性別 = @sex, 生年月日 = @date, 郵便番号 = @post, 住所 = @address, 電話番号 = @phone, メールアドレス = @mail where 会員ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@number", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@name", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@hurigana", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@sex", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("@date", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("@post", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@address", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@phone", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@mail", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("@joindate", OleDbType.Date).Value = dateTimePicker2.Text;
                            AC.cmd.Parameters.Add("@pass", OleDbType.VarWChar).Value = textBox8.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

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
            AC.closeConnection();
            Application.Exit();
        }

    }
}
