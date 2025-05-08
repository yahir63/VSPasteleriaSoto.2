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
    public partial class PantallaDetallePedido : Form
    {
        public PantallaDetallePedido()
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
    }
}
