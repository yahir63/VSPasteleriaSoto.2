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
            if (IdProductoPSeleccionado > 0) // Verifica que el ID está guardado
            {
                ProductoPersonalizado PP = new ProductoPersonalizado();
                PP.ID_PERSONALIZADO = IdProductoPSeleccionado; // Usa el ID guardado
                PP.DESCRIPCION = txtNombreIdentificador.Text;
                PP.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);
                PP.ID_CLIENTE = Convert.ToInt32(cbCliente.SelectedValue);
                PP.PRECIO_VENTA = PrecioTotal;

                _productoPersonalizadoRepository.ActualizarProductoP(PP);

                // Refrescar DataGridView
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
            //Relleno relleno = new Relleno();

            //relleno.NOMBRERELLENO = txtNombreIdentificador.Text;
            //relleno.DESCRIPCION = txtFecha.Text;
            //relleno.PRECIORELLENO = txtVolumen.Text; 


            //ListaRellenosTemp.Add(relleno);

            //dgvRelleno.DataSource = null;
            //dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnVerRelleno_Click(object sender, EventArgs e)
        {
            dgvOpciones.DataSource = null;
            ListaProductosPersonalizados.Clear();
            ListaProductosPersonalizados.AddRange(_productoPersonalizadoRepository.ObtenerListaProductosPersonalizados());
            dgvOpciones.DataSource = ListaProductosPersonalizados;
        }

        private void btnRegistrarRelleno_Click(object sender, EventArgs e)
        {
        }

        private void btnEditarRelleno_Click(object sender, EventArgs e)
        {
            //int ID_RELLENO = Convert.ToInt32(dgvRelleno.CurrentRow.Cells["ID_RELLENO"].Value);


            //string nuevoNombre = txtNombreIdentificador.Text;
            //string nuevaDescripcion = txtFecha.Text;
            //string precioRelleno = txtVolumen.Text;



            //_registroRepositorioRelleno.EditarRelleno(ID_RELLENO, nuevoNombre, nuevaDescripcion, precioRelleno);
            //dgvRelleno.DataSource = null;
            //ListaRellenosTemp.Clear();
            //ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
            //dgvRelleno.DataSource = ListaRellenosTemp;

            //txtNombreIdentificador.Enabled = true;
            //txtFecha.Enabled = true;
            //txtVolumen.Enabled = true;


        }

        private void btnEliminarRelleno_Click(object sender, EventArgs e)
        {
            //var ID_RELLENO = ListaRellenosTemp[indice].ID_RELLENO;

            //_registroRepositorioRelleno.EliminarRelleno(ID_RELLENO);


            //dgvRelleno.DataSource = null;
            //ListaRellenosTemp.Clear();
            //ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
            //dgvRelleno.DataSource = ListaRellenosTemp;
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

        private void dgvOpciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                var listaCLientes = _clientesRepository.ObtenerListaCliente();

                indice = e.RowIndex;
                IdProductoPSeleccionado = ListaProductos[indice].ID_CATEGORIA;

                txtNombreIdentificador.Text = ListaProductosPersonalizados[indice].DESCRIPCION.ToString();
                txtCantidad.Text = ListaOpcionesTemp[indice].CANTIDAD.ToString();
                cbCliente.SelectedItem = listaClientes.FirstOrDefault(cliente => cliente.Id == ListaProductosPersonalizados[indice]?.ClienteId);


                btnEditarPer.Visible = true;
                btnEditarPer.Enabled = true;
                btnEliminarPer.Visible = true;
                btnEliminarPer.Enabled = true;


                txtCat.Enabled = false;
                txtNombreCat.Enabled = false;
                txtDescripcion.Enabled = false;


            }
        }

        //private void btnCancelarRelleno_Click(object sender, EventArgs e)
        //{
        //    txtNombreIdentificador.Text = "";
        //    txtFecha.Text = "";
        //    txtVolumen.Text = "";
        //    dgvOpciones.ClearSelection();
        //}

        //private void btnRegresarRelleno_Click(object sender, EventArgs e)
        //{
        //    frmInicio nuevapantallainicio = new frmInicio();
        //    nuevapantallainicio.Show();
        //}


        //private void label5_Click(object sender, EventArgs e)
        //{

        //}

        //private void dgvRelleno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        ////{
        ////    if (e.RowIndex >= 0)
        ////    {
        ////        indice = e.RowIndex;
        ////        idRellenoSeleccionado = ListaRellenosTemp[indice].ID_RELLENO;

        ////        txtNombreIdentificador.Text = ListaRellenosTemp[indice].NOMBRERELLENO.ToString();
        ////        txtFecha.Text = ListaRellenosTemp[indice].DESCRIPCION.ToString();
        ////        txtVolumen.Text = ListaRellenosTemp[indice].PRECIORELLENO.ToString();


        ////        btnEditarPer.Visible = true;
        ////        btnEditarPer.Enabled = true;
        ////        btnEliminarPer.Visible = true;
        ////        btnEliminarPer.Enabled = true;

        ////        txtNombreIdentificador.Enabled = false;
        ////        txtFecha.Enabled = false;
        ////        txtVolumen.Enabled = false;

        ////        MessageBox.Show("ID seleccionado: " + idRellenoSeleccionado); 
        ////    }

        //}


    }

}
