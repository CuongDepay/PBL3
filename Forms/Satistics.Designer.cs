
namespace PBL3.Forms
{
    partial class Satistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satistics));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSortDT = new System.Windows.Forms.ComboBox();
            this.butSortDT = new System.Windows.Forms.Button();
            this.butSearchDT = new System.Windows.Forms.Button();
            this.txtSearchDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTLN = new System.Windows.Forms.TextBox();
            this.txtTDT = new System.Windows.Forms.TextBox();
            this.txtTHD = new System.Windows.Forms.TextBox();
            this.butNam = new System.Windows.Forms.Button();
            this.butMonth = new System.Windows.Forms.Button();
            this.butWeek = new System.Windows.Forms.Button();
            this.butToday = new System.Windows.Forms.Button();
            this.butTC = new System.Windows.Forms.Button();
            this.butXem = new System.Windows.Forms.Button();
            this.dateEndDT = new System.Windows.Forms.DateTimePicker();
            this.dateBeginDT = new System.Windows.Forms.DateTimePicker();
            this.btnOutt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutt)).BeginInit();
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
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnRev.FlatAppearance.BorderSize = 0;
            this.btnRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.ForeColor = System.Drawing.Color.White;
            this.btnRev.Image = ((System.Drawing.Image)(resources.GetObject("btnRev.Image")));
            this.btnRev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRev.Location = new System.Drawing.Point(505, 12);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(293, 73);
            this.btnRev.TabIndex = 11;
            this.btnRev.Text = "           Doanh Thu ";
            this.btnRev.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.cbbSortDT);
            this.groupBox1.Controls.Add(this.butSortDT);
            this.groupBox1.Controls.Add(this.butSearchDT);
            this.groupBox1.Controls.Add(this.txtSearchDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTLN);
            this.groupBox1.Controls.Add(this.txtTDT);
            this.groupBox1.Controls.Add(this.txtTHD);
            this.groupBox1.Controls.Add(this.butNam);
            this.groupBox1.Controls.Add(this.butMonth);
            this.groupBox1.Controls.Add(this.butWeek);
            this.groupBox1.Controls.Add(this.butToday);
            this.groupBox1.Controls.Add(this.butTC);
            this.groupBox1.Controls.Add(this.butXem);
            this.groupBox1.Controls.Add(this.dateEndDT);
            this.groupBox1.Controls.Add(this.dateBeginDT);
            this.groupBox1.Location = new System.Drawing.Point(88, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 626);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cbbSortDT
            // 
            this.cbbSortDT.FormattingEnabled = true;
            this.cbbSortDT.Location = new System.Drawing.Point(901, 277);
            this.cbbSortDT.Name = "cbbSortDT";
            this.cbbSortDT.Size = new System.Drawing.Size(121, 24);
            this.cbbSortDT.TabIndex = 17;
            // 
            // butSortDT
            // 
            this.butSortDT.BackColor = System.Drawing.Color.Lime;
            this.butSortDT.Location = new System.Drawing.Point(1028, 277);
            this.butSortDT.Name = "butSortDT";
            this.butSortDT.Size = new System.Drawing.Size(75, 27);
            this.butSortDT.TabIndex = 16;
            this.butSortDT.Text = "Sắp xếp ";
            this.butSortDT.UseVisualStyleBackColor = false;
            this.butSortDT.Click += new System.EventHandler(this.butSortDT_Click);
            // 
            // butSearchDT
            // 
            this.butSearchDT.BackColor = System.Drawing.Color.Lime;
            this.butSearchDT.Location = new System.Drawing.Point(81, 279);
            this.butSearchDT.Name = "butSearchDT";
            this.butSearchDT.Size = new System.Drawing.Size(75, 26);
            this.butSearchDT.TabIndex = 16;
            this.butSearchDT.Text = "Tìm Kiếm";
            this.butSearchDT.UseVisualStyleBackColor = false;
            this.butSearchDT.Click += new System.EventHandler(this.butSearchDT_Click);
            // 
            // txtSearchDT
            // 
            this.txtSearchDT.Location = new System.Drawing.Point(162, 280);
            this.txtSearchDT.Name = "txtSearchDT";
            this.txtSearchDT.Size = new System.Drawing.Size(100, 22);
            this.txtSearchDT.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách các thiết bị đã bán ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 292);
            this.dataGridView1.TabIndex = 13;
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(632, 168);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 51);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(207, 168);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 51);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(745, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 51);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(278, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng Khách Hàng ";
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(403, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 51);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(64, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 51);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(696, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Sản Phẩm Đã Bán  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(821, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Lợi Nhuận";
            // 
            // txtTSP
            // 
            this.txtTSP.Location = new System.Drawing.Point(699, 197);
            this.txtTSP.Name = "txtTSP";
            this.txtTSP.Size = new System.Drawing.Size(150, 22);
            this.txtTSP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // txtTKH
            // 
            this.txtTKH.Location = new System.Drawing.Point(268, 197);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(148, 22);
            this.txtTKH.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng Hóa Đơn ";
            // 
            // txtTLN
            // 
            this.txtTLN.Location = new System.Drawing.Point(806, 112);
            this.txtTLN.Name = "txtTLN";
            this.txtTLN.Size = new System.Drawing.Size(137, 22);
            this.txtTLN.TabIndex = 3;
            // 
            // txtTDT
            // 
            this.txtTDT.Location = new System.Drawing.Point(464, 112);
            this.txtTDT.Name = "txtTDT";
            this.txtTDT.Size = new System.Drawing.Size(137, 22);
            this.txtTDT.TabIndex = 3;
            // 
            // txtTHD
            // 
            this.txtTHD.Location = new System.Drawing.Point(125, 112);
            this.txtTHD.Name = "txtTHD";
            this.txtTHD.Size = new System.Drawing.Size(137, 22);
            this.txtTHD.TabIndex = 3;
            // 
            // butNam
            // 
            this.butNam.BackColor = System.Drawing.Color.Thistle;
            this.butNam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butNam.Location = new System.Drawing.Point(1044, 69);
            this.butNam.Name = "butNam";
            this.butNam.Size = new System.Drawing.Size(149, 28);
            this.butNam.TabIndex = 2;
            this.butNam.Text = "Doanh Thu Năm ";
            this.butNam.UseVisualStyleBackColor = false;
            this.butNam.Click += new System.EventHandler(this.butNam_Click);
            // 
            // butMonth
            // 
            this.butMonth.BackColor = System.Drawing.Color.Thistle;
            this.butMonth.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butMonth.Location = new System.Drawing.Point(1044, 16);
            this.butMonth.Name = "butMonth";
            this.butMonth.Size = new System.Drawing.Size(149, 28);
            this.butMonth.TabIndex = 2;
            this.butMonth.Text = "Doanh Thu Tháng ";
            this.butMonth.UseVisualStyleBackColor = false;
            this.butMonth.Click += new System.EventHandler(this.butMonth_Click);
            // 
            // butWeek
            // 
            this.butWeek.BackColor = System.Drawing.Color.Thistle;
            this.butWeek.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butWeek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butWeek.Location = new System.Drawing.Point(894, 16);
            this.butWeek.Name = "butWeek";
            this.butWeek.Size = new System.Drawing.Size(144, 28);
            this.butWeek.TabIndex = 2;
            this.butWeek.Text = "Doanh Thu Tuần ";
            this.butWeek.UseVisualStyleBackColor = false;
            this.butWeek.Click += new System.EventHandler(this.butWeek_Click);
            // 
            // butToday
            // 
            this.butToday.BackColor = System.Drawing.Color.Thistle;
            this.butToday.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butToday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butToday.Location = new System.Drawing.Point(738, 16);
            this.butToday.Name = "butToday";
            this.butToday.Size = new System.Drawing.Size(144, 28);
            this.butToday.TabIndex = 2;
            this.butToday.Text = "Doanh Thu Ngày ";
            this.butToday.UseVisualStyleBackColor = false;
            this.butToday.Click += new System.EventHandler(this.butToday_Click);
            // 
            // butTC
            // 
            this.butTC.BackColor = System.Drawing.Color.Thistle;
            this.butTC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butTC.Location = new System.Drawing.Point(618, 17);
            this.butTC.Name = "butTC";
            this.butTC.Size = new System.Drawing.Size(114, 28);
            this.butTC.TabIndex = 2;
            this.butTC.Text = "Tùy Chỉnh ";
            this.butTC.UseVisualStyleBackColor = false;
            this.butTC.Click += new System.EventHandler(this.butTC_Click);
            // 
            // butXem
            // 
            this.butXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butXem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXem.ForeColor = System.Drawing.Color.White;
            this.butXem.Location = new System.Drawing.Point(506, 17);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(86, 29);
            this.butXem.TabIndex = 2;
            this.butXem.Text = "Xem";
            this.butXem.UseVisualStyleBackColor = false;
            this.butXem.Click += new System.EventHandler(this.butXem_Click);
            // 
            // dateEndDT
            // 
            this.dateEndDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndDT.Location = new System.Drawing.Point(271, 20);
            this.dateEndDT.Name = "dateEndDT";
            this.dateEndDT.Size = new System.Drawing.Size(229, 25);
            this.dateEndDT.TabIndex = 1;
            // 
            // dateBeginDT
            // 
            this.dateBeginDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBeginDT.Location = new System.Drawing.Point(10, 20);
            this.dateBeginDT.Name = "dateBeginDT";
            this.dateBeginDT.Size = new System.Drawing.Size(242, 25);
            this.dateBeginDT.TabIndex = 0;
            // 
            // btnOutt
            // 
            this.btnOutt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutt.Image = ((System.Drawing.Image)(resources.GetObject("btnOutt.Image")));
            this.btnOutt.Location = new System.Drawing.Point(1290, 12);
            this.btnOutt.Name = "btnOutt";
            this.btnOutt.Size = new System.Drawing.Size(20, 20);
            this.btnOutt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOutt.TabIndex = 14;
            this.btnOutt.TabStop = false;
            this.btnOutt.Click += new System.EventHandler(this.btnOutt_Click);
            // 
            // Satistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1322, 771);
            this.Controls.Add(this.btnOutt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRev);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satistics";
            this.Text = "Satistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateEndDT;
        private System.Windows.Forms.DateTimePicker dateBeginDT;
        private System.Windows.Forms.Button butXem;
        private System.Windows.Forms.Button butMonth;
        private System.Windows.Forms.Button butWeek;
        private System.Windows.Forms.Button butToday;
        private System.Windows.Forms.Button butTC;
        private System.Windows.Forms.TextBox txtTLN;
        private System.Windows.Forms.TextBox txtTDT;
        private System.Windows.Forms.TextBox txtTHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTSP;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.PictureBox btnOutt;
        private System.Windows.Forms.Button butNam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butSearchDT;
        private System.Windows.Forms.TextBox txtSearchDT;
        private System.Windows.Forms.ComboBox cbbSortDT;
        private System.Windows.Forms.Button butSortDT;
    }
}