using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class LoadedListForm : Form
    {
        private int MID;
        private int PID;
        private int stock;

        public LoadedListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadedListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
            MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.sql =
                "select ld.入庫ID, od.発注ID, pd.商品ID, pd.商品名, od.発注数量 as 入庫数, mk.メーカー名 from ((入庫テーブル as ld inner join 発注テーブル as od on ld.発注ID = od.発注ID) inner join 商品マスタ as pd on ld.商品ID = pd.商品ID) inner join 仕入先マスタ as mk on ld.メーカーID = mk.メーカーID";
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
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
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
            }
        }

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox4.Text.Trim()) || string.IsNullOrEmpty(textBox5.Text.Trim()) ||
                    string.IsNullOrEmpty(textBox6.Text.Trim()))
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
                            AC.sql = "insert into 入庫テーブル(発注ID, 商品ID, メーカーID, 入庫日, 入庫数) Values(?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox2.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox3.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox6.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.ToString("d");
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox5.Text);

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.sql = "update 発注テーブル set ステータス = ? where 発注ID = @id";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 1;
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(textBox2.Text);

                                AC.cmd.CommandText = AC.sql;
                                AC.cmd.ExecuteNonQuery();

                                AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = stock + int.Parse(textBox5.Text);
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(textBox3.Text);

                                AC.cmd.CommandText = AC.sql;
                                AC.cmd.ExecuteNonQuery();

                                RefreshLoad();
                            }
                        }
                        else
                        {
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
                MessageBox.Show("入庫したデータの編集はできません。", "データの編集", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("発注テーブル", "発注情報選択",
                "select od.発注ID, pd.商品名, mk.メーカー名, od.発注数量, od.発注日 from (発注テーブル as od inner join 商品マスタ as pd on od.商品ID = pd.商品ID) inner join 仕入先マスタ as mk on od.メーカーID = mk.メーカーID where od.ステータス = 0");
            if (GridForm.ShowDialog() == DialogResult.OK)
                try
                {
                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカーID, 商品ID, 発注数量 from 発注テーブル where 発注ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        MID = int.Parse(AC.rd.GetValue(0).ToString());
                        textBox6.Tag = MID.ToString();
                        PID = int.Parse(AC.rd.GetValue(1).ToString());
                        textBox3.Text = PID.ToString();
                        textBox5.Text = AC.rd.GetValue(2).ToString();
                        textBox2.Text = id.ToString();
                    }
                    else
                    {
                        return;
                    }

                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名 from 商品マスタ where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                        textBox4.Text = AC.rd.GetString(0);
                    else
                        return;
                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカー名 from 仕入先マスタ where メーカーID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = MID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                        textBox6.Text = AC.rd.GetString(0);
                    else
                        return;
                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 在庫数 from 在庫テーブル where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                        stock = int.Parse(AC.rd.GetValue(0).ToString());
                    else
                        return;
                    AC.rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("発注情報の取得に失敗しました : " + ex.Message, "発注情報の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select ld.入庫ID, od.発注ID, pd.商品ID, pd.商品名, od.発注数量 as 入庫数, mk.メーカー名 from ((入庫テーブル as ld inner join 発注テーブル as od on ld.発注ID = od.発注ID) inner join 商品マスタ as pd on ld.商品ID = pd.商品ID) inner join 仕入先マスタ as mk on ld.メーカーID = mk.メーカーID where (ld.入庫ID like '%{kw}%' or od.発注ID like '%{kw}%' or pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or od.発注数量 like '%{kw}%' or mk.メーカー名 like '%{kw}%')";
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
    }
}