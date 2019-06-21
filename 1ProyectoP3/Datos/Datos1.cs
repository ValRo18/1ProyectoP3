using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;



namespace Datos
{

    public class Datos1
    {
        Datos.Conexion n = new Datos.Conexion();
        private int terminal;
        public void setTerminal(int termin) {
            this.terminal = termin ;
        }
        public int getTerminal() {
            return this.terminal;
        }

        public string getTerminal(string codigoUsuario)
        {
           
            String terminal = "";
            String query = $"select id_terminal from usuarios where codigo = '{codigoUsuario}'";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                        terminal = rs.GetValue(0).ToString();
                }
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo insertar");
            }
            n.desconectar();
            return terminal;
        }

        public string CierredeCaja(string fecha, int montoCaja) {
            String mensaje = "Cierre de caja realizado con exito";
            Datos.Conexion n = new Datos.Conexion();
            String sqlCode = "insert into cierreEncomiendas(fecha,monto)" +
                "values('{0}',{1});";
            sqlCode = string.Format(sqlCode,fecha,montoCaja);
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, n.conectar());
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new Exception("No se pudo insertar", e);
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
                        setTerminal(Convert.ToInt32(rs.GetValue(4)));

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

        public string EntregarPaquete(string id)
        {
            String query = "UPDATE encomiendas SET estado='Entregado' where id_encomienda ="+id+"";
            string men = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                comm.ExecuteNonQuery();
                men = "Se a entregado el paquete con exito!";
            }
            catch (NpgsqlException x) {
                throw new Exception("No se pudo hacer la entrega",x);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            n.desconectar();
            return men;
        }
        public string MontodeCaja(string fecha)
        {
            
            String query = "select sum(total) from encomiendas where fecha ='"+fecha+"'";
            String monto = "";
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(query, n.conectar());
                NpgsqlDataReader rs = comm.ExecuteReader();
                while (rs.Read())
                {
                   monto = rs.GetString(0);
                }
                rs.Close();
            }
            catch (Exception x)
            {
                throw new Exception("No se pudo extraer", x);
            }
            n.desconectar();
            return monto;
        }

        public List<String> extraerTerminales() {
           
            List<String> terminales = new List<String>();

            String query = "select id_terinal from terminal where id_terinal <>"+getTerminal();
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
                throw new Exception("No se pudo extraer",x);
            }
            n.desconectar();
            return terminales;
        }

        public DataSet BuscarPaquete(string cedula)
        {
             System.Data.DataSet datos = new System.Data.DataSet();
            Datos.Conexion n = new Datos.Conexion();
            try
            {
                string query = "select id_encomienda,cod_encomienda, fecha, nombre, estado from encomiendas where nombre = '" + cedula + "' and id_terminal = '" + getTerminal()+ "'and estado = 'Procesando'";
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, n.conectar());
                add.Fill(datos);
                return datos;
            }
            catch (Exception e)
            {
            }
            n.desconectar();
            return datos;
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
                throw new Exception("No se pudo insertar",e);
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
