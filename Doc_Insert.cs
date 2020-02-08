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
    public partial class Doc_Insert : Form
    {
        public Doc_Insert()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void combo_copies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

           //insert_Doc(@proj_name varchar(500), @Dr_name varchar(250), @graduation_year smallint, @categ_name varchar(400), @loc int)
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_insrtDoc = new SqlCommand("insert_Doc", con);
            cmd_insrtDoc.CommandType = CommandType.StoredProcedure;

            cmd_insrtDoc.Parameters.AddWithValue("proj_name", DocTitle_txt.Text);
            cmd_insrtDoc.Parameters.AddWithValue("Dr_name", combo_dr.Text);
            cmd_insrtDoc.Parameters.AddWithValue("graduation_year", combo_year.Text);
            cmd_insrtDoc.Parameters.AddWithValue("categ_name ", combo_categ.Text);
            cmd_insrtDoc.Parameters.AddWithValue("loc", combo_loc.Text);
           
            cmd_insrtDoc.ExecuteNonQuery();

            SqlCommand cmd_dr = new SqlCommand("D_list_dr", con);
            cmd_dr.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_categ = new SqlCommand("D_listCateg", con);
            cmd_categ.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_year = new SqlCommand("D_list_year", con);
            cmd_year.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_loc = new SqlCommand("D_listLoc", con);
            cmd_loc.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_dr = new DataTable();
            DataTable dt_categ = new DataTable();
            DataTable dt_year = new DataTable();
            DataTable dt_loc = new DataTable();

            DataRow row_dr = dt_dr.NewRow();
            DataRow row_categ = dt_categ.NewRow();
            DataRow row_year = dt_year.NewRow();
            DataRow row_loc = dt_loc.NewRow();

            dt_dr.Rows.InsertAt(row_dr, 0);
            dt_categ.Rows.InsertAt(row_categ, 0);
            dt_year.Rows.InsertAt(row_year, 0);
            dt_loc.Rows.InsertAt(row_loc, 0);

            SqlDataAdapter sql_Adap_dr = new SqlDataAdapter(cmd_dr);
            sql_Adap_dr.Fill(dt_dr);

            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categ);
            sql_Adap_categ.Fill(dt_categ);

            SqlDataAdapter sql_Adap_year = new SqlDataAdapter(cmd_year);
            sql_Adap_year.Fill(dt_year);

            SqlDataAdapter sql_Adap_loc = new SqlDataAdapter(cmd_loc);
            sql_Adap_loc.Fill(dt_loc);

            //Assign DataTable as DataSource.
            combo_dr.DataSource = dt_dr;
            combo_dr.DisplayMember = "Dr_name";

            combo_categ.DataSource = dt_categ;
            combo_categ.DisplayMember = "categ_name";

            combo_year.DataSource = dt_year;
            combo_year.DisplayMember = "graduation_year";

            combo_loc.DataSource = dt_loc;
            combo_loc.DisplayMember = "loc";

            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);


            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";

            DocTitle_txt.Text = "";
            combo_dr.Text = "";
            combo_year.Text = "";
            combo_categ.Text = "";
            combo_loc.Text = "";

        }

        private void Doc_Insert_Load(object sender, EventArgs e)
        {

            //string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            //SqlConnection con = new SqlConnection(connetionString);
            //con.Open();

            //SqlCommand cmd_dr = new SqlCommand("D_list_dr", con);
            //cmd_dr.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd_categ = new SqlCommand("D_listCateg", con);
            //cmd_categ.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd_year = new SqlCommand("D_list_year", con);
            //cmd_year.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd_loc = new SqlCommand("D_listLoc", con);
            //cmd_loc.CommandType = CommandType.StoredProcedure;

            ////Fill the DataTable with records from Table.
            //DataTable dt_dr = new DataTable();
            //DataTable dt_categ = new DataTable();
            //DataTable dt_year = new DataTable();
            //DataTable dt_loc = new DataTable();

            //DataRow row_dr = dt_dr.NewRow();
            //DataRow row_categ = dt_categ.NewRow();
            //DataRow row_year = dt_year.NewRow();
            //DataRow row_loc = dt_loc.NewRow();

            //dt_dr.Rows.InsertAt(row_dr, 0);
            //dt_categ.Rows.InsertAt(row_categ, 0);
            //dt_year.Rows.InsertAt(row_year, 0);
            //dt_loc.Rows.InsertAt(row_loc, 0);

            //SqlDataAdapter sql_Adap_dr = new SqlDataAdapter(cmd_dr);
            //sql_Adap_dr.Fill(dt_dr);

            //SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categ);
            //sql_Adap_categ.Fill(dt_categ);

            //SqlDataAdapter sql_Adap_year= new SqlDataAdapter(cmd_year);
            //sql_Adap_year.Fill(dt_year);

            //SqlDataAdapter sql_Adap_loc= new SqlDataAdapter(cmd_loc);
            //sql_Adap_loc.Fill(dt_loc);

            ////Assign DataTable as DataSource.
            //combo_dr.DataSource = dt_dr;
            //combo_dr.DisplayMember = "Dr_name";

            //combo_categ.DataSource = dt_categ;
            //combo_categ.DisplayMember = "categ_name";

            //combo_year.DataSource = dt_year;
            //combo_year.DisplayMember = "graduation_year";

            //combo_loc.DataSource = dt_loc;
            //combo_loc.DisplayMember = "loc";

            Doctitle_lbl.Visible = false;
            DocDr_lbl.Visible = false;
            DocCateg_lbl.Visible = false;
            Docyear_lbl.Visible = false;
            Docloc_lbl.Visible = false;

            DocTitle_txt.Visible = false;
            combo_dr.Visible = false;
            combo_categ.Visible = false;
            combo_year.Visible = false;
            combo_loc.Visible = false;

            grid.Visible = false;
            DocID_lbl.Visible = false;
            combo_DocID.Visible = false;
            AddQ_btn.Visible = false;
            updateQ_btn.Visible = false;
            Select_btn.Visible = false;
            deleteQ_btn.Visible = false;

        }


        private void Select_btn_Click(object sender, EventArgs e)
        {
            //searchDoc_Id(@doc_id int)
            // proj_name , Dr_name , graduation_year , categ_name ,loc

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

      
            SqlCommand cmd_Doc= new SqlCommand("searchDoc_Id", con);
            cmd_Doc.CommandType = CommandType.StoredProcedure;


            cmd_Doc.Parameters.Add("@doc_id", SqlDbType.VarChar).Value = combo_DocID.Text;

            SqlDataReader data_rdr;

            data_rdr = cmd_Doc.ExecuteReader();
            if (data_rdr.HasRows == true)
            {
                data_rdr.Read();
                DocTitle_txt.Text = data_rdr["proj_name"].ToString();
                combo_dr.Text = data_rdr["Dr_name"].ToString();
                combo_year.Text = data_rdr["graduation_year"].ToString();
                combo_categ.Text = data_rdr["categ_name"].ToString();
                combo_loc.Text = data_rdr["loc"].ToString();

                data_rdr.Close();
            };


            Doctitle_lbl.Visible = true;
            DocDr_lbl.Visible = true;
            DocCateg_lbl.Visible = true;
            Docyear_lbl.Visible = true;
            Docloc_lbl.Visible = true;

            DocTitle_txt.Visible = true;
            combo_dr.Visible = true;
            combo_categ.Visible = true;
            combo_year.Visible = true;
            combo_loc.Visible = true;

            updateQ_btn.Visible = true;
            deleteQ_btn.Visible = false;


        }

        private void updateQ_btn_Click(object sender, EventArgs e)
        {
            //updateDoc_id (@doc_id int, @proj_name varchar(500), @Dr_name varchar(250), @graduation_year smallint, @categ_name varchar(400), @loc int)
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_updateDoc = new SqlCommand("updateDoc_id", con);
            cmd_updateDoc.CommandType = CommandType.StoredProcedure;

            cmd_updateDoc.Parameters.Add("@doc_id", SqlDbType.VarChar).Value = combo_DocID.Text;

            cmd_updateDoc.Parameters.AddWithValue("proj_name", DocTitle_txt.Text);
            cmd_updateDoc.Parameters.AddWithValue("Dr_name", combo_dr.Text);
            cmd_updateDoc.Parameters.AddWithValue("graduation_year", combo_year.Text);
            cmd_updateDoc.Parameters.AddWithValue("categ_name ", combo_categ.Text);
            cmd_updateDoc.Parameters.AddWithValue("loc", combo_loc.Text);


            cmd_updateDoc.ExecuteNonQuery();

            SqlCommand cmd_dr = new SqlCommand("D_list_dr", con);
            cmd_dr.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_categ = new SqlCommand("D_listCateg", con);
            cmd_categ.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_year = new SqlCommand("D_list_year", con);
            cmd_year.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_loc = new SqlCommand("D_listLoc", con);
            cmd_loc.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_dr = new DataTable();
            DataTable dt_categ = new DataTable();
            DataTable dt_year = new DataTable();
            DataTable dt_loc = new DataTable();

            DataRow row_dr = dt_dr.NewRow();
            DataRow row_categ = dt_categ.NewRow();
            DataRow row_year = dt_year.NewRow();
            DataRow row_loc = dt_loc.NewRow();

            dt_dr.Rows.InsertAt(row_dr, 0);
            dt_categ.Rows.InsertAt(row_categ, 0);
            dt_year.Rows.InsertAt(row_year, 0);
            dt_loc.Rows.InsertAt(row_loc, 0);

            SqlDataAdapter sql_Adap_dr = new SqlDataAdapter(cmd_dr);
            sql_Adap_dr.Fill(dt_dr);

            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categ);
            sql_Adap_categ.Fill(dt_categ);

            SqlDataAdapter sql_Adap_year = new SqlDataAdapter(cmd_year);
            sql_Adap_year.Fill(dt_year);

            SqlDataAdapter sql_Adap_loc = new SqlDataAdapter(cmd_loc);
            sql_Adap_loc.Fill(dt_loc);

            //Assign DataTable as DataSource.
            combo_dr.DataSource = dt_dr;
            combo_dr.DisplayMember = "Dr_name";

            combo_categ.DataSource = dt_categ;
            combo_categ.DisplayMember = "categ_name";

            combo_year.DataSource = dt_year;
            combo_year.DisplayMember = "graduation_year";

            combo_loc.DataSource = dt_loc;
            combo_loc.DisplayMember = "loc";

            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);


            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";

            SqlCommand cmd_id = new SqlCommand("ListDocID", con);
            cmd_id.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid_ID = new DataTable();
            DataRow row = dt_Grid_ID.NewRow();
            dt_Grid_ID.Rows.InsertAt(row, 0);

            SqlDataAdapter sql_Adap_ID = new SqlDataAdapter(cmd_id);
            sql_Adap_ID.Fill(dt_Grid_ID);

            combo_DocID.DataSource = dt_Grid_ID;
            combo_DocID.DisplayMember = "doc_id";


            DocTitle_txt.Text = "";
            combo_dr.Text = "";
            combo_year.Text = "";
            combo_categ.Text = "";
            combo_loc.Text = "";

           
        }

        private void UpdateChoice_btn_Click(object sender, EventArgs e)
        {
            Doctitle_lbl.Visible = false;
            DocDr_lbl.Visible = false;
            DocCateg_lbl.Visible = false;
            Docyear_lbl.Visible = false;
            Docloc_lbl.Visible = false;

            DocTitle_txt.Visible = false;
            combo_dr.Visible = false;
            combo_categ.Visible = false;
            combo_year.Visible = false;
            combo_loc.Visible = false;

            AddQ_btn.Visible = false;
            grid.Visible = true;

            DocID_lbl.Visible = true;
            combo_DocID.Visible = true;
            Select_btn.Visible = true;
            updateQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_dr = new SqlCommand("D_list_dr", con);
            cmd_dr.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_categ = new SqlCommand("D_listCateg", con);
            cmd_categ.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_year = new SqlCommand("D_list_year", con);
            cmd_year.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_loc = new SqlCommand("D_listLoc", con);
            cmd_loc.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_dr = new DataTable();
            DataTable dt_categ = new DataTable();
            DataTable dt_year = new DataTable();
            DataTable dt_loc = new DataTable();

            DataRow row_dr = dt_dr.NewRow();
            DataRow row_categ = dt_categ.NewRow();
            DataRow row_year = dt_year.NewRow();
            DataRow row_loc = dt_loc.NewRow();

            dt_dr.Rows.InsertAt(row_dr, 0);
            dt_categ.Rows.InsertAt(row_categ, 0);
            dt_year.Rows.InsertAt(row_year, 0);
            dt_loc.Rows.InsertAt(row_loc, 0);

            SqlDataAdapter sql_Adap_dr = new SqlDataAdapter(cmd_dr);
            sql_Adap_dr.Fill(dt_dr);

            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categ);
            sql_Adap_categ.Fill(dt_categ);

            SqlDataAdapter sql_Adap_year = new SqlDataAdapter(cmd_year);
            sql_Adap_year.Fill(dt_year);

            SqlDataAdapter sql_Adap_loc = new SqlDataAdapter(cmd_loc);
            sql_Adap_loc.Fill(dt_loc);

            //Assign DataTable as DataSource.
            combo_dr.DataSource = dt_dr;
            combo_dr.DisplayMember = "Dr_name";

            combo_categ.DataSource = dt_categ;
            combo_categ.DisplayMember = "categ_name";

            combo_year.DataSource = dt_year;
            combo_year.DisplayMember = "graduation_year";

            combo_loc.DataSource = dt_loc;
            combo_loc.DisplayMember = "loc";

            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();

            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);


            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";


            SqlCommand cmd_id = new SqlCommand("ListDocID", con);
            cmd_id.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid_ID = new DataTable();

            DataRow row_ID = dt_Grid_ID.NewRow();

            SqlDataAdapter sql_Adap_ID = new SqlDataAdapter(cmd_id);
            sql_Adap_ID.Fill(dt_Grid_ID);

            dt_Grid_ID.Rows.InsertAt(row_ID, 0);
         
            combo_DocID.DataSource = dt_Grid_ID;
            combo_DocID.DisplayMember = "doc_id";
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            BookDoc book_doc = new BookDoc();
            book_doc.Show();
            this.Hide();


        }

        private void Display_btn_Click(object sender, EventArgs e)
        {

            Doctitle_lbl.Visible = false;
            DocDr_lbl.Visible = false;
            DocCateg_lbl.Visible = false;
            Docyear_lbl.Visible = false;
            Docloc_lbl.Visible = false;

            DocTitle_txt.Visible = false;
            combo_dr.Visible = false;
            combo_categ.Visible = false;
            combo_year.Visible = false;
            combo_loc.Visible = false;

            AddQ_btn.Visible = false;
            Select_btn.Visible = false;
            updateQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            grid.Visible = true;

            DocID_lbl.Visible = false;
            combo_DocID.Visible = false;



            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();


            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);


            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";


        }

        private void AddChoice_btn_Click(object sender, EventArgs e)
        {
            

            Doctitle_lbl.Visible = true;
            DocDr_lbl.Visible = true;
            DocCateg_lbl.Visible = true;
            Docyear_lbl.Visible = true;
            Docloc_lbl.Visible = true;

            DocTitle_txt.Visible = true;
            combo_dr.Visible = true;
            combo_categ.Visible = true;
            combo_year.Visible = true;
            combo_loc.Visible = true;

            DocID_lbl.Visible = false;
            combo_DocID.Visible = false;

            AddQ_btn.Visible = true;
            grid.Visible = true;

            Select_btn.Visible = false;
            updateQ_btn.Visible = false;
            deleteQ_btn.Visible = false;


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_dr = new SqlCommand("D_list_dr", con);
            cmd_dr.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_categ = new SqlCommand("D_listCateg", con);
            cmd_categ.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_year = new SqlCommand("D_list_year", con);
            cmd_year.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd_loc = new SqlCommand("D_listLoc", con);
            cmd_loc.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_dr = new DataTable();
            DataTable dt_categ = new DataTable();
            DataTable dt_year = new DataTable();
            DataTable dt_loc = new DataTable();

            DataRow row_dr = dt_dr.NewRow();
            DataRow row_categ = dt_categ.NewRow();
            DataRow row_year = dt_year.NewRow();
            DataRow row_loc = dt_loc.NewRow();

            dt_dr.Rows.InsertAt(row_dr, 0);
            dt_categ.Rows.InsertAt(row_categ, 0);
            dt_year.Rows.InsertAt(row_year, 0);
            dt_loc.Rows.InsertAt(row_loc, 0);

            SqlDataAdapter sql_Adap_dr = new SqlDataAdapter(cmd_dr);
            sql_Adap_dr.Fill(dt_dr);

            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categ);
            sql_Adap_categ.Fill(dt_categ);

            SqlDataAdapter sql_Adap_year = new SqlDataAdapter(cmd_year);
            sql_Adap_year.Fill(dt_year);

            SqlDataAdapter sql_Adap_loc = new SqlDataAdapter(cmd_loc);
            sql_Adap_loc.Fill(dt_loc);

            //Assign DataTable as DataSource.
            combo_dr.DataSource = dt_dr;
            combo_dr.DisplayMember = "Dr_name";

            combo_categ.DataSource = dt_categ;
            combo_categ.DisplayMember = "categ_name";

            combo_year.DataSource = dt_year;
            combo_year.DisplayMember = "graduation_year";

            combo_loc.DataSource = dt_loc;
            combo_loc.DisplayMember = "loc";

            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);


            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";

            DocTitle_txt.Text = "";
            combo_dr.Text = "";
            combo_year.Text = "";
            combo_categ.Text = "";
            combo_loc.Text = "";

           
        }

        private void deleteQ_btn_Click(object sender, EventArgs e)
        {

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();


            SqlCommand cmd_delete = new SqlCommand("DeleteDoc_Id", con);
            cmd_delete.CommandType = CommandType.StoredProcedure;

            cmd_delete.Parameters.Add("@doc_id", SqlDbType.VarChar).Value = combo_DocID.Text;
            cmd_delete.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);

            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Doctitle_lbl.Visible = false;
            DocDr_lbl.Visible = false;
            DocCateg_lbl.Visible = false;
            Docyear_lbl.Visible = false;
            Docloc_lbl.Visible = false;

            DocTitle_txt.Visible = false;
            combo_dr.Visible = false;
            combo_categ.Visible = false;
            combo_year.Visible = false;
            combo_loc.Visible = false;

            AddQ_btn.Visible = false;
            grid.Visible = true;

            updateQ_btn.Visible = false;
            Select_btn.Visible = false;

            DocID_lbl.Visible = true;
            combo_DocID.Visible = true;
            deleteQ_btn.Visible = true;

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("ListDocID_All", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_All = new SqlDataAdapter(cmd);
            sql_Adap_All.Fill(dt_Grid);

            // doc_id, proj_name, Dr_name, categ_name, graduation_year, loc

            grid.DataSource = dt_Grid;
            grid.Columns["doc_id"].HeaderText = "Code";
            grid.Columns["proj_name"].HeaderText = "Documentation Title";
            grid.Columns["Dr_name"].HeaderText = "Supervisior";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["graduation_year"].HeaderText = "Graduation Year";
            grid.Columns["loc"].HeaderText = "Shelf";

            SqlCommand cmd_id = new SqlCommand("ListDocID", con);
            cmd_id.CommandType = CommandType.StoredProcedure;

            DataTable dt_Grid_ID = new DataTable();
            DataRow row = dt_Grid_ID.NewRow();
            dt_Grid_ID.Rows.InsertAt(row, 0);

            SqlDataAdapter sql_Adap_ID = new SqlDataAdapter(cmd_id);
            sql_Adap_ID.Fill(dt_Grid_ID);

            combo_DocID.DataSource = dt_Grid_ID;
            combo_DocID.DisplayMember = "doc_id";
        }
    }
}
