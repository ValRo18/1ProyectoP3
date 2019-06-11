using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{
    public class Conexion
    {
        public NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;User Id=postgres;Password=123;Database=Proyecto1");
        public NpgsqlConnection conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("No se conecto con la base");
            }
            return conexion;
        }
        public void desconectar()
        {
            conexion.Close();
        }

    }
}