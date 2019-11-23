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
    public partial class RequestListForm : Form
    {

        public RequestListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new MainMenuForm();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form orderedlistForm = new OrderedListForm();
            orderedlistForm.ShowDialog();
        }

        private void RequestListForm_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad()
        {
            AC.sql = "select re.発注ID, pd.商品ID, pd.商品名, mk.メーカー名, re.発注数量, re.発注日 from (発注テーブル as re inner join 仕入先マスタ as mk on re.メーカーID = mk.メーカーID) inner join 商品マスタ as pd on re.商品ID = pd.商品ID where re.ステータス = 0";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }

        private void RequestListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
