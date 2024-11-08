using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survays_2024
{
    public partial class Results : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ayamani\Downloads\Database11.accdb");

        private Form1 form1;
        public Results(Form1 form1Instance)
        {

            InitializeComponent();
            form1 = form1Instance;
            LoadDataIntoListBox();
        }

        private void LoadDataIntoListBox()
        {
            try
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT FullNames FROM Survay_Data";

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        lstResults.Items.Clear();

                        while (reader.Read())
                        {
                            lstResults.Items.Add(reader["FullNames"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            form1.DisableNextPageButton();

            //Enable all fields in form 1
            form1.EnableAllFields();

            //Clear all textboxes in form 1
            form1.ClearAllTextboxes();

            //Uncheck all checked boxes in form 1
            form1.UncheckBoxes();

            this.Hide();

           form1.Show();

          

        }
  
    }
}
