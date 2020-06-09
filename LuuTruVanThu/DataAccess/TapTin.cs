using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class TapTin
    {
        public String saveData(String tapTinID, String vanBanID, String duongDan)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVETAPTIN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TAPTINID", "VANBANID", "TENTAPTIN" };
            Object[] ThamTri = { tapTinID, vanBanID, duongDan };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "TAPTINID", 10);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.TapTin";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String vanBanID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.TapTin Where VanBanID = '" + vanBanID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String tapTinID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.TapTin Where TapTinID = '" + tapTinID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String tapTinID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.TapTin Where TapTinID = '" + tapTinID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
        public void updateFileName(String tapTinID, String tenTapTin)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Update VTLT.TapTin Set DuongDan = '" + tenTapTin + "' Where TapTinID = '" + tapTinID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
