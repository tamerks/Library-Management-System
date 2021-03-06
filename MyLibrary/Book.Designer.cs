
namespace MyLibrary
{
    partial class Book
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxLan = new System.Windows.Forms.ComboBox();
            this.comboxCategory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_PAGE_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR_SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_ISBN_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANGUAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutSurname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Name";
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(110, 13);
            this.txtBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(110, 23);
            this.txtBook.TabIndex = 4;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(110, 52);
            this.txtPageCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(110, 23);
            this.txtPageCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN NO";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(110, 198);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(110, 23);
            this.txtISBN.TabIndex = 9;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(11, 284);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(82, 22);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add ";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(335, 243);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Language";
            // 
            // comboxLan
            // 
            this.comboxLan.FormattingEnabled = true;
            this.comboxLan.Items.AddRange(new object[] {
            "tr",
            "eng",
            "fr"});
            this.comboxLan.Location = new System.Drawing.Point(87, 235);
            this.comboxLan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxLan.Name = "comboxLan";
            this.comboxLan.Size = new System.Drawing.Size(133, 23);
            this.comboxLan.TabIndex = 15;
            // 
            // comboxCategory
            // 
            this.comboxCategory.FormattingEnabled = true;
            this.comboxCategory.Location = new System.Drawing.Point(87, 88);
            this.comboxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxCategory.Name = "comboxCategory";
            this.comboxCategory.Size = new System.Drawing.Size(133, 23);
            this.comboxCategory.TabIndex = 17;
            this.comboxCategory.Click += new System.EventHandler(this.comboxCategory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK_NAME,
            this.BOOK_PAGE_COUNT,
            this.CATEGORY_NAME,
            this.AUTHOR_NAME,
            this.AUTHOR_SURNAME,
            this.BOOK_ISBN_NO,
            this.LANGUAGE,
            this.BOOK_ID});
            this.dataGridView1.Location = new System.Drawing.Point(226, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(315, 225);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BOOK_NAME
            // 
            this.BOOK_NAME.DataPropertyName = "BOOK_NAME";
            this.BOOK_NAME.HeaderText = "Book Name";
            this.BOOK_NAME.Name = "BOOK_NAME";
            // 
            // BOOK_PAGE_COUNT
            // 
            this.BOOK_PAGE_COUNT.DataPropertyName = "BOOK_PAGE_COUNT";
            this.BOOK_PAGE_COUNT.HeaderText = "Page count";
            this.BOOK_PAGE_COUNT.Name = "BOOK_PAGE_COUNT";
            // 
            // CATEGORY_NAME
            // 
            this.CATEGORY_NAME.DataPropertyName = "CATEGORY_NAME";
            this.CATEGORY_NAME.HeaderText = "Category";
            this.CATEGORY_NAME.Name = "CATEGORY_NAME";
            // 
            // AUTHOR_NAME
            // 
            this.AUTHOR_NAME.DataPropertyName = "AUTHOR_NAME";
            this.AUTHOR_NAME.HeaderText = "Author Name";
            this.AUTHOR_NAME.Name = "AUTHOR_NAME";
            // 
            // AUTHOR_SURNAME
            // 
            this.AUTHOR_SURNAME.DataPropertyName = "AUTHOR_SURNAME";
            this.AUTHOR_SURNAME.HeaderText = "Author Surname";
            this.AUTHOR_SURNAME.Name = "AUTHOR_SURNAME";
            // 
            // BOOK_ISBN_NO
            // 
            this.BOOK_ISBN_NO.DataPropertyName = "BOOK_ISBN_NO";
            this.BOOK_ISBN_NO.HeaderText = "ISBN NO";
            this.BOOK_ISBN_NO.Name = "BOOK_ISBN_NO";
            // 
            // LANGUAGE
            // 
            this.LANGUAGE.DataPropertyName = "LANGUAGE";
            this.LANGUAGE.HeaderText = "Language";
            this.LANGUAGE.Name = "LANGUAGE";
            // 
            // BOOK_ID
            // 
            this.BOOK_ID.DataPropertyName = "BOOK_ID";
            this.BOOK_ID.HeaderText = "Book ID";
            this.BOOK_ID.Name = "BOOK_ID";
            this.BOOK_ID.Visible = false;
            // 
            // txtAutName
            // 
            this.txtAutName.Location = new System.Drawing.Point(110, 123);
            this.txtAutName.Name = "txtAutName";
            this.txtAutName.Size = new System.Drawing.Size(110, 23);
            this.txtAutName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Author Surname";
            // 
            // txtAutSurname
            // 
            this.txtAutSurname.Location = new System.Drawing.Point(110, 160);
            this.txtAutSurname.Name = "txtAutSurname";
            this.txtAutSurname.Size = new System.Drawing.Size(110, 23);
            this.txtAutSurname.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(56, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(308, 152);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 23);
            this.txtBookID.TabIndex = 23;
            this.txtBookID.Visible = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAutSurname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAutName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboxCategory);
            this.Controls.Add(this.comboxLan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboxLan;
        private System.Windows.Forms.ComboBox comboxCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAutName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutSurname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_PAGE_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ISBN_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANGUAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ID;
    }
}