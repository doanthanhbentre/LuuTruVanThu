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
    public partial class FrmChonCBCCVC : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.CBCCVC cbccvc = new DataAccess.CBCCVC();
        DataAccess.NguoiNhan nguoiNhan = new DataAccess.NguoiNhan();
        String m_VanBanID;

        public string VanBanID
        {
            get
            {
                return m_VanBanID;
            }

            set
            {
                m_VanBanID = value;
            }
        }

        public FrmChonCBCCVC()
        {
            InitializeComponent();
        }

        private void FrmChonCBCCVC_Load(object sender, EventArgs e)
        {
            txtNgay.DateTime = DateTime.Today;
            bindingCBCCVC.DataSource = cbccvc.getDataTable2();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
                chkListCBCCVC.CheckAll();
            else
                chkListCBCCVC.UnCheckAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean m_Chon = false;
            for (Int32 i = 0; i < chkListCBCCVC.ItemCount; i++)
            {
                if (chkListCBCCVC.GetItemChecked(i))
                {
                    nguoiNhan.saveData(VanBanID, chkListCBCCVC.GetItemValue(i).ToString(), txtNgay.DateTime);
                    m_Chon = true;
                }
            }
            if (!m_Chon)
            {
                MessageBox.Show("Bạn chưa chọn người nhận!", "Người nhận");
                return;
            }
            Close();            
        }
    }
}