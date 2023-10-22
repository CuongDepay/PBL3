
namespace PBL3
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butReset = new System.Windows.Forms.Button();
            this.butDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSearchDis = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.butSearchDis = new System.Windows.Forms.Button();
            this.butAddDis = new System.Windows.Forms.Button();
            this.butDelDis = new System.Windows.Forms.Button();
            this.butUpDis = new System.Windows.Forms.Button();
            this.butSortDis = new System.Windows.Forms.Button();
            this.cbbSortDis = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut3 = new System.Windows.Forms.PictureBox();
            this.btnDis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phầm trăm giảm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên khuyến mãi ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(180, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 25);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(180, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(180, 162);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(169, 25);
            this.txtPercent.TabIndex = 6;
            this.txtPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercent_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 239);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh sách ưu đãi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.butReset);
            this.groupBox1.Controls.Add(this.butDone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPercent);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(121, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 245);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(738, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(738, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.butReset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(365, 181);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(93, 41);
            this.butReset.TabIndex = 15;
            this.butReset.Text = "Làm Mới";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butDone
            // 
            this.butDone.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.butDone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDone.Location = new System.Drawing.Point(525, 181);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(93, 41);
            this.butDone.TabIndex = 15;
            this.butDone.Text = "OK";
            this.butDone.UseVisualStyleBackColor = false;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(617, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(617, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // cbbSearchDis
            // 
            this.cbbSearchDis.FormattingEnabled = true;
            this.cbbSearchDis.Location = new System.Drawing.Point(777, 650);
            this.cbbSearchDis.Name = "cbbSearchDis";
            this.cbbSearchDis.Size = new System.Drawing.Size(138, 24);
            this.cbbSearchDis.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(921, 650);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // butSearchDis
            // 
            this.butSearchDis.BackColor = System.Drawing.Color.SlateBlue;
            this.butSearchDis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchDis.ForeColor = System.Drawing.Color.White;
            this.butSearchDis.Location = new System.Drawing.Point(1095, 644);
            this.butSearchDis.Name = "butSearchDis";
            this.butSearchDis.Size = new System.Drawing.Size(93, 35);
            this.butSearchDis.TabIndex = 14;
            this.butSearchDis.Text = "Tìm Kiếm";
            this.butSearchDis.UseVisualStyleBackColor = false;
            this.butSearchDis.Click += new System.EventHandler(this.butSearchDis_Click);
            // 
            // butAddDis
            // 
            this.butAddDis.BackColor = System.Drawing.Color.SlateBlue;
            this.butAddDis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddDis.ForeColor = System.Drawing.Color.White;
            this.butAddDis.Location = new System.Drawing.Point(126, 644);
            this.butAddDis.Name = "butAddDis";
            this.butAddDis.Size = new System.Drawing.Size(93, 35);
            this.butAddDis.TabIndex = 15;
            this.butAddDis.Text = "Thêm";
            this.butAddDis.UseVisualStyleBackColor = false;
            this.butAddDis.Click += new System.EventHandler(this.butAddDis_Click);
            // 
            // butDelDis
            // 
            this.butDelDis.BackColor = System.Drawing.Color.SlateBlue;
            this.butDelDis.ForeColor = System.Drawing.Color.White;
            this.butDelDis.Location = new System.Drawing.Point(126, 682);
            this.butDelDis.Name = "butDelDis";
            this.butDelDis.Size = new System.Drawing.Size(93, 35);
            this.butDelDis.TabIndex = 15;
            this.butDelDis.Text = "Xóa";
            this.butDelDis.UseVisualStyleBackColor = false;
            this.butDelDis.Click += new System.EventHandler(this.butDelDis_Click);
            // 
            // butUpDis
            // 
            this.butUpDis.BackColor = System.Drawing.Color.SlateBlue;
            this.butUpDis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpDis.ForeColor = System.Drawing.Color.White;
            this.butUpDis.Location = new System.Drawing.Point(261, 644);
            this.butUpDis.Name = "butUpDis";
            this.butUpDis.Size = new System.Drawing.Size(93, 35);
            this.butUpDis.TabIndex = 15;
            this.butUpDis.Text = "Sửa";
            this.butUpDis.UseVisualStyleBackColor = false;
            this.butUpDis.Click += new System.EventHandler(this.butUpDis_Click);
            // 
            // butSortDis
            // 
            this.butSortDis.BackColor = System.Drawing.Color.SlateBlue;
            this.butSortDis.ForeColor = System.Drawing.Color.White;
            this.butSortDis.Location = new System.Drawing.Point(261, 682);
            this.butSortDis.Name = "butSortDis";
            this.butSortDis.Size = new System.Drawing.Size(93, 35);
            this.butSortDis.TabIndex = 15;
            this.butSortDis.Text = "Sắp Xếp";
            this.butSortDis.UseVisualStyleBackColor = false;
            this.butSortDis.Click += new System.EventHandler(this.butSortDis_Click_1);
            // 
            // cbbSortDis
            // 
            this.cbbSortDis.FormattingEnabled = true;
            this.cbbSortDis.Location = new System.Drawing.Point(360, 688);
            this.cbbSortDis.Name = "cbbSortDis";
            this.cbbSortDis.Size = new System.Drawing.Size(113, 24);
            this.cbbSortDis.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnOut3
            // 
            this.btnOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut3.Image = ((System.Drawing.Image)(resources.GetObject("btnOut3.Image")));
            this.btnOut3.Location = new System.Drawing.Point(1233, 12);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(20, 20);
            this.btnOut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut3.TabIndex = 4;
            this.btnOut3.TabStop = false;
            this.btnOut3.Click += new System.EventHandler(this.btnOut3_Click);
            // 
            // btnDis
            // 
            this.btnDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnDis.FlatAppearance.BorderSize = 0;
            this.btnDis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.ForeColor = System.Drawing.Color.White;
            this.btnDis.Image = ((System.Drawing.Image)(resources.GetObject("btnDis.Image")));
            this.btnDis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDis.Location = new System.Drawing.Point(505, 12);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(293, 73);
            this.btnDis.TabIndex = 2;
            this.btnDis.Text = "     Ưu Đãi ";
            this.btnDis.UseVisualStyleBackColor = false;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1265, 750);
            this.Controls.Add(this.cbbSortDis);
            this.Controls.Add(this.butSortDis);
            this.Controls.Add(this.butUpDis);
            this.Controls.Add(this.butDelDis);
            this.Controls.Add(this.butAddDis);
            this.Controls.Add(this.butSearchDis);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchDis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOut3);
            this.Controls.Add(this.btnDis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount";
            this.Text = "Discount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.PictureBox btnOut3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSearchDis;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button butSearchDis;
        private System.Windows.Forms.Button butAddDis;
        private System.Windows.Forms.Button butDelDis;
        private System.Windows.Forms.Button butUpDis;
        private System.Windows.Forms.Button butSortDis;
        private System.Windows.Forms.ComboBox cbbSortDis;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.Button butReset;
    }
}