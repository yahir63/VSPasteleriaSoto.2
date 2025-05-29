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
using PasteleriaSoto.BLL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaRelleno : Form
    {
        List<Relleno> ListaRellenosTemp = new List<Relleno>();

        RegistroRepositoryRelleno _registroRepositorioRelleno = new RegistroRepositoryRelleno();
        private int indice;
        int idRellenoSeleccionado;
        public PantallaRelleno()
        {
            InitializeComponent();
        }

        private void btnMnzcliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizarRelleno_Click(object sender, EventArgs e)
        {
            if (idRellenoSeleccionado > 0) // Verifica que el ID está guardado
            {
                Relleno relleno = new Relleno();
                relleno.ID_RELLENO = idRellenoSeleccionado; // Usa el ID guardado
                relleno.NOMBRERELLENO = txtRelleno.Text;
                relleno.DESCRIPCION = txtDescripRelleno.Text;
                relleno.PRECIORELLENO = txtPrecioRelleno.Text;

                _registroRepositorioRelleno.ActualizarRelleno(relleno);

                // Refrescar DataGridView
                dgvRelleno.DataSource = null;
                ListaRellenosTemp.Clear();
                ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
                dgvRelleno.DataSource = ListaRellenosTemp;
            }
            else
            {
                MessageBox.Show("Selecciona un relleno antes de actualizar.");
            }

        }

        private void btnAgregarRelleno_Click(object sender, EventArgs e)
        {
            Relleno relleno = new Relleno();

            relleno.NOMBRERELLENO = txtRelleno.Text;
            relleno.DESCRIPCION = txtDescripRelleno.Text;
            relleno.PRECIORELLENO = txtPrecioRelleno.Text; 


            ListaRellenosTemp.Add(relleno);

            dgvRelleno.DataSource = null;
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnVerRelleno_Click(object sender, EventArgs e)
        {
            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnRegistrarRelleno_Click(object sender, EventArgs e)
        {
            PantallaRelleno eleccion = new PantallaRelleno();
            eleccion.Show();
            this.Hide();
            _registroRepositorioRelleno.RegistrarRelleno(ListaRellenosTemp);
            ListaRellenosTemp.Clear();
            dgvRelleno.DataSource = null;



        }

        private void btnEditarRelleno_Click(object sender, EventArgs e)
        {
            int ID_RELLENO = Convert.ToInt32(dgvRelleno.CurrentRow.Cells["ID_RELLENO"].Value);


            string nuevoNombre = txtRelleno.Text;
            string nuevaDescripcion = txtDescripRelleno.Text;
            string precioRelleno = txtPrecioRelleno.Text;
            


            _registroRepositorioRelleno.EditarRelleno(ID_RELLENO, nuevoNombre, nuevaDescripcion, precioRelleno);
            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;

            txtRelleno.Enabled = true;
            txtDescripRelleno.Enabled = true;
            txtPrecioRelleno.Enabled = true;


        }

        private void btnEliminarRelleno_Click(object sender, EventArgs e)
        {
            var ID_RELLENO = ListaRellenosTemp[indice].ID_RELLENO;

            _registroRepositorioRelleno.EliminarRelleno(ID_RELLENO);


            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorioRelleno.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnCancelarRelleno_Click(object sender, EventArgs e)
        {
            txtRelleno.Text = "";
            txtDescripRelleno.Text = "";
            txtPrecioRelleno.Text = "";
            dgvRelleno.ClearSelection();
        }

        private void btnRegresarRelleno_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }

        private void PantallaRelleno_Load(object sender, EventArgs e)
        {

        }

        private void dgvRelleno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                idRellenoSeleccionado = ListaRellenosTemp[indice].ID_RELLENO;

                txtRelleno.Text = ListaRellenosTemp[indice].NOMBRERELLENO.ToString();
                txtDescripRelleno.Text = ListaRellenosTemp[indice].DESCRIPCION.ToString();
                txtPrecioRelleno.Text = ListaRellenosTemp[indice].PRECIORELLENO.ToString();


                btnEditarRelleno.Visible = true;
                btnEditarRelleno.Enabled = true;
                btnEliminarRelleno.Visible = true;
                btnEliminarRelleno.Enabled = true;
                
                txtRelleno.Enabled = false;
                txtDescripRelleno.Enabled = false;
                txtPrecioRelleno.Enabled = false;

                MessageBox.Show("ID seleccionado: " + idRellenoSeleccionado); 
            }

        }


    }

}
