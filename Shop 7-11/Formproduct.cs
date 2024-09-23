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
    public partial class Formproduct : Form
    {
        public Formproduct()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void Formproduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._7_11DataSet.Product);

        }
    }
}
