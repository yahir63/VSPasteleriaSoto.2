using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasteleriaSoto.BLL;
using PasteleriaSoto.DAL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaBaño : Form
    {
        List<Bano> ListaBanoTemp = new List<Bano>();
        int idBanoSeleccionado;

        RegistroRepositoryBaño _registroRepositorio = new RegistroRepositoryBaño();
        private int indice;
        public PantallaBaño()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarBano_Click(object sender, EventArgs e)
        {
            Bano bano = new Bano();

            bano.NOMBREBANO = txtNombreBano.Text;
            bano.DESCRIPCION = txtDescripcion.Text;
            bano.PRECIO = txtPrecio.Text;


            ListaBanoTemp.Add(bano);

            dgvBano.DataSource = null;
            dgvBano.DataSource = ListaBanoTemp;
        }

        private void btnVerBano_Click(object sender, EventArgs e)
        {
            dgvBano.DataSource = null;
            ListaBanoTemp.Clear();
            ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            dgvBano.DataSource = ListaBanoTemp;
        }

        private void btnRegistrarBano_Click(object sender, EventArgs e)
        {
            PantallaBaño eleccion = new PantallaBaño();
            eleccion.Show();
            this.Hide();
            _registroRepositorio.RegistrarBano(ListaBanoTemp);
            ListaBanoTemp.Clear();
            dgvBano.DataSource = null;
        }

        private void btnEditarBano_Click(object sender, EventArgs e)
        {
            int ID_BANO = Convert.ToInt32(dgvBano.CurrentRow.Cells["ID_BANO"].Value);


            string nuevoNombreBano = txtNombreBano.Text;
            string nuevaDescripcionBano = txtDescripcion.Text;


            _registroRepositorio.EditarBano(ID_BANO, nuevoNombreBano, nuevaDescripcionBano);
            dgvBano.DataSource = null;
            ListaBanoTemp.Clear();
            ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            dgvBano.DataSource = ListaBanoTemp;

            txtNombreBano.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnActualizarBano_Click(object sender, EventArgs e)
        {
           

            if (idBanoSeleccionado > 0)
            {
                Bano bano = new Bano();
                bano.ID_BANO = idBanoSeleccionado;
                bano.NOMBREBANO = txtNombreBano.Text;
                bano.DESCRIPCION = txtDescripcion.Text;
                bano.PRECIO = txtPrecio.Text;

                _registroRepositorio.ActualizarBano(bano);

                dgvBano.DataSource = null;
                ListaBanoTemp.Clear();
                ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
                dgvBano.DataSource = ListaBanoTemp;
            }
            else
            {
                MessageBox.Show("Debes seleccionar un baño antes de actualizar.");
            }

        }

        private void btnEliminarBano_Click(object sender, EventArgs e)
        {
            var ID_BANO = ListaBanoTemp[indice].ID_BANO;

            _registroRepositorio.EliminarBano(ID_BANO);


            dgvBano.DataSource = null;
            ListaBanoTemp.Clear();
            ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            dgvBano.DataSource = ListaBanoTemp;
        }

        private void btnCancelarBano_Click(object sender, EventArgs e)
        {
            txtNombreBano.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            dgvBano.ClearSelection();
        }

        private void btnRegresarBano_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }

        private void dgvBano_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                idBanoSeleccionado = ListaBanoTemp[indice].ID_BANO;

                txtNombreBano.Text = ListaBanoTemp[indice].NOMBREBANO.ToString();
                txtDescripcion.Text = ListaBanoTemp[indice].DESCRIPCION.ToString();
                txtPrecio.Text = ListaBanoTemp[indice].PRECIO.ToString();

                MessageBox.Show("ID seleccionado: " + idBanoSeleccionado); 
            }


        }
    }
}

