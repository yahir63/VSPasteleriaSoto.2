 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PantallasProyecto.DAL;
using PasteleriaSoto.BLL;
using Pedido.DAL;
using Clientes.DAL;
namespace Pasteleria_Soto.UI
{
    public partial class PantallaRegistro : Form
    {
        List<Cliente> ListaCLientesTemp = new List<Cliente>();

        RegistroRepositoryCliente _registroRepositorio = new RegistroRepositoryCliente();

        private int indice;



        public PantallaRegistro()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio volver = new frmInicio();
            volver.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {



        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NOMBRECLIENTE = txtNombre.Text;
            cliente.DIRECCIONCLIENTE = txtDireccion.Text;
            cliente.TELEFONOCLIENTE = txtTelefono.Text;
            cliente.CIUDAD = txtCiudad.Text;
            cliente.CEDULA = txtCedula.Text;

            ListaCLientesTemp.Add(cliente);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaCLientesTemp;
            btnRegistrarCliente.Visible = true;
            btnRegistrarCliente.Enabled = true;

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
            _registroRepositorio.RegistrarClientes(ListaCLientesTemp);
            ListaCLientesTemp.Clear();
            dgvDatos.DataSource = null;
        }

        private void btnVerCLiente_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            ListaCLientesTemp.Clear();
            ListaCLientesTemp.AddRange(_registroRepositorio.ObtenerListaCliente());
            dgvDatos.DataSource = ListaCLientesTemp;
        }

        private void grbRegistroPedido_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;
            btnEditar.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;
            btnRegistrarCliente.Visible = false;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            txtNombre.Text = ListaCLientesTemp[indice].NOMBRECLIENTE.ToString();
            txtCiudad.Text = ListaCLientesTemp[indice].CIUDAD.ToString();
            txtDireccion.Text = ListaCLientesTemp[indice].DIRECCIONCLIENTE.ToString();
            txtCedula.Text = ListaCLientesTemp[indice].CEDULA.ToString();
            txtTelefono.Text = ListaCLientesTemp[indice].TELEFONOCLIENTE.ToString();
            txtNombre.Enabled = false;
            txtCiudad.Enabled = false;
            txtDireccion.Enabled = false;
            txtCedula.Enabled = false;
            txtTelefono.Enabled = false;
            btnEditar.Visible = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NOMBRECLIENTE = txtNombre.Text;
            cliente.DIRECCIONCLIENTE = txtDireccion.Text;
            cliente.TELEFONOCLIENTE = txtTelefono.Text;
            cliente.CIUDAD = txtCiudad.Text;
            cliente.CEDULA = txtCedula.Text;

            _registroRepositorio.ActualizarCliente(cliente);
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = true;
            btnRegistrarCliente.Visible = false;



            dgvDatos.DataSource = null;
            ListaCLientesTemp.Clear();
            ListaCLientesTemp.AddRange(_registroRepositorio.ObtenerListaCliente());
            dgvDatos.DataSource = ListaCLientesTemp;

        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var CEDULA = txtCedula.Text;

            btnActualizar.Visible = false;
            btnEditar.Visible = false;
            btnRegistrarCliente.Visible = false;
            btnCancelar.Visible = false;

            btnEditar.Visible = false;
            btnEliminar.Visible = true;
            btnActualizar.Visible = false;
            btnCancelar.Visible = false;

            _registroRepositorio.Eliminar(CEDULA);


            dgvDatos.DataSource = null;
            ListaCLientesTemp.Clear();
            ListaCLientesTemp.AddRange(_registroRepositorio.ObtenerListaCliente());
            dgvDatos.DataSource = ListaCLientesTemp;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCiudad.Enabled = true;
            txtDireccion.Enabled = true;
            txtCedula.Enabled = true;
            txtTelefono.Enabled = true;
            btnActualizar.Visible = true;
            btnActualizar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnEliminar.Visible = true;
            btnEliminar.Enabled = true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();

            txtNombre.Enabled = true;
            txtCiudad.Enabled = true;
            txtTelefono.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;




            btnRegistrarCliente.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;
            btnCancelar.Visible = false;

        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }
    }
}
