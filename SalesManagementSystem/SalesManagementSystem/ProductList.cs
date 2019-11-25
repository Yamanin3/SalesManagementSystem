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
    public partial class ProductListForm : Form
    {
        private int PID;
        private int I;
        private double D;
        private long L;
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {

            AC.sql = "select pd.商品ID, pd.商品名, pd.重量, pd.口径, pd.全長, pd.マガジンタイプ, pd.装弾数, mk.メーカー名, pd.商品価格, mk.メーカーID from 商品マスタ as pd inner join 仕入先マスタ as mk on pd.メーカーID = mk.メーカーID where ステータス = 0";
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
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                // datagridview1の最上段にカーソルを当てる
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
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
                    textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    textBox7.Tag = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました : " + ex.Message.ToString(), "データの取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())))
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

                            AC.sql = "insert into 商品マスタ(メーカーID, 商品名, 重量, 口径, 全長, マガジンタイプ, 装弾数, 商品価格, ステータス) Values(?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = textBox7.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox5.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox6.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Currency).Value = textBox8.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = 0;

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.sql = "select top 1 商品ID from 商品マスタ order by 商品ID desc";
                                AC.cmd.CommandText = AC.sql;
                                AC.cmd.Parameters.Clear();
                                AC.rd = AC.cmd.ExecuteReader();
                                if (AC.rd.Read())
                                {
                                    PID = int.Parse(AC.rd.GetValue(0).ToString());
                                }
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
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())) || (string.IsNullOrEmpty(this.textBox8.Text.Trim())) || (string.IsNullOrEmpty(this.comboBox1.Text.Trim())))
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
                            AC.sql = "update 商品マスタ set メーカーID = ?, 商品名 = ?, 重量 = ?, 口径 = ?, 全長 = ?, マガジンタイプ = ?, 装弾数 = ?, 商品価格 = ? where 商品ID = @id;";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.BigInt).Value = int.Parse(textBox7.Tag.ToString());
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox2.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox3.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = textBox4.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox5.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comboBox1.Text;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox6.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Currency).Value = textBox8.Text;
                            AC.cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

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

        private void ProductListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("仕入先マスタ", "メーカー選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカー名 from 仕入先マスタ where メーカーID = @id";
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
                        MessageBox.Show("メーカー名の取得に失敗しました : " + ex.Message.ToString(), "メーカー名の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && int.TryParse(textBox8.Text, out I) != true)
            {
                textBox8.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text) && int.TryParse(textBox6.Text, out I) != true)
            {
                textBox6.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && double.TryParse(textBox4.Text, out D) != true)
            {
                textBox4.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && double.TryParse(textBox3.Text, out D) != true)
            {
                textBox3.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox5.Text) && double.TryParse(textBox5.Text, out D) != true)
            {
                textBox5.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                    AC.sql = "update 商品マスタ set ステータス = ? where 商品ID = @id";
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
                MessageBox.Show("データの削除に失敗しました" + ex.Message.ToString(), "データの削除", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
