using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{
    public class Class1
    {
        public static void conetion() {
         NpgsqlConnection conexion = new NpgsqlConnection();
            try
            {
                conexion.ConnectionString = "Username =postgres ;Password = 181920; Host =127.0.0.1; Port = 5433; Database = Proyecto1";
                conexion.Open();
               Console.WriteLine("Se conecto");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

        }
    }
}
