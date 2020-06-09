using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
namespace LuuTruVanThu.VanBan
{
    public partial class FrmDeNghi : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.CoQuanBP noiDeNghi = new DataAccess.CoQuanBP();
        DataAccess.CBCCVC nguoiDeNghi = new DataAccess.CBCCVC();
        DataAccess.CBCCVC nguoiGQ = new DataAccess.CBCCVC();
        DataAccess.DeNghi deNghi = new DataAccess.DeNghi();
        String m_DeNghiID = "";

        public string DeNghiID
        {
            get
            {
                return m_DeNghiID;
            }

            set
            {
                m_DeNghiID = value;
            }
        }

        public FrmDeNghi()
        {
            InitializeComponent();
        }

        private void btnCBCCVC_Click(object sender, EventArgs e)
        {
            ThietLap.FrmCBCCVC frm = new ThietLap.FrmCBCCVC();
            frm.ShowDialog();
            loadCBCCVC();
        }

        private void btnCoQuanBP_Click(object sender, EventArgs e)
        {
            ThietLap.FrmCoQuanBP frm = new ThietLap.FrmCoQuanBP();
            frm.ShowDialog();
            loadNoiDeNghi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadCBCCVC()
        {
            bindingNguoiDeNghi.DataSource = nguoiDeNghi.getDataTable();
            bindingNguoiGQ.DataSource = nguoiGQ.getDataTable();
        }
        private void loadNoiDeNghi()
        {
            bindingNoiDeNghi.DataSource = noiDeNghi.getDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDeNghiID.Text = "";
            txtNgay.DateTime = DateTime.Today;
            txtNoiDung.Text = "";
            txtYKienGQ.Text = "";
            txtFileName.Text = "";
            txtNoiDeNghi.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtDeNghiID.Text = deNghi.saveData(txtDeNghiID.Text, txtCBCCVCID.EditValue.ToString(), txtNoiDeNghi.EditValue.ToString(), txtNgay.DateTime, txtNoiDung.Text, txtYKienGQ.Text, txtNguoiGQ.EditValue.ToString(), chkDone.Checked ? 1 : 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deNghi.deleteData(txtDeNghiID.Text);
            btnNew_Click(null, null);
        }

        private void FrmDeNghi_Load(object sender, EventArgs e)
        {
            btnNew_Click(null, null);
            loadCBCCVC();
            loadNoiDeNghi();
            if (DeNghiID.Length > 0)
                loadDeNghi();
            else
                btnNew_Click(null, null);
        }
        private void loadDeNghi()
        {
            DataRow dr = deNghi.getDataRow(DeNghiID);
            if (dr != null)
            {
                txtDeNghiID.EditValue = dr["DeNghiID"];
                txtNoiDeNghi.EditValue = dr["MaCQBP"];
                txtCBCCVCID.EditValue = dr["CBCCVCID"];
                txtNgay.DateTime = DateTime.Parse(dr["Ngay"].ToString());
                txtNoiDung.Text = dr["NoiDung"].ToString();
                txtYKienGQ.EditValue = dr["YKienGQ"];
                txtNguoiGQ.EditValue = dr["NguoiGQ"];
                txtFileName.EditValue = dr["FileName"];
                chkDone.Checked = dr["Done"].ToString() == "1" ? true : false;
            }
            else btnNew_Click(null, null);
        }

        private void bindingNoiDeNghi_CurrentChanged(object sender, EventArgs e)
        {
            //DataRowView drv = (DataRowView)bindingNoiDeNghi.Current;
            //if (drv != null)
            //    bindingNguoiDeNghi.DataSource = nguoiDeNghi.getDataTable(drv["MaCQBP"].ToString());
            //else
            //    bindingNguoiDeNghi.DataSource = nguoiDeNghi.getDataTable("");
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                btnSave_Click(null, null);
                if (txtDeNghiID.Text.Trim().Length > 0)
                {
                    String m_FileName = "DeNghi\\" + txtDeNghiID.Text.Trim() + Path.GetExtension(openFileDialog1.FileName);
                    File.Copy(openFileDialog1.FileName, m_FileName, true);
                    txtFileName.Text = m_FileName;
                    deNghi.updateFileName(txtDeNghiID.Text, txtFileName.Text);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim().Length > 0)
                Process.Start("explorer.exe", txtFileName.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            File.Delete(txtFileName.Text);
            txtFileName.Text = "";
            deNghi.updateFileName(txtDeNghiID.Text, txtFileName.Text);
        }
    }
}