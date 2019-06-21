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
        String cedula = "";
        string codigoUsuario;
        public EnvioYRePaquetes(string codigoUsuario)
        {
            InitializeComponent();
            this.codigoUsuario = codigoUsuario;
            log.setTerminal(codigoUsuario);
            codTerminal.DataSource = log.extraerTerminales();
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
        private void Button3_Click(object sender, EventArgs e)
        {
            cedula = numCedula.Text;
            DataSet data = log.buscarPaquete(cedula);
            tabla.AutoGenerateColumns = true;
            tabla.DataSource = data.Tables[0];
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            string id = tabla.SelectedRows[0].Cells[0].EditedFormattedValue.ToString();
            string mensaje = log.EntregarPaquete(id);
            MessageBox.Show(mensaje);
            numCedula.Clear();
        }

    }
}
