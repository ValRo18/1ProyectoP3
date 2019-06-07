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

        public void ValidarIngreso(string cod, string con)
        {
            da.ValidarIngresoD(cod, con);
        }
    }
}
