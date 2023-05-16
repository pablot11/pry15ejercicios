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
    public partial class frmFrutasGustanAlumnos : Form
    {
        Alumnos objAlumno;
        FrutasQueGustanDni objFrutasQueGustan;
        public frmFrutasGustanAlumnos()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objFrutasQueGustan = new FrutasQueGustanDni();
                objFrutasQueGustan.Dni = Convert.ToInt32(lstDniAlumno.SelectedValue);
                objFrutasQueGustan.Frutaa = Convert.ToInt32(lstFrutas.SelectedValue);
                objFrutasQueGustan.Agregar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }

        private void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFrutasGustanAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                
                objAlumno = new Alumnos();
                lstDniAlumno.DataSource = objAlumno.getAll();
                lstDniAlumno.DisplayMember = "dni";
                lstDniAlumno.ValueMember = "dni";
                clsFrutas objFrutas = new clsFrutas();
                lstFrutas.DataSource = objFrutas.getAll();
                lstFrutas.DisplayMember = "nombre";
                lstFrutas.ValueMember = "fruta";

            }
            catch (Exception)
            {

                MessageBox.Show("Error con la base de datos");
                this.Close();
            }
     

        }

        private void lstDniAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
