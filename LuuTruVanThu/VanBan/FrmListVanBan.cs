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
    public partial class FrmListVanBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.VanBan vanBan = new DataAccess.VanBan();
        Int32 m_DiDen = 1;

        public int DiDen
        {
            get
            {
                return m_DiDen;
            }

            set
            {
                m_DiDen = value;
            }
        }

        public FrmListVanBan()
        {
            InitializeComponent();
        }

        private void loadVanBan()
        {
            bindingSource1.DataSource = vanBan.getDataTable(txtTuNgay.DateTime, txtDenNgay.DateTime, DiDen);
        }
        private void FrmListVanBan_Load(object sender, EventArgs e)
        {
            txtTuNgay.DateTime = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.DateTime = DateTime.Today;
            if (DiDen == 1)
                lblVanBan.Text = "VĂN BẢN ĐI";
            else
                lblVanBan.Text = "VĂN BẢN ĐẾN";

            loadVanBan();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            VanBan.FrmVanBan frm = new VanBan.FrmVanBan();
            frm.DiDen = DiDen;
            frm.ShowDialog();
            loadVanBan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                VanBan.FrmVanBan frm = new VanBan.FrmVanBan();
                frm.DiDen = DiDen;
                frm.VanBanID = drv["VanBanID"].ToString();
                frm.ShowDialog();
                loadVanBan();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadVanBan();
        }
    }
}