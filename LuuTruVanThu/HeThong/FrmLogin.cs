using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LuuTruVanThu.HeThong
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean kiemTra()
        {
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên đăng nhâp!", "Login");
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Login");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            if (!DataAccess.NguoiDung.dangNhap(txtTenDangNhap.Text.Trim(), txtMatKhau.Text))
            {
                MessageBox.Show("Tên đăng nhâp hoặc mật khẩu sai!", "Login");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }
    }
}