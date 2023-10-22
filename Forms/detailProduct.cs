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

namespace PBL3.Forms
{
    public partial class detailProduct : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public string IDThietbi { get; set; }
        private int index;
        public detailProduct(string id, int i)
        {
            InitializeComponent();
            IDThietbi = id;
            index = i;
            GUI(index);
            cbbLoaiTB.Items.AddRange(WareHouse_BLL.Instance.CBBLoaiTB().ToArray());
        }
        public void GUI(int index)
        {
            if (WareHouse_BLL.Instance.Check(IDThietbi))
            {
                txtIDThietbi.Enabled = false;
                if (index == 1)
                {
                    txtTenThietbi.Enabled = false;
                    cbbLoaiTB.Enabled = false;
                    txtNhasx.Enabled = false;
                    txtGiaban.Enabled = false;
                    butOK.Enabled = false;
                }
                if (index == 2)
                {
                    txtTenThietbi.Enabled = true;
                    cbbLoaiTB.Enabled = true;
                    txtNhasx.Enabled = true;
                    txtGiaban.Enabled = true;
                    butOK.Enabled = true;
                }
                txtGianhap.Enabled = false;
                txtSoluongtonkho.Enabled = false;
                txtSoluongnhap.Enabled = false;
                txtSoluongdaban.Enabled = false;
                txtIDThietbi.Text = IDThietbi;
                txtTenThietbi.Text = WareHouse_BLL.Instance.GetThietBiByID(IDThietbi).TenThietBi.ToString();
                cbbLoaiTB.Text = WareHouse_BLL.Instance.GetThietBiByID(IDThietbi).LoaiThietBi.ToString();
                txtNhasx.Text = WareHouse_BLL.Instance.GetThietBiByID(IDThietbi).NhaSX.ToString();
                txtGianhap.Text = WareHouse_BLL.Instance.GetThietBiByID(IDThietbi).GiaNhap.ToString();
                txtGiaban.Text = WareHouse_BLL.Instance.GetThietBiByID(IDThietbi).GiaBan.ToString();
                txtSoluongnhap.Text = WareHouse_BLL.Instance.GetKhoByID(IDThietbi).TongSoLuongNhap.ToString();
                txtSoluongdaban.Text = WareHouse_BLL.Instance.GetKhoByID(IDThietbi).SoLuongBan.ToString();
                txtSoluongtonkho.Text = WareHouse_BLL.Instance.GetKhoByID(IDThietbi).SoLuongTonkho.ToString();
            }
        }

        private ThietBi getThietbi()
        {
            try
            {
                ThietBi tb = new ThietBi()
                {
                    ID_ThietBi = txtIDThietbi.Text,
                    TenThietBi = txtTenThietbi.Text,
                    LoaiThietBi = cbbLoaiTB.Text,
                    NhaSX = txtNhasx.Text,
                    GiaNhap = Convert.ToDouble(txtGianhap.Text.ToString()),
                    GiaBan = Convert.ToDouble(txtGiaban.Text.ToString()),
                };
                return tb;
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ");
                return null;
            }
        }
        private KHO getKhoThietbi()
        {
            try
            {
                KHO c = new KHO()
                {
                    ID_ThietBi = txtIDThietbi.Text,
                    TongSoLuongNhap = Convert.ToInt32(txtSoluongnhap.Text.ToString()),
                    SoLuongTonkho = Convert.ToInt32(txtSoluongnhap.Text.ToString()),
                    SoLuongBan = 0

                };
                return c;
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ");
                return null;
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            KHO kho = getKhoThietbi();
            if (txtIDThietbi.Text == "" || txtTenThietbi.Text == "" || cbbLoaiTB.Text == "" || txtNhasx.Text == "" || txtGianhap.Text == "" || txtSoluongnhap.Text == "" || txtGiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (cbbLoaiTB.Text == "Máy Tính")
                {
                    if (kho.TongSoLuongNhap < 2)
                    {
                        MessageBox.Show("Số lượng nhập quá ít, vui lòng nhập thêm!");
                        txtSoluongnhap.Text = "";
                        txtSoluongtonkho.Text = "";
                    }
                    else if (kho.TongSoLuongNhap > 100)
                    {
                        DialogResult result = MessageBox.Show("Số lượng nhập đã nhiều, bạn vẫn muốn nhập ?", "Hỏi Nhập Kho ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            WareHouse_BLL.Instance.Excute(getThietbi(), getKhoThietbi());
                            d();
                            this.Close();
                        }
                        else
                        {
                            txtSoluongnhap.Text = "";
                            txtSoluongtonkho.Text = "";
                        }
                    }
                    else
                    {
                        WareHouse_BLL.Instance.Excute(getThietbi(), getKhoThietbi());
                        d();
                        this.Close();
                    }
                }
                else
                {
                    if (kho.TongSoLuongNhap > 120)
                    {
                        DialogResult result = MessageBox.Show("Số lượng nhập đã nhiều, bạn vẫn muốn nhập ?", "Hỏi Nhập Kho ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            WareHouse_BLL.Instance.Excute(getThietbi(), getKhoThietbi());
                            d();
                            this.Close();
                        }
                        else
                        {
                            txtSoluongnhap.Text = "";
                            txtSoluongtonkho.Text = "";
                        }
                    }
                    else if (kho.TongSoLuongNhap < 2)
                    {
                        MessageBox.Show("Số lượng nhập quá ít, vui lòng nhập thêm!");
                        txtSoluongnhap.Text = "";
                        txtSoluongtonkho.Text = "";
                    }
                    else
                    {
                        WareHouse_BLL.Instance.Excute(getThietbi(), getKhoThietbi());
                        d();
                        this.Close();
                    }
                }
            }
        }
        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoluongnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoluongdaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoluongtonkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

