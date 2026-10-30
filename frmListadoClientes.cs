using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes_archivoCSV_
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.Listar(dgvGrilla);
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            
            objArchivo.Title = "Seleccionen carpeta y escriba el nombre del archivo";
            objArchivo.RestoreDirectory = true; //usa el ultimo directorio 
            objArchivo.Filter = "Archivo separado por coma. (*.csv)|*.csv| Archivo de texto (*.txt)|*.txt";
            objArchivo.ShowDialog();

            clsClientes objClientes = new clsClientes();
            objClientes.ReporteClientesCuadroDialogo(objArchivo.FileName);
            //MessageBox.Show("Reporte Generado Correctamente");
        }
    }
}
