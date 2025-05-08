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

        RegistroRepositoryRelleno _registroRepositorio = new RegistroRepositoryRelleno();
        private int indice;
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
            Relleno relleno = new Relleno();

            relleno.NOMBRERELLENO = txtRelleno.Text;
            relleno.DESCRIPCION = txtDescripRelleno.Text;


            _registroRepositorio.ActualizarRelleno(relleno);


            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorio.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnAgregarRelleno_Click(object sender, EventArgs e)
        {
            Relleno relleno = new Relleno();

            relleno.NOMBRERELLENO = txtRelleno.Text;
            relleno.DESCRIPCION = txtDescripRelleno.Text;


            ListaRellenosTemp.Add(relleno);

            dgvRelleno.DataSource = null;
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnVerRelleno_Click(object sender, EventArgs e)
        {
            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorio.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnRegistrarRelleno_Click(object sender, EventArgs e)
        {
            PantallaRelleno eleccion = new PantallaRelleno();
            eleccion.Show();
            this.Hide();
            _registroRepositorio.RegistrarRelleno(ListaRellenosTemp);
            ListaRellenosTemp.Clear();
            dgvRelleno.DataSource = null;



        }

        private void btnEditarRelleno_Click(object sender, EventArgs e)
        {
            int ID_RELLENO = Convert.ToInt32(dgvRelleno.CurrentRow.Cells["ID_RELLENO"].Value);


            string nuevoNombre = txtRelleno.Text;
            string nuevaDescripcion = txtDescripRelleno.Text;


            _registroRepositorio.EditarRelleno(ID_RELLENO, nuevoNombre, nuevaDescripcion);
            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorio.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;

            txtRelleno.Enabled = true;
            txtDescripRelleno.Enabled = true;


        }

        private void btnEliminarRelleno_Click(object sender, EventArgs e)
        {
            var ID_RELLENO = int.Parse(txtRelleno.Text);

            _registroRepositorio.EliminarRelleno(ID_RELLENO);


            dgvRelleno.DataSource = null;
            ListaRellenosTemp.Clear();
            ListaRellenosTemp.AddRange(_registroRepositorio.ObtenerListaRelleno());
            dgvRelleno.DataSource = ListaRellenosTemp;
        }

        private void btnCancelarRelleno_Click(object sender, EventArgs e)
        {
            txtRelleno.Text = "";
            txtDescripRelleno.Text = "";
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

                txtRelleno.Text = ListaRellenosTemp[indice].NOMBRERELLENO.ToString();
                txtDescripRelleno.Text = ListaRellenosTemp[indice].DESCRIPCION.ToString();

                // aqui habilito los botones
                btnEditarRelleno.Visible = true;
                btnEditarRelleno.Enabled = true;
                btnEliminarRelleno.Visible = true;
                btnEliminarRelleno.Enabled = true;


               
                txtRelleno.Enabled = false;
                txtDescripRelleno.Enabled = false;
            }
        }

        public event EventHandler RellenoAgregado;
    }

}
