using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Drawing.Text;

namespace pry.COLEGIO.PracticaParcial
{
    internal class Alumnos
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        DataSet objds = new DataSet();
        private Int32 DNI;
        private string NOMBRE;
        private string SEXO;
        private string FOTO;
        private Int32 BARRIO;

        public Int32 Documento
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public string Nombre
        {
            get { return NOMBRE; }  
            set { NOMBRE = value; }
        }

        public string Sexo
        {
            get { return SEXO; }
            set { SEXO = value; }
        }

        public string Foto
        {
            get { return FOTO; }
            set { FOTO = value; }
        }

        public Int32 Barrio
        {
            get { return BARRIO; }
            set { BARRIO = value; }
        } 

        public Alumnos()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb");

            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["dni"];
            tabla.PrimaryKey = dc;

        }

        public DataTable getAll()
        {
            return tabla;
        }

        public void RegistrarAlumnos()
        {
            //Obtener la referencia a la tabla 
            //DataTable dt = objds.Tables["Alumnos"];
            //Creamos el nuevo DataRow con la estructura de campos de la tabla Alumnos
            DataRow BuscarFila = tabla.Rows.Find(DNI);
            //Si la fila que busca es nula, creamos una nueva fila e insertamos los datos
            if (BuscarFila is null)
            {
                DataRow Fila = tabla.NewRow();
                Fila["dni"] = DNI;
                Fila["nombre"] = NOMBRE;
                Fila["sexo"] = SEXO;
                Fila["foto"] = FOTO;
                Fila["barrio"] = BARRIO;
                //Agregamos los nuevos datos a la fila
                tabla.Rows.Add(Fila);
                //Actualizar la tabla y guardar los datos ingresados
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                //Actualiza la tabla
                adaptador.Update(tabla);

            }
            
            
        }
        public void Buscar(int dni)
        {
            DataRow filabuscar = tabla.Rows.Find(dni);
            if (filabuscar != null)
            {
                DNI = dni;
                NOMBRE = Convert.ToString(filabuscar["nombre"]);
                if (filabuscar["sexo"].ToString() == "F")
                {
                    SEXO = "Femenino";
                }
                else
                {
                    SEXO = "Masculino";
                }        
                BARRIO = Convert.ToInt32(filabuscar["barrio"]);
                FOTO = filabuscar["foto"].ToString();
            }
            else
            {
                DNI = 0;
                NOMBRE = "";
                SEXO = "";
                BARRIO = 0;
                FOTO = "";
            }
        
        }

        public string BuscarNombreAlumnoPorDni(int dni)
        {
            DataRow filabusca = tabla.Rows.Find(dni);
            NOMBRE = filabusca["nombre"].ToString();
            return NOMBRE;
        }

        public void Eliminar()
        {
            


        }



    }
}
