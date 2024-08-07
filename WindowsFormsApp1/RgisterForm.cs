using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RgisterForm : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\form.mdf;Integrated Security=True;Connect Timeout=30");
        public RgisterForm()
        {
            InitializeComponent();
        }

        private void RgisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
             Form1 loginForm = new Form1(); 
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blanks fields"
                   , "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open) 
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER ID EXISTING ALREADY
                        string selectUsername = "SELECT COUNT (id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect)) 
                        { 
                            checkUser.Parameters.AddWithValue("@user",signup_username.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users" +
                                    "(username, password, date_register)" +

                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                       

                    }catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                 , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally 
                    {
                       connect.Close();
                    }
                }
            }
        }
    }
}
