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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring;
                connectionstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Student;Integrated Security=True";
                SqlConnection cn;
                cn = new SqlConnection(connectionstring);
                cn.Open();
                
                string sql;
                SqlCommand command;

                if(textBox1.Text!="" && textBox2.Text!="")
                {
                    try
                    {
                        sql = "insert stud (studid,studname) values(@id,@name)";
                        command = new SqlCommand(sql, cn);
                        command.Parameters.AddWithValue("@id", textBox1.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        int i=command.ExecuteNonQuery();
                        MessageBox.Show("inserted");
                    }
                    catch(Exception E1)
                    {
                        Console.WriteLine("Error Occurs : " + E1);
                    }
                    
                }
           
            }
            catch(Exception E)
            {
                Console.WriteLine("Error Occurs : " + E);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.stud' table. You can move, or remove it, as needed.
            this.studTableAdapter.Fill(this.studentDataSet.stud);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
    }
}
