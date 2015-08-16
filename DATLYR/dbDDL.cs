using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DATLYR
{
    public class dbDDL
    {
        public DataTable empDDL()
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsDDL = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spBusquedaClienteDDL", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            SqlDa.Fill(dsDDL);
            cn.Close();
            return dsDDL.Tables[0];
        }
    }
}
