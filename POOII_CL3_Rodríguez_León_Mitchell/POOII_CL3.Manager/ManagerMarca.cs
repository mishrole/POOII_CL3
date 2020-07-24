using POOII_CL3.Dominio;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.Manager
{
    public class ManagerMarca
    {
        public List<Marca> Listar()
        {
            return new DomMarca().Listar();
        }
    }
}
