using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_management_system
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }
        int ed;//Store the number of rows returned
        public edit(int a)
        {
            InitializeComponent();
            ed = a;
            Dao dao = new Dao();
            MySqlConnection conn = dao.Connect();
            try
            {
                // Create command objects and execute queries
                string sql = $"SELECT * FROM products WHERE id = {ed}";
                MySqlDataReader reader = dao.read(sql);

                if (reader.Read())
                {
                    // Display the results in the text box
                    textBox6.Text = reader["id"].ToString();
                    textBox1.Text = reader["name"].ToString();
                    textBox2.Text = reader["code"].ToString();
                    textBox3.Text = reader["specification"].ToString();
                    textBox4.Text = reader["inventory"].ToString();
                    dateTimePicker1.Text = reader["created_at"].ToString();
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE products SET id={textBox6.Text},name='{textBox1.Text}',code='{textBox2.Text}'," +
                         $"specification='{textBox3.Text}',inventory={textBox4.Text},created_at='{dateTimePicker1.Text}'WHERE id={ed};";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Data has been updated");
                this.Close();
            }
        }
    }
}
