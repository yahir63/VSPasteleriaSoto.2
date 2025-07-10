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
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;
using Pedido.DAL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaHistorialVenta : Form
    {
        MetodosHistorialVentas _ventasRepository = new MetodosHistorialVentas();
        List<Venta> _ventas = new List<Venta>();
        List<Detalle_Venta> _detallesVenta = new List<Detalle_Venta>();
        public PantallaHistorialVenta()
        {
            InitializeComponent();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {

            dgvListVenta.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
            dtvDetalleVenta.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
            var fechaInicio = dtpFechaInicialVenta.Value;
            var fechaFinal = dtpFechaFinalVenta.Value;

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
                fechaInicio = dtpFechaInicialVenta.Value.Date;
            }

            _ventas = _ventasRepository.ObtenerVenta(fechaInicio, fechaFinal);
            if (_ventas == null || _ventas.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            dgvListVenta.DataSource = _ventas;

  


        }

        private void dgvListVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indice = e.RowIndex;
            if (indice < 0 || indice >= _ventas.Count)
            {
                MessageBox.Show("Seleccione una venta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ID_VENTA = _ventas[indice].ID_VENTA;
            _detallesVenta = _ventasRepository.ObtenerDetalleVentas(ID_VENTA);

            if (_detallesVenta == null || _detallesVenta.Count == 0)
            {
                MessageBox.Show("No se encontraron detalles para la venta seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtvDetalleVenta.DataSource = null;
            dtvDetalleVenta.DataSource = _detallesVenta;





        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            frmInicio regresar = new frmInicio();
            regresar.Show();
            this.Hide();
        }
    }
}
