using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Static_Classes
{
    class NumJudge
    {
        public static int I;
        public static long L;
        public static double D;

        public static int NJ(string tb)
        {
            if (!string.IsNullOrEmpty(tb) && int.TryParse(tb, out I) != true)
            {
                textBox4.ResetText();
                MessageBox.Show("数字しか入力できません", "入力制限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }
}
}
