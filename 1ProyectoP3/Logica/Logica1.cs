using System;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Logica
{

    public class Logica1
    {
       
        
        Datos1 da = new Datos1();

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

        public string MontoCaja()
        {
            return da.MontodeCaja(getDate);
        }

        public void RegistarU(string codigoN, string nombreN, string contra)
        {
            da.RegistarUsu(codigoN, nombreN, contra);
        }
        public string getDate()
        {
            String fecha = "";
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
            return fecha;
        }

        public List<String> extraerTermiales() {
            List<String> terminales = da.extraerTerminales();
            return terminales;
        }
        public List<String> extraerUnidades()
        {
            List<String> unidades= da.extraerUnidades();
            return unidades;
        }

        public string insertarEncomienda(string codEnc, string dirigido, double pagar, string terminal, string unidad)
        {
            string mensaje = da.enviarEncomienda(codEnc, dirigido, pagar, terminal, unidad, getDate());
            return mensaje;
        }

        public DataSet buscarPaquete(string cedula)
        {
            return da.BuscarPaquete(cedula);
        }

    }
}
