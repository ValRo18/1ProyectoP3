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
    public partial class EnvioYRePaquetes : Form
    {
        Logica1 log = new Logica1();
        public EnvioYRePaquetes()
        {
            InitializeComponent();
            codTerminal.DataSource = log.extraerTermiales();
            codUnidad.DataSource = log.extraerUnidades();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string codEnc = codEnco.Text;
            string diri = dirigida.Text;
            double pagar = Convert.ToDouble(pago.Text);
            int indice = codTerminal.SelectedIndex; 
            string terminal = codTerminal.Items[indice].ToString();
            int indice2 = codUnidad.SelectedIndex;
            string unidad = codUnidad.Items[indice2].ToString();
            string mensaje = log.insertarEncomienda(codEnc, diri, pagar, terminal, unidad);
            MessageBox.Show(mensaje);
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String cedula = numCedula.Text;
            log.buscarPaquete(cedula);
        }

        private void NumCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
