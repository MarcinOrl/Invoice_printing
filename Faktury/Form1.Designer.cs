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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dtv = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstnm = new DataGridViewTextBoxColumn();
            lastnm = new DataGridViewTextBoxColumn();
            itm = new DataGridViewTextBoxColumn();
            val = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            reloadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)valueTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtv).BeginInit();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(41, 36);
            firstName.Name = "firstName";
            firstName.Size = new Size(38, 20);
            firstName.TabIndex = 0;
            firstName.Text = "Imię";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(94, 33);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(125, 27);
            firstNameTxt.TabIndex = 1;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(7, 80);
            lastName.Name = "lastName";
            lastName.Size = new Size(72, 20);
            lastName.TabIndex = 2;
            lastName.Text = "Nazwisko";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(94, 77);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(125, 27);
            lastNameTxt.TabIndex = 3;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(37, 175);
            value.Name = "value";
            value.Size = new Size(42, 20);
            value.TabIndex = 4;
            value.Text = "Cena";
            // 
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(30, 128);
            item.Name = "item";
            item.Size = new Size(49, 20);
            item.TabIndex = 6;
            item.Text = "Towar";
            // 
            // itemTxt
            // 
            itemTxt.Location = new Point(94, 125);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new Size(125, 27);
            itemTxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(224, 375);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(154, 44);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Zapisz";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnInsertPrint
            // 
            btnInsertPrint.Location = new Point(418, 375);
            btnInsertPrint.Name = "btnInsertPrint";
            btnInsertPrint.Size = new Size(154, 44);
            btnInsertPrint.TabIndex = 9;
            btnInsertPrint.Text = "Zapisz i drukuj";
            btnInsertPrint.UseVisualStyleBackColor = true;
            btnInsertPrint.Click += btnInsertPrint_Click;
            // 
            // valueTxt
            // 
            valueTxt.DecimalPlaces = 2;
            valueTxt.Location = new Point(94, 173);
            valueTxt.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            valueTxt.Name = "valueTxt";
            valueTxt.Size = new Size(125, 27);
            valueTxt.TabIndex = 7;
            // 
            // dtv
            // 
            dtv.AllowUserToAddRows = false;
            dtv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv.Columns.AddRange(new DataGridViewColumn[] { id, firstnm, lastnm, itm, val });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtv.DefaultCellStyle = dataGridViewCellStyle2;
            dtv.Location = new Point(244, 33);
            dtv.Name = "dtv";
            dtv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtv.RowHeadersWidth = 51;
            dtv.RowTemplate.Height = 29;
            dtv.Size = new Size(544, 216);
            dtv.TabIndex = 10;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 53;
            // 
            // firstnm
            // 
            firstnm.DataPropertyName = "firstname";
            firstnm.HeaderText = "IMIĘ";
            firstnm.MinimumWidth = 6;
            firstnm.Name = "firstnm";
            firstnm.ReadOnly = true;
            firstnm.Width = 97;
            // 
            // lastnm
            // 
            lastnm.DataPropertyName = "lastname";
            lastnm.HeaderText = "NAZWISKO";
            lastnm.MinimumWidth = 6;
            lastnm.Name = "lastnm";
            lastnm.ReadOnly = true;
            lastnm.Width = 98;
            // 
            // itm
            // 
            itm.DataPropertyName = "item";
            itm.HeaderText = "TOWAR";
            itm.MinimumWidth = 6;
            itm.Name = "itm";
            itm.ReadOnly = true;
            itm.Width = 97;
            // 
            // val
            // 
            val.DataPropertyName = "value";
            val.HeaderText = "WARTOŚĆ";
            val.MinimumWidth = 6;
            val.Name = "val";
            val.ReadOnly = true;
            val.Width = 97;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(94, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // reloadBtn
            // 
            reloadBtn.Location = new Point(468, 267);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(94, 29);
            reloadBtn.TabIndex = 12;
            reloadBtn.Text = "Odśwież";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 440);
            Controls.Add(reloadBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtv);
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
            ((System.ComponentModel.ISupportInitialize)dtv).EndInit();
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
        private DataGridView dtv;
        private DateTimePicker dateTimePicker1;
        private Button reloadBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstnm;
        private DataGridViewTextBoxColumn lastnm;
        private DataGridViewTextBoxColumn itm;
        private DataGridViewTextBoxColumn val;
    }
}