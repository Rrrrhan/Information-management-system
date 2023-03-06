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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                Dao dao = new();
                string sql = $"INSERT INTO `products` (`name`, `code`, `specification`, `inventory`, `created_at`) " +
                    $"VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', {textBox4.Text}, '{dateTimePicker1.Text}');";
                int n = dao.Execute(sql);
                if (n > 0) { MessageBox.Show("Added successfully "); }
                else { MessageBox.Show("Add failure "); }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
