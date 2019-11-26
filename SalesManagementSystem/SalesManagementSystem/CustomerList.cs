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
    public partial class CustomerListForm : Form
    {
        private long L;
        private int I;

        public CustomerListForm()
        {
            InitializeComponent();
        }


        private void CustomerListForm_Load(object sender, EventArgs e)
        {

            RefreshLoad();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new MainMenuForm();
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
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
                    textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message.ToString(), "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 行が選択されていないかどうか or 選択された行idが存在するかどうか
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
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

                            AC.sql = "insert into 顧客マスタ(顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {

                                RefreshLoad();

                            }
                        }
                        else
                        {
                            return;
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
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
                {
                    MessageBox.Show("全てのデータ項目を入力してください", "データ入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string msg = "レコードの編集を反映しますか？";
                        string caption = "レコードの編集";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon ico = MessageBoxIcon.Question;

                        DialogResult result;

                        result = MessageBox.Show(this, msg, caption, buttons, ico);

                        if (result == DialogResult.Yes)
                        {

                            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            AC.sql = "update 顧客マスタ set 顧客名 = ?, ふりがな = ?, 性別 = ?, 生年月日 = ?, 郵便番号 = ?, 住所 = ?, 電話番号 = ?, メールアドレス = ? where 顧客ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {

                                RefreshLoad();

                            }
                        }
                        else
                        {
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データの編集に失敗しました: " + ex.Message.ToString(), "データの編集", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            AC.dt.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            dataGridView1_SelectionChanged(this,EventArgs.Empty);
            
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "選択された顧客を削除しますか？";
                string caption = "顧客の削除";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    AC.sql = "update 顧客マスタ set ステータス = ? where 顧客ID = @id";
                    AC.cmd.Parameters.Clear();
                    AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 2;
                    AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    AC.cmd.CommandText = AC.sql;
                    AC.cmd.ExecuteNonQuery();

                    RefreshLoad();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("顧客の削除に失敗しました : " + ex.Message.ToString(), "顧客の削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshLoad()
        {
            AC.sql = "select 顧客ID, 顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス from 顧客マスタ where ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }

        }

        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text) && long.TryParse(textBox6.Text, out L) != true)
            {
                textBox6.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && int.TryParse(textBox4.Text, out I) != true)
            {
                textBox4.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
