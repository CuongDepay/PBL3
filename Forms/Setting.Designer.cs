
namespace PBL3
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butXóa = new System.Windows.Forms.Button();
            this.butSửa = new System.Windows.Forms.Button();
            this.butThêm = new System.Windows.Forms.Button();
            this.butXem = new System.Windows.Forms.Button();
            this.cbbID_NV = new System.Windows.Forms.ComboBox();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtID_TK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTkiem = new System.Windows.Forms.TextBox();
            this.cbbSX = new System.Windows.Forms.ComboBox();
            this.butTìm = new System.Windows.Forms.Button();
            this.butXếp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnOut5
            // 
            this.btnOut5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut5.Image = ((System.Drawing.Image)(resources.GetObject("btnOut5.Image")));
            this.btnOut5.Location = new System.Drawing.Point(1248, 12);
            this.btnOut5.Name = "btnOut5";
            this.btnOut5.Size = new System.Drawing.Size(20, 20);
            this.btnOut5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut5.TabIndex = 5;
            this.btnOut5.TabStop = false;
            this.btnOut5.Click += new System.EventHandler(this.btnOut5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.butLamMoi);
            this.groupBox1.Controls.Add(this.butXóa);
            this.groupBox1.Controls.Add(this.butSửa);
            this.groupBox1.Controls.Add(this.butThêm);
            this.groupBox1.Controls.Add(this.butXem);
            this.groupBox1.Controls.Add(this.cbbID_NV);
            this.groupBox1.Controls.Add(this.cbbCV);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.txtID_TK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(141, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // butLamMoi
            // 
            this.butLamMoi.BackColor = System.Drawing.Color.Magenta;
            this.butLamMoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLamMoi.Location = new System.Drawing.Point(830, 201);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(98, 37);
            this.butLamMoi.TabIndex = 14;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = false;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // butXóa
            // 
            this.butXóa.BackColor = System.Drawing.Color.Magenta;
            this.butXóa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXóa.Location = new System.Drawing.Point(641, 201);
            this.butXóa.Name = "butXóa";
            this.butXóa.Size = new System.Drawing.Size(89, 37);
            this.butXóa.TabIndex = 13;
            this.butXóa.Text = "Xóa";
            this.butXóa.UseVisualStyleBackColor = false;
            this.butXóa.Click += new System.EventHandler(this.butXóa_Click);
            // 
            // butSửa
            // 
            this.butSửa.BackColor = System.Drawing.Color.Magenta;
            this.butSửa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSửa.Location = new System.Drawing.Point(456, 201);
            this.butSửa.Name = "butSửa";
            this.butSửa.Size = new System.Drawing.Size(95, 37);
            this.butSửa.TabIndex = 12;
            this.butSửa.Text = "Chỉnh sửa";
            this.butSửa.UseVisualStyleBackColor = false;
            this.butSửa.Click += new System.EventHandler(this.butSửa_Click);
            // 
            // butThêm
            // 
            this.butThêm.BackColor = System.Drawing.Color.Magenta;
            this.butThêm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThêm.Location = new System.Drawing.Point(286, 201);
            this.butThêm.Name = "butThêm";
            this.butThêm.Size = new System.Drawing.Size(96, 37);
            this.butThêm.TabIndex = 11;
            this.butThêm.Text = "Thêm mới";
            this.butThêm.UseVisualStyleBackColor = false;
            this.butThêm.Click += new System.EventHandler(this.butThêm_Click);
            // 
            // butXem
            // 
            this.butXem.BackColor = System.Drawing.Color.Magenta;
            this.butXem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXem.Location = new System.Drawing.Point(125, 201);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(88, 37);
            this.butXem.TabIndex = 10;
            this.butXem.Text = "Xem";
            this.butXem.UseVisualStyleBackColor = false;
            this.butXem.Click += new System.EventHandler(this.butXem_Click);
            // 
            // cbbID_NV
            // 
            this.cbbID_NV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbID_NV.FormattingEnabled = true;
            this.cbbID_NV.Location = new System.Drawing.Point(771, 126);
            this.cbbID_NV.Name = "cbbID_NV";
            this.cbbID_NV.Size = new System.Drawing.Size(168, 25);
            this.cbbID_NV.TabIndex = 9;
            // 
            // cbbCV
            // 
            this.cbbCV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(771, 44);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(168, 25);
            this.cbbCV.TabIndex = 8;
            this.cbbCV.SelectedIndexChanged += new System.EventHandler(this.cbbCV_SelectedIndexChanged);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(219, 142);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(163, 25);
            this.txtMK.TabIndex = 7;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(219, 93);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(163, 25);
            this.txtTenTK.TabIndex = 6;
            // 
            // txtID_TK
            // 
            this.txtID_TK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_TK.Location = new System.Drawing.Point(219, 46);
            this.txtID_TK.Name = "txtID_TK";
            this.txtID_TK.Size = new System.Drawing.Size(163, 25);
            this.txtID_TK.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(643, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(643, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID tài khoản";
            // 
            // txtTkiem
            // 
            this.txtTkiem.Location = new System.Drawing.Point(243, 411);
            this.txtTkiem.Name = "txtTkiem";
            this.txtTkiem.Size = new System.Drawing.Size(145, 22);
            this.txtTkiem.TabIndex = 9;
            // 
            // cbbSX
            // 
            this.cbbSX.FormattingEnabled = true;
            this.cbbSX.Location = new System.Drawing.Point(1021, 411);
            this.cbbSX.Name = "cbbSX";
            this.cbbSX.Size = new System.Drawing.Size(147, 24);
            this.cbbSX.TabIndex = 10;
            // 
            // butTìm
            // 
            this.butTìm.BackColor = System.Drawing.Color.LightGray;
            this.butTìm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTìm.Location = new System.Drawing.Point(143, 404);
            this.butTìm.Name = "butTìm";
            this.butTìm.Size = new System.Drawing.Size(94, 35);
            this.butTìm.TabIndex = 14;
            this.butTìm.Text = "Tìm kiếm";
            this.butTìm.UseVisualStyleBackColor = false;
            this.butTìm.Click += new System.EventHandler(this.butTìm_Click);
            // 
            // butXếp
            // 
            this.butXếp.BackColor = System.Drawing.Color.LightGray;
            this.butXếp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXếp.Location = new System.Drawing.Point(923, 404);
            this.butXếp.Name = "butXếp";
            this.butXếp.Size = new System.Drawing.Size(92, 35);
            this.butXếp.TabIndex = 15;
            this.butXếp.Text = "Sắp xếp";
            this.butXếp.UseVisualStyleBackColor = false;
            this.butXếp.Click += new System.EventHandler(this.butXếp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 266);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.Image")));
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(505, 12);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(293, 73);
            this.btnSet.TabIndex = 25;
            this.btnSet.Text = "         Quản Lí Tài Khoản ";
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 734);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butTìm);
            this.Controls.Add(this.butXếp);
            this.Controls.Add(this.cbbSX);
            this.Controls.Add(this.txtTkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOut5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.PictureBox btnOut5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbID_NV;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtID_TK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTkiem;
        private System.Windows.Forms.ComboBox cbbSX;
        private System.Windows.Forms.Button butXóa;
        private System.Windows.Forms.Button butSửa;
        private System.Windows.Forms.Button butThêm;
        private System.Windows.Forms.Button butXem;
        private System.Windows.Forms.Button butTìm;
        private System.Windows.Forms.Button butXếp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button butLamMoi;
    }
}

