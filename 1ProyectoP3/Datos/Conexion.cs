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
        public NpgsqlConnection getconetion()
        {

            NpgsqlConnection conexion = new NpgsqlConnection();
            if (conexion == null)
            {
                try
                {
                    conexion.ConnectionString = "Username = postgres ;Password = 181920; Host =127.0.0.1; Port = 5433; Database = Proyecto1";
                    conexion.Open();
                    Console.WriteLine("Se conecto");
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            return conexion;
        }
    }
}
