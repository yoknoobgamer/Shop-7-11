namespace Shop_7_11
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._7_11DataSet = new Shop_7_11._7_11DataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Shop_7_11._7_11DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Shop_7_11._7_11DataSetTableAdapters.TableAdapterManager();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new Shop_7_11._7_11DataSetTableAdapters.ProductTypeTableAdapter();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this._7_11DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shop_7_11._7_11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this._7_11DataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(180)))), ((int)(((byte)(164)))));
            this.tUser.Location = new System.Drawing.Point(176, 251);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(161, 29);
            this.tUser.TabIndex = 1;
            this.tUser.Text = "  Username";
            this.tUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tUser_KeyDown);
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(180)))), ((int)(((byte)(164)))));
            this.tPassword.Location = new System.Drawing.Point(176, 306);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(161, 29);
            this.tPassword.TabIndex = 3;
            this.tPassword.Text = "  Password";
            this.tPassword.Enter += new System.EventHandler(this.tPassword_Enter);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(180)))), ((int)(((byte)(164)))));
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bLogin.Location = new System.Drawing.Point(149, 364);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(221, 59);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_7_11.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tUser);
            this.Name = "FormLogin";
            this.Text = "7-11";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private _7_11DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private _7_11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private _7_11DataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bLogin;
    }
}

