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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.openConnection();
            AC.sql = "select * from 商品マスタ";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - dataGridView1.Rows.Count].Cells[2];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }
            else
            {

                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2];
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
                        AC.cmd.CommandText = "delete from 商品マスタ where 商品ID = @id;";
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
                if ((string.IsNullOrEmpty(this.textBox1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox2.Text.Trim())))
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

                            AC.sql = "insert into 商品マスタ(商品番号, 商品名, 重量, 口径, 全長, 弾薬, マガジンタイプ, 装弾数, メーカー名, 商品価格) Values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox8.Text;

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
                if ((string.IsNullOrEmpty(this.textBox1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox2.Text.Trim())))
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
                            AC.sql = "update 商品マスタ set 商品番号 = ?, 商品名 = ?, 重量 = ?, 口径 = ?, 全長 = ?, 弾薬 = ?, マガジンタイプ = ?, 装弾数 = ?, メーカー名 = ?, 商品価格 = ? where 商品ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Numeric).Value = textBox8.Text;
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

        private void ProductListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }

    }
}
