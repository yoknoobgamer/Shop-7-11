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
    public partial class Formproducttype : Form
    {
        public Formproducttype()
        {
            InitializeComponent();
        }

        private void productTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void Formproducttype_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this._7_11DataSet.ProductType);

        }
    }
}
