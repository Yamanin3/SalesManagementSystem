using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using Login_form.Static_Classes;

namespace SalesManagementSystem
{
    public partial class GridForm : Form
    {
        private readonly string formname;
        public int result;
        private string sql;

        private DataTable table;
        private readonly string tblname;

        public GridForm(string tbl, string fname, string sql = null)
        {
            InitializeComponent();
            tblname = tbl;
            formname = fname;
            this.sql = sql;
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            table = AC.dt;

            if (sql == null) sql = $"select * from {tblname}";
            Text = formname;
            AC.sql = sql;
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridView1.DataSource = AC.dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || e.RowIndex <= -1) // e.RowIndexが-1以下かどうかでヘッダー部ダブルクリック時のエラーを回避
            {
            }
            else
            {
                result = (int) dataGridView1[0, e.RowIndex].Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void GridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AC.dt = table;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            foreach (DataColumn col in AC.dt.Columns)
                if (col.DataType.FullName == typeof(string).FullName)
                    builder.Append($"{col.ColumnName} like '%{SearchTextbox.Text}%' or ");
                else if (DateTime.TryParse(SearchTextbox.Text, out var dateTime) &&
                         col.DataType.FullName == typeof(DateTime).FullName)
                    builder.Append($"{col.ColumnName} = #{SearchTextbox.Text}# or ");
                else if (int.TryParse(SearchTextbox.Text, out var value) &&
                         col.DataType.FullName == typeof(int).FullName)
                    builder.Append($"{col.ColumnName} = {value} or ");

            builder.Remove(builder.Length - 4, 4);

            var rows = AC.dt.Select(builder.ToString());
            if (rows.Length > 0)
            {
                dataGridView1.DataSource = rows.CopyToDataTable();
            }
            else
            {
                var tbl = new DataTable();
                foreach (DataColumn col in AC.dt.Columns)
                    tbl.Columns.Add(new DataColumn(col.ColumnName));
                dataGridView1.DataSource = tbl;

                MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }
    }
}