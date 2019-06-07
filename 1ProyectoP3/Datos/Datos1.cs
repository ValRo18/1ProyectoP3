using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;S

namespace Datos
{

    public class Datos1
    {
        Conexion co = new Conexion();


        public void ValidarIngresoD(string cod, string con)
        {
            NpgsqlConnection conn = co.getconetion();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from usuarios where codigo = '" + cod + "' and contra = '" + con + "' ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                Console.Write("{0}\n", dr[0]);
    
        }

        }
}
