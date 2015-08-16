using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSNLYR
{
    public class bsnssDept
    {
        public DataTable consultarDept()
        {
            DataTable dtDepartamento = new DataTable();
            DATLYR.dbDept ObjDept = new DATLYR.dbDept();
            dtDepartamento = ObjDept.consultaDept();
            return dtDepartamento;
        }
    }
}
