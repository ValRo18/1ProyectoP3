using System;
using System.Windows.Forms;
using Logica;

namespace _1ProyectoP3
{
    public partial class Login : Form
    {
        Logica1 log = new Logica1();
     
        public Login()
        {
            InitializeComponent();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String cod = codigo.Text;
            String con = contrasena.Text;
            log.ValidarIngreso(cod, con);
            
        }
    }
}
