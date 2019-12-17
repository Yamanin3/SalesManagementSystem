using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class ProductListForm : Form
    {
        private double D;
        private int I;
        private long L;
        private int PID;

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRemove.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            buttonPmaker.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242); RefreshLoad();
            MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.sql =
                "select pd.商品ID, pd.商品名, pd.重量, pd.口径, pd.全長, pd.マガジンタイプ, pd.装弾数, mk.メーカー名, pd.商品価格, mk.メーカーID from 商品マスタ as pd inner join 仕入先マスタ as mk on pd.メーカーID = mk.メーカーID where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridViewPlist.DataSource = AC.dt;

            if (dataGridViewPlist.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBoxPid.Text = "";
                textBoxPname.Text = "";
                textBoxPweight.Text = "";
                textBoxPcaliber.Text = "";
                textBoxPlength.Text = "";
                textBoxPcapa.Text = "";
                textBoxMname.Text = "";
                textBoxPcurrency.Text = "";
                comboBoxPmagazine.Text = "";
            }
            else
            {
                buttonAdd.Enabled = true;
                // datagridview1の最上段にカーソルを当てる
                dataGridViewPlist.CurrentCell = dataGridViewPlist.Rows[0].Cells[0];
            }
        }

        private void dataGridViewPlist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPlist.CurrentCell == null)
                {
                    buttonAdd.Enabled = false;
                    textBoxPid.Text = "";
                    textBoxPname.Text = "";
                    textBoxPweight.Text = "";
                    textBoxPcaliber.Text = "";
                    textBoxPlength.Text = "";
                    textBoxPcapa.Text = "";
                    textBoxMname.Text = "";
                    textBoxPcurrency.Text = "";
                    comboBoxPmagazine.Text = "";
                }
                else if (dataGridViewPlist.CurrentRow.Cells[0].Value.ToString() == "")
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "追加";
                    textBoxPid.Text = dataGridViewPlist.CurrentRow.Cells[0].Value.ToString();
                    textBoxPname.Text = dataGridViewPlist.CurrentRow.Cells[1].Value.ToString();
                    textBoxPweight.Text = dataGridViewPlist.CurrentRow.Cells[2].Value.ToString();
                    textBoxPcaliber.Text = dataGridViewPlist.CurrentRow.Cells[3].Value.ToString();
                    textBoxPlength.Text = dataGridViewPlist.CurrentRow.Cells[4].Value.ToString();
                    comboBoxPmagazine.Text = dataGridViewPlist.CurrentRow.Cells[5].Value.ToString();
                    textBoxPcapa.Text = dataGridViewPlist.CurrentRow.Cells[6].Value.ToString();
                    textBoxMname.Text = dataGridViewPlist.CurrentRow.Cells[7].Value.ToString();
                    textBoxPcurrency.Text = dataGridViewPlist.CurrentRow.Cells[8].Value.ToString();
                    textBoxMname.Tag = dataGridViewPlist.CurrentRow.Cells[9].Value.ToString();
                }
                else
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "編集";
                    textBoxPid.Text = dataGridViewPlist.CurrentRow.Cells[0].Value.ToString();
                    textBoxPname.Text = dataGridViewPlist.CurrentRow.Cells[1].Value.ToString();
                    textBoxPweight.Text = dataGridViewPlist.CurrentRow.Cells[2].Value.ToString();
                    textBoxPcaliber.Text = dataGridViewPlist.CurrentRow.Cells[3].Value.ToString();
                    textBoxPlength.Text = dataGridViewPlist.CurrentRow.Cells[4].Value.ToString();
                    comboBoxPmagazine.Text = dataGridViewPlist.CurrentRow.Cells[5].Value.ToString();
                    textBoxPcapa.Text = dataGridViewPlist.CurrentRow.Cells[6].Value.ToString();
                    textBoxMname.Text = dataGridViewPlist.CurrentRow.Cells[7].Value.ToString();
                    textBoxPcurrency.Text = dataGridViewPlist.CurrentRow.Cells[8].Value.ToString();
                    textBoxMname.Tag = dataGridViewPlist.CurrentRow.Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message, "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlist.SelectedRows.Count <= 0 || dataGridViewPlist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxPname.Text.Trim()) || string.IsNullOrEmpty(textBoxPweight.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcaliber.Text.Trim()) || string.IsNullOrEmpty(textBoxPlength.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcapa.Text.Trim()) || string.IsNullOrEmpty(textBoxMname.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcurrency.Text.Trim()) || string.IsNullOrEmpty(comboBoxPmagazine.Text.Trim()))
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
                            AC.sql =
                                "insert into 商品マスタ(メーカーID, 商品名, 重量, 口径, 全長, マガジンタイプ, 装弾数, 商品価格, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBoxMname.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPweight.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPcaliber.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxPlength.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxPmagazine.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxPcapa.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPcurrency.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.sql = "select top 1 商品ID from 商品マスタ order by 商品ID desc";
                                AC.cmd.CommandText = AC.sql;
                                AC.cmd.Parameters.Clear();
                                AC.rd = AC.cmd.ExecuteReader();
                                if (AC.rd.Read()) PID = int.Parse(AC.rd.GetValue(0).ToString());
                                AC.rd.Close();

                                AC.sql = "insert into 在庫テーブル(商品ID, 在庫数, 発注点) Values(?, ?, ?)";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = PID;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 40;
                                AC.cmd.CommandText = AC.sql;
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
                if (string.IsNullOrEmpty(textBoxPname.Text.Trim()) || string.IsNullOrEmpty(textBoxPweight.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcaliber.Text.Trim()) || string.IsNullOrEmpty(textBoxPlength.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcapa.Text.Trim()) || string.IsNullOrEmpty(textBoxMname.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPcurrency.Text.Trim()) || string.IsNullOrEmpty(comboBoxPmagazine.Text.Trim()))
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    try
                    {
                        var msg = "データの編集を反映しますか？";
                        var caption = "データの編集";
                        var buttons = MessageBoxButtons.YesNo;
                        var ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {
                            var id = int.Parse(dataGridViewPlist.CurrentRow.Cells[0].Value.ToString());
                            AC.sql =
                                "update 商品マスタ set メーカーID = ?, 商品名 = ?, 重量 = ?, 口径 = ?, 全長 = ?, マガジンタイプ = ?, 装弾数 = ?, 商品価格 = ? where 商品ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = int.Parse(textBoxMname.Tag.ToString());
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPweight.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPcaliber.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxPlength.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxPmagazine.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBoxPcapa.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxPcurrency.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1) RefreshLoad();
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
            var GridForm = new GridForm("仕入先マスタ", "メーカー選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
                try
                {
                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカー名 from 仕入先マスタ where メーカーID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBoxMname.Text = AC.rd.GetString(0);
                        textBoxMname.Tag = id;
                    }

                    else
                    {
                        return;
                    }

                    AC.rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("メーカー名の取得に失敗しました : " + ex.Message, "メーカー名の取得", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPcurrency.Text) && int.TryParse(textBoxPcurrency.Text, out I) != true)
            {
                textBoxPcurrency.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPcapa.Text) && int.TryParse(textBoxPcapa.Text, out I) != true)
            {
                textBoxPcapa.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPcaliber.Text) && double.TryParse(textBoxPcaliber.Text, out D) != true)
            {
                textBoxPcaliber.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPweight.Text) && double.TryParse(textBoxPweight.Text, out D) != true)
            {
                textBoxPweight.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPlength.Text) && double.TryParse(textBoxPlength.Text, out D) != true)
            {
                textBoxPlength.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonrRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (dataGridViewPlist.CurrentCell == null) return;
            }
            else
            {
                try
                {
                    var msg = "データを削除しますか？";
                    var caption = "データの削除";
                    var buttons = MessageBoxButtons.YesNo;
                    var ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {
                        AC.sql = "update 商品マスタ set ステータス = ? where 商品ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                            int.Parse(dataGridViewPlist.CurrentRow.Cells[0].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.cmd.ExecuteNonQuery();
                        RefreshLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("データの削除に失敗しました" + ex.Message, "データの削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select pd.商品ID, pd.商品名, pd.重量, pd.口径, pd.全長, pd.マガジンタイプ, pd.装弾数, mk.メーカー名, pd.商品価格, mk.メーカーID from 商品マスタ as pd inner join 仕入先マスタ as mk on pd.メーカーID = mk.メーカーID where (pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or pd.重量 like '%{kw}%' or pd.口径 like '%{kw}%' or pd.全長 like '%{kw}%' or pd.マガジンタイプ like '%{kw}%' or pd.装弾数 like '%{kw}%' or mk.メーカー名 like '%{kw}%' or pd.商品価格 like '%{kw}%') and ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridViewPlist.DataSource = AC.dt;
            dataGridViewPlist_SelectionChanged(this, EventArgs.Empty);
            if (dataGridViewPlist.CurrentCell == null)
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
            dataGridViewPlist.CurrentCell = dataGridViewPlist.Rows[dataGridViewPlist.Rows.Count - 1].Cells[0];
            dataGridViewPlist_SelectionChanged(this, EventArgs.Empty);
        }

    }
}