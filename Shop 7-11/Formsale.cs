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
    public partial class Formsale : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SKT2C9JJ;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int proCount = 0;
        string numCash = null;
        public Formsale()
        {
            InitializeComponent();
        }

        private void t_ID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (t_ID.TextLength == 4)
                {
                    cmd = new SqlCommand("SELECT * FROM product WHERE pID = " + t_ID.Text + "", conn);
                    conn.Open();
                    adapter = new SqlDataAdapter(cmd);
                    conn.Close();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    la_ProName.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    la_ProAmount.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM product WHERE pID = " + t_ID.Text + "", conn);
                conn.Open();
                adapter = new SqlDataAdapter(cmd);
                conn.Close();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                int p = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[2]);
                int a = Convert.ToInt16(la_ProAmount.Text);
                int total = p * a;
                string[] row = new string[] { "" + ds.Tables[0].Rows[0].ItemArray[0], "" + ds.Tables[0].Rows[0].ItemArray[1], "" + la_ProAmount.Text, "" + ds.Tables[0].Rows[0].ItemArray[2], "" + total };
                dataGridView1.Rows.Add(row);
                proCount++;
                calTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void calTotal()
        {

            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            la_Total.Text = string.Format(" {0:#,##0.00}", double.Parse(total.ToString()));
        }
        private void getCash(String getCash)
        {
            numCash += getCash;
            la_Cash.Text = string.Format(" {0:#,##0.00}", double.Parse(numCash));
        }


        private void nu_Amount_ValueChanged(object sender, EventArgs e)
        {
            la_ProAmount.Text = nu_Amount.Value.ToString();
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            getCash("1");
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            getCash("2");
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            getCash("3");
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            getCash("4");
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            getCash("5");
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            getCash("6");
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            getCash("7");
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            getCash("8");
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            getCash("9");
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            getCash("0");
        }

        private void b_Dot_Click(object sender, EventArgs e)
        {
            getCash(".");
        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            numCash = null;
            la_Cash.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    calTotal();
                }
            }
        }

        private void b_Sale_Click(object sender, EventArgs e)
        {
            if (la_Cash.Text == string.Empty)
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(la_Cash.Text) < Convert.ToDouble(la_Total.Text))
            {
                MessageBox.Show("ใส่จำนวนเงินให้มากกว่าราคารวม", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double change = Convert.ToDouble(la_Cash.Text) - Convert.ToDouble(la_Total.Text);
                la_Change.Text = change.ToString();
                updateAmount();
            }
        }
        private void updateAmount()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)

                    {
                        cmd = new SqlCommand("UPDATE product SET pAmount=pAmount-" + row.Cells[2].Value + "WHERE pID=" + row.Cells[0].Value + "", conn);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("฿ Sale Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}

