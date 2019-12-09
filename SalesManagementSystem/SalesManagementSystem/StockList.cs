using Login_form.Static_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class StockListForm : Form
    {
        private int I;

        public StockListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void StockListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.sql = "select st.在庫ID, pd.商品ID, pd.商品名, st.在庫数, st.発注点 from 在庫テーブル as st right outer join 商品マスタ as pd on st.商品ID = pd.商品ID where pd.ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            this.dataGridView1.Columns[0].Visible = false;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0";
                textBox4.Text = "";

            }
            else
            {
                buttonAdd.Enabled = true;
                // datagridview1の最上段にカーソルを当てる
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    buttonAdd.Enabled = false;

                }
                else
                {
                    buttonAdd.Enabled = true;
                    textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    if(dataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    }
                    textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message.ToString(), "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if ((string.IsNullOrEmpty(this.textBox4.Text.Trim())))
                {
                    MessageBox.Show("発注点を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox4.Focus();
                    textBox4.SelectAll();
                }else if (textBox4.Text == "0")
                {
                    MessageBox.Show("発注点に\"0\"は設定できません", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox4.Focus();
                    textBox4.SelectAll();
                }
                else
                {

                    try
                    {
                        string msg = "商品に発注点を設定しますか？";
                        string caption = "発注点の設定";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {

                            AC.sql = "insert into 在庫テーブル(商品ID, 在庫数, 発注点) Values(?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox3.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox4.Text);


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
                        MessageBox.Show("発注点の設定に失敗しました: " + ex.Message.ToString(), "発注点の設定", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            else
            {
                if ((string.IsNullOrEmpty(this.textBox4.Text.Trim())))
                {
                    MessageBox.Show("発注点を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string msg = "発注点の編集を反映しますか？";
                        string caption = "発注点の編集";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {

                            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            AC.sql = "update 在庫テーブル set 商品ID = ?, 在庫数 = ?, 発注点 = ? where 在庫ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox3.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox4.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshLoad();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kw = SearchTextbox.Text;
            AC.sql = $"select st.在庫ID, pd.商品ID, pd.商品名, st.在庫数, st.発注点 from 在庫テーブル as st right outer join 商品マスタ as pd on st.商品ID = pd.商品ID where (st.在庫ID like '%{kw}%' or pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or st.在庫数 like '%{kw}%' or st.発注点 like '%{kw}%') and ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
    }
}
