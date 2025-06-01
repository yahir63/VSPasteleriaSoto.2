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
            producto.DESCRIPCION = txtUnidadMedida.Text;
            producto.ID_CATEGORIA = Convert.ToInt32(cbCategoriaProducto.SelectedValue);
            producto.UNIDADDEMEDIDA = Convert.ToInt32(txtUnidadMedida.Text);
            producto.PRODUCTOBASE = txtProductoBase.Text;
            producto.CANTIDAD = int.Parse(txtCantidad.Text);
            producto.TAMAÑO = int.Parse(txtTamano.Text);


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
       
            txtCantidad.Enabled = true;
            txtUnidadMedida.Enabled = true;
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
            producto.DESCRIPCION = txtDescripcion.Text;
            producto.PRODUCTOBASE = txtCantidad.Text;
            producto.UNIDADDEMEDIDA = int.Parse(txtUnidadMedida.Text);
            producto.ID_CATEGORIA = ((Categoria)cbCategoriaProducto.SelectedItem).ID_CATEGORIA;
            producto.UNIDADDEMEDIDA = int.Parse(txtUnidadMedida.Text);
            producto.TAMAÑO = decimal.Parse(txtTamano.Text);

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

         
        }

        private void EleccionProducto_Load(object sender, EventArgs e)
        {
            cbCategoriaProducto.SelectedIndex = -1;
 

            btnEliminarProducto.Visible = false;
            btnCancelarProducto.Visible = false;
            btnRegistrarProducto.Visible = false;
            btnActualizarProducto.Visible = false;
            btnEditarProducto.Visible = false;

            cbCategoriaProducto.DataSource = registroRepositoryCAT.MostrarCategorias();
            cbCategoriaProducto.DisplayMember = "NOMBRECATEGORIA";
            cbCategoriaProducto.ValueMember = "ID_CATEGORIA";
            cbCategoriaProducto.DropDownStyle = ComboBoxStyle.DropDownList;


      

            
        }

        private void grbDatosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtUnidadMedida.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            txtProductoBase.Text = "";
            cbCategoriaProducto.Text = "";
            txtTamano.Text = "";


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
                txtNombreProducto.Text = ListProductosTemp[indice].NOMBREPRODUCTO.ToString();
                txtDescripcion.Text = ListProductosTemp[indice].DESCRIPCION.ToString();
                txtProductoBase.Text = ListProductosTemp[indice].PRODUCTOBASE.ToString();
                txtUnidadMedida.Text = ListProductosTemp[indice].UNIDADDEMEDIDA.ToString();
                txtCantidad.Text = ListProductosTemp[indice].CANTIDAD.ToString();
                txtTamano.Text = ListProductosTemp[indice].TAMAÑO.ToString();


                cbCategoriaProducto.Enabled = false;
          
               
                txtNombreProducto.Enabled = false;
                txtUnidadMedida.Enabled = false;
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
