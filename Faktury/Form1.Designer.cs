namespace Faktury
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
            firstName = new Label();
            textBox1 = new TextBox();
            lastName = new Label();
            textBox2 = new TextBox();
            value = new Label();
            textBox3 = new TextBox();
            item = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            btnInsert = new Button();
            btnInsertPrint = new Button();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(51, 37);
            firstName.Name = "firstName";
            firstName.Size = new Size(38, 20);
            firstName.TabIndex = 0;
            firstName.Text = "Imię";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(51, 80);
            lastName.Name = "lastName";
            lastName.Size = new Size(72, 20);
            lastName.TabIndex = 2;
            lastName.Text = "Nazwisko";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(51, 176);
            value.Name = "value";
            value.Size = new Size(42, 20);
            value.TabIndex = 4;
            value.Text = "Cena";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(51, 129);
            item.Name = "item";
            item.Size = new Size(49, 20);
            item.TabIndex = 6;
            item.Text = "Towar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 129);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(114, 256);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(154, 33);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Zapisz";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnInsertPrint
            // 
            btnInsertPrint.Location = new Point(114, 318);
            btnInsertPrint.Name = "btnInsertPrint";
            btnInsertPrint.Size = new Size(154, 33);
            btnInsertPrint.TabIndex = 9;
            btnInsertPrint.Text = "Zapisz i drukuj";
            btnInsertPrint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 440);
            Controls.Add(btnInsertPrint);
            Controls.Add(btnInsert);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(item);
            Controls.Add(textBox3);
            Controls.Add(value);
            Controls.Add(textBox2);
            Controls.Add(lastName);
            Controls.Add(textBox1);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Faktury";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstName;
        private TextBox textBox1;
        private Label lastName;
        private TextBox textBox2;
        private Label value;
        private TextBox textBox3;
        private Label item;
        private TextBox textBox4;
        private Label label1;
        private Button btnInsert;
        private Button btnInsertPrint;
    }
}