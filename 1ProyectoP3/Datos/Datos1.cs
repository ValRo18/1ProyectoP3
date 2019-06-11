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
            Datos.Conexion n = new Datos.Conexion();
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
                throw new Exception("No se pudo insertar");
            }
            n.desconectar();
            return codigoUsuario;
        }

        public void RegistarUsu(string codigoN, string nombreN, string contra)
        {
            Datos.Conexion n = new Datos.Conexion();
            String sqlCode = "INSERT INTO usuarios (nombre,codigo,contra,tipo)" + " VALUES('{0}','{1}','{2}',{3});";
            sqlCode = string.Format(sqlCode, codigoN, nombreN, contra,"false");
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, n.conectar());
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new Exception("No se pudo insertar");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                n.desconectar();
            }
        }

    }

}
