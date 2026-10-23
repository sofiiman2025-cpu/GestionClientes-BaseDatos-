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
            clsClientes x = new clsClientes();

            Int32 cliente = Convert.ToInt32(txtCodigo.Text);
            x.Buscar(cliente);

            if (x.idCliente != 0)
            {
                lblNombre.Text = x.nombre;
                lblDeuda.Text = x.TotalDeuda.ToString();
                lblLim.Text = x.limite.ToString();
            }
            else
            {
                lblNombre.Text = "";
                lblDeuda.Text = "";
                lblLim.Text = "";
                MessageBox.Show("Cliente no existente");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsClientes cliente = new clsClientes();
            cliente.limite = Convert.ToDecimal(lblLim.Text);
            cliente.Modificar(Convert.ToInt32(txtCodigo.Text));
            btnGuardar.Enabled = false;

            MessageBox.Show("El límite de crédito del cliente ha sido modificado correctamente.", "Modificación de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
