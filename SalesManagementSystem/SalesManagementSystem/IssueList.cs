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
    public partial class IssueListForm : Form
    {
        public IssueListForm()
        {
            InitializeComponent();
        }

        private void IssueListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {

            AC.sql = "select pd.商品ID, pd.商品名, pd.重量, pd.口径, pd.全長, pd.弾薬, pd.マガジンタイプ, pd.装弾数, mk.メーカー名, pd.商品価格 from 商品マスタ as pd inner join 仕入先マスタ as mk on pd.メーカーID = mk.メーカーID";
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
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form issuedlistForm = new IssuedListForm();
            issuedlistForm.ShowDialog();
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
            else
            {

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

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
                        AC.cmd.CommandText = "delete from 出庫テーブル where 出庫ID = @id;";
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
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())))
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

                            AC.sql = "insert into 出庫テーブル(出庫番号, 商品番号, 商品名, 商品価格, 数量, 製造元, 出庫先営業所) Values(@number, @pnumber, @pname, @price, @quantity, @manufa, @to)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@number", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@pnumber", OleDbType.Integer).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@pname", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@price", OleDbType.Integer).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@quantity", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@manufa", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@to", OleDbType.VarWChar).Value = textBox7.Text;

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
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())))
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
                            AC.sql = "update 出庫テーブル set 出庫番号 = @number, 商品番号 = @pnumber, 商品名 = @pname, 商品価格 = @price, 数量 = @quantity, 製造元 = @manufa, 出庫先営業所 = @to where 出庫ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@number", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@pnumber", OleDbType.Integer).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@pname", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@price", OleDbType.Integer).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@quantity", OleDbType.Integer).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@manufa", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@to", OleDbType.VarWChar).Value = textBox7.Text;
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

        private void IssueListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
