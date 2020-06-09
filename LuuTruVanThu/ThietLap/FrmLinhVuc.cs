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
    public partial class FrmLinhVuc : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.LinhVuc linhVuc = new DataAccess.LinhVuc();
        public FrmLinhVuc()
        {
            InitializeComponent();
        }

        private void FrmSoLuu_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = linhVuc.getDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtLinhVucID.Text = "";
            txtTenLinhVuc.Text = "";
            txtTenLinhVuc.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenLinhVuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên lĩnh vực!", "Lĩnh vực");
                txtTenLinhVuc.Focus();
                return;
            }
            linhVuc.saveData(txtLinhVucID.Text, txtTenLinhVuc.Text);
            FrmSoLuu_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            linhVuc.deleteData(txtLinhVucID.Text);
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
                txtLinhVucID.Text = drv["LinhVucID"].ToString();
                txtTenLinhVuc.Text = drv["TenLinhVuc"].ToString();
            }
            else btnNew_Click(null, null);
        }
    }
}