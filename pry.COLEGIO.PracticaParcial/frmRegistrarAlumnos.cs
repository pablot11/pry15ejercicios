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
    public partial class frmRegistrarAlumnos : Form
    {
        Alumnos clsAlumnos = new Alumnos();
        clsBarrios clsBarrios = new clsBarrios();
        public frmRegistrarAlumnos()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
           try
            {

                clsAlumnos = new Alumnos();
                clsAlumnos.Nombre = txtNombre.Text;
                clsAlumnos.Documento = Convert.ToInt32(txtDNI.Text);
                if (btnFemenino.Checked == true)
                {
                    clsAlumnos.Sexo = "F";
                }
                else
                {
                    clsAlumnos.Sexo = "M";
                }
                clsAlumnos.Foto = txtFoto.Text;
                clsAlumnos.Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
                clsAlumnos.RegistrarAlumnos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
           
        }

        private void frmRegistrarAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                //Mostrar los datos de barrio en la lista desplegable 
                clsBarrios = new clsBarrios();
                lstBarrio.DisplayMember = "nombre";
                lstBarrio.ValueMember = "barrio";
                lstBarrio.DataSource = clsBarrios.GetAll();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error con la base de datos");
                this.Close();
            }
        }
    }
}
