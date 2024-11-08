using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Survays_2024
{
   
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ayamani\Downloads\Database11.accdb");

        public Form1()
        {
            InitializeComponent();
            btnNextPage.Enabled = false;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            

          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            // Validation for FullName with spaces allowed
            string pattern = @"^[a-zA-Z\s]+$";

            // Validate the input
            if (!Regex.IsMatch(txtFullName.Text, pattern))
            {
                // Show a message or set an error
                MessageBox.Show("The name must contain only letters and spaces, without numbers or special characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFullName.Text = string.Empty;
                txtFullName.Focus();
                return;
            }

            // Validation for Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = string.Empty;
                txtEmail.Focus();
                return;
            }

            // Validation for Date of Birth in DD/MM/YYYY format
            string dobPattern = @"^(0[1-9]|1[0-9]|2[0-8])/(02)/([0-9]{4})$|^(29)/(02)/(([0-9]{2}(0[48]|[2468][048]|[13579][26]))|([02468][048]00)|([13579][26]00))$|^(0[1-9]|[12][0-9]|30)/(0[13-9]|1[0-2])/([0-9]{4})$|^(31)/(0[13578]|1[02])/([0-9]{4})$";

            if (!Regex.IsMatch(txtDOB.Text, dobPattern))
            {
                MessageBox.Show("Please enter a valid date of birth in the format DD/MM/YYYY.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDOB.Text = string.Empty;
                txtDOB.Focus();
                //txtDOB.ForeColorChanged += Color.Red;
                return;
            }

            // Validation for Contact Number to accept only 10 digits
            string contactPattern = @"^\d{10}$";
            if (!Regex.IsMatch(txtContactNumber.Text, contactPattern))
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNumber.Text = string.Empty;
                txtContactNumber.Focus();
                return;
            }
            //Validate if is there any checked box

            if (chkWatchTV.Checked || chkEatOut.Checked || chkMovies.Checked || chkPizza.Checked || chkPasta.Checked || chkRadio.Checked || chkPapaAndWors.Checked || chkOther.Checked)
            {

                //Connection to MS Access Database, inserting the values\\
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Survay_Data (FullNames, Email, DOB, ContactNumber, likeWatchTV, " +
                            "likeEatOut, likeRadio, likeMovies, likePizza, likePasta, likePapAndWors, likeOtherFood ) " + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                        //Adding personal details
                        cmd.Parameters.AddWithValue("?", txtFullName.Text);
                        cmd.Parameters.AddWithValue("?", txtEmail.Text);
                        cmd.Parameters.AddWithValue("?", DateTime.Parse(txtDOB.Text));
                        cmd.Parameters.AddWithValue("?", txtContactNumber.Text);

                        // The like to do check boxes
                        cmd.Parameters.AddWithValue("?", chkWatchTV.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkEatOut.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkRadio.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkMovies.Checked ? "Yes" : "No");

                        // The favourite food check boxes
                        cmd.Parameters.AddWithValue("?", chkPizza.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkPasta.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkPapaAndWors.Checked ? "Yes" : "No");
                        cmd.Parameters.AddWithValue("?", chkOther.Checked ? "Yes" : "No");

                        cmd.ExecuteNonQuery();

                    }
                    {
                        MessageBox.Show("Record is successfully added!");

                        //Disable every field
                        DisableAllFields();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check the check boxes as you choose what you like do and eat.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnNextPage.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                // Show a message box with "Yes" and "No" buttons
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Handle the user's choice
                if (result == DialogResult.Yes)
                {

                    this.Close();
                }
              
            }
           
        }

        private void chkLikeToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkWatchTV_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results results = new Results(this);
            results.Show();
            
        }

        public void DisableNextPageButton()
        {
            btnNextPage.Enabled = false;
        }

        public void ClearAllTextboxes()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtDOB.Clear();
            txtContactNumber.Clear();
        }

        public void UncheckBoxes()
        {
            chkWatchTV.Checked = false;
            chkEatOut.Checked = false;
            chkRadio.Checked = false;
            chkMovies.Checked = false;
            chkPizza.Checked = false;
            chkPasta.Checked = false;
            chkPapaAndWors.Checked = false;
            chkOther.Checked = false;
        }
        private void DisableAllFields()
        {
            txtFullName.Enabled = false;
            txtEmail.Enabled = false;
            txtDOB.Enabled = false;
            txtContactNumber.Enabled = false;

            chkWatchTV.Enabled = false;
            chkEatOut.Enabled = false;
            chkRadio.Enabled = false;
            chkMovies.Enabled = false;
            chkPizza.Enabled = false;
            chkPasta.Enabled = false;
            chkPapaAndWors.Enabled = false;
            chkOther.Enabled = false;

        }

        public void EnableAllFields()
        {
            txtFullName.Enabled = true;
            txtEmail.Enabled = true;
            txtDOB.Enabled = true;
            txtContactNumber.Enabled = true;

            chkWatchTV.Enabled = true;
            chkEatOut.Enabled = true;
            chkRadio.Enabled = true;
            chkMovies.Enabled = true;
            chkPizza.Enabled = true;
            chkPasta.Enabled = true;
            chkPapaAndWors.Enabled = true;
            chkOther.Enabled = true;

        }

    }
}
