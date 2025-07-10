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
            txtHoraEntrega = new TextBox();
            dtpFechaEntrega = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txtCedula = new TextBox();
            btnBuscarCliente = new Button();
            btnLimpiar = new Button();
            cbClientes = new ComboBox();
            label9 = new Label();
            label12 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtAdelanto = new TextBox();
            dgvDetallePedido = new DataGridView();
            grpDetallePedido = new GroupBox();
            label17 = new Label();
            label14 = new Label();
            btnRegistrarDPedido = new Button();
            txtTotal = new TextBox();
            txtSubtotal = new TextBox();
            btnAgregarDetalle = new Button();
            btnRegresarDPedido = new Button();
            grpProdGenericos = new GroupBox();
            cbVolumenPG = new ComboBox();
            label4 = new Label();
            txtStockDisponible = new TextBox();
            label1 = new Label();
            txtPVtaProducto = new TextBox();
            txtCantidad = new TextBox();
            label13 = new Label();
            cbProducto = new ComboBox();
            label15 = new Label();
            label3 = new Label();
            grpProdPersonal = new GroupBox();
            cbVolumenPPers = new ComboBox();
            cbProductoPersonalizado = new ComboBox();
            btnAgregarPPers = new Button();
            v = new Label();
            txtCantidadPers = new TextBox();
            label10 = new Label();
            label5 = new Label();
            txtPVtaPPers = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            grpDatosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            grpDetallePedido.SuspendLayout();
            grpProdGenericos.SuspendLayout();
            grpProdPersonal.SuspendLayout();
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
            panel1.Size = new Size(1252, 67);
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
            grpDatosPedido.Controls.Add(txtHoraEntrega);
            grpDatosPedido.Controls.Add(dtpFechaEntrega);
            grpDatosPedido.Controls.Add(label8);
            grpDatosPedido.Controls.Add(label7);
            grpDatosPedido.Controls.Add(txtCedula);
            grpDatosPedido.Controls.Add(btnBuscarCliente);
            grpDatosPedido.Controls.Add(btnLimpiar);
            grpDatosPedido.Controls.Add(cbClientes);
            grpDatosPedido.Controls.Add(label9);
            grpDatosPedido.Controls.Add(label12);
            grpDatosPedido.Controls.Add(label2);
            grpDatosPedido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosPedido.Location = new Point(33, 103);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Size = new Size(1152, 119);
            grpDatosPedido.TabIndex = 1;
            grpDatosPedido.TabStop = false;
            grpDatosPedido.Text = "Datos del Pedido";
            // 
            // txtHoraEntrega
            // 
            txtHoraEntrega.Location = new Point(987, 65);
            txtHoraEntrega.Name = "txtHoraEntrega";
            txtHoraEntrega.Size = new Size(125, 26);
            txtHoraEntrega.TabIndex = 49;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(658, 65);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(301, 26);
            dtpFechaEntrega.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 40);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 0;
            label8.Text = "Cédula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 227);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 18;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(24, 63);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(199, 26);
            txtCedula.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(237, 61);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(88, 29);
            btnBuscarCliente.TabIndex = 10;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(341, 63);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(462, 64);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(163, 28);
            cbClientes.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(462, 40);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 2;
            label9.Text = "Nombre del cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(658, 40);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 20;
            label12.Text = "Fecha de Entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(985, 40);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Hora de Entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 280);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 17;
            label6.Text = "Adelanto";
            // 
            // txtAdelanto
            // 
            txtAdelanto.Location = new Point(476, 272);
            txtAdelanto.Name = "txtAdelanto";
            txtAdelanto.Size = new Size(102, 26);
            txtAdelanto.TabIndex = 12;
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.BackgroundColor = Color.Ivory;
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(21, 43);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(1112, 203);
            dgvDetallePedido.TabIndex = 25;
            // 
            // grpDetallePedido
            // 
            grpDetallePedido.Controls.Add(label17);
            grpDetallePedido.Controls.Add(label14);
            grpDetallePedido.Controls.Add(btnRegistrarDPedido);
            grpDetallePedido.Controls.Add(txtTotal);
            grpDetallePedido.Controls.Add(dgvDetallePedido);
            grpDetallePedido.Controls.Add(txtAdelanto);
            grpDetallePedido.Controls.Add(label6);
            grpDetallePedido.Controls.Add(txtSubtotal);
            grpDetallePedido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetallePedido.Location = new Point(33, 474);
            grpDetallePedido.Name = "grpDetallePedido";
            grpDetallePedido.Size = new Size(1152, 306);
            grpDetallePedido.TabIndex = 41;
            grpDetallePedido.TabStop = false;
            grpDetallePedido.Text = "Detalle de Pedido";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(208, 280);
            label17.Name = "label17";
            label17.Size = new Size(68, 20);
            label17.TabIndex = 59;
            label17.Text = "Subtotal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 280);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 58;
            label14.Text = "Total";
            // 
            // btnRegistrarDPedido
            // 
            btnRegistrarDPedido.BackColor = Color.LightSeaGreen;
            btnRegistrarDPedido.FlatStyle = FlatStyle.Popup;
            btnRegistrarDPedido.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDPedido.Location = new Point(1013, 258);
            btnRegistrarDPedido.Name = "btnRegistrarDPedido";
            btnRegistrarDPedido.Size = new Size(120, 31);
            btnRegistrarDPedido.TabIndex = 49;
            btnRegistrarDPedido.Text = "Registrar Pedido";
            btnRegistrarDPedido.UseVisualStyleBackColor = false;
            btnRegistrarDPedido.Click += btnRegistrarDPedido_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(89, 273);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(102, 26);
            txtTotal.TabIndex = 57;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(279, 273);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(102, 26);
            txtSubtotal.TabIndex = 56;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.PaleTurquoise;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarDetalle.Location = new Point(364, 144);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(101, 31);
            btnAgregarDetalle.TabIndex = 41;
            btnAgregarDetalle.Text = "Agregar ";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click_1;
            // 
            // btnRegresarDPedido
            // 
            btnRegresarDPedido.BackColor = Color.PowderBlue;
            btnRegresarDPedido.FlatStyle = FlatStyle.System;
            btnRegresarDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarDPedido.Location = new Point(35, 819);
            btnRegresarDPedido.Name = "btnRegresarDPedido";
            btnRegresarDPedido.Size = new Size(126, 29);
            btnRegresarDPedido.TabIndex = 48;
            btnRegresarDPedido.Text = "Menú";
            btnRegresarDPedido.UseVisualStyleBackColor = false;
            btnRegresarDPedido.Click += btnRegresarDPedido_Click;
            // 
            // grpProdGenericos
            // 
            grpProdGenericos.Controls.Add(cbVolumenPG);
            grpProdGenericos.Controls.Add(label4);
            grpProdGenericos.Controls.Add(btnAgregarDetalle);
            grpProdGenericos.Controls.Add(txtStockDisponible);
            grpProdGenericos.Controls.Add(label1);
            grpProdGenericos.Controls.Add(txtPVtaProducto);
            grpProdGenericos.Controls.Add(txtCantidad);
            grpProdGenericos.Controls.Add(label13);
            grpProdGenericos.Controls.Add(cbProducto);
            grpProdGenericos.Controls.Add(label15);
            grpProdGenericos.Controls.Add(label3);
            grpProdGenericos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProdGenericos.Location = new Point(35, 235);
            grpProdGenericos.Name = "grpProdGenericos";
            grpProdGenericos.Size = new Size(488, 205);
            grpProdGenericos.TabIndex = 54;
            grpProdGenericos.TabStop = false;
            grpProdGenericos.Text = "Producto genérico";
            // 
            // cbVolumenPG
            // 
            cbVolumenPG.FormattingEnabled = true;
            cbVolumenPG.Location = new Point(196, 147);
            cbVolumenPG.Name = "cbVolumenPG";
            cbVolumenPG.Size = new Size(125, 28);
            cbVolumenPG.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 38);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 57;
            label4.Text = "Stock disponible";
            // 
            // txtStockDisponible
            // 
            txtStockDisponible.Location = new Point(340, 72);
            txtStockDisponible.Name = "txtStockDisponible";
            txtStockDisponible.ReadOnly = true;
            txtStockDisponible.Size = new Size(125, 26);
            txtStockDisponible.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 55;
            label1.Text = "Precio Venta";
            // 
            // txtPVtaProducto
            // 
            txtPVtaProducto.Location = new Point(196, 72);
            txtPVtaProducto.Name = "txtPVtaProducto";
            txtPVtaProducto.ReadOnly = true;
            txtPVtaProducto.Size = new Size(125, 26);
            txtPVtaProducto.TabIndex = 54;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(23, 148);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(137, 26);
            txtCantidad.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(196, 121);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 50;
            label13.Text = "Volumen (Lbs)";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(23, 71);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(151, 28);
            cbProducto.TabIndex = 53;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            cbProducto.SelectionChangeCommitted += cbProducto_SelectionChangeCommitted;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 38);
            label15.Name = "label15";
            label15.Size = new Size(140, 20);
            label15.TabIndex = 52;
            label15.Text = "Nombre Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 121);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 47;
            label3.Text = "Cantidad a reservar";
            // 
            // grpProdPersonal
            // 
            grpProdPersonal.Controls.Add(cbVolumenPPers);
            grpProdPersonal.Controls.Add(cbProductoPersonalizado);
            grpProdPersonal.Controls.Add(btnAgregarPPers);
            grpProdPersonal.Controls.Add(v);
            grpProdPersonal.Controls.Add(txtCantidadPers);
            grpProdPersonal.Controls.Add(label10);
            grpProdPersonal.Controls.Add(label5);
            grpProdPersonal.Controls.Add(txtPVtaPPers);
            grpProdPersonal.Controls.Add(label11);
            grpProdPersonal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProdPersonal.Location = new Point(549, 235);
            grpProdPersonal.Name = "grpProdPersonal";
            grpProdPersonal.Size = new Size(484, 205);
            grpProdPersonal.TabIndex = 55;
            grpProdPersonal.TabStop = false;
            grpProdPersonal.Text = "Producto Personalizado";
            // 
            // cbVolumenPPers
            // 
            cbVolumenPPers.FormattingEnabled = true;
            cbVolumenPPers.Location = new Point(198, 147);
            cbVolumenPPers.Name = "cbVolumenPPers";
            cbVolumenPPers.Size = new Size(125, 28);
            cbVolumenPPers.TabIndex = 62;
            // 
            // cbProductoPersonalizado
            // 
            cbProductoPersonalizado.FormattingEnabled = true;
            cbProductoPersonalizado.Location = new Point(25, 66);
            cbProductoPersonalizado.Name = "cbProductoPersonalizado";
            cbProductoPersonalizado.Size = new Size(163, 28);
            cbProductoPersonalizado.TabIndex = 57;
            cbProductoPersonalizado.SelectionChangeCommitted += cbProductoPersonalizado_SelectionChangeCommitted;
            // 
            // btnAgregarPPers
            // 
            btnAgregarPPers.BackColor = Color.PaleTurquoise;
            btnAgregarPPers.FlatStyle = FlatStyle.Flat;
            btnAgregarPPers.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPPers.Location = new Point(366, 144);
            btnAgregarPPers.Name = "btnAgregarPPers";
            btnAgregarPPers.Size = new Size(101, 31);
            btnAgregarPPers.TabIndex = 58;
            btnAgregarPPers.Text = "Agregar ";
            btnAgregarPPers.UseVisualStyleBackColor = false;
            btnAgregarPPers.Click += btnAgregarPPers_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(25, 34);
            v.Name = "v";
            v.Size = new Size(140, 20);
            v.TabIndex = 56;
            v.Text = "Nombre Producto";
            // 
            // txtCantidadPers
            // 
            txtCantidadPers.Location = new Point(25, 148);
            txtCantidadPers.Name = "txtCantidadPers";
            txtCantidadPers.Size = new Size(137, 26);
            txtCantidadPers.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(202, 34);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 55;
            label10.Text = "Precio Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 121);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 61;
            label5.Text = "Volumen (Lbs)";
            // 
            // txtPVtaPPers
            // 
            txtPVtaPPers.Location = new Point(200, 67);
            txtPVtaPPers.Name = "txtPVtaPPers";
            txtPVtaPPers.ReadOnly = true;
            txtPVtaPPers.Size = new Size(125, 26);
            txtPVtaPPers.TabIndex = 54;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 121);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 59;
            label11.Text = "Cantidad a reservar";
            // 
            // PantallaDetallePedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1252, 878);
            Controls.Add(grpProdGenericos);
            Controls.Add(grpProdPersonal);
            Controls.Add(btnRegresarDPedido);
            Controls.Add(grpDetallePedido);
            Controls.Add(grpDatosPedido);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaDetallePedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += PantallaDetallePedido_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            grpDatosPedido.ResumeLayout(false);
            grpDatosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            grpDetallePedido.ResumeLayout(false);
            grpDetallePedido.PerformLayout();
            grpProdGenericos.ResumeLayout(false);
            grpProdGenericos.PerformLayout();
            grpProdPersonal.ResumeLayout(false);
            grpProdPersonal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpDatosPedido;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox txtAdelanto;
        private DataGridView dgvDetallePedido;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox txtCedula;
        private Label label8;
        private Label label12;
        private Label label16;
        private GroupBox grpDetallePedido;
        private Button btnAgregarDetalle;
        private Button btnRegresarDPedido;
        private Button btnRegistrarDPedido;
        private Button btnLimpiar;
        private Button btnBuscarCliente;
        private ComboBox cbClientes;
        private TextBox txtCantidad;
        private Label label3;
        private Label label13;
        private GroupBox grpProdGenericos;
        private ComboBox cbProducto;
        private Label label15;
        private Label label4;
        private TextBox txtStockDisponible;
        private Label label1;
        private TextBox txtPVtaProducto;
        private GroupBox grpProdPersonal;
        private ComboBox cbProductoPersonalizado;
        private Label v;
        private Label label10;
        private TextBox txtPVtaPPers;
        private DateTimePicker dtpFechaEntrega;
        private ComboBox cbVolumenPG;
        private ComboBox cbVolumenPPers;
        private Button btnAgregarPPers;
        private TextBox txtCantidadPers;
        private Label label5;
        private Label label11;
        private TextBox txtHoraEntrega;
        private Label label17;
        private Label label14;
        private TextBox txtTotal;
        private TextBox txtSubtotal;
    }
}