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
        private int stock;
        private int dstock;
        private int PID;
        private int MID;
        private int answer;
        private int order_quantity = 50;
        private int order_point;

        public On_orderListForm()
        {
            InitializeComponent();
        }

        private void RefreshLoad()
        {
            if (checkBox1.Checked == false)
            {
                AC.sql = "select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, mem.会員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 会員マスタ as mem on od.会員ID = mem.会員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where od.ステータス = 0";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();

                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                dataGridView1.Columns[8].Visible = false;
                if (dataGridView1.SelectedRows.Count <= 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                }
                else
                {
                    // datagridview1の最上段にカーソルを当てる
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
            }
            else
            {
                AC.sql = "select od.注文ID, cus.顧客名, pd.商品名, od.注文数量, od.注文日, pd.商品価格, od.合計額, mem.会員名, pd.商品ID from ((注文テーブル as od inner join 顧客マスタ as cus on od.顧客ID = cus.顧客ID) inner join 会員マスタ as mem on od.会員ID = mem.会員ID) inner join 商品マスタ as pd on od.商品ID = pd.商品ID where od.ステータス = 1";
                AC.cmd.CommandText = AC.sql;
                AC.da = new OleDbDataAdapter(AC.cmd);
                AC.dt = new DataTable();

                AC.da.Fill(AC.dt);
                dataGridView1.DataSource = AC.dt;
                dataGridView1.Columns[8].Visible = false;
                if (dataGridView1.SelectedRows.Count <= 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                }
                else
                {
                    // datagridview1の最上段にカーソルを当てる
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
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
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // 追加ボタンクリック後の処理////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())))
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

                            if (stock >= int.Parse(comboBox1.Text))
                            {

                                AC.sql = "insert into 注文テーブル(商品ID, 顧客ID, 会員ID, 注文数量, 注文日, 合計額, ステータス) Values(?, ?, ?, ?, ?, ?, ?)";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBox3.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBox2.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBox7.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(comboBox1.Text);
                                AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                                AC.cmd.Parameters.Add("?", OleDbType.Currency).Value = textBox6.Text;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                                AC.cmd.CommandText = AC.sql;
                                int rows = AC.cmd.ExecuteNonQuery();
                                if (rows >= 1)
                                {
                                    RefreshLoad();
                                    dstock = stock - int.Parse(comboBox1.Text);
                                    AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id;";
                                    AC.cmd.Parameters.Clear();
                                    AC.cmd.Parameters.Add("id", OleDbType.Integer).Value = dstock;
                                    AC.cmd.Parameters.Add("id", OleDbType.BigInt).Value = PID;
                                    AC.cmd.CommandText = AC.sql;
                                    int row = AC.cmd.ExecuteNonQuery();
                                    if (row >= 1)
                                    {
                                        RefreshLoad();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("在庫数不足のため注文できません、再入荷までしばらくお待ちください。", "在庫不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            if (stock <= order_point)
                            {
                                AC.cmd.Parameters.Clear();
                                AC.cmd.CommandText = "select count(*) from 発注テーブル where 商品ID = @id";
                                AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                                AC.rd = AC.cmd.ExecuteReader();

                                if (AC.rd.Read())
                                {
                                    answer = int.Parse(AC.rd.GetValue(0).ToString());

                                }
                                AC.rd.Close();

                                if (answer >= 1)
                                {
                                    return;
                                }
                                else
                                {
                                    AC.sql = "insert into 発注テーブル(メーカーID, 商品ID, 発注数量, 発注日, ステータス) Values(?, ?, ?, ?, ?)";
                                    AC.cmd.Parameters.Clear();
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = MID;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = PID;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = order_quantity;
                                    AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                                    AC.cmd.CommandText = AC.sql;
                                    AC.cmd.ExecuteNonQuery();
                                }
                            }
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
                
                MessageBox.Show("注文内容は編集できません", "データの追加", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                    string msg = "選択された注文をキャンセルしますか？";
                    string caption = "注文のキャンセル";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {
                        AC.sql = "update 注文テーブル set ステータス = ? where 注文ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.cmd.ExecuteNonQuery();

                        AC.sql = "select 在庫数 from 在庫テーブル where 商品ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.rd = AC.cmd.ExecuteReader();
                        if (AC.rd.Read())
                        { stock = int.Parse(AC.rd.GetValue(0).ToString()); }
                        AC.rd.Close(); 

                        AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = (stock + int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.cmd.ExecuteNonQuery();

                        RefreshLoad();
                }
                    else {return;}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("注文のキャンセルに失敗しました : " + ex.Message.ToString(), "注文のキャンセル", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void On_orderListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("顧客マスタ", "顧客選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 顧客名 from 顧客マスタ where 顧客ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox2.Text = AC.rd.GetString(0);
                        textBox2.Tag = id;
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("顧客名の取得に失敗しました : " + ex.Message.ToString(), "顧客名の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("商品マスタ", "商品選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名, 商品価格, メーカーID from 商品マスタ where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox3.Text = AC.rd.GetString(0);
                        textBox5.Text = AC.rd.GetValue(1).ToString();
                        MID = int.Parse(AC.rd.GetValue(2).ToString());
                        textBox3.Tag = id;
                        PID = id;
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("商品名の取得に失敗しました : " + ex.Message.ToString(), "商品名の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("会員マスタ", "担当者選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 会員名 from 会員マスタ where 会員ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox7.Text = AC.rd.GetString(0);
                        textBox7.Tag = id;
                    }

                    else
                    {
                        return;
                    }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("担当者の取得に失敗しました : " + ex.Message.ToString(), "担当者の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "") {

                double quantity = double.Parse(comboBox1.Text);
                double price = double.Parse(textBox5.Text);

                textBox6.Text = (price * quantity).ToString();
            }
            else {
                return;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RefreshLoad();
                
                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                toolStripButtonNew.Enabled = false;
                toolStripButtonRemove.Enabled = false;
                buttonAdd.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
                toolStripButtonNew.Enabled = true;
                toolStripButtonRemove.Enabled = true;
                buttonAdd.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                RefreshLoad();
            }
        }
    }
}
