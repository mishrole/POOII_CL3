﻿using POOII_CL3.ADOSqlServer.Util;
using POOII_CL3.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace POOII_CL3.ADOSqlServer
{
    public class ADOSqlMarca
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();

            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_MARCAS_LISTAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Marca()
                    {
                        IdMarca = dr.GetInt32(0),
                        Nombre = dr.GetString(1)
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
    }
}
