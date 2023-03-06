namespace Information_management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            add = new Button();
            edit = new Button();
            delete = new Button();
            refresh = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            find = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 36);
            label1.TabIndex = 0;
            label1.Text = "Product List";
            // 
            // add
            // 
            add.Location = new Point(553, 91);
            add.Name = "add";
            add.Size = new Size(101, 38);
            add.TabIndex = 1;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(660, 91);
            edit.Name = "edit";
            edit.Size = new Size(101, 38);
            edit.TabIndex = 2;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(767, 91);
            delete.Name = "delete";
            delete.Size = new Size(101, 38);
            delete.TabIndex = 3;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(446, 91);
            refresh.Name = "refresh";
            refresh.Size = new Size(101, 38);
            refresh.TabIndex = 4;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(20, 73);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 5;
            label2.Text = "*Please enter keywords";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 6;
            // 
            // find
            // 
            find.Location = new Point(269, 94);
            find.Name = "find";
            find.Size = new Size(94, 35);
            find.TabIndex = 7;
            find.Text = "Find";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 136);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(880, 658);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 794);
            Controls.Add(dataGridView1);
            Controls.Add(find);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(refresh);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button add;
        private Button edit;
        private Button delete;
        private Button refresh;
        private Label label2;
        private TextBox textBox1;
        private Button find;
        private DataGridView dataGridView1;
    }
}