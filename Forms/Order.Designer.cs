namespace PBL3
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCusname = new System.Windows.Forms.TextBox();
            this.cbbSodienthoai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDHoadon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDThietbi = new System.Windows.Forms.TextBox();
            this.butReset = new System.Windows.Forms.Button();
            this.butAddtoBill = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGiasanpham = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbIDKhuyenmai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnOut6 = new System.Windows.Forms.PictureBox();
            this.butOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSearchEquip = new System.Windows.Forms.Button();
            this.txtSearchEquip = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenKhuyenmai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.datagridviewDonhang = new System.Windows.Forms.DataGridView();
            this.butDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDonhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtCusname);
            this.panel1.Controls.Add(this.cbbSodienthoai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(86, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 127);
            this.panel1.TabIndex = 1;
            // 
            // txtCusname
            // 
            this.txtCusname.Enabled = false;
            this.txtCusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusname.Location = new System.Drawing.Point(282, 81);
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.Size = new System.Drawing.Size(167, 22);
            this.txtCusname.TabIndex = 4;
            // 
            // cbbSodienthoai
            // 
            this.cbbSodienthoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSodienthoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSodienthoai.FormattingEnabled = true;
            this.cbbSodienthoai.Location = new System.Drawing.Point(29, 79);
            this.cbbSodienthoai.Name = "cbbSodienthoai";
            this.cbbSodienthoai.Size = new System.Drawing.Size(152, 24);
            this.cbbSodienthoai.TabIndex = 3;
            this.cbbSodienthoai.SelectionChangeCommitted += new System.EventHandler(this.cbbSodienthoai_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(292, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng ";
            // 
            // txtIDHoadon
            // 
            this.txtIDHoadon.Enabled = false;
            this.txtIDHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHoadon.Location = new System.Drawing.Point(94, 41);
            this.txtIDHoadon.Name = "txtIDHoadon";
            this.txtIDHoadon.Size = new System.Drawing.Size(86, 22);
            this.txtIDHoadon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Hóa Đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.txtIDThietbi);
            this.panel2.Controls.Add(this.txtIDHoadon);
            this.panel2.Controls.Add(this.butReset);
            this.panel2.Controls.Add(this.butAddtoBill);
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Controls.Add(this.txtGiasanpham);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTensanpham);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(86, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 189);
            this.panel2.TabIndex = 2;
            // 
            // txtIDThietbi
            // 
            this.txtIDThietbi.Enabled = false;
            this.txtIDThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDThietbi.Location = new System.Drawing.Point(274, 41);
            this.txtIDThietbi.Name = "txtIDThietbi";
            this.txtIDThietbi.Size = new System.Drawing.Size(86, 22);
            this.txtIDThietbi.TabIndex = 4;
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.Color.Black;
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butReset.Location = new System.Drawing.Point(277, 138);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(94, 33);
            this.butReset.TabIndex = 9;
            this.butReset.Text = "Xóa";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butAddtoBill
            // 
            this.butAddtoBill.BackColor = System.Drawing.Color.Black;
            this.butAddtoBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddtoBill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAddtoBill.Location = new System.Drawing.Point(110, 138);
            this.butAddtoBill.Name = "butAddtoBill";
            this.butAddtoBill.Size = new System.Drawing.Size(108, 33);
            this.butAddtoBill.TabIndex = 8;
            this.butAddtoBill.Text = "Thêm ";
            this.butAddtoBill.UseVisualStyleBackColor = false;
            this.butAddtoBill.Click += new System.EventHandler(this.butAddtoBill_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(343, 104);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(130, 22);
            this.txtSoluong.TabIndex = 7;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtGiasanpham
            // 
            this.txtGiasanpham.Enabled = false;
            this.txtGiasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiasanpham.Location = new System.Drawing.Point(173, 104);
            this.txtGiasanpham.Name = "txtGiasanpham";
            this.txtGiasanpham.Size = new System.Drawing.Size(133, 22);
            this.txtGiasanpham.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SteelBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(271, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "ID Thiết Bị";
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Enabled = false;
            this.txtTensanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensanpham.Location = new System.Drawing.Point(13, 104);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(134, 22);
            this.txtTensanpham.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(336, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số Lượng Thiết Bị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(184, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giá Thiết Bị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Thiết Bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đặt hàng ";
            // 
            // cbbIDKhuyenmai
            // 
            this.cbbIDKhuyenmai.FormattingEnabled = true;
            this.cbbIDKhuyenmai.Location = new System.Drawing.Point(33, 78);
            this.cbbIDKhuyenmai.Name = "cbbIDKhuyenmai";
            this.cbbIDKhuyenmai.Size = new System.Drawing.Size(119, 28);
            this.cbbIDKhuyenmai.TabIndex = 10;
            this.cbbIDKhuyenmai.SelectionChangeCommitted += new System.EventHandler(this.cbbIDKhuyenmai_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Magenta;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "ID Khuyến Mãi ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 524);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 201);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thiết Bị Trong Kho ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(625, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đơn Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(995, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tổng Tiền";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1098, 456);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 22);
            this.txtTotal.TabIndex = 9;
            // 
            // btnOut6
            // 
            this.btnOut6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut6.Image = ((System.Drawing.Image)(resources.GetObject("btnOut6.Image")));
            this.btnOut6.Location = new System.Drawing.Point(1248, 12);
            this.btnOut6.Name = "btnOut6";
            this.btnOut6.Size = new System.Drawing.Size(20, 20);
            this.btnOut6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut6.TabIndex = 12;
            this.btnOut6.TabStop = false;
            this.btnOut6.Click += new System.EventHandler(this.btnOut6_Click);
            // 
            // butOrder
            // 
            this.butOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.butOrder.FlatAppearance.BorderSize = 0;
            this.butOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.butOrder.ForeColor = System.Drawing.Color.White;
            this.butOrder.Image = ((System.Drawing.Image)(resources.GetObject("butOrder.Image")));
            this.butOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOrder.Location = new System.Drawing.Point(505, 12);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(293, 73);
            this.butOrder.TabIndex = 11;
            this.butOrder.Text = "       Đặt Hàng ";
            this.butOrder.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // butSearchEquip
            // 
            this.butSearchEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butSearchEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchEquip.Location = new System.Drawing.Point(94, 487);
            this.butSearchEquip.Name = "butSearchEquip";
            this.butSearchEquip.Size = new System.Drawing.Size(83, 31);
            this.butSearchEquip.TabIndex = 13;
            this.butSearchEquip.Text = "Tìm kiếm";
            this.butSearchEquip.UseVisualStyleBackColor = false;
            this.butSearchEquip.Click += new System.EventHandler(this.butSearchEquip_Click);
            // 
            // txtSearchEquip
            // 
            this.txtSearchEquip.Location = new System.Drawing.Point(183, 493);
            this.txtSearchEquip.Name = "txtSearchEquip";
            this.txtSearchEquip.Size = new System.Drawing.Size(100, 22);
            this.txtSearchEquip.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(289, 492);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 24);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Magenta;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(200, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tên Khuyến Mãi";
            // 
            // txtTenKhuyenmai
            // 
            this.txtTenKhuyenmai.Enabled = false;
            this.txtTenKhuyenmai.Location = new System.Drawing.Point(199, 80);
            this.txtTenKhuyenmai.Name = "txtTenKhuyenmai";
            this.txtTenKhuyenmai.Size = new System.Drawing.Size(130, 27);
            this.txtTenKhuyenmai.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Magenta;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(383, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Phần Trăm";
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Enabled = false;
            this.txtPhanTram.Location = new System.Drawing.Point(387, 80);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(100, 27);
            this.txtPhanTram.TabIndex = 19;
            // 
            // datagridviewDonhang
            // 
            this.datagridviewDonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewDonhang.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewDonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewDonhang.Location = new System.Drawing.Point(625, 221);
            this.datagridviewDonhang.Name = "datagridviewDonhang";
            this.datagridviewDonhang.RowHeadersWidth = 51;
            this.datagridviewDonhang.RowTemplate.Height = 24;
            this.datagridviewDonhang.Size = new System.Drawing.Size(627, 220);
            this.datagridviewDonhang.TabIndex = 20;
            // 
            // butDone
            // 
            this.butDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDone.Location = new System.Drawing.Point(810, 459);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(134, 43);
            this.butDone.TabIndex = 22;
            this.butDone.Text = "Xuất hóa đơn ";
            this.butDone.UseVisualStyleBackColor = false;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPhanTram);
            this.groupBox1.Controls.Add(this.cbbIDKhuyenmai);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTenKhuyenmai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(724, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 114);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ưu Đãi";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 734);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.datagridviewDonhang);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txtSearchEquip);
            this.Controls.Add(this.butSearchEquip);
            this.Controls.Add(this.btnOut6);
            this.Controls.Add(this.butOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDonhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusname;
        private System.Windows.Forms.ComboBox cbbSodienthoai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGiasanpham;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butAddtoBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butOrder;
        private System.Windows.Forms.PictureBox btnOut6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDHoadon;
        private System.Windows.Forms.Button butSearchEquip;
        private System.Windows.Forms.TextBox txtSearchEquip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbIDKhuyenmai;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenKhuyenmai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDThietbi;
        private System.Windows.Forms.DataGridView datagridviewDonhang;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}