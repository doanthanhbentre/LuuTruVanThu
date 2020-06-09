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
    public partial class FrmSoLuu : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.SoLuu soLuu = new DataAccess.SoLuu();
        public FrmSoLuu()
        {
            InitializeComponent();
        }

        private void FrmSoLuu_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = soLuu.getDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSoLuuID.Text = "";
            txtTen.Text = "";
            txtTen.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sổ lưu!", "Sổ lưu");
                txtTen.Focus();
                return;
            }
            soLuu.saveData(txtSoLuuID.Text, txtTen.Text);
            FrmSoLuu_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            soLuu.deleteData(txtSoLuuID.Text);
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
                txtSoLuuID.Text = drv["SoLuuID"].ToString();
                txtTen.Text = drv["Ten"].ToString();
            }
            else btnNew_Click(null, null);
        }
    }
}