using System;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Logica
{

    public class Logica1
    {
       
        
        Datos1 da = new Datos1();

        /// <summary>
        /// divide the code to then validate
        /// </summary>
        /// <param name="cod"></param> the cod
        /// <param name="con"></param> the password
        /// <returns></returns> the cod
        public String ValidarIngreso(string cod, string con)
        {
            String codigo = "";
            if (da.ValidarIngresoD(cod, con) != "")
            {
                codigo = da.ValidarIngresoD(cod, con);
                String[] c = new string[2];
                c = codigo.Split('-');
                codigo = c[0];
            }
            return codigo;
        }

        /// <summary>
        /// send to extract the terminal
        /// </summary>
        /// <param name="codigoUsuario"></param> the user cod
        public void setTerminal(string codigoUsuario)
        {
            da.setTerminal(Convert.ToInt32(da.getTerminal(codigoUsuario)));
        }

        /// <summary>
        /// send to extract the amount of the box
        /// </summary>
        /// <returns></returns> the amount
        public string MontoCaja()
        {
            string monto = da.MontodeCaja(getDate());
            return monto;
        }

        public void RegistarU(string codigoN, string nombreN, string contra)
        {
            da.RegistarUsu(codigoN, nombreN, contra);
        }

        /// <summary>
        /// send to  create the box closing 
        /// </summary>
        /// <param name="montoCaja"></param> the amount
        /// <returns></returns> it was done or not
        public string cierreDeCaja(int montoCaja)
        {
            return da.CierredeCaja(getDate(), montoCaja);
        }

        /// <summary>
        /// extract the system date
        /// </summary>
        /// <returns></returns> the date
        public string getDate()
        {
            String fecha = "";
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
            return fecha;
        }

        /// <summary>
        /// send to extract the terminals
        /// </summary>
        /// <returns></returns> the terminals
        public List<String> extraerTerminales() {
            List<String> terminales = da.extraerTerminales();
            return terminales;
        }
        /// <summary>
        /// send to extract the units
        /// </summary>
        /// <returns></returns> the units
        public List<String> extraerUnidades()
        {
            List<String> unidades= da.extraerUnidades();
            return unidades;
        }

        /// <summary>
        /// send to send an order
        /// </summary>
        /// <param name="codEnc"></param> the cod
        /// <param name="dirigido"></param> the person 
        /// <param name="pagar"></param> the amount
        /// <param name="terminal"></param> the id terminal
        /// <param name="unidad"></param> the  id units 
        /// <returns></returns> if send or not
        public string insertarEncomienda(string codEnc, string dirigido, double pagar, string terminal, string unidad)
        {
            string mensaje = da.enviarEncomienda(codEnc, dirigido, pagar, terminal, unidad, getDate());
            return mensaje;
        }

        /// <summary>
        /// send to search the package
        /// </summary>
        /// <param name="cedula"></param> the person id 
        /// <returns></returns> the package
       public DataSet buscarPaquete(string cedula)
        {
            return da.BuscarPaquete(cedula);
        }

        /// <summary>
        /// Send to change the package status
        /// </summary>
        /// <param name="id"></param> the pakage id
        /// <returns></returns> if channg the status or not
        public string EntregarPaquete(string id)
        {
            return da.EntregarPaquete(id);
        }
    }
}
