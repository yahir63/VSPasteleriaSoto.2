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

namespace Pasteleria_Soto.UI
{
    public partial class EleccionProducto : Form
    {
        List<Producto> ListProductosTemp = new List<Producto>();
        RegistroRepositoryPRODUCTO RepositoryPRODUCTO = new RegistroRepositoryPRODUCTO();
        RegistroRepositoryRelleno registroRepositoryRelleno = new RegistroRepositoryRelleno();
        RepositorioSabor repositorioSabor = new RepositorioSabor();
        RegistroRepositoryCAT registroRepositoryCAT = new RegistroRepositoryCAT();
        RegistroRepositoryBaño registroRepositoryBano = new RegistroRepositoryBaño();
        MetodoSabor metSabor = new MetodoSabor();
        MetodosRelleno metRelleno = new MetodosRelleno();
        MetodosBano metBano = new MetodosBano();
        private int indice;
        private int Id_Producto;

        public EleccionProducto()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();




            producto.ID_PRODUCTO = Convert.ToInt32(dgvDatos.CurrentRow.Cells["ID_PRODUCTO"].Value);
            producto.NOMBREPRODUCTO = txtNombreProducto.Text;
            producto.ID_CATEGORIA = Convert.ToInt32(cbCategoriaProducto.SelectedValue);
            producto.ID_SABOR = Convert.ToInt32(cbSaborProducto.SelectedValue);
            producto.ID_RELLENO = Convert.ToInt32(cbRellenoProducto.SelectedValue);
            producto.ID_BANO = Convert.ToInt32(cbBanoProducto.SelectedValue);
            producto.CANTIDAD = int.Parse(txtCantidad.Text);
            producto.LIBRAS = int.Parse(txtLibra.Text);

            RepositoryPRODUCTO.ActualizarProducto(producto);


            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id_producto = ListProductosTemp[indice].ID_PRODUCTO;
            RepositoryPRODUCTO.Eliminar(id_producto);


            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            cbCategoriaProducto.Enabled = true;
            cbRellenoProducto.Enabled = true;
            cbSaborProducto.Enabled = true;
            cbBanoProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtLibra.Enabled = true;
            txtNombreProducto.Enabled = true;
            btnActualizarProducto.Enabled = true;
            btnActualizarProducto.Visible = true;
            btnCancelarProducto.Enabled = true;
            btnCancelarProducto.Visible = true;
            btnEliminarProducto.Enabled = true;
            btnEliminarProducto.Visible = true;



            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            EleccionProducto eleccion = new EleccionProducto();
            eleccion.Show();
            this.Hide();
            RepositoryPRODUCTO.RegistrarProductos(ListProductosTemp);
            ListProductosTemp.Clear();
            dgvDatos.DataSource = null;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            btnRegistrarProducto.Visible = true;
            btnRegistrarProducto.Enabled = true;

            Producto producto = new Producto();

            producto.NOMBREPRODUCTO = txtNombreProducto.Text;
            producto.NOMBRECATEGORIA = cbCategoriaProducto.Text;
            producto.NOMBRESABOR = cbSaborProducto.Text;
            producto.NOMBRERELLENO = cbRellenoProducto.Text;
            producto.NOMBREBANO = cbBanoProducto.Text;
            producto.CANTIDAD = int.Parse(txtCantidad.Text);
            producto.LIBRAS = int.Parse(txtLibra.Text);
            producto.ID_CATEGORIA = ((Categoria)cbCategoriaProducto.SelectedItem).ID_CATEGORIA;
            producto.ID_SABOR = ((Sabor)cbSaborProducto.SelectedItem).ID_SABOR;
            producto.ID_RELLENO = ((Relleno)cbRellenoProducto.SelectedItem).ID_RELLENO;
            producto.ID_BANO = ((Bano)cbBanoProducto.SelectedItem).ID_BANO;



            // Obtener precios desde BD
            decimal precioSabor = metSabor.ObtenerPrecioSaborPorId(producto.ID_SABOR);
            decimal precioRelleno = metRelleno.ObtenerPrecioRelleno(producto.ID_RELLENO);
            decimal precioBano = metBano.ObtenerPrecioBano(producto.ID_BANO);
            decimal precioPorLibra = 450;

