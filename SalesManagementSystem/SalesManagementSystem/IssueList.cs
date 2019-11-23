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
    public partial class IssueListForm : Form
    {
        private int PID;
        private int MID;

        public IssueListForm()
        {
            InitializeComponent();
        }

        private void IssueListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.sql = "select ss.出庫ID, od.発注ID, pd.商品ID, pd.商品名, od.発注数量 as 出庫数, mk.メーカー名, ff.営業所名 from (((出庫テーブル as ss inner join 発注テーブル as od on ss.発注ID = od.発注ID) inner join 商品マスタ as pd on ss.商品ID = pd.商品ID) inner join 仕入先マスタ as mk on od.メーカーID = mk.メーカーID) inner join 営業所マスタ as ff on ss.営業所ID = ff.営業所ID";
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

            }
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

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

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
                if ((string.IsNullOrEmpty(this.textBox2.Text.Trim())) || (string.IsNullOrEmpty(this.textBox3.Text.Trim())) || (string.IsNullOrEmpty(this.textBox4.Text.Trim())) || (string.IsNullOrEmpty(this.textBox5.Text.Trim())) || (string.IsNullOrEmpty(this.textBox6.Text.Trim())) || (string.IsNullOrEmpty(this.textBox7.Text.Trim())))
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

                            AC.sql = "insert into 出庫テーブル(発注ID, 商品ID, 営業所ID, 出庫数) Values(?, ?, ?, ?)";
                            AC.cmd.Parameters.Clear();
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox2.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox3.Text);
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox7.Tag;
                            AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox5.Text);

                            AC.cmd.CommandText = AC.sql;
                            int rows = AC.cmd.ExecuteNonQuery();
                            if (rows >= 1)
                            {
                                AC.sql = "insert into 入荷テーブル(商品ID, 営業所ID, 入荷数, 入荷日) Values(?, ?, ?, ?)";
                                AC.cmd.Parameters.Clear();
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox3.Text);
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = textBox7.Tag;
                                AC.cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(textBox5.Text);
                                AC.cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.ToString("d");

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
              MessageBox.Show("出庫したデータの編集はできません。", "データの編集", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IssueListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var GridForm = new GridForm("発注テーブル", "発注情報選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
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
                    else {return;}
                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 商品名 from 商品マスタ where 商品ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = PID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox4.Text = AC.rd.GetString(0);
                    }
                    else { return; }
                    AC.rd.Close();

                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select メーカー名 from 仕入先マスタ where メーカーID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = MID;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox6.Text = AC.rd.GetString(0);
                    }
                    else { return; }
                    AC.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("発注情報の取得に失敗しました : " + ex.Message.ToString(), "発注情報の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var GridForm = new GridForm("営業所マスタ", "営業所選択");
            if (GridForm.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var id = GridForm.result;
                    AC.cmd.Parameters.Clear();
                    AC.cmd.CommandText = "select 営業所名 from 営業所マスタ where 営業所ID = @id";
                    AC.cmd.Parameters.Add("@id", OleDbType.BigInt).Value = id;
                    AC.rd = AC.cmd.ExecuteReader();

                    if (AC.rd.Read())
                    {
                        textBox7.Text = AC.rd.GetValue(0).ToString();
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
                    MessageBox.Show("営業所情報の取得に失敗しました : " + ex.Message.ToString(), "営業所情報の取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
