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
    

    public partial class frmListarTodasLasFrutas : Form
    {
        clsFrutas objFruta;
        
        public frmListarTodasLasFrutas()
        {
            InitializeComponent();
        }

        private void brnListar_Click(object sender, EventArgs e)
        {
            dgvFrutas.DataSource = objFruta.getAll();
        }

        private void frmListarTodasLasFrutas_Load(object sender, EventArgs e)
        {
            objFruta = new clsFrutas();



        }
    }
}
