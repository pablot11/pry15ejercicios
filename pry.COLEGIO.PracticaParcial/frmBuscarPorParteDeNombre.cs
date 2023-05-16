using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pry.COLEGIO.PracticaParcial
{
    public partial class frmBuscarPorParteDeNombre : Form
    {
        Alumnos objAlumno;
        DataTable tabla;
        public frmBuscarPorParteDeNombre()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();

            string busco = txtNombre.Text;
            string nombre = "";

            foreach (DataRow fila in tabla.Rows)
            {
                nombre = fila["nombre"].ToString();
                int posicion = nombre.IndexOf(busco);
                if (posicion > -1)
                {
                   dgvAlumnos.Rows.Add(fila["dni"].ToString(), fila["nombre"].ToString());

                }
            }
        }

        private void frmBuscarPorParteDeNombre_Load(object sender, EventArgs e)
        {
            objAlumno = new Alumnos();
            tabla = objAlumno.getAll(); 
        }
    }
}
