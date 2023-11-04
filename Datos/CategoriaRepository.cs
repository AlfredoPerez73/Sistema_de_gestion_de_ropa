﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class CategoriaRepository : ConexionRepository
    {
        private ConexionRepository connection = new ConexionRepository();
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public CategoriaRepository() : base()
        {

        }

        public List<Categoria> CargarRegistro()
        {
            List<Categoria> categoriaList = new List<Categoria>();
            string Consulta = "SELECT * FROM CATEGORIA";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categoriaList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return categoriaList;
        }

        public string GuardarRegistros(Categoria categoria)
        {
            try
            {
                string Registro = "INSERT INTO CATEGORIA(IdCategoria,TipoCategoria) VALUES('" + categoria.IdCategoria + "', '" + categoria.TipoCategoria + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado la categoria {categoria.TipoCategoria}" +
                $"con la ID {categoria.IdCategoria}";
        }

        public string ModificarRegistros(Categoria categoria)
        {
            try
            {
                string Actualizar = "ModificarCategoria";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@TipoCategoria", categoria.TipoCategoria);
                command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar la categoria";
            }
            return $"Se ha modificar el producto {categoria.TipoCategoria}" +
                $"con la ID {categoria.IdCategoria}";
        }

        public string EliminarRegistros(Categoria categoria)
        {
            try
            {
                string Eliminar = "EliminarCategoria";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar la categoria";
            }
            return $"Se ha eliminar la categoria {categoria.TipoCategoria}" +
                $"con la ID {categoria.TipoCategoria}";
        }

        public bool BuscarCategoria(Categoria categoria)
        {
            try
            {
                string ID = "select * from CATEGORIA where IdCategoria=@IdCategoria";
                SqlCommand command = new SqlCommand(ID, Connection);
                command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoria.IdCategoria = reader.GetString(0);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private Categoria Map(SqlDataReader reader)
        {
            Categoria categoria = new Categoria
            {
                IdCategoria = Convert.ToString(reader["IdCategoria"]),
                TipoCategoria = Convert.ToString(reader["TipoCategoria"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return categoria;
        }
    }
}
