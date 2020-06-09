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

namespace LuuTruVanThu.ThietLap
{
    public partial class FrmLoaiVanBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.LoaiVanBan loaiVanBan = new DataAccess.LoaiVanBan();
        public FrmLoaiVanBan()
        {
            InitializeComponent();
        }

        private void FrmSoLuu_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = loaiVanBan.getDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtLoaiVBID.Text = "";
            txtTenLoaiVB.Text = "";
            txtTenLoaiVB.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiVB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên loại văn bản!", "Loại văn bản");
                txtTenLoaiVB.Focus();
                return;
            }
            loaiVanBan.saveData(txtLoaiVBID.Text, txtTenLoaiVB.Text);
            FrmSoLuu_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loaiVanBan.deleteData(txtLoaiVBID.Text);
            FrmSoLuu_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                txtLoaiVBID.Text = drv["LoaiVBID"].ToString();
                txtTenLoaiVB.Text = drv["TenLoaiVB"].ToString();
            }
            else btnNew_Click(null, null);
        }
    }
}