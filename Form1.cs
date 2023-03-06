using MySql.Data.MySqlClient;
using System.Data;

namespace Information_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.DataSource = null;//Emptying old data
            Dao dao = new Dao();
            MySqlConnection conn = dao.Connect();
            string query = "select * from products";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            // Creating Data Table Objects
            DataTable dataTable = new DataTable();

            // Use the data adapter to fill the data table
            adapter.Fill(dataTable);

            // Bind the data table to the DataGridView control
            dataGridView1.DataSource = dataTable;

            // Close the database connection
            conn.Close();
        }
        private void add_Click(object sender, EventArgs e)
        {
            add form2 = new add();
            form2.ShowDialog();
            Table();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = this.dataGridView1.CurrentRow.Index;
                int id = (int)this.dataGridView1.Rows[r].Cells["id"].Value;

                string sql = $"DELETE FROM products WHERE id = '{id}'";
                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[r]);
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("Delete succeed" + sql);
                    Table();
                }
                else
                {
                    MessageBox.Show("Delete failed" + sql);
                }
            }
            catch
            {
                MessageBox.Show("Please select the records to delete first", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Table();
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Dao dao = new Dao();
                MySqlConnection conn = dao.Connect();
                //string sql = $"select * from products WHERE id LIKE '%1%';";
                string sql = $"select * from products where concat(id,name,code,specification,inventory,created_at) like '%{textBox1.Text}%';";
                //dao.Execute(sql);
                MySqlDataAdapter adapter = new(sql, conn);
                DataTable dataTable = new();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();
            }
            else
            {
                MessageBox.Show("please enter keywords");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            int id = (int)this.dataGridView1.Rows[r].Cells["id"].Value;

            edit form3 = new edit(id);
            form3.ShowDialog();
        }
    }
}