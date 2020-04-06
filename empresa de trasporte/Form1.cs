using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa_de_trasporte
{
    public partial class Form1 : Form
    {
        EmpresaTrasporte empresa = new EmpresaTrasporte();
        public Form1()
        {
            InitializeComponent();
            actualizarPaneles();
        }


        private void actualizarPaneles()
        {   Camion camion = empresa.darCamion1();
            lblMatricula1.Text = camion.Matricula;
            lblCapacidad1.Text = camion.Capacidad.ToString() + " kg";
            lblConsumo1.Text = camion.Consumo.ToString() + " gal/km";
            lblCargaActual1.Text = camion.CargaActual.ToString() + " kg";
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string nombreArchivo = Path.Combine(dir, @"imagenes\carga.png");
            if (camion.CargaActual > 0)
            {
               caja1.Image = Image.FromFile(nombreArchivo);
            }
            else
            {
                caja1.Image = null;
            }

            camion = empresa.darCamion2();
            lblMatricula2.Text = camion.Matricula;
            lblCapacidad2.Text = camion.Capacidad.ToString() + " kg";
            lblConsumo2.Text = camion.Consumo.ToString() + " gal/km";
            lblCargaActual2.Text = camion.CargaActual.ToString() + " kg";
            if (camion.CargaActual > 0)
            {
                caja2.Image = Image.FromFile(nombreArchivo);
            }
            else
            {
                caja2.Image = null;
            }

            camion = empresa.darCamion3();
            lblMatricula3.Text = camion.Matricula;
            lblCapacidad3.Text = camion.Capacidad.ToString() + " kg";
            lblConsumo3.Text = camion.Consumo.ToString() + " gal/km";
            lblCargaActual3.Text = camion.CargaActual.ToString() + " kg";
            if (camion.CargaActual > 0)
            {
                caja3.Image = Image.FromFile(nombreArchivo);
            }
            else
            {
                caja3.Image = null;
            }


                camion = empresa.darCamion4();
            lblMatricula4.Text = camion.Matricula;
            lblCapacidad4.Text = camion.Capacidad.ToString() + " kg";
            lblConsumo4.Text = camion.Consumo.ToString() + " gal/km";
            lblCargaActual4.Text = camion.CargaActual.ToString() + " kg";
            if (camion.CargaActual > 0)
            {
                caja4.Image = Image.FromFile(nombreArchivo);
            }
            else
            {
                caja4.Image = null;
                
            }
            lblCargaTotal.Text = empresa.darCargaActualTotal().ToString();
            lblCargaPromedio.Text = empresa.calcularCargaPromedio().ToString();

        }

        private void cargar(string matricula)
        {
            string texto = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresala cantidad de la carga",
                "Cargar",
                "0");
            int carga = int.Parse(texto);
            if(!empresa.cargarCamion(matricula, carga))
            {
                MessageBox.Show("la carga sobrepasa la capacidad del camion");
            }
            {
                actualizarPaneles();
            }
            
        }

        private void descargar(string matricula)
        {
            empresa.descargarCamion(matricula);
            actualizarPaneles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            descargar(lblMatricula2.Text);
        }

        private void btnCargar1_Click(object sender, EventArgs e)
        {
            cargar(lblMatricula1.Text);
        }

        private void btnCargar2_Click(object sender, EventArgs e)
        {
            cargar(lblMatricula2.Text);
        }

        private void btnCargar3_Click(object sender, EventArgs e)
        {
            cargar(lblMatricula3.Text);
        }

        private void btnCargar4_Click(object sender, EventArgs e)
        {
            cargar(lblMatricula4.Text);
        }

        private void btnDescargar1_Click(object sender, EventArgs e)
        {
            descargar(lblMatricula1.Text);
        }

        private void btnDescargar3_Click(object sender, EventArgs e)
        {
            descargar(lblMatricula3.Text);
        }

        private void btnDescargar4_Click(object sender, EventArgs e)
        {
            descargar(lblMatricula4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la capacidad total es: " + empresa.darCapacidadTotal().ToString());
            ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string texto = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresala cantidad de la carga",
                "Cargar",
                "0");
            int carga = int.Parse(texto);
            Camion mejorCamion = empresa.darMejorCamion(carga);
            MessageBox.Show("el mejor camion para trasportar la carga es "
                + mejorCamion.Matricula + " \ncon un consumo de " + mejorCamion.Consumo+ " gal/km");
        }
    }
}
