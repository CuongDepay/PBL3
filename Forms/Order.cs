using PBL3.BLL.Admin;
using PBL3.BLL.Staff;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Order : Form
    {
        public string id { get; set; }
        NewDBPBL db = new NewDBPBL();
        public Order(string m)
        {
            id = m;
            InitializeComponent();
            comboBox3.Items.AddRange(Order_BLL.Instance.CBBSearch().ToArray());
            cbbSodienthoai.Items.AddRange(Order_BLL.Instance.CBBSoDienThoai().ToArray());
            cbbIDKhuyenmai.Items.AddRange(Order_BLL.Instance.CBBIDKhuyenMai().ToArray());
        }
        public void show()
        {
            dataGridView1.DataSource = WareHouse_BLL.Instance.GetallThietbiView();
        }
        private void btnOut6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSearchEquip_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
            {
                string se = comboBox3.SelectedItem.ToString();
                dataGridView1.DataSource = WareHouse_BLL.Instance.search_byy(se, txtSearchEquip.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính loại thiết bị");
            }
        }

        private void cbbSodienthoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (KhachHang kh in db.KhachHangs)
            {
                if (kh.SDT == cbbSodienthoai.SelectedItem.ToString())
                {
                    txtCusname.Text = kh.TenKH;
                }
                txtIDHoadon.Text = "HD" + Order_BLL.Instance.NhapIDHoadon().ToString();
            }
        }

        private void cbbIDKhuyenmai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbIDKhuyenmai.SelectedItem.ToString() == "NULL")
            {
                txtTenKhuyenmai.Text = "NULL";
                txtPhanTram.Text = 0.ToString();
            }
            else
            {
                foreach (KhuyenMai km in db.KhuyenMais)
                {
                    if (km.ID_KhuyenMai == cbbIDKhuyenmai.SelectedItem.ToString())
                    {
                        txtTenKhuyenmai.Text = km.TenKhuyenMai;
                        txtPhanTram.Text = km.PhanTram.ToString();
                    }
                }
            }
            cbbIDKhuyenmai.Enabled = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID_ThietBi"].Value.ToString();
                txtIDThietbi.Text = ID;
                txtTensanpham.Text = Order_BLL.Instance.GetThietBiByID(ID).TenThietBi;
                txtGiasanpham.Text = Order_BLL.Instance.GetThietBiByID(ID).GiaBan.ToString();
            }
        }
        private void UpdateStock()
        {
            WareHouse_BLL.Instance.UpdateKho(txtIDThietbi.Text.ToString(), Convert.ToInt32(txtSoluong.Text.ToString()));
        }

        int GrdTotal = 0;
        private void Reset()
        {
            txtIDThietbi.Text = "";
            txtTensanpham.Text = "";
            txtGiasanpham.Text = "";
            txtSoluong.Text = "";
        }
        private void ResetFull()
        {
            txtIDThietbi.Text = "";
            txtTensanpham.Text = "";
            txtGiasanpham.Text = "";
            txtSoluong.Text = "";
            cbbSodienthoai.Text = "";
            txtCusname.Text = "";
            txtIDHoadon.Text = "";
            cbbIDKhuyenmai.Text = "";
            txtTenKhuyenmai.Text = "";
            txtPhanTram.Text = "";
            txtTotal.Text = "";
            datagridviewDonhang.Rows.Clear();
            cbbIDKhuyenmai.Enabled = true;
        }


        private void butReset_Click(object sender, EventArgs e)
        {
            datagridviewDonhang.AllowUserToAddRows = false;
            foreach (DataGridViewRow i in datagridviewDonhang.Rows)
            {
                string idtb = i.Cells[0].Value.ToString();
                int slrf = Convert.ToInt32(i.Cells[3].Value.ToString());
                WareHouse_BLL.Instance.RefundKho(idtb, slrf);
            }
            dataGridView1.DataSource = WareHouse_BLL.Instance.GetallThietbiView();
            ResetFull();
            MessageBox.Show("Đã hủy đơn hàng!");
        }
        public int CheckDGV(string id)
        {
            datagridviewDonhang.AllowUserToAddRows = false;
            foreach (DataGridViewRow i in datagridviewDonhang.Rows)
            {

                string idtb = i.Cells[0].Value.ToString();
                if (idtb == id)
                {
                    return datagridviewDonhang.Rows.IndexOf(i);
                }
            }
            return -1;
        }

        private void butAddtoBill_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "" || txtIDHoadon.Text == "" || txtPhanTram.Text == "" || cbbIDKhuyenmai.Text == ""||txtIDThietbi.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else if (Convert.ToInt32(txtSoluong.Text) > Order_BLL.Instance.GetKhoByID(txtIDThietbi.Text.ToString()).SoLuongTonkho)
            {
                MessageBox.Show("Không đủ số lượng trong kho!");
            }
            else if (CheckDGV(txtIDThietbi.Text) != -1)
            {
                datagridviewDonhang.ColumnCount = 5;
                datagridviewDonhang.Columns[0].Name = "ID_ThietBi";
                datagridviewDonhang.Columns[1].Name = "TenThietBi";
                datagridviewDonhang.Columns[2].Name = "GiaThietBi";
                datagridviewDonhang.Columns[3].Name = "SoLuong";
                datagridviewDonhang.Columns[4].Name = "Tong";
                int soluongpl = Convert.ToInt32(txtSoluong.Text);
                int soluongdgv = Convert.ToInt32(datagridviewDonhang.Rows[CheckDGV(txtIDThietbi.Text)].Cells[3].Value.ToString());
                int soluongcc = soluongpl + soluongdgv;
                datagridviewDonhang.Rows[CheckDGV(txtIDThietbi.Text)].Cells[3].Value = soluongcc;
                int total = soluongcc * Convert.ToInt32(txtGiasanpham.Text);
                datagridviewDonhang.Rows[CheckDGV(txtIDThietbi.Text)].Cells[4].Value = total;
                GrdTotal = GrdTotal + soluongpl * Convert.ToInt32(txtGiasanpham.Text);

                int TongHoadon = GrdTotal - GrdTotal * Convert.ToInt32(txtPhanTram.Text.ToString()) / 100;
                txtTotal.Text = TongHoadon.ToString();
                UpdateStock();
                Reset();
                dataGridView1.DataSource = WareHouse_BLL.Instance.GetallThietbiView();

            }
            else
            {

                int total = Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtGiasanpham.Text);
                datagridviewDonhang.ColumnCount = 5;
                datagridviewDonhang.Columns[0].Name = "ID_ThietBi";
                datagridviewDonhang.Columns[1].Name = "TenThietBi";
                datagridviewDonhang.Columns[2].Name = "GiaThietBi";
                datagridviewDonhang.Columns[3].Name = "SoLuong";
                datagridviewDonhang.Columns[4].Name = "Tong";

                GrdTotal = GrdTotal + total;
                string stt = txtIDThietbi.Text;
                string ten = txtTensanpham.Text;
                string gia = txtGiasanpham.Text;
                string soluong = txtSoluong.Text;
                string tong = (total).ToString();
                string[] row = new string[] { stt, ten, gia, soluong, tong };
                datagridviewDonhang.Rows.Add(row);


                int TongHoadon = GrdTotal - GrdTotal * Convert.ToInt32(txtPhanTram.Text.ToString()) / 100;
                txtTotal.Text = TongHoadon.ToString();
                UpdateStock();
                Reset();
                dataGridView1.DataSource = WareHouse_BLL.Instance.GetallThietbiView();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
            {
                string se = comboBox3.SelectedItem.ToString();
                dataGridView1.DataSource = WareHouse_BLL.Instance.search_byy(se, "");
            }
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            if (datagridviewDonhang.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon()
                {
                    ID_HoaDon = txtIDHoadon.Text,
                    ID_KhuyenMai = cbbIDKhuyenmai.Text,
                    PhanTram = Convert.ToInt32(txtPhanTram.Text.ToString()),
                    TenKhachHang = txtCusname.Text,
                    SDT = cbbSodienthoai.Text,
                    NgayMuaHang = DateTime.Now,
                    TongTien = Convert.ToInt32(txtTotal.Text.ToString()),
                    ID_NV = ManagerUser_BLL.Instance.GetNVByID(id).ID_NV
                };
                Order_BLL.Instance.AddHoaDon(hd);
                datagridviewDonhang.AllowUserToAddRows = false;
                foreach (DataGridViewRow i in datagridviewDonhang.Rows)
                {
                    string idtb = i.Cells[0].Value.ToString();
                    string sl = i.Cells[3].Value.ToString();
                    string gtb = i.Cells[2].Value.ToString();
                    ChiTietHoaDon ct = new ChiTietHoaDon()
                    {
                        ID_HoaDon = txtIDHoadon.Text,
                        ID_ThietBi = idtb,
                        SoLuong = Convert.ToInt32(sl),
                        GiaNhap = Order_BLL.Instance.GetThietBiByID(idtb).GiaNhap,
                        GiaTien = Convert.ToInt32(gtb)
                    };
                    Order_BLL.Instance.AddChitiethoadon(ct);
                }

                ResetFull();
                MessageBox.Show("Đơn hàng đã được lưu!");
            }
            else
            {
                MessageBox.Show("Chưa có thiết bị nào trong đơn hàng!");
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
