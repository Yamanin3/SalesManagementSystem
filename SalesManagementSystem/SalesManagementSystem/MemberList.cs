using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;
using SalesManagementSystem.Static_Classes;

namespace SalesManagementSystem
{
    public partial class MemberListForm : Form
    {
        private double D;
        private int I;
        private long L;

        public MemberListForm()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(236, 233, 216);
            RefreshLoad();
            MaximizeBox = false;
            dateTimePickerMbirth.MaxDate = DateTime.Now;
        }

        private void RefreshLoad()
        {
            AC.sql = "select 社員ID, 社員名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, 入社日, パスワード from 社員マスタ where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                buttonAdd.Enabled = false;
                textBoxMID.Text = "";
                textBoxMname.Text = "";
                textBoxMhurigana.Text = "";
                comboBoxMsex.Text = "";
                dateTimePickerMbirth.Text = "";
                textBoxMpost.Text = "";
                textBoxMaddress.Text = "";
                textBoxMphone.Text = "";
                textBoxMmail.Text = "";
                dateTimePickerMjoin.Text = "";
                textBoxMpass.Text = "";
            }
            else
            {
                buttonAdd.Enabled = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    buttonAdd.Enabled = false;
                    textBoxMID.Text = "";
                    textBoxMname.Text = "";
                    textBoxMhurigana.Text = "";
                    comboBoxMsex.Text = "";
                    dateTimePickerMbirth.Text = "";
                    textBoxMpost.Text = "";
                    textBoxMaddress.Text = "";
                    textBoxMphone.Text = "";
                    textBoxMmail.Text = "";
                    dateTimePickerMjoin.Text = "";
                    textBoxMpass.Text = "";
                }
                else if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "追加";
                    textBoxMpass.Enabled = true;
                    textBoxMID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBoxMname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBoxMhurigana.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    comboBoxMsex.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerMbirth.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    textBoxMpost.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBoxMaddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBoxMphone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBoxMmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    dateTimePickerMjoin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    textBoxMpass.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                }
                else
                {
                    buttonAdd.Enabled = true;
                    buttonAdd.Text = "編集";
                    textBoxMpass.Enabled = false;
                    textBoxMID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBoxMname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBoxMhurigana.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    comboBoxMsex.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerMbirth.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    textBoxMpost.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBoxMaddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBoxMphone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBoxMmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    dateTimePickerMjoin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    textBoxMpass.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message, "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonrRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (dataGridView1.CurrentCell == null) return;
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
                            int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(textBoxMname.Text.Trim()) || string.IsNullOrEmpty(textBoxMhurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMpost.Text.Trim()) || string.IsNullOrEmpty(textBoxMaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMphone.Text.Trim()) || string.IsNullOrEmpty(textBoxMmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxMsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerMbirth.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMpass.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxMmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMmail.Focus();
                        textBoxMmail.SelectAll();
                        return;
                    }

                    var index = textBoxMmail.Text.IndexOf('@');
                    if (textBoxMmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMmail.Focus();
                        textBoxMmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxMpost.TextLength;
                    var iLengthphone = textBoxMphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMpost.Focus();
                        textBoxMpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMphone.Focus();
                        textBoxMphone.SelectAll();
                        return;
                    }

                    var iLength = textBoxMpass.TextLength;
                    var passwd = textBoxMpass.Text;

                    if (iLength < 8)
                    {
                        MessageBox.Show("パスワードが短すぎます。8文字以上で入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMpass.Focus();
                        textBoxMpass.SelectAll();
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
                            textBoxMpass.Focus();
                            textBoxMpass.SelectAll();
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
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMhurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxMsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerMbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMmail.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerMjoin.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = Sha256hash.ToHash(textBoxMpass.Text);
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
                if (string.IsNullOrEmpty(textBoxMname.Text.Trim()) || string.IsNullOrEmpty(textBoxMhurigana.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMpost.Text.Trim()) || string.IsNullOrEmpty(textBoxMaddress.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMphone.Text.Trim()) || string.IsNullOrEmpty(textBoxMmail.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxMsex.Text.Trim()) || string.IsNullOrEmpty(dateTimePickerMbirth.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxMpass.Text.Trim()) || string.IsNullOrEmpty(textBoxMpass.Text.Trim()))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxMmail.Text.IndexOf('@') == -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMmail.Focus();
                        textBoxMmail.SelectAll();
                        return;
                    }

                    var index = textBoxMmail.Text.IndexOf('@');
                    if (textBoxMmail.Text.IndexOf('@', index + 1) != -1)
                    {
                        MessageBox.Show("これは有効なメールアドレスではありません", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMmail.Focus();
                        textBoxMmail.SelectAll();
                        return;
                    }

                    var iLengthpost = textBoxMpost.TextLength;
                    var iLengthphone = textBoxMphone.TextLength;

                    if (iLengthpost < 7)
                    {
                        MessageBox.Show("正しい郵便番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMpost.Focus();
                        textBoxMpost.SelectAll();
                        return;
                    }

                    if (iLengthphone < 10)
                    {
                        MessageBox.Show("正しい電話番号を入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMphone.Focus();
                        textBoxMphone.SelectAll();
                        return;
                    }


                    var iLength = textBoxMpass.TextLength;
                    var passwd = textBoxMpass.Text;

                    if (iLength < 8)
                    {
                        MessageBox.Show("パスワードが短すぎます。8文字以上で入力してください", "データ入力エラー", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        textBoxMpass.Focus();
                        textBoxMpass.SelectAll();
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
                            textBoxMpass.Focus();
                            textBoxMpass.SelectAll();
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
                            var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            AC.sql =
                                "update 社員マスタ set 社員名 = ?, ふりがな = ?, 性別 = ?, 生年月日 = ?, 郵便番号 = ?, 住所 = ?, 電話番号 = ?, メールアドレス = ?, 入社日 = ? where 社員ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMname.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMhurigana.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBoxMsex.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerMbirth.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMpost.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMaddress.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMphone.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBoxMmail.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePickerMjoin.Text;
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
            if (!string.IsNullOrEmpty(textBoxMpost.Text) && int.TryParse(textBoxMpost.Text, out I) != true)
            {
                textBoxMpost.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            long L;
            if (!string.IsNullOrEmpty(textBoxMphone.Text) && long.TryParse(textBoxMphone.Text, out L) != true)
            {
                textBoxMphone.ResetText();
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
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }
    }
}