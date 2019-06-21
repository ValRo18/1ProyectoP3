using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace _1ProyectoP3
{
    public partial class CierreCajaEncomienda : Form
    {
        Logica1 log = new Logica1();
        public CierreCajaEncomienda()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string monto = log.MontoCaja();
            textBox2.Text = monto;
        }
    }
}
