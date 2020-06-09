using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu.DataAccess
{
    public class NguoiNhan
    {
        public void saveData(String vanBanID, String cbccvcID, DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "VTLT.SAVENGUOINHAN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "VANBANID", "CBCCVCID", "NGAY" };
            Object[] ThamTri = { vanBanID, cbccvcID, ngay };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable(String vanBanID)
        {
            String m_SQL = "SELECT NN.VANBANID, NN.NGAY, NN.CBCCVCID, NV.HOTEN, NV.MACQBP, BP.TENCQBP ";
            m_SQL += "FROM VTLT.NGUOINHAN NN INNER JOIN VTLT.CBCCVC NV ON NN.CBCCVCID = NV.CBCCVCID ";
            m_SQL += "JOIN VTLT.COQUANBP BP ON NV.MACQBP = BP.MACQBP ";
            m_SQL += "WHERE VANBANID = '" + vanBanID + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public void deleteData(String vanBanID, String cbccvcID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Delete VTLT.NGUOINHAN Where VANBANID = '" + vanBanID + "' AND CBCCVCID = '" + cbccvcID + "'";
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
