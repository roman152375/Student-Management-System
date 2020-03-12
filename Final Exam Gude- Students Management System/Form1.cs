using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Final_Exam_Gude__Students_Management_System
{
    public partial class Form1 : Form
    {
        string connStr = 
            "Server=INSTRUCTORIT; Database=IBTCollege; User Id=ProfileUser; Password=ProfileUser2019";
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tcNewStudent_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string testConn = "SELECT COUNT (id) FROM Students";
                SqlCommand cmd = new SqlCommand(testConn, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int total = 0;

                while (reader.Read())
                {
                    total++;
                }

               
            }
        }

        //Adding New Student
        private void AddRecord()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string addRecord = String.Format("INSERT INTO Students (firstName, lastName, ID, emailAddress) " +
                    "VALUES ('{0}', '{1}', {2}, '{3}')", txtFnameNew.Text, txtLnameNew.Text, txtIdnew.Text, txtEmailNew.Text);
                SqlCommand cmd = new SqlCommand(addRecord, conn);
                int rowsAffected = cmd.ExecuteNonQuery();


                MessageBox.Show(String.Format("{0}, {1}, Added into the database.", txtFnameNew.Text, txtLnameNew.Text));
            }
            txtFnameNew.Clear();
            txtLnameNew.Clear();
            txtIdnew.Clear();
            txtEmailNew.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFnameNew.Clear();
            txtLnameNew.Clear();
            txtIdnew.Clear();
            txtEmailNew.Clear();
        }

        //Search Student
        private void SearchRecord()
        {
            LBsearch.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string SearchConn = String.Format("SELECT * FROM Students" +
                    " WHERE firstName='{0}' OR lastName='{1}' OR ID={2}", txtFnameSearch.Text, txtLnameSearch.Text, txtIdSearch.Text);
                SqlCommand cmd = new SqlCommand(SearchConn, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int rowsAffected = 0;

                while (reader.Read())
                {
                    string fullName = reader["firstName"] + " " + reader["lastName"];
                    LBsearch.Items.Add(fullName);
                    rowsAffected++;
                }

                txtFnameSearch.Clear();
                txtLnameSearch.Clear();
                txtIdSearch.Clear();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFnameSearch.Clear();
            txtLnameSearch.Clear();
            txtIdSearch.Clear();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecord();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Roman Visual Studio\Final Exam Gude - Students Management System\exported Student.txt"))
            {
                foreach (String itemRow in lbExport.Items)
                {
                    sw.WriteLine(itemRow.ToString());
                }
            }
        }
    }
}
