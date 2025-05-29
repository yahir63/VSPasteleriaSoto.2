namespace Pasteleria_Soto.UI
{
    partial class PantallaDetallePedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDetallePedido));
            panel1 = new Panel();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            grpDatosPedido = new GroupBox();
            v = new Label();
            txtPrecioProducto = new TextBox();
            label13 = new Label();
            txtFechaEntrega = new TextBox();
            label12 = new Label();
            txtLibras = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            txtHoraEntrega = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtSubTotal = new TextBox();
            txtAdelanto = new TextBox();
            txtTotal = new TextBox();
            dgvDetallePedido = new DataGridView();
            grpDatosClientes = new GroupBox();
            txtCiudad = new TextBox();
            label11 = new Label();
            btnLimpiar = new Button();
            btnBuscarCliente = new Button();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtNombreCliente = new TextBox();
            txtTelefono = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtCedula = new TextBox();
            label8 = new Label();
            grpDetallePedido = new GroupBox();
            btnAgregarDetalle = new Button();
            btnRegresarDPedido = new Button();
            btnCancelarDPedido = new Button();
            btnEliminarDPedido = new Button();
            btnActualizarDPedido = new Button();
            btnEditarDPedido = new Button();
            btnRegistrarDPedido = new Button();
            cbProductos = new ComboBox();
            cbProductosPersonalizados = new ComboBox();
            label1 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            grpDatosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            grpDatosClientes.SuspendLayout();
            grpDetallePedido.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 50);
            panel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.LightSeaGreen;
            label16.Location = new Point(115, 12);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 42;
            label16.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1063, 12);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(22, 22);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 40;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1021, 12);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(28, 22);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 40;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // grpDatosPedido
            // 
            grpDatosPedido.Controls.Add(label14);
            grpDatosPedido.Controls.Add(label1);
            grpDatosPedido.Controls.Add(cbProductosPersonalizados);
            grpDatosPedido.Controls.Add(cbProductos);
            grpDatosPedido.Controls.Add(v);
            grpDatosPedido.Controls.Add(txtPrecioProducto);
            grpDatosPedido.Controls.Add(label13);
            grpDatosPedido.Controls.Add(txtFechaEntrega);
            grpDatosPedido.Controls.Add(label12);
            grpDatosPedido.Controls.Add(txtLibras);
            grpDatosPedido.Controls.Add(label3);
            grpDatosPedido.Controls.Add(txtCantidad);
            grpDatosPedido.Controls.Add(txtHoraEntrega);
            grpDatosPedido.Controls.Add(label2);
            grpDatosPedido.Location = new Point(31, 177);
            grpDatosPedido.Margin = new Padding(3, 2, 3, 2);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Padding = new Padding(3, 2, 3, 2);
            grpDatosPedido.Size = new Size(1054, 211);
            grpDatosPedido.TabIndex = 1;
            grpDatosPedido.TabStop = false;
            grpDatosPedido.Text = "Datos del Pedido";
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(341, 91);
            v.Name = "v";
            v.Size = new Size(40, 15);
            v.TabIndex = 25;
            v.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(341, 108);
            txtPrecioProducto.Margin = new Padding(3, 2, 3, 2);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(322, 23);
            txtPrecioProducto.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 91);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 23;
            label13.Text = "Libra";
            // 
            // txtFechaEntrega
            // 
            txtFechaEntrega.Location = new Point(18, 174);
            txtFechaEntrega.Margin = new Padding(3, 2, 3, 2);
            txtFechaEntrega.Name = "txtFechaEntrega";
            txtFechaEntrega.Size = new Size(309, 23);
            txtFechaEntrega.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 157);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 20;
            label12.Text = "Fecha de Entrega";
            // 
            // txtLibras
            // 
            txtLibras.Location = new Point(18, 108);
            txtLibras.Margin = new Padding(3, 2, 3, 2);
            txtLibras.Name = "txtLibras";
            txtLibras.Size = new Size(123, 23);
            txtLibras.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 91);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(170, 108);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(143, 23);
            txtCantidad.TabIndex = 8;
            // 
            // txtHoraEntrega
            // 
            txtHoraEntrega.Location = new Point(341, 174);
            txtHoraEntrega.Margin = new Padding(3, 2, 3, 2);
            txtHoraEntrega.Name = "txtHoraEntrega";
            txtHoraEntrega.Size = new Size(309, 23);
            txtHoraEntrega.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 157);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Hora de Entrega";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 142);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 18;
            label7.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 142);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 17;
            label6.Text = "Adelanto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 144);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 14;
            label4.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(18, 161);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(88, 23);
            txtSubTotal.TabIndex = 13;
            // 
            // txtAdelanto
            // 
            txtAdelanto.Location = new Point(134, 161);
            txtAdelanto.Margin = new Padding(3, 2, 3, 2);
            txtAdelanto.Name = "txtAdelanto";
            txtAdelanto.Size = new Size(90, 23);
            txtAdelanto.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(253, 161);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(88, 23);
            txtTotal.TabIndex = 11;
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.BackgroundColor = Color.Ivory;
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(18, 32);
            dgvDetallePedido.Margin = new Padding(3, 2, 3, 2);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(916, 108);
            dgvDetallePedido.TabIndex = 25;
            // 
            // grpDatosClientes
            // 
            grpDatosClientes.Controls.Add(txtCiudad);
            grpDatosClientes.Controls.Add(label11);
            grpDatosClientes.Controls.Add(btnLimpiar);
            grpDatosClientes.Controls.Add(btnBuscarCliente);
            grpDatosClientes.Controls.Add(txtDireccion);
            grpDatosClientes.Controls.Add(label5);
            grpDatosClientes.Controls.Add(txtNombreCliente);
            grpDatosClientes.Controls.Add(txtTelefono);
            grpDatosClientes.Controls.Add(label10);
            grpDatosClientes.Controls.Add(label9);
            grpDatosClientes.Controls.Add(txtCedula);
            grpDatosClientes.Controls.Add(label8);
            grpDatosClientes.Location = new Point(31, 56);
            grpDatosClientes.Margin = new Padding(3, 2, 3, 2);
            grpDatosClientes.Name = "grpDatosClientes";
            grpDatosClientes.Padding = new Padding(3, 2, 3, 2);
            grpDatosClientes.Size = new Size(1054, 117);
            grpDatosClientes.TabIndex = 40;
            grpDatosClientes.TabStop = false;
            grpDatosClientes.Text = "Datos del Cliente";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(793, 25);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(223, 23);
            txtCiudad.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(738, 25);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 12;
            label11.Text = "Ciudad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(383, 22);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 22);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(301, 22);
            btnBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(77, 22);
            btnBuscarCliente.TabIndex = 10;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(554, 59);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(223, 23);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 64);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 8;
            label5.Text = "Dirección ";
            label5.Click += label5_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(146, 62);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(223, 23);
            txtNombreCliente.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(554, 24);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(490, 22);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 3;
            label10.Text = "Teléfono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 64);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 2;
            label9.Text = "Nombre del cliente";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(75, 22);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(219, 23);
            txtCedula.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 22);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 0;
            label8.Text = "Cédula";
            // 
            // grpDetallePedido
            // 
            grpDetallePedido.Controls.Add(btnAgregarDetalle);
            grpDetallePedido.Controls.Add(dgvDetallePedido);
            grpDetallePedido.Controls.Add(txtSubTotal);
            grpDetallePedido.Controls.Add(label7);
            grpDetallePedido.Controls.Add(txtTotal);
            grpDetallePedido.Controls.Add(label4);
            grpDetallePedido.Controls.Add(txtAdelanto);
            grpDetallePedido.Controls.Add(label6);
            grpDetallePedido.Location = new Point(31, 392);
            grpDetallePedido.Margin = new Padding(3, 2, 3, 2);
            grpDetallePedido.Name = "grpDetallePedido";
            grpDetallePedido.Padding = new Padding(3, 2, 3, 2);
            grpDetallePedido.Size = new Size(1054, 200);
            grpDetallePedido.TabIndex = 41;
            grpDetallePedido.TabStop = false;
            grpDetallePedido.Text = "Detalle de Pedido";
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.PaleTurquoise;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarDetalle.Location = new Point(949, 64);
            btnAgregarDetalle.Margin = new Padding(3, 2, 3, 2);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(88, 23);
            btnAgregarDetalle.TabIndex = 41;
            btnAgregarDetalle.Text = "Agregar ";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // btnRegresarDPedido
            // 
            btnRegresarDPedido.BackColor = Color.PowderBlue;
            btnRegresarDPedido.FlatStyle = FlatStyle.System;
            btnRegresarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarDPedido.Location = new Point(31, 596);
            btnRegresarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnRegresarDPedido.Name = "btnRegresarDPedido";
            btnRegresarDPedido.Size = new Size(110, 22);
            btnRegresarDPedido.TabIndex = 48;
            btnRegresarDPedido.Text = "Regresar ";
            btnRegresarDPedido.UseVisualStyleBackColor = false;
            btnRegresarDPedido.Click += btnRegresarDPedido_Click;
            // 
            // btnCancelarDPedido
            // 
            btnCancelarDPedido.BackColor = Color.PaleTurquoise;
            btnCancelarDPedido.FlatStyle = FlatStyle.Popup;
            btnCancelarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarDPedido.Location = new Point(1001, 596);
            btnCancelarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnCancelarDPedido.Name = "btnCancelarDPedido";
            btnCancelarDPedido.Size = new Size(82, 22);
            btnCancelarDPedido.TabIndex = 53;
            btnCancelarDPedido.Text = "Cancelar";
            btnCancelarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDPedido
            // 
            btnEliminarDPedido.BackColor = Color.PaleTurquoise;
            btnEliminarDPedido.FlatStyle = FlatStyle.Popup;
            btnEliminarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDPedido.Location = new Point(911, 596);
            btnEliminarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnEliminarDPedido.Name = "btnEliminarDPedido";
            btnEliminarDPedido.Size = new Size(82, 22);
            btnEliminarDPedido.TabIndex = 52;
            btnEliminarDPedido.Text = "Eliminar";
            btnEliminarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnActualizarDPedido
            // 
            btnActualizarDPedido.BackColor = Color.PaleTurquoise;
            btnActualizarDPedido.FlatStyle = FlatStyle.Popup;
            btnActualizarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarDPedido.Location = new Point(823, 596);
            btnActualizarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnActualizarDPedido.Name = "btnActualizarDPedido";
            btnActualizarDPedido.Size = new Size(82, 22);
            btnActualizarDPedido.TabIndex = 51;
            btnActualizarDPedido.Text = "Actualizar";
            btnActualizarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnEditarDPedido
            // 
            btnEditarDPedido.BackColor = Color.PaleTurquoise;
            btnEditarDPedido.FlatStyle = FlatStyle.Popup;
            btnEditarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarDPedido.Location = new Point(736, 596);
            btnEditarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnEditarDPedido.Name = "btnEditarDPedido";
            btnEditarDPedido.Size = new Size(82, 22);
            btnEditarDPedido.TabIndex = 50;
            btnEditarDPedido.Text = "Editar";
            btnEditarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDPedido
            // 
            btnRegistrarDPedido.BackColor = Color.LightSeaGreen;
            btnRegistrarDPedido.FlatStyle = FlatStyle.Popup;
            btnRegistrarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDPedido.Location = new Point(646, 595);
            btnRegistrarDPedido.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarDPedido.Name = "btnRegistrarDPedido";
            btnRegistrarDPedido.Size = new Size(82, 23);
            btnRegistrarDPedido.TabIndex = 49;
            btnRegistrarDPedido.Text = "Registrar Pedido";
            btnRegistrarDPedido.UseVisualStyleBackColor = false;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbProductos.Location = new Point(18, 48);
            cbProductos.Margin = new Padding(3, 2, 3, 2);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(295, 23);
            cbProductos.TabIndex = 46;
            // 
            // cbProductosPersonalizados
            // 
            cbProductosPersonalizados.FormattingEnabled = true;
            cbProductosPersonalizados.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbProductosPersonalizados.Location = new Point(341, 48);
            cbProductosPersonalizados.Margin = new Padding(3, 2, 3, 2);
            cbProductosPersonalizados.Name = "cbProductosPersonalizados";
            cbProductosPersonalizados.Size = new Size(322, 23);
            cbProductosPersonalizados.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 48;
            label1.Text = "Productos ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(341, 31);
            label14.Name = "label14";
            label14.Size = new Size(142, 15);
            label14.TabIndex = 49;
            label14.Text = "Productos Personalizados";
            // 
            // PantallaDetallePedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1111, 591);
            Controls.Add(btnCancelarDPedido);
            Controls.Add(btnRegistrarDPedido);
            Controls.Add(btnRegresarDPedido);
            Controls.Add(grpDetallePedido);
            Controls.Add(btnEliminarDPedido);
            Controls.Add(grpDatosClientes);
            Controls.Add(btnActualizarDPedido);
            Controls.Add(grpDatosPedido);
            Controls.Add(panel1);
            Controls.Add(btnEditarDPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaDetallePedido";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaDetallePedido";
            Load += PantallaDetallePedido_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            grpDatosPedido.ResumeLayout(false);
            grpDatosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            grpDatosClientes.ResumeLayout(false);
            grpDatosClientes.PerformLayout();
            grpDetallePedido.ResumeLayout(false);
            grpDetallePedido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpDatosPedido;
        private TextBox txtHoraEntrega;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtSubTotal;
        private TextBox txtAdelanto;
        private TextBox txtTotal;
        private DataGridView dgvDetallePedido;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private PictureBox pictureBox1;
        private GroupBox grpDatosClientes;
        private TextBox txtTelefono;
        private Label label10;
        private Label label9;
        private TextBox txtCedula;
        private Label label8;
        private TextBox txtNombreCliente;
        private TextBox txtFechaEntrega;
        private Label label12;
        private Label v;
        private TextBox txtPrecioProducto;
        private Label label13;
        private TextBox txtLibras;
        private Label label16;
        private GroupBox grpDetallePedido;
        private Button btnAgregarDetalle;
        private Button btnRegresarDPedido;
        private Button btnCancelarDPedido;
        private Button btnEliminarDPedido;
        private Button btnActualizarDPedido;
        private Button btnEditarDPedido;
        private Button btnRegistrarDPedido;
        private Label label5;
        private Button btnLimpiar;
        private Button btnBuscarCliente;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private Label label11;
        private Label label14;
        private Label label1;
        private ComboBox cbProductosPersonalizados;
        private ComboBox cbProductos;
    }
}