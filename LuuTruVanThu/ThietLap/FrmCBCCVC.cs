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
    public partial class FrmCBCCVC : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.CoQuanBP coQuan = new DataAccess.CoQuanBP();
        DataAccess.CBCCVC cbccvc = new DataAccess.CBCCVC();
        public FrmCBCCVC()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCBCCVCID.Text = "";
            txtHoTen.Text = "";
            txtHoTen.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cbccvc.saveData(txtCBCCVCID.Text, lstCoQuanBP.SelectedValue.ToString(), txtHoTen.Text);
            loadCBCCVC();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cbccvc.deleteData(txtCBCCVCID.Text);
            loadCBCCVC();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadCoQuanBP()
        {
            bindingCoQuanBP.DataSource = coQuan.getDataTable();
        }
        private void loadCBCCVC()
        {
            if (lstCoQuanBP.SelectedValue == null)
                bindingCBCCVC.DataSource = cbccvc.getDataTable("");
            else
                bindingCBCCVC.DataSource = cbccvc.getDataTable(lstCoQuanBP.SelectedValue.ToString());
        }
        private void FrmCBCCVC_Load(object sender, EventArgs e)
        {
            loadCoQuanBP();
            loadCBCCVC();
        }

        private void bindingCBCCVC_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingCBCCVC.Current;
            if (drv != null)
            {
                txtCBCCVCID.Text = drv["CBCCVCID"].ToString();
                txtHoTen.Text = drv["HoTen"].ToString();
            }
            else btnNew_Click(null, null);
        }

        private void bindingCoQuanBP_CurrentChanged(object sender, EventArgs e)
        {
            loadCBCCVC();
        }
    }
}