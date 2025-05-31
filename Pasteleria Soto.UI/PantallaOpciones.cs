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
using PasteleriaSoto.DAL.Entities;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaOpciones : Form
    {
        private OpcionesRepository _opcionesRepository;

        List<Opciones> ListaOpcionesTemp = new List<Opciones>();
        private int indice;
        int idOpcionSeleccionada;
        public PantallaOpciones()
        {
            InitializeComponent();

            _opcionesRepository = new OpcionesRepository();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarBano_Click(object sender, EventArgs e)
        {
            Opciones opcion = new Opciones();

            opcion.NOMBRE_OPCION = txtNombre.Text;
            opcion.DESCRIPCION = txtDescripcion.Text;
            opcion.UNIDADMEDIDA = txtUnidadDeMedida.Text;
            opcion.PRECIO = Convert.ToDouble(txtPrecioDeVenta.Text);

            ListaOpcionesTemp.Add(opcion);

            dgvOpciones.DataSource = null;
            dgvOpciones.DataSource = ListaOpcionesTemp;

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioDeVenta.Clear();
        }

        private void btnVerBano_Click(object sender, EventArgs e)
        {
   

        }

        private void btnRegistrarBano_Click(object sender, EventArgs e)
        {


            if (ListaOpcionesTemp.Count == 0)
                return;

            try
            {
                _opcionesRepository.RegistrarOpcion(ListaOpcionesTemp);

                ListaOpcionesTemp.Clear();
                dgvOpciones.DataSource = null;


            }
            catch (Exception)
            {

            }

        }

        private void btnEditarBano_Click(object sender, EventArgs e)
        {
            //int ID_BANO = Convert.ToInt32(dgvOpciones.CurrentRow.Cells["ID_BANO"].Value);


            //string nuevoNombreBano = txtNombre.Text;
            //string nuevaDescripcionBano = txtDescripcion.Text;


            //_registroRepositorio.EditarBano(ID_BANO, nuevoNombreBano, nuevaDescripcionBano);
            //dgvOpciones.DataSource = null;
            //ListaBanoTemp.Clear();
            //ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            //dgvOpciones.DataSource = ListaBanoTemp;

            //txtNombre.Enabled = true;
            //txtDescripcion.Enabled = true;
        }

        private void btnActualizarBano_Click(object sender, EventArgs e)
        {


            //if (idBanoSeleccionado > 0)
            //{
            //    Bano bano = new Bano();
            //    bano.ID_BANO = idBanoSeleccionado;
            //    bano.NOMBREBANO = txtNombre.Text;
            //    bano.DESCRIPCION = txtDescripcion.Text;
            //    bano.PRECIO = txtPrecioDeVenta.Text;

            //    _registroRepositorio.ActualizarBano(bano);

            //    dgvOpciones.DataSource = null;
            //    ListaBanoTemp.Clear();
            //    ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            //    dgvOpciones.DataSource = ListaBanoTemp;
            //}
            //else
            //{
            //    MessageBox.Show("Debes seleccionar un baño antes de actualizar.");
            //}

        }

        private void btnEliminarBano_Click(object sender, EventArgs e)
        {
            //var ID_BANO = ListaBanoTemp[indice].ID_BANO;

            //_registroRepositorio.EliminarBano(ID_BANO);


            //dgvOpciones.DataSource = null;
            //ListaBanoTemp.Clear();
            //ListaBanoTemp.AddRange(_registroRepositorio.ObtenerListaBano());
            //dgvOpciones.DataSource = ListaBanoTemp;
        }

        private void btnCancelarBano_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioDeVenta.Text = "";
            dgvOpciones.ClearSelection();
        }

        private void btnRegresarBano_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }

        private void dgvBano_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    indice = e.RowIndex;
            //    idBanoSeleccionado = ListaBanoTemp[indice].ID_BANO;

            //    txtNombre.Text = ListaBanoTemp[indice].NOMBREBANO.ToString();
            //    txtDescripcion.Text = ListaBanoTemp[indice].DESCRIPCION.ToString();
            //    txtPrecioDeVenta.Text = ListaBanoTemp[indice].PRECIO.ToString();

            //    MessageBox.Show("ID seleccionado: " + idBanoSeleccionado);
            //}


        }

        private void PantallaOpciones_Load(object sender, EventArgs e)
        {

        }
    }
}

