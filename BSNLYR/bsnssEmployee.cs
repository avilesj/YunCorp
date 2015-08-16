using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSNLYR
{
    public class bsnssEmployee
    {
        public string emp_nombre;
        public string emp_apellido;
        public string emp_cedula;
        public string emp_ext;
        public string emp_flota;
        public string dept_id;
        public string emp_id;

        public DataTable ConsultarCliente(string emp_parametro, int tipo)
        {
            DataTable dtCliente = new DataTable();
            DATLYR.dbEmployee ObjCliente = new DATLYR.dbEmployee();
            dtCliente = ObjCliente.ConsultarEmpleado(emp_parametro, tipo);
            return dtCliente;
        }

        public void selectEmployee(string emp_parametro, int tipo)
        {
            DataTable dtEmp = new DataTable();
            DATLYR.dbEmployee objEmp = new DATLYR.dbEmployee();
            dtEmp = objEmp.ConsultarEmpleado(emp_parametro, tipo);
            this.emp_nombre = dtEmp.Rows[0]["Nombre"].ToString();
            this.emp_apellido = dtEmp.Rows[0]["Apellido"].ToString();
            this.emp_cedula = dtEmp.Rows[0]["Cedula"].ToString();
            this.emp_ext = dtEmp.Rows[0]["Extension"].ToString();
            this.emp_flota = dtEmp.Rows[0]["Flota"].ToString();
            this.dept_id = dtEmp.Rows[0]["Departamento"].ToString();
            this.emp_id = dtEmp.Rows[0]["Codigo"].ToString();
        }

        public void guardarEmpleado(int emp_id, string emp_nombre, string emp_apellido,
                                    string emp_cedula, string emp_extension, string emp_flota,
                                    int dept_id)
        {
            DATLYR.dbEmployee objEmp = new DATLYR.dbEmployee();
            objEmp.editarEmpleado(emp_id, emp_nombre, emp_apellido,
                                    emp_cedula, emp_extension, emp_flota,
                                    dept_id);
        }
    }
}
