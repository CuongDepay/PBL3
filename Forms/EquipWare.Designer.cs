
namespace PBL3
{
    partial class EquipWare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipWare));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.butDel = new System.Windows.Forms.Button();
            this.butSort = new System.Windows.Forms.Button();
            this.butUpWare = new System.Windows.Forms.Button();
            this.butAddE = new System.Windows.Forms.Button();
            this.butAddWare = new System.Windows.Forms.Button();
            this.butSearchWare = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnWare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(228, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(105, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kho Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(1086, 136);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(105, 24);
            this.cbbSort.TabIndex = 1;
            // 
            // butDel
            // 
            this.butDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Location = new System.Drawing.Point(405, 641);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(104, 44);
            this.butDel.TabIndex = 0;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = false;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butSort
            // 
            this.butSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butSort.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSort.ForeColor = System.Drawing.Color.White;
            this.butSort.Location = new System.Drawing.Point(988, 133);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(89, 30);
            this.butSort.TabIndex = 0;
            this.butSort.Text = "Sắp Xếp";
            this.butSort.UseVisualStyleBackColor = false;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butUpWare
            // 
            this.butUpWare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butUpWare.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpWare.ForeColor = System.Drawing.Color.White;
            this.butUpWare.Location = new System.Drawing.Point(268, 641);
            this.butUpWare.Name = "butUpWare";
            this.butUpWare.Size = new System.Drawing.Size(104, 44);
            this.butUpWare.TabIndex = 0;
            this.butUpWare.Text = "Chỉnh sửa";
            this.butUpWare.UseVisualStyleBackColor = false;
            this.butUpWare.Click += new System.EventHandler(this.butUpWare_Click);
            // 
            // butAddE
            // 
            this.butAddE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butAddE.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddE.Location = new System.Drawing.Point(892, 640);
            this.butAddE.Name = "butAddE";
            this.butAddE.Size = new System.Drawing.Size(141, 46);
            this.butAddE.TabIndex = 0;
            this.butAddE.Text = "Nhập Kho";
            this.butAddE.UseVisualStyleBackColor = false;
            this.butAddE.Click += new System.EventHandler(this.butAddE_Click);
            // 
            // butAddWare
            // 
            this.butAddWare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butAddWare.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddWare.ForeColor = System.Drawing.Color.White;
            this.butAddWare.Location = new System.Drawing.Point(140, 641);
            this.butAddWare.Name = "butAddWare";
            this.butAddWare.Size = new System.Drawing.Size(104, 44);
            this.butAddWare.TabIndex = 0;
            this.butAddWare.Text = "Thêm Mới ";
            this.butAddWare.UseVisualStyleBackColor = false;
            this.butAddWare.Click += new System.EventHandler(this.butAddWare_Click);
            // 
            // butSearchWare
            // 
            this.butSearchWare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butSearchWare.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchWare.ForeColor = System.Drawing.Color.White;
            this.butSearchWare.Location = new System.Drawing.Point(137, 136);
            this.butSearchWare.Name = "butSearchWare";
            this.butSearchWare.Size = new System.Drawing.Size(89, 30);
            this.butSearchWare.TabIndex = 0;
            this.butSearchWare.Text = "Tìm Kiếm";
            this.butSearchWare.UseVisualStyleBackColor = false;
            this.butSearchWare.Click += new System.EventHandler(this.butSearchWare_Click);
            // 
            // butView
            // 
            this.butView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.butView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butView.ForeColor = System.Drawing.Color.White;
            this.butView.Location = new System.Drawing.Point(1055, 640);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(141, 47);
            this.butView.TabIndex = 11;
            this.butView.Text = "Chi Tiết";
            this.butView.UseVisualStyleBackColor = false;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(339, 139);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(104, 24);
            this.cbbSearch.TabIndex = 12;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged_1);
            // 
            // btnWare
            // 
            this.btnWare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnWare.FlatAppearance.BorderSize = 0;
            this.btnWare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWare.ForeColor = System.Drawing.Color.White;
            this.btnWare.Image = ((System.Drawing.Image)(resources.GetObject("btnWare.Image")));
            this.btnWare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWare.Location = new System.Drawing.Point(505, 12);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(293, 73);
            this.btnWare.TabIndex = 14;
            this.btnWare.Text = "             Quản Lí Kho Hàng";
            this.btnWare.UseVisualStyleBackColor = false;
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
            // btnOut2
            // 
            this.btnOut2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut2.Image = ((System.Drawing.Image)(resources.GetObject("btnOut2.Image")));
            this.btnOut2.Location = new System.Drawing.Point(1233, 12);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(20, 20);
            this.btnOut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut2.TabIndex = 3;
            this.btnOut2.TabStop = false;
            this.btnOut2.Click += new System.EventHandler(this.btnOut2_Click);
            // 
            // EquipWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1265, 750);
            this.Controls.Add(this.btnWare);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.butAddE);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butView);
            this.Controls.Add(this.butUpWare);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.butAddWare);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOut2);
            this.Controls.Add(this.butSearchWare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipWare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnOut2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butUpWare;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSearchWare;
        private System.Windows.Forms.Button butAddWare;
        private System.Windows.Forms.Button butAddE;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnWare;
    }
}