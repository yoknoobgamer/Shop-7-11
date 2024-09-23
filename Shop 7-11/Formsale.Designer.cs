namespace Shop_7_11
{
    partial class Formsale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.nu_Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.la_ProName = new System.Windows.Forms.Label();
            this.la_ProAmount = new System.Windows.Forms.Label();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_Dot = new System.Windows.Forms.Button();
            this.b_Sale = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.la_Total = new System.Windows.Forms.Label();
            this.la_Cash = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.la_Change = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_7_11.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(340, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "จำนวน";
            // 
            // t_ID
            // 
            this.t_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.t_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.t_ID.Location = new System.Drawing.Point(125, 103);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(145, 36);
            this.t_ID.TabIndex = 4;
            this.t_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t_ID_KeyUp);
            // 
            // nu_Amount
            // 
            this.nu_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nu_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.nu_Amount.Location = new System.Drawing.Point(426, 103);
            this.nu_Amount.Name = "nu_Amount";
            this.nu_Amount.Size = new System.Drawing.Size(120, 36);
            this.nu_Amount.TabIndex = 5;
            this.nu_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_Amount.ValueChanged += new System.EventHandler(this.nu_Amount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "รายการสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(340, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "จำนวน";
            // 
            // la_ProName
            // 
            this.la_ProName.AutoSize = true;
            this.la_ProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.la_ProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.la_ProName.Location = new System.Drawing.Point(151, 168);
            this.la_ProName.Name = "la_ProName";
            this.la_ProName.Size = new System.Drawing.Size(111, 29);
            this.la_ProName.TabIndex = 8;
            this.la_ProName.Text = "..............";
            // 
            // la_ProAmount
            // 
            this.la_ProAmount.AutoSize = true;
            this.la_ProAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.la_ProAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.la_ProAmount.Location = new System.Drawing.Point(421, 168);
            this.la_ProAmount.Name = "la_ProAmount";
            this.la_ProAmount.Size = new System.Drawing.Size(111, 29);
            this.la_ProAmount.TabIndex = 9;
            this.la_ProAmount.Text = "..............";
            // 
            // b_OK
            // 
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_OK.Location = new System.Drawing.Point(538, 154);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 43);
            this.b_OK.TabIndex = 10;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_7
            // 
            this.b_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_7.Location = new System.Drawing.Point(608, 200);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(75, 50);
            this.b_7.TabIndex = 11;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
            // 
            // b_8
            // 
            this.b_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_8.Location = new System.Drawing.Point(689, 200);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(75, 50);
            this.b_8.TabIndex = 12;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
            // 
            // b_9
            // 
            this.b_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_9.Location = new System.Drawing.Point(770, 200);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(75, 50);
            this.b_9.TabIndex = 13;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
            // 
            // b_4
            // 
            this.b_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_4.Location = new System.Drawing.Point(608, 256);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(75, 50);
            this.b_4.TabIndex = 14;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_5
            // 
            this.b_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_5.Location = new System.Drawing.Point(689, 256);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(75, 50);
            this.b_5.TabIndex = 15;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_6
            // 
            this.b_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_6.Location = new System.Drawing.Point(770, 256);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(75, 50);
            this.b_6.TabIndex = 16;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // b_1
            // 
            this.b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_1.Location = new System.Drawing.Point(608, 312);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(75, 50);
            this.b_1.TabIndex = 17;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_2.Location = new System.Drawing.Point(689, 312);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(75, 50);
            this.b_2.TabIndex = 18;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_3
            // 
            this.b_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_3.Location = new System.Drawing.Point(770, 312);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(75, 50);
            this.b_3.TabIndex = 19;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_Clear.Location = new System.Drawing.Point(770, 368);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 50);
            this.b_Clear.TabIndex = 20;
            this.b_Clear.Text = "C";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_0
            // 
            this.b_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_0.Location = new System.Drawing.Point(608, 368);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(75, 50);
            this.b_0.TabIndex = 20;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = true;
            this.b_0.Click += new System.EventHandler(this.b_0_Click);
            // 
            // b_Dot
            // 
            this.b_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_Dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.b_Dot.Location = new System.Drawing.Point(689, 368);
            this.b_Dot.Name = "b_Dot";
            this.b_Dot.Size = new System.Drawing.Size(75, 50);
            this.b_Dot.TabIndex = 21;
            this.b_Dot.Text = ".";
            this.b_Dot.UseVisualStyleBackColor = true;
            this.b_Dot.Click += new System.EventHandler(this.b_Dot_Click);
            // 
            // b_Sale
            // 
            this.b_Sale.BackColor = System.Drawing.Color.LimeGreen;
            this.b_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.b_Sale.ForeColor = System.Drawing.Color.White;
            this.b_Sale.Location = new System.Drawing.Point(608, 440);
            this.b_Sale.Name = "b_Sale";
            this.b_Sale.Size = new System.Drawing.Size(237, 64);
            this.b_Sale.TabIndex = 22;
            this.b_Sale.Text = "Sale";
            this.b_Sale.UseVisualStyleBackColor = false;
            this.b_Sale.Click += new System.EventHandler(this.b_Sale_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.amount,
            this.price,
            this.sum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 215);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "รหัส";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "รายการสินค้า";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 140;
            // 
            // amount
            // 
            this.amount.HeaderText = "จำนวนสินค้า";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "ราคา";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 90;
            // 
            // sum
            // 
            this.sum.HeaderText = "รวม";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.Width = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(396, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "รวม";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(374, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "รับเงิน";
            // 
            // la_Total
            // 
            this.la_Total.AutoSize = true;
            this.la_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.la_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.la_Total.Location = new System.Drawing.Point(454, 424);
            this.la_Total.Name = "la_Total";
            this.la_Total.Size = new System.Drawing.Size(111, 29);
            this.la_Total.TabIndex = 26;
            this.la_Total.Text = "..............";
            // 
            // la_Cash
            // 
            this.la_Cash.AutoSize = true;
            this.la_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.la_Cash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.la_Cash.Location = new System.Drawing.Point(454, 454);
            this.la_Cash.Name = "la_Cash";
            this.la_Cash.Size = new System.Drawing.Size(111, 29);
            this.la_Cash.TabIndex = 27;
            this.la_Cash.Text = "..............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(392, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "ทอน";
            // 
            // la_Change
            // 
            this.la_Change.AutoSize = true;
            this.la_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.la_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(100)))));
            this.la_Change.Location = new System.Drawing.Point(454, 483);
            this.la_Change.Name = "la_Change";
            this.la_Change.Size = new System.Drawing.Size(111, 29);
            this.la_Change.TabIndex = 29;
            this.la_Change.Text = "..............";
            // 
            // Formsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.la_Change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.la_Cash);
            this.Controls.Add(this.la_Total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_Sale);
            this.Controls.Add(this.b_Dot);
            this.Controls.Add(this.b_0);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.b_6);
            this.Controls.Add(this.b_5);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_9);
            this.Controls.Add(this.b_8);
            this.Controls.Add(this.b_7);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.la_ProAmount);
            this.Controls.Add(this.la_ProName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nu_Amount);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formsale";
            this.Text = "7-11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.NumericUpDown nu_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label la_ProName;
        private System.Windows.Forms.Label la_ProAmount;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_7;
        private System.Windows.Forms.Button b_8;
        private System.Windows.Forms.Button b_9;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_0;
        private System.Windows.Forms.Button b_Dot;
        private System.Windows.Forms.Button b_Sale;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label la_Total;
        private System.Windows.Forms.Label la_Cash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label la_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}