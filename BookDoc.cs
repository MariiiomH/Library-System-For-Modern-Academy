using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_System
{
    public partial class BookDoc : Form
    {
        public BookDoc()
        {
            InitializeComponent();
        }

        private void circledBtn_book_Click(object sender, EventArgs e)
        {

            books form3 = new books();
            form3.Show();
            this.Hide();
        }

        private void circledBtns_doc_Click(object sender, EventArgs e)
        {
            Doc_Insert docForm = new Doc_Insert();
            docForm.Show();
            this.Hide();
        }
    }
}
