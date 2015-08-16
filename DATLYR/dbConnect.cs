using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DATLYR
{
    public class dbConnect
    {
        public string connect()
        {
            //Extrae string de conexion a la base de datos
            //string cn = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            string cn = "Data Source=JOE-PC\\SQLEXPRESS;Initial Catalog=YunDB;Integrated Security=True";
            return cn;
        }
    }
}
