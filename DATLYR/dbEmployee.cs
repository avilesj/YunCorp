using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DATLYR
{
    public class dbEmployee
    {
        public DataTable ConsultarEmpleado(string emp_parameter, int type)
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsCliente = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spConsultaEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //Condiciones para multiples formas de consulta
            if (type == 1)
            {
                cmd.Parameters.AddWithValue("@emp_nombre", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_nombre", "NULL");
            }
            if (type == 2)
            {
                cmd.Parameters.AddWithValue("@emp_apellido", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_apellido", "NULL");
            }
            if (type == 3)
            {
                cmd.Parameters.AddWithValue("@emp_cedula", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_cedula", "NULL");
            }
            if (type == 4)
            {
                cmd.Parameters.AddWithValue("@dept_id", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@dept_id", "NULL");
            }
            if (type == 5)
            {
                cmd.Parameters.AddWithValue("@emp_ext", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_ext", "NULL");
            }
            if (type == 6)
            {
                cmd.Parameters.AddWithValue("@emp_flota", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_flota", "NULL");
            }
            if (type == 7)
            {
                cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(emp_parameter));
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_id", System.Data.SqlTypes.SqlInt32.Null);
            }
            //Fin de multiples formas de consultar

            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            SqlDa.Fill(dsCliente);
            cn.Close();
            return dsCliente.Tables[0];
        }

    }
}
