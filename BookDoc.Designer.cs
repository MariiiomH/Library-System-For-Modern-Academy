namespace library_System
{
    partial class BookDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDoc));
            this.book_lbl = new System.Windows.Forms.Label();
            this.circledBtn_book = new library_System.CircledBtns();
            this.label1 = new System.Windows.Forms.Label();
            this.circledBtns_doc = new library_System.CircledBtns();
            this.SuspendLayout();
            // 
            // book_lbl
            // 
            this.book_lbl.AutoSize = true;
            this.book_lbl.BackColor = System.Drawing.Color.Transparent;
            this.book_lbl.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_lbl.ForeColor = System.Drawing.Color.White;
            this.book_lbl.Location = new System.Drawing.Point(57, 167);
            this.book_lbl.Name = "book_lbl";
            this.book_lbl.Size = new System.Drawing.Size(52, 20);
            this.book_lbl.TabIndex = 4;
            this.book_lbl.Text = "Books";
            // 
            // circledBtn_book
            // 
            this.circledBtn_book.BackColor = System.Drawing.Color.Transparent;
            this.circledBtn_book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circledBtn_book.BackgroundImage")));
            this.circledBtn_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circledBtn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circledBtn_book.FlatAppearance.BorderSize = 0;
            this.circledBtn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circledBtn_book.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.circledBtn_book.Location = new System.Drawing.Point(35, 62);
            this.circledBtn_book.Name = "circledBtn_book";
            this.circledBtn_book.Size = new System.Drawing.Size(92, 92);
            this.circledBtn_book.TabIndex = 3;
            this.circledBtn_book.UseVisualStyleBackColor = false;
            this.circledBtn_book.Click += new System.EventHandler(this.circledBtn_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Documentation";
            // 
            // circledBtns_doc
            // 
            this.circledBtns_doc.BackColor = System.Drawing.Color.Transparent;
            this.circledBtns_doc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circledBtns_doc.BackgroundImage")));
            this.circledBtns_doc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circledBtns_doc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circledBtns_doc.FlatAppearance.BorderSize = 0;
            this.circledBtns_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circledBtns_doc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.circledBtns_doc.Location = new System.Drawing.Point(164, 63);
            this.circledBtns_doc.Name = "circledBtns_doc";
            this.circledBtns_doc.Size = new System.Drawing.Size(92, 92);
            this.circledBtns_doc.TabIndex = 5;
            this.circledBtns_doc.UseVisualStyleBackColor = false;
            this.circledBtns_doc.Click += new System.EventHandler(this.circledBtns_doc_Click);
            // 
            // BookDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circledBtns_doc);
            this.Controls.Add(this.book_lbl);
            this.Controls.Add(this.circledBtn_book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookDoc";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label book_lbl;
        private CircledBtns circledBtn_book;
        private System.Windows.Forms.Label label1;
        private CircledBtns circledBtns_doc;
    }
}