namespace library_System
{
    partial class books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.ISBN_txt = new System.Windows.Forms.TextBox();
            this.book_txt = new System.Windows.Forms.TextBox();
            this.combo_auth1 = new System.Windows.Forms.ComboBox();
            this.combo_pubPlace = new System.Windows.Forms.ComboBox();
            this.combo_major = new System.Windows.Forms.ComboBox();
            this.isbn_lbl = new System.Windows.Forms.Label();
            this.pubyear_lbl = new System.Windows.Forms.Label();
            this.auth_Name1 = new System.Windows.Forms.Label();
            this.pubName_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pubPlace_lbl = new System.Windows.Forms.Label();
            this.maj_lbl = new System.Windows.Forms.Label();
            this.cat_lbl = new System.Windows.Forms.Label();
            this.combo_categ = new System.Windows.Forms.ComboBox();
            this.loc_lbl = new System.Windows.Forms.Label();
            this.loc_txt = new System.Windows.Forms.TextBox();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.AddQ_btn = new System.Windows.Forms.Button();
            this.Edition_lbl = new System.Windows.Forms.Label();
            this.copy_lbl = new System.Windows.Forms.Label();
            this.combo_edi = new System.Windows.Forms.ComboBox();
            this.combo_copies = new System.Windows.Forms.ComboBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.select_categName = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ISBN_combo = new System.Windows.Forms.ComboBox();
            this.deleteQ_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Select_btn = new System.Windows.Forms.Button();
            this.updateQ_btn = new System.Windows.Forms.Button();
            this.combo_pubName = new System.Windows.Forms.ComboBox();
            this.stand_lbl = new System.Windows.Forms.Label();
            this.pages_lbl = new System.Windows.Forms.Label();
            this.page_txt = new System.Windows.Forms.TextBox();
            this.shelf_ok = new System.Windows.Forms.Button();
            this.Combo_Stand = new System.Windows.Forms.ComboBox();
            this.UpdateChoice_btn = new library_System.CircledBtns();
            this.Del_btn = new library_System.CircledBtns();
            this.Add_Btn = new library_System.CircledBtns();
            this.Display_btn = new library_System.CircledBtns();
            this.circledBtn_book = new library_System.CircledBtns();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN_txt
            // 
            this.ISBN_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_txt.Location = new System.Drawing.Point(205, 210);
            this.ISBN_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ISBN_txt.Name = "ISBN_txt";
            this.ISBN_txt.Size = new System.Drawing.Size(249, 26);
            this.ISBN_txt.TabIndex = 4;
            // 
            // book_txt
            // 
            this.book_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_txt.Location = new System.Drawing.Point(205, 282);
            this.book_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.book_txt.Multiline = true;
            this.book_txt.Name = "book_txt";
            this.book_txt.Size = new System.Drawing.Size(249, 53);
            this.book_txt.TabIndex = 5;
            // 
            // combo_auth1
            // 
            this.combo_auth1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_auth1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_auth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_auth1.FormattingEnabled = true;
            this.combo_auth1.Location = new System.Drawing.Point(205, 408);
            this.combo_auth1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_auth1.Name = "combo_auth1";
            this.combo_auth1.Size = new System.Drawing.Size(249, 28);
            this.combo_auth1.TabIndex = 9;
            this.combo_auth1.SelectedIndexChanged += new System.EventHandler(this.combo_auth1_SelectedIndexChanged);
            // 
            // combo_pubPlace
            // 
            this.combo_pubPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_pubPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_pubPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pubPlace.FormattingEnabled = true;
            this.combo_pubPlace.Location = new System.Drawing.Point(760, 408);
            this.combo_pubPlace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_pubPlace.Name = "combo_pubPlace";
            this.combo_pubPlace.Size = new System.Drawing.Size(150, 28);
            this.combo_pubPlace.TabIndex = 10;
            // 
            // combo_major
            // 
            this.combo_major.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_major.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_major.FormattingEnabled = true;
            this.combo_major.Location = new System.Drawing.Point(49, 524);
            this.combo_major.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_major.Name = "combo_major";
            this.combo_major.Size = new System.Drawing.Size(269, 28);
            this.combo_major.TabIndex = 12;
            // 
            // isbn_lbl
            // 
            this.isbn_lbl.AutoSize = true;
            this.isbn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_lbl.ForeColor = System.Drawing.Color.White;
            this.isbn_lbl.Location = new System.Drawing.Point(56, 210);
            this.isbn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbn_lbl.Name = "isbn_lbl";
            this.isbn_lbl.Size = new System.Drawing.Size(51, 20);
            this.isbn_lbl.TabIndex = 13;
            this.isbn_lbl.Text = "ISBN";
            // 
            // pubyear_lbl
            // 
            this.pubyear_lbl.AutoSize = true;
            this.pubyear_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubyear_lbl.ForeColor = System.Drawing.Color.White;
            this.pubyear_lbl.Location = new System.Drawing.Point(592, 354);
            this.pubyear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pubyear_lbl.Name = "pubyear_lbl";
            this.pubyear_lbl.Size = new System.Drawing.Size(140, 20);
            this.pubyear_lbl.TabIndex = 14;
            this.pubyear_lbl.Text = "Publication Year";
            this.pubyear_lbl.Click += new System.EventHandler(this.pubyear_lbl_Click);
            // 
            // auth_Name1
            // 
            this.auth_Name1.AutoSize = true;
            this.auth_Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth_Name1.ForeColor = System.Drawing.Color.White;
            this.auth_Name1.Location = new System.Drawing.Point(56, 411);
            this.auth_Name1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.auth_Name1.Name = "auth_Name1";
            this.auth_Name1.Size = new System.Drawing.Size(114, 20);
            this.auth_Name1.TabIndex = 15;
            this.auth_Name1.Text = "Author Name";
            // 
            // pubName_lbl
            // 
            this.pubName_lbl.AutoSize = true;
            this.pubName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubName_lbl.ForeColor = System.Drawing.Color.White;
            this.pubName_lbl.Location = new System.Drawing.Point(56, 354);
            this.pubName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pubName_lbl.Name = "pubName_lbl";
            this.pubName_lbl.Size = new System.Drawing.Size(134, 20);
            this.pubName_lbl.TabIndex = 16;
            this.pubName_lbl.Text = "Publisher Name";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(56, 294);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(89, 20);
            this.title_lbl.TabIndex = 17;
            this.title_lbl.Text = "Book Title";
            // 
            // pubPlace_lbl
            // 
            this.pubPlace_lbl.AutoSize = true;
            this.pubPlace_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubPlace_lbl.ForeColor = System.Drawing.Color.White;
            this.pubPlace_lbl.Location = new System.Drawing.Point(592, 411);
            this.pubPlace_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pubPlace_lbl.Name = "pubPlace_lbl";
            this.pubPlace_lbl.Size = new System.Drawing.Size(146, 20);
            this.pubPlace_lbl.TabIndex = 18;
            this.pubPlace_lbl.Text = "Publication Place";
            // 
            // maj_lbl
            // 
            this.maj_lbl.AutoSize = true;
            this.maj_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maj_lbl.ForeColor = System.Drawing.Color.White;
            this.maj_lbl.Location = new System.Drawing.Point(162, 487);
            this.maj_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maj_lbl.Name = "maj_lbl";
            this.maj_lbl.Size = new System.Drawing.Size(53, 20);
            this.maj_lbl.TabIndex = 21;
            this.maj_lbl.Text = "Major";
            // 
            // cat_lbl
            // 
            this.cat_lbl.AutoSize = true;
            this.cat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_lbl.ForeColor = System.Drawing.Color.White;
            this.cat_lbl.Location = new System.Drawing.Point(480, 487);
            this.cat_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cat_lbl.Name = "cat_lbl";
            this.cat_lbl.Size = new System.Drawing.Size(81, 20);
            this.cat_lbl.TabIndex = 22;
            this.cat_lbl.Text = "Category";
            // 
            // combo_categ
            // 
            this.combo_categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categ.FormattingEnabled = true;
            this.combo_categ.Location = new System.Drawing.Point(405, 522);
            this.combo_categ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_categ.Name = "combo_categ";
            this.combo_categ.Size = new System.Drawing.Size(228, 28);
            this.combo_categ.TabIndex = 25;
            // 
            // loc_lbl
            // 
            this.loc_lbl.AutoSize = true;
            this.loc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc_lbl.ForeColor = System.Drawing.Color.White;
            this.loc_lbl.Location = new System.Drawing.Point(720, 487);
            this.loc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loc_lbl.Name = "loc_lbl";
            this.loc_lbl.Size = new System.Drawing.Size(202, 20);
            this.loc_lbl.TabIndex = 26;
            this.loc_lbl.Text = "Available Shelf Location";
            this.loc_lbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // loc_txt
            // 
            this.loc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc_txt.Location = new System.Drawing.Point(724, 524);
            this.loc_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loc_txt.Name = "loc_txt";
            this.loc_txt.Size = new System.Drawing.Size(170, 26);
            this.loc_txt.TabIndex = 27;
            // 
            // combo_year
            // 
            this.combo_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_year.FormattingEnabled = true;
            this.combo_year.Location = new System.Drawing.Point(760, 351);
            this.combo_year.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(150, 28);
            this.combo_year.TabIndex = 28;
            // 
            // AddQ_btn
            // 
            this.AddQ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddQ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddQ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQ_btn.ForeColor = System.Drawing.Color.Transparent;
            this.AddQ_btn.Location = new System.Drawing.Point(1029, 505);
            this.AddQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddQ_btn.Name = "AddQ_btn";
            this.AddQ_btn.Size = new System.Drawing.Size(101, 63);
            this.AddQ_btn.TabIndex = 29;
            this.AddQ_btn.Text = "Add";
            this.AddQ_btn.UseVisualStyleBackColor = false;
            this.AddQ_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edition_lbl
            // 
            this.Edition_lbl.AutoSize = true;
            this.Edition_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition_lbl.ForeColor = System.Drawing.Color.White;
            this.Edition_lbl.Location = new System.Drawing.Point(592, 213);
            this.Edition_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Edition_lbl.Name = "Edition_lbl";
            this.Edition_lbl.Size = new System.Drawing.Size(65, 20);
            this.Edition_lbl.TabIndex = 30;
            this.Edition_lbl.Text = "Edition";
            // 
            // copy_lbl
            // 
            this.copy_lbl.AutoSize = true;
            this.copy_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_lbl.ForeColor = System.Drawing.Color.White;
            this.copy_lbl.Location = new System.Drawing.Point(592, 258);
            this.copy_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copy_lbl.Name = "copy_lbl";
            this.copy_lbl.Size = new System.Drawing.Size(64, 20);
            this.copy_lbl.TabIndex = 31;
            this.copy_lbl.Text = "Copies";
            // 
            // combo_edi
            // 
            this.combo_edi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_edi.FormattingEnabled = true;
            this.combo_edi.Location = new System.Drawing.Point(760, 210);
            this.combo_edi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_edi.Name = "combo_edi";
            this.combo_edi.Size = new System.Drawing.Size(150, 28);
            this.combo_edi.TabIndex = 32;
            this.combo_edi.SelectedIndexChanged += new System.EventHandler(this.combo_edi_SelectedIndexChanged);
            // 
            // combo_copies
            // 
            this.combo_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_copies.FormattingEnabled = true;
            this.combo_copies.Location = new System.Drawing.Point(760, 255);
            this.combo_copies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_copies.Name = "combo_copies";
            this.combo_copies.Size = new System.Drawing.Size(150, 28);
            this.combo_copies.TabIndex = 33;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(151, 558);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(64, 20);
            this.ok_btn.TabIndex = 35;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // select_categName
            // 
            this.select_categName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_categName.Location = new System.Drawing.Point(490, 558);
            this.select_categName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.select_categName.Name = "select_categName";
            this.select_categName.Size = new System.Drawing.Size(64, 20);
            this.select_categName.TabIndex = 36;
            this.select_categName.Text = "Ok";
            this.select_categName.UseVisualStyleBackColor = true;
            this.select_categName.Click += new System.EventHandler(this.select_categName_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(842, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Display";
            // 
            // grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.grid.Location = new System.Drawing.Point(49, 200);
            this.grid.Name = "grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(1233, 409);
            this.grid.TabIndex = 68;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(977, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1212, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Delete";
            // 
            // ISBN_combo
            // 
            this.ISBN_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_combo.FormattingEnabled = true;
            this.ISBN_combo.Location = new System.Drawing.Point(205, 207);
            this.ISBN_combo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ISBN_combo.Name = "ISBN_combo";
            this.ISBN_combo.Size = new System.Drawing.Size(223, 28);
            this.ISBN_combo.TabIndex = 73;
            // 
            // deleteQ_btn
            // 
            this.deleteQ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteQ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteQ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQ_btn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteQ_btn.Location = new System.Drawing.Point(458, 200);
            this.deleteQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteQ_btn.Name = "deleteQ_btn";
            this.deleteQ_btn.Size = new System.Drawing.Size(81, 41);
            this.deleteQ_btn.TabIndex = 74;
            this.deleteQ_btn.Text = "Delete";
            this.deleteQ_btn.UseVisualStyleBackColor = false;
            this.deleteQ_btn.Click += new System.EventHandler(this.deleteQ_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1089, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Update ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Select_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Select_btn.Location = new System.Drawing.Point(458, 200);
            this.Select_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(81, 41);
            this.Select_btn.TabIndex = 77;
            this.Select_btn.Text = "Select";
            this.Select_btn.UseVisualStyleBackColor = false;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // updateQ_btn
            // 
            this.updateQ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateQ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateQ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQ_btn.ForeColor = System.Drawing.Color.Transparent;
            this.updateQ_btn.Location = new System.Drawing.Point(1029, 516);
            this.updateQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateQ_btn.Name = "updateQ_btn";
            this.updateQ_btn.Size = new System.Drawing.Size(101, 41);
            this.updateQ_btn.TabIndex = 78;
            this.updateQ_btn.Text = "Update";
            this.updateQ_btn.UseVisualStyleBackColor = false;
            this.updateQ_btn.Click += new System.EventHandler(this.updateQ_btn_Click_1);
            // 
            // combo_pubName
            // 
            this.combo_pubName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_pubName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_pubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pubName.FormattingEnabled = true;
            this.combo_pubName.Location = new System.Drawing.Point(205, 354);
            this.combo_pubName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_pubName.Name = "combo_pubName";
            this.combo_pubName.Size = new System.Drawing.Size(249, 28);
            this.combo_pubName.TabIndex = 79;
            // 
            // stand_lbl
            // 
            this.stand_lbl.AutoSize = true;
            this.stand_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand_lbl.ForeColor = System.Drawing.Color.White;
            this.stand_lbl.Location = new System.Drawing.Point(742, 558);
            this.stand_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stand_lbl.Name = "stand_lbl";
            this.stand_lbl.Size = new System.Drawing.Size(134, 20);
            this.stand_lbl.TabIndex = 81;
            this.stand_lbl.Text = "Available Stand";
            // 
            // pages_lbl
            // 
            this.pages_lbl.AutoSize = true;
            this.pages_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pages_lbl.ForeColor = System.Drawing.Color.White;
            this.pages_lbl.Location = new System.Drawing.Point(592, 306);
            this.pages_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pages_lbl.Name = "pages_lbl";
            this.pages_lbl.Size = new System.Drawing.Size(59, 20);
            this.pages_lbl.TabIndex = 82;
            this.pages_lbl.Text = "Pages";
            // 
            // page_txt
            // 
            this.page_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_txt.Location = new System.Drawing.Point(760, 303);
            this.page_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.page_txt.Name = "page_txt";
            this.page_txt.Size = new System.Drawing.Size(150, 26);
            this.page_txt.TabIndex = 83;
            // 
            // shelf_ok
            // 
            this.shelf_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelf_ok.Location = new System.Drawing.Point(908, 528);
            this.shelf_ok.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shelf_ok.Name = "shelf_ok";
            this.shelf_ok.Size = new System.Drawing.Size(64, 20);
            this.shelf_ok.TabIndex = 84;
            this.shelf_ok.Text = "Ok";
            this.shelf_ok.UseVisualStyleBackColor = true;
            this.shelf_ok.Click += new System.EventHandler(this.shelf_ok_Click);
            // 
            // Combo_Stand
            // 
            this.Combo_Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Stand.FormattingEnabled = true;
            this.Combo_Stand.Location = new System.Drawing.Point(724, 592);
            this.Combo_Stand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Combo_Stand.Name = "Combo_Stand";
            this.Combo_Stand.Size = new System.Drawing.Size(170, 28);
            this.Combo_Stand.TabIndex = 85;
            // 
            // UpdateChoice_btn
            // 
            this.UpdateChoice_btn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateChoice_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateChoice_btn.BackgroundImage")));
            this.UpdateChoice_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateChoice_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateChoice_btn.FlatAppearance.BorderSize = 0;
            this.UpdateChoice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateChoice_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateChoice_btn.Location = new System.Drawing.Point(1076, 46);
            this.UpdateChoice_btn.Name = "UpdateChoice_btn";
            this.UpdateChoice_btn.Size = new System.Drawing.Size(88, 85);
            this.UpdateChoice_btn.TabIndex = 76;
            this.UpdateChoice_btn.UseVisualStyleBackColor = false;
            this.UpdateChoice_btn.Click += new System.EventHandler(this.UpdateChoice_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.BackColor = System.Drawing.Color.Transparent;
            this.Del_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Del_btn.BackgroundImage")));
            this.Del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Del_btn.FlatAppearance.BorderSize = 0;
            this.Del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Del_btn.Location = new System.Drawing.Point(1196, 46);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(88, 85);
            this.Del_btn.TabIndex = 72;
            this.Del_btn.UseVisualStyleBackColor = false;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.White;
            this.Add_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Btn.BackgroundImage")));
            this.Add_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Btn.Location = new System.Drawing.Point(950, 46);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(88, 85);
            this.Add_Btn.TabIndex = 70;
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Display_btn
            // 
            this.Display_btn.BackColor = System.Drawing.Color.Transparent;
            this.Display_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Display_btn.BackgroundImage")));
            this.Display_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Display_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_btn.FlatAppearance.BorderSize = 0;
            this.Display_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Display_btn.Location = new System.Drawing.Point(829, 46);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(88, 85);
            this.Display_btn.TabIndex = 66;
            this.Display_btn.UseVisualStyleBackColor = false;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // circledBtn_book
            // 
            this.circledBtn_book.BackColor = System.Drawing.Color.White;
            this.circledBtn_book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circledBtn_book.BackgroundImage")));
            this.circledBtn_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circledBtn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circledBtn_book.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.circledBtn_book.FlatAppearance.BorderSize = 0;
            this.circledBtn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circledBtn_book.ForeColor = System.Drawing.Color.Transparent;
            this.circledBtn_book.Location = new System.Drawing.Point(41, 46);
            this.circledBtn_book.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.circledBtn_book.Name = "circledBtn_book";
            this.circledBtn_book.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circledBtn_book.Size = new System.Drawing.Size(87, 89);
            this.circledBtn_book.TabIndex = 3;
            this.circledBtn_book.UseVisualStyleBackColor = false;
            this.circledBtn_book.Click += new System.EventHandler(this.circledBtn_book_Click);
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1298, 650);
            this.Controls.Add(this.Combo_Stand);
            this.Controls.Add(this.shelf_ok);
            this.Controls.Add(this.page_txt);
            this.Controls.Add(this.pages_lbl);
            this.Controls.Add(this.stand_lbl);
            this.Controls.Add(this.combo_pubName);
            this.Controls.Add(this.updateQ_btn);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.UpdateChoice_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteQ_btn);
            this.Controls.Add(this.ISBN_combo);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.select_categName);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.combo_copies);
            this.Controls.Add(this.combo_edi);
            this.Controls.Add(this.copy_lbl);
            this.Controls.Add(this.Edition_lbl);
            this.Controls.Add(this.AddQ_btn);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.loc_txt);
            this.Controls.Add(this.loc_lbl);
            this.Controls.Add(this.combo_categ);
            this.Controls.Add(this.cat_lbl);
            this.Controls.Add(this.maj_lbl);
            this.Controls.Add(this.pubPlace_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.pubName_lbl);
            this.Controls.Add(this.auth_Name1);
            this.Controls.Add(this.pubyear_lbl);
            this.Controls.Add(this.isbn_lbl);
            this.Controls.Add(this.combo_major);
            this.Controls.Add(this.combo_pubPlace);
            this.Controls.Add(this.combo_auth1);
            this.Controls.Add(this.book_txt);
            this.Controls.Add(this.ISBN_txt);
            this.Controls.Add(this.circledBtn_book);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "books";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircledBtns circledBtn_book;
        private System.Windows.Forms.TextBox ISBN_txt;
        private System.Windows.Forms.TextBox book_txt;
        private System.Windows.Forms.ComboBox combo_auth1;
        private System.Windows.Forms.ComboBox combo_pubPlace;
        private System.Windows.Forms.ComboBox combo_major;
        private System.Windows.Forms.Label isbn_lbl;
        private System.Windows.Forms.Label pubyear_lbl;
        private System.Windows.Forms.Label auth_Name1;
        private System.Windows.Forms.Label pubName_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label pubPlace_lbl;
        private System.Windows.Forms.Label maj_lbl;
        private System.Windows.Forms.Label cat_lbl;
        private System.Windows.Forms.ComboBox combo_categ;
        private System.Windows.Forms.Label loc_lbl;
        private System.Windows.Forms.TextBox loc_txt;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.Button AddQ_btn;
        private System.Windows.Forms.Label Edition_lbl;
        private System.Windows.Forms.Label copy_lbl;
        private System.Windows.Forms.ComboBox combo_edi;
        private System.Windows.Forms.ComboBox combo_copies;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button select_categName;
        private System.Windows.Forms.Label label7;
        private CircledBtns Display_btn;
        private System.Windows.Forms.DataGridView grid;
        private CircledBtns Add_Btn;
        private System.Windows.Forms.Label label8;
        private CircledBtns Del_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ISBN_combo;
        private System.Windows.Forms.Button deleteQ_btn;
        private CircledBtns UpdateChoice_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button updateQ_btn;
        private System.Windows.Forms.ComboBox combo_pubName;
        private System.Windows.Forms.Label stand_lbl;
        private System.Windows.Forms.Label pages_lbl;
        private System.Windows.Forms.TextBox page_txt;
        private System.Windows.Forms.Button shelf_ok;
        private System.Windows.Forms.ComboBox Combo_Stand;
    }
}