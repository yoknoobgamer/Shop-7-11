using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_7_11
{
    public partial class FormuserNew : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SKT2C9JJ;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormuserNew()
        {
            InitializeComponent();
        }
        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", tID.Text);
            cmd.Parameters.AddWithValue("email", tEmail.Text);
            cmd.Parameters.AddWithValue("fname", tFirstname.Text);
            cmd.Parameters.AddWithValue("lname", tLastname.Text);
            cmd.Parameters.AddWithValue("user", tUsername.Text);
            cmd.Parameters.AddWithValue("pwd", tPassword.Text);
            cmd.Parameters.AddWithValue("search", tSearch.Text);
        }

        private void FormuserNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._7_11DataSet.Users);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                tID.Text = row.Cells[0].Value.ToString();
                tEmail.Text = row.Cells[1].Value.ToString();
                tFirstname.Text = row.Cells[2].Value.ToString();
                tLastname.Text = row.Cells[3].Value.ToString();
                tUsername.Text = row.Cells[4].Value.ToString();
                tPassword.Text = row.Cells[5].Value.ToString();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE users SET userFname=@fname,userLname=@lname,userEmail=@email,userName=@user WHERE userID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.Users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO users (userID,userFname,userLname,userEmail,userName,userPwd)VALUES(@id,@fname,@lname,@email,@user,@pwd)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.Users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM users WHERE userID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.Users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM users WHERE userID LIKE @search+'%' OR userFname LIKE @search+'%' OR userLname LIKE @search+'%' OR userEmail LIKE @search+'%' OR userName LIKE @search+'%' OR userPwd LIKE @search+'%'", conn);
                parameter();
                conn.Open();
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No data", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
