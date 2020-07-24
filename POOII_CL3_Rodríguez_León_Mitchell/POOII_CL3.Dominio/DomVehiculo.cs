using POOII_CL3.ADOSqlServer;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.Dominio
{
    public class DomVehiculo
    {
        public List<string> Mensajes { get; set; }
        public List<Vehiculo> Listar()
        {
            return new ADOSqlVehiculo().Listar();
        }

        public int Insertar(Vehiculo objeto)
        {
            return new ADOSqlVehiculo().Insertar(objeto);
        }

        public Vehiculo Obtener(int id)
        {
            return new ADOSqlVehiculo().Obtener(id);
        }

        public int Actualizar(Vehiculo objeto)
        {
            return new ADOSqlVehiculo().Actualizar(objeto);
        }

        public int Eliminar(int id)
        {
            return new ADOSqlVehiculo().Eliminar(id);
        }

    }
}
