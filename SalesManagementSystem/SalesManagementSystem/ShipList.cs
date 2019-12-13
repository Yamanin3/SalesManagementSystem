using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class ShipListForm : Form
    {
        private int CID;
        private int OID;
        private int PID;
        private int total;

        public ShipListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void ShipListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
            MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.cmd.Parameters.Clear();
            AC.sql =
                "select sh.出荷ID, od.注文ID, pd.商品名, od.注文数量, od.合計額, cus.顧客名, cus.ふりがな, cus.郵便番号, cus.住所, cus.電話番号 from ((出荷テーブル as sh inner join 顧客マスタ as cus on sh.顧客ID = cus.顧客ID) inner join 注文テーブル as od on sh.注文ID = od.注文ID) inner join 商品マスタ as pd on sh.商品ID = pd.商品ID where sh.ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;


            if (dataGridView1.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
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
                buttonAdd.Enabled = true;
                // datagridview1の最上段にカーソルを当てる
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }

            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                buttonAdd.Enabled = false;
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
            else if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                buttonAdd.Enabled = true;
                buttonAdd.Text = "追加";
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
            else
            {
                buttonAdd.Enabled = false;
                buttonAdd.Text = "編集";
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
                if (string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox4.Text.Trim()) || string.IsNullOrEmpty(textBox5.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox6.Text.Trim()) || string.IsNullOrEmpty(textBox7.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox8.Text.Trim()) || string.IsNullOrEmpty(textBox9.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox10.Text.Trim()))
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    try
                    {
                        var msg = "データを追加しますか？";
                        var caption = "データの追加";
                        var buttons = MessageBoxButtons.YesNo;
                        var ico = MessageBoxIcon.Question;

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
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.cmd.Parameters.Clear();
                                AC.cmd.CommandText = "update 注文テーブル set ステータス = ? where 注文ID = @id";
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 1;
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = OID;
                                AC.cmd.ExecuteNonQuery();

                                AC.cmd.Parameters.Clear();
                                AC.cmd.CommandText = "insert into 売上テーブル(商品ID, 注文ID, 売上額) Values(?, ?, ?)";
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = PID;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = OID;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = total;
                                AC.cmd.ExecuteNonQuery();

                                RefreshLoad();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの追加に失敗しました: " + ex.Message, "データの追加", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
            dataGridView1.CurrentCell =
                dataGridView1.Rows[dataGridView1.Rows.Count - 1]
                    .Cells[0]; // 非可視セルがどうのこうの言われたらCells[]の値に非表示にしてるIDの数を入れるといい
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("注文テーブル", "注文情報選択",
                "select od.注文ID, pd.商品名, od.注文数量, od.注文日, od.合計額 from 注文テーブル as od inner join 商品マスタ as pd on od.商品ID = pd.商品ID where od.ステータス = 0");
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
                        total = int.Parse(AC.rd.GetValue(3).ToString());
                        textBox5.Text = total.ToString();
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
                    MessageBox.Show("注文情報の取得に失敗しました : " + ex.Message, "注文情報の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名 from 商品マスタ where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = PID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                        textBox3.Text = AC.rd.GetString(0);

                    else
                        return;
                    AC.rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("商品情報の取得に失敗しました : " + ex.Message, "商品情報の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
                        textBox8.Text = AC.rd.GetValue(2).ToString();
                        textBox9.Text = AC.rd.GetString(3);
                        textBox10.Text = AC.rd.GetValue(4).ToString();
                    }

                    else
                    {
                        return;
                    }

                    AC.rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("顧客情報の取得に失敗しました : " + ex.Message, "顧客情報の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select sh.出荷ID, od.注文ID, pd.商品名, od.注文数量, od.合計額, cus.顧客名, cus.ふりがな, cus.郵便番号, cus.住所, cus.電話番号 from ((出荷テーブル as sh inner join 顧客マスタ as cus on sh.顧客ID = cus.顧客ID) inner join 注文テーブル as od on sh.注文ID = od.注文ID) inner join 商品マスタ as pd on sh.商品ID = pd.商品ID where (sh.出荷ID like '%{kw}%' or od.注文ID like '%{kw}%' or pd.商品名 like '%{kw}%' or od.合計額 like '%{kw}%' or cus.顧客名 like '%{kw}%' or cus.ふりがな like '%{kw}%' or cus.郵便番号 like '%{kw}%' or cus.住所 like '%{kw}%' or cus.電話番号 like '%{kw}%') and sh.ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }
    }
}