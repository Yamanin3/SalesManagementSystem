using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;
using SalesManagementSystem.Static_Classes;

namespace SalesManagementSystem
{
    public partial class EmployeeListForm : Form
    {
        private double D;
        private int I;
        private long L;

        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.FromArgb(191, 205, 219);
            buttonNew.BackColor = Color.FromArgb(191, 205, 219);
            buttonRemove.BackColor = Color.FromArgb(191, 205, 219);
            buttonRefresh.BackColor = Color.FromArgb(191, 205, 219);
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            comboBoxEsex.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242);
            RefreshLoad();
            MaximizeBox = false;
            dateTimePickerEbirth.MaxDate = DateTime.Now;
        }

        private void RefreshLoad()
        {
            AC.sql = "select 社員ID, 社員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入社日, パスワード from 社員マスタ where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridViewElist.DataSource = AC.dt;

            if (dataGridViewElist.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBoxEID.Text = "";
                textBoxEname.Text = "";
                textBoxEhurigana.Text = "";
                comboBoxEsex.Text = "";
                dateTimePickerEbirth.Text = "";
                textBoxEpost.Text = "";
                textBoxEaddress.Text = "";
                textBoxEphone.Text = "";
                textBoxEmail.Text = "";
                dateTimePickerEjoin.Text = "";
                textBoxEpass.Text = "";
            }
            else
            {
                buttonAdd.Enabled = true;
                dataGridViewElist.CurrentCell = dataGridViewElist.Rows[0].Cells[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridViewElist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewElist.CurrentCell == null)
                {
                    buttonAdd.Enabled = false;
                    textBoxEID.Text = "";
                    textBoxEname.Text = "";
                    textBoxEhurigana.Text = "";
                    comboBoxEsex.Text = "";
                    dateTimePickerEbirth.Text = "";
                    textBoxEpost.Text = "";
                    textBoxEaddress.Text = "";
                    textBoxEphone.Text = "";
                    textBoxEmail.Text = "";
                    dateTimePickerEjoin.Text = "";
                    textBoxEpass.Text = "";
                }
                else if (dataGridViewElist.CurrentRow.Cells[0].Value.ToString() == "")
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "追加";
                    textBoxEpass.Enabled = true;
                    textBoxEID.Text = dataGridViewElist.CurrentRow.Cells[0].Value.ToString();
                    textBoxEname.Text = dataGridViewElist.CurrentRow.Cells[1].Value.ToString();
                    textBoxEhurigana.Text = dataGridViewElist.CurrentRow.Cells[2].Value.ToString();
                    comboBoxEsex.Text = dataGridViewElist.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerEbirth.Text = dataGridViewElist.CurrentRow.Cells[4].Value.ToString();
                    textBoxEpost.Text = dataGridViewElist.CurrentRow.Cells[5].Value.ToString();
                    textBoxEaddress.Text = dataGridViewElist.CurrentRow.Cells[6].Value.ToString();
                    textBoxEphone.Text = dataGridViewElist.CurrentRow.Cells[7].Value.ToString();
                    textBoxEmail.Text = dataGridViewElist.CurrentRow.Cells[8].Value.ToString();
                    dateTimePickerEjoin.Text = dataGridViewElist.CurrentRow.Cells[9].Value.ToString();
                    textBoxEpass.Text = dataGridViewElist.CurrentRow.Cells[10].Value.ToString();
                }
                else
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "編集";
                    textBoxEpass.Enabled = false;
                    textBoxEID.Text = dataGridViewElist.CurrentRow.Cells[0].Value.ToString();
                    textBoxEname.Text = dataGridViewElist.CurrentRow.Cells[1].Value.ToString();
                    textBoxEhurigana.Text = dataGridViewElist.CurrentRow.Cells[2].Value.ToString();
                    comboBoxEsex.Text = dataGridViewElist.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerEbirth.Text = dataGridViewElist.CurrentRow.Cells[4].Value.ToString();
                    textBoxEpost.Text = dataGridViewElist.CurrentRow.Cells[5].Value.ToString();
                    textBoxEaddress.Text = dataGridViewElist.CurrentRow.Cells[6].Value.ToString();
                    textBoxEphone.Text = dataGridViewElist.CurrentRow.Cells[7].Value.ToString();
                    textBoxEmail.Text = dataGridViewElist.CurrentRow.Cells[8].Value.ToString();
                    dateTimePickerEjoin.Text = dataGridViewElist.CurrentRow.Cells[9].Value.ToString();
                    textBoxEpass.Text = dataGridViewElist.CurrentRow.Cells[10].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message, "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonrRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewElist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (dataGridViewElist.CurrentCell == null) return;
            }
            else
            {
                try
                {
                    var msg = "選択された社員を削除しますか？";
                    var caption = "社員の削除";
                    var buttons = MessageBoxButtons.YesNo;
                    var ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {
                        AC.sql = "update 社員マスタ set ステータス = ? where 社員ID = @id";
                        AC.cmd.Parameters.Clear();
                        AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                        AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value =
                            int.Parse(dataGridViewElist.CurrentRow.Cells[0].Value.ToString());
                        AC.cmd.CommandText = AC.sql;
                        AC.cmd.ExecuteNonQuery();

                        RefreshLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("社員の削除に失敗しました : " + ex.Message, "社員の削除", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewElist.SelectedRows.Count <= 0 || dataGridViewElist.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxEname.Text.Trim()) || string.IsNullOrEmpty(textBoxEhurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEpost.Text.Trim()) || string.IsNullOrEmpty(textBoxEaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEphone.Text.Trim()) || string.IsNullOrEmpty(textBoxEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxEsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerEbirth.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEpass.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxEmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEmail.Focus();
                        textBoxEmail.SelectAll();
                        return;
                    }

                    var index = textBoxEmail.Text.IndexOf('@');
                    if (textBoxEmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEmail.Focus();
                        textBoxEmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxEpost.TextLength;
                    var iLengthphone = textBoxEphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEpost.Focus();
                        textBoxEpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEphone.Focus();
                        textBoxEphone.SelectAll();
                        return;
                    }

                    var iLength = textBoxEpass.TextLength;
                    var passwd = textBoxEpass.Text;

                    if (iLength < 8)
                    {
                        MessageBox.Show("パスワードが短すぎます。8文字以上で入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEpass.Focus();
                        textBoxEpass.SelectAll();
                        return;
                    }

                    if (iLength >= 8)
                    {
                        var answer = 0;
                        foreach (var c in passwd)
                        {
                            if (answer == 1) break;
                            if (!char.IsUpper(c))
                            {
                            }
                            else
                            {
                                answer = 1;
                            }
                        }

                        if (answer == 0)
                        {
                            MessageBox.Show("パスワードに大文字が含まれていません。", "データ入力エラー", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            textBoxEpass.Focus();
                            textBoxEpass.SelectAll();
                            return;
                        }
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
                                "insert into 社員マスタ(社員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入社日, パスワード, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEhurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxEsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerEbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEmail.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerEjoin.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = Sha256hash.ToHash(textBoxEpass.Text);
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
                if (string.IsNullOrEmpty(textBoxEname.Text.Trim()) || string.IsNullOrEmpty(textBoxEhurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEpost.Text.Trim()) || string.IsNullOrEmpty(textBoxEaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEphone.Text.Trim()) || string.IsNullOrEmpty(textBoxEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxEsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerEbirth.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxEpass.Text.Trim()) || string.IsNullOrEmpty(textBoxEpass.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxEmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEmail.Focus();
                        textBoxEmail.SelectAll();
                        return;
                    }

                    var index = textBoxEmail.Text.IndexOf('@');
                    if (textBoxEmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEmail.Focus();
                        textBoxEmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxEpost.TextLength;
                    var iLengthphone = textBoxEphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEpost.Focus();
                        textBoxEpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEphone.Focus();
                        textBoxEphone.SelectAll();
                        return;
                    }


                    var iLength = textBoxEpass.TextLength;
                    var passwd = textBoxEpass.Text;

                    if (iLength < 8)
                    {
                        MessageBox.Show("パスワードが短すぎます。8文字以上で入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxEpass.Focus();
                        textBoxEpass.SelectAll();
                        return;
                    }

                    if (iLength >= 8)
                    {
                        var answer = 0;
                        foreach (var c in passwd)
                        {
                            if (answer == 1) break;
                            if (!char.IsUpper(c))
                            {
                            }
                            else
                            {
                                answer = 1;
                            }
                        }

                        if (answer == 0)
                        {
                            MessageBox.Show("パスワードに大文字が含まれていません。", "データ入力エラー", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            textBoxEpass.Focus();
                            textBoxEpass.SelectAll();
                            return;
                        }
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
                            var id = int.Parse(dataGridViewElist.CurrentRow.Cells[0].Value.ToString());
                            AC.sql =
                                "update 社員マスタ set 社員名 = ?, ふりがな = ?, 性別 = ?, 生年月日 = ?, 郵便番号 = ?, 住所 = ?, 電話番号 = ?, メールアドレス = ?, 入社日 = ? where 社員ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEhurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxEsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerEbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxEmail.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerEjoin.Text;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEpost.Text) && int.TryParse(textBoxEpost.Text, out I) != true)
            {
                textBoxEpost.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            long L;
            if (!string.IsNullOrEmpty(textBoxEphone.Text) && long.TryParse(textBoxEphone.Text, out L) != true)
            {
                textBoxEphone.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select 社員ID, 社員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入社日, パスワード from 社員マスタ where (社員ID like '%{kw}%' or 社員名 like '%{kw}%' or ふりがな like '%{kw}%' or 性別 like '%{kw}%' or 生年月日 like '%{kw}%' or 郵便番号 like '%{kw}%' or 住所 like '%{kw}%' or 電話番号 like '%{kw}%' or メールアドレス like '%{kw}%' or 入社日 like '%{kw}%') and ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridViewElist.DataSource = AC.dt;
            dataGridViewElist_SelectionChanged(this, EventArgs.Empty);
            if (dataGridViewElist.CurrentCell == null)
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
            dataGridViewElist.CurrentCell = dataGridViewElist.Rows[dataGridViewElist.Rows.Count - 1].Cells[0];
            dataGridViewElist_SelectionChanged(this, EventArgs.Empty);
        }
    }
}