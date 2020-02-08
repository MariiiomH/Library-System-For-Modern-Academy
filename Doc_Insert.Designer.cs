namespace library_System
{
    partial class Doc_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc_Insert));
            this.combo_loc = new System.Windows.Forms.ComboBox();
            this.Docloc_lbl = new System.Windows.Forms.Label();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.DocCateg_lbl = new System.Windows.Forms.Label();
            this.DocDr_lbl = new System.Windows.Forms.Label();
            this.Docyear_lbl = new System.Windows.Forms.Label();
            this.Doctitle_lbl = new System.Windows.Forms.Label();
            this.combo_categ = new System.Windows.Forms.ComboBox();
            this.combo_dr = new System.Windows.Forms.ComboBox();
            this.DocTitle_txt = new System.Windows.Forms.TextBox();
            this.AddQ_btn = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.DocID_lbl = new System.Windows.Forms.Label();
            this.combo_DocID = new System.Windows.Forms.ComboBox();
            this.Select_btn = new System.Windows.Forms.Button();
            this.updateQ_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteQ_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_btn = new library_System.CircledBtns();
            this.Display_btn = new library_System.CircledBtns();
            this.Back_Btn = new library_System.CircledBtns();
            this.UpdateChoice_btn = new library_System.CircledBtns();
            this.AddChoice_btn = new library_System.CircledBtns();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_loc
            // 
            this.combo_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_loc.FormattingEnabled = true;
            this.combo_loc.Location = new System.Drawing.Point(230, 529);
            this.combo_loc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_loc.Name = "combo_loc";
            this.combo_loc.Size = new System.Drawing.Size(150, 28);
            this.combo_loc.TabIndex = 49;
            this.combo_loc.SelectedIndexChanged += new System.EventHandler(this.combo_copies_SelectedIndexChanged);
            // 
            // Docloc_lbl
            // 
            this.Docloc_lbl.AutoSize = true;
            this.Docloc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docloc_lbl.ForeColor = System.Drawing.Color.White;
            this.Docloc_lbl.Location = new System.Drawing.Point(34, 529);
            this.Docloc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Docloc_lbl.Name = "Docloc_lbl";
            this.Docloc_lbl.Size = new System.Drawing.Size(51, 20);
            this.Docloc_lbl.TabIndex = 47;
            this.Docloc_lbl.Text = "Shelf";
            this.Docloc_lbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // combo_year
            // 
            this.combo_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_year.FormattingEnabled = true;
            this.combo_year.Location = new System.Drawing.Point(230, 470);
            this.combo_year.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(150, 28);
            this.combo_year.TabIndex = 45;
            // 
            // DocCateg_lbl
            // 
            this.DocCateg_lbl.AutoSize = true;
            this.DocCateg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocCateg_lbl.ForeColor = System.Drawing.Color.White;
            this.DocCateg_lbl.Location = new System.Drawing.Point(34, 417);
            this.DocCateg_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocCateg_lbl.Name = "DocCateg_lbl";
            this.DocCateg_lbl.Size = new System.Drawing.Size(81, 20);
            this.DocCateg_lbl.TabIndex = 44;
            this.DocCateg_lbl.Text = "Category";
            // 
            // DocDr_lbl
            // 
            this.DocDr_lbl.AutoSize = true;
            this.DocDr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDr_lbl.ForeColor = System.Drawing.Color.White;
            this.DocDr_lbl.Location = new System.Drawing.Point(34, 353);
            this.DocDr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocDr_lbl.Name = "DocDr_lbl";
            this.DocDr_lbl.Size = new System.Drawing.Size(181, 20);
            this.DocDr_lbl.TabIndex = 41;
            this.DocDr_lbl.Text = "Supervisor Name (Dr)";
            // 
            // Docyear_lbl
            // 
            this.Docyear_lbl.AutoSize = true;
            this.Docyear_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docyear_lbl.ForeColor = System.Drawing.Color.White;
            this.Docyear_lbl.Location = new System.Drawing.Point(34, 470);
            this.Docyear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Docyear_lbl.Name = "Docyear_lbl";
            this.Docyear_lbl.Size = new System.Drawing.Size(142, 20);
            this.Docyear_lbl.TabIndex = 40;
            this.Docyear_lbl.Text = "Graduation Year";
            // 
            // Doctitle_lbl
            // 
            this.Doctitle_lbl.AutoSize = true;
            this.Doctitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctitle_lbl.ForeColor = System.Drawing.Color.White;
            this.Doctitle_lbl.Location = new System.Drawing.Point(34, 279);
            this.Doctitle_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Doctitle_lbl.Name = "Doctitle_lbl";
            this.Doctitle_lbl.Size = new System.Drawing.Size(170, 20);
            this.Doctitle_lbl.TabIndex = 39;
            this.Doctitle_lbl.Text = "Documentation Title";
            // 
            // combo_categ
            // 
            this.combo_categ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_categ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categ.FormattingEnabled = true;
            this.combo_categ.Location = new System.Drawing.Point(230, 417);
            this.combo_categ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_categ.Name = "combo_categ";
            this.combo_categ.Size = new System.Drawing.Size(257, 28);
            this.combo_categ.TabIndex = 38;
            // 
            // combo_dr
            // 
            this.combo_dr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_dr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dr.FormattingEnabled = true;
            this.combo_dr.Location = new System.Drawing.Point(230, 353);
            this.combo_dr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_dr.Name = "combo_dr";
            this.combo_dr.Size = new System.Drawing.Size(257, 28);
            this.combo_dr.TabIndex = 37;
            // 
            // DocTitle_txt
            // 
            this.DocTitle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTitle_txt.Location = new System.Drawing.Point(230, 254);
            this.DocTitle_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DocTitle_txt.Multiline = true;
            this.DocTitle_txt.Name = "DocTitle_txt";
            this.DocTitle_txt.Size = new System.Drawing.Size(257, 74);
            this.DocTitle_txt.TabIndex = 34;
            // 
            // AddQ_btn
            // 
            this.AddQ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddQ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddQ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQ_btn.ForeColor = System.Drawing.Color.Transparent;
            this.AddQ_btn.Location = new System.Drawing.Point(230, 599);
            this.AddQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddQ_btn.Name = "AddQ_btn";
            this.AddQ_btn.Size = new System.Drawing.Size(101, 38);
            this.AddQ_btn.TabIndex = 50;
            this.AddQ_btn.Text = "Add";
            this.AddQ_btn.UseVisualStyleBackColor = false;
            this.AddQ_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // grid
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.grid.Location = new System.Drawing.Point(526, 254);
            this.grid.Name = "grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(815, 522);
            this.grid.TabIndex = 52;
            // 
            // DocID_lbl
            // 
            this.DocID_lbl.AutoSize = true;
            this.DocID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID_lbl.ForeColor = System.Drawing.Color.White;
            this.DocID_lbl.Location = new System.Drawing.Point(34, 198);
            this.DocID_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocID_lbl.Name = "DocID_lbl";
            this.DocID_lbl.Size = new System.Drawing.Size(155, 20);
            this.DocID_lbl.TabIndex = 54;
            this.DocID_lbl.Text = "Documentation ID";
            // 
            // combo_DocID
            // 
            this.combo_DocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_DocID.FormattingEnabled = true;
            this.combo_DocID.Location = new System.Drawing.Point(230, 195);
            this.combo_DocID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_DocID.Name = "combo_DocID";
            this.combo_DocID.Size = new System.Drawing.Size(150, 28);
            this.combo_DocID.TabIndex = 55;
            // 
            // Select_btn
            // 
            this.Select_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Select_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Select_btn.Location = new System.Drawing.Point(406, 187);
            this.Select_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(81, 41);
            this.Select_btn.TabIndex = 56;
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
            this.updateQ_btn.Location = new System.Drawing.Point(386, 598);
            this.updateQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateQ_btn.Name = "updateQ_btn";
            this.updateQ_btn.Size = new System.Drawing.Size(101, 41);
            this.updateQ_btn.TabIndex = 57;
            this.updateQ_btn.Text = "Update";
            this.updateQ_btn.UseVisualStyleBackColor = false;
            this.updateQ_btn.Click += new System.EventHandler(this.updateQ_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1024, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1128, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Update ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(884, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Display";
            // 
            // deleteQ_btn
            // 
            this.deleteQ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteQ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteQ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQ_btn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteQ_btn.Location = new System.Drawing.Point(406, 187);
            this.deleteQ_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteQ_btn.Name = "deleteQ_btn";
            this.deleteQ_btn.Size = new System.Drawing.Size(81, 41);
            this.deleteQ_btn.TabIndex = 65;
            this.deleteQ_btn.Text = "Delete";
            this.deleteQ_btn.UseVisualStyleBackColor = false;
            this.deleteQ_btn.Click += new System.EventHandler(this.deleteQ_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1260, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Delete";
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.Delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btn.BackgroundImage")));
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_btn.Location = new System.Drawing.Point(1243, 45);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(89, 85);
            this.Delete_btn.TabIndex = 67;
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
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
            this.Display_btn.Location = new System.Drawing.Point(869, 45);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(88, 85);
            this.Display_btn.TabIndex = 64;
            this.Display_btn.UseVisualStyleBackColor = false;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // Back_Btn
            // 
            this.Back_Btn.BackColor = System.Drawing.Color.White;
            this.Back_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Btn.BackgroundImage")));
            this.Back_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Back_Btn.Location = new System.Drawing.Point(38, 33);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(87, 85);
            this.Back_Btn.TabIndex = 62;
            this.Back_Btn.UseVisualStyleBackColor = false;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
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
            this.UpdateChoice_btn.Location = new System.Drawing.Point(1116, 45);
            this.UpdateChoice_btn.Name = "UpdateChoice_btn";
            this.UpdateChoice_btn.Size = new System.Drawing.Size(88, 89);
            this.UpdateChoice_btn.TabIndex = 61;
            this.UpdateChoice_btn.UseVisualStyleBackColor = false;
            this.UpdateChoice_btn.Click += new System.EventHandler(this.UpdateChoice_btn_Click);
            // 
            // AddChoice_btn
            // 
            this.AddChoice_btn.BackColor = System.Drawing.Color.White;
            this.AddChoice_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddChoice_btn.BackgroundImage")));
            this.AddChoice_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddChoice_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddChoice_btn.FlatAppearance.BorderSize = 0;
            this.AddChoice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChoice_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddChoice_btn.Location = new System.Drawing.Point(1001, 45);
            this.AddChoice_btn.Name = "AddChoice_btn";
            this.AddChoice_btn.Size = new System.Drawing.Size(88, 85);
            this.AddChoice_btn.TabIndex = 59;
            this.AddChoice_btn.UseVisualStyleBackColor = false;
            this.AddChoice_btn.Click += new System.EventHandler(this.AddChoice_btn_Click);
            // 
            // Doc_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteQ_btn);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_Btn);
            this.Controls.Add(this.UpdateChoice_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddChoice_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateQ_btn);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.combo_DocID);
            this.Controls.Add(this.DocID_lbl);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.AddQ_btn);
            this.Controls.Add(this.combo_loc);
            this.Controls.Add(this.Docloc_lbl);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.DocCateg_lbl);
            this.Controls.Add(this.DocDr_lbl);
            this.Controls.Add(this.Docyear_lbl);
            this.Controls.Add(this.Doctitle_lbl);
            this.Controls.Add(this.combo_categ);
            this.Controls.Add(this.combo_dr);
            this.Controls.Add(this.DocTitle_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doc_Insert";
            this.Text = "Documentation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Doc_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_loc;
        private System.Windows.Forms.Label Docloc_lbl;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.Label DocCateg_lbl;
        private System.Windows.Forms.Label DocDr_lbl;
        private System.Windows.Forms.Label Docyear_lbl;
        private System.Windows.Forms.Label Doctitle_lbl;
        private System.Windows.Forms.ComboBox combo_categ;
        private System.Windows.Forms.ComboBox combo_dr;
        private System.Windows.Forms.TextBox DocTitle_txt;
        private System.Windows.Forms.Button AddQ_btn;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label DocID_lbl;
        private System.Windows.Forms.ComboBox combo_DocID;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button updateQ_btn;
        private CircledBtns AddChoice_btn;
        private System.Windows.Forms.Label label5;
        private CircledBtns UpdateChoice_btn;
        private System.Windows.Forms.Label label1;
        private CircledBtns Back_Btn;
        private CircledBtns Display_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteQ_btn;
        private CircledBtns Delete_btn;
        private System.Windows.Forms.Label label3;
    }
}