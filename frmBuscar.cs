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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsClientes cliente = new clsClientes();

            cliente.Eliminar(Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("El cliente ha sido eliminado correctamente.", "Eliminación de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsClientes cliente = new clsClientes();

            Int32 codigo = Convert.ToInt32(txtCodigo.Text);
            cliente.Buscar(codigo);

            if (cliente.idCliente == 0)
            {
                MessageBox.Show("No se encontró el cliente con el código ingresado.", "Búsqueda de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblNom.Text = cliente.nombre;
                lblDeu.Text = cliente.TotalDeuda.ToString();
                txtLim.Text = cliente.limite.ToString();
            }
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            txtLim.ReadOnly = false;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsClientes cliente = new clsClientes();
            cliente.limite = Convert.ToDecimal(txtLim.Text);
            cliente.Modificar(Convert.ToInt32(txtCodigo.Text));
            btnGuardar.Enabled = false;

            MessageBox.Show("El límite de crédito del cliente ha sido modificado correctamente.", "Modificación de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
