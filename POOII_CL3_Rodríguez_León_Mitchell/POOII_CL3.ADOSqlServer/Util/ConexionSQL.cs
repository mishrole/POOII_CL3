using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.ADOSqlServer.Util
{
    public class ConexionSQL
    {
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);
        }
    }
}
