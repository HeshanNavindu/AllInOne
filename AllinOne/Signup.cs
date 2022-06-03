using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using AllinOne.DataLayer;

namespace AllinOne
{
    public partial class Signup : Form
    {
        SqlCommand cmd;
        SqlConnection con;

        public Signup()
        {
            InitializeComponent();
            //LoadDB();
        }

        public string LoadDB()
        {
            DB myDB = new DB();
            var dblink= myDB.DBConnection();
            return dblink;
        }


        

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

              

        }

        private void gunabtn_signup_Click(object sender, EventArgs e)
        {
            try
            {
              
                con.Open();
                cmd = new SqlCommand("insert into signuptable  values ('" + gunatxt_firstname.Text + "', '" + gunatxt_lastname.Text + "', '" + gunatxt_email.Text + "',  '" + gunaDOB.Value + "', '" + gunatxt_cnumber.Text + "', '" + gunacmb_gender.Text + "',  '" + gunatxt_password.Text + "', '" + gunatxt_cpassword.Text + "') ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                   MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                if (string.IsNullOrEmpty(gunatxt_firstname.Text))
                {
                    gunaerror_msg.Text = "First Name cannot be blank";
                    gunatxt_firstname.Focus();
                }
                else if (gunatxt_firstname.Text.Any(char.IsDigit))
                {
                    gunaerror_msg.Text = "First Name cannot have numbers";
                    gunatxt_firstname.Focus();
                }
                else if (string.IsNullOrEmpty(gunatxt_lastname.Text))
                {
                    gunaerror_msg.Text = "Last Name cannot be blank";
                    gunatxt_lastname.Focus();
                }
                else if (gunatxt_lastname.Text.Any(char.IsDigit))
                {
                    gunaerror_msg.Text = "Last Name cannot have numbers";
                    gunatxt_lastname.Focus();
                }
                else if (gunacmb_role.SelectedItem == null)
                {
                    gunaerror_msg.Text = "Please select role";
                    gunacmb_role.Focus();

                }
                else if (gunatxt_email.Text.Length == 0)
                {
                    gunaerror_msg.Text = "Please Enter Email Address";
                    gunatxt_email.Focus();
                }
                else if (!Regex.IsMatch(gunatxt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    gunaerror_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                    gunatxt_email.Focus();
                }
                else if (gunatxt_password.Text.Length == 0)
                {
                    gunaerror_msg.Text = "Please Enter your Password";
                    gunatxt_password.Focus();
                }
                else if (gunatxt_cpassword.Text.Length == 0)
                {
                    gunaerror_msg.Text = "Please Enter your Confirm Password";
                    gunatxt_cpassword.Focus();
                }
                else if (gunatxt_password != gunatxt_cpassword)
                {
                    gunaerror_msg.Text = "Confirm Password must same as the Password";
                    gunatxt_cpassword.Focus();
                }
                else if (gunacmb_gender.SelectedItem == null)
                {
                    gunaerror_msg.Text = "Please select gender";
                    gunacmb_gender.Focus();

                }
                else if (!gunacheckbox.Checked && !gunacheckbox.Checked)
                {
                    gunaerror_msg.Text = "Please agree";
                    gunacheckbox.Focus();

                }
                else if (!Regex.IsMatch(gunatxt_cnumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    gunaerror_msg.Text = "TP must have 10 numbers";
                    gunatxt_cnumber.Focus();
                }
                else
                {
                    gunaerror_msg.Text = "";
                    MessageBox.Show("Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                cmd.Dispose();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void gunaDOB_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - gunaDOB.Value.Year; 
            

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
