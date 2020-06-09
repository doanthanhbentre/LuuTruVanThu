using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class LoaiVanBan
    {
        public String saveData(String loaiVBID, String tenLoaiVB)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVELOAIVANBAN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "LOAIVANBANID", "TENLOAIVANBAN" };
            Object[] ThamTri = { loaiVBID, tenLoaiVB };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "LOAIVANBANID", 2);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.LoaiVanBan";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String loaiVBID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.LoaiVanBan Where LoaiVBID = '" + loaiVBID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String loaiVBID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.LoaiVanBan Where LoaiVBID = '" + loaiVBID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
    }
}
