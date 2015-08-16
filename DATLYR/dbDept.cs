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

        public DataTable consultaTodosDept()
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsDept = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spConsultaTodosDept", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            SqlDa.Fill(dsDept);
            cn.Close();
            return dsDept.Tables[0];
        }

        public DataTable consultaID(int dept_id)
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsDept = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spCsonultaDeptID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dept_id", dept_id);
            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            SqlDa.Fill(dsDept);
            cn.Close();
            return dsDept.Tables[0];
        }

        public void editarDept(int dept_id, string dept_desc)
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsDept = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spActDept", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dept_id", dept_id);
            cmd.Parameters.AddWithValue("@dept_desc", dept_desc);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
