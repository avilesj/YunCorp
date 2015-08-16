using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSNLYR
{
    public class bsnssDept
    {
        public string dept_nombre;
        public string dept_gerente;
        public string dept_id;

        public DataTable consultarDept()
        {
            DataTable dtDepartamento = new DataTable();
            DATLYR.dbDept ObjDept = new DATLYR.dbDept();
            dtDepartamento = ObjDept.consultaDept();
            return dtDepartamento;
        }

        public DataTable consultarTodos()
        {
            DataTable dtDepartamento = new DataTable();
            DATLYR.dbDept ObjDept = new DATLYR.dbDept();
            dtDepartamento = ObjDept.consultaTodosDept();
            return dtDepartamento;
        }

        public void consultarID(int dept_id)
        {
            DataTable dtTable = new DataTable();
            DATLYR.dbDept objDept = new DATLYR.dbDept();
            dtTable = objDept.consultaID(dept_id);
            this.dept_id = dtTable.Rows[0]["Codigo"].ToString();
            this.dept_gerente = dtTable.Rows[0]["Gerente"].ToString();
            this.dept_nombre = dtTable.Rows[0]["Departamento"].ToString();

        }
        public void actualizarDept(int dept_id, string dept_desc)
        {
            DATLYR.dbDept objDept = new DATLYR.dbDept();
            objDept.editarDept(dept_id, dept_desc);
        }
    }
}
