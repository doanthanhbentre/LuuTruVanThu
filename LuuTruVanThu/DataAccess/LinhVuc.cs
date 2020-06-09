using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class LinhVuc
    {
        public String saveData(String linhVucID, String tenLinhVuc)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVELINHVUC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "LINHVUCID", "TENLINHVUC" };
            Object[] ThamTri = { linhVucID, tenLinhVuc };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "LINHVUCID", 3);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.LinhVuc";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String linhVucID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.LinhVuc Where LinhVucID = '" + linhVucID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String linhVucID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.LinhVuc Where LinhVucID = '" + linhVucID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
    }
}
