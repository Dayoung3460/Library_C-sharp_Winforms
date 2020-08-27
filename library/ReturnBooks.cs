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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where sEnroll ='"+txtSearch.Text+"' and returnDate IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            txtSearch.Clear();
        }

        String bName;
        String bIssueDate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelInfo.Visible = true;
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bName = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bIssueDate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }

            txtBname.Text = bName;
            txtIssueDate.Text = bIssueDate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 303-01 ; database = libraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "update IRBook set returnDate = '"+ txtReturnDate.Text+"' where sEnroll = '"+txtSearch.Text+"' and id = "+rowid+"";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "update NewBook set bQuan = bQuan + 1 where bName = '" + txtBname.Text + "'";
            
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReturnBooks_Load(this, null); // reset the returnBooks form.
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                panelInfo.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
        }
    }
}
