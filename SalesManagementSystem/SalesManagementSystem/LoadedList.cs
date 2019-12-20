using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            buttonOid.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
            RefreshLoad();
            dataGridViewLlist_SelectionChanged(this, EventArgs.Empty);
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
            dataGridViewLlist.DataSource = AC.dt;

            if (dataGridViewLlist.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBoxLID.Text = "";
                textBoxRID.Text = "";
                textBoxPID.Text = "";
                textBoxPname.Text = "";
                textBoxLquantity.Text = "";
                textBoxMname.Text = "";
            }
            else
            {
                dataGridViewLlist.CurrentCell = dataGridViewLlist.Rows[0].Cells[0];
            }
            dataGridViewLlist_SelectionChanged(this, EventArgs.Empty);
        }

        private void dataGridViewLlist_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLlist.CurrentCell == null)
            {
                buttonAdd.Enabled = false;
                buttonOid.Enabled = false;
                textBoxLID.Text = "";
                textBoxRID.Text = "";
                textBoxPID.Text = "";
                textBoxPname.Text = "";
                textBoxLquantity.Text = "";
                textBoxMname.Text = "";
            }
            else if (dataGridViewLlist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                buttonAdd.Enabled = true;
                buttonAdd.Text = "追加";
                buttonOid.Enabled = true;
                textBoxLID.Text = dataGridViewLlist.CurrentRow.Cells[0].Value.ToString();
                textBoxRID.Text = dataGridViewLlist.CurrentRow.Cells[1].Value.ToString();
                textBoxPID.Text = dataGridViewLlist.CurrentRow.Cells[2].Value.ToString();
                textBoxPname.Text = dataGridViewLlist.CurrentRow.Cells[3].Value.ToString();
                textBoxLquantity.Text = dataGridViewLlist.CurrentRow.Cells[4].Value.ToString();
                textBoxMname.Text = dataGridViewLlist.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonAdd.Text = "編集";
                buttonOid.Enabled = false;
                textBoxLID.Text = dataGridViewLlist.CurrentRow.Cells[0].Value.ToString();
                textBoxRID.Text = dataGridViewLlist.CurrentRow.Cells[1].Value.ToString();
                textBoxPID.Text = dataGridViewLlist.CurrentRow.Cells[2].Value.ToString();
                textBoxPname.Text = dataGridViewLlist.CurrentRow.Cells[3].Value.ToString();
                textBoxLquantity.Text = dataGridViewLlist.CurrentRow.Cells[4].Value.ToString();
                textBoxMname.Text = dataGridViewLlist.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewLlist.SelectedRows.Count <= 0 || dataGridViewLlist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxRID.Text.Trim()) || string.IsNullOrEmpty(textBoxPID.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPname.Text.Trim()) || string.IsNullOrEmpty(textBoxLquantity.Text.Trim()) ||
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
                            AC.sql = "insert into 入庫テーブル(発注ID, 商品ID, メーカーID, 入庫日, 入庫数) Values(?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxRID.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxPID.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBoxMname.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.ToString("d");
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxLquantity.Text);

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.sql = "update 発注テーブル set ステータス = ? where 発注ID = @id";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 1;
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(textBoxRID.Text);

                                AC.cmd.CommandText = AC.sql;
                                AC.cmd.ExecuteNonQuery();

                                AC.sql = "update 在庫テーブル set 在庫数 = ? where 商品ID = @id";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = stock + int.Parse(textBoxLquantity.Text);
                                AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(textBoxPID.Text);

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
                        textBoxMname.Tag = MID.ToString();
                        PID = int.Parse(AC.rd.GetValue(1).ToString());
                        textBoxPID.Text = PID.ToString();
                        textBoxLquantity.Text = AC.rd.GetValue(2).ToString();
                        textBoxRID.Text = id.ToString();
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
                        textBoxPname.Text = AC.rd.GetString(0);
                    else
                        return;
                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカー名 from 仕入先マスタ where メーカーID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = MID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                        textBoxMname.Text = AC.rd.GetString(0);
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
            dataGridViewLlist.DataSource = AC.dt;
            dataGridViewLlist_SelectionChanged(this, EventArgs.Empty);
            if (dataGridViewLlist.CurrentCell == null)
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
            dataGridViewLlist.CurrentCell = dataGridViewLlist.Rows[dataGridViewLlist.Rows.Count - 1].Cells[0];
            dataGridViewLlist_SelectionChanged(this, EventArgs.Empty);
        }

        private void dataGridViewLlist_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = AC.dt.Rows[e.RowIndex][e.ColumnIndex];
        }
    }
}