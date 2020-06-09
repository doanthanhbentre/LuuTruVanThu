namespace LuuTruVanThu
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhaiBao = new DevExpress.XtraBars.BarButtonItem();
            this.btnVanBanDen = new DevExpress.XtraBars.BarButtonItem();
            this.btnVanBanDi = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.stsHomNay = new DevExpress.XtraBars.BarStaticItem();
            this.btnSoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLinhVuc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiVanBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnCoQuanBP = new DevExpress.XtraBars.BarButtonItem();
            this.stsTenDangNhap = new DevExpress.XtraBars.BarStaticItem();
            this.btnDeNghi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonVanBan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangXuat,
            this.btnDoiMK,
            this.btnKhaiBao,
            this.btnVanBanDen,
            this.btnVanBanDi,
            this.barStaticItem1,
            this.stsHomNay,
            this.btnSoLuu,
            this.btnLinhVuc,
            this.btnLoaiVanBan,
            this.btnNhanVien,
            this.btnCoQuanBP,
            this.stsTenDangNhap,
            this.btnDeNghi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonVanBan});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(809, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.LargeImage = global::LuuTruVanThu.Properties.Resources.Keys_icon;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 2;
            this.btnDoiMK.ImageOptions.LargeImage = global::LuuTruVanThu.Properties.Resources._1416573065_Password_protection;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMK_ItemClick);
            // 
            // btnKhaiBao
            // 
            this.btnKhaiBao.Caption = "Khai báo";
            this.btnKhaiBao.Id = 3;
            this.btnKhaiBao.ImageOptions.LargeImage = global::LuuTruVanThu.Properties.Resources._1416573149_User;
            this.btnKhaiBao.Name = "btnKhaiBao";
            this.btnKhaiBao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhaiBao_ItemClick);
            // 
            // btnVanBanDen
            // 
            this.btnVanBanDen.Caption = "Văn bản đến";
            this.btnVanBanDen.Id = 4;
            this.btnVanBanDen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVanBanDen.ImageOptions.Image")));
            this.btnVanBanDen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVanBanDen.ImageOptions.LargeImage")));
            this.btnVanBanDen.Name = "btnVanBanDen";
            this.btnVanBanDen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVanBanDen_ItemClick);
            // 
            // btnVanBanDi
            // 
            this.btnVanBanDi.Caption = "Văn bản đi";
            this.btnVanBanDi.Id = 5;
            this.btnVanBanDi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVanBanDi.ImageOptions.Image")));
            this.btnVanBanDi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVanBanDi.ImageOptions.LargeImage")));
            this.btnVanBanDi.Name = "btnVanBanDi";
            this.btnVanBanDi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVanBanDi_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Tác giả: CN. Đoàn Văn Thanh, ĐT: 0946 459 989";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // stsHomNay
            // 
            this.stsHomNay.Caption = "Hôm nay";
            this.stsHomNay.Id = 7;
            this.stsHomNay.Name = "stsHomNay";
            // 
            // btnSoLuu
            // 
            this.btnSoLuu.Caption = "Khai báo Sổ lưu";
            this.btnSoLuu.Id = 9;
            this.btnSoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoLuu.ImageOptions.Image")));
            this.btnSoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoLuu.ImageOptions.LargeImage")));
            this.btnSoLuu.Name = "btnSoLuu";
            this.btnSoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoLuu_ItemClick);
            // 
            // btnLinhVuc
            // 
            this.btnLinhVuc.Caption = "Lĩnh vực văn bản";
            this.btnLinhVuc.Id = 10;
            this.btnLinhVuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLinhVuc.ImageOptions.Image")));
            this.btnLinhVuc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLinhVuc.ImageOptions.LargeImage")));
            this.btnLinhVuc.Name = "btnLinhVuc";
            this.btnLinhVuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLinhVuc_ItemClick);
            // 
            // btnLoaiVanBan
            // 
            this.btnLoaiVanBan.Caption = "Loại văn bản";
            this.btnLoaiVanBan.Id = 11;
            this.btnLoaiVanBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiVanBan.ImageOptions.Image")));
            this.btnLoaiVanBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiVanBan.ImageOptions.LargeImage")));
            this.btnLoaiVanBan.Name = "btnLoaiVanBan";
            this.btnLoaiVanBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiVanBan_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Cán bộ viên chức";
            this.btnNhanVien.Id = 14;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnCoQuanBP
            // 
            this.btnCoQuanBP.Caption = "Cơ quan bộ phận";
            this.btnCoQuanBP.Id = 15;
            this.btnCoQuanBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCoQuanBP.ImageOptions.Image")));
            this.btnCoQuanBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCoQuanBP.ImageOptions.LargeImage")));
            this.btnCoQuanBP.Name = "btnCoQuanBP";
            this.btnCoQuanBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCoQuanBP_ItemClick);
            // 
            // stsTenDangNhap
            // 
            this.stsTenDangNhap.Id = 17;
            this.stsTenDangNhap.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.stsTenDangNhap.ItemAppearance.Normal.Options.UseForeColor = true;
            this.stsTenDangNhap.Name = "stsTenDangNhap";
            // 
            // btnDeNghi
            // 
            this.btnDeNghi.Caption = "Đề nghị";
            this.btnDeNghi.Id = 18;
            this.btnDeNghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeNghi.ImageOptions.Image")));
            this.btnDeNghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeNghi.ImageOptions.LargeImage")));
            this.btnDeNghi.Name = "btnDeNghi";
            this.btnDeNghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeNghi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhaiBao);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Thiết lập";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSoLuu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLinhVuc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoaiVanBan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Văn bản";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCoQuanBP);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nhân viên, Khoa phòng";
            // 
            // ribbonVanBan
            // 
            this.ribbonVanBan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonVanBan.Name = "ribbonVanBan";
            this.ribbonVanBan.Text = "Văn bản";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVanBanDi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVanBanDen);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDeNghi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Văn bản";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Báo cáo";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.stsHomNay);
            this.ribbonStatusBar1.ItemLinks.Add(this.stsTenDangNhap, true);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 420);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(809, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::LuuTruVanThu.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Lưu trữ văn bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonVanBan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem btnKhaiBao;
        private DevExpress.XtraBars.BarButtonItem btnVanBanDen;
        private DevExpress.XtraBars.BarButtonItem btnVanBanDi;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem stsHomNay;
        private DevExpress.XtraBars.BarButtonItem btnSoLuu;
        private DevExpress.XtraBars.BarButtonItem btnLinhVuc;
        private DevExpress.XtraBars.BarButtonItem btnLoaiVanBan;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnCoQuanBP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarStaticItem stsTenDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDeNghi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

