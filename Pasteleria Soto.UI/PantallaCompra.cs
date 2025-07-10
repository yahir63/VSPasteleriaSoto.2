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
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaCompra : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        RegistroRepositoryPRODUCTO RepositoryPRODUCTO = new RegistroRepositoryPRODUCTO();
        RepositoryProveedor RepositoryProveedor = new RepositoryProveedor();
        List<Proveedor> listaProveedores = new List<Proveedor>();
        private List<Detallle_compra> listaDetalleCompraTemp = new List<Detallle_compra>();


        double TotalParcial = 0.0;

        public PantallaCompra()
        {
            InitializeComponent();
        }

        private void PantallaCompra_Load(object sender, EventArgs e)
        {
            listaProductos = RepositoryPRODUCTO.ObtenerListProductosTemp();
            cbProductosGen.DataSource = listaProductos;
            cbProductosGen.ValueMember = "ID_PRODUCTO";
            cbProductosGen.DisplayMember = "NOMBREPRODUCTO";

            listaProveedores = RepositoryProveedor.ObtenerListaProveedores();
            cbProveedores.DataSource = listaProveedores;
            cbProveedores.ValueMember = "ID_PROVEEDOR";
            cbProveedores.DisplayMember = "NOMBREPROVEEDOR";

        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)

        {
            var productosleccionado = cbProductosGen.SelectedItem;


            Detallle_compra detalleCompra = new Detallle_compra();

            if (productosleccionado != null)
            {
                Producto prod = (Producto)productosleccionado;

                // Obtener valores desde los TextBox
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                int cantidad = Convert.ToInt32(txtCantidadCompra.Text);

                // Llenar el objeto detalle
                detalleCompra.ID_PRODUCTO = prod.ID_PRODUCTO;
                detalleCompra.NOMBREPRODUCTO = prod.NOMBREPRODUCTO;
                detalleCompra.PRECIOVENTA = (double)precioVenta;
                detalleCompra.PRECIOCOMPRA = (double)precioCompra;
                detalleCompra.CANTIDAD = cantidad;
                detalleCompra.TOTAL = (double)(precioCompra * cantidad);

                TotalParcial += (double)detalleCompra.TOTAL;

                listaDetalleCompraTemp.Add(detalleCompra);



                dgvCompra.DataSource = null;
                dgvCompra.DataSource = listaDetalleCompraTemp;
                ActualizarTotalCompra();

                dgvCompra.Columns["ID_DETALLECOMPRA"].Visible = false;
                dgvCompra.Columns["ID_COMPRA"].Visible = false;
                dgvCompra.Columns["ID_PRODUCTO"].Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción válida.");
            }

            txtCantidadCompra.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtNumeroFactura.Clear();

        }


        private void ActualizarTotalCompra()
        {
            decimal sumaTotal = 0;

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["TOTAL"].Value != null && decimal.TryParse(fila.Cells["TOTAL"].Value.ToString(), out decimal valor))
                {
                    sumaTotal += valor;
                }
            }

            txtTotal.Text = sumaTotal.ToString("N2");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.ID_PROVEEDOR = Convert.ToInt32(cbProveedores.SelectedValue);
            compra.FECHA_COMPRA = DateTime.Now;
            compra.NUMEROFACTURA = txtNumeroFactura.Text;
            compra.TOTAL = TotalParcial;

            var resultado = MetodosCompra.RegistrarCompra(compra, listaDetalleCompraTemp);

            if (!resultado)
                MessageBox.Show("Algo fue mal");
            else
                MessageBox.Show("Compra Exitosa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicio frminicio = new frmInicio();
            frminicio.Show();
            this.Hide();
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    
}
