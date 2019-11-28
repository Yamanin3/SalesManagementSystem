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
    public partial class SalesListForm : Form
    {
        public SalesListForm()
        {
            InitializeComponent();
        }

        int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalesListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandText = "select sl.売上ID, pd.商品名, pd.商品価格 as 単価, od.注文数量 as 数量, sl.売上額 from (売上テーブル as sl inner join 商品マスタ as pd on sl.商品ID = pd.商品ID) inner join 注文テーブル as od on sl.注文ID = od.注文ID";
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }

       
    }
}
