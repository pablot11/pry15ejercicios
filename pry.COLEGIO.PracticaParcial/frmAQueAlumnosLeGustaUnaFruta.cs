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
    public partial class frmAQueAlumnosLeGustaUnaFruta : Form
    {
        clsFrutas objFruta;

        FrutasQueGustanDni objFrutasQueGustan;

        public frmAQueAlumnosLeGustaUnaFruta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }

        private void frmAQueAlumnosLeGustaUnaFruta_Load(object sender, EventArgs e)
        {
            try
            {
                objFruta = new clsFrutas();
                lstFrutas.ValueMember = "fruta";
                lstFrutas.DisplayMember = "nombre";
                lstFrutas.DataSource = objFruta.getAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int varIdFruta = Convert.ToInt32(lstFrutas.SelectedValue);
                objFrutasQueGustan = new FrutasQueGustanDni();
                dgvAlumnos.Rows.Clear();
                objFrutasQueGustan.BuscarAQuienLeGustaLaFruta(varIdFruta, dgvAlumnos);
                if (objFrutasQueGustan.Bandera == false)
                {
                    MessageBox.Show("No hay ningun alumno cargado con esa fruta");
                }
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
