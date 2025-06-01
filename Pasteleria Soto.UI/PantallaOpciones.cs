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
            btnRegistrarBano.Enabled = true;    
        }

        private void btnVerBano_Click(object sender, EventArgs e)
        {
            btnEditarBano.Visible = false;
            btnActualizarBano.Enabled = false;
            btnEliminarBano.Enabled = false;
            btnCancelarBano.Enabled = true;

            dgvOpciones.DataSource = null;
            ListaOpcionesTemp.Clear();
            ListaOpcionesTemp.AddRange(_opcionesRepository.ObtenerListaOpciones());
            dgvOpciones.DataSource = ListaOpcionesTemp;

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
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            btnEliminarBano.Visible = true;
            btnEliminarBano.Enabled = false;
            btnActualizarBano.Visible = true;
            btnCancelarBano.Visible = true;
            btnActualizarBano.Enabled = true;
            btnCancelarBano.Enabled = true;
            txtUnidadDeMedida.Enabled = true;
            txtUnidadDeMedida.Enabled = true;
            }

        private void btnActualizarBano_Click(object sender, EventArgs e)
        {


            if (idOpcionSeleccionada > 0)
            {
                Opciones opc = new Opciones();
                opc.ID_OPCIONES = idOpcionSeleccionada;
                opc.NOMBRE_OPCION = txtNombre.Text;
                opc.DESCRIPCION = txtDescripcion.Text;
                opc.PRECIO = Convert.ToDouble(txtPrecioDeVenta.Text);

                _opcionesRepository.ActualizarOpciones(opc);

                dgvOpciones.DataSource = null;
                ListaOpcionesTemp.Clear();                                                    
                ListaOpcionesTemp.AddRange(_opcionesRepository.ObtenerListaOpciones());
                dgvOpciones.DataSource = ListaOpcionesTemp;
            }
            else
            {
                MessageBox.Show("Debes seleccionar un baño antes de actualizar.");
            }

        }

        private void btnEliminarBano_Click(object sender, EventArgs e)
        {
            var ID_OPCION = ListaOpcionesTemp[indice].ID_OPCIONES;

            _opcionesRepository.EliminarOpciones(ID_OPCION);


            dgvOpciones.DataSource = null;
            ListaOpcionesTemp.Clear();
            ListaOpcionesTemp.AddRange(_opcionesRepository.ObtenerListaOpciones());
            dgvOpciones.DataSource = ListaOpcionesTemp;
        }

        private void btnCancelarBano_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioDeVenta.Clear();
            txtUnidadDeMedida.Clear();
            btnRegistrarBano.Enabled = false;
            btnEditarBano.Enabled = false;  
            btnActualizarBano.Enabled = false;
            btnEliminarBano.Enabled = false;
            btnCancelarBano.Enabled = true;
            dgvOpciones.ClearSelection();
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
                idOpcionSeleccionada = ListaOpcionesTemp[indice].ID_OPCIONES;

                txtNombre.Text = ListaOpcionesTemp[indice].NOMBRE_OPCION.ToString();
                txtDescripcion.Text = ListaOpcionesTemp[indice].DESCRIPCION.ToString();
                txtPrecioDeVenta.Text = ListaOpcionesTemp[indice].PRECIO.ToString();

                MessageBox.Show("ID seleccionado: " + idOpcionSeleccionada);

                btnEditarBano.Enabled = true;
                btnActualizarBano.Enabled = false;
                btnEliminarBano.Enabled = true;
                btnCancelarBano.Enabled = true;
                btnRegistrarBano.Enabled = false;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                txtUnidadDeMedida.Enabled = false;
                btnEditarBano.Visible = true;
                
            }


        }

        private void PantallaOpciones_Load(object sender, EventArgs e)
        {
            btnRegistrarBano.Enabled = false;
            btnEditarBano.Enabled = false;
            btnActualizarBano.Enabled = false;
            btnEliminarBano.Enabled = false;
            btnCancelarBano.Enabled = true;
        }
    }
}

