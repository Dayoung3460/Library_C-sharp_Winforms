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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            // select books only available to issue.
            cmd = new SqlCommand("select bName from NewBook where bQuan > 0", con); 
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i=0; i<sdr.FieldCount; i++) // NewBook table row counts.
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                String enrollNo = txtSearch.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where sEnroll = '" + enrollNo + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // books issued and haven't returned yet.
                cmd.CommandText = "select count(sEnroll) from IRBook where sEnroll = '" + enrollNo + "' and returnDate is null"; 
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                // count how many book are issued to 1 student. max is 5.
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                

                if (ds.Tables[0].Rows.Count != 0)
                {
                    // get data from database table and put value in the textbox.
                    txtSname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepart.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemes.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtSname.Clear();
                    txtDepart.Clear();
                    txtSemes.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            String enroll = txtSearch.Text;
            String sname = txtSname.Text;
            String sdepart = txtDepart.Text;
            String semes = txtSemes.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;
            String bookname = comboBox1.Text;
            String issueDate = dateTimePicker1.Text;
          
                if (sname != "")
                {
                    if (comboBox1.SelectedIndex != -1 && count < 5) 
                    {
                        String enrollNo = txtSearch.Text;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        con.Open();
                        cmd.CommandText = "insert into IRBook (sEnroll, sName, sDepart, sSemes, sContact, sEmail, bName, IssueDate) values ('" + enroll + "', '" + sname + "', '" + sdepart + "', '" + semes + "', " + contact + ", '" + email + "','" + bookname + "', '" + issueDate + "')";
                        cmd.ExecuteNonQuery();

                        // seduct the book quantity as it's iss
                        cmd.CommandText = "update NewBook set bQuan = bQuan - 1 where  bName = '" + bookname + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Book issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Select book or Maximum of book has been issued.", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSname.Clear();
                txtDepart.Clear();
                txtDepart.Clear();
                txtSemes.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                comboBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Comfirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
