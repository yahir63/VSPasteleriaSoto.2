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
       
        RegistroRepositoryCAT registroRepositoryCAT = new RegistroRepositoryCAT();
  
    
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
            producto.DESCRIPCION = txtDescripcion.Text;
            producto.ID_CATEGORIA = Convert.ToInt32(cbCategoriaProducto.SelectedValue);
            producto.UNIDADDEMEDIDA = txtUnidadMedida.Text;
            producto.VOLUMEN = Convert.ToDouble(txtVolumen.Text);

            producto.TAMAÑO = txtTamano.Text;


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
            producto.ID_CATEGORIA = ((Categoria)cbCategoriaProducto.SelectedItem).ID_CATEGORIA;
            producto.UNIDADDEMEDIDA = txtUnidadMedida.Text;
            producto.VOLUMEN = Convert.ToDouble(txtVolumen.Text); 
            producto.TAMAÑO = txtTamano.Text;
            producto.PRECIO = 0;
            producto.PRECIOCOMPRA = 0;
            producto.ESTADO = true; 
            producto.StockReservado = 0;
            producto.CANTIDAD = 0;


            ListProductosTemp.Add(producto);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListProductosTemp;
            dgvDatos.Columns["ID_PRODUCTO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ESTADO"].Visible = false;
            dgvDatos.Columns["StockReservado"].Visible = false;
            dgvDatos.Columns["PRECIO"].Visible = false;
            dgvDatos.Columns["PRECIOCOMPRA"].Visible = false;
            dgvDatos.Columns["CANTIDAD"].Visible = false;

        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {

            dgvDatos.DataSource = null;
            ListProductosTemp.Clear();
            ListProductosTemp.AddRange(RepositoryPRODUCTO.ObtenerListProductosTemp());
            dgvDatos.DataSource = ListProductosTemp;

            dgvDatos.Columns["ID_PRODUCTO"].Visible = false;
            dgvDatos.Columns["ID_CATEGORIA"].Visible = false;
            dgvDatos.Columns["ESTADO"].Visible = false;


        }

        private void EleccionProducto_Load(object sender, EventArgs e)
        {
            cbCategoriaProducto.SelectedIndex = -1;
 

            btnEliminarProducto.Visible = true;
            btnCancelarProducto.Visible = true;
            btnRegistrarProducto.Visible = true;
            btnActualizarProducto.Visible = true;
            btnEditarProducto.Visible = true;

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
        
            txtUnidadMedida.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
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
            this.Hide();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;


                txtNombreProducto.Text = ListProductosTemp[indice].NOMBREPRODUCTO.ToString();
                txtDescripcion.Text = ListProductosTemp[indice].DESCRIPCION.ToString();
               
                txtUnidadMedida.Text = ListProductosTemp[indice].UNIDADDEMEDIDA.ToString();
               
                txtTamano.Text = ListProductosTemp[indice].TAMAÑO.ToString();


                cbCategoriaProducto.Enabled = false;


                txtNombreProducto.Enabled = false;
                txtUnidadMedida.Enabled = false;

                btnEditarProducto.Enabled = true;
                btnEditarProducto.Visible = true;
            }
        }

        private void cbRellenoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
