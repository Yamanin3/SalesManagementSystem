using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242); RefreshLoad();
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
                textBoxSID.Text = "";
                textBoxOID.Text = "";
                textBoxPname.Text = "";
                textBoxSquantity.Text = "";
                textBoxOcurrency.Text = "";
                textBoxCname.Text = "";
                textBoxChurigana.Text = "";
                textBoxCpost.Text = "";
                textBoxCaddress.Text = "";
                textBoxCphone.Text = "";
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
                textBoxSID.Text = "";
                textBoxOID.Text = "";
                textBoxPname.Text = "";
                textBoxSquantity.Text = "";
                textBoxOcurrency.Text = "";
                textBoxCname.Text = "";
                textBoxChurigana.Text = "";
                textBoxCpost.Text = "";
                textBoxCaddress.Text = "";
                textBoxCphone.Text = "";
            }
            else if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                buttonAdd.Enabled = true;
                buttonAdd.Text = "追加";
                textBoxSID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxOID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxSquantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxOcurrency.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxCname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxChurigana.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxCpost.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBoxCaddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBoxCphone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonAdd.Text = "編集";
                textBoxSID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxOID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxSquantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxOcurrency.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxCname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxChurigana.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxCpost.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBoxCaddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBoxCphone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxOID.Text.Trim()) || string.IsNullOrEmpty(textBoxPname.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxSquantity.Text.Trim()) || string.IsNullOrEmpty(textBoxOcurrency.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCname.Text.Trim()) || string.IsNullOrEmpty(textBoxChurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCpost.Text.Trim()) || string.IsNullOrEmpty(textBoxCaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCphone.Text.Trim()))
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
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBoxOID.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBoxPname.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBoxCname.Tag;
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
                        textBoxPname.Tag = PID.ToString();
                        CID = int.Parse(AC.rd.GetValue(1).ToString());
                        textBoxCname.Tag = CID.ToString();
                        textBoxSquantity.Text = AC.rd.GetValue(2).ToString();
                        total = int.Parse(AC.rd.GetValue(3).ToString());
                        textBoxOcurrency.Text = total.ToString();
                        textBoxOID.Text = id.ToString();
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
                        textBoxPname.Text = AC.rd.GetString(0);

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
                        textBoxCname.Text = AC.rd.GetString(0);
                        textBoxChurigana.Text = AC.rd.GetString(1);
                        textBoxCpost.Text = AC.rd.GetValue(2).ToString();
                        textBoxCaddress.Text = AC.rd.GetString(3);
                        textBoxCphone.Text = AC.rd.GetValue(4).ToString();
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
            if (dataGridView1.CurrentCell == null)
                MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell =
                dataGridView1.Rows[dataGridView1.Rows.Count - 1]
                    .Cells[0];
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }
    }
}