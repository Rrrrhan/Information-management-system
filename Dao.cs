using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Information_management_system
{
    class Dao
    {
        static string conStr = "server=127.0.0.1;port=3306;user=root;password=1234567; database=productdb;";//mysql connettion

        public MySqlConnection Connect()
        {
            MySqlConnection conn = new MySqlConnection(conStr);//creat connetion
            try
            {
                conn.Open();
            }
            catch (MySqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            return conn;
        }
        public MySqlCommand Command(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connect());
            return cmd;
        }
        public int Execute(string sql)
        {
            return Command(sql).ExecuteNonQuery();
        }
        public MySqlDataReader read(string sql)
        {
            return Command(sql).ExecuteReader();
        }
    }
}
