using POOII_CL3.ADOSqlServer;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.Dominio
{
    public class DomMarca
    {
        public List<string> Mensajes { get; set; }

        public List<Marca> Listar()
        {
            return new ADOSqlMarca().Listar();
        }
    }
}
