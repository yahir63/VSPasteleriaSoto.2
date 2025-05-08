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

namespace Pasteleria_Soto.UI
{
    public partial class EleccionProducto : Form
    {
        List<Producto> ListProductosTemp = new List<Producto>();
        RegistroRepositoryPRODUCTO RegistroRepositoryPRODUCTO = new RegistroRepositoryPRODUCTO();
        RegistroRepositoryRelleno registroRepositoryRelleno = new RegistroRepositoryRelleno();
        RepositorioSabor repositorioSabor = new RepositorioSabor();
        RegistroRepositoryCAT registroRepositoryCAT = new RegistroRepositoryCAT();
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
            producto.NOMBRECATEGORIA = dgvDatos.CurrentRow.Cells["NOMBRECATEGORIA"].Value.ToString();
            producto.NOMBREPRODUCTO = dgvDatos.CurrentRow.Cells["NOMBREPRODUCTO"].Value.ToString();
            producto.NOMBRESABOR = dgvDatos.CurrentRow.Cells["NOMBRESABOR"].Value.ToString();     // Nombre del sabor
            producto.NOMBRERELLENO = dgvDatos.CurrentRow.Cells["NOMBRERELLENO"].Value.ToString(); // Nombre del relleno
            producto.CANTIDAD = Convert.ToInt32(dgvDatos.CurrentRow.Cells["CANTIDAD"].Value);
            producto.LIBRAS = Convert.ToInt32(dgvDatos.CurrentRow.Cells["LIBRAS"].Value);


            RegistroRepositoryPRODUCTO.ActualizarProducto(producto);


            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RegistroRepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID_PRODUCTO = Id_Producto;

            RegistroRepositoryPRODUCTO.Eliminar(ID_PRODUCTO);


            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RegistroRepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            cbCategoriaProducto.Enabled = true;
            cbRellenoProducto.Enabled = true;
            cbSaborProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtLibra.Enabled = true;
            txtNombreProducto.Enabled = true;
            btnActualizarProducto.Enabled = true;
            btnActualizarProducto.Visible  = true;
            btnCancelarProducto.Enabled = true;
            btnCancelarProducto.Visible= true;
            btnEliminarProducto.Enabled = true;
            btnEliminarProducto.Visible = true;



            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RegistroRepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            EleccionProducto eleccion = new EleccionProducto();
            eleccion.Show();
            this.Hide();
            RegistroRepositoryPRODUCTO.RegistrarProductos(ListProductosTemp);
            ListProductosTemp.Clear();
            dgvDatos.DataSource = null;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            btnRegistrarProducto.Visible = true;
            btnRegistrarProducto.Enabled = true;
            Producto producto = new Producto();

            producto.NOMBREPRODUCTO = txtNombreProducto.Text;
            producto.CANTIDAD = int.Parse(txtCantidad.Text);
            producto.LIBRAS = int.Parse(txtLibra.Text);
            producto.ID_CATEGORIA = ((Categoria)cbCategoriaProducto.SelectedItem).ID_CATEGORIA;
            producto.ID_SABOR = ((Sabor)cbSaborProducto.SelectedItem).ID_SABOR;
            producto.ID_RELLENO = ((Relleno)cbRellenoProducto.SelectedItem).ID_RELLENO;

            ListProductosTemp.Add(producto);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListProductosTemp;

            dgvDatos.Columns["ID_SABOR"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ID_DECORACION"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;


        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RegistroRepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;

            dgvDatos.Columns["ID_SABOR"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ID_DECORACION"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ID_RELLENO"].Visible = false;
        }

        private void EleccionProducto_Load(object sender, EventArgs e)
        {
            btnEliminarProducto.Visible = false;
            btnCancelarProducto.Visible = false;
            btnRegistrarProducto.Visible = false;
            btnActualizarProducto.Visible = false;
            btnEditarProducto.Visible = false;

            cbCategoriaProducto.DataSource = registroRepositoryCAT.MostrarCategorias();
            cbCategoriaProducto.DisplayMember = "NOMBRECATEGORIA";
            cbCategoriaProducto.ValueMember = "ID_CATEGORIA";

            cbSaborProducto.DataSource = repositorioSabor.ObtenerSabores();
            cbSaborProducto.DisplayMember = "NOMBRESABOR";
            cbSaborProducto.ValueMember = "ID_SABOR";
            

            cbRellenoProducto.DataSource = registroRepositoryRelleno.ObtenerListaRelleno();
            cbRellenoProducto.DisplayMember = "NOMBRERELLENO";
            cbRellenoProducto.ValueMember = "ID_RELLENO";
        }

        private void grbDatosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            cbCategoriaProducto.Text = "";
            cbSaborProducto.Text = "";
            cbRellenoProducto.Text = "";
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

                cbCategoriaProducto.Text = ListProductosTemp[indice].NOMBRECATEGORIA.ToString();
                cbRellenoProducto.Text = ListProductosTemp[indice].NOMBRERELLENO.ToString();
                cbSaborProducto.Text = ListProductosTemp[indice].NOMBRESABOR.ToString();
                txtNombreProducto.Text = ListProductosTemp[indice].NOMBREPRODUCTO.ToString();
                txtLibra.Text = ListProductosTemp[indice].LIBRAS.ToString();
                txtCantidad.Text = ListProductosTemp[indice].CANTIDAD.ToString();


                cbCategoriaProducto.Enabled = false;
                cbRellenoProducto.Enabled = false;
                cbSaborProducto.Enabled = false;
                txtNombreProducto.Enabled = false;
                txtLibra.Enabled = false;
                txtCantidad.Enabled = false;
                btnEditarProducto.Enabled = true;
                btnEditarProducto.Visible = true;
            }
        }
    }
}
