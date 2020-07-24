using POOII_CL3.ADOSqlServer.Util;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.ADOSqlServer
{
    public class ADOSqlVehiculo
    {
        public List<Vehiculo> Listar()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_LISTAR", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Vehiculo()
                    {
                        IdVehiculo = dr.GetInt32(0),
                        Placa = dr.GetString(1),
                        Año = dr.GetInt32(2),
                        Modelo = dr.GetString(3),
                        IdMarca = dr.GetInt32(4),
                        Marca = dr.GetString(5)
                    });

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}
