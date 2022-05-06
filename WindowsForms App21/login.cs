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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-PTQ7CTJ\SQLEXPRESS;Initial Catalog=registration;Integrated Security = True");
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter User name and Password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("selct* from LoginUsers where U_Name=@Name and U_Pass=@Pass");
                    cmd.Parameters.Add("@Name", txtUser.Text);
                    cmd.Parameters.Add("@Pass", txtPassword.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int Count = ds.Tables[0].Rows.Count;
                    if (Count == 1)
                    {
                        MessageBox.Show("You have successfully logged in ");
                        Form1 ob =new Form1();
                        this.Hide();
                        ob.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter User name and Password");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
