using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL.Admin;
using PBL3.BLL.Staff;
using System.IO;
using System.Drawing.Imaging;



namespace PBL3
{
    public partial class FormStaffInfor : Form
    {
        public string id { get; set; }
        public FormStaffInfor(string m)
        {
            id = m;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            NhanVien nv = ManagerUser_BLL.Instance.GetNVByID(id);
            txtIDInfor.Enabled = false;
            txtIDInfor.Text = nv.ID_NV;
            txtNameInfor.Text = nv.TenNV;
            txtAddressInfor.Text = nv.DiaChi;
            dateTimePicker1.Value = nv.NgaySinh.Value;
            if (nv.GioiTinh == true)
            {
                txtGenderInfor.Text = "Nam";
            }
            else
            {
                txtGenderInfor.Text = "Nữ";
            }
            txtPhoneInfor.Text = nv.SDT;
            if (nv.Anh_NV != null)
            {
                MemoryStream m = new MemoryStream(nv.Anh_NV.ToArray());
                Image img = Image.FromStream(m);
                pictureStaff.Image = img;
            }
        }
        private void btnOut7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void butUpLoad_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    imagelocation = openFileDialog1.FileName;
                    Image i = Image.FromFile(imagelocation);
                    pictureStaff.Image = i;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butUpdateInfor_Click_1(object sender, EventArgs e)
        {
            if (pictureStaff.Image != null)
            {
                MemoryStream st = new MemoryStream();
                pictureStaff.Image.Save(st, ImageFormat.Jpeg);
                NhanVien nv = new NhanVien();
                nv.ID_NV = txtIDInfor.Text;
                nv.TenNV = txtNameInfor.Text;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.DiaChi = txtAddressInfor.Text;
                nv.SDT = txtPhoneInfor.Text;
                if (txtGenderInfor.Text == "Nam")
                {
                    nv.GioiTinh = true;
                }
                else { nv.GioiTinh = false; }
                nv.Anh_NV = st.ToArray();
                ManagerUser_BLL.Instance.ThemvaSua(nv);
                MessageBox.Show("Chỉnh sửa thành công");
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.ID_NV = txtIDInfor.Text;
                nv.TenNV = txtNameInfor.Text;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.DiaChi = txtAddressInfor.Text;
                nv.SDT = txtPhoneInfor.Text;
                if (txtGenderInfor.Text == "Nam")
                {
                    nv.GioiTinh = true;
                }
                else { nv.GioiTinh = false; }
                nv.Anh_NV = null;
                ManagerUser_BLL.Instance.ThemvaSua(nv);
                MessageBox.Show("Chỉnh sửa thành công");
            }

        }
    }
}