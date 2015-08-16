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
                cmd.Parameters.AddWithValue("@emp_nombre", System.Data.SqlTypes.SqlString.Null);
            }
            if (type == 2)
            {
                cmd.Parameters.AddWithValue("@emp_apellido", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_apellido", System.Data.SqlTypes.SqlString.Null);
            }
            if (type == 3)
            {
                cmd.Parameters.AddWithValue("@emp_cedula", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_cedula", System.Data.SqlTypes.SqlString.Null);
            }
            if (type == 4)
            {
                cmd.Parameters.AddWithValue("@dept_id", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@dept_id", System.Data.SqlTypes.SqlString.Null);
            }
            if (type == 5)
            {
                cmd.Parameters.AddWithValue("@emp_ext", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_ext", System.Data.SqlTypes.SqlString.Null);
            }
            if (type == 6)
            {
                cmd.Parameters.AddWithValue("@emp_flota", emp_parameter);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emp_flota", System.Data.SqlTypes.SqlString.Null);
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

        public void editarEmpleado(int emp_id, string emp_nombre, string emp_apellido,
                                    string emp_cedula, string emp_extension, string emp_flota,
                                    int dept_id)
        {
            dbConnect ObjConexionDB = new dbConnect();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spActEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (String.IsNullOrEmpty(emp_nombre))
            {
                emp_nombre = "NULL";
            }

            if (String.IsNullOrEmpty(emp_apellido))
            {
                emp_apellido = "NULL";
            }

            if (String.IsNullOrEmpty(emp_cedula))
            {
                emp_cedula = "NULL";
            }

            if (String.IsNullOrEmpty(emp_extension))
            {
                emp_extension = "NULL";
            }

            if (String.IsNullOrEmpty(emp_flota))
            {
                emp_flota = "NULL";
            }

            cmd.Parameters.AddWithValue("@emp_nombre", emp_nombre);
            cmd.Parameters.AddWithValue("@emp_apellido", emp_apellido);
            cmd.Parameters.AddWithValue("@emp_cedula", emp_cedula);
            cmd.Parameters.AddWithValue("@dept_id", dept_id);
            cmd.Parameters.AddWithValue("@emp_ext", emp_extension);
            cmd.Parameters.AddWithValue("@emp_flota", emp_flota);
            cmd.Parameters.AddWithValue("@emp_id",emp_id);
            cmd.ExecuteNonQuery();
            
            //Fin de multiples formas de consultar

            SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
            cn.Close();
        }

        public void eliminarEmpleado(int emp_id)
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsCliente = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spEliminarEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", emp_id);
            cmd.ExecuteNonQuery();
        }

        public void crearEmpleado(string emp_nombre, string emp_apellido,
                                    string emp_cedula, string emp_extension, string emp_flota,
                                    int dept_id)
        {
            dbConnect ObjConexionDB = new dbConnect();
            DataSet dsCliente = new DataSet();
            SqlConnection cn = new SqlConnection(ObjConexionDB.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand("spNuevoEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_nombre", emp_nombre);
            cmd.Parameters.AddWithValue("@emp_apellido", emp_apellido);
            cmd.Parameters.AddWithValue("@emp_cedula", emp_cedula);
            cmd.Parameters.AddWithValue("@dept_id", dept_id);
            cmd.Parameters.AddWithValue("@emp_ext", emp_extension);
            cmd.Parameters.AddWithValue("@emp_flota", emp_flota);
            cmd.ExecuteNonQuery();
        }

    }
}
