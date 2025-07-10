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
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;
using Pedido.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaDetallePedido : Form
    {
        MetodosCliente _clientesRepository = new MetodosCliente();
        RegistroRepositoryPRODUCTO _productosRepository = new RegistroRepositoryPRODUCTO();
        ProductoPersonalizadoRepository _productoPersonalizadoRepository = new ProductoPersonalizadoRepository();
        private List<DetallePedido> ListdetallePedidotemp = new List<DetallePedido>();
        MetodoPedido _metodoPedido = new MetodoPedido();

        Pedidos pedido = new Pedidos();

        List<DetallePedido> listdetalles = new List<DetallePedido>();


        List<Producto> listaProductos = new List<Producto>();

        List<ProductoPersonalizado> listaProductosPersonalizados = new List<ProductoPersonalizado>();

        double Total = 0;

        public class OpcionCombo
        {
            public string Display { get; set; }
            public double Value { get; set; }
        }


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


                    cbClientes.Text = cliente.NOMBRECLIENTE;
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

            txtCedula.Clear();
        }




        private void btnRegresarDPedido_Click(object sender, EventArgs e)
        {
            frmInicio regresar = new frmInicio();
            regresar.Show();
            this.Hide();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {


        }

        private void PantallaDetallePedido_Load(object sender, EventArgs e)
        {
            List<OpcionCombo> opciones = new List<OpcionCombo>
            {
              
                new OpcionCombo { Display = "1/2 libra", Value = 0.5 },
                new OpcionCombo { Display = "1 libra", Value = 1 },
                new OpcionCombo { Display = "1.5 libra", Value = 1.5},
                new OpcionCombo { Display = "2 libra", Value = 2}
            };

            cbVolumenPG.DataSource = opciones;
            cbVolumenPG.DisplayMember = "Display";
            cbVolumenPG.ValueMember = "Value";

            cbVolumenPPers.DataSource = opciones;
            cbVolumenPPers.DisplayMember = "Display";
            cbVolumenPPers.ValueMember = "Value";


            var listaCLientes = _clientesRepository.ObtenerListaCliente();
            cbClientes.DataSource = listaCLientes;
            cbClientes.ValueMember = "ID_CLIENTE";
            cbClientes.DisplayMember = "NOMBRECLIENTE";


            // Cargar productos en el ComboBox
            listaProductos = _productosRepository.ObtenerListProductosTemp();
            cbProducto.DataSource = listaProductos;
            cbProducto.ValueMember = "ID_PRODUCTO";
            cbProducto.DisplayMember = "NOMBREPRODUCTO";


            listaProductosPersonalizados = _productoPersonalizadoRepository.ObtenerListaProductosPersonalizados();
            cbProductoPersonalizado.DataSource = listaProductosPersonalizados;
            cbProductoPersonalizado.ValueMember = "ID_PERSONALIZADO";
            cbProductoPersonalizado.DisplayMember = "DESCRIPCION";
             
        }

        private void btnAgregarDetalle_Click_1(object sender, EventArgs e)
        {
            var productoSeleccionado = cbProducto.SelectedItem;
            double precioBase = 0;

            DetallePedido detallePedido = new DetallePedido();

            if (productoSeleccionado != null)
            {
                Producto prod = (Producto)productoSeleccionado;


                detallePedido.ID_PRODUCTO = prod.ID_PRODUCTO;
                detallePedido.NOMBREPRODUCTO = prod.NOMBREPRODUCTO;
                detallePedido.CANTIDAD = Convert.ToInt32(txtCantidad.Text);
                detallePedido.PRECIO_VENTA = Convert.ToDouble(txtPVtaProducto.Text);
                detallePedido.SUBTOTAL = detallePedido.CANTIDAD * detallePedido.PRECIO_VENTA;
                detallePedido.VOLUMEN = 0;

                if (prod.ID_CATEGORIA == 1)
                {
                    
                    detallePedido.VOLUMEN = Convert.ToDouble(cbVolumenPG.SelectedValue);
                    detallePedido.SUBTOTAL = detallePedido.CANTIDAD * detallePedido.PRECIO_VENTA * detallePedido.VOLUMEN;
                    
                }

                precioBase += prod.PRECIO;


                ListdetallePedidotemp.Add(detallePedido);
                ActualizardgvDetallePedido();
                 

                dgvDetallePedido.DataSource = null;
                dgvDetallePedido.DataSource = ListdetallePedidotemp;

                dgvDetallePedido.Columns["ID_DETALLEPEDIDO"].Visible = false;
                dgvDetallePedido.Columns["ID_PEDIDO"].Visible = false;
                dgvDetallePedido.Columns["ID_PRODUCTO"].Visible = false;
                dgvDetallePedido.Columns["ID_PERSONALIZADO"].Visible = false;
                dgvDetallePedido.Columns["TOTAL"].Visible = false; 
                dgvDetallePedido.Columns["SUBTOTAL"].Visible = false;


            }
        }


        private void btnRegistrarDPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.ID_CLIENTE = Convert.ToInt32(cbClientes.SelectedValue);
            pedido.FECHAPEDIDO = DateTime.Now;
            pedido.FECHAENTREGA = Convert.ToDateTime(dtpFechaEntrega.Value);
            pedido.HORAENTREGA = Convert.ToDateTime(txtHoraEntrega.Text);
            pedido.SUBTOTAL = Convert.ToDouble(txtSubtotal.Text);
            pedido.TOTAL = Convert.ToDouble(txtTotal.Text);
            pedido.ADELANTO = Convert.ToDouble(txtAdelanto.Text);


            // Llamar al método
            var resultado = MetodoPedido.RegistarPedidos(pedido, ListdetallePedidotemp);

            if (!resultado)
                MessageBox.Show("Algo fue mal");
            else
                MessageBox.Show("Registro exitoso");

          


        }

        private void cbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var indice = Convert.ToInt32(cbProducto.SelectedIndex.ToString());

            txtPVtaProducto.Text = listaProductos[indice].PRECIO.ToString();
            txtStockDisponible.Text = listaProductos[indice].CANTIDAD.ToString();

        }

        private void cbProductoPersonalizado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var indice = Convert.ToInt32(cbProductoPersonalizado.SelectedIndex.ToString());

            txtPVtaPPers.Text = listaProductosPersonalizados[indice].PRECIO_VENTA.ToString();
        }

        private void btnAgregarPPers_Click(object sender, EventArgs e)
        {
            var productoPerSeleccionado = cbProductoPersonalizado.SelectedItem;
            ProductoPersonalizado prodP = (ProductoPersonalizado)productoPerSeleccionado;
            double precioBase = 0;
            DetallePedido detallePedido = new DetallePedido();


            if (productoPerSeleccionado != null)
            {
                detallePedido.ID_PRODUCTO = prodP.ID_PERSONALIZADO;
                detallePedido.NOMBREPRODUCTO = prodP.DESCRIPCION;
                detallePedido.PRECIO_VENTA = prodP.PRECIO_VENTA;
                detallePedido.CANTIDAD = Convert.ToInt32(txtCantidadPers.Text);
                detallePedido.SUBTOTAL = detallePedido.CANTIDAD * detallePedido.PRECIO_VENTA;
                detallePedido.PRECIO_VENTA = Convert.ToDouble(txtPVtaPPers.Text);
                detallePedido.VOLUMEN = Convert.ToDouble(cbVolumenPPers.SelectedValue);
                detallePedido.SUBTOTAL = detallePedido.CANTIDAD * detallePedido.PRECIO_VENTA * detallePedido.VOLUMEN;


                precioBase += Convert.ToDouble(prodP.PRECIO_VENTA);
            }

            ListdetallePedidotemp.Add(detallePedido);
            ActualizardgvDetallePedido();

            dgvDetallePedido.DataSource = null;
            dgvDetallePedido.DataSource = ListdetallePedidotemp;

            dgvDetallePedido.Columns["ID_DETALLEPEDIDO"].Visible = false;
            dgvDetallePedido.Columns["ID_PEDIDO"].Visible = false;
            dgvDetallePedido.Columns["ID_PRODUCTO"].Visible = false;
            dgvDetallePedido.Columns["ID_PERSONALIZADO"].Visible = false;
            dgvDetallePedido.Columns["TOTAL"].Visible = false;
            dgvDetallePedido.Columns["SUBTOTAL"].Visible = false;


        }

        private void ActualizardgvDetallePedido()
        {
            double subtotal = 0, adelanto = 0;

            dgvDetallePedido.DataSource = null;
            dgvDetallePedido.DataSource = ListdetallePedidotemp;

            foreach (DataGridViewRow fila in dgvDetallePedido.Rows)
            {
                if (fila.Cells["SUBTOTAL"].Value != null)
                {
                    double valor = Convert.ToDouble(fila.Cells["SUBTOTAL"].Value);
                    subtotal += valor;
                }
            }
            adelanto = subtotal * 0.50; // 50% de adelanto
            Total = subtotal - adelanto;

            txtSubtotal.Text = Total.ToString();
            txtAdelanto.Text = adelanto.ToString();
            txtTotal.Text = subtotal.ToString();

            
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
       
    }

}

 
        
    


