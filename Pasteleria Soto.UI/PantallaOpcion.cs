using PantallasProyecto.DAL;
using PasteleriaSoto.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaCategoria : Form
    {
        private RegistroRepositoryCAT _registroRepositorioCAT;
        List<Categoria> ListaCategoriasTemp = new List<Categoria>();
        private int indice;
        int idCategoriaSeleccionada;
        public PantallaCategoria()
        {
            InitializeComponent();
            _registroRepositorioCAT = new RegistroRepositoryCAT();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PantallaCategoria_Load(object sender, EventArgs e)
        {
            txtIdCat.Enabled = false;
            btnEditarCategoria.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnEliminarCategoria.Visible = false;
            btnCancelarCategoria.Visible = false;
            btnRegistrar.Visible = false;
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpCategoria_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.NOMBRECATEGORIA = txtNombreCat.Text;
            categoria.DESCRIPCION = txtUnidadDeMedida.Text;

            ListaCategoriasTemp.Add(categoria);

            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = ListaCategoriasTemp;

            txtNombreCat.Clear();
            txtUnidadDeMedida.Clear();

            btnRegistrar.Visible = true;
            btnCancelarCategoria.Visible = true;
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnEliminarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnCancelarCategoria.Visible = false;

            if (ListaCategoriasTemp.Count == 0)
                return;

            try
            {
                _registroRepositorioCAT.RegistrarCategorias(ListaCategoriasTemp);

                ListaCategoriasTemp.Clear();
                dgvCategoria.DataSource = null;


            }
            catch (Exception)
            {

            }
        }



        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            btnCancelarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnEliminarCategoria.Visible = false;
            btnRegistrar.Visible = false;

            if (idCategoriaSeleccionada > 0)
            {
                Categoria categoria = new Categoria();
                categoria.ID_CATEGORIA = idCategoriaSeleccionada; 
                categoria.NOMBRECATEGORIA = txtNombreCat.Text;
                categoria.DESCRIPCION = txtUnidadDeMedida.Text;

                _registroRepositorioCAT.ActualizarCategoria(categoria);

               
                dgvCategoria.DataSource = null;
                ListaCategoriasTemp.Clear();
                ListaCategoriasTemp.AddRange(_registroRepositorioCAT.MostrarCategorias());
                dgvCategoria.DataSource = ListaCategoriasTemp;
                btnActualizarCategoria.Visible = false;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoría antes de actualizar.");
            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {

            btnActualizarCategoria.Visible = false;
            btnEditarCategoria.Visible = false;
            btnRegistrar.Visible = false;
            btnCancelarCategoria.Visible = false;

            var ID_CATEGORIA = ListaCategoriasTemp[indice].ID_CATEGORIA;

            _registroRepositorioCAT.EliminarCategoria(ID_CATEGORIA);


            dgvCategoria.DataSource = null;
            ListaCategoriasTemp.Clear();
            ListaCategoriasTemp.AddRange(_registroRepositorioCAT.MostrarCategorias());
            dgvCategoria.DataSource = ListaCategoriasTemp;
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {

            btnEditarCategoria.Visible = true;
            btnActualizarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            btnCancelarCategoria.Enabled = false;

            dgvCategoria.DataSource = null;
            ListaCategoriasTemp.Clear();
            ListaCategoriasTemp.AddRange(_registroRepositorioCAT.MostrarCategorias());
            dgvCategoria.DataSource = ListaCategoriasTemp;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            txtIdCat.Enabled = false;
            txtNombreCat.Enabled = true;
            txtUnidadDeMedida.Enabled = true;
            btnEliminarCategoria.Visible = false;
            btnActualizarCategoria.Visible = true;
            btnCancelarCategoria.Visible = true;
            btnActualizarCategoria.Enabled = true;
            btnCancelarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;

        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            txtIdCat.Clear();
            txtNombreCat.Clear();
            txtUnidadDeMedida.Clear();


            txtIdCat.Enabled = false;
            txtNombreCat.Enabled = true;
            txtUnidadDeMedida.Enabled = true;


            btnEditarCategoria.Visible = false;
            btnEliminarCategoria.Visible = false;
            btnActualizarCategoria.Visible = false;
            btnCancelarCategoria.Visible = false;

        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                idCategoriaSeleccionada = ListaCategoriasTemp[indice].ID_CATEGORIA;

                txtNombreCat.Text = ListaCategoriasTemp[indice].NOMBRECATEGORIA.ToString();
                txtUnidadDeMedida.Text = ListaCategoriasTemp[indice].DESCRIPCION.ToString();

                btnEditarCategoria.Visible = true;
                btnEditarCategoria.Enabled = true;
                btnEliminarCategoria.Visible = true;
                btnEliminarCategoria.Enabled = true;


                txtIdCat.Enabled = false;
                txtNombreCat.Enabled = false;
                txtUnidadDeMedida.Enabled = false;


                MessageBox.Show("ID seleccionado: " + idCategoriaSeleccionada); 
            }

        }

        private void btnRegresarCategoria_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }
    }
}
