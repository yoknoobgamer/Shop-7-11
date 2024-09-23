using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_7_11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormproductNew formProduct = new FormproductNew();
            formProduct.MdiParent = this;
            formProduct.Dock = DockStyle.Fill;
            formProduct.Show();
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormproducttypeNew formProductType = new FormproducttypeNew();
            formProductType.MdiParent = this;
            formProductType.Dock = DockStyle.Fill;
            formProductType.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormuserNew formUser = new FormuserNew();
            formUser.MdiParent = this;
            formUser.Dock = DockStyle.Fill;
            formUser.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Formsale formSale = new Formsale();
            formSale.MdiParent = this;
            formSale.Dock = DockStyle.Fill;
            formSale.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
