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
    public partial class books : Form
    {


        public books()
        {
            InitializeComponent();
        }

        private void books_Load(object sender, EventArgs e)
        {
            grid.Visible = false;
            isbn_lbl.Visible = false;
            title_lbl.Visible = false;
            auth_Name1.Visible = false;
            pubName_lbl.Visible = false;
            pubPlace_lbl.Visible = false;
            pubyear_lbl.Visible = false;
            maj_lbl.Visible = false;
            cat_lbl.Visible = false;
            Edition_lbl.Visible = false;
            copy_lbl.Visible = false;
            pages_lbl.Visible = false;
            loc_lbl.Visible = false;
            stand_lbl.Visible = false;

            ISBN_txt.Visible = false;
            book_txt.Visible = false;
            combo_auth1.Visible = false;
            combo_pubName.Visible = false;
            combo_pubPlace.Visible = false;
            combo_year.Visible = false;
            combo_major.Visible = false;
            combo_categ.Visible = false;
            combo_edi.Visible = false;
            combo_copies.Visible = false;
            page_txt.Visible = false;
            loc_txt.Visible = false;
            Combo_Stand.Visible = false;

            ok_btn.Visible = false;
            select_categName.Visible = false;
            AddQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            ISBN_combo.Visible = false;
            Select_btn.Visible = false;
            updateQ_btn.Visible = false;
            shelf_ok.Visible = false;
         

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();


            SqlCommand cmd = new SqlCommand("listAuth_names", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("listMajor_name", con);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("listPublisher_names", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd4 = new SqlCommand("listPublisher_Place", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_authName = new DataTable();
            DataTable dt_major = new DataTable();
            DataTable dt_pubName = new DataTable();
            DataTable dt_pubPlace = new DataTable();

            DataRow row_maj = dt_major.NewRow();
            dt_major.Rows.InsertAt(row_maj, 0);

            SqlDataAdapter sql_Adap_authName = new SqlDataAdapter(cmd);
            sql_Adap_authName.Fill(dt_authName);

            SqlDataAdapter sql_Adap_major = new SqlDataAdapter(cmd2);
            sql_Adap_major.Fill(dt_major);

            SqlDataAdapter sql_Adap_pubName = new SqlDataAdapter(cmd3);
            sql_Adap_pubName.Fill(dt_pubName);

            SqlDataAdapter sql_Adap_pubPlace = new SqlDataAdapter(cmd4);
            sql_Adap_pubPlace.Fill(dt_pubPlace);

            //Assign DataTable as DataSource.
            combo_auth1.DataSource = dt_authName;
            combo_auth1.DisplayMember = "auth_name1";

            combo_major.DataSource = dt_major;
            combo_major.DisplayMember = "major_name";

            combo_pubName.DataSource = dt_pubName;
            combo_pubName.DisplayMember = "publisher_name";

            combo_pubPlace.DataSource = dt_pubPlace;
            combo_pubPlace.DisplayMember = "publication_Place";

            combo_year.Items.Add("");

            for (int i = 1900; i <= DateTime.UtcNow.Year; i++)
            {
                combo_year.Items.Add(i);
            }


            combo_copies.Items.Add("");
            for (int i = 1; i <= 15; i++)
            {
                combo_copies.Items.Add(i);

            }


            combo_edi.Items.Add("");
            combo_edi.Items.Add("1st");
            combo_edi.Items.Add("2nd");
            combo_edi.Items.Add("3rd");
            combo_edi.Items.Add("4th");
            combo_edi.Items.Add("5th");
            combo_edi.Items.Add("6th");
            combo_edi.Items.Add("7th");
            combo_edi.Items.Add("8th");
            combo_edi.Items.Add("9th");
            combo_edi.Items.Add("10th");
         
           


        }

        private void circledBtn_book_Click(object sender, EventArgs e)
        {
            BookDoc book_doc = new BookDoc();
            book_doc.Show();
            this.Hide();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Add Button 
        private void button1_Click(object sender, EventArgs e)
        {

            //string Selected_Auth = combo_auth1.Text;
            //int index = combo_auth1.SelectedIndex;
            //MessageBox.Show("Abbosa "+ Selected_Auth + " " + index.ToString());

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_insrtBook = new SqlCommand("insert_Book", con);
            cmd_insrtBook.CommandType = CommandType.StoredProcedure;


            ////insert_BookAuth(@ISBN varchar(15), @author_id int)
            //SqlCommand cmd_book_Auth = new SqlCommand("insert_BookAuth", con);
            //cmd_book_Auth.CommandType = CommandType.StoredProcedure;


            //SqlCommand cmd_book_Auth2 = new SqlCommand("insert_BookAuth", con);
            //cmd_book_Auth2.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd_isrt_Auth = new SqlCommand("insert_Auth", con);
            //cmd_isrt_Auth.CommandType = CommandType.StoredProcedure;

            //cmd_isrt_Auth.Parameters.AddWithValue("author_name", auth_name1);
            //cmd_isrt_Auth.ExecuteNonQuery();

            //SqlCommand cmd_isrt_Auth2 = new SqlCommand("insert_Auth", con);
            //cmd_isrt_Auth2.CommandType = CommandType.StoredProcedure;

            //cmd_isrt_Auth2.Parameters.AddWithValue("author_name", auth_name2);
            //cmd_isrt_Auth2.ExecuteNonQuery();

            //if (ISBN_txt.Text == "")
            //{
            //    MessageBox.Show("Missing ISBN");
            //    cmd_book_Auth.Parameters.AddWithValue("ISBN_fk", DBNull.Value);
            //    cmd_book_Auth2.Parameters.AddWithValue("ISBN_fk", DBNull.Value);
            //}
            //else
            //{
            //    cmd_book_Auth.Parameters.AddWithValue("ISBN_fk", ISBN_txt.Text);
            //    cmd_book_Auth2.Parameters.AddWithValue("ISBN_fk", ISBN_txt.Text);
            //}



            //values(@ISBN  , @book_name  , @publisher_name , @publication_year  ,@major_id, @Edition   , @copies  , @loc , @categ_id  ) 


            //SqlCommand cmd_Auth1ID = new SqlCommand("getAuth_id", con);
            //cmd_Auth1ID.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd_Auth2ID = new SqlCommand("getAuth_id", con);
            //cmd_Auth2ID.CommandType = CommandType.StoredProcedure;

            //getMaj_id(@major_name varchar(300)

            //insert_Categ(@categ_name varchar(300), @categ_loc varchar(100), @major_id int)

            SqlCommand cmd_insrtMaj = new SqlCommand("insert_maj", con);
            cmd_insrtMaj.CommandType = CommandType.StoredProcedure;


            cmd_insrtMaj.Parameters.AddWithValue("major_name", combo_major.Text);
            cmd_insrtMaj.ExecuteNonQuery();


            SqlCommand cmd_insrtCateg = new SqlCommand("insert_Categ", con);
            cmd_insrtCateg.CommandType = CommandType.StoredProcedure;

            cmd_insrtCateg.Parameters.AddWithValue("categ_name", combo_categ.Text);
            cmd_insrtCateg.Parameters.AddWithValue("categ_loc ", loc_txt.Text);



            SqlCommand cmd_MajID = new SqlCommand("getMaj_id", con);
            cmd_MajID.CommandType = CommandType.StoredProcedure;

            cmd_MajID.Parameters.Add("@major_name", SqlDbType.VarChar).Value = combo_major.Text;



            DataTable dt = new DataTable();
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd_MajID);

            SqlDataReader rdr_MajID = cmd_MajID.ExecuteReader();

            if (combo_major.Text == "")
            {

                cmd_insrtBook.Parameters.AddWithValue("major_id", DBNull.Value);


            }

            while (rdr_MajID.Read())
            {

                string maj_id = rdr_MajID["major_id".ToString()].ToString();
                cmd_insrtBook.Parameters.AddWithValue("major_id", maj_id);
                cmd_insrtCateg.Parameters.AddWithValue("major_id", maj_id);

            }

            rdr_MajID.Close();
            cmd_insrtCateg.ExecuteNonQuery();

            SqlCommand cmd_categID = new SqlCommand("getCateg_id", con);
            cmd_categID.CommandType = CommandType.StoredProcedure;

            cmd_categID.Parameters.Add("@categ_name ", SqlDbType.VarChar).Value = combo_categ.Text;


            DataTable dt_categ = new DataTable();
            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categID);
            SqlDataReader rdr_CategID = cmd_categID.ExecuteReader();


            if (combo_categ.Text == "")
            {

                cmd_insrtBook.Parameters.AddWithValue("categ_id", DBNull.Value);

            }

            while (rdr_CategID.Read())
            {
                string categ_id = rdr_CategID["categ_id".ToString()].ToString();
                cmd_insrtBook.Parameters.AddWithValue("categ_id", categ_id);


            }

            rdr_CategID.Close();


            //cmd_Auth1ID.Parameters.Add("@author_name ", SqlDbType.VarChar).Value = auth_name1;
            //cmd_Auth2ID.Parameters.Add("@author_name ", SqlDbType.VarChar).Value = auth_name2;

            //DataTable dt = new DataTable();
            //SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd_Auth1ID);

            //SqlDataReader rdr = cmd_Auth1ID.ExecuteReader();




            //if (auth_name1 == "" )
            //{
            //    MessageBox.Show("Author Name 1 Must be inserted ");
            //    cmd_book_Auth.Parameters.AddWithValue("author_id", DBNull.Value);

            //}


            //while (rdr.Read())
            //{
            //    string takenFK = rdr["author_id".ToString()].ToString();
            //    cmd_book_Auth.Parameters.AddWithValue("author_id", takenFK);


            //}
            //rdr.Close();


            //DataTable dt2 = new DataTable();
            //SqlDataAdapter sql_Adap2 = new SqlDataAdapter(cmd_Auth2ID);

            //SqlDataReader rdr2 = cmd_Auth2ID.ExecuteReader();

            //if (auth_name2 == "")
            //{

            //    cmd_book_Auth2.Parameters.AddWithValue("author_id", DBNull.Value);

            //}


            //if (auth_name1 == "" & auth_name2 =="")
            //{

            //    MessageBox.Show("Missing Author Name ");

            //}
            //while (rdr2.Read())
            //{
            //    string takenFK = rdr2["author_id".ToString()].ToString();
            //    //MessageBox.Show(rdr2["author_id".ToString()].ToString());
            //    cmd_book_Auth2.Parameters.AddWithValue("author_id", takenFK);


            //}

            //rdr2.Close();


            SqlCommand check_ISBN = new SqlCommand("select * from Book where ([ISBN]= @ISBN )", con);
            check_ISBN.Parameters.AddWithValue("@ISBN", ISBN_txt.Text);


            SqlDataReader chk_isbn_rdr = check_ISBN.ExecuteReader();
            if (chk_isbn_rdr.HasRows)
            {
                MessageBox.Show("Already Exists");

            }


            chk_isbn_rdr.Close();

            //(@ISBN nvarchar(15), @book_name nvarchar(600), @auth_name1 nvarchar(400), @publisher_name nvarchar(200), @publication_year smallint, @publication_Place nvarchar(100), @major_id int, @Edition nvarchar(20), @copies int, @no_of_pages int, @shelf_loc nvarchar(50), @stand nvarchar(50), @categ_id int)

            cmd_insrtBook.Parameters.AddWithValue("ISBN", ISBN_txt.Text);
            cmd_insrtBook.Parameters.AddWithValue("book_name", book_txt.Text);
            cmd_insrtBook.Parameters.AddWithValue("auth_name1", combo_auth1.Text);
            cmd_insrtBook.Parameters.AddWithValue("publisher_name", combo_pubName.Text);
            cmd_insrtBook.Parameters.AddWithValue("publication_year", combo_year.Text);
            cmd_insrtBook.Parameters.AddWithValue("publication_Place", combo_pubPlace.Text);
            //cmd_insrtBook.Parameters.AddWithValue("major_id", combo_major.Text);
            cmd_insrtBook.Parameters.AddWithValue("Edition", combo_edi.Text);
            cmd_insrtBook.Parameters.AddWithValue("copies", combo_copies.Text);
            cmd_insrtBook.Parameters.AddWithValue("no_of_pages", page_txt.Text);
            cmd_insrtBook.Parameters.AddWithValue("shelf_loc", loc_txt.Text);
            cmd_insrtBook.Parameters.AddWithValue("stand", Combo_Stand.Text);
            // cmd_insrtBook.Parameters.AddWithValue("categ_id", 1);

            cmd_insrtBook.ExecuteNonQuery();

            ISBN_txt.Text = "";
            book_txt.Text = "";
            combo_auth1.Text = "";
            combo_pubName.Text = "";
            combo_pubPlace.Text = "";
            combo_year.Text = "";
            combo_major.Text = "";
            combo_categ.Text = "";
            combo_edi.Text = "";
            combo_copies.Text = "";
            page_txt.Text = "";
            loc_txt.Text = "";
            Combo_Stand.Text = "";

            SqlCommand cmdAuth = new SqlCommand("listAuth_names", con);
            cmdAuth.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("listMajor_name", con);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("listPublisher_names", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd4 = new SqlCommand("listPublisher_Place", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_authName = new DataTable();
            DataTable dt_major = new DataTable();
            DataTable dt_pubName = new DataTable();
            DataTable dt_pubPlace = new DataTable();

            DataRow row_maj = dt_major.NewRow();
            dt_major.Rows.InsertAt(row_maj, 0);

            SqlDataAdapter sql_Adap_authName = new SqlDataAdapter(cmdAuth);
            sql_Adap_authName.Fill(dt_authName);

            SqlDataAdapter sql_Adap_major = new SqlDataAdapter(cmd2);
            sql_Adap_major.Fill(dt_major);

            SqlDataAdapter sql_Adap_pubName = new SqlDataAdapter(cmd3);
            sql_Adap_pubName.Fill(dt_pubName);

            SqlDataAdapter sql_Adap_pubPlace = new SqlDataAdapter(cmd4);
            sql_Adap_pubPlace.Fill(dt_pubPlace);

            //Assign DataTable as DataSource.
            combo_auth1.DataSource = dt_authName;
            combo_auth1.DisplayMember = "auth_name1";

            combo_major.DataSource = dt_major;
            combo_major.DisplayMember = "major_name";

            combo_pubName.DataSource = dt_pubName;
            combo_pubName.DisplayMember = "publisher_name";

            combo_pubPlace.DataSource = dt_pubPlace;
            combo_pubPlace.DisplayMember = "publication_Place";

        }


        // Select Major
        private void ok_btn_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string selected_majName = combo_major.Text;
            SqlCommand cmd3 = new SqlCommand("listCateg_MajName", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            cmd3.Parameters.Add("@major_name", SqlDbType.VarChar).Value = selected_majName;
            DataTable dt3 = new DataTable();
            DataRow row = dt3.NewRow();
            dt3.Rows.InsertAt(row, 0);

            SqlDataAdapter sql_Adap3 = new SqlDataAdapter(cmd3);
            sql_Adap3.Fill(dt3);

            combo_categ.DataSource = dt3;
            combo_categ.DisplayMember = "categ_name";


            SqlCommand cmd_insrtMaj = new SqlCommand("insert_maj", con);
            cmd_insrtMaj.CommandType = CommandType.StoredProcedure;

            cmd_insrtMaj.Parameters.AddWithValue("major_name", combo_major.Text);
            cmd_insrtMaj.ExecuteNonQuery();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void combo_auth1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //select categ
        private void select_categName_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("getLoc_categ", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@categ_name", SqlDbType.VarChar).Value = combo_categ.Text;

            SqlDataReader data_rdr;

            data_rdr = cmd.ExecuteReader();
            if (data_rdr.HasRows == true)
            {
                data_rdr.Read();
                loc_lbl.Text = data_rdr["categ_loc"].ToString();

                data_rdr.Close();
            };



        }

        private void combo_edi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            grid.Visible = true;
            isbn_lbl.Visible = false;
            title_lbl.Visible = false;
            auth_Name1.Visible = false;
            pubName_lbl.Visible = false;
            pubPlace_lbl.Visible = false;
            pubyear_lbl.Visible = false;
            maj_lbl.Visible = false;
            cat_lbl.Visible = false;
            Edition_lbl.Visible = false;
            copy_lbl.Visible = false;
            pages_lbl.Visible = false;
            loc_lbl.Visible = false;
            stand_lbl.Visible = false;

            ISBN_txt.Visible = false;
            book_txt.Visible = false;
            combo_auth1.Visible = false;
            combo_pubName.Visible = false;
            combo_pubPlace.Visible = false;
            combo_year.Visible = false;
            combo_major.Visible = false;
            combo_categ.Visible = false;
            combo_edi.Visible = false;
            combo_copies.Visible = false;
            page_txt.Visible = false;
            loc_txt.Visible = false;
            Combo_Stand.Visible = false;


            ok_btn.Visible = false;
            select_categName.Visible = false;
            AddQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            ISBN_combo.Visible = false;
            Select_btn.Visible = false;
            updateQ_btn.Visible = false;
            shelf_ok.Visible = false;




            //DisplayBook_Allinfo
            //ISBN , book_name ,auth_name1 , publisher_name , publication_year , publication_Place , major_name, categ_name  , copies , Edition , no_of_pages , shelf_loc , stand 


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();


            SqlCommand cmd = new SqlCommand("DisplayBook_Allinfo", con);
            cmd.CommandType = CommandType.StoredProcedure;



            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd);
            sql_Adap_Auth.Fill(dt_Grid);


            grid.DataSource = dt_Grid;
            grid.Columns["ISBN"].HeaderText = "ISBN";
            grid.Columns["book_name"].HeaderText = "Book Title";
            grid.Columns["auth_name1"].HeaderText = "Author";
            grid.Columns["publisher_name"].HeaderText = "Publisher Name";
            grid.Columns["publication_year"].HeaderText = "Publication Year";
            grid.Columns["publication_Place"].HeaderText = "publication_Place";
            grid.Columns["major_name"].HeaderText = "Major";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["copies"].HeaderText = "Copies";
            grid.Columns["Edition"].HeaderText = "Edition";
            grid.Columns["no_of_pages"].HeaderText = "Pages";
            grid.Columns["shelf_loc"].HeaderText = "Shelf";
            grid.Columns["stand"].HeaderText = "Stand";

            //int All = grid.Rows.Count - 1;
            //total_lbl.Visible = true;
            //total_lbl.Text = "Total Books = " + All.ToString();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            grid.Visible = false;

            ISBN_txt.Text = "";
            book_txt.Text = "";
            combo_auth1.Text = "";
            combo_pubName.Text = "";
            combo_pubPlace.Text = "";
            combo_year.Text = "";
            combo_major.Text = "";
            combo_categ.Text = "";
            combo_edi.Text = "";
            combo_copies.Text = "";
            page_txt.Text = "";
            loc_txt.Text = "";
            Combo_Stand.Text = "";
            loc_lbl.Text = "Available Shelf Location";

            isbn_lbl.Visible = true;
            title_lbl.Visible = true;
            auth_Name1.Visible = true;
            pubName_lbl.Visible = true;
            pubPlace_lbl.Visible = true;
            pubyear_lbl.Visible = true;
            maj_lbl.Visible = true;
            cat_lbl.Visible = true;
            Edition_lbl.Visible = true;
            copy_lbl.Visible = true;
            pages_lbl.Visible = true;
            loc_lbl.Visible = true;
            stand_lbl.Visible = true;


            ISBN_txt.Visible = true;
            book_txt.Visible = true;
            combo_auth1.Visible = true;
            combo_pubName.Visible = true;
            combo_pubPlace.Visible = true;
            combo_year.Visible = true;
            combo_major.Visible = true;
            combo_categ.Visible = true;
            combo_edi.Visible = true;
            combo_copies.Visible = true;
            page_txt.Visible = true;
            loc_txt.Visible = true;
            Combo_Stand.Visible = true;
           

            ok_btn.Visible = true;
            select_categName.Visible = true;
            AddQ_btn.Visible = true;
            deleteQ_btn.Visible = false;
            ISBN_combo.Visible = false;
            Select_btn.Visible = false;
            updateQ_btn.Visible = false;
            shelf_ok.Visible = true;


            SqlCommand cmdAuth = new SqlCommand("listAuth_names", con);
            cmdAuth.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("listMajor_name", con);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("listPublisher_names", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd4 = new SqlCommand("listPublisher_Place", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_authName = new DataTable();
            DataTable dt_major = new DataTable();
            DataTable dt_pubName = new DataTable();
            DataTable dt_pubPlace = new DataTable();

            DataRow row_maj = dt_major.NewRow();
            dt_major.Rows.InsertAt(row_maj, 0);

            SqlDataAdapter sql_Adap_authName = new SqlDataAdapter(cmdAuth);
            sql_Adap_authName.Fill(dt_authName);

            SqlDataAdapter sql_Adap_major = new SqlDataAdapter(cmd2);
            sql_Adap_major.Fill(dt_major);

            SqlDataAdapter sql_Adap_pubName = new SqlDataAdapter(cmd3);
            sql_Adap_pubName.Fill(dt_pubName);

            SqlDataAdapter sql_Adap_pubPlace = new SqlDataAdapter(cmd4);
            sql_Adap_pubPlace.Fill(dt_pubPlace);

            //Assign DataTable as DataSource.
            combo_auth1.DataSource = dt_authName;
            combo_auth1.DisplayMember = "auth_name1";

            combo_major.DataSource = dt_major;
            combo_major.DisplayMember = "major_name";

            combo_pubName.DataSource = dt_pubName;
            combo_pubName.DisplayMember = "publisher_name";

            combo_pubPlace.DataSource = dt_pubPlace;
            combo_pubPlace.DisplayMember = "publication_Place";


        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {


            title_lbl.Visible = false;
            auth_Name1.Visible = false;
            pubName_lbl.Visible = false;
            pubPlace_lbl.Visible = false;
            pubyear_lbl.Visible = false;
            maj_lbl.Visible = false;
            cat_lbl.Visible = false;
            Edition_lbl.Visible = false;
            copy_lbl.Visible = false;
            pages_lbl.Visible = false;
            loc_lbl.Visible = false;
            stand_lbl.Visible = false;


            ISBN_txt.Visible = false;
            book_txt.Visible = false;
            combo_auth1.Visible = false;
            combo_pubName.Visible = false;
            combo_pubPlace.Visible = false;
            combo_year.Visible = false;
            combo_major.Visible = false;
            combo_categ.Visible = false;
            combo_edi.Visible = false;
            combo_copies.Visible = false;
            page_txt.Visible = false;
            loc_txt.Visible = false;
            Combo_Stand.Visible = false;

            ok_btn.Visible = false;
            select_categName.Visible = false;
            AddQ_btn.Visible = false;
            Select_btn.Visible = false;

            grid.Visible = false;
            isbn_lbl.Visible = true;
            deleteQ_btn.Visible = true;
            ISBN_combo.Visible = true;
            updateQ_btn.Visible = false;
            shelf_ok.Visible = false;


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("listAll_ISBN", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            //Insert the Default Item to DataTable.


            //Assign DataTable as DataSource.
            ISBN_combo.DataSource = dt;
            ISBN_combo.DisplayMember = "ISBN";

            SqlCommand cmd_Display = new SqlCommand("DisplayBook_Allinfo", con);
            cmd_Display.CommandType = CommandType.StoredProcedure;


            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd_Display);
            sql_Adap_Auth.Fill(dt_Grid);

            grid.DataSource = dt_Grid;
            grid.Columns["ISBN"].HeaderText = "ISBN";
            grid.Columns["book_name"].HeaderText = "Book Title";
            grid.Columns["auth_name1"].HeaderText = "Author";
            grid.Columns["publisher_name"].HeaderText = "Publisher Name";
            grid.Columns["publication_year"].HeaderText = "Publication Year";
            grid.Columns["publication_Place"].HeaderText = "publication_Place ";
            grid.Columns["major_name"].HeaderText = "Major";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["copies"].HeaderText = "Copies";
            grid.Columns["Edition"].HeaderText = "Edition";
            grid.Columns["no_of_pages"].HeaderText = "Pages";
            grid.Columns["shelf_loc"].HeaderText = "Shelf";
            grid.Columns["stand"].HeaderText = "Stand";
        }

        private void deleteQ_btn_Click(object sender, EventArgs e)
        {

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_delete = new SqlCommand("DeleteBook_Id", con);
            cmd_delete.CommandType = CommandType.StoredProcedure;

            cmd_delete.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = ISBN_combo.Text;
            cmd_delete.ExecuteNonQuery();

            SqlCommand cmd_Display = new SqlCommand("DisplayBook_Allinfo", con);
            cmd_Display.CommandType = CommandType.StoredProcedure;



            DataTable dt_Grid = new DataTable();
            SqlDataAdapter sql_Adap_Auth = new SqlDataAdapter(cmd_Display);
            sql_Adap_Auth.Fill(dt_Grid);


            grid.DataSource = dt_Grid;
            grid.Columns["ISBN"].HeaderText = "ISBN";
            grid.Columns["book_name"].HeaderText = "Book Title";
            grid.Columns["auth_name1"].HeaderText = "Author";
            grid.Columns["publisher_name"].HeaderText = "Publisher Name";
            grid.Columns["publication_year"].HeaderText = "Publication Year";
            grid.Columns["publication_Place"].HeaderText = "publication_Place ";
            grid.Columns["major_name"].HeaderText = "Major";
            grid.Columns["categ_name"].HeaderText = "Category";
            grid.Columns["copies"].HeaderText = "Copies";
            grid.Columns["Edition"].HeaderText = "Edition";
            grid.Columns["no_of_pages"].HeaderText = "Pages";
            grid.Columns["shelf_loc"].HeaderText = "Shelf";
            grid.Columns["stand"].HeaderText = "Stand";

            SqlCommand cmd = new SqlCommand("listAll_ISBN", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            //Assign DataTable as DataSource.
            ISBN_combo.DataSource = dt;
            ISBN_combo.DisplayMember = "ISBN";
        }

        private void UpdateChoice_btn_Click(object sender, EventArgs e)
        {
            loc_lbl.Text = "Available Shelf Location";

            grid.Visible = false;
            isbn_lbl.Visible = true;
            title_lbl.Visible = false;
            auth_Name1.Visible = false;
            pubName_lbl.Visible = false;
            pubPlace_lbl.Visible = false;
            pubyear_lbl.Visible = false;
            maj_lbl.Visible = false;
            cat_lbl.Visible = false;
            Edition_lbl.Visible = false;
            copy_lbl.Visible = false;
            pages_lbl.Visible = false;
            loc_lbl.Visible = false;
            stand_lbl.Visible = false;

            ISBN_txt.Visible = false;
            book_txt.Visible = false;
            combo_auth1.Visible = false;
            combo_pubName.Visible = false;
            combo_pubPlace.Visible = false;
            combo_year.Visible = false;
            combo_major.Visible = false;
            combo_categ.Visible = false;
            combo_edi.Visible = false;
            combo_copies.Visible = false;
            page_txt.Visible = false;
            loc_txt.Visible = false;
            Combo_Stand.Visible = false;

            ok_btn.Visible = false;
            select_categName.Visible = false;
            AddQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            ISBN_combo.Visible = true;
            Select_btn.Visible = true;
            updateQ_btn.Visible = false;
            shelf_ok.Visible = false;


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("listAll_ISBN", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd);
            sql_Adap.Fill(dt);

            
            ISBN_combo.DataSource = dt;
            ISBN_combo.DisplayMember = "ISBN";

            SqlCommand cmdAuth = new SqlCommand("listAuth_names", con);
            cmdAuth.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("listMajor_name", con);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("listPublisher_names", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd4 = new SqlCommand("listPublisher_Place", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_authName = new DataTable();
            DataTable dt_major = new DataTable();
            DataTable dt_pubName = new DataTable();
            DataTable dt_pubPlace = new DataTable();

            DataRow row_maj = dt_major.NewRow();
            dt_major.Rows.InsertAt(row_maj, 0);

            SqlDataAdapter sql_Adap_authName = new SqlDataAdapter(cmdAuth);
            sql_Adap_authName.Fill(dt_authName);

            SqlDataAdapter sql_Adap_major = new SqlDataAdapter(cmd2);
            sql_Adap_major.Fill(dt_major);

            SqlDataAdapter sql_Adap_pubName = new SqlDataAdapter(cmd3);
            sql_Adap_pubName.Fill(dt_pubName);

            SqlDataAdapter sql_Adap_pubPlace = new SqlDataAdapter(cmd4);
            sql_Adap_pubPlace.Fill(dt_pubPlace);

            //Assign DataTable as DataSource.
            combo_auth1.DataSource = dt_authName;
            combo_auth1.DisplayMember = "auth_name1";

            combo_major.DataSource = dt_major;
            combo_major.DisplayMember = "major_name";

            combo_pubName.DataSource = dt_pubName;
            combo_pubName.DisplayMember = "publisher_name";

            combo_pubPlace.DataSource = dt_pubPlace;
            combo_pubPlace.DisplayMember = "publication_Place";

        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            loc_lbl.Text = "Available Shelf Location";

            grid.Visible = false;

            isbn_lbl.Visible = true;
            title_lbl.Visible = true;
            auth_Name1.Visible = true;
            pubName_lbl.Visible = true;
            pubPlace_lbl.Visible = true;
            pubyear_lbl.Visible = true;
            maj_lbl.Visible = true;
            cat_lbl.Visible = true;
            Edition_lbl.Visible = true;
            copy_lbl.Visible = true;
            pages_lbl.Visible = true;
            loc_lbl.Visible = true;
            stand_lbl.Visible = true;


            ISBN_txt.Visible = false;
            book_txt.Visible = true;
            combo_auth1.Visible = true;
            combo_pubName.Visible = true;
            combo_pubPlace.Visible = true;
            combo_year.Visible = true;
            combo_major.Visible = true;
            combo_categ.Visible = true;
            combo_edi.Visible = true;
            combo_copies.Visible = true;
            page_txt.Visible = true;
            loc_txt.Visible = true;
            Combo_Stand.Visible = true;

            ok_btn.Visible = true;
            select_categName.Visible = true;
            AddQ_btn.Visible = false;
            deleteQ_btn.Visible = false;
            ISBN_combo.Visible = true;
            Select_btn.Visible = true;
            updateQ_btn.Visible = true;
            shelf_ok.Visible = true;


            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            //searchByISBN(@ISBN varchar(15))
            //book_name , auth_name1  , publisher_name ,publication_year , publication_Place ,Edition , copies  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand 
            SqlCommand cmd_update = new SqlCommand("searchByISBN", con);
            cmd_update.CommandType = CommandType.StoredProcedure;


            cmd_update.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = ISBN_combo.Text;

            SqlDataReader data_rdr;

            data_rdr = cmd_update.ExecuteReader();
            if (data_rdr.HasRows == true)
            {
                data_rdr.Read();
                book_txt.Text = data_rdr["book_name"].ToString();
                combo_auth1.Text = data_rdr["auth_name1"].ToString();
                combo_pubName.Text = data_rdr["publisher_name"].ToString();
                combo_year.Text = data_rdr["publication_year"].ToString();
                combo_pubPlace.Text = data_rdr["publication_Place"].ToString();
                combo_edi.Text = data_rdr["Edition"].ToString();
                combo_copies.Text = data_rdr["copies"].ToString();
                combo_major.Text = data_rdr["major_name"].ToString();
                combo_categ.Text = data_rdr["categ_name"].ToString();
                page_txt.Text = data_rdr["no_of_pages"].ToString();
                loc_txt.Text = data_rdr["shelf_loc"].ToString();
                Combo_Stand.Text = data_rdr["stand"].ToString();
                data_rdr.Close();
            };
        }

        
    
        private void updateQ_btn_Click_1(object sender, EventArgs e)
        {
           // (@ISBN nvarchar(15) , @book_name nvarchar(600), @auth_name1 nvarchar(400), @publisher_name nvarchar(200), @publication_year smallint, @publication_Place nvarchar(100), @major_id int, @Edition nvarchar(20), @copies int, @no_of_pages int, @shelf_loc nvarchar(50), @stand nvarchar(50), @categ_id int)

            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_update = new SqlCommand("updateBook_id", con);
            cmd_update.CommandType = CommandType.StoredProcedure;

            cmd_update.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = ISBN_combo.Text;

            SqlCommand cmd_insrtMaj = new SqlCommand("insert_maj", con);
            cmd_insrtMaj.CommandType = CommandType.StoredProcedure;


            cmd_insrtMaj.Parameters.AddWithValue("major_name", combo_major.Text);
            cmd_insrtMaj.ExecuteNonQuery();


            SqlCommand cmd_insrtCateg = new SqlCommand("insert_Categ", con);
            cmd_insrtCateg.CommandType = CommandType.StoredProcedure;

            cmd_insrtCateg.Parameters.AddWithValue("categ_name", combo_categ.Text);
            cmd_insrtCateg.Parameters.AddWithValue("categ_loc ", loc_txt.Text);



            SqlCommand cmd_MajID = new SqlCommand("getMaj_id", con);
            cmd_MajID.CommandType = CommandType.StoredProcedure;

            cmd_MajID.Parameters.Add("@major_name", SqlDbType.VarChar).Value = combo_major.Text;



            DataTable dt = new DataTable();
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd_MajID);

            SqlDataReader rdr_MajID = cmd_MajID.ExecuteReader();

            if (combo_major.Text == "")
            {

                cmd_update.Parameters.AddWithValue("major_id", DBNull.Value);


            }

            while (rdr_MajID.Read())
            {

                string maj_id = rdr_MajID["major_id".ToString()].ToString();
                cmd_update.Parameters.AddWithValue("major_id", maj_id);
                cmd_insrtCateg.Parameters.AddWithValue("major_id", maj_id);
              

            }

            rdr_MajID.Close();
            cmd_insrtCateg.ExecuteNonQuery();

            SqlCommand cmd_categID = new SqlCommand("getCateg_id", con);
            cmd_categID.CommandType = CommandType.StoredProcedure;

            cmd_categID.Parameters.Add("@categ_name ", SqlDbType.VarChar).Value = combo_categ.Text;


            DataTable dt_categ = new DataTable();
            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categID);
            SqlDataReader rdr_CategID = cmd_categID.ExecuteReader();


            if (combo_categ.Text == "")
            {

                cmd_update.Parameters.AddWithValue("categ_id", DBNull.Value);

            }

            while (rdr_CategID.Read())
            {
                string categ_id = rdr_CategID["categ_id".ToString()].ToString();
                cmd_update.Parameters.AddWithValue("categ_id", categ_id);


            }

            rdr_CategID.Close();

            cmd_update.Parameters.AddWithValue("book_name", book_txt.Text);
            cmd_update.Parameters.AddWithValue("auth_name1", combo_auth1.Text);
            cmd_update.Parameters.AddWithValue("publisher_name", combo_pubName.Text);
            cmd_update.Parameters.AddWithValue("publication_Place", combo_pubPlace.Text);
            cmd_update.Parameters.AddWithValue("publication_year", combo_year.Text);
            cmd_update.Parameters.AddWithValue("Edition", combo_edi.Text);
            cmd_update.Parameters.AddWithValue("copies", combo_copies.Text);
            cmd_update.Parameters.AddWithValue("no_of_pages", page_txt.Text);
            cmd_update.Parameters.AddWithValue ("shelf_loc", loc_txt.Text);
            cmd_update.Parameters.AddWithValue("stand", Combo_Stand.Text);
  
            cmd_update.ExecuteNonQuery();

            ISBN_txt.Text = "";
            book_txt.Text = "";
            combo_auth1.Text = "";
            combo_pubName.Text = "";
            combo_pubPlace.Text = "";
            combo_year.Text = "";
            combo_major.Text = "";
            combo_categ.Text = "";
            combo_edi.Text = "";
            combo_copies.Text = "";
            page_txt.Text = "";
            loc_txt.Text = "";
            Combo_Stand.Text = "";

            SqlCommand cmdAuth = new SqlCommand("listAuth_names", con);
            cmdAuth.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("listMajor_name", con);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("listPublisher_names", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd4 = new SqlCommand("listPublisher_Place", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            //Fill the DataTable with records from Table.
            DataTable dt_authName = new DataTable();
            DataTable dt_major = new DataTable();
            DataTable dt_pubName = new DataTable();
            DataTable dt_pubPlace = new DataTable();

            DataRow row_maj = dt_major.NewRow();
            dt_major.Rows.InsertAt(row_maj, 0);

            SqlDataAdapter sql_Adap_authName = new SqlDataAdapter(cmdAuth);
            sql_Adap_authName.Fill(dt_authName);

            SqlDataAdapter sql_Adap_major = new SqlDataAdapter(cmd2);
            sql_Adap_major.Fill(dt_major);

            SqlDataAdapter sql_Adap_pubName = new SqlDataAdapter(cmd3);
            sql_Adap_pubName.Fill(dt_pubName);

            SqlDataAdapter sql_Adap_pubPlace = new SqlDataAdapter(cmd4);
            sql_Adap_pubPlace.Fill(dt_pubPlace);

            //Assign DataTable as DataSource.
            combo_auth1.DataSource = dt_authName;
            combo_auth1.DisplayMember = "auth_name1";

            combo_major.DataSource = dt_major;
            combo_major.DisplayMember = "major_name";

            combo_pubName.DataSource = dt_pubName;
            combo_pubName.DisplayMember = "publisher_name";

            combo_pubPlace.DataSource = dt_pubPlace;
            combo_pubPlace.DisplayMember = "publication_Place";
        }

        private void pubyear_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shelf_ok_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-VFFH91B;Initial Catalog=master;User ID=Temogen;Password=A38M97";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd_insrtCateg = new SqlCommand("insert_Categ", con);
            cmd_insrtCateg.CommandType = CommandType.StoredProcedure;

            cmd_insrtCateg.Parameters.AddWithValue("categ_name", combo_categ.Text);
            cmd_insrtCateg.Parameters.AddWithValue("categ_loc ", loc_txt.Text);



            SqlCommand cmd_MajID = new SqlCommand("getMaj_id", con);
            cmd_MajID.CommandType = CommandType.StoredProcedure;

            cmd_MajID.Parameters.Add("@major_name", SqlDbType.VarChar).Value = combo_major.Text;



            DataTable dt = new DataTable();
            SqlDataAdapter sql_Adap = new SqlDataAdapter(cmd_MajID);

            SqlDataReader rdr_MajID = cmd_MajID.ExecuteReader();

            if (combo_major.Text == "")
            {

                cmd_insrtCateg.Parameters.AddWithValue("major_id", DBNull.Value);


            }

            while (rdr_MajID.Read())
            {

                string maj_id = rdr_MajID["major_id".ToString()].ToString();
                cmd_insrtCateg.Parameters.AddWithValue("major_id", maj_id);

            }

            rdr_MajID.Close();
            cmd_insrtCateg.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("NotAva_Stand", con);
            cmd3.CommandType = CommandType.StoredProcedure;


            SqlCommand cmd_categID = new SqlCommand("getCateg_id", con);
            cmd_categID.CommandType = CommandType.StoredProcedure;

            cmd_categID.Parameters.Add("@categ_name ", SqlDbType.VarChar).Value = combo_categ.Text;


            DataTable dt_categ = new DataTable();
            SqlDataAdapter sql_Adap_categ = new SqlDataAdapter(cmd_categID);
            SqlDataReader rdr_CategID = cmd_categID.ExecuteReader();


            if (combo_categ.Text == "")
            {

                cmd3.Parameters.AddWithValue("categ_id", DBNull.Value);

            }

            while (rdr_CategID.Read())
            {
                string categ_id = rdr_CategID["categ_id".ToString()].ToString();
                cmd3.Parameters.AddWithValue("categ_id", categ_id);


            }

            rdr_CategID.Close();

            cmd3.Parameters.Add("@shelf_loc", SqlDbType.NVarChar).Value = loc_txt.Text;

            DataTable dt3 = new DataTable();
            DataRow row = dt3.NewRow();
            dt3.Rows.InsertAt(row, 0);

            SqlDataAdapter sql_Adap3 = new SqlDataAdapter(cmd3);
            sql_Adap3.Fill(dt3);

            Combo_Stand.DataSource = dt3;
            Combo_Stand.DisplayMember = "stand";


           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
