using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? This will DELETE your unsaved data.", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Four blanks are needed to fill up.
            if (txtStudentName.Text != "" && txtEnrollNo.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
                String sName = txtStudentName.Text;
                String sNo = txtEnrollNo.Text;
                String sDepart = txtDepart.Text;
                String sSemes = txtSemes.Text;
                Int64 sContact = Int64.Parse(txtContact.Text);
                String sEmail = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (sName, sEnroll, sDepart, sSemester, sContact, sEmail) values ('" + sName + "','" + sNo + "','" + sDepart + "','" + sSemes + "'," + sContact + ",'" + sEmail + "')";
                cmd.ExecuteNonQuery(); // Data will be inserted.
                con.Close();

                // Make the blanks empty.
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentName.Clear();
                txtEnrollNo.Clear();
                txtDepart.Clear();
                txtSemes.Clear();
                txtEmail.Clear();
                txtContact.Clear();
            }

            else
            {
                MessageBox.Show("Student's name, enrollment No, contact and Email are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEnrollNo.Clear();
            txtDepart.Clear();
            txtSemes.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
    }
}
