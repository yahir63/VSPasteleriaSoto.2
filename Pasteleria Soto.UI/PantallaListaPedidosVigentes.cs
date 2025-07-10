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
using Microsoft.Identity.Client;
using PantallasProyecto.DAL;
using PasteleriaSoto.BLL;
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;
using Pedido.DAL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaListaPedidosVigentes : Form
    {
        MetodosHistorialPedidos _pedidosRepository = new MetodosHistorialPedidos();
        List<Pedidos> _pedidos = new List<Pedidos>();
        List<DetallePedido> _detallesPedido = new List<DetallePedido>();
        List<Detalle_Venta> detalle_Ventas = new List<Detalle_Venta>();
        List<Pedidos> _pedidoscancelados = new List<Pedidos>();
        List<Pedidos> ListaNuevosPedidosCancelados = new List<Pedidos>();




        public PantallaListaPedidosVigentes()
        {
            InitializeComponent();
        }

        private void btnMnzProducto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditarSabor_Click(object sender, EventArgs e)
        {

        }


        private void btnActualizarSabor_Click(object sender, EventArgs e)
        {




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSabor_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void dgvSabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaSabor_Load(object sender, EventArgs e)
        {

        }

        private void btnVerSabor_Click(object sender, EventArgs e)
        {
            dgvListPedidos.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
            dtvDetalleVenta.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
            var fechaInicio = dtpFechaInicial.Value;
            var fechaFinal = dtpFechaFinal.Value;

            if (fechaInicio.Date != fechaFinal.Date)
            {
                if (fechaFinal.Date < fechaInicio.Date)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (fechaInicio.Date == DateTime.Today)
            {
                fechaInicio = dtpFechaInicial.Value.Date;
            }

            _pedidos = _pedidosRepository.ObtenerPedido(fechaInicio, fechaFinal);
            if (_pedidos == null || _pedidos.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            dgvListPedidos.DataSource = _pedidos;
            dgvListPedidos.Columns["ID_CLIENTE"].Visible = false;
            dgvListPedidos.Columns["ID_USUARIO"].Visible = false;
            dgvListPedidos.Columns["ESTADO"].Visible = false;
            dgvListPedidos.Columns["SUBTOTAL"].Visible = false;
            dgvListPedidos.Columns["FECHAPEDIDO"].Visible = false;
            dgvListPedidos.Columns["ADELANTO"].Visible = false;
            dgvListPedidos.Columns["HORAENTREGA"].Visible = false;







        }

        private void btnAgregarSabor_Click(object sender, EventArgs e)
        {


        }

        private void btnRegistrarSabor_Click(object sender, EventArgs e)
        {
            PantallaRegistro PantallaRegistro = new PantallaRegistro();
            PantallaRegistro.Show();
            this.Hide();

        }



        private void btnEliminarSabor_Click(object sender, EventArgs e)
        {


        }

        private void btnCancelarSabor_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRegresarSabor_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
            this.Hide();
        }

        private void dgvSabor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvListPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indice = e.RowIndex;
            if (indice < 0 || indice >= _pedidos.Count)
            {
                MessageBox.Show("Seleccione una venta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ID_PEDIDO = _pedidos[indice].ID_PEDIDO;
            _detallesPedido = _pedidosRepository.ObtenerDetallePedido(ID_PEDIDO);

            if (_detallesPedido == null || _detallesPedido.Count == 0)
            {
                MessageBox.Show("No se encontraron detalles para la venta seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtvDetalleVenta.DataSource = null;
            dtvDetalleVenta.DataSource = _detallesPedido;


            foreach (var d in _detallesPedido)
            {
                var detalle = new Detalle_Venta
                {
                    ID_PRODUCTO = d.ID_PRODUCTO,
                    CANTIDAD = d.CANTIDAD,
                    PRECIO_VENTA = d.PRECIO_VENTA,
                    TOTAL_LINEA = d.TOTAL
                };

                detalle_Ventas.Add(detalle);
                dtvDetalleVenta.Columns["ID_PEDIDO"].Visible = false;
                dtvDetalleVenta.Columns["ID_PERSONALIZADO"].Visible = false;
                dtvDetalleVenta.Columns["ID_DETALLEPEDIDO"].Visible = false;
                dtvDetalleVenta.Columns["ID_PRODUCTO"].Visible = false;
                dtvDetalleVenta.Columns["SUBTOTAL"].Visible = false;
                dtvDetalleVenta.Columns["VOLUMEN"].Visible = false;




            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            //var indice = dgvListPedidos.CurrentRow.Index;

            venta.ID_PEDIDO = Convert.ToInt32(dgvListPedidos.CurrentRow.Cells["ID_PEDIDO"].Value);
            venta.ID_CLIENTE = Convert.ToInt32(dgvListPedidos.CurrentRow.Cells["ID_CLIENTE"].Value);
            venta.FECHAVENTA = DateTime.Now;
            venta.TOTALVENTA = Convert.ToDouble(dgvListPedidos.CurrentRow.Cells["TOTAL"].Value);




            var resultado = MetodosHistorialPedidos.ActualizarEstadoPedido(venta, detalle_Ventas);

            if (!resultado)
                MessageBox.Show("Algo fue mal");
            else
                MessageBox.Show("Registro exitoso");

        }

        private void btnCancelados_Click(object sender, EventArgs e)
        {
            dgvListPedidos.DataSource = null;
            _pedidoscancelados.Clear();
            _pedidoscancelados.AddRange(MetodosHistorialPedidos.ObtenerPedidosCancelados());

            dgvListPedidos.DataSource = _pedidoscancelados;

            dgvListPedidos.Columns["ID_USUARIO"].Visible = false;
            dgvListPedidos.Columns["NOMBRECLIENTE"].Visible = false;
            dgvListPedidos.Columns["FECHAENTREGA"].Visible = false;
            dgvListPedidos.Columns["HORAENTREGA"].Visible = false;
            dgvListPedidos.Columns["ADELANTO"].Visible = false;
            dgvListPedidos.Columns["SUBTOTAL"].Visible = false;
            dgvListPedidos .Columns["ESTADO"].Visible = false;
        }
    }
}
