using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class CoQuanBP
    {
        public String saveData(String maCQBP, String tenCQBP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVECOQUANBP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MACQBP", "TENCQBP" };
            Object[] ThamTri = { maCQBP, tenCQBP };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "MACQBP", 5);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.CoQuanBP";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String maCQBP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.CoQuanBP Where MaCQBP = '" + maCQBP + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String maCQBP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.CoQuanBP Where MaCQBP = '" + maCQBP + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
    }
}
