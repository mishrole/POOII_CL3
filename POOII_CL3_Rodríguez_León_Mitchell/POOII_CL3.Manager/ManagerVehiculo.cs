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

        public Vehiculo Obtener(int id)
        {
            return new DomVehiculo().Obtener(id);
        }

        public int Actualizar(Vehiculo objeto)
        {
            return new DomVehiculo().Actualizar(objeto);
        }

        public int Eliminar(int id)
        {
            return new DomVehiculo().Eliminar(id);
        }

        public List<Vehiculo> ListarVehiculoXMarca(int id)
        {
            return new DomVehiculo().ListarVehiculoXMarca(id);
        }
    }
}
