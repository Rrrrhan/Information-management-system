﻿namespace Information_management_system
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(349, 391);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 327);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 20;
            label5.Text = "created_at";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(349, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 27);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 268);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 18;
            label4.Text = "inventory";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(349, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 27);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 212);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 16;
            label3.Text = "specification";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 27);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 153);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 85);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(349, 26);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 27);
            textBox6.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 29);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 23;
            label6.Text = "id";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(349, 322);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // edit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "edit";
            Text = "edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox6;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}