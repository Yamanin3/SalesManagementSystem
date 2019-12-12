using Login_form.Static_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class In_stockListForm : Form
    {
        public In_stockListForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void In_stockListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
            this.MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.sql = "select i.入荷ID, pd.商品ID, pd.商品名, i.入荷数, i.入荷日, ff.営業所名 from (入荷テーブル as i inner join 営業所マスタ as ff on i.営業所ID = ff.営業所ID) inner join 商品マスタ as pd on i.商品ID = pd.商品ID";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kw = SearchTextbox.Text;
            AC.sql = $"select i.入荷ID, pd.商品ID, pd.商品名, i.入荷数, i.入荷日, ff.営業所名 from (入荷テーブル as i inner join 営業所マスタ as ff on i.営業所ID = ff.営業所ID) inner join 商品マスタ as pd on i.商品ID = pd.商品ID where (i.入荷ID like '%{kw}%' or pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or i.入荷数 like '%{kw}%' or i.入荷日 like '%{kw}%' or ff.営業所名 like '%{kw}%')";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
    }
}
