using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class CBCCVC
    {
        public String saveData(String cbccvcID, String maCQBP, String hoTen)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVECBCCVC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "CBCCVCID", "MACQBP", "HOTEN" };
            Object[] ThamTri = { cbccvcID, maCQBP, hoTen };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "CBCCVCID", 5);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select NV.CBCCVCID, NV.HOTEN, BP.TENCQBP From VTLT.CBCCVC NV INNER JOIN VTLT.COQUANBP BP ON NV.MACQBP = BP.MACQBP";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable2()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select NV.CBCCVCID, NV.HOTEN || ' [' || BP.TENCQBP || ']' as HOTEN From VTLT.CBCCVC NV INNER JOIN VTLT.COQUANBP BP ON NV.MACQBP = BP.MACQBP";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }

        public DataTable getDataTable(String maCQBP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.CBCCVC Where MaCQBP = '" + maCQBP + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String cbccvcID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.CBCCVC Where CBCCVCID = '" + cbccvcID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataRow getDataRow(String cbccvcID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From VTLT.CBCCVC Where CBCCVCID = '" + cbccvcID + "'";
            data.CommandType = CommandType.Text;
            return data.GetDataRow();
        }
    }
}
