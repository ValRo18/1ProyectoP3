using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{

    public class Datos1
    {
      
    public void ValidarIngresoD(string cod, string con)
        {  
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from usuarios where codigo = '" + cod + "' and contra = '" + con + "' ");
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.Write("{0}\n", dr[0]);
                }
            }
        }
    }

}
