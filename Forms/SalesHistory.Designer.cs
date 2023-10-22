namespace PBL3
{
    partial class SalesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butSearchHis = new System.Windows.Forms.Button();
            this.txtSearchHis = new System.Windows.Forms.TextBox();
            this.butViewHis = new System.Windows.Forms.Button();
            this.butSortHis = new System.Windows.Forms.Button();
            this.cbbSortHis = new System.Windows.Forms.ComboBox();
            this.cbbSearchHis = new System.Windows.Forms.ComboBox();
            this.dateBeginHis = new System.Windows.Forms.DateTimePicker();
            this.dateEndHis = new System.Windows.Forms.DateTimePicker();
            this.btnOut10 = new System.Windows.Forms.PictureBox();
            this.butSalesHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử đơn hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // butSearchHis
            // 
            this.butSearchHis.BackColor = System.Drawing.Color.Teal;
            this.butSearchHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butSearchHis.ForeColor = System.Drawing.Color.White;
            this.butSearchHis.Location = new System.Drawing.Point(173, 616);
            this.butSearchHis.Name = "butSearchHis";
            this.butSearchHis.Size = new System.Drawing.Size(85, 27);
            this.butSearchHis.TabIndex = 16;
            this.butSearchHis.Text = "Tìm kiếm ";
            this.butSearchHis.UseVisualStyleBackColor = false;
            this.butSearchHis.Click += new System.EventHandler(this.butSearchHis_Click);
            // 
            // txtSearchHis
            // 
            this.txtSearchHis.Location = new System.Drawing.Point(263, 619);
            this.txtSearchHis.Name = "txtSearchHis";
            this.txtSearchHis.Size = new System.Drawing.Size(106, 22);
            this.txtSearchHis.TabIndex = 17;
            // 
            // butViewHis
            // 
            this.butViewHis.BackColor = System.Drawing.Color.SlateBlue;
            this.butViewHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butViewHis.ForeColor = System.Drawing.Color.White;
            this.butViewHis.Location = new System.Drawing.Point(577, 665);
            this.butViewHis.Name = "butViewHis";
            this.butViewHis.Size = new System.Drawing.Size(232, 50);
            this.butViewHis.TabIndex = 18;
            this.butViewHis.Text = "Xem Chi Tiết ";
            this.butViewHis.UseVisualStyleBackColor = false;
            this.butViewHis.Click += new System.EventHandler(this.butViewHis_Click);
            // 
            // butSortHis
            // 
            this.butSortHis.BackColor = System.Drawing.Color.Teal;
            this.butSortHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butSortHis.ForeColor = System.Drawing.Color.White;
            this.butSortHis.Location = new System.Drawing.Point(172, 149);
            this.butSortHis.Name = "butSortHis";
            this.butSortHis.Size = new System.Drawing.Size(85, 26);
            this.butSortHis.TabIndex = 16;
            this.butSortHis.Text = "Sắp xếp ";
            this.butSortHis.UseVisualStyleBackColor = false;
            this.butSortHis.Click += new System.EventHandler(this.butSortHis_Click);
            // 
            // cbbSortHis
            // 
            this.cbbSortHis.FormattingEnabled = true;
            this.cbbSortHis.Location = new System.Drawing.Point(263, 149);
            this.cbbSortHis.Name = "cbbSortHis";
            this.cbbSortHis.Size = new System.Drawing.Size(159, 24);
            this.cbbSortHis.TabIndex = 19;
            // 
            // cbbSearchHis
            // 
            this.cbbSearchHis.FormattingEnabled = true;
            this.cbbSearchHis.Location = new System.Drawing.Point(375, 619);
            this.cbbSearchHis.Name = "cbbSearchHis";
            this.cbbSearchHis.Size = new System.Drawing.Size(162, 24);
            this.cbbSearchHis.TabIndex = 19;
            // 
            // dateBeginHis
            // 
            this.dateBeginHis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBeginHis.Location = new System.Drawing.Point(690, 615);
            this.dateBeginHis.Name = "dateBeginHis";
            this.dateBeginHis.Size = new System.Drawing.Size(238, 25);
            this.dateBeginHis.TabIndex = 21;
            // 
            // dateEndHis
            // 
            this.dateEndHis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndHis.Location = new System.Drawing.Point(957, 615);
            this.dateEndHis.Name = "dateEndHis";
            this.dateEndHis.Size = new System.Drawing.Size(232, 25);
            this.dateEndHis.TabIndex = 22;
            // 
            // btnOut10
            // 
            this.btnOut10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut10.Image = ((System.Drawing.Image)(resources.GetObject("btnOut10.Image")));
            this.btnOut10.Location = new System.Drawing.Point(1233, 12);
            this.btnOut10.Name = "btnOut10";
            this.btnOut10.Size = new System.Drawing.Size(20, 20);
            this.btnOut10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut10.TabIndex = 15;
            this.btnOut10.TabStop = false;
            this.btnOut10.Click += new System.EventHandler(this.btnOut10_Click);
            // 
            // butSalesHistory
            // 
            this.butSalesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.butSalesHistory.FlatAppearance.BorderSize = 0;
            this.butSalesHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.butSalesHistory.ForeColor = System.Drawing.Color.White;
            this.butSalesHistory.Image = ((System.Drawing.Image)(resources.GetObject("butSalesHistory.Image")));
            this.butSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSalesHistory.Location = new System.Drawing.Point(505, 12);
            this.butSalesHistory.Name = "butSalesHistory";
            this.butSalesHistory.Size = new System.Drawing.Size(293, 73);
            this.butSalesHistory.TabIndex = 14;
            this.butSalesHistory.Text = "           Lịch Sử Bán Hàng ";
            this.butSalesHistory.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1265, 750);
            this.Controls.Add(this.dateEndHis);
            this.Controls.Add(this.dateBeginHis);
            this.Controls.Add(this.cbbSearchHis);
            this.Controls.Add(this.cbbSortHis);
            this.Controls.Add(this.butViewHis);
            this.Controls.Add(this.txtSearchHis);
            this.Controls.Add(this.butSortHis);
            this.Controls.Add(this.butSearchHis);
            this.Controls.Add(this.btnOut10);
            this.Controls.Add(this.butSalesHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSalesHistory;
        private System.Windows.Forms.PictureBox btnOut10;
        private System.Windows.Forms.Button butSearchHis;
        private System.Windows.Forms.TextBox txtSearchHis;
        private System.Windows.Forms.Button butViewHis;
        private System.Windows.Forms.Button butSortHis;
        private System.Windows.Forms.ComboBox cbbSortHis;
        private System.Windows.Forms.ComboBox cbbSearchHis;
        private System.Windows.Forms.DateTimePicker dateBeginHis;
        private System.Windows.Forms.DateTimePicker dateEndHis;
    }
}