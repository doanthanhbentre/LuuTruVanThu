using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LuuTruVanThu.DataAccess
{
    public static class NguoiDung
    {
        private static String m_TenDangNhap = String.Empty;
        private static String m_MatKhau = String.Empty;
        private static String m_HoTen = String.Empty;

        public static String TenDangNhap
        {
            get { return m_TenDangNhap; }
            //set { m_TenDangNhap = value; }
        }

        public static String MatKhau
        {
            get { return m_MatKhau; }
            //set { m_MatKhau = value; }
        }

        public static String HoTen
        {
            get { return m_HoTen; }
            //set { m_HoTen = value; }
        }
        public static void saveData(String tenDangNhap, String matKhau, String hoTen)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVENGUOIDUNG";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TENDANGNHAP", "MATKHAU", "HOTEN" };
            Object[] ThamTri = { tenDangNhap, matKhau, hoTen };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public static void deleteData(String tenDangNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM VTLT.NGUOIDUNG WHERE TenDangNhap = '" + tenDangNhap + "' AND UCASE(TENDANGNHAP) != 'ADMIN'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public static DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM VTLT.NGUOIDUNG";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public static DataRow getDataRow(String tenDangNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM VTLT.NGUOIDUNG WHERE UCASE(TenDangNhap) = '" + tenDangNhap.ToUpper() + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public static Boolean dangNhap(String tenDangNhap, String matKhau)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM VTLT.NGUOIDUNG WHERE UCASE(TenDangNhap) = '" + tenDangNhap.ToUpper() + "' AND MatKhau = '" + matKhau + "'";
            data.CommandType = System.Data.CommandType.Text;
            DataRow dr = data.GetDataRow();
            if (dr == null)
            {
                m_TenDangNhap = "";
                m_MatKhau = "";
                m_HoTen = "";
                return false;
            }
            else
            {
                m_TenDangNhap = dr["TenDangNhap"].ToString();
                m_MatKhau = dr["MatKhau"].ToString();
                m_HoTen = dr["HoTen"].ToString();
                return true;
            }
        }
        public static void doiMatKhau(String tenDangNhap, String matKhau)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE VTLT.NGUOIDUNG SET MATKHAU = '" + matKhau + "' WHERE UCASE(TenDangNhap) = '" + tenDangNhap.ToUpper() + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
