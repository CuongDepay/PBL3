namespace PBL3
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butSapXep = new System.Windows.Forms.Button();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.butXem = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTKiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butTKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butManageCustomer = new System.Windows.Forms.Button();
            this.btnOut9 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.butSapXep);
            this.panel1.Controls.Add(this.cbbSapXep);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtTKiem);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butTKiem);
            this.panel1.Location = new System.Drawing.Point(162, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 605);
            this.panel1.TabIndex = 0;
            // 
            // butSapXep
            // 
            this.butSapXep.BackColor = System.Drawing.Color.Yellow;
            this.butSapXep.Location = new System.Drawing.Point(846, 411);
            this.butSapXep.Name = "butSapXep";
            this.butSapXep.Size = new System.Drawing.Size(78, 30);
            this.butSapXep.TabIndex = 14;
            this.butSapXep.Text = "Sắp xếp";
            this.butSapXep.UseVisualStyleBackColor = false;
            this.butSapXep.Click += new System.EventHandler(this.butSapXep_Click_1);
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(711, 415);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(132, 25);
            this.cbbSapXep.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.HotPink;
            this.groupBox2.Controls.Add(this.butLamMoi);
            this.groupBox2.Controls.Add(this.txtDC);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.butXem);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.butXoa);
            this.groupBox2.Controls.Add(this.butSua);
            this.groupBox2.Controls.Add(this.butThem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(49, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 254);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // butLamMoi
            // 
            this.butLamMoi.BackColor = System.Drawing.Color.Yellow;
            this.butLamMoi.Location = new System.Drawing.Point(691, 99);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(89, 34);
            this.butLamMoi.TabIndex = 13;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = false;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(542, 52);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(238, 25);
            this.txtDC.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(229, 99);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 25);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // butXem
            // 
            this.butXem.BackColor = System.Drawing.Color.Yellow;
            this.butXem.Location = new System.Drawing.Point(113, 174);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(89, 34);
            this.butXem.TabIndex = 12;
            this.butXem.Text = "Xem";
            this.butXem.UseVisualStyleBackColor = false;
            this.butXem.Click += new System.EventHandler(this.butXem_Click_1);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(229, 57);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(185, 25);
            this.txtTenKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.HotPink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(476, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.Color.Yellow;
            this.butXoa.Location = new System.Drawing.Point(691, 174);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(89, 34);
            this.butXoa.TabIndex = 0;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click_1);
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.Color.Yellow;
            this.butSua.Location = new System.Drawing.Point(479, 174);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(89, 34);
            this.butSua.TabIndex = 0;
            this.butSua.Text = "Chỉnh sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click_1);
            // 
            // butThem
            // 
            this.butThem.BackColor = System.Drawing.Color.Yellow;
            this.butThem.Location = new System.Drawing.Point(294, 174);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(89, 34);
            this.butThem.TabIndex = 0;
            this.butThem.Text = "Thêm mới";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click_1);
            this.butThem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.butThem_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.HotPink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khách hàng";
            // 
            // txtTKiem
            // 
            this.txtTKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKiem.Location = new System.Drawing.Point(711, 350);
            this.txtTKiem.Name = "txtTKiem";
            this.txtTKiem.Size = new System.Drawing.Size(132, 25);
            this.txtTKiem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // butTKiem
            // 
            this.butTKiem.BackColor = System.Drawing.Color.Yellow;
            this.butTKiem.Location = new System.Drawing.Point(846, 346);
            this.butTKiem.Name = "butTKiem";
            this.butTKiem.Size = new System.Drawing.Size(78, 30);
            this.butTKiem.TabIndex = 0;
            this.butTKiem.Text = "Tìm kiếm";
            this.butTKiem.UseVisualStyleBackColor = false;
            this.butTKiem.Click += new System.EventHandler(this.butTKiem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // butManageCustomer
            // 
            this.butManageCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.butManageCustomer.FlatAppearance.BorderSize = 0;
            this.butManageCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butManageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.butManageCustomer.ForeColor = System.Drawing.Color.White;
            this.butManageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("butManageCustomer.Image")));
            this.butManageCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butManageCustomer.Location = new System.Drawing.Point(505, 12);
            this.butManageCustomer.Name = "butManageCustomer";
            this.butManageCustomer.Size = new System.Drawing.Size(293, 73);
            this.butManageCustomer.TabIndex = 5;
            this.butManageCustomer.Text = "            Khách Hàng ";
            this.butManageCustomer.UseVisualStyleBackColor = false;
            // 
            // btnOut9
            // 
            this.btnOut9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut9.Image = ((System.Drawing.Image)(resources.GetObject("btnOut9.Image")));
            this.btnOut9.Location = new System.Drawing.Point(1248, 12);
            this.btnOut9.Name = "btnOut9";
            this.btnOut9.Size = new System.Drawing.Size(20, 20);
            this.btnOut9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut9.TabIndex = 13;
            this.btnOut9.TabStop = false;
            this.btnOut9.Click += new System.EventHandler(this.btnOut9_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 734);
            this.Controls.Add(this.btnOut9);
            this.Controls.Add(this.butManageCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut9)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butManageCustomer;
        private System.Windows.Forms.PictureBox btnOut9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTKiem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button butTKiem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butXem;
        private System.Windows.Forms.Button butSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.Button butLamMoi;
    }
}