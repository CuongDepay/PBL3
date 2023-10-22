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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        bool checkloginAdmin(string userName, string passWord)
        {
            if (userName == "admin123" && passWord == "admin123")
            {
                return true;
            }
            return false;
        }
        bool checkLoginUser(string userName, string passWord)
        {
            if (userName == "user123" && passWord == "user123")
            {
                return true;
            }
            return false;
        }
        public string KiemTraTK()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            TaiKhoan tk = LogIn_BLL.Instance.GetTKByUserNameAndPass(username, password);
            return tk.ID_NV;
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            TaiKhoan tk = LogIn_BLL.Instance.GetTKByUserNameAndPass(username, password);
            if (LogIn_BLL.Instance.GetTKByUserNameAndPass(username, password) == null)
            {
                //MessageBox.Show("Wrong Username Or Password !", "Error!", MessageBoxButtons.OK);
                //return;
                DialogResult ret = MessageBox.Show(
                "Wrong Username Or Password !",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                if (ret == DialogResult.OK)
                {
                }
            }
            else
            if (LogIn_BLL.Instance.CheckAdminUser(tk) == false)
            {
                Form2 f = new Form2(KiemTraTK());
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            if (LogIn_BLL.Instance.CheckAdminUser(tk))
            {
                AdminForm f = new AdminForm();
                f.Show();
                this.Hide();
                f.Logout1 += F_Logout1;
            }
           



        }

        private void F_Logout1(object sender, EventArgs e)
        {
            (sender as AdminForm).isExit = false;
            (sender as AdminForm).Close();
            this.Show();
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as Form2).isExit = false;
            (sender as Form2).Close();
            this.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                butLogin_Click(sender, e);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                butLogin_Click(sender, e);
            }
        }
    }
}



