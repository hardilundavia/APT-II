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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=testdb;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testdbDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.testdbDataSet.student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtSem.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("insert into student(name,sem) values(@name,@sem)", con);
                    con.Open();
                  //  cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@sem", txtSem.Text);
                   int i= cmd.ExecuteNonQuery();
                  //  MessageBox.Show("i:"+i);
                    MessageBox.Show("Record Inserted Successfully");
                  //  DisplayData();
                    con.Close();
                    //  ClearData();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from student", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txtName.Text = "";
            txtId.Text = "";
            txtSem.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSem.Text != "")
            {
                cmd = new SqlCommand("update student set name=@name,sem=@sem where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@sem", txtSem.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtId.Text) != null)
            {
                cmd = new SqlCommand("delete from student where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
//https://www.c-sharpcorner.com/UploadFile/1e050f/insert-update-and-delete-record-in-datagridview-C-Sharp/