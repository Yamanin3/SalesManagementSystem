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
    public partial class OrderedListForm : Form
    {
        public OrderedListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void OrderedListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void OrderedListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.sql = "select re.発注ID, pd.商品ID, pd.商品名, mk.メーカー名, re.発注数量, re.発注日 from (発注テーブル as re inner join 仕入先マスタ as mk on re.メーカーID = mk.メーカーID) inner join 商品マスタ as pd on re.商品ID = pd.商品ID where re.ステータス = 1";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }
    }
}
