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
    public partial class frmVerTodasLasFrutasYContador : Form
    {
        clsFrutas objFrutas;
        FrutasQueGustanDni objFrutasQueGustan;
        public frmVerTodasLasFrutasYContador()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objFrutas = new clsFrutas();
            objFrutas.MostrarGrillaNombreFruta(dgvConsulta);



        }
    }
}
