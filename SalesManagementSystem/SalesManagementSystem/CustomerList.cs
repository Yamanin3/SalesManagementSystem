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
            // IDカラムを隠す
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {

            AC.openConnection();
            AC.sql = "select * from 顧客マスタ";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
            AC.closeConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            AC.openConnection();
            string cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AC.sql = "update 顧客マスタ set 顧客番号 = @cnumber, 顧客名 = @cname, ふりがな = @churigana, 性別 = @csex, 生年月日 = @cdate, 郵便番号 = @cpost, 住所 = @caddress, 電話番号 = @cphone, メールアドレス = @cmail where 顧客ID = @cid;";
            AC.cmd.Parameters.Clear();
            AC.cmd.Parameters.Add("@cid", OleDbType.Integer).Value = cid;
            AC.cmd.Parameters.Add("@cname", OleDbType.VarWChar).Value = textBox2.Text;
            AC.cmd.Parameters.Add("@churigana", OleDbType.VarWChar).Value = textBox3.Text;
            AC.cmd.Parameters.Add("@csex", OleDbType.VarWChar).Value = comboBox1.Text;
            AC.cmd.Parameters.Add("@cdate", OleDbType.Date).Value = dateTimePicker1.Text;
            AC.cmd.Parameters.Add("@cpost", OleDbType.VarWChar).Value = textBox4.Text;
            AC.cmd.Parameters.Add("@caddress", OleDbType.VarWChar).Value = textBox5.Text;
            AC.cmd.Parameters.Add("@cphone", OleDbType.VarWChar).Value = textBox6.Text;
            AC.cmd.Parameters.Add("@cmail", OleDbType.VarWChar).Value = textBox7.Text;
            // 日付の場合: AC.cmd.Parameters.Add("@date", OleDbType.Date).Value = new DateTime(2017, 1, 1);
            AC.cmd.CommandText = AC.sql;
            AC.cmd.ExecuteNonQuery();
            AC.closeConnection();

        }

    }
}
