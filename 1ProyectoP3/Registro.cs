﻿using System;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su codigo consiste en Tres letras especificas y los últimos tres dígitos de la cédula\nAdministradores de Terminal = ADT\nTiqueteros(as) = TIQ\nEncomiendas = ENC\nAsistentes Administrativos = ASI");
        }
    }
}
