using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login_form.Static_Classes
{
    class AC
    {
        public static OleDbConnection con = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", con);
        public static OleDbDataReader rd;
        public static OleDbDataAdapter da;
        public static DataTable dt;

        public static string currentFullName;
        public static string sql;

        public static string getConnectionString()
        {
            // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\SMSdatabase.mdb
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "\\SMSdatabase.mdb;";

            return connectionString;

        }

        public static void openConnection()
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = getConnectionString();
                    con.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("エラー" + Environment.NewLine + "説明: " + ex.Message.ToString(), "会員ログイン : データベースへの接続", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void closeConnection()
        {

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー" + Environment.NewLine + "説明: " + ex.Message.ToString(), "会員ログイン : データベースへの接続", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
