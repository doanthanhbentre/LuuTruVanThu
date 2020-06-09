using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class SoLuu
    {
        public String saveData(String soLuuID, String ten)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVESOLUU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "SOLUUID", "TENSOLUU" };
            Object[] ThamTri = { soLuuID, ten };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "SOLUUID", 6);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.SoLuu";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String soLuuID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.SoLuu Where SoLuuID = '" + soLuuID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String soLuuID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.SoLuu Where SoLuuID = '" + soLuuID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
    }
}
