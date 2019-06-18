using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ProyectoP3
{
    public partial class Encomiendas : Form
    {
        public Encomiendas()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EnvioYRePaquetes en = new EnvioYRePaquetes();
            en.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CierreCajaEncomienda ci = new CierreCajaEncomienda();
            ci.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
