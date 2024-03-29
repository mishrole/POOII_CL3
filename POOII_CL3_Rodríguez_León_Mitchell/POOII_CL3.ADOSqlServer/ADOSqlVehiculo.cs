﻿using POOII_CL3.ADOSqlServer.Util;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    
        public int Insertar(Vehiculo objeto)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_REGISTRAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", objeto.Placa);
                cmd.Parameters.AddWithValue("@Año", objeto.Año);
                cmd.Parameters.AddWithValue("@Modelo", objeto.Modelo);
                cmd.Parameters.AddWithValue("@IdMarca", objeto.IdMarca);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public Vehiculo Obtener(int id)
        {
            Vehiculo objeto = new Vehiculo();

            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_OBTENER", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVehiculo", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    objeto = new Vehiculo()
                    {
                        IdVehiculo = dr.GetInt32(0),
                        Placa = dr.GetString(1),
                        Año = dr.GetInt32(2),
                        Modelo = dr.GetString(3),
                        IdMarca = dr.GetInt32(4),
                        Marca = dr.GetString(5)
                    };
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return objeto;
        }

        public int Actualizar(Vehiculo objeto)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_ACTUALIZAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", objeto.Placa);
                cmd.Parameters.AddWithValue("@Año", objeto.Año);
                cmd.Parameters.AddWithValue("@Modelo", objeto.Modelo);
                cmd.Parameters.AddWithValue("@IdMarca", objeto.IdMarca);
                cmd.Parameters.AddWithValue("@IdVehiculo", objeto.IdVehiculo);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public int Eliminar(int id)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_ELIMINAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVehiculo", id);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public List<Vehiculo> ListarVehiculoXMarca(int id)
        {
            List<Vehiculo> resultado = new List<Vehiculo>();
            SqlConnection cn = new ConexionSQL().ObtenerConexion();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_VEHICULOS_X_MARCA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMarca", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Vehiculo objeto = new Vehiculo();
                    objeto.IdVehiculo = dr.GetInt32(0);
                    objeto.Placa = dr.GetString(1);
                    objeto.Año = dr.GetInt32(2);
                    objeto.Modelo = dr.GetString(3);
                    objeto.IdMarca = dr.GetInt32(4);
                    objeto.Marca = dr.GetString(5);
                    resultado.Add(objeto);
                }
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                cn.Close();
            }

            return resultado;
        }

    }
}