            // Calcular precio total
            decimal precioUnitario = (producto.LIBRAS * precioPorLibra) + precioSabor + precioRelleno + precioBano;
            producto.PRECIO = (float)(precioUnitario * producto.CANTIDAD);

            // Agregar a la lista y actualizar DataGridView
            ListProductosTemp.Add(producto);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListProductosTemp;

            // Ocultar columnas no necesarias
            dgvDatos.Columns["ID_SABOR"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
            dgvDatos.Columns["ID_BANO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;


        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {



            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;

            dgvDatos.Columns["ID_SABOR"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;

            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
            dgvDatos.Columns["ID_BANO"].Visible = false;
        }

        private void EleccionProducto_Load(object sender, EventArgs e)
        {
            cbCategoriaProducto.SelectedIndex = -1;
            cbSaborProducto.SelectedIndex = -1;
            cbRellenoProducto.SelectedIndex = -1;

            btnEliminarProducto.Visible = false;
            btnCancelarProducto.Visible = false;
            btnRegistrarProducto.Visible = false;
            btnActualizarProducto.Visible = false;
            btnEditarProducto.Visible = false;

            cbCategoriaProducto.DataSource = registroRepositoryCAT.MostrarCategorias();
            cbCategoriaProducto.DisplayMember = "NOMBRECATEGORIA";
            cbCategoriaProducto.ValueMember = "ID_CATEGORIA";
            cbCategoriaProducto.DropDownStyle = ComboBoxStyle.DropDownList;


            cbSaborProducto.DataSource = repositorioSabor.ObtenerSabores();
            cbSaborProducto.DisplayMember = "NOMBRESABOR";
            cbSaborProducto.ValueMember = "ID_SABOR";
            cbSaborProducto.DropDownStyle = ComboBoxStyle.DropDownList;



            cbRellenoProducto.DataSource = registroRepositoryRelleno.ObtenerListaRelleno();
            cbRellenoProducto.DisplayMember = "NOMBRERELLENO";
            cbRellenoProducto.ValueMember = "ID_RELLENO";
            cbRellenoProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            cbBanoProducto.DataSource = registroRepositoryBano.ObtenerListaBano();
            cbBanoProducto.DisplayMember = "NOMBREBANO";
            cbBanoProducto.ValueMember = "ID_BANO";
            cbBanoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void grbDatosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            cbCategoriaProducto.Text = "";
            cbSaborProducto.Text = "";
            cbRellenoProducto.Text = "";
            cbBanoProducto.Text = "";
            txtCantidad.Text = "";
            txtLibra.Text = "";
            txtNombreProducto.Text = "";


            dgvDatos.ClearSelection();
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresarProducto_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;

                cbCategoriaProducto.SelectedValue = ListProductosTemp[indice].NOMBRECATEGORIA.ToString();
                cbRellenoProducto.SelectedValue = ListProductosTemp[indice].NOMBRERELLENO.ToString();
                cbSaborProducto.SelectedValue = ListProductosTemp[indice].NOMBRESABOR.ToString();
                cbBanoProducto.SelectedValue = ListProductosTemp[indice].NOMBREBANO.ToString();
                txtNombreProducto.Text = ListProductosTemp[indice].NOMBREPRODUCTO.ToString();
                txtLibra.Text = ListProductosTemp[indice].LIBRAS.ToString();
                txtCantidad.Text = ListProductosTemp[indice].CANTIDAD.ToString();


                cbCategoriaProducto.Enabled = false;
                cbRellenoProducto.Enabled = false;
                cbSaborProducto.Enabled = false;
                cbBanoProducto.Enabled = false;
                txtNombreProducto.Enabled = false;
                txtLibra.Enabled = false;
                txtCantidad.Enabled = false;
                btnEditarProducto.Enabled = true;
                btnEditarProducto.Visible = true;
            }
        }

        private void cbRellenoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
