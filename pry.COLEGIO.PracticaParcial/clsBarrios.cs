using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;



namespace pry.COLEGIO.PracticaParcial
{
    internal class clsBarrios
    {
        private string cadena = "";
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private Int32 BARRIO;
        private string NOMBRE;

        public string Nombre
        {
            get { return NOMBRE; }
            set { NOMBRE = value; } 
        }

        public Int32 Barrio
        {
            get { return BARRIO; }
            set { BARRIO = value; }
        }
        
        public clsBarrios()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);


            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["barrio"];
            tabla.PrimaryKey = dc;
        }

        public DataTable GetAll()
        {
            return tabla;
        }

        public void RegistrarBarrio()
        {
            //DataTable dt = objds.Tables["Barrios"];
            DataRow BuscarFila = tabla.Rows.Find(BARRIO);
            DataRow Fila = tabla.NewRow();
            Fila["barrio"] = BARRIO;
            Fila["nombre"] = NOMBRE; 
            tabla.Rows.Add(Fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
             adaptador.Update(tabla);
            
        }
    }
}
