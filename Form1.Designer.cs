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
            Add = new Button();
            Edit = new Button();
            Delete = new Button();
            Refresh = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            Find = new Button();
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
            // Add
            // 
            Add.Location = new Point(553, 91);
            Add.Name = "Add";
            Add.Size = new Size(101, 38);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(660, 91);
            Edit.Name = "Edit";
            Edit.Size = new Size(101, 38);
            Edit.TabIndex = 2;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(767, 91);
            Delete.Name = "Delete";
            Delete.Size = new Size(101, 38);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(446, 91);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(101, 38);
            Refresh.TabIndex = 4;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
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
            // Find
            // 
            Find.Location = new Point(269, 94);
            Find.Name = "Find";
            Find.Size = new Size(94, 35);
            Find.TabIndex = 7;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = true;
            Find.Click += Find_Click;
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
            Controls.Add(Find);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Refresh);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Add);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private new Button Refresh;
        private Label label2;
        private TextBox textBox1;
        private Button Find;
        private DataGridView dataGridView1;
    }
}