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
    public partial class On_orderListForm : Form
    {
        public On_orderListForm()
        {
            InitializeComponent();
        }

        private void RefreshLoad()
        {
            AC.openConnection();
            AC.sql = "select * from 注文テーブル";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dateTimePicker1.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void On_orderListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
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

                            AC.sql = "insert into 注文テーブル(注文番号, 顧客名, 商品名, 注文数量, 注文日, 商品価格, 会員名) Values(?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;

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
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
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
                            AC.sql = "update 注文テーブル set 注文番号 = ?, 顧客名 = ?, 商品名 = ?, 注文数量 = ?, 注文日 = ?, 商品価格 = ?, 会員名 = ? where 注文ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;
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

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4]; // 非可視セルがどうのこうの言われたらCells[]の値に非表示にしてるIDの数を入れるといい
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
                        AC.cmd.CommandText = "delete from 注文テーブル where 注文ID = @id;";
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

        private void On_orderListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }
    }
}
