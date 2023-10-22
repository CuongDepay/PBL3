
namespace PBL3
{
    partial class Reveneu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reveneu));
            this.butSearchRev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butDelRev = new System.Windows.Forms.Button();
            this.butDetailBill = new System.Windows.Forms.Button();
            this.cbbSortRev = new System.Windows.Forms.ComboBox();
            this.butSortHis = new System.Windows.Forms.Button();
            this.cbbSearchRev = new System.Windows.Forms.ComboBox();
            this.txtSearchRev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut4 = new System.Windows.Forms.PictureBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut4)).BeginInit();
            this.SuspendLayout();
            // 
            // butSearchRev
            // 
            this.butSearchRev.BackColor = System.Drawing.Color.Yellow;
            this.butSearchRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchRev.Location = new System.Drawing.Point(960, 50);
            this.butSearchRev.Name = "butSearchRev";
            this.butSearchRev.Size = new System.Drawing.Size(84, 26);
            this.butSearchRev.TabIndex = 5;
            this.butSearchRev.Text = "Xem";
            this.butSearchRev.UseVisualStyleBackColor = false;
            this.butSearchRev.Click += new System.EventHandler(this.butSearchRev_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.butDelRev);
            this.groupBox1.Controls.Add(this.butDetailBill);
            this.groupBox1.Controls.Add(this.cbbSortRev);
            this.groupBox1.Controls.Add(this.butSortHis);
            this.groupBox1.Controls.Add(this.cbbSearchRev);
            this.groupBox1.Controls.Add(this.txtSearchRev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.dateBegin);
            this.groupBox1.Controls.Add(this.butSearchRev);
            this.groupBox1.Location = new System.Drawing.Point(134, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 606);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // butDelRev
            // 
            this.butDelRev.BackColor = System.Drawing.Color.Red;
            this.butDelRev.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelRev.Location = new System.Drawing.Point(79, 536);
            this.butDelRev.Name = "butDelRev";
            this.butDelRev.Size = new System.Drawing.Size(115, 49);
            this.butDelRev.TabIndex = 25;
            this.butDelRev.Text = "Xóa Hóa Đơn";
            this.butDelRev.UseVisualStyleBackColor = false;
            this.butDelRev.Click += new System.EventHandler(this.butDelRev_Click_1);
            // 
            // butDetailBill
            // 
            this.butDetailBill.BackColor = System.Drawing.Color.Lime;
            this.butDetailBill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDetailBill.Location = new System.Drawing.Point(486, 536);
            this.butDetailBill.Name = "butDetailBill";
            this.butDetailBill.Size = new System.Drawing.Size(178, 49);
            this.butDetailBill.TabIndex = 26;
            this.butDetailBill.Text = "Xem Chi Tiết Hóa Đơn";
            this.butDetailBill.UseVisualStyleBackColor = false;
            this.butDetailBill.Click += new System.EventHandler(this.butDetailBill_Click_1);
            // 
            // cbbSortRev
            // 
            this.cbbSortRev.FormattingEnabled = true;
            this.cbbSortRev.Location = new System.Drawing.Point(169, 128);
            this.cbbSortRev.Name = "cbbSortRev";
            this.cbbSortRev.Size = new System.Drawing.Size(150, 24);
            this.cbbSortRev.TabIndex = 24;
            // 
            // butSortHis
            // 
            this.butSortHis.BackColor = System.Drawing.Color.Yellow;
            this.butSortHis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSortHis.Location = new System.Drawing.Point(78, 128);
            this.butSortHis.Name = "butSortHis";
            this.butSortHis.Size = new System.Drawing.Size(85, 26);
            this.butSortHis.TabIndex = 23;
            this.butSortHis.Text = "Sắp xếp ";
            this.butSortHis.UseVisualStyleBackColor = false;
            this.butSortHis.Click += new System.EventHandler(this.butSortHis_Click);
            // 
            // cbbSearchRev
            // 
            this.cbbSearchRev.FormattingEnabled = true;
            this.cbbSearchRev.Location = new System.Drawing.Point(748, 50);
            this.cbbSearchRev.Name = "cbbSearchRev";
            this.cbbSearchRev.Size = new System.Drawing.Size(100, 24);
            this.cbbSearchRev.TabIndex = 22;
            // 
            // txtSearchRev
            // 
            this.txtSearchRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRev.Location = new System.Drawing.Point(854, 50);
            this.txtSearchRev.Name = "txtSearchRev";
            this.txtSearchRev.Size = new System.Drawing.Size(100, 24);
            this.txtSearchRev.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 357);
            this.dataGridView1.TabIndex = 17;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(356, 50);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(256, 25);
            this.dateEnd.TabIndex = 8;
            // 
            // dateBegin
            // 
            this.dateBegin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBegin.Location = new System.Drawing.Point(78, 50);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(256, 25);
            this.dateBegin.TabIndex = 8;
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
            // btnOut4
            // 
            this.btnOut4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut4.Image = ((System.Drawing.Image)(resources.GetObject("btnOut4.Image")));
            this.btnOut4.Location = new System.Drawing.Point(1276, 12);
            this.btnOut4.Name = "btnOut4";
            this.btnOut4.Size = new System.Drawing.Size(20, 20);
            this.btnOut4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOut4.TabIndex = 9;
            this.btnOut4.TabStop = false;
            this.btnOut4.Click += new System.EventHandler(this.btnOut4_Click);
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
            this.btnRev.Location = new System.Drawing.Point(505, 12);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(293, 73);
            this.btnRev.TabIndex = 12;
            this.btnRev.Text = "         Xem Hóa Đơn ";
            this.btnRev.UseVisualStyleBackColor = false;
            // 
            // Reveneu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1308, 768);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOut4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reveneu";
            this.Text = "`";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOut4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butSearchRev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnOut4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbSearchRev;
        private System.Windows.Forms.TextBox txtSearchRev;
        private System.Windows.Forms.ComboBox cbbSortRev;
        private System.Windows.Forms.Button butSortHis;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button butDelRev;
        private System.Windows.Forms.Button butDetailBill;
    }
}