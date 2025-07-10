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
using PasteleriaSoto.DAL.Entities;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaProductoPersonalizado : Form
    {
        public OpcionesRepository _opcionesRepository = new OpcionesRepository();
        public RegistroRepositoryCliente _clientesRepository = new RegistroRepositoryCliente();
        public RegistroRepositoryPRODUCTO _productosRepository = new RegistroRepositoryPRODUCTO();
        public ProductoPersonalizadoRepository _productoPersonalizadoRepository = new ProductoPersonalizadoRepository();

        List<Opciones> ListaOpciones = new List<Opciones>();
        List<Opciones> ListaOpcionesTemp = new List<Opciones>();
        List<Producto> ListaProductos = new List<Producto>();
        List<ProductoPersonalizado> ListaProductosPersonalizados = new List<ProductoPersonalizado>();

        private int indice;
        int idOpcionSeleccionada;
        double PrecioTotal = 0.0;
        int IdProductoPSeleccionado;



        public PantallaProductoPersonalizado()
        {
            InitializeComponent();
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizarRelleno_Click(object sender, EventArgs e)
        {
            if (IdProductoPSeleccionado > 0)
            {
                ProductoPersonalizado PP = new ProductoPersonalizado();
                PP.ID_PERSONALIZADO = IdProductoPSeleccionado;
                PP.DESCRIPCION = txtNombreIdentificador.Text;
                PP.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);
                PP.ID_CLIENTE = Convert.ToInt32(cbCliente.SelectedValue);
                PP.PRECIO_VENTA = PrecioTotal;

                _productoPersonalizadoRepository.ActualizarProductoP(PP);


                dgvOpciones.DataSource = null;
                ListaProductosPersonalizados.Clear();
                ListaProductosPersonalizados.AddRange(_productoPersonalizadoRepository.ObtenerListaProductosPersonalizados());
                dgvOpciones.DataSource = ListaProductosPersonalizados;
            }
            else
            {
                MessageBox.Show("Selecciona un relleno antes de actualizar.");
            }

        }

        private void btnAgregarRelleno_Click(object sender, EventArgs e)
        {

        }

        private void btnVerRelleno_Click(object sender, EventArgs e)
        {
            dgvOpciones.DataSource = null;
            ListaProductosPersonalizados.Clear();
            ListaProductosPersonalizados.AddRange(_productoPersonalizadoRepository.ObtenerListaProductosPersonalizados());
            dgvOpciones.DataSource = ListaProductosPersonalizados;

            dgvOpciones.Columns["ID_PERSONALIZADO"].Visible = false;
           
        }

        private void btnRegistrarRelleno_Click(object sender, EventArgs e)
        {
        }

        private void btnEditarRelleno_Click(object sender, EventArgs e)
        {



        }

        private void btnEliminarRelleno_Click(object sender, EventArgs e)
        {

        }

        private void PantallaProductoPersonalizado_Load(object sender, EventArgs e)
        {
            ListaProductos.AddRange(_productosRepository.ObtenerListProductosTemp());
            ListaOpciones.AddRange(_opcionesRepository.ObtenerListaOpciones());


            //Cargar los Combo Box
            var listaCLientes = _clientesRepository.ObtenerListaCliente();
            cbCliente.DataSource = listaCLientes;
            cbCliente.ValueMember = "ID_CLIENTE";
            cbCliente.DisplayMember = "NOMBRECLIENTE";

            var listaProductos = _productosRepository.ObtenerListProductosTemp();
            cbProductoBase.DataSource = listaProductos;
            cbProductoBase.ValueMember = "ID_PRODUCTO";
            cbProductoBase.DisplayMember = "NOMBREPRODUCTO";


            cbOpciones.DataSource = _opcionesRepository.ObtenerListaOpciones();
            cbOpciones.ValueMember = "ID_OPCIONES";
            cbOpciones.DisplayMember = "NOMBRE_OPCION";
        }

        private void btnAgregarOpcion_Click(object sender, EventArgs e)
        {
            var opcionSeleccionada = cbOpciones.SelectedItem;
            double PrecioParcial = 0.0;


            if (opcionSeleccionada != null)
            {
                Opciones opcion = (Opciones)opcionSeleccionada;
                opcion.CANTIDAD = Convert.ToInt32(txtCantidad.Text); // Asignar la cantidad seleccionada

                ListaOpcionesTemp.Add(opcion);
                dgvOpciones.DataSource = null;
                dgvOpciones.DataSource = ListaOpcionesTemp;

                foreach (var item in ListaOpcionesTemp)
                {
                    PrecioParcial += (item.PRECIO * item.CANTIDAD);
                }

                PrecioTotal = PrecioParcial + Convert.ToDouble(ListaProductos[cbProductoBase.SelectedIndex].PRECIO.ToString());

                lblPrecioVta.Text = Convert.ToString(PrecioTotal);

                dgvOpciones.Columns["ID_OPCIONES"].Visible = false; // Ocultar la columna ID_OPCIONES

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción válida.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool validacion = true;
            ProductoPersonalizado productoPersonalizado = new ProductoPersonalizado();

            productoPersonalizado.DESCRIPCION = txtNombreIdentificador.Text;
            productoPersonalizado.ID_CLIENTE = Convert.ToInt32(cbCliente.SelectedValue);
            productoPersonalizado.PRECIO_VENTA = PrecioTotal;
            productoPersonalizado.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);


            validacion = _productoPersonalizadoRepository.Registrar(productoPersonalizado, ListaOpcionesTemp);

            if (validacion == true)
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("No se guardó el registro");
            }

        }

        private void txtNombreIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresarRelleno_Click(object sender, EventArgs e)
        {
            frmInicio frminicio = new frmInicio();
            frminicio.Show();
            this.Hide();
        }

        private void cbProductoBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductoBase.SelectedItem != null)
            {
                // Obtener el producto seleccionado
                Producto productoSeleccionado = (Producto)cbProductoBase.SelectedItem;

                // Mostrar el precio en un Label o TextBox
                txtPrecio.Text = "Precio: $" + productoSeleccionado.PRECIO.ToString("0.00");
            }

        }
    }

}
