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
using System.Configuration;

namespace ADOSTUDENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Sql Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\mssqllocaldb; initial catalog=Training; Integrated Security=true;";
            //Create Sql Command - Select Query or DML Query or Stored Procedure
            SqlCommand cmd = new SqlCommand();
            //Passing connection object
            cmd.Connection = conn;
            //Passing command
            cmd.CommandText = "Select Stud_Code, Stud_Name, Dept_Code, Stud_Dob, Address from Student_master";
            //Open the connection
            conn.Open();
            //Execute the command and fetch datas
            SqlDataReader reader = cmd.ExecuteReader();
            //Read the first row
            reader.Read();
            //Store into releavant TextBoxes
            txtStuCode.Text = reader["Stud_Code"].ToString(); txtStuName.Text = reader["Stud_Name"].ToString(); txtStuDept.Text = reader["Dept_Code"].ToString(); dtpStuDOB.Text = reader["Stud_Dob"].ToString(); txtStuAdd.Text = reader["Address"].ToString();
            //Close
            reader.Close();
            cmd.Dispose();
            conn.Close();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.Resetbtn();
        }
        public void Resetbtn()
        {
            txtStuName.Text = "";
            txtStuCode.Clear();
            txtStuDept.Text = "";
            dtpStuDOB.Text = "";
            txtStuAdd.Text = "";
            txtStuCode.Focus();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Training; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("Select Stud_Code, Stud_Name, Dept_Code, Stud_Dob, Address from Student_master Where Stud_Code=@SearchBox", conn))
                {
                    cmd.Parameters.AddWithValue("@SearchBox", SearchBox.Text);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();


                    using (reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtStuName.Text = reader["Stud_Name"].ToString();
                            txtStuDept.Text = reader["Dept_Code"].ToString();
                            txtStuAdd.Text = reader["Address"].ToString();
                            txtStuCode.Text = reader["Stud_Code"].ToString();
                            dtpStuDOB.Text = reader["Stud_Dob"].ToString();
                        }
                }
            }
        }

        private void AddStu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Training; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("usp_AddNewStudenttttt", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentCode", txtStuCode.Text);
                    cmd.Parameters.AddWithValue("@StudName", txtStuName.Text);
                    cmd.Parameters.AddWithValue("@StudAdd", txtStuAdd.Text);
                    cmd.Parameters.AddWithValue("@StudDOB", dtpStuDOB.Text);
                    cmd.Parameters.AddWithValue("@StudDept", txtStuDept.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("New Student Created");
        }

        private void EditStu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Training; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("usp_UpdateStudentt", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentCode", txtStuCode.Text);
                    cmd.Parameters.AddWithValue("@StudName", txtStuName.Text);
                    cmd.Parameters.AddWithValue("@StudAdd", txtStuAdd.Text);
                    cmd.Parameters.AddWithValue("@StudDOB", dtpStuDOB.Text);
                    cmd.Parameters.AddWithValue("@StudDept", txtStuDept.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery(); //used for DML operation
                }
                MessageBox.Show("Student Edited");
            }
        }

        private void DeleteStu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Training; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("usp_DeleteStudenttttt", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentCode", txtStuCode.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery(); //used for DML operation

                }
            }
            MessageBox.Show("Student Deleted");

        }
    }
}
