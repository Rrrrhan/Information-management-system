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
    public partial class Edit : Form
    {
        int Ed;// Store the number of rows returned

        public Edit()
        {
            InitializeComponent();
        }
        public Edit(int a)
        {
            InitializeComponent();
            Ed = a;
            Dao dao = new();
            MySqlConnection conn = dao.Connect();
            try
            {
                // Create command objects and execute queries
                string sql = $"SELECT * FROM products WHERE id = {Ed}";
                MySqlDataReader reader = dao.Read(sql);

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
        public void Button1_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE products SET id={textBox6.Text},name='{textBox1.Text}',code='{textBox2.Text}'," +
                         $"specification='{textBox3.Text}',inventory={textBox4.Text},created_at='{dateTimePicker1.Text}'WHERE id={Ed};";
            Dao dao = new();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Data has been updated");
                this.Close();
            }
        }
    }
}
