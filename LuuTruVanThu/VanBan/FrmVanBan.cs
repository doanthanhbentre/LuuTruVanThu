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
    public partial class FrmVanBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.SoLuu soLuu = new DataAccess.SoLuu();
        DataAccess.LinhVuc linhVuc = new DataAccess.LinhVuc();
        DataAccess.LoaiVanBan loaiVB = new DataAccess.LoaiVanBan();
        DataAccess.CBCCVC nguoiSoan = new DataAccess.CBCCVC();
        DataAccess.CBCCVC nguoiKy = new DataAccess.CBCCVC();
        DataAccess.CBCCVC nguoiDuyet = new DataAccess.CBCCVC();
        DataAccess.CBCCVC nguoiLuu = new DataAccess.CBCCVC();
        DataAccess.TapTin tapTin = new DataAccess.TapTin();
        DataAccess.VanBan vanBan = new DataAccess.VanBan();
        DataAccess.NguoiNhan nguoiNhan = new DataAccess.NguoiNhan();
        Int32 m_DiDen = 1;
        public Int32 DiDen
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

        public string VanBanID
        {
            get
            {
                return txtVanBanID.Text;
            }

            set
            {
                txtVanBanID.Text = value;
            }
        }

        public FrmVanBan()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSoLuu.DataSource = soLuu.getDataTable();
            bindingLinhVuc.DataSource = linhVuc.getDataTable();
            bindingLoaiVB.DataSource = loaiVB.getDataTable();
        }
        private void loadTapTin()
        {
            bindingTapTin.DataSource = tapTin.getDataTable(txtVanBanID.Text);
        }
        private void loadCBCCVC()
        {
            bindingNguoiSoan.DataSource = nguoiSoan.getDataTable();
            bindingNguoiKy.DataSource = nguoiKy.getDataTable();
            bindingNguoiDuyet.DataSource = nguoiDuyet.getDataTable();
            bindingNguoiLuu.DataSource = nguoiLuu.getDataTable();
        }

        private void loadNguyoiNhan()
        {
            bindingNguoiNhan.DataSource = nguoiNhan.getDataTable(txtVanBanID.Text);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadVanBan()
        {
            DataRow dr = vanBan.getDataRow(VanBanID);
            if (dr != null)
            {
                txtSoLuu.EditValue = dr["SoLuuID"];
                txtLinhVuc.EditValue = dr["LinhVucID"];
                txtLoaiVB.EditValue = dr["LoaiVBID"];
                txtSTT.Text = dr["STT"].ToString();
                txtKyHieu.Text = dr["KyHieu"].ToString();
                txtNgay.DateTime = DateTime.Parse(dr["Ngay"].ToString());
                txtNoiDung.Text = dr["NoiDung"].ToString();
                txtNguoiSoan.EditValue = dr["NguoiSoan"];
                txtNguoiKy.EditValue = dr["NguoiKy"];
                txtNguoiDuyet.EditValue = dr["NguoiDuyet"];
                txtNguoiLuu.EditValue = dr["NguoiLuu"];
                txtGhiChu.Text = dr["GhiChu"].ToString();
                cboPhatHanh.SelectedIndex = Int32.Parse(dr["PhatHanh"].ToString());
                txtSTT.Text = dr["STT"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private void FrmVanBan_Load(object sender, EventArgs e)
        {
            if (DiDen == 1)
                this.Text = "VĂN BẢN ĐI";
            else
                this.Text = "VĂN BẢN ĐẾN";
            loadData();
            loadCBCCVC();
            if (VanBanID.Length > 0)
                loadVanBan();
            else
                btnNew_Click(null, null);
            loadNguyoiNhan();
            loadTapTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnSave_Click(null, null);
                String m_TapTinID = tapTin.saveData("", txtVanBanID.Text, openFileDialog1.FileName);
                if (m_TapTinID.Length > 0)
                {
                    //String m_FileName = Application.StartupPath + "\\TapTin\\" + m_TapTinID + Path.GetExtension(openFileDialog1.FileName);
                    String m_FileName = "TapTin\\" + m_TapTinID + Path.GetExtension(openFileDialog1.FileName);
                    File.Copy(openFileDialog1.FileName, m_FileName, true);
                    tapTin.updateFileName(m_TapTinID, m_FileName);
                }
                loadTapTin();
            }
        }

        private void bindingTapTin_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnOpen.Enabled = btnHuy.Enabled = bindingTapTin.Count > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtVanBanID.Text.Trim().Length == 0) return;
            vanBan.deleteData(txtVanBanID.Text);
            btnNew_Click(null, null);
        }

        private Boolean kiemTra()
        {
            if (txtSoLuu.EditValue == null)
            {
                MessageBox.Show("Chưa chọn sổ lưu!", "Văn bản");
                txtSoLuu.Focus();
                return false;
            }
            if (txtLinhVuc.EditValue == null)
            {
                MessageBox.Show("Chưa chọn lĩnh vực!", "Văn bản");
                txtLinhVuc.Focus();
                return false;
            }
            if (txtSoLuu.EditValue == null)
            {
                MessageBox.Show("Chưa chọn loại văn bản!", "Văn bản");
                txtLoaiVB.Focus();
                return false;
            }
            return true;
        }
        private void setValues()
        {
            vanBan.VanBanID = txtVanBanID.Text;
            vanBan.SoLuuID = txtSoLuu.EditValue.ToString();
            vanBan.LinhVucID = txtLinhVuc.EditValue.ToString();
            vanBan.LoaiVBID = txtLoaiVB.EditValue.ToString();
            vanBan.STT = Int32.Parse(txtSTT.Text);
            vanBan.KyHieu = txtKyHieu.Text;
            vanBan.Ngay = txtNgay.DateTime;
            vanBan.NoiDung = txtNoiDung.Text;
            vanBan.NguoiSoan = txtNguoiSoan.EditValue == null ? "" : txtNguoiSoan.EditValue.ToString();
            vanBan.NguoiKy = txtNguoiKy.EditValue == null ? "" : txtNguoiKy.EditValue.ToString();
            vanBan.NguoiDuyet = txtNguoiDuyet.EditValue == null ? "" : txtNguoiDuyet.EditValue.ToString();
            vanBan.NguoiLuu = txtNguoiLuu.EditValue == null ? "" : txtNguoiLuu.EditValue.ToString();
            vanBan.GhiChu = txtGhiChu.Text;
            vanBan.DiDen = DiDen;
            vanBan.PhatHanh = cboPhatHanh.SelectedIndex;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            setValues();
            vanBan.saveData();
            txtVanBanID.Text = vanBan.VanBanID;
        }

        private void txtSoLuu_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSoLuu_EditValueChanged(null, null);
            cboPhatHanh.SelectedIndex = 0;
            txtNgay.DateTime = DateTime.Today;
            txtVanBanID.Text = "";
            txtKyHieu.Text = "";
            txtNoiDung.Text = "";
            txtGhiChu.Text = "";
            txtNguoiLuu.EditValue = null;
            loadTapTin();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingTapTin.Current;
            if (drv != null)
            {
                if (MessageBox.Show("Xóa tập tin đính kèm [" + drv["DuongDan"].ToString() + "] phải không?", "Xóa tập tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    File.Delete(drv["DuongDan"].ToString());
                    tapTin.deleteData(drv["TapTinID"].ToString());
                    loadTapTin();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingTapTin.Current;
            if (drv != null)
            {
                Process.Start("explorer.exe", drv["DuongDan"].ToString());
            }
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
        }

        private void btnDelNguoiNhan_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingNguoiNhan.Current;
            if (drv != null)
            {
                if (MessageBox.Show("Xóa người nhận [" + drv["HoTen"].ToString() + "] phải không?", "Xóa người nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    nguoiNhan.deleteData(drv["VanBanID"].ToString(), drv["CBCCVCID"].ToString());
                    loadNguyoiNhan();
                }
            }
        }

        private void btnNewNguoiNhan_Click(object sender, EventArgs e)
        {
            if (txtVanBanID.Text.Length > 0)
            {
                FrmChonCBCCVC frm = new FrmChonCBCCVC();
                frm.VanBanID = txtVanBanID.Text;
                frm.ShowDialog();
                loadNguyoiNhan();
            }
        }

        private void cboPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            txtSTT.Text = vanBan.getSTT(DiDen, cboPhatHanh.SelectedIndex).ToString();
        }
    }
}