using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Input;

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
        
        public List<String> extraerTerminales() {
            Datos.Conexion n = new Datos.Conexion();
            List<String> terminales = new List<String>();

            String query = "select id_terinal from terminal";
            String nombre = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    nombre = rs.GetString(0);
                    terminales.Add(nombre);
                    
                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer");
            }
            n.desconectar();
            return terminales;
        }

        public List<string> BuscarPaquete(string cedula, string terminal)
        {
            Datos.Conexion n = new Datos.Conexion();
            List<String> encomienda = new List<String>();

            String query = "select cod_encomienda,fecha,nombre,estado from encomiendas where nombre ='" +cedula+"' and id_terminal ='"+terminal+"'";
            String tem = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    tem = rs.GetString(0);
                    encomienda.Add(tem);

                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer");
            }
            n.desconectar();
            return encomienda;
        }
        public string enviarEncomienda(string codEnc, string dirigido, double pagar, string terminal, string unidad, string fecha)
        {
            String mensaje = "Encomienda Enviada";
            String estado = "Procesando";
            Datos.Conexion n = new Datos.Conexion();
            String sqlCode = "insert into encomiendas(cod_encomienda,fecha,nombre,id_terminal,id_unidades,total,estado)" +
                "values('{0}','{1}','{2}',{3},{4},{5},'{6}');";
            sqlCode = string.Format(sqlCode, codEnc, fecha, dirigido, terminal, unidad, pagar, estado);

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
            return mensaje;
        }

        public List<String> extraerUnidades()
        {
            Datos.Conexion n = new Datos.Conexion();
            List<String> unidades = new List<String>();

            String query = "select id_unidades from unidades";
            int id;
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                    id = rs.GetInt16(0);
                    unidades.Add(Convert.ToString(id));

                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer");
            }
            n.desconectar();
            return unidades;
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
