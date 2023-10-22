namespace PBL3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butLogout = new System.Windows.Forms.Button();
            this.butSetting = new System.Windows.Forms.Button();
            this.butManageCustomer = new System.Windows.Forms.Button();
            this.butSalesHistory = new System.Windows.Forms.Button();
            this.butOrder = new System.Windows.Forms.Button();
            this.butProductList = new System.Windows.Forms.Button();
            this.butStaffInfor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconclose = new System.Windows.Forms.PictureBox();
            this.iconmin = new System.Windows.Forms.PictureBox();
            this.iconmax = new System.Windows.Forms.PictureBox();
            this.iconminimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.butLogout);
            this.MenuVertical.Controls.Add(this.butSetting);
            this.MenuVertical.Controls.Add(this.butManageCustomer);
            this.MenuVertical.Controls.Add(this.butSalesHistory);
            this.MenuVertical.Controls.Add(this.butOrder);
            this.MenuVertical.Controls.Add(this.butProductList);
            this.MenuVertical.Controls.Add(this.butStaffInfor);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(251, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // butLogout
            // 
            this.butLogout.FlatAppearance.BorderSize = 0;
            this.butLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.ForeColor = System.Drawing.Color.Yellow;
            this.butLogout.Image = ((System.Drawing.Image)(resources.GetObject("butLogout.Image")));
            this.butLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLogout.Location = new System.Drawing.Point(-5, 519);
            this.butLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(256, 68);
            this.butLogout.TabIndex = 6;
            this.butLogout.Text = "      Đăng Xuất";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // butSetting
            // 
            this.butSetting.FlatAppearance.BorderSize = 0;
            this.butSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSetting.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSetting.ForeColor = System.Drawing.Color.White;
            this.butSetting.Image = ((System.Drawing.Image)(resources.GetObject("butSetting.Image")));
            this.butSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSetting.Location = new System.Drawing.Point(-5, 431);
            this.butSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSetting.Name = "butSetting";
            this.butSetting.Size = new System.Drawing.Size(256, 84);
            this.butSetting.TabIndex = 5;
            this.butSetting.Text = "      Kiểm Kho";
            this.butSetting.UseVisualStyleBackColor = true;
            this.butSetting.Click += new System.EventHandler(this.butSetting_Click);
            // 
            // butManageCustomer
            // 
            this.butManageCustomer.FlatAppearance.BorderSize = 0;
            this.butManageCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butManageCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butManageCustomer.ForeColor = System.Drawing.Color.White;
            this.butManageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("butManageCustomer.Image")));
            this.butManageCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butManageCustomer.Location = new System.Drawing.Point(0, 343);
            this.butManageCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butManageCustomer.Name = "butManageCustomer";
            this.butManageCustomer.Size = new System.Drawing.Size(256, 84);
            this.butManageCustomer.TabIndex = 4;
            this.butManageCustomer.Text = "        Khách Hàng";
            this.butManageCustomer.UseVisualStyleBackColor = true;
            this.butManageCustomer.Click += new System.EventHandler(this.butManageCustomer_Click);
            // 
            // butSalesHistory
            // 
            this.butSalesHistory.FlatAppearance.BorderSize = 0;
            this.butSalesHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalesHistory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalesHistory.ForeColor = System.Drawing.Color.White;
            this.butSalesHistory.Image = ((System.Drawing.Image)(resources.GetObject("butSalesHistory.Image")));
            this.butSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSalesHistory.Location = new System.Drawing.Point(-5, 255);
            this.butSalesHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSalesHistory.Name = "butSalesHistory";
            this.butSalesHistory.Size = new System.Drawing.Size(258, 84);
            this.butSalesHistory.TabIndex = 3;
            this.butSalesHistory.Text = "            Lịch Sử Bán Hàng";
            this.butSalesHistory.UseVisualStyleBackColor = true;
            this.butSalesHistory.Click += new System.EventHandler(this.butSalesHistory_Click);
            // 
            // butOrder
            // 
            this.butOrder.FlatAppearance.BorderSize = 0;
            this.butOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOrder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrder.ForeColor = System.Drawing.Color.White;
            this.butOrder.Image = ((System.Drawing.Image)(resources.GetObject("butOrder.Image")));
            this.butOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOrder.Location = new System.Drawing.Point(-5, 164);
            this.butOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(261, 77);
            this.butOrder.TabIndex = 2;
            this.butOrder.Text = "      Bán Hàng ";
            this.butOrder.UseVisualStyleBackColor = true;
            this.butOrder.Click += new System.EventHandler(this.butOrder_Click);
            // 
            // butProductList
            // 
            this.butProductList.Location = new System.Drawing.Point(0, 0);
            this.butProductList.Name = "butProductList";
            this.butProductList.Size = new System.Drawing.Size(75, 23);
            this.butProductList.TabIndex = 10;
            // 
            // butStaffInfor
            // 
            this.butStaffInfor.FlatAppearance.BorderSize = 0;
            this.butStaffInfor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.butStaffInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStaffInfor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStaffInfor.ForeColor = System.Drawing.Color.White;
            this.butStaffInfor.Image = ((System.Drawing.Image)(resources.GetObject("butStaffInfor.Image")));
            this.butStaffInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStaffInfor.Location = new System.Drawing.Point(-5, 75);
            this.butStaffInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butStaffInfor.Name = "butStaffInfor";
            this.butStaffInfor.Size = new System.Drawing.Size(258, 85);
            this.butStaffInfor.TabIndex = 0;
            this.butStaffInfor.Text = "           Thông Tin Cá Nhân ";
            this.butStaffInfor.UseVisualStyleBackColor = true;
            this.butStaffInfor.Click += new System.EventHandler(this.butStaffInfor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.iconclose);
            this.panel1.Controls.Add(this.iconmin);
            this.panel1.Controls.Add(this.iconmax);
            this.panel1.Controls.Add(this.iconminimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 75);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconclose
            // 
            this.iconclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconclose.BackColor = System.Drawing.Color.Thistle;
            this.iconclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconclose.Image = ((System.Drawing.Image)(resources.GetObject("iconclose.Image")));
            this.iconclose.Location = new System.Drawing.Point(1003, 12);
            this.iconclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(43, 44);
            this.iconclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconclose.TabIndex = 6;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click_1);
            // 
            // iconmin
            // 
            this.iconmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmin.BackColor = System.Drawing.Color.Thistle;
            this.iconmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmin.Image = ((System.Drawing.Image)(resources.GetObject("iconmin.Image")));
            this.iconmin.Location = new System.Drawing.Point(953, 12);
            this.iconmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconmin.Name = "iconmin";
            this.iconmin.Size = new System.Drawing.Size(43, 44);
            this.iconmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmin.TabIndex = 5;
            this.iconmin.TabStop = false;
            this.iconmin.Visible = false;
            this.iconmin.Click += new System.EventHandler(this.iconmin_Click_1);
            // 
            // iconmax
            // 
            this.iconmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmax.BackColor = System.Drawing.Color.Thistle;
            this.iconmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmax.Image = ((System.Drawing.Image)(resources.GetObject("iconmax.Image")));
            this.iconmax.Location = new System.Drawing.Point(953, 12);
            this.iconmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconmax.Name = "iconmax";
            this.iconmax.Size = new System.Drawing.Size(43, 44);
            this.iconmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmax.TabIndex = 3;
            this.iconmax.TabStop = false;
            this.iconmax.Click += new System.EventHandler(this.iconmax_Click);
            // 
            // iconminimize
            // 
            this.iconminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimize.BackColor = System.Drawing.Color.Thistle;
            this.iconminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimize.Image = ((System.Drawing.Image)(resources.GetObject("iconminimize.Image")));
            this.iconminimize.Location = new System.Drawing.Point(905, 12);
            this.iconminimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconminimize.Name = "iconminimize";
            this.iconminimize.Size = new System.Drawing.Size(43, 44);
            this.iconminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimize.TabIndex = 1;
            this.iconminimize.TabStop = false;
            this.iconminimize.Click += new System.EventHandler(this.iconminimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(251, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 575);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(320, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(415, 387);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Cửa Hàng Bán Thiết Bị Máy Tính";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimize)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button butStaffInfor;
        private System.Windows.Forms.Button butSetting;
        private System.Windows.Forms.Button butManageCustomer;
        private System.Windows.Forms.Button butSalesHistory;
        private System.Windows.Forms.Button butOrder;
        private System.Windows.Forms.Button butProductList;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconmax;
        private System.Windows.Forms.PictureBox iconminimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconmin;
        private System.Windows.Forms.PictureBox iconclose;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

