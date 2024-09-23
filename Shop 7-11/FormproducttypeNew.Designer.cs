namespace Shop_7_11
{
    partial class FormproducttypeNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.Button();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._7_11DataSet = new Shop_7_11._7_11DataSet();
            this.productTypeTableAdapter = new Shop_7_11._7_11DataSetTableAdapters.ProductTypeTableAdapter();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.tSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 101);
            this.panel1.TabIndex = 2;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bSearch.Location = new System.Drawing.Point(744, 26);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(124, 42);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tSearch.Location = new System.Drawing.Point(507, 23);
            this.tSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(231, 45);
            this.tSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_7_11.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tName.Location = new System.Drawing.Point(496, 117);
            this.tName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(271, 45);
            this.tName.TabIndex = 19;
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tID.Location = new System.Drawing.Point(91, 117);
            this.tID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(232, 45);
            this.tID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(383, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.bDelete.Location = new System.Drawing.Point(781, 229);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(83, 42);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bEdit.Location = new System.Drawing.Point(781, 182);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(83, 42);
            this.bEdit.TabIndex = 21;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAdd.Location = new System.Drawing.Point(781, 133);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(83, 42);
            this.bAdd.TabIndex = 20;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productTypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 306);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this._7_11DataSet;
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "tID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "รหัสประเภทสินค้า";
            this.tIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "tName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "ชื่อประเภทสินค้า";
            this.tNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.Width = 570;
            // 
            // FormproducttypeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormproducttypeNew";
            this.Text = "FormproducttypeNew";
            this.Load += new System.EventHandler(this.FormproducttypeNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private _7_11DataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
    }
}