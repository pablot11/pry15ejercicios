using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pry.COLEGIO.PracticaParcial
{
    internal class FrutasQueGustanDni
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private int varDni;
        private int varIdFruta;
        private string varNombreFruta;
        private string varNombreAlumno;
        private int varContadorAlumnos = 0;
        private Boolean bandera = false;
        public int Dni
        {
            get { return varDni; }
            set { varDni = value; }
        }
        public int Frutaa
        {
            get { return varIdFruta; }
            set { varIdFruta = value; }
        }
        public string NombreFruta
        {
            get { return varNombreFruta; }
            set { varNombreFruta = value; }
        }
        public string NombreAlumno
        {
            get { return varNombreAlumno; }
            set { varNombreAlumno= value; }
        }
        public int ContadorAlumnos
        {
            get { return varContadorAlumnos; }
            set { varContadorAlumnos = value; }
        }
        public Boolean Bandera
        {
            get { return bandera; }
            set { bandera= value; }
        }

        public DataTable DataTablaPublic
        {
            get { return tabla; }
            set { tabla = value; }
        }



        public FrutasQueGustanDni()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "LeGustan";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["dni"];
            dc[1] = tabla.Columns["fruta"];
            tabla.PrimaryKey = dc;

        }
        public void Agregar()
        {
            DataRow fila = tabla.NewRow();
            fila["dni"] = varDni;
            fila["fruta"] = varIdFruta;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);



        }
        public void BuscarFrutaQueLeGustaAUnAlumno(int dni, DataGridView dgvFruta)
        {
            foreach (DataRow buscarfila in tabla.Rows)
            {
                if (dni == Convert.ToInt32(buscarfila["dni"]))
                {
                    varIdFruta = Convert.ToInt32(buscarfila["fruta"]);
                    clsFrutas objFrutas = new clsFrutas();
                    varNombreFruta = objFrutas.NombreFrutaBuscar(varIdFruta);
                    if (varNombreFruta != "")
                    {
                        dgvFruta.Rows.Add(varNombreFruta);
                    }                

                }

            }
         

        }
        public void BuscarAQuienLeGustaLaFruta(int idfruta, DataGridView dgvMostrar)
        {
            foreach (DataRow filabuscar in tabla.Rows)
            {
                if (idfruta == Convert.ToInt32(filabuscar["fruta"]))
                {
                    bandera = true;
                    varDni = Convert.ToInt32(filabuscar["dni"]);
                    Alumnos objAlumnos = new Alumnos();
                    varNombreAlumno = objAlumnos.BuscarNombreAlumnoPorDni(varDni);
                    if (varNombreAlumno != null)
                    {
                        dgvMostrar.Rows.Add(varNombreAlumno);
                    }
                }         

            }




        }
        //No se si esta bien

        public void ContadorDeAlumnosQueLeGustanUnaFruta(int idfruta)
        {
            foreach (DataRow filabusc in tabla.Rows)
            {
                if (idfruta == Convert.ToInt32(filabusc["fruta"]))
                {
                    varContadorAlumnos = varContadorAlumnos + 1;

                }

            }
        }

        public void ContadorDeFrutas()
        {
          
            





        }
        public DataTable getAll()
        {

            return tabla;
        }


    }
}
