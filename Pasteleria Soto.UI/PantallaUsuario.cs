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
    public partial class PantallaUsuario : Form
    {
        public PantallaUsuario()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {


            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "AdminSoto" && contrasena == "AdminSoto2025")
            {
                PantalladeCarga pantalladecarga = new PantalladeCarga();
                pantalladecarga.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos. Inténtelo de nuevo.");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '●';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PantallaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
