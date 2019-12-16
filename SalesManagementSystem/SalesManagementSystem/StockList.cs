using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

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
            Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void StockListForm_Load(object sender, EventArgs e)
        {
            buttonSet.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
            RefreshLoad();
            dataGridViewSTlist_SelectionChanged(this, EventArgs.Empty);
            MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.sql =
                "select st.在庫ID, pd.商品ID, pd.商品名, st.在庫数, st.発注点 from 在庫テーブル as st right outer join 商品マスタ as pd on st.商品ID = pd.商品ID where pd.ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridViewSTlist.DataSource = AC.dt;
            dataGridViewSTlist.Columns[0].Visible = false;

            if (dataGridViewSTlist.SelectedRows.Count <= 0)
            {
                buttonSet.Enabled = false;
                textBoxPID.Text = "";
                textBoxPname.Text = "";
                textBoxStstock.Text = "0";
                textBoxStpoint.Text = "";
            }
            else
            {
                buttonSet.Enabled = true;
                // datagridview1の最上段にカーソルを当てる
                dataGridViewSTlist.CurrentCell = dataGridViewSTlist.Rows[0].Cells[1];
            }
        }

        private void dataGridViewSTlist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSTlist.CurrentCell == null)
                {
                    textBoxPID.Text = "";
                    textBoxPname.Text = "";
                    textBoxStstock.Text = "";
                    textBoxStpoint.Text = "";
                    buttonSet.Enabled = false;
                    textBoxStpoint.Enabled = false;
                }
                else
                {
                    buttonSet.Enabled = true;
                    textBoxStpoint.Enabled = true;
                    textBoxPID.Text = dataGridViewSTlist.CurrentRow.Cells[1].Value.ToString();
                    textBoxPname.Text = dataGridViewSTlist.CurrentRow.Cells[2].Value.ToString();
                    if (dataGridViewSTlist.CurrentRow.Cells[3].Value.ToString() == "")
                        textBoxStstock.Text = "0";
                    else
                        textBoxStstock.Text = dataGridViewSTlist.CurrentRow.Cells[3].Value.ToString();
                    textBoxStpoint.Text = dataGridViewSTlist.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message, "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewSTlist.SelectedRows.Count <= 0 || dataGridViewSTlist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxStpoint.Text.Trim()))
                {
                    MessageBox.Show("発注点を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxStpoint.Focus();
                    textBoxStpoint.SelectAll();
                }
                else if (textBoxStpoint.Text == "0")
                {
                    MessageBox.Show("発注点に\"0\"は設定できません", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxStpoint.Focus();
                    textBoxStpoint.SelectAll();
                }
                else
                {
                    try
                    {
                        var msg = "商品に発注点を設定しますか？";
                        var caption = "発注点の設定";
                        var buttons = MessageBoxButtons.YesNo;
                        var ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {
                            AC.sql = "insert into 在庫テーブル(商品ID, 在庫数, 発注点) Values(?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBoxPID.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxStstock.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxStpoint.Text);


                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1) RefreshLoad();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("発注点の設定に失敗しました: " + ex.Message, "発注点の設定", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxStpoint.Text.Trim()))
                    MessageBox.Show("発注点を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    try
                    {
                        var msg = "発注点の編集を反映しますか？";
                        var caption = "発注点の編集";
                        var buttons = MessageBoxButtons.YesNo;
                        var ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {
                            var id = int.Parse(dataGridViewSTlist.CurrentRow.Cells[0].Value.ToString());
                            AC.sql = "update 在庫テーブル set 商品ID = ?, 在庫数 = ?, 発注点 = ? where 在庫ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBoxPID.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxStstock.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxStpoint.Text);
                            AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1) RefreshLoad();
                        }
                        else
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの編集に失敗しました: " + ex.Message, "データの編集", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
            if (!string.IsNullOrEmpty(textBoxStpoint.Text) && int.TryParse(textBoxStpoint.Text, out I) != true)
            {
                textBoxStpoint.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select st.在庫ID, pd.商品ID, pd.商品名, st.在庫数, st.発注点 from 在庫テーブル as st right outer join 商品マスタ as pd on st.商品ID = pd.商品ID where (st.在庫ID like '%{kw}%' or pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or st.在庫数 like '%{kw}%' or st.発注点 like '%{kw}%') and ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridViewSTlist.DataSource = AC.dt;
            dataGridViewSTlist_SelectionChanged(this, EventArgs.Empty);
            if (dataGridViewSTlist.CurrentCell == null)
                MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }

    }
}