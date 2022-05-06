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
using Microsoft.Office.Interop.Excel;

namespace WindowsForms_App21
{
    public partial class Registration : Form
    {
        //string connection
        
        string path = @"Data Source =DESKTOP-PTQ7CTJ\SQLEXPRESS;Initial Catalog=registration;Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;


        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
                dt = new System.Data.DataTable();
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
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string gender;

                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                con.Open();
                cmd = new SqlCommand("Update employee set Employee_Name='"+txtName.Text+ "',Employee_FName='" + txtFName.Text + "',Employee_Designation='" + txtDesign.Text + "',Employee_Email='" + txtEmail.Text + "',Emp_ID='" + txtID.Text + "',gender='" + gender + "',Adress='" + txtAdress.Text + "' where Employee_Id='"+ID+"'",con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Your data has been updated");
                display();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from employee where Employee_Id='" + ID + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Your record has been deleted");
                display();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt = new System.Data.DataTable();
            con.Open();
            adpt = new SqlDataAdapter("select * from Employee where Employee_Name like '% "+txtSearch.Text+"%'", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

          try
          {
                Microsoft.Office.Interop.Excel.Application Excell = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excell.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excell.ActiveSheet;
            Excell.Visible = true;

            for (int j= 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <=1; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
            for (int i = 1; i<= dataGridView1.Columns.Count +1 ; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.Columns.Count ; j++)
                {
                    ws.Cells[i+2, j+1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
          }
          catch (Exception )
          {
                
          }
        }
    }
}
