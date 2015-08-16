using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DATLYR
{
    public class dbDept
    {
        public DataTable consultaDept()
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsDept = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spConsultaDepartamentos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            SqlDa.Fill(dsDept);
            cn.Close();
            return dsDept.Tables[0];
        }
    }
}
