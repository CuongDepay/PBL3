using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Admin;
using PBL3.DTO;



namespace PBL3
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            cbbCV.Items.Add("Admin");
            cbbCV.Items.Add("User");
            cbbSX.Items.Add("ID tài khoản");
            cbbSX.Items.Add("Tên tài khoản");
            cbbSX.Items.Add("Chức vụ");
        }
        private void btnOut5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void butXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void Reset()
        {
            txtID_TK.Text = "";
            txtID_TK.Enabled = true;
            txtTenTK.Text = "";
            txtMK.Text = "";
            cbbCV.Text = "";
            cbbID_NV.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID_TK"].Value.ToString();
                txtID_TK.Text = id;
                txtID_TK.Enabled = false;
                txtTenTK.Text = ManagerAccount_BLL.Instance.GetTKByID(id).TenTK;
                txtMK.Text = ManagerAccount_BLL.Instance.GetTKByID(id).MatKhau;
                cbbCV.Text = ManagerAccount_BLL.Instance.GetTKByID(id).ChucVu;
                if (ManagerAccount_BLL.Instance.GetTKByID(id).ID_NV == null)
                {
                    cbbID_NV.Text = "";
                }
                else cbbID_NV.Text = ManagerAccount_BLL.Instance.GetTKByID(id).ID_NV;
            }
        }
        private void butSửa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (cbbCV.SelectedItem.ToString() == "User")
                {
                    if (cbbID_NV.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn ID nhân viên");
                    }
                    else
                    {
                        TaiKhoan tk = new TaiKhoan()
                        {
                            ID_TK = txtID_TK.Text,
                            TenTK = txtTenTK.Text,
                            MatKhau = txtMK.Text,
                            ChucVu = cbbCV.Text,
                            ID_NV = cbbID_NV.Text
                        };
                        ManagerAccount_BLL.Instance.Update(tk);
                        Reset();
                        dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
                    }
                }
                else if (cbbCV.SelectedItem.ToString() == "Admin")
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        ID_TK = txtID_TK.Text,
                        TenTK = txtTenTK.Text,
                        MatKhau = txtMK.Text,
                        ChucVu = cbbCV.Text,
                        ID_NV = null
                    };
                    ManagerAccount_BLL.Instance.Update(tk);
                    Reset();
                    dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa");
            }
        }
        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbID_NV.Items.Clear();
            foreach (string i in ManagerAccount_BLL.Instance.GetIDNV().Distinct())
            {
                if (cbbCV.SelectedItem.ToString() == "User")
                {
                    cbbID_NV.Items.Add(i.ToString());
                    foreach (string j in ManagerAccount_BLL.Instance.GetIDNVInTK().Distinct())
                    {
                        cbbID_NV.Items.Remove(j);
                    }

                }
                else if (cbbCV.SelectedItem.ToString() == "Admin")
                {
                    cbbID_NV.Text = "";

                }

            }
        }
        public void kiemtraID(TaiKhoan tk)
        {
            if (ManagerAccount_BLL.Instance.Check(tk.ID_TK))
            {
                MessageBox.Show("ID tài khoản đã tồn tại");
            }
            else
            {
                ManagerAccount_BLL.Instance.Add(tk);
                Reset();
                dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
            }
        }
        private void butThêm_Click(object sender, EventArgs e)
        {
            if (txtID_TK.Text != "" && txtTenTK.Text != "" && txtMK.Text != "")
            {
                if (cbbCV.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn chức vụ");
                }
                else if (cbbCV.SelectedItem.ToString() == "User")
                {
                    if (cbbID_NV.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn ID nhân viên");
                    }
                    else
                    {
                        TaiKhoan tk = new TaiKhoan()
                        {
                            ID_TK = txtID_TK.Text,
                            TenTK = txtTenTK.Text,
                            MatKhau = txtMK.Text,
                            ChucVu = cbbCV.Text,
                            ID_NV = cbbID_NV.Text
                        };
                        kiemtraID(tk);
                    }
                }
                else if (cbbCV.SelectedItem.ToString() == "Admin")
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        ID_TK = txtID_TK.Text,
                        TenTK = txtTenTK.Text,
                        MatKhau = txtMK.Text,
                        ChucVu = cbbCV.Text,
                        ID_NV = null
                    };
                    kiemtraID(tk);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin tài khoản");
            }
        }
        private void butXóa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    string ID = r.Cells["ID_TK"].Value.ToString();
                    TaiKhoan tk = ManagerAccount_BLL.Instance.GetTKByID(ID);
                    if (tk.ChucVu == "Admin")
                    {
                        MessageBox.Show("Không được phép xóa tài khoản admin");
                    }
                    else
                    {
                        ManagerAccount_BLL.Instance.Del(ID);
                    }

                }
                Reset();
                dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa");
            }
        }
        private void butTìm_Click(object sender, EventArgs e)
        {
            if (txtTkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản cần tìm");
            }
            else
            {
                dataGridView1.DataSource = ManagerAccount_BLL.Instance.TimKiem(txtTkiem.Text);
            }
        }
        private void butXếp_Click(object sender, EventArgs e)
        {
            if (cbbSX.Text != "")
            {
                dataGridView1.DataSource = ManagerAccount_BLL.Instance.SapXep(cbbSX.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Hãy chọn thuộc tính cần sắp xếp");
            }
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.DataSource = ManagerAccount_BLL.Instance.GetALLTK();
        }
    }
}