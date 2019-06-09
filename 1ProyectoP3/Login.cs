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
            if(log.ValidarIngreso(cod, con) == "ADT")
            {
                Administrador admi = new Administrador();
                this.Hide();
                admi.Show();
            }
            if (log.ValidarIngreso(cod, con) == "TIQ" || log.ValidarIngreso(cod, con) == "ENC" || log.ValidarIngreso(cod, con) == "ASI")
            {
                Usuario usuario = new Usuario();
                this.Hide();
                usuario.Show();
            }
            else
            {
                MessageBox.Show("No registrado");
            }
            

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
