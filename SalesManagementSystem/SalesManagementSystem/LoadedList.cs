using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class LoadedListForm : Form
    {
        public LoadedListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void LoadedListForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadedListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
