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
    public partial class frmTreeViewFrutasQueLeGustanACadaAlumno : Form
    {

        clsFrutas objFrutas;
        Alumnos objAlumno;
        FrutasQueGustanDni objQueGustanDni;
        public frmTreeViewFrutasQueLeGustanACadaAlumno()
        {
            InitializeComponent();
        }

        private void frmTreeViewFrutas_Load(object sender, EventArgs e)
        {
            objAlumno = new Alumnos();
            objFrutas = new clsFrutas();
            objQueGustanDni = new FrutasQueGustanDni();
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;

            abuelo = tvMostrar.Nodes.Add("frutas");
            DataTable dtFrutas = objFrutas.getAll();
            DataTable dtAumnos = objAlumno.getAll();
            DataTable dtLeGustan = objQueGustanDni.DataTablaPublic;
            foreach (DataRow dr in dtFrutas.Rows)
            {
                padre = abuelo.Nodes.Add(dr["nombre"].ToString());
                foreach (DataRow dralumnosquegustan in dtLeGustan.Rows)
                {
                    if (dralumnosquegustan["fruta"].ToString() == dr["fruta"].ToString())
                    {
                        foreach (DataRow drAlumnos in dtAumnos.Rows)
                        {
                            if (dralumnosquegustan["dni"].ToString() == drAlumnos["dni"].ToString())
                            {
                                hijo = padre.Nodes.Add(drAlumnos["nombre"].ToString());
                            }
                        }
                    }
                    
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void tvMostrar_AfterSelect(object sender, TreeViewEventArgs e)
        {
   
        }
    }
}
