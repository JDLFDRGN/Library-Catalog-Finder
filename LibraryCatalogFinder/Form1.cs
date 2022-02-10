using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryCatalogFinder
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataReader dr;
        DataTable table;
        string query, defaultQuery;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Categories.SelectedIndex = 0;
            conn = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=;database=dblibrary");
            conn.Open();
            defaultQuery = "select tblbooks.isbn as ISBN, tblbooks.title as Title,tblbooks.author as Author, tblbooks.category as Category, case when tblstocks.instock > 0 then 'Available' when tblstocks.instock <= 0 then 'Not Available' end as Stock from tblbooks inner join tblstocks on tblbooks.isbn = tblstocks.isbn ";
            query = defaultQuery;
            comm = new MySqlCommand(query, conn);
            dr = comm.ExecuteReader();
            table = new DataTable(dr.ToString());
            table.Load(dr);
            Library.DataSource = table;
            conn.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            query = defaultQuery;
            if (Categories.SelectedItem.ToString() != "All")
            {
                query += "where tblbooks.category = '" + Categories.SelectedItem.ToString() + "'";
            }
            if (ISBN.Text != "")
            {
                query += " and tblbooks.isbn = " + ISBN.Text;
            }
            if (Title.Text != "")
            {
                query += " and tblbooks.title like '%" + Title.Text + "%'";
            }
            if (Author.Text != "")
            {
                query += " and tblbooks.author like '%" + Author.Text + "%'";
            }

            conn.Open();
            comm = new MySqlCommand(query,conn);
            dr = comm.ExecuteReader();
            table = new DataTable(dr.ToString());
            table.Load(dr);
            Library.DataSource = table;
            conn.Close();
        }
    }
}
