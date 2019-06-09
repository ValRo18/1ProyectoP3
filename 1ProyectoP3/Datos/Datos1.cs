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
        Datos.Conexion n = new Datos.Conexion();


        public String ValidarIngresoD(string codigo, string contra)
        {
            String codigoUsuario = "";
            String query = "select * from usuarios";
            try
            { 
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    if (rs.GetValue(1).ToString() == codigo && rs.GetValue(2).ToString() == contra)
                    {
                        codigoUsuario = rs.GetValue(1).ToString();
                        break;
                    }
                }
            }
            catch (Exception x)
            {
                
            }
            n.desconectar();
            return codigoUsuario;
        }
    }

}
