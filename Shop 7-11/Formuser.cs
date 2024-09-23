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
    public partial class Formuser : Form
    {
        public Formuser()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void Formuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._7_11DataSet.Users);

        }
    }
}
