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
    public partial class frmConsultarAlumno : Form
    {
        public frmConsultarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumnos objAlumno = new Alumnos();
                int dni = Convert.ToInt32(txtDniBuscar.Text);
                objAlumno.Buscar(dni);
                if (objAlumno.Documento != 0)
                {
                    txtNombre.Text = objAlumno.Nombre;
                    txtSexo.Text = objAlumno.Sexo;
                    picFoto.ImageLocation = "JPG/" + objAlumno.Foto;
                    txtBarrio.Text = objAlumno.Barrio.ToString();
                    
                }
                else
                {
                    MessageBox.Show("No se encontro el alumno");
                }


            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
         
            




        }
    }
}
