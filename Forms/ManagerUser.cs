using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Admin;
using PBL3.DTO;



namespace PBL3
{
    public partial class ManagerUser : Form
    {
        public ManagerUser()
        {
            InitializeComponent();
            cbbSapXep.Items.Add("ID nhân viên");
            cbbSapXep.Items.Add("Tên nhân viên");
            cbbSapXep.Items.Add("Địa chỉ");
        }
        private void btnOut1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Reset()
        {
            txtIDNV.Text = "";
            txtIDNV.Enabled = true;
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtDC.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            imageNV.Image = null;
        }
        private void butXem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
            Reset();
        }
        private void butThem_Click_1(object sender, EventArgs e)
        {
            if (ManagerUser_BLL.Instance.Check(txtIDNV.Text))
            {
                MessageBox.Show("Đã có nhân viên trong danh sách");
            }
            else if (txtIDNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin nhân viên");
            }
            else
            {
                if (imageNV.Image != null)
                {
                    MemoryStream st = new MemoryStream();
                    imageNV.Image.Save(st, ImageFormat.Jpeg);
                    NhanVien nv = new NhanVien()
                    {
                        ID_NV = txtIDNV.Text,
                        TenNV = txtTenNV.Text,
                        GioiTinh = rdNam.Checked,
                        NgaySinh = dateTimePicker1.Value,
                        DiaChi = txtDC.Text,
                        SDT = txtSDT.Text,
                        Anh_NV = st.ToArray(),
                    };
                    ManagerUser_BLL.Instance.ThemvaSua(nv);
                    MessageBox.Show("Thêm nhân viên thành công!");
                    Reset();
                    dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
                }
                else
                {
                    NhanVien nv = new NhanVien()
                    {
                        ID_NV = txtIDNV.Text,
                        TenNV = txtTenNV.Text,
                        GioiTinh = rdNam.Checked,
                        NgaySinh = dateTimePicker1.Value,
                        DiaChi = txtDC.Text,
                        SDT = txtSDT.Text,
                        Anh_NV = null
                    };
                    ManagerUser_BLL.Instance.ThemvaSua(nv);
                    MessageBox.Show("Thêm nhân viên thành công");
                    Reset();
                    dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
                }

            }
        }
        private void butSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (imageNV.Image == null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm ảnh nhân viên?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                    }
                    else
                    {
                        NhanVien nv = new NhanVien()
                        {
                            ID_NV = txtIDNV.Text,
                            TenNV = txtTenNV.Text,
                            GioiTinh = rdNam.Checked,
                            NgaySinh = dateTimePicker1.Value,
                            DiaChi = txtDC.Text,
                            SDT = txtSDT.Text,
                            Anh_NV = null
                        };
                        ManagerUser_BLL.Instance.ThemvaSua(nv);
                        MessageBox.Show("Chỉnh sửa thành công");
                        Reset();
                        dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
                    }
                }
                else
                {
                    MemoryStream st = new MemoryStream();
                    imageNV.Image.Save(st, ImageFormat.Jpeg);
                    NhanVien nv = new NhanVien()
                    {
                        ID_NV = txtIDNV.Text,
                        TenNV = txtTenNV.Text,
                        GioiTinh = rdNam.Checked,
                        NgaySinh = dateTimePicker1.Value,
                        DiaChi = txtDC.Text,
                        SDT = txtSDT.Text,
                        Anh_NV = st.ToArray()
                    };
                    ManagerUser_BLL.Instance.ThemvaSua(nv);
                    MessageBox.Show("Chỉnh sửa thành công");
                    Reset();
                    dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để chỉnh sửa");
            }
        }
        private void butXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa nhân viên này", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        string id = i.Cells["ID_NV"].Value.ToString();
                        ManagerUser_BLL.Instance.XoaNV(id);
                    }
                    Reset();
                    dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
                }
                else
                {
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn các nhân viên cần xóa");
            }
        }
        private void butTKiem_Click_1(object sender, EventArgs e)
        {
            string txt = txtTKiem.Text;
            if (txt != "")
            {
                dataGridView1.DataSource = ManagerUser_BLL.Instance.TimKiem(txt);
                txtTKiem.Clear();
                Reset();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên cần tìm");
            }
        }
        private void butXep_Click_1(object sender, EventArgs e)
        {
            if (cbbSapXep.Text != "")
            {
                dataGridView1.DataSource = ManagerUser_BLL.Instance.SapXep(cbbSapXep.SelectedItem.ToString());
                cbbSapXep.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính cần sắp xếp");
            }
            Reset();
        }
        public void chonAnh()
        {
            string imagelocation = "";
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    imagelocation = openFileDialog1.FileName;
                    Image i = Image.FromFile(imagelocation);
                    imageNV.Image = i;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butAnh_Click_1(object sender, EventArgs e)
        {
            chonAnh();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID_NV"].Value.ToString();
                txtIDNV.Text = id;
                txtIDNV.Enabled = false;
                txtTenNV.Text = ManagerUser_BLL.Instance.GetNVByID(id).TenNV;
                txtDC.Text = ManagerUser_BLL.Instance.GetNVByID(id).DiaChi;
                txtSDT.Text = ManagerUser_BLL.Instance.GetNVByID(id).SDT;
                dateTimePicker1.Value = ManagerUser_BLL.Instance.GetNVByID(id).NgaySinh.Value;
                if (ManagerUser_BLL.Instance.GetNVByID(id).GioiTinh==true)
                {
                    rdNam.Checked = true;
                }
                else
                    rdNu.Checked = true;
                if (ManagerUser_BLL.Instance.GetNVByID(id).Anh_NV == null)
                {
                    imageNV.Image = null;
                }
                else
                {
                    MemoryStream n = new MemoryStream((ManagerUser_BLL.Instance.GetNVByID(id)).Anh_NV.ToArray());
                    Image im = Image.FromStream(n);
                    imageNV.Image = im;
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butLammoi_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.DataSource = ManagerUser_BLL.Instance.GetALLNV();
        }
    }
}