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
using PasteleriaSoto.DAL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaDetallePedido : Form
    {
        public PantallaDetallePedido()
        {
            InitializeComponent();
        }

        public int ID_Cliente { get; set; }
        public int ID_Producto { get; set; }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Instanciar Cliente


            // Instanciar Cliente
            MetodosCliente obtenerccliente = new MetodosCliente();

            // Validar que el campo no esté vacío
            if (!string.IsNullOrEmpty(txtCedula.Text))
            {
                // Buscar cliente por documento (ya no devuelve DataTable, sino Cliente)
                Cliente cliente = obtenerccliente.ObtenerClientePorCedula(txtCedula.Text);

                // Validar que el cliente exista
                if (cliente != null)
                {
                    // Guardar el ID_Cliente
                    int ID_CLIENTE = cliente.ID_CLIENTE;

                
                    txtNombreCliente.Text = cliente.NOMBRECLIENTE;
                    txtDireccion.Text = cliente.DIRECCIONCLIENTE;
                    txtTelefono.Text = cliente.TELEFONOCLIENTE;
                    txtCiudad.Text = cliente.CIUDAD;
                    txtCedula.Text = cliente.CEDULA;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCiudad.Clear();
            txtCedula.Clear();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {



            // Instanciar método para buscar productos
            MetodosProductos obtenerProducto = new MetodosProductos();

            // Validar que el campo no esté vacío
            if (!string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                // Buscar producto por nombre
                Producto producto = obtenerProducto.BuscarProducto(txtNombreProducto.Text);

                // Validar que el producto exista
                if (producto != null)
                {
                    // Guardar el ID_PRODUCTO
                    int ID_PRODUCTO = producto.ID_PRODUCTO;

                    // Llenar los campos con los datos del producto
                    txtNombreProducto.Text = producto.NOMBREPRODUCTO;
                    txtPrecioProducto.Text = producto.PRECIO.ToString();
                    txtCantidad.Text = producto.CANTIDAD.ToString();
                    txtLibras.Text = producto.LIBRAS.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtLibras.Clear();

            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
        }

        private void btnRegresarDPedido_Click(object sender, EventArgs e)
        {
            frmInicio regresar = new frmInicio();
            regresar.Show();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                string.IsNullOrEmpty(txtNombreProducto.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text) ||
                string.IsNullOrEmpty(txtPrecioProducto.Text) ||
                string.IsNullOrEmpty(txtAdelanto.Text))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidad = 0;
            decimal precio = 0m;
            decimal adelanto = 0m;
            decimal total = 0m;

             cantidad = Convert.ToInt32(txtCantidad.Text);
           precio = Convert.ToDecimal(txtPrecioProducto.Text);
            adelanto = Convert.ToDecimal(txtAdelanto.Text);
             total = (precio * cantidad); 

            // Verificar si el producto ya está en el DataGridView
            bool productoExiste = false;
            foreach (DataGridViewRow row in dgvDetallePedido.Rows)
            {
                if (row.Cells["NOMBREPRODUCTO"].Value != null && row.Cells["NOMBREPRODUCTO"].Value.ToString() == txtNombreProducto.Text)
                {
                    int nuevaCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value) + Convert.ToInt32(txtCantidad.Text);
                    row.Cells["Cantidad"].Value = nuevaCantidad;

                    decimal preciop = Convert.ToDecimal(txtPrecioProducto.Text);
                    decimal totalp = precio * nuevaCantidad;

                    row.Cells["Total"].Value = total.ToString("N2");

                    productoExiste = true;
                    break;
                }
            }


            if (!productoExiste)
            {
                dgvDetallePedido.Rows.Add(ID_Producto, txtNombreProducto.Text, txtCedula, txtCiudad, txtDireccion, txtNombreCliente, txtFechaEntrega, txtHoraEntrega, precio.ToString("N2"), cantidad, total.ToString("N2"), adelanto.ToString("N2"));
            }

            // Crear y registrar el detalle del pedido
            DetallePedido detallePedido = new DetallePedido
            {
                ID_CLIENTE = Convert.ToInt32(txtNombreCliente.Tag),  
                ID_PRODUCTO = ID_Producto,

                FECHAPEDIDO = DateTime.Now,
                HORAENTREGA = DateTime.Now,
                SUBTOTAL = total,
                TOTAL = total,
                dt = new DataTable()
            };

            // Insertar el pedido con el detalle correspondiente
            MetodoPedido pedidoMet = new MetodoPedido();
            pedidoMet.InsertarPedido(detallePedido);

            // Limpiar los campos después de agregar el producto

            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidad.Clear();
            txtAdelanto.Clear();
            ID_Producto = 0;


        }

        private void PantallaDetallePedido_Load(object sender, EventArgs e)
        {
            // Agregar columnas al DataGridView
            dgvDetallePedido.Columns.Add("NOMBRECLIENTE", "Nombre Cliente");
            dgvDetallePedido.Columns.Add("NOMBREPRODUCTO", "Nombre Producto");
            dgvDetallePedido.Columns.Add("CEDULA", "Cédula");
            dgvDetallePedido.Columns.Add("HORAENTREGA", "Hora Entrega");
            dgvDetallePedido.Columns.Add("FECHAPEDIDO", "Fecha Pedido");
            dgvDetallePedido.Columns.Add("PRECIO", "Precio");
            dgvDetallePedido.Columns.Add("CANTIDAD", "Cantidad");
           
  

            dgvDetallePedido.Rows.Clear();

        }
    }

}

