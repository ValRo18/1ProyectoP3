using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class LogicaReportes
    {
        DatosReportes re = new DatosReportes();
        public void Reporte1()
        {
            re.Reporte1();
        }

        public string Reporte4Mas()
        {
            return re.Reporte4mas();
        }

        public string Reporte4menos()
        {
             return re.Reporte4menos();
        }
    }
}
