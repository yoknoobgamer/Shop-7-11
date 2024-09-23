namespace Shop_7_11
{
    partial class FormuserNew
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
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tFirstname = new System.Windows.Forms.TextBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tLastname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this._7_11DataSet = new Shop_7_11._7_11DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Shop_7_11._7_11DataSetTableAdapters.UsersTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.tSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 98);
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
            this.label1.Size = new System.Drawing.Size(89, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
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
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tPassword.Location = new System.Drawing.Point(590, 215);
            this.tPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(186, 45);
            this.tPassword.TabIndex = 25;
            // 
            // tUsername
            // 
            this.tUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tUsername.Location = new System.Drawing.Point(201, 215);
            this.tUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(216, 45);
            this.tUsername.TabIndex = 24;
            // 
            // tEmail
            // 
            this.tEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tEmail.Location = new System.Drawing.Point(375, 114);
            this.tEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(401, 45);
            this.tEmail.TabIndex = 23;
            // 
            // tFirstname
            // 
            this.tFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tFirstname.Location = new System.Drawing.Point(201, 166);
            this.tFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tFirstname.Name = "tFirstname";
            this.tFirstname.Size = new System.Drawing.Size(216, 45);
            this.tFirstname.TabIndex = 22;
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tID.Location = new System.Drawing.Point(83, 114);
            this.tID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(172, 45);
            this.tID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(421, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "PassWord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(261, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(423, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 39);
            this.label7.TabIndex = 26;
            this.label7.Text = "LastName";
            // 
            // tLastname
            // 
            this.tLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tLastname.Location = new System.Drawing.Point(590, 166);
            this.tLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLastname.Name = "tLastname";
            this.tLastname.Size = new System.Drawing.Size(186, 45);
            this.tLastname.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userFnameDataGridViewTextBoxColumn,
            this.userLnameDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPwdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 228);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.bDelete.Location = new System.Drawing.Point(784, 218);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(83, 42);
            this.bDelete.TabIndex = 31;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bEdit.Location = new System.Drawing.Point(784, 167);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(83, 42);
            this.bEdit.TabIndex = 30;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAdd.Location = new System.Drawing.Point(784, 115);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(83, 42);
            this.bAdd.TabIndex = 29;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._7_11DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userFnameDataGridViewTextBoxColumn
            // 
            this.userFnameDataGridViewTextBoxColumn.DataPropertyName = "userFname";
            this.userFnameDataGridViewTextBoxColumn.HeaderText = "userFname";
            this.userFnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userFnameDataGridViewTextBoxColumn.Name = "userFnameDataGridViewTextBoxColumn";
            // 
            // userLnameDataGridViewTextBoxColumn
            // 
            this.userLnameDataGridViewTextBoxColumn.DataPropertyName = "userLname";
            this.userLnameDataGridViewTextBoxColumn.HeaderText = "userLname";
            this.userLnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLnameDataGridViewTextBoxColumn.Name = "userLnameDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPwdDataGridViewTextBoxColumn
            // 
            this.userPwdDataGridViewTextBoxColumn.DataPropertyName = "userPwd";
            this.userPwdDataGridViewTextBoxColumn.HeaderText = "userPwd";
            this.userPwdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPwdDataGridViewTextBoxColumn.Name = "userPwdDataGridViewTextBoxColumn";
            // 
            // FormuserNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 502);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tLastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.tFirstname);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormuserNew";
            this.Text = "FormuserNew";
            this.Load += new System.EventHandler(this.FormuserNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tFirstname;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tLastname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _7_11DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPwdDataGridViewTextBoxColumn;
    }
}