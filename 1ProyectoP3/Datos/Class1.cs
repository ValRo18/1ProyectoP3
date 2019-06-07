using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Class1
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        public void conexion_bd()
        {

            String cadena = "Server = 127.0.0.1; Port = 5432; Database = Proyecto1; User Id=postgre; Password = 12345 ";
            conexion.ConnectionString = cadena;
            try
            {
                conexion.Open();
            }
            catch
            {
                conexion.Close();
            }
        }
    }
}
