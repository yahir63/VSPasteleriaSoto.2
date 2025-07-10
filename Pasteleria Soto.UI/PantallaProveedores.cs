using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasteleriaSoto.BLL;
using PasteleriaSoto.DAL.Entities;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaProveedores : Form
    {
        List<Proveedor> ListaProveedores = new List<Proveedor>();
        private int indice;
        RepositoryProveedor _repositoryProveedor = new RepositoryProveedor();
        public PantallaProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.NOMBREPROVEEDOR = txtNombreProveedor.Text;
            proveedor.UBICACION = txtUbicacionProveedor.Text;
            proveedor.TELEFONO = txtTelefonoProveedor.Text;

            ListaProveedores.Add(proveedor);
            dgvDatosProveedor.DataSource = null;
            dgvDatosProveedor.DataSource = ListaProveedores;
            btnRegistrarProveedor.Visible = true;

            txtNombreProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtUbicacionProveedor.Clear();

        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            _repositoryProveedor.RegistrarProveedor(ListaProveedores);
            ListaProveedores.Clear();
            dgvDatosProveedor.DataSource = null;
            dgvDatosProveedor.Rows.Clear();
        }

        private void btnVerProveedor_Click(object sender, EventArgs e)
        {
            dgvDatosProveedor.DataSource = null;
            ListaProveedores.Clear();
            ListaProveedores.AddRange(_repositoryProveedor.ObtenerListaProveedores());
            dgvDatosProveedor.DataSource = ListaProveedores;
        }

        private void dgvDatosProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            txtNombreProveedor.Text = ListaProveedores[indice].NOMBREPROVEEDOR.ToString();
            txtUbicacionProveedor.Text = ListaProveedores[indice].UBICACION.ToString();
            txtTelefonoProveedor.Text = ListaProveedores[indice].TELEFONO.ToString();

            txtNombreProveedor.Enabled = false;
            txtUbicacionProveedor.Enabled = false;
            txtTelefonoProveedor.Enabled = false;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.NOMBREPROVEEDOR = txtNombreProveedor.Text;
            proveedor.UBICACION = txtUbicacionProveedor.Text;
            proveedor.TELEFONO = txtTelefonoProveedor.Text;

            _repositoryProveedor.ActualizarProveedor(proveedor);

            dgvDatosProveedor.DataSource = null;
            ListaProveedores.Clear();
            ListaProveedores.AddRange(_repositoryProveedor.ObtenerListaProveedores());
            dgvDatosProveedor.DataSource = ListaProveedores;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Enabled = true;
            txtUbicacionProveedor.Enabled = true;
            txtTelefonoProveedor.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvDatosProveedor.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(dgvDatosProveedor.SelectedRows[0].Cells["ID_PROVEEDOR"].Value);

                    _repositoryProveedor.EliminarProveedor(idProveedor);

                    dgvDatosProveedor.DataSource = null;
                    ListaProveedores.Clear();
                    ListaProveedores.AddRange(_repositoryProveedor.ObtenerListaProveedores());
                    dgvDatosProveedor.DataSource = ListaProveedores;

                    MessageBox.Show("Proveedor eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Selecciona un proveedor antes de eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
            }
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            frmInicio frminicio = new frmInicio();
            frminicio.Show();
            this.Hide();
        }

        private void grpDatosProveedor_Enter(object sender, EventArgs e)
        {

        }
    }
}
