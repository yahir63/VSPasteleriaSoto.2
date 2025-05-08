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
using Microsoft.Identity.Client;
using PantallasProyecto.DAL;
using PasteleriaSoto.BLL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaSabor : Form
    {
        private List<Sabor> ListaTemporalSabores = new List<Sabor>();
        private RepositorioSabor _saborRepo = new RepositorioSabor();
        private int indice;
        int IdSaborSeleccionado = -1;



        public PantallaSabor()
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

        private void btnEditarSabor_Click(object sender, EventArgs e)
        {

        }
          
        //Bton para Actuzalizar el sabor
        private void btnActualizarSabor_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtSabor.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa valores válidos para el sabor y la descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que hay un ID seleccionado
                if (IdSaborSeleccionado == 0) // Asegúrate de que el tipo de dato coincida
                {
                    MessageBox.Show("Debes seleccionar un sabor antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear instancia de Sabor con el ID seleccionado
                Sabor sabor = new Sabor
                {
                    ID_SABOR = IdSaborSeleccionado,  // Aquí pasamos el ID capturado
                    NOMBRESABOR = txtSabor.Text.Trim(),
                    DESCRIPCION = txtDescripcion.Text.Trim()
                };

                // Actualizar sabor en la base de datos
                _saborRepo.ActualizarSabor(sabor);

                // Refrescar la lista en la tabla
                dgvSabor.DataSource = null;
                ListaTemporalSabores.Clear();
                ListaTemporalSabores.AddRange(_saborRepo.ObtenerSabores());
                dgvSabor.DataSource = ListaTemporalSabores;

                MessageBox.Show("¡Sabor actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el sabor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSabor_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void dgvSabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaSabor_Load(object sender, EventArgs e)
        {
             
        }

        private void btnVerSabor_Click(object sender, EventArgs e)
        {
            dgvSabor.DataSource = null;
            ListaTemporalSabores.Clear();
            ListaTemporalSabores.AddRange(_saborRepo.ObtenerSabores());
            dgvSabor.DataSource = ListaTemporalSabores;
            btnEditarSabor.Visible = true;
            btnEliminarSabor.Visible = true;
            btnActualizarSabor.Visible = true;
            btnCancelarSabor.Visible = true;

        }

        private void btnAgregarSabor_Click(object sender, EventArgs e)
        {
            Sabor sabor = new Sabor();

            sabor.NOMBRESABOR = txtSabor.Text;
            sabor.DESCRIPCION = txtDescripcion.Text;


            ListaTemporalSabores.Add(sabor);

            dgvSabor.DataSource = null;
            dgvSabor.DataSource = ListaTemporalSabores;
            btnRegistrarSabor.Visible = true;

        }

        private void btnRegistrarSabor_Click(object sender, EventArgs e)
        {
            _saborRepo.RegistrarSabor(ListaTemporalSabores);
            ListaTemporalSabores.Clear();
            dgvSabor.DataSource = null;

        }

      

        private void btnEliminarSabor_Click(object sender, EventArgs e)
        {
            if (IdSaborSeleccionado != -1)
            {
                _saborRepo.EliminarSabor(IdSaborSeleccionado);

                dgvSabor.DataSource = null;
                ListaTemporalSabores.Clear();
                ListaTemporalSabores.AddRange(_saborRepo.ObtenerSabores());
                dgvSabor.DataSource = ListaTemporalSabores;

                // Limpiar después de eliminar
                txtSabor.Clear();
                txtDescripcion.Clear();
                IdSaborSeleccionado = -1;
            }
            else
            {
                MessageBox.Show("Selecciona un sabor haciendo doble clic primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelarSabor_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRegresarSabor_Click(object sender, EventArgs e)
        {
            frmInicio nuevapantallainicio = new frmInicio();
            nuevapantallainicio.Show();
        }

        private void dgvSabor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0 && indice < ListaTemporalSabores.Count)
            {
                IdSaborSeleccionado = ListaTemporalSabores[indice].ID_SABOR; // Aquí tomas el ID real
                txtSabor.Text = ListaTemporalSabores[indice].NOMBRESABOR.ToString();
                txtDescripcion.Text = ListaTemporalSabores[indice].DESCRIPCION.ToString();
            }
            

        }

        public event EventHandler SaborAgregado;
    }
}
