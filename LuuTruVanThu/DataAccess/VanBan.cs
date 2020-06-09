using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class VanBan
    {
        String m_VanBanID, m_SoLuuID, m_LinhVucID, m_LoaiVBID, m_KyHieu, m_NoiDung, m_NguoiSoan, m_NguoiKy, m_NguoiDuyet, m_NguoiLuu, m_GhiChu;
        DateTime m_Ngay;
        Int32 m_STT, m_DiDen, m_PhatHanh;
        public string GhiChu
        {
            get
            {
                return m_GhiChu;
            }

            set
            {
                m_GhiChu = value;
            }
        }

        public string KyHieu
        {
            get
            {
                return m_KyHieu;
            }

            set
            {
                m_KyHieu = value;
            }
        }

        public string LinhVucID
        {
            get
            {
                return m_LinhVucID;
            }

            set
            {
                m_LinhVucID = value;
            }
        }

        public string LoaiVBID
        {
            get
            {
                return m_LoaiVBID;
            }

            set
            {
                m_LoaiVBID = value;
            }
        }

        public string NguoiDuyet
        {
            get
            {
                return m_NguoiDuyet;
            }

            set
            {
                m_NguoiDuyet = value;
            }
        }

        public string NguoiKy
        {
            get
            {
                return m_NguoiKy;
            }

            set
            {
                m_NguoiKy = value;
            }
        }

        public string NguoiLuu
        {
            get
            {
                return m_NguoiLuu;
            }

            set
            {
                m_NguoiLuu = value;
            }
        }

        public string NguoiSoan
        {
            get
            {
                return m_NguoiSoan;
            }

            set
            {
                m_NguoiSoan = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return m_NoiDung;
            }

            set
            {
                m_NoiDung = value;
            }
        }

        public string SoLuuID
        {
            get
            {
                return m_SoLuuID;
            }

            set
            {
                m_SoLuuID = value;
            }
        }

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

        public DateTime Ngay
        {
            get
            {
                return m_Ngay;
            }

            set
            {
                m_Ngay = value;
            }
        }

        public Int32 STT
        {
            get
            {
                return m_STT;
            }

            set
            {
                m_STT = value;
            }
        }

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

        public Int32 PhatHanh
        {
            get
            {
                return m_PhatHanh;
            }

            set
            {
                m_PhatHanh = value;
            }
        }

        public void saveData()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVEVANBAN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "VANBANID", "SOLUUID", "LINHVUCID", "LOAIVBID", "STT", "KYHIEU", "NGAY", "NOIDUNG", "NGUOISOAN", "NGUOIKY", "NGUOIDUYET", "NGUOILUU", "GHICHU", "DIDEN", "PHATHANH" };
            Object[] ThamTri = { VanBanID, SoLuuID, LinhVucID, LoaiVBID, STT, KyHieu, Ngay, NoiDung, NguoiSoan, NguoiKy, NguoiDuyet, NguoiLuu, GhiChu, DiDen, PhatHanh };
            VanBanID = data.sExecuteNonQuery(ThamBien, ThamTri, "VANBANID", 10);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.VanBan";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime tuNgay, DateTime denNgay, Int32 diDen)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.LISTVANBAN";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY", "DIDEN" };
            Object[] ThamTri = { tuNgay, denNgay, diDen };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public void deleteData(String vanBanID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.VanBan Where VanBanID = '" + vanBanID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String vanBanID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.VanBan Where VanBanID = '" + vanBanID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
        public Int32 getSTT(Int32 diDen, Int32 phatHanh)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT MAX(STT) FROM VTLT.VANBAN WHERE DiDen = " + diDen.ToString() + " And PhatHanh = " + phatHanh.ToString();
            data.CommandType = CommandType.Text;
            if (data.ExecuteScalar() == DBNull.Value)
                return 1;
            else
                return Int32.Parse(data.ExecuteScalar().ToString()) + 1;
        }
    }
}
