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
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SKT2C9JJ;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this._7_11DataSet.ProductType);
            // TODO: This line of code loads data into the '_7_11DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._7_11DataSet.Product);
            

        }

        private void tUser_KeyDown(object sender, KeyEventArgs e)
        {
            this.tUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void tPassword_Enter(object sender, EventArgs e)
        {
            tPassword.UseSystemPasswordChar = true;
            this.tPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where userName = '" + tUser.Text + "' AND userPwd = '" + tPassword.Text + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
