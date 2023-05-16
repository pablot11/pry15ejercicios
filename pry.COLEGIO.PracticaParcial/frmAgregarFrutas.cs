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
    public partial class frmAgregarFrutas : Form
    {

        clsFrutas objFruta;

        public frmAgregarFrutas()
        {
            InitializeComponent();
        }

        private void frmAgregarFrutas_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objFruta = new clsFrutas();
                objFruta.IdFruta = Convert.ToInt32(txtIdFruta.Text);
                objFruta.NombreFrutaa = txtFruta.Text;
                objFruta.Agregar();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        
        }
    }
}
