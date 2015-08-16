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
        }

    }
}
