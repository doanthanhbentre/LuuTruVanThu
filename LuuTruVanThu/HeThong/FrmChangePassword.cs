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
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean kiemTra()
        {
            if (txtMatKhauCu.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ!", "Change password");
                txtMatKhauCu.Focus();
                return false;
            }
            if (txtMatKhauCu.Text != DataAccess.NguoiDung.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Change password");
                txtMatKhauCu.Focus();
                return false;
            }
            if (txtMatKhauMoi.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!", "Change password");
                txtMatKhauMoi.Focus();
                return false;
            }
            if (txtMatKhauMoi.Text != txtMatKhauMoi2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới sai!", "Change password");
                txtMatKhauMoi2.Focus();
                return false;
            }
            return true;
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            DataAccess.NguoiDung.doiMatKhau(DataAccess.NguoiDung.TenDangNhap, txtMatKhauMoi.Text);
            MessageBox.Show("Đổi mât khẩu thành công!", "Change password");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }
    }
}