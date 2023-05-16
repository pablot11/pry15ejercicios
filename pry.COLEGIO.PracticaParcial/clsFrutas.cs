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
    internal class clsFrutas
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private int varIdFruta = 0;
        private string varNombreFruta = "";
        FrutasQueGustanDni objFrutaQueGustan;
        private int contador;
        public string NombreFrutaa
        {
            get { return varNombreFruta; }
            set { varNombreFruta = value; }
        }
        public int IdFruta
        {
            get { return varIdFruta; }
            set { varIdFruta = value; }
        }
    

        public clsFrutas()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["fruta"];
            tabla.PrimaryKey = dc;
            objFrutaQueGustan = new FrutasQueGustanDni();
        }
        public void Agregar()
        {
            DataRow fila = tabla.NewRow();
            fila["fruta"] = varIdFruta;
            fila["nombre"] = varNombreFruta;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }
        public DataTable getAll()
        {
            return tabla;

        }
       public string NombreFrutaBuscar(int idfruta)
       {
            DataRow filabusca = tabla.Rows.Find(idfruta);
            varNombreFruta = filabusca["nombre"].ToString();     
            return NombreFrutaa;
       }
        

        public void MostrarGrillaNombreFruta(DataGridView dataGridView)
        {
            foreach (DataRow dr in tabla.Rows)
            {
                contador = 0;
                foreach (DataRow dr2 in objFrutaQueGustan.DataTablaPublic.Rows)
                {
                    if (Convert.ToInt32(dr[0]) == Convert.ToInt32(dr2[1]))
                    {
                        contador = contador + 1;
                    }
                }               
                dataGridView.Rows.Add(dr["nombre"], contador);
          
            }
            

        }












    }
}
