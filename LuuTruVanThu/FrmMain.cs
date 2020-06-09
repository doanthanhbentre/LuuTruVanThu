using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuuTruVanThu
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private string getThu()
        {
            String m_Thu = "";
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    m_Thu = "thứ Sáu";
                    break;
                case DayOfWeek.Monday:
                    m_Thu = "thứ Hai";
                    break;
                case DayOfWeek.Saturday:
                    m_Thu = "thứ Bảy";
                    break;
                case DayOfWeek.Sunday:
                    m_Thu = "Chủ nhật";
                    break;
                case DayOfWeek.Thursday:
                    m_Thu = "thứ Năm";
                    break;
                case DayOfWeek.Tuesday:
                    m_Thu = "thứ Ba";
                    break;
                case DayOfWeek.Wednesday:
                    m_Thu = "thứ Tư";
                    break;
            }
            return m_Thu;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //MdiClient ctlMDI;
            //foreach (Control ctl in this.Controls)
            //    {
            //        try
            //        {
            //            ctlMDI = (MdiClient)ctl;
            //            ctlMDI.BackColor = this.BackColor;
            //        }
            //        catch (InvalidCastException exc)
            //        {
            //            // Catch and ignore the error if casting failed.
            //        }
            //    }
            ribbonControl1.SelectedPage = ribbonVanBan;
            stsHomNay.Caption = String.Format("Hôm nay, {0} ngày {1} tháng {2} năm {3}", getThu(), DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            btnDangXuat_ItemClick(null, null);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmLogin frm = new HeThong.FrmLogin();
            if (frm.ShowDialog() != DialogResult.OK) Close();
            stsTenDangNhap.Caption = DataAccess.NguoiDung.HoTen;
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmChangePassword frm = new HeThong.FrmChangePassword();
            if (frm.ShowDialog() == DialogResult.OK) btnDangXuat_ItemClick(null, null);
        }

        private void btnKhaiBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmCreateUsers frm = new HeThong.FrmCreateUsers();
            frm.ShowDialog();
        }

        private void btnSoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmSoLuu frm = new ThietLap.FrmSoLuu();
            frm.ShowDialog();
        }

        private void btnLinhVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmLinhVuc frm = new ThietLap.FrmLinhVuc();
            frm.ShowDialog();
        }

        private void btnLoaiVanBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmLoaiVanBan frm = new ThietLap.FrmLoaiVanBan();
            frm.ShowDialog();
        }

        private void btnCoQuanBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmCoQuanBP frm = new ThietLap.FrmCoQuanBP();
            frm.ShowDialog();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmCBCCVC frm = new ThietLap.FrmCBCCVC();
            frm.ShowDialog();
        }

        private void btnVanBanDen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VanBan.FrmListVanBan frm = new VanBan.FrmListVanBan();
            frm.DiDen = 2;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void btnVanBanDi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VanBan.FrmListVanBan frm = new VanBan.FrmListVanBan();
            frm.DiDen = 1;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDeNghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VanBan.FrmListDeNghi frm = new VanBan.FrmListDeNghi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
