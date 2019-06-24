using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{
    public class DatosReportes
    {
        public void Reporte1()
        {
        }

        public string Reporte4mas()
        {
            Datos.Conexion n = new Datos.Conexion();
            List<String> terminales = new List<String>(2);
            String query = "";
            string mayor = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    string  tem = rs.GetString(0);
                    
                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer", x);
            }
            n.desconectar();
            return mayor;
        }

        public string Reporte4menos()
        {
            Datos.Conexion n = new Datos.Conexion();
            List<String> terminales = new List<String>(2);
            String query = "";
            string menos = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    string tem = rs.GetString(0);

                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer", x);
            }
            n.desconectar();
            return menos;
        }
    }
}
            
