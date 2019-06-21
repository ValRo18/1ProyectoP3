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
        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            String cod = codigo.Text;
            String con = contrasena.Text;
            string codigoUsuario = log.ValidarIngreso(cod, con);
            if (codigoUsuario == "ADT")
            {
                Administrador admi = new Administrador(cod);
                this.Hide();
                admi.Show();
            }
            else if (codigoUsuario == "TIQ") {
                Tiquetes ti = new Tiquetes();
            }
            else if (codigoUsuario == "ENC") {
                Encomiendas en = new Encomiendas(cod);
                this.Hide();
                en.Show();
            }
            else if (log.ValidarIngreso(cod, con) == "ASI") {
                AsitenteAdministrativo asd = new AsitenteAdministrativo();
            }
            else
            {
                MessageBox.Show("No registrado");
            }
            

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
