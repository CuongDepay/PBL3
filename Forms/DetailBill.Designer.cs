
namespace PBL3.Forms
{
    partial class DetailBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailBill));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDHDRev = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotalRev = new System.Windows.Forms.TextBox();
            this.txtTKHRev = new System.Windows.Forms.TextBox();
            this.txtDateRev = new System.Windows.Forms.TextBox();
            this.txtKMRev = new System.Windows.Forms.TextBox();
            this.txtIDKMRev = new System.Windows.Forms.TextBox();
            this.txtNameRev = new System.Windows.Forms.TextBox();
            this.txtIDNVRev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lime;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(440, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 45);
            this.label8.TabIndex = 19;
            this.label8.Text = "Chi tiết hóa đơn ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.txtIDHDRev);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtTotalRev);
            this.groupBox1.Controls.Add(this.txtTKHRev);
            this.groupBox1.Controls.Add(this.txtDateRev);
            this.groupBox1.Controls.Add(this.txtKMRev);
            this.groupBox1.Controls.Add(this.txtIDKMRev);
            this.groupBox1.Controls.Add(this.txtNameRev);
            this.groupBox1.Controls.Add(this.txtIDNVRev);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(112, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 412);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // txtIDHDRev
            // 
            this.txtIDHDRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHDRev.Location = new System.Drawing.Point(137, 31);
            this.txtIDHDRev.Name = "txtIDHDRev";
            this.txtIDHDRev.Size = new System.Drawing.Size(159, 25);
            this.txtIDHDRev.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label11.Location = new System.Drawing.Point(18, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 357);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtTotalRev
            // 
            this.txtTotalRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRev.Location = new System.Drawing.Point(857, 384);
            this.txtTotalRev.Name = "txtTotalRev";
            this.txtTotalRev.Size = new System.Drawing.Size(159, 25);
            this.txtTotalRev.TabIndex = 1;
            // 
            // txtTKHRev
            // 
            this.txtTKHRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKHRev.Location = new System.Drawing.Point(137, 329);
            this.txtTKHRev.Name = "txtTKHRev";
            this.txtTKHRev.Size = new System.Drawing.Size(159, 25);
            this.txtTKHRev.TabIndex = 1;
            // 
            // txtDateRev
            // 
            this.txtDateRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRev.Location = new System.Drawing.Point(137, 278);
            this.txtDateRev.Name = "txtDateRev";
            this.txtDateRev.Size = new System.Drawing.Size(159, 25);
            this.txtDateRev.TabIndex = 1;
            // 
            // txtKMRev
            // 
            this.txtKMRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKMRev.Location = new System.Drawing.Point(137, 226);
            this.txtKMRev.Name = "txtKMRev";
            this.txtKMRev.Size = new System.Drawing.Size(159, 25);
            this.txtKMRev.TabIndex = 1;
            // 
            // txtIDKMRev
            // 
            this.txtIDKMRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKMRev.Location = new System.Drawing.Point(137, 172);
            this.txtIDKMRev.Name = "txtIDKMRev";
            this.txtIDKMRev.Size = new System.Drawing.Size(159, 25);
            this.txtIDKMRev.TabIndex = 1;
            // 
            // txtNameRev
            // 
            this.txtNameRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRev.Location = new System.Drawing.Point(137, 118);
            this.txtNameRev.Name = "txtNameRev";
            this.txtNameRev.Size = new System.Drawing.Size(159, 25);
            this.txtNameRev.TabIndex = 1;
            // 
            // txtIDNVRev
            // 
            this.txtIDNVRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNVRev.Location = new System.Drawing.Point(137, 75);
            this.txtIDNVRev.Name = "txtIDNVRev";
            this.txtIDNVRev.Size = new System.Drawing.Size(159, 25);
            this.txtIDNVRev.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày mua hàng ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(779, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng tiền ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(15, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(18, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phần trăm giảm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnRev.FlatAppearance.BorderSize = 0;
            this.btnRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.ForeColor = System.Drawing.Color.White;
            this.btnRev.Image = ((System.Drawing.Image)(resources.GetObject("btnRev.Image")));
            this.btnRev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRev.Location = new System.Drawing.Point(446, 12);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(293, 73);
            this.btnRev.TabIndex = 21;
            this.btnRev.Text = "         Xem Hóa Đơn ";
            this.btnRev.UseVisualStyleBackColor = false;
            // 
            // DetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetailBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailBill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotalRev;
        private System.Windows.Forms.TextBox txtTKHRev;
        private System.Windows.Forms.TextBox txtDateRev;
        private System.Windows.Forms.TextBox txtIDKMRev;
        private System.Windows.Forms.TextBox txtIDNVRev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDHDRev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameRev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKMRev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRev;
    }
}