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
        public int montoCaja;
        public int montoSis;
        public CierreCajaEncomienda()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int caja = Convert.ToInt32(textBox1.Text);
            montoCaja = caja - 5000;
            montoSis =Convert.ToInt32(log.MontoCaja());
            textBox2.Text = Convert.ToString(montoSis);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (montoCaja == montoSis) {

                string mensaje =log.cierreDeCaja(montoCaja);
                MessageBox.Show(mensaje);
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Los montos no coinciden, se requiere hacer arqueo de caja!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
