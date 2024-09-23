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

namespace Shop_7_11
{
    public partial class FormproductNew : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SKT2C9JJ;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormproductNew()
        {
            InitializeComponent();
        }

        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", tID.Text);
            cmd.Parameters.AddWithValue("name", tName.Text);
            cmd.Parameters.AddWithValue("price", tPrice.Text);
            cmd.Parameters.AddWithValue("amount", tAmount.Text);
            cmd.Parameters.AddWithValue("type", tType.Text);
            cmd.Parameters.AddWithValue("search", tSearch.Text);
        }

        private void FormproductNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._7_11DataSet.Product);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                tID.Text = row.Cells[0].Value.ToString();
                tName.Text = row.Cells[1].Value.ToString();
                tPrice.Text = row.Cells[2].Value.ToString();
                tAmount.Text = row.Cells[3].Value.ToString();
                tType.Text = row.Cells[4].Value.ToString();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE product SET pName=@name,pPrice=@price,pAmount=@amount WHERE pID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1) 
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.Product);
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
                cmd = new SqlCommand("INSERT INTO product (pID,pName,pPrice,pAmount,tID)VALUES(@id,@name,@price,@amount,@type)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.Product);
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
                cmd = new SqlCommand("DELETE FROM product WHERE pID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.Product);
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
                cmd = new SqlCommand("SELECT * FROM product WHERE pID LIKE @search+'%' OR pName LIKE @search+'%' OR pPrice LIKE @search+'%' OR pAmount LIKE @search+'%' OR tID LIKE @search+'%'", conn);
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
