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
    public partial class frmQueFrutaLeGustanAUnAlumno : Form
    {
        FrutasQueGustanDni objFrutaQueGustan;
        public frmQueFrutaLeGustanAUnAlumno()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQueFrutaLeGustanAUnAlumno_Load(object sender, EventArgs e)
        {
            Alumnos objAlumno = new Alumnos();
            lstDniAlumno.DataSource = objAlumno.getAll();
            lstDniAlumno.DisplayMember = "dni";
            lstDniAlumno.ValueMember = "dni";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int varDni = Convert.ToInt32(lstDniAlumno.SelectedValue);
                objFrutaQueGustan = new FrutasQueGustanDni();
                dgvFrutas.Rows.Clear();
                objFrutaQueGustan.BuscarFrutaQueLeGustaAUnAlumno(varDni, dgvFrutas);
                if (objFrutaQueGustan.NombreFruta is null)
                {
                    MessageBox.Show("El alumno en la base de datos no tiene cargada ninguna fruta");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
      
        }
    }
}
