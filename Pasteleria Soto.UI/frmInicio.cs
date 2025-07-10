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
            this.Hide();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            PantallaRegistro pantallaregistro = new PantallaRegistro();
            pantallaregistro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            PantallaListaPedidosVigentes pantallaListaPedidosVigentes = new PantallaListaPedidosVigentes();
            pantallaListaPedidosVigentes.Show();
        }

        private void btnSabor_Click(object sender, EventArgs e)
        {
            PantallaProductoPersonalizado pantallaProductoPersonalizado = new PantallaProductoPersonalizado();
            pantallaProductoPersonalizado.Show();
            this.Hide();
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
            this.Hide();
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
            PantallaOpciones pantallabaño = new PantallaOpciones();
            pantallabaño.Show();
            this.Hide();
        }

        private void btnDetallePedido_Click(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PantallaDetallePedido pantallaDetallePedido = new PantallaDetallePedido();
            pantallaDetallePedido.Show();
            this.Hide();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            PantallaHistorialVenta PantallaHistorialVenta = new PantallaHistorialVenta();
            PantallaHistorialVenta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaProveedores pantallaproveedores = new PantallaProveedores();
            pantallaproveedores.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PantallaListaPedidosVigentes pantallaListaPedidosVigentes = new PantallaListaPedidosVigentes();
            pantallaListaPedidosVigentes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaCompra pantallacompra = new PantallaCompra();
            pantallacompra.Show();
            this.Hide();
        }
    }
}
