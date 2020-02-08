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
    public partial class DocSearchForm : Form
    {
        public DocSearchForm()
        {
            InitializeComponent();
        }

        private void DocSearchForm_Load(object sender, EventArgs e)
        {
            titleS_btn.Visible = false;
            CategSrch_btn.Visible = false;
            YearSrch_btn.Visible = false;
            SuperSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = false;
            
            mybox.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Super_Btn 
        private void circledBtns3_Click(object sender, EventArgs e)
        {

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("D_list_dr", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            mybox.DataSource = dt;
            mybox.DisplayMember = "Dr_name";

            titleS_btn.Visible = false;
            CategSrch_btn.Visible = false;
            YearSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = false;
            SuperSrch_btn.Visible = true;

            mybox.Visible = true;

        }

        private void shelf_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("D_listLoc", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            mybox.DataSource = dt;
            mybox.DisplayMember = "loc";

            titleS_btn.Visible = false;
            CategSrch_btn.Visible = false;
            YearSrch_btn.Visible = false;
            SuperSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = true;

            mybox.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void title_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("D_list_title", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            mybox.DataSource = dt;
            mybox.DisplayMember = "proj_name";

            titleS_btn.Visible = true;
            CategSrch_btn.Visible = false;
            YearSrch_btn.Visible = false;
            SuperSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = false;

            mybox.Visible = true;
        }

        private void Categ_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("D_listCateg", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            mybox.DataSource = dt;
            mybox.DisplayMember = "categ_name";

            titleS_btn.Visible = false;
            CategSrch_btn.Visible = true;
            YearSrch_btn.Visible = false;
            SuperSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = false;

            mybox.Visible = true;
        }

        private void year_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("D_list_year", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            mybox.DataSource = dt;
            mybox.DisplayMember = "graduation_year";


            titleS_btn.Visible = false;
            CategSrch_btn.Visible = false;
            YearSrch_btn.Visible = true;
            SuperSrch_btn.Visible = false;
            ShelfSrch_btn.Visible = false;

            mybox.Visible = true;
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            //ListDoc_AllInfo
            string connetionString = null;
            connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
      
        
            SqlCommand cmd = new SqlCommand("ListDoc_AllInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);

            // proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisor";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";

            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();
        }

        private void titleS_btn_Click(object sender, EventArgs e)
        {
            // searchDoc_name(@proj_name )
            //  Dr_name , graduation_year , categ_name ,loc

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string Selected = mybox.Text;
            SqlCommand cmd = new SqlCommand("searchDoc_name", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@proj_name", SqlDbType.VarChar).Value = Selected;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);

  
            grid.DataSource = dt_Grid;
            grid.Columns["Dr_name"].HeaderText = "Supervisor";
            grid.Columns["graduation_year"].HeaderText = "Graduation year";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["loc"].HeaderText = "Shelf";


            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategSrch_btn_Click(object sender, EventArgs e)
        {
            //searchDoc_Categ(@categ_name)
            //proj_name , Dr_name , graduation_year , loc

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string Selected = mybox.Text;
            SqlCommand cmd = new SqlCommand("searchDoc_Categ", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@categ_name", SqlDbType.VarChar).Value = Selected;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);


            grid.DataSource = dt_Grid;
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisor";
            grid.Columns["graduation_year"].HeaderText = "Graduation year";
            grid.Columns["loc"].HeaderText = "Shelf";

            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();
        }

        private void YearSrch_btn_Click(object sender, EventArgs e)
        {
            // searchDoc_year(@graduation_year )
            //  proj_name , Dr_name  , categ_name ,loc

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string Selected = mybox.Text;
            SqlCommand cmd = new SqlCommand("searchDoc_year", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@graduation_year", SqlDbType.VarChar).Value = Selected;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);

            grid.DataSource = dt_Grid;
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisor";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["loc"].HeaderText = "Shelf";

            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();
        }

        private void SuperSrch_btn_Click(object sender, EventArgs e)
        {
            // searchDoc_super(@Dr_name varchar(250))
            //  proj_name , graduation_year , categ_name ,loc


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string Selected = mybox.Text;
            SqlCommand cmd = new SqlCommand("searchDoc_super", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Dr_name", SqlDbType.VarChar).Value = Selected;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);

            grid.DataSource = dt_Grid;
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["graduation_year"].HeaderText = "Graduation year";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["loc"].HeaderText = "Shelf";

            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();


        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShelfSrch_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            // searchDoc_loc(@loc int)
            // proj_name , Dr_name , categ_name , graduation_year
            string Selected = mybox.Text;
            SqlCommand cmd = new SqlCommand("searchDoc_loc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@loc", SqlDbType.VarChar).Value = Selected;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);

            grid.DataSource = dt_Grid;
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisor";
            grid.Columns["graduation_year"].HeaderText = "Graduation year";
            grid.Columns["categ_name"].HeaderText = "Category";
           

            int All = grid.Rows.Count - 1;
            total_lbl.Visible = true;
            total_lbl.Text = "Total = " + All.ToString();
        }
    }
}
