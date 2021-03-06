﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Login_form.Static_Classes;

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

        private void OrderedListForm_Load(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(191, 205, 219);
            buttonSearch.BackColor = Color.FromArgb(191, 205, 219);
            BackColor = Color.FromArgb(215, 228, 242); RefreshLoad();
            MaximizeBox = false;
        }

        private void RefreshLoad()
        {
            AC.sql =
                "select re.発注ID, pd.商品ID, pd.商品名, mk.メーカー名, re.発注数量, re.発注日 from (発注テーブル as re inner join 仕入先マスタ as mk on re.メーカーID = mk.メーカーID) inner join 商品マスタ as pd on re.商品ID = pd.商品ID where re.ステータス = 1";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();

            AC.da.Fill(AC.dt);
            dataGridViewOrderedlist.DataSource = AC.dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var kw = SearchTextbox.Text;
            AC.sql =
                $"select re.発注ID, pd.商品ID, pd.商品名, mk.メーカー名, re.発注数量, re.発注日 from (発注テーブル as re inner join 仕入先マスタ as mk on re.メーカーID = mk.メーカーID) inner join 商品マスタ as pd on re.商品ID = pd.商品ID where (re.発注ID like '%{kw}%' or pd.商品ID like '%{kw}%' or pd.商品名 like '%{kw}%' or mk.メーカー名 like '%{kw}%' or re.発注数量 like '%{kw}%' or re.発注日 like '%{kw}%') and re.ステータス = 1";
            AC.cmd.CommandText = AC.sql;
            AC.da = new OleDbDataAdapter(AC.cmd);
            AC.dt = new DataTable();
            AC.da.Fill(AC.dt);
            dataGridViewOrderedlist.DataSource = AC.dt;
            if (dataGridViewOrderedlist.CurrentCell == null)
                MessageBox.Show("該当するデータがありません", "データの検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSearch.PerformClick();
        }

        private void dataGridViewOrderedlist_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = AC.dt.Rows[e.RowIndex][e.ColumnIndex];
        }
    }
}