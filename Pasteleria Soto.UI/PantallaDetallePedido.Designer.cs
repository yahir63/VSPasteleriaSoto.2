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
            btnLimpiarProducto = new Button();
            btnBuscarProducto = new Button();
            label15 = new Label();
            v = new Label();
            txtPrecioProducto = new TextBox();
            label13 = new Label();
            txtFechaEntrega = new TextBox();
            label12 = new Label();
            txtLibras = new TextBox();
            label3 = new Label();
            txtNombreProducto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtSubTotal = new TextBox();
            txtAdelanto = new TextBox();
            txtTotal = new TextBox();
            txtCantidad = new TextBox();
            txtHoraEntrega = new TextBox();
            label2 = new Label();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 67);
            panel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.LightSeaGreen;
            label16.Location = new Point(131, 16);
            label16.Name = "label16";
            label16.Size = new Size(240, 35);
            label16.TabIndex = 42;
            label16.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1215, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 40;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1167, 16);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 40;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // grpDatosPedido
            // 
            grpDatosPedido.Controls.Add(btnLimpiarProducto);
            grpDatosPedido.Controls.Add(btnBuscarProducto);
            grpDatosPedido.Controls.Add(label15);
            grpDatosPedido.Controls.Add(v);
            grpDatosPedido.Controls.Add(txtPrecioProducto);
            grpDatosPedido.Controls.Add(label13);
            grpDatosPedido.Controls.Add(txtFechaEntrega);
            grpDatosPedido.Controls.Add(label12);
            grpDatosPedido.Controls.Add(txtLibras);
            grpDatosPedido.Controls.Add(label3);
            grpDatosPedido.Controls.Add(txtNombreProducto);
            grpDatosPedido.Controls.Add(txtCantidad);
            grpDatosPedido.Controls.Add(txtHoraEntrega);
            grpDatosPedido.Controls.Add(label2);
            grpDatosPedido.Location = new Point(35, 236);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Size = new Size(1205, 281);
            grpDatosPedido.TabIndex = 1;
            grpDatosPedido.TabStop = false;
            grpDatosPedido.Text = "Datos del Pedido";
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(508, 65);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(94, 29);
            btnLimpiarProducto.TabIndex = 45;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(402, 67);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(100, 29);
            btnBuscarProducto.TabIndex = 14;
            btnBuscarProducto.Text = " Buscar Prod";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 36);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 44;
            label15.Text = "Nombre del Producto";
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(633, 42);
            v.Name = "v";
            v.Size = new Size(50, 20);
            v.TabIndex = 25;
            v.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(632, 65);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(368, 27);
            txtPrecioProducto.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 121);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 23;
            label13.Text = "Libra";
            // 
            // txtFechaEntrega
            // 
            txtFechaEntrega.Location = new Point(24, 200);
            txtFechaEntrega.Name = "txtFechaEntrega";
            txtFechaEntrega.Size = new Size(353, 27);
            txtFechaEntrega.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 177);
            label12.Name = "label12";
            label12.Size = new Size(123, 20);
            label12.TabIndex = 20;
            label12.Text = "Fecha de Entrega";
            // 
            // txtLibras
            // 
            txtLibras.Location = new Point(21, 144);
            txtLibras.Name = "txtLibras";
            txtLibras.Size = new Size(140, 27);
            txtLibras.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(24, 67);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(353, 27);
            txtNombreProducto.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 190);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 18;
            label7.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 190);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 17;
            label6.Text = "Adelanto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 192);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 14;
            label4.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(21, 215);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 27);
            txtSubTotal.TabIndex = 13;
            // 
            // txtAdelanto
            // 
            txtAdelanto.Location = new Point(153, 215);
            txtAdelanto.Name = "txtAdelanto";
            txtAdelanto.Size = new Size(102, 27);
            txtAdelanto.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(289, 215);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 27);
            txtTotal.TabIndex = 11;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(401, 135);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(163, 27);
            txtCantidad.TabIndex = 8;
            // 
            // txtHoraEntrega
            // 
            txtHoraEntrega.Location = new Point(633, 135);
            txtHoraEntrega.Name = "txtHoraEntrega";
            txtHoraEntrega.Size = new Size(353, 27);
            txtHoraEntrega.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 112);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Hora de Entrega";
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.BackgroundColor = Color.Ivory;
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(21, 43);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(1047, 144);
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
            grpDatosClientes.Location = new Point(35, 74);
            grpDatosClientes.Name = "grpDatosClientes";
            grpDatosClientes.Size = new Size(1205, 156);
            grpDatosClientes.TabIndex = 40;
            grpDatosClientes.TabStop = false;
            grpDatosClientes.Text = "Datos del Cliente";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(906, 33);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(254, 27);
            txtCiudad.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(844, 33);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 12;
            label11.Text = "Ciudad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(438, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(344, 30);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(88, 29);
            btnBuscarCliente.TabIndex = 10;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(633, 79);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(254, 27);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 86);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "Dirección ";
            label5.Click += label5_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(167, 83);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(254, 27);
            txtNombreCliente.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(633, 32);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(560, 30);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 3;
            label10.Text = "Teléfono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 86);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 2;
            label9.Text = "Nombre del cliente";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(86, 30);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(250, 27);
            txtCedula.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 30);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
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
            grpDetallePedido.Location = new Point(35, 523);
            grpDetallePedido.Name = "grpDetallePedido";
            grpDetallePedido.Size = new Size(1205, 266);
            grpDetallePedido.TabIndex = 41;
            grpDetallePedido.TabStop = false;
            grpDetallePedido.Text = "Detalle de Pedido";
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.PaleTurquoise;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarDetalle.Location = new Point(1085, 85);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(101, 31);
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
            btnRegresarDPedido.Location = new Point(35, 795);
            btnRegresarDPedido.Name = "btnRegresarDPedido";
            btnRegresarDPedido.Size = new Size(126, 29);
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
            btnCancelarDPedido.Location = new Point(1144, 795);
            btnCancelarDPedido.Name = "btnCancelarDPedido";
            btnCancelarDPedido.Size = new Size(94, 29);
            btnCancelarDPedido.TabIndex = 53;
            btnCancelarDPedido.Text = "Cancelar";
            btnCancelarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDPedido
            // 
            btnEliminarDPedido.BackColor = Color.PaleTurquoise;
            btnEliminarDPedido.FlatStyle = FlatStyle.Popup;
            btnEliminarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDPedido.Location = new Point(1041, 795);
            btnEliminarDPedido.Name = "btnEliminarDPedido";
            btnEliminarDPedido.Size = new Size(94, 29);
            btnEliminarDPedido.TabIndex = 52;
            btnEliminarDPedido.Text = "Eliminar";
            btnEliminarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnActualizarDPedido
            // 
            btnActualizarDPedido.BackColor = Color.PaleTurquoise;
            btnActualizarDPedido.FlatStyle = FlatStyle.Popup;
            btnActualizarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarDPedido.Location = new Point(941, 795);
            btnActualizarDPedido.Name = "btnActualizarDPedido";
            btnActualizarDPedido.Size = new Size(94, 29);
            btnActualizarDPedido.TabIndex = 51;
            btnActualizarDPedido.Text = "Actualizar";
            btnActualizarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnEditarDPedido
            // 
            btnEditarDPedido.BackColor = Color.PaleTurquoise;
            btnEditarDPedido.FlatStyle = FlatStyle.Popup;
            btnEditarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarDPedido.Location = new Point(841, 795);
            btnEditarDPedido.Name = "btnEditarDPedido";
            btnEditarDPedido.Size = new Size(94, 29);
            btnEditarDPedido.TabIndex = 50;
            btnEditarDPedido.Text = "Editar";
            btnEditarDPedido.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDPedido
            // 
            btnRegistrarDPedido.BackColor = Color.LightSeaGreen;
            btnRegistrarDPedido.FlatStyle = FlatStyle.Popup;
            btnRegistrarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDPedido.Location = new Point(738, 793);
            btnRegistrarDPedido.Name = "btnRegistrarDPedido";
            btnRegistrarDPedido.Size = new Size(94, 31);
            btnRegistrarDPedido.TabIndex = 49;
            btnRegistrarDPedido.Text = "Registrar Pedido";
            btnRegistrarDPedido.UseVisualStyleBackColor = false;
            // 
            // PantallaDetallePedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 868);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtNombreProducto;
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
        private Button btnLimpiarProducto;
        private Button btnBuscarProducto;
        private Label label15;
    }
}