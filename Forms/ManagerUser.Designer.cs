namespace PBL3
{
    partial class ManagerUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; /// <summary>
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
        #region Windows Form Designer generated code /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butLammoi = new System.Windows.Forms.Button();
            this.butXem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.butSua = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butTKiem = new System.Windows.Forms.Button();
            this.txtTKiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.butXep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOut1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.imageNV = new System.Windows.Forms.PictureBox();
            this.butAnh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.butLammoi);
            this.groupBox1.Controls.Add(this.butXem);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.butSua);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.butThem);
            this.groupBox1.Controls.Add(this.butXoa);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtIDNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(159, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butLammoi
            // 
            this.butLammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butLammoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLammoi.ForeColor = System.Drawing.Color.White;
            this.butLammoi.Location = new System.Drawing.Point(667, 227);
            this.butLammoi.Name = "butLammoi";
            this.butLammoi.Size = new System.Drawing.Size(95, 32);
            this.butLammoi.TabIndex = 8;
            this.butLammoi.Text = "Làm mới ";
            this.butLammoi.UseVisualStyleBackColor = false;
            this.butLammoi.Click += new System.EventHandler(this.butLammoi_Click);
            // 
            // butXem
            // 
            this.butXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butXem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXem.ForeColor = System.Drawing.Color.White;
            this.butXem.Location = new System.Drawing.Point(52, 227);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(95, 32);
            this.butXem.TabIndex = 7;
            this.butXem.Text = "Xem";
            this.butXem.UseVisualStyleBackColor = false;
            this.butXem.Click += new System.EventHandler(this.butXem_Click_1);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(573, 109);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 25);
            this.txtSDT.TabIndex = 4;
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSua.ForeColor = System.Drawing.Color.White;
            this.butSua.Location = new System.Drawing.Point(346, 227);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(95, 32);
            this.butSua.TabIndex = 6;
            this.butSua.Text = "Chỉnh sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click_1);
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(573, 42);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(169, 25);
            this.txtDC.TabIndex = 4;
            // 
            // butThem
            // 
            this.butThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.ForeColor = System.Drawing.Color.White;
            this.butThem.Location = new System.Drawing.Point(194, 227);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(95, 32);
            this.butThem.TabIndex = 6;
            this.butThem.Text = "Thêm mới";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click_1);
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.ForeColor = System.Drawing.Color.White;
            this.butXoa.Location = new System.Drawing.Point(502, 227);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(95, 32);
            this.butXoa.TabIndex = 6;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click_1);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(169, 111);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(169, 25);
            this.txtTenNV.TabIndex = 4;
            // 
            // txtIDNV
            // 
            this.txtIDNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNV.Location = new System.Drawing.Point(169, 42);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.Size = new System.Drawing.Size(169, 25);
            this.txtIDNV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(448, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số điện thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNu);
            this.groupBox2.Controls.Add(this.rdNam);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(453, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(204, -1);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(49, 21);
            this.rdNu.TabIndex = 0;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(100, -1);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(59, 21);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(448, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // butTKiem
            // 
            this.butTKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butTKiem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTKiem.ForeColor = System.Drawing.Color.White;
            this.butTKiem.Location = new System.Drawing.Point(17, 34);
            this.butTKiem.Name = "butTKiem";
            this.butTKiem.Size = new System.Drawing.Size(97, 28);
            this.butTKiem.TabIndex = 5;
            this.butTKiem.Text = "Tìm kiếm";
            this.butTKiem.UseVisualStyleBackColor = false;
            this.butTKiem.Click += new System.EventHandler(this.butTKiem_Click_1);
            // 
            // txtTKiem
            // 
            this.txtTKiem.Location = new System.Drawing.Point(120, 35);
            this.txtTKiem.Name = "txtTKiem";
            this.txtTKiem.Size = new System.Drawing.Size(169, 22);
            this.txtTKiem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 201);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Magenta;
            this.groupBox3.Controls.Add(this.txtTKiem);
            this.groupBox3.Controls.Add(this.butTKiem);
            this.groupBox3.Controls.Add(this.cbbSapXep);
            this.groupBox3.Controls.Add(this.butXep);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(159, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1062, 313);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(734, 37);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(168, 24);
            this.cbbSapXep.TabIndex = 7;
            // 
            // butXep
            // 
            this.butXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butXep.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXep.ForeColor = System.Drawing.Color.White;
            this.butXep.Location = new System.Drawing.Point(908, 34);
            this.butXep.Name = "butXep";
            this.butXep.Size = new System.Drawing.Size(83, 28);
            this.butXep.TabIndex = 6;
            this.butXep.Text = "Sắp xếp";
            this.butXep.UseVisualStyleBackColor = false;
            this.butXep.Click += new System.EventHandler(this.butXep_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // btnOut1
            // 
            this.btnOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut1.Image = ((System.Drawing.Image)(resources.GetObject("btnOut1.Image")));
            this.btnOut1.Location = new System.Drawing.Point(1233, 12);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(20, 20);
            this.btnOut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut1.TabIndex = 21;
            this.btnOut1.TabStop = false;
            this.btnOut1.Click += new System.EventHandler(this.btnOut1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(505, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(293, 73);
            this.btnUser.TabIndex = 19;
            this.btnUser.Text = "         Quản Lý Nhân Viên";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // imageNV
            // 
            this.imageNV.BackColor = System.Drawing.Color.White;
            this.imageNV.Location = new System.Drawing.Point(1010, 110);
            this.imageNV.Name = "imageNV";
            this.imageNV.Size = new System.Drawing.Size(211, 235);
            this.imageNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNV.TabIndex = 22;
            this.imageNV.TabStop = false;
            // 
            // butAnh
            // 
            this.butAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAnh.Location = new System.Drawing.Point(1021, 364);
            this.butAnh.Name = "butAnh";
            this.butAnh.Size = new System.Drawing.Size(186, 43);
            this.butAnh.TabIndex = 1;
            this.butAnh.Text = "Tải ảnh";
            this.butAnh.UseVisualStyleBackColor = false;
            this.butAnh.Click += new System.EventHandler(this.butAnh_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1265, 750);
            this.Controls.Add(this.butAnh);
            this.Controls.Add(this.imageNV);
            this.Controls.Add(this.btnOut1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerUser";
            this.Text = "ManagerUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNV)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTKiem;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butTKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butXep;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnOut1;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button butXem;
        private System.Windows.Forms.PictureBox imageNV;
        private System.Windows.Forms.Button butAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLammoi;
    }
}

