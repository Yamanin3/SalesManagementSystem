using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class OrderListForm : Form
    {
        private int answer;
        private int dstock;
        private int MID;
        private int order_point;
        private readonly int order_quantity = 50;
        private int PID;
        private int stock;

        public OrderListForm()
        {
            InitializeComponent();
        }

        private void RefreshLoad()
        {
            if (checkBox1.Checked == false)
            {
                AC.sql =
                    "select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, emp.社員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 社員マスタ as emp on od.社員ID = emp.社員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where od.ステータス = 0";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();

                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                if (dataGridView1.SelectedRows.Count <= 0)
                {
                    textBoxOID.Text = "";
                    textBoxCname.Text = "";
                    textBoxPname.Text = "";
                    comboBoxOquantity.Text = "1";
                    dateTimePickerOdate.Text = "";
                    textBoxPcurrency.Text = "";
                    textBoxOcurrency.Text = "";
                    textBoxMname.Text = "";
                }
                else
                {
                    // datagridview1の最上段にカーソルを当てる
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
            }
            else
            {
                AC.sql =
                    "select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, emp.社員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 社員マスタ as emp on od.社員ID = emp.社員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where od.ステータス = 1";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();

                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                if (dataGridView1.SelectedRows.Count <= 0)
                {
                    buttonAdd.Enabled = false;
                    textBoxOID.Text = "";
                    textBoxCname.Text = "";
                    textBoxPname.Text = "";
                    comboBoxOquantity.Text = "1";
                    dateTimePickerOdate.Text = "";
                    textBoxPcurrency.Text = "";
                    textBoxOcurrency.Text = "";
                    textBoxMname.Text = "";
                }
                else
                {
                    // datagridview1の最上段にカーソルを当てる
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
            }
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRemove.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242); RefreshLoad();
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
            MaximizeBox = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                buttonAdd.Enabled = false;
                textBoxOID.Text = "";
                textBoxCname.Text = "";
                textBoxPname.Text = "";
                comboBoxOquantity.Text = "1";
                dateTimePickerOdate.Text = "";
                textBoxPcurrency.Text = "";
                textBoxOcurrency.Text = "";
                textBoxMname.Text = "";
            }
            else if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                buttonAdd.Enabled = true;
                buttonAdd.Text = "追加";
                textBoxOID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxCname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBoxOquantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePickerOdate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxPcurrency.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxOcurrency.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxMname.Text = AC.currentFullName;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonAdd.Text = "編集";
                textBoxOID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxCname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBoxOquantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePickerOdate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxPcurrency.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxOcurrency.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxMname.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // 追加ボタンクリック後の処理////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxCname.Text.Trim()) || string.IsNullOrEmpty(textBoxPname.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxOquantity.Text.Trim()) || string.IsNullOrEmpty(textBoxPcurrency.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxOcurrency.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerOdate.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMname.Text.Trim()))
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
                            AC.cmd.Parameters.Clear();
                            AC.cmd.CommandText = "select 在庫数, 発注点 from 在庫テーブル where 商品ID = @id";
                            AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                            AC.rd = AC.cmd.ExecuteReader();

                            if (AC.rd.Read())
                            {
                                stock = int.Parse(AC.rd.GetValue(0).ToString());
                                order_point = int.Parse(AC.rd.GetValue(1).ToString());
                            }
                            else
                            {
                                return;
                            }

                            AC.rd.Close();

                            if (stock >= int.Parse(comboBoxOquantity.Text))
                            {
                                AC.sql =
                                    "insert into 注文テーブル(商品ID, 顧客ID, 社員ID, 注文数量, 注文日, 合計額, ステータス) Values(?, ?, ?, ?, ?, ?, ?)";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBoxPname.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBoxCname.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = AC.currentID;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(comboBoxOquantity.Text);
                                AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerOdate.Text;
                                AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxOcurrency.Text;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                                AC.cmd.CommandText = AC.sql;
                                var rows = AC.cmd.ExecuteNonQuery();
                                if (rows >= 1)
                                {
                                    RefreshLoad();
                                    dstock = stock - int.Parse(comboBoxOquantity.Text);
                                    AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id;";
                                    AC.cmd.Parameters.Clear();
                                    AC.cmd.Parameters.Add("id", OleDbType.Integer).Value = dstock;
                                    AC.cmd.Parameters.Add("id", OleDbType.BigInt).Value = PID;
                                    AC.cmd.CommandText = AC.sql;
                                    var row = AC.cmd.ExecuteNonQuery();
                                    if (row >= 1) RefreshLoad();
                                }
                            }
                            else
                            {
                                MessageBox.Show("在庫数不足のため注文できません、再入荷までしばらくお待ちください。", "在庫不足", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }

                            if (stock <= order_point)
                            {
                                AC.cmd.Parameters.Clear();
                                AC.cmd.CommandText = "select count(*) from 発注テーブル where 商品ID = @id";
                                AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                                AC.rd = AC.cmd.ExecuteReader();

                                if (AC.rd.Read()) answer = int.Parse(AC.rd.GetValue(0).ToString());
                                AC.rd.Close();

                                if (answer >= 1)
                                {
                                }
                                else
                                {
                                    AC.sql = "insert into 発注テーブル(メーカーID, 商品ID, 発注数量, 発注日, ステータス) Values(?, ?, ?, ?, ?)";
                                    AC.cmd.Parameters.Clear();
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = MID;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = PID;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = order_quantity;
                                    AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerOdate.Text;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                                    AC.cmd.CommandText = AC.sql;
                                    AC.cmd.ExecuteNonQuery();
                                }
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
                MessageBox.Show("注文内容は編集できません", "データの追加", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLoad();
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.CurrentRow?.Cells[0].Value.ToString()))
                return;
            try
            {
                var msg = "選択された注文をキャンセルしますか？";
                var caption = "注文のキャンセル";
                var buttons = MessageBoxButtons.YesNo;
                var ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    AC.sql = "update 注文テーブル set ステータス = ? where 注文ID = @id";
                    AC.cmd.Parameters.Clear();
                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                        int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    AC.cmd.CommandText = AC.sql;
                    AC.cmd.ExecuteNonQuery();

                    AC.sql = "select 在庫数 from 在庫テーブル where 商品ID = @id";
                    AC.cmd.Parameters.Clear();
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                        int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    AC.cmd.CommandText = AC.sql;
                    AC.rd = AC.cmd.ExecuteReader();
                    if (AC.rd.Read()) stock = int.Parse(AC.rd.GetValue(0).ToString());
                    AC.rd.Close();

                    AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id";
                    AC.cmd.Parameters.Clear();
                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value =
                        stock + int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                        int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    AC.cmd.CommandText = AC.sql;
                    AC.cmd.ExecuteNonQuery();

                    RefreshLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("注文のキャンセルに失敗しました : " + ex.Message, "注文のキャンセル", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("顧客マスタ", "顧客選択",
                "select 顧客ID, 顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス from 顧客マスタ where ステータス = 0");
            if (GridForm.ShowDialog() == DialogResult.OK)
                try
                {
                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 顧客名 from 顧客マスタ where 顧客ID = ?";
                    AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBoxCname.Text = AC.rd.GetString(0);
                        textBoxCname.Tag = id;
                    }

                    else
                    {
                        return;
                    }

                    AC.rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("顧客名の取得に失敗しました : " + ex.Message, "顧客名の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("商品マスタ", "商品選択",
                "select 商品ID, 商品名, 重量, 口径, 全長, マガジンタイプ, 装弾数, 商品価格 from 商品マスタ where ステータス = 0");
            if (GridForm.ShowDialog() == DialogResult.OK)
                try
                {
                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名, 商品価格, メーカーID from 商品マスタ where 商品ID = ?";
                    AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBoxPname.Text = AC.rd.GetString(0);
                        textBoxPcurrency.Text = AC.rd.GetValue(1).ToString();
                        MID = int.Parse(AC.rd.GetValue(2).ToString());
                        textBoxPname.Tag = id;
                        PID = id;
                    }

                    else
                    {
                        return;
                    }

                    AC.rd.Close();
                    if (textBoxPcurrency.Text != "")
                    {
                        long quantity = long.Parse(comboBoxOquantity.Text);
                        long price = long.Parse(textBoxPcurrency.Text);

                        textBoxOcurrency.Text = (price * quantity).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("商品名の取得に失敗しました : " + ex.Message, "商品名の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (textBoxPcurrency.Text != "")
            {
                long quantity = long.Parse(comboBoxOquantity.Text);
                long price = long.Parse(textBoxPcurrency.Text);

                textBoxOcurrency.Text = (price * quantity).ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RefreshLoad();

                comboBoxOquantity.Enabled = false;
                dateTimePickerOdate.Enabled = false;
                buttonNew.Enabled = false;
                buttonRemove.Enabled = false;
                buttonAdd.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                comboBoxOquantity.Enabled = true;
                dateTimePickerOdate.Enabled = true;
                buttonNew.Enabled = true;
                buttonRemove.Enabled = true;
                buttonAdd.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                RefreshLoad();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                var kw = SearchTextbox.Text;
                AC.sql =
                    $"select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, emp.社員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 社員マスタ as emp on od.社員ID = emp.社員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where (od.注文ID like '%{kw}%' or cus.顧客名 like '%{kw}%' or pd.商品名 like '%{kw}%' or od.注文数量 like '%{kw}%' or od.注文日 like '%{kw}%' or pd.商品価格 like '%{kw}%' or od.合計額 like '%{kw}%' or emp.社員名 like '%{kw}%' or pd.商品ID like '%{kw}%') and od.ステータス = 0";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();
                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                dataGridView1_SelectionChanged(this, EventArgs.Empty);
                if (dataGridView1.CurrentCell == null)
                    MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var kw = SearchTextbox.Text;
                AC.sql =
                    $"select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, emp.社員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 社員マスタ as emp on od.社員ID = emp.社員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where (od.注文ID like '%{kw}%' or cus.顧客名 like '%{kw}%' or pd.商品名 like '%{kw}%' or od.注文数量 like '%{kw}%' or od.注文日 like '%{kw}%' or pd.商品価格 like '%{kw}%' or od.合計額 like '%{kw}%' or emp.社員名 like '%{kw}%' or pd.商品ID like '%{kw}%') and od.ステータス = 1";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();
                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                dataGridView1_SelectionChanged(this, EventArgs.Empty);
                if (dataGridView1.CurrentCell == null) { 
                    MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }
    }
}