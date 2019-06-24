using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Logica;

namespace _1ProyectoP3
{
    public partial class Reportes : Form
    {
        LogicaReportes log = new LogicaReportes();
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            string[] a = { "A", "B", "C" };
            int[] re = { 2, 50, 20 };

            chart1.Titles.Add("Prueba");
            for (int i = 0; i < a.Length; i++)
            {
                Series ant = chart1.Series.Add(a[i]);
                   ant.Label = re[i].ToString();
                ant.Points.Add(re[i]);
            } 
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            log.Reporte1();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string mas = log.Reporte4Mas();
            string menos = log.Reporte4menos();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}
