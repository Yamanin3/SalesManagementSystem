using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class CustomerListForm : Form
    {
        private int I;
        private long L;

        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
            MaximizeBox = false;
            dateTimePickerCbirth.MaxDate = DateTime.Now;
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRemove.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            comboBoxCsex.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new MainMenuForm();
            Close();
        }

        private void dataGridViewClist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClist.CurrentCell == null)
                {
                    buttonAdd.Enabled = false;
                    textBoxCID.Text = "";
                    textBoxCname.Text = "";
                    textBoxChurigana.Text = "";
                    comboBoxCsex.Text = "";
                    dateTimePickerCbirth.Text = "";
                    textBoxCpost.Text = "";
                    textBoxCaddress.Text = "";
                    textBoxCphone.Text = "";
                    textBoxCmail.Text = "";
                }
                else if (dataGridViewClist.CurrentRow.Cells[0].Value.ToString() == "")
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "追加";
                    textBoxCID.Text = dataGridViewClist.CurrentRow.Cells[0].Value.ToString();
                    textBoxCname.Text = dataGridViewClist.CurrentRow.Cells[1].Value.ToString();
                    textBoxChurigana.Text = dataGridViewClist.CurrentRow.Cells[2].Value.ToString();
                    comboBoxCsex.Text = dataGridViewClist.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerCbirth.Text = dataGridViewClist.CurrentRow.Cells[4].Value.ToString();
                    textBoxCpost.Text = dataGridViewClist.CurrentRow.Cells[5].Value.ToString();
                    textBoxCaddress.Text = dataGridViewClist.CurrentRow.Cells[6].Value.ToString();
                    textBoxCphone.Text = dataGridViewClist.CurrentRow.Cells[7].Value.ToString();
                    textBoxCmail.Text = dataGridViewClist.CurrentRow.Cells[8].Value.ToString();
                }
                else
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "編集";
                    textBoxCID.Text = dataGridViewClist.CurrentRow.Cells[0].Value.ToString();
                    textBoxCname.Text = dataGridViewClist.CurrentRow.Cells[1].Value.ToString();
                    textBoxChurigana.Text = dataGridViewClist.CurrentRow.Cells[2].Value.ToString();
                    comboBoxCsex.Text = dataGridViewClist.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerCbirth.Text = dataGridViewClist.CurrentRow.Cells[4].Value.ToString();
                    textBoxCpost.Text = dataGridViewClist.CurrentRow.Cells[5].Value.ToString();
                    textBoxCaddress.Text = dataGridViewClist.CurrentRow.Cells[6].Value.ToString();
                    textBoxCphone.Text = dataGridViewClist.CurrentRow.Cells[7].Value.ToString();
                    textBoxCmail.Text = dataGridViewClist.CurrentRow.Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message, "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewClist.SelectedRows.Count <= 0 || dataGridViewClist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxCname.Text.Trim()) || string.IsNullOrEmpty(textBoxChurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCpost.Text.Trim()) || string.IsNullOrEmpty(textBoxCaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCphone.Text.Trim()) || string.IsNullOrEmpty(textBoxCmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxCsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerCbirth.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxCmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCmail.Focus();
                        textBoxCmail.SelectAll();
                        return;
                    }

                    var index = textBoxCmail.Text.IndexOf('@');
                    if (textBoxCmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCmail.Focus();
                        textBoxCmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxCpost.TextLength;
                    var iLengthphone = textBoxCphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCpost.Focus();
                        textBoxCpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCphone.Focus();
                        textBoxCphone.SelectAll();
                        return;
                    }

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
                                "insert into 顧客マスタ(顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxChurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxCsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerCbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCmail.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            var rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1) RefreshLoad();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの追加に失敗しました: " + ex.Message, "データの追加", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxCname.Text.Trim()) || string.IsNullOrEmpty(textBoxChurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCpost.Text.Trim()) || string.IsNullOrEmpty(textBoxCaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCphone.Text.Trim()) || string.IsNullOrEmpty(textBoxCmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxCsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerCbirth.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxCmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCmail.Focus();
                        textBoxCmail.SelectAll();
                        return;
                    }

                    var index = textBoxCmail.Text.IndexOf('@');
                    if (textBoxCmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCmail.Focus();
                        textBoxCmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxCpost.TextLength;
                    var iLengthphone = textBoxCphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCpost.Focus();
                        textBoxCpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxCphone.Focus();
                        textBoxCphone.SelectAll();
                        return;
                    }

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
                            var id = int.Parse(dataGridViewClist.CurrentRow.Cells[0].Value.ToString());
                            AC.sql =
                                "update 顧客マスタ set 顧客名 = ?, ふりがな = ?, 性別 = ?, 生年月日 = ?, 郵便番号 = ?, 住所 = ?, 電話番号 = ?, メールアドレス = ? where 顧客ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxChurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxCsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerCbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxCmail.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;

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
        }

        private void buttonrRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewClist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (dataGridViewClist.CurrentCell == null) return;
            }
            else
            {
                try
                {
                    var msg = "選択された顧客を削除しますか？";
                    var caption = "顧客の削除";
                    var buttons = MessageBoxButtons.YesNo;
                    var ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {
                        AC.sql = "update 顧客マスタ set ステータス = ? where 顧客ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                            int.Parse(dataGridViewClist.CurrentRow.Cells[0].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.cmd.ExecuteNonQuery();

                        RefreshLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("顧客の削除に失敗しました : " + ex.Message, "顧客の削除", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshLoad()
        {
            AC.sql = "select 顧客ID, 顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス from 顧客マスタ where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridViewClist.DataSource = AC.dt;

            if (dataGridViewClist.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBoxCID.Text = "";
                textBoxCname.Text = "";
                textBoxChurigana.Text = "";
                comboBoxCsex.Text = "";
                dateTimePickerCbirth.Text = "";
                textBoxCpost.Text = "";
                textBoxCaddress.Text = "";
                textBoxCphone.Text = "";
                textBoxCmail.Text = "";
            }
            else
            {
                buttonAdd.Enabled = true;
                dataGridViewClist.CurrentCell = dataGridViewClist.Rows[0].Cells[0];
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCphone.Text) && long.TryParse(textBoxCphone.Text, out L) != true)
            {
                textBoxCphone.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCpost.Text) && int.TryParse(textBoxCpost.Text, out I) != true)
            {
                textBoxCpost.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select 顧客ID, 顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス from 顧客マスタ where (顧客ID like '%{kw}%' or 顧客名 like '%{kw}%' or ふりがな like '%{kw}%' or 性別 like '%{kw}%' or 生年月日 like '%{kw}%' or 郵便番号 like '%{kw}%' or 住所 like '%{kw}%' or 電話番号 like '%{kw}%' or メールアドレス like '%{kw}%') and ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridViewClist.DataSource = AC.dt;
            dataGridViewClist_SelectionChanged(this, EventArgs.Empty);
            if (dataGridViewClist.CurrentCell == null) 
                MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridViewClist.CurrentCell = dataGridViewClist.Rows[dataGridViewClist.Rows.Count - 1].Cells[0];
            dataGridViewClist_SelectionChanged(this, EventArgs.Empty);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void dataGridViewClist_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = AC.dt.Rows[e.RowIndex][e.ColumnIndex];
        }
    }
}