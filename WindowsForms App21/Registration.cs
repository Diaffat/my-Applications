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

namespace WindowsForms_App21
{
    public partial class Registration : Form
    {
        //string connection
        
        string path = @"Data Source =DESKTOP-PTQ7CTJ\SQLEXPRESS;Initial Catalog=registration;Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;


        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (txtName.Text==""|| txtFName.Text==""|| txtDesign.Text=="" || txtEmail.Text=="" || txtID.Text==""|| txtAdress.Text=="")
            {
                MessageBox.Show("Please fill in the blanks");
            }
         else
         {

          
            try
            {
                
                string gender;

                if(radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                con.Open();
                cmd = new SqlCommand("insert into Employee(Employee_Name,Employee_FName,Employee_Designation,Employee_Email,Emp_ID,Gender,adress)values('" + txtName.Text + "','" + txtFName.Text + "','" + txtDesign.Text + "','" + txtEmail.Text + "','" + txtID.Text + "','" + gender + "','" + txtAdress.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been saved in the database");
                clear();
                display();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         }
        }
        public void clear()
        {
            txtName.Text = "";
            txtFName.Text = "";
            txtDesign.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtAdress.Text ="";
        }
        public void display()
        {
            try
            {
                dt =new DataTable();
            con.Open();
            adpt= new SqlDataAdapter("select* from Employee",con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close() ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDesign.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            radioButtonMale.Checked = true;
            radioButtonFemale.Checked = false;
            if(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()=="Female")
            {

                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }
            txtAdress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Update employee set");
               
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
