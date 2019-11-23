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
    public partial class ShipListForm : Form
    {
        private int PID;
        private int CID;
        private int OID;
        public ShipListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void ShipListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.cmd.Parameters.Clear();
            AC.sql = "select sh.出荷ID, od.注文ID, pd.商品名, od.注文数量, od.合計額, cus.顧客名, cus.ふりがな, cus.郵便番号, cus.住所, cus.電話番号 from ((出荷テーブル as sh inner join 顧客マスタ as cus on sh.顧客ID = cus.顧客ID) inner join 注文テーブル as od on sh.注文ID = od.注文ID) inner join 商品マスタ as pd on sh.商品ID = pd.商品ID where sh.ステータス = 0";
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
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

            }
            else
            {
                // datagridview1の最上段にカーソルを当てる
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
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
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.textBox9.Text.Trim())) || (string.IsNullOrEmpty(this.textBox10.Text.Trim())))
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

                            AC.sql = "insert into 出荷テーブル(注文ID, 商品ID, 顧客ID, ステータス) Values(?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox3.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox6.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.cmd.Parameters.Clear();
                                AC.cmd.CommandText = "update 注文テーブル set ステータス = ? where 注文ID = @id";
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 1;
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = OID;
                                AC.cmd.ExecuteNonQuery();

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
                MessageBox.Show("出荷済みのデータは編集できません", "データの編集", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0]; // 非可視セルがどうのこうの言われたらCells[]の値に非表示にしてるIDの数を入れるといい
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void ShipListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("注文テーブル", "注文情報選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品ID, 顧客ID, 注文数量, 合計額 from 注文テーブル where 注文ID = @id and ステータス = 0";
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        PID = int.Parse(AC.rd.GetValue(0).ToString());
                        textBox3.Tag = PID.ToString();
                        CID = int.Parse(AC.rd.GetValue(1).ToString());
                        textBox6.Tag = CID.ToString();
                        textBox4.Text = AC.rd.GetValue(2).ToString();
                        textBox5.Text = AC.rd.GetValue(3).ToString();
                        textBox2.Text = id.ToString();
                        OID = id;
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("注文情報の取得に失敗しました : " + ex.Message.ToString(), "注文情報の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名 from 商品マスタ where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = PID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox3.Text = AC.rd.GetString(0);
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("商品情報の取得に失敗しました : " + ex.Message.ToString(), "商品情報の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 顧客名, ふりがな, 郵便番号, 住所, 電話番号 from 顧客マスタ where 顧客ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = CID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox6.Text = AC.rd.GetString(0);
                        textBox7.Text = AC.rd.GetString(1);
                        textBox8.Text = AC.rd.GetString(2);
                        textBox9.Text = AC.rd.GetString(3);
                        textBox10.Text = AC.rd.GetString(4);
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("顧客情報の取得に失敗しました : " + ex.Message.ToString(), "顧客情報の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
