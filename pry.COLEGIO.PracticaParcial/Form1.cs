using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.COLEGIO.PracticaParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void aQueAlumnosLeGustaUnaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAQueAlumnosLeGustaUnaFruta obj = new frmAQueAlumnosLeGustaUnaFruta();
            obj.ShowDialog();
        }

        private void verTodasLasFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarAlumnosPorParteDeSuNombewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarBarrio frmAgregarBarrio = new frmAgregarBarrio(); 
            frmAgregarBarrio.ShowDialog();
        }

        private void nuevaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarFrutas frmAgregarFrutas = new frmAgregarFrutas();
            frmAgregarFrutas.ShowDialog();
        }

        private void queFrutasLeGustaAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasGustanAlumnos frmFrutas = new frmFrutasGustanAlumnos();
            frmFrutas.ShowDialog();
        }

        private void consultarAlumnoPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAlumno objConsultarAlumno = new frmConsultarAlumno();
            objConsultarAlumno.ShowDialog();
        }

        private void consultarQueFrutasLeGustanAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueFrutaLeGustanAUnAlumno obj = new frmQueFrutaLeGustanAUnAlumno();
            obj.ShowDialog();
        }

        private void cantidadTotalDeAlumnosPorFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarFrutas frmAgregarFrutas = new frmAgregarFrutas();
            frmAgregarFrutas.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegistrarAlumnos frmRegistrarAlumnos = new frmRegistrarAlumnos();
            frmRegistrarAlumnos.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAgregarBarrio frmAgregarBarrio = new frmAgregarBarrio();
            frmAgregarBarrio.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmFrutasGustanAlumnos frmFrutas = new frmFrutasGustanAlumnos();
            frmFrutas.ShowDialog();
        }

        private void coToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTodasLasFrutasYContador obj = new frmVerTodasLasFrutasYContador();
            obj.ShowDialog();
        }

        private void listarTodasLasFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTodasLasFrutas obj = new frmListarTodasLasFrutas();
            obj.ShowDialog();
        }

        private void arbolitoFrutasAlumnoTreeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreeViewFrutasQueLeGustanACadaAlumno obj = new frmTreeViewFrutasQueLeGustanACadaAlumno();
            obj.ShowDialog();
        }

        private void buscarPorParteDeNonbreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPorParteDeNombre obj = new frmBuscarPorParteDeNombre();
            obj.ShowDialog();
        }
    }
}
