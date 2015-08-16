using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSNLYR
{
    public class bsnssDDL
    {
        public DataTable obtenerDDL()
        {
            DataTable dtDDL = new DataTable();
            DATLYR.dbDDL ObjDept = new DATLYR.dbDDL();
            dtDDL = ObjDept.empDDL();
            return dtDDL;
        }
    }
}
