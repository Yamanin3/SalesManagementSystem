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
    public partial class GridForm : Form
    {
        private string tblname;
        private string formname;
        public int result;

        public GridForm(string tbl, string fname)
        {
            InitializeComponent();
            tblname = tbl;
            formname = fname;
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            this.Text = formname;
            AC.sql = $"select * from {tblname}";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || e.RowIndex <= -1)// e.RowIndexが-1以下かどうかでヘッダー部ダブルクリック時のエラーを回避
            {
                return;
            }
            else
            {
                result = (int)dataGridView1[0, e.RowIndex].Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void GridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
