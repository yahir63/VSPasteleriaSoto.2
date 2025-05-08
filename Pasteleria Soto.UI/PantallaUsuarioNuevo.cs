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
using PasteleriaSoto.BLL;
using PasteleriaSoto.DAL;

namespace Pasteleria_Soto.UI
{
    public partial class PantallaUsuarioNuevo : Form
    {
        List<Usuario> ListaUsuarioNuevoTemp = new List<Usuario>();
        RegistroRepositoryNuevoUsuario _registroRepositorio = new RegistroRepositoryNuevoUsuario();
        public PantallaUsuarioNuevo()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NOMBREUSUARIO=txtNombreUsuario. Text;
            usuario.CLAVE = txtClaveUsuario.Text;       

           
            ListaUsuarioNuevoTemp.Add(usuario);
            _registroRepositorio.RegistrarUsuario(ListaUsuarioNuevoTemp);
           
            ListaUsuarioNuevoTemp.Clear();

            this.Hide();


        }

        private void PantallaUsuarioNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
    

