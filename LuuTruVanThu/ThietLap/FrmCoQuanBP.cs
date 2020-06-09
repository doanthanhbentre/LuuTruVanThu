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
    public partial class FrmCoQuanBP : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.CoQuanBP coQuanBP = new DataAccess.CoQuanBP();
        public FrmCoQuanBP()
        {
            InitializeComponent();
        }

        private void FrmSoLuu_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = coQuanBP.getDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaCQBP.Text = "";
            txtTenCQBP.Text = "";
            txtTenCQBP.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenCQBP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên cơ quan bộ phận!", "Cơ quan bộ phận");
                txtTenCQBP.Focus();
                return;
            }
            coQuanBP.saveData(txtMaCQBP.Text, txtTenCQBP.Text);
            FrmSoLuu_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            coQuanBP.deleteData(txtMaCQBP.Text);
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
                txtMaCQBP.Text = drv["MaCQBP"].ToString();
                txtTenCQBP.Text = drv["TenCQBP"].ToString();
            }
            else btnNew_Click(null, null);
        }
    }
}