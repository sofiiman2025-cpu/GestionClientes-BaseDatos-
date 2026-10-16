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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            clsCiudad cls = new clsCiudad();
            cls.Listar(cmbCiudad);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsClientes clase = new clsClientes();
            clase.nombre = txtNombre.Text;
            clase.limite = Convert.ToDecimal(txtLimite.Text);
            clase.idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            clase.Agregar();

            MessageBox.Show("Cliente Agregado Correctamente");

            txtNombre.Text = "";
            txtLimite.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }
    }
}
