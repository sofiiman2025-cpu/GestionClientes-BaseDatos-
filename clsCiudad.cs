using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionClientes_archivoCSV_
{
    internal class clsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Ciudad";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Adaptamos los datos de toda la tabla y se los cargamos a DS
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);

                //Mostramos los datos en la grilla (cargamos la grilla)
                Grilla.DataSource = DS.Tables[0];


                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Listar(ComboBox combo) //sobrecarga de funciones (dos procedimientos que se llaman igual)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Adaptamos los datos de toda la tabla y se los cargamos a DS
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                //Mostramos los datos en la grilla (cargamos la grilla)
                combo.DataSource = DS.Tables[Tabla];
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "IdCiudad";


                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public String Buscar(Int32 idCiudad)
        {
            try
            {
                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                OleDbDataReader DR = comando.ExecuteReader();
                String Resultado = "";
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCiudad)
                        {
                            Resultado = DR.GetString(1);
                        }

                          
                    }
                }
                
                conexion.Close();

                return Resultado;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            
        }
    }
}
