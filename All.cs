using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace library_System
{
    public partial class All_form : Form
    {
        private object Cr_major_categ_V;

        public All_form()
        {
            InitializeComponent();
        }

        //books
        private void circledBtn_book_Click(object sender, EventArgs e)
        {

            welcome form1 = new welcome();
            form1.Hide();

            Login log = new Login();
            log.Show();
            //books form3 = new books();
            //form3.Show();
        }

        //Author
        private void circledBtns2_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchBtns_Click(object sender, EventArgs e)
        {
            All_form all_f = new All_form();
            all_f.Hide();

            authors auth = new authors();
            auth.Show();
        }

        private void author_lbl_Click(object sender, EventArgs e)
        {

        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            All_form all_f = new All_form();
            all_f.Hide();

            Reports_form reports = new Reports_form();
            reports.Show();



        }

        // Documentation Search
        private void circledBtns1_Click(object sender, EventArgs e)
        {
            DocSearchForm doc_search = new DocSearchForm();
            doc_search.Show();
           
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
