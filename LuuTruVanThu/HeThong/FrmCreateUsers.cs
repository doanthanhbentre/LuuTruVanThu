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
    public partial class FrmCreateUsers : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreateUsers()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = DataAccess.NguoiDung.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void FrmCreateUsers_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtMatKhau2.Text = "";
            txtTenDangNhap.Focus();
        }

        private void FrmCreateUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                txtTenDangNhap.Text = drv["TenDangNhap"].ToString();
                txtHoTen.Text = drv["HoTen"].ToString();
                txtMatKhau.Text = drv["MatKhau"].ToString();
                txtMatKhau2.Text = drv["MatKhau"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!", "Create Users");
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập họ tên!", "Create Users");
                txtHoTen.Focus();
                return false;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!", "Create Users");
                txtMatKhau.Focus();
                return false;
            }
            if (txtMatKhau.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới sai!", "Create Users");
                txtMatKhau2.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            DataAccess.NguoiDung.saveData(txtTenDangNhap.Text, txtMatKhau.Text, txtHoTen.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess.NguoiDung.deleteData(txtTenDangNhap.Text);
            loadData();
            btnNew.Focus();
        }
    }
}