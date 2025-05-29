namespace Pasteleria_Soto.UI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            PantallaRegistro registro = new PantallaRegistro();
            registro.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grbInicio_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {

        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMnzInicio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            PantallaUsuarioNuevo pantallaUsuarioNuevo = new PantallaUsuarioNuevo();
            pantallaUsuarioNuevo.Show();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            PantallaRegistro pantallaregistro = new PantallaRegistro();
            pantallaregistro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {


            PantallaRelleno nuevapantallarelleno = new PantallaRelleno();
            nuevapantallarelleno.Show();
        }

        private void btnSabor_Click(object sender, EventArgs e)
        {


            PantallaSabor nuevapantallasabor = new PantallaSabor();
            nuevapantallasabor.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            PantallaCategoria nuevapantallacategoria = new PantallaCategoria();
            nuevapantallacategoria.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            EleccionProducto nuevoeleccionproducto = new EleccionProducto();
            nuevoeleccionproducto.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBaño_Click(object sender, EventArgs e)
        {
            PantallaBaño pantallabaño = new PantallaBaño();
            pantallabaño.Show();
        }

        private void btnDetallePedido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PantallaDetallePedido pantallaDetallePedido = new PantallaDetallePedido();
            pantallaDetallePedido.Show();

        }
    }
}
