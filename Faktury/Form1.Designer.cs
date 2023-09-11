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
            firstNameTxt = new TextBox();
            lastName = new Label();
            lastNameTxt = new TextBox();
            value = new Label();
            item = new Label();
            itemTxt = new TextBox();
            label1 = new Label();
            btnInsert = new Button();
            btnInsertPrint = new Button();
            valueTxt = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)valueTxt).BeginInit();
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
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(129, 34);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(125, 27);
            firstNameTxt.TabIndex = 1;
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
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(129, 78);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(125, 27);
            lastNameTxt.TabIndex = 3;
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
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(51, 129);
            item.Name = "item";
            item.Size = new Size(49, 20);
            item.TabIndex = 6;
            item.Text = "Towar";
            // 
            // itemTxt
            // 
            itemTxt.Location = new Point(129, 126);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new Size(125, 27);
            itemTxt.TabIndex = 5;
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
            // valueTxt
            // 
            valueTxt.DecimalPlaces = 2;
            valueTxt.Location = new Point(129, 174);
            valueTxt.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            valueTxt.Name = "valueTxt";
            valueTxt.Size = new Size(125, 27);
            valueTxt.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 440);
            Controls.Add(valueTxt);
            Controls.Add(btnInsertPrint);
            Controls.Add(btnInsert);
            Controls.Add(itemTxt);
            Controls.Add(label1);
            Controls.Add(item);
            Controls.Add(value);
            Controls.Add(lastNameTxt);
            Controls.Add(lastName);
            Controls.Add(firstNameTxt);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Faktury";
            ((System.ComponentModel.ISupportInitialize)valueTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstName;
        private TextBox firstNameTxt;
        private Label lastName;
        private TextBox lastNameTxt;
        private Label value;
        private Label item;
        private TextBox itemTxt;
        private Label label1;
        private Button btnInsert;
        private Button btnInsertPrint;
        private NumericUpDown valueTxt;
    }
}