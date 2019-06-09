using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
     
    public class Logica1
    {
        Datos1 da = new Datos1();

        public String ValidarIngreso(string cod, string con)
        {
            String codigo = "";
            if(da.ValidarIngresoD(cod, con)!="")
            {
                codigo = da.ValidarIngresoD(cod, con);
                String[] c = new string[2];
                c = codigo.Split('-');
                codigo = c[0];
            }
            return codigo;
        }
    }
}
