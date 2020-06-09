using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class DeNghi
    {
        public String saveData(String deNghiID, String cbccvcID, String maCQBP, DateTime ngay, String noiDung, String yKienGQ, String nguoiGQ, Int32 done)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVEDENGHI";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DENGHIID", "CBCCVCID", "MACQBP", "NGAY", "NOIDUNG", "YKIENGQ", "NGUOIGQ", "DONE" };
            Object[] ThamTri = { deNghiID, cbccvcID, maCQBP, ngay, noiDung, yKienGQ, nguoiGQ, done };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "DENGHIID", 10);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.DENGHI";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.LISTDENGHI";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getDataTable(String maCQBP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.DENGHI Where MaCQBP = '" + maCQBP + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String deNghiID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.DeNghi Where DeNghiID = '" + deNghiID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String deNghiID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.DeNghi Where DeNghiID = '" + deNghiID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
        public void updateFileName(String deNghiID, String fileName)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Update VTLT.DeNghi Set FileName = '" + fileName + "' Where DeNghiID = '" + deNghiID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
