using POOII_CL3.Dominio;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.Manager
{
    public class ManagerVehiculo
    {
        public List<Vehiculo> Listar()
        {
            return new DomVehiculo().Listar();
        }

        public int Insertar(Vehiculo objeto)
        {
            return new DomVehiculo().Insertar(objeto);
        }
    }
}
