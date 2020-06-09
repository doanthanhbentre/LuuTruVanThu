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

namespace LuuTruVanThu.VanBan
{
    public partial class FrmListDeNghi : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.DeNghi deNghi = new DataAccess.DeNghi();

        public FrmListDeNghi()
        {
            InitializeComponent();
        }

        private void loadDeNghi()
        {
            bindingSource1.DataSource = deNghi.getDataTable(txtTuNgay.DateTime, txtDenNgay.DateTime);
        }
        private void FrmListVanBan_Load(object sender, EventArgs e)
        {
            txtTuNgay.DateTime = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.DateTime = DateTime.Today;
            loadDeNghi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            VanBan.FrmDeNghi frm = new VanBan.FrmDeNghi();
            frm.ShowDialog();
            loadDeNghi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                VanBan.FrmDeNghi frm = new VanBan.FrmDeNghi();
                frm.DeNghiID = drv["DeNghiID"].ToString();
                frm.ShowDialog();
                loadDeNghi();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDeNghi();
        }
    }
}