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
    public partial class frmAgregarBarrio : Form
    {
        clsBarrios clsBarrio = new clsBarrios();
        public frmAgregarBarrio()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            clsBarrio = new clsBarrios();
            clsBarrio.Barrio = Convert.ToInt32(txtIdBarrio.Text);
            clsBarrio.Nombre = txtNombreBarrio.Text;
            clsBarrio.RegistrarBarrio();
            if (clsBarrio.Barrio == 0)
            {
                MessageBox.Show("El ID del barrio ya existe", "ERROR");
            }
            else
            {
                MessageBox.Show("Barrio cargado con éxito");
                txtNombreBarrio.Text = "";
                txtIdBarrio.Text = "";
            }

        }
    }
}
