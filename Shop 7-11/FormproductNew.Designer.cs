namespace Shop_7_11
{
    partial class FormproductNew
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.tType = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._7_11DataSet = new Shop_7_11._7_11DataSet();
            this.productTableAdapter = new Shop_7_11._7_11DataSetTableAdapters.ProductTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.tSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 82);
            this.panel1.TabIndex = 1;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bSearch.Location = new System.Drawing.Point(558, 21);
            this.bSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(93, 34);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tSearch.Location = new System.Drawing.Point(380, 19);
            this.tSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(174, 38);
            this.tSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(214, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(214, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(423, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tID.Location = new System.Drawing.Point(59, 97);
            this.tID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(129, 38);
            this.tID.TabIndex = 7;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tName.Location = new System.Drawing.Point(299, 99);
            this.tName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(162, 38);
            this.tName.TabIndex = 8;
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tPrice.Location = new System.Drawing.Point(93, 146);
            this.tPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(88, 38);
            this.tPrice.TabIndex = 9;
            // 
            // tAmount
            // 
            this.tAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tAmount.Location = new System.Drawing.Point(318, 148);
            this.tAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(91, 38);
            this.tAmount.TabIndex = 10;
            // 
            // tType
            // 
            this.tType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tType.Location = new System.Drawing.Point(502, 148);
            this.tType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tType.Name = "tType";
            this.tType.Size = new System.Drawing.Size(83, 38);
            this.tType.TabIndex = 11;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAdd.Location = new System.Drawing.Point(589, 161);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(62, 34);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bEdit.Location = new System.Drawing.Point(589, 201);
            this.bEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(62, 34);
            this.bEdit.TabIndex = 13;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.bDelete.Location = new System.Drawing.Point(589, 239);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(62, 34);
            this.bDelete.TabIndex = 14;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pPriceDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 235);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "pID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า";
            this.pIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "ชื่อสินค้า";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pPriceDataGridViewTextBoxColumn
            // 
            this.pPriceDataGridViewTextBoxColumn.DataPropertyName = "pPrice";
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "ราคาสินค้า";
            this.pPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "จำนวนสินค้า";
            this.pAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "tID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "ประเภทสินค้า";
            this.tIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this._7_11DataSet;
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_7_11.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormproductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tType);
            this.Controls.Add(this.tAmount);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormproductNew";
            this.Text = "FormproductNew";
            this.Load += new System.EventHandler(this.FormproductNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.TextBox tType;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private _7_11DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
    }
}