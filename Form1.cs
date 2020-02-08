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
    public partial class welcome : Form
    {
        
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // wel_btn
        private void button1_Click(object sender, EventArgs e)
        {
            

            All_form form2 = new All_form();
            form2.Show();
            this.Hide();
            
            


        }
    }
}
