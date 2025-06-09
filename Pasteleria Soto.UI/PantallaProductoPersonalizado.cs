using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes.DAL;
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
        ProductoPersonalizado productoPersonalizado = new ProductoPersonalizado();

        List<Opciones> ListaOpciones = new List<Opciones>();
        List<Opciones> ListaOpcionesTemp = new List<Opciones>();
        List<Producto> ListaProductos = new List<Producto>();
        List<ProductoPersonalizado> ListaProductosPersonalizados = new List<ProductoPersonalizado>();
        List<Cliente> listaCLientes = new List<Cliente>();

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
                    try
                    {
                        if (IdProductoPSeleccionado > 0) // Verifica que el ID está guardado
                        {
                            ProductoPersonalizado PP = new ProductoPersonalizado();
                            PP.ID_PERSONALIZADO = IdProductoPSeleccionado; // Usa el ID guardado
                            PP.DESCRIPCION = txtNombreIdentificador.Text;

                            
                            if (cbProductoBase.SelectedValue == null || cbCliente.SelectedValue == null)
                            {
                                MessageBox.Show("Debe seleccionar un producto y un cliente antes de actualizar.");
                                return;
                            }

                            PP.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);
                            PP.ID_CLIENTE = Convert.ToInt32(cbCliente.SelectedValue);
                            PP.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);

                    // Validar que la lista de opciones no esté vacía
                    if (ListaOpcionesTemp == null || ListaOpcionesTemp.Count == 0)
                            {
                                MessageBox.Show("Debe agregar al menos una opción antes de actualizar.");
                                return;
                            }

                            PP.Opciones = new List<Opciones>();
                            foreach (var opcion in ListaOpcionesTemp)
                            {
                                if (opcion == null) continue; // Evita errores si hay elementos nulos

                                Opciones nuevaOpcion = new Opciones
                                {
                                    ID_OPCIONES = opcion.ID_OPCIONES,
                                    CANTIDAD = opcion.CANTIDAD,
                                    PRECIO = opcion.PRECIO
                                };
                                PP.Opciones.Add(nuevaOpcion);
                            }

                            bool actualizado = _productoPersonalizadoRepository.ActualizarProductoPersonalizado(PP, ListaOpcionesTemp);

                            if (actualizado)
                            {
                                MessageBox.Show("Producto personalizado actualizado correctamente.");

                                // Refrescar DataGridView solo si la actualización fue exitosa
                                dgvOpciones.DataSource = null;
                                ListaProductosPersonalizados.Clear();
                                ListaProductosPersonalizados.AddRange(_productoPersonalizadoRepository.ObtenerListaProductosPersonalizados());
                                dgvOpciones.DataSource = ListaProductosPersonalizados;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al actualizar el producto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecciona un producto antes de actualizar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al procesar la actualización: " + ex.Message);
                    }
                }

        

        private void btnAgregarRelleno_Click(object sender, EventArgs e)
        {
            
            productoPersonalizado.DESCRIPCION = txtNombreIdentificador.Text;
            productoPersonalizado.ID_CLIENTE = Convert.ToInt32(cbCliente.SelectedValue);
            productoPersonalizado.PRECIO_VENTA = PrecioTotal;
            productoPersonalizado.ID_PRODUCTO = Convert.ToInt32(cbProductoBase.SelectedValue);
            
            ListaProductosPersonalizados.Add(productoPersonalizado);

            dgvOpciones.DataSource = null;
            dgvOpciones.DataSource = ListaProductosPersonalizados;

            cbCliente.SelectedValue = -1;
            txtNombreIdentificador.Clear();
            txtCantidad.Clear();
            cbProductoBase.SelectedValue = -1;




        }

        private void btnVerRelleno_Click(object sender, EventArgs e)
        {
            dgvOpciones.DataSource = null;
            ListaProductosPersonalizados.Clear();
            ListaProductosPersonalizados.AddRange(_productoPersonalizadoRepository.ObtenerListaProductosPersonalizados());
            dgvOpciones.DataSource = ListaProductosPersonalizados;
        }


        
           private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                bool registrado = _productoPersonalizadoRepository.Registrar(productoPersonalizado, ListaOpcionesTemp);

                if (registrado)
                {
                    // ya con los datos capturados por agregar solo llamamos el metodo
                    _productoPersonalizadoRepository.Registrar(productoPersonalizado, ListaOpcionesTemp);

                    ListaOpcionesTemp.Clear();
                    dgvOpciones.DataSource = null; 

                    MessageBox.Show("Producto personalizado registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        

        private void btnEditarRelleno_Click(object sender, EventArgs e)
        {
            btnEditarPer.Visible = true;
            btnEditarPer.Enabled = false;
            btnEliminarPer.Visible = true;
            btnEliminarPer.Enabled = false;
            btnCancelarPer.Visible = true;
            btnCancelarPer.Enabled = true;


            txtNombreIdentificador.Enabled = true;
            txtCantidad.Enabled = true;
            cbCliente.Enabled = true;
            cbProductoBase.Enabled = true;
            cbOpciones.Enabled = true;
          
       
            btnActualizarPer.Visible = true;
            btnActualizarPer.Enabled = true;






        }

        private void btnEliminarRelleno_Click(object sender, EventArgs e)
        {
            
        
            try
            {
                if (indice > 0 )
                {
                    MessageBox.Show("No se encontró el producto para eliminar.");
                    return;
                }

                var ID_PERSONALIZADO = ListaProductosPersonalizados[indice].ID_PERSONALIZADO;

                bool eliminado = _productoPersonalizadoRepository.EliminarProductoPersonalizado(ID_PERSONALIZADO);

                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.");

                    ListaProductosPersonalizados.RemoveAt(indice);
                    dgvOpciones.DataSource = null;
                    dgvOpciones.DataSource = ListaProductosPersonalizados;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void PantallaProductoPersonalizado_Load(object sender, EventArgs e)
        {
            ListaProductos.AddRange(_productosRepository.ObtenerListProductosTemp());
            ListaOpciones.AddRange(_opcionesRepository.ObtenerListaOpciones());


            //Cargar los Combo Box
             listaCLientes = _clientesRepository.ObtenerListaCliente();
            cbCliente.DataSource = listaCLientes;
            cbCliente.ValueMember = "ID_CLIENTE";
            cbCliente.DisplayMember = "NOMBRECLIENTE";

            ListaProductos = _productosRepository.ObtenerListProductosTemp();
            cbProductoBase.DataSource = ListaProductos;
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
            
        }

        private void txtNombreIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOpciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                listaCLientes = _clientesRepository.ObtenerListaCliente();

                indice = e.RowIndex;
                IdProductoPSeleccionado = ListaProductos[indice].ID_CATEGORIA;

                txtNombreIdentificador.Text = ListaProductosPersonalizados[indice].DESCRIPCION.ToString();
                txtCantidad.Text = ListaOpcionesTemp[indice].CANTIDAD.ToString();
                cbCliente.SelectedItem = listaCLientes.FirstOrDefault(cliente => cliente.ID_CLIENTE == ListaProductosPersonalizados[indice]?.ID_CLIENTE);
                cbOpciones.SelectedItem = ListaOpciones.FirstOrDefault(opcion => opcion.ID_OPCIONES == ListaOpcionesTemp[indice]?.ID_OPCIONES);

                btnEditarPer.Visible = true;
                btnEditarPer.Enabled = true;
                btnEliminarPer.Visible = true;
                btnEliminarPer.Enabled = true;


                txtNombreIdentificador.Enabled = false;
                txtCantidad.Enabled = false;
                cbCliente.Enabled = false;
                cbProductoBase.Enabled = false;
                cbOpciones.Enabled = false;
                btnEditarPer.Visible = true;
                btnEditarPer.Enabled = true;
                btnEliminarPer.Visible = true;
                btnEliminarPer.Enabled = true;
                btnActualizarPer.Visible = true;
                btnActualizarPer.Enabled = false;
                


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
