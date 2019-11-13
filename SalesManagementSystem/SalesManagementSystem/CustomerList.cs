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
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 行が選択されていないかどうか or 選択された行idが存在するかどうか
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
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

                            AC.sql = "insert into 顧客マスタ(顧客番号, 顧客名, ふりがな, 性別, 生年月日, 郵便番号, 住所, 電話番号, メールアドレス) Values(@cnumber, @cname, @churigana, @csex, @cdate, @cpost, @caddress, @cphone, @cmail)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@cnumber", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@cname", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@churigana", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@csex", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("@cdate", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("@cpost", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@caddress", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@cphone", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@cmail", OleDbType.VarWChar).Value = textBox7.Text;

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
                if (string.IsNullOrEmpty(this.textBox1.Text.Trim()) || (string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())) || (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim())))
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

                            int cid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            AC.sql = "update 顧客マスタ set 顧客番号 = @cnumber, 顧客名 = @cname, ふりがな = @churigana, 性別 = @csex, 生年月日 = @cdate, 郵便番号 = @cpost, 住所 = @caddress, 電話番号 = @cphone, メールアドレス = @cmail where 顧客ID = @cid;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("@cnumber", OleDbType.Integer).Value = textBox1.Text;
                            AC.cmd.Parameters.Add("@cname", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("@churigana", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("@csex", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("@cdate", OleDbType.Date).Value = dateTimePicker1.Text;
                            AC.cmd.Parameters.Add("@cpost", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("@caddress", OleDbType.VarWChar).Value = textBox5.Text;
                            AC.cmd.Parameters.Add("@cphone", OleDbType.VarWChar).Value = textBox6.Text;
                            AC.cmd.Parameters.Add("@cmail", OleDbType.VarWChar).Value = textBox7.Text;
                            AC.cmd.Parameters.Add("@cid", OleDbType.Integer).Value = cid;

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
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
            dataGridView1_SelectionChanged(this,EventArgs.Empty);
            
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
            {
                AC.dt.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                RefreshLoad();
            }
            else
            {
                try
                {
                    string msg = "レコードを削除しますか？";
                    string caption = "レコードの削除";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(this, msg, caption, buttons, ico);

                    if (result == DialogResult.Yes)
                    {


                        AC.cmd.Parameters.Clear();
                        AC.cmd.CommandText = "delete from 顧客マスタ where 顧客ID = @cid;";
                        AC.cmd.Parameters.Add("@cid", OleDbType.Integer).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
                    MessageBox.Show("データの削除に失敗しました : " + ex.Message.ToString(), "データの削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshLoad()
        {
            this.dataGridView1.Columns[0].Visible = false;
            AC.openConnection();
            AC.sql = "select * from 顧客マスタ";
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

        }

        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.closeConnection();
            Application.Exit();
        }

    }
}
