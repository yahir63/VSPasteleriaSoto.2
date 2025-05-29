namespace Pasteleria_Soto.UI
{
    partial class EleccionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleccionProducto));
            grbDatosProducto = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            txtLibra = new TextBox();
            cbProductosBase = new ComboBox();
            txtCantidad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cbProductosDefinidos = new ComboBox();
            btnAgregarProducto = new Button();
            dgvDatos = new DataGridView();
            btnRegistrarProducto = new Button();
            panel1 = new Panel();
            btnCerrarProducto = new PictureBox();
            btnMnzProducto = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEditarProducto = new Button();
            btnActualizarProducto = new Button();
            btnEliminarProducto = new Button();
            btnCancelarProducto = new Button();
            btnVerProducto = new Button();
            btnRegresarProducto = new Button();
            txtNombreProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrecioVenta = new TextBox();
            cbOpciones = new ComboBox();
            label6 = new Label();
            grbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbDatosProducto
            // 
            grbDatosProducto.BackColor = Color.LightCyan;
            grbDatosProducto.Controls.Add(label6);
            grbDatosProducto.Controls.Add(cbOpciones);
            grbDatosProducto.Controls.Add(txtPrecioVenta);
            grbDatosProducto.Controls.Add(label3);
            grbDatosProducto.Controls.Add(label2);
            grbDatosProducto.Controls.Add(txtNombreProducto);
            grbDatosProducto.Controls.Add(label5);
            grbDatosProducto.Controls.Add(label4);
            grbDatosProducto.Controls.Add(txtLibra);
            grbDatosProducto.Controls.Add(cbProductosBase);
            grbDatosProducto.Controls.Add(txtCantidad);
            grbDatosProducto.Controls.Add(label11);
            grbDatosProducto.Controls.Add(label10);
            grbDatosProducto.Controls.Add(cbProductosDefinidos);
            grbDatosProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDatosProducto.Location = new Point(21, 78);
            grbDatosProducto.Margin = new Padding(3, 2, 3, 2);
            grbDatosProducto.Name = "grbDatosProducto";
            grbDatosProducto.Padding = new Padding(3, 2, 3, 2);
            grbDatosProducto.Size = new Size(523, 359);
            grbDatosProducto.TabIndex = 2;
            grbDatosProducto.TabStop = false;
            grbDatosProducto.Text = "Datos del producto";
            grbDatosProducto.Enter += grbDatosProducto_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 41);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 25;
            label5.Text = "Nombre Producto";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 150);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 24;
            label4.Text = "Libras";
            // 
            // txtLibra
            // 
            txtLibra.Location = new Point(352, 186);
            txtLibra.Margin = new Padding(3, 2, 3, 2);
            txtLibra.Name = "txtLibra";
            txtLibra.Size = new Size(149, 22);
            txtLibra.TabIndex = 23;
            // 
            // cbProductosBase
            // 
            cbProductosBase.FormattingEnabled = true;
            cbProductosBase.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbProductosBase.Location = new Point(190, 71);
            cbProductosBase.Margin = new Padding(3, 2, 3, 2);
            cbProductosBase.Name = "cbProductosBase";
            cbProductosBase.Size = new Size(141, 25);
            cbProductosBase.TabIndex = 20;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(190, 189);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(141, 22);
            txtCantidad.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(190, 150);
            label11.Name = "label11";
            label11.Size = new Size(147, 17);
            label11.TabIndex = 16;
            label11.Text = "Cantidad de productos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 41);
            label10.Name = "label10";
            label10.Size = new Size(126, 17);
            label10.TabIndex = 14;
            label10.Text = "Productos Definidos";
            // 
            // cbProductosDefinidos
            // 
            cbProductosDefinidos.FormattingEnabled = true;
            cbProductosDefinidos.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbProductosDefinidos.Location = new Point(11, 71);
            cbProductosDefinidos.Margin = new Padding(3, 2, 3, 2);
            cbProductosDefinidos.Name = "cbProductosDefinidos";
            cbProductosDefinidos.Size = new Size(149, 25);
            cbProductosDefinidos.TabIndex = 13;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.DarkCyan;
            btnAgregarProducto.FlatStyle = FlatStyle.System;
            btnAgregarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.Location = new Point(107, 462);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(104, 22);
            btnAgregarProducto.TabIndex = 23;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.Ivory;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(584, 78);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(443, 256);
            dgvDatos.TabIndex = 24;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            dgvDatos.CellContentDoubleClick += dgvDatos_CellContentDoubleClick;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.BackColor = Color.PaleTurquoise;
            btnRegistrarProducto.FlatStyle = FlatStyle.Popup;
            btnRegistrarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarProducto.Location = new Point(942, 374);
            btnRegistrarProducto.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(82, 23);
            btnRegistrarProducto.TabIndex = 26;
            btnRegistrarProducto.Text = "Registrar Pedido";
            btnRegistrarProducto.UseVisualStyleBackColor = false;
            btnRegistrarProducto.Click += btnRegistrarPedido_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarProducto);
            panel1.Controls.Add(btnMnzProducto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 56);
            panel1.TabIndex = 27;
            // 
            // btnCerrarProducto
            // 
            btnCerrarProducto.Image = (Image)resources.GetObject("btnCerrarProducto.Image");
            btnCerrarProducto.Location = new Point(1057, 14);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(22, 22);
            btnCerrarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarProducto.TabIndex = 29;
            btnCerrarProducto.TabStop = false;
            btnCerrarProducto.Click += btnCerrarProducto_Click;
            // 
            // btnMnzProducto
            // 
            btnMnzProducto.Image = (Image)resources.GetObject("btnMnzProducto.Image");
            btnMnzProducto.Location = new Point(1010, 14);
            btnMnzProducto.Name = "btnMnzProducto";
            btnMnzProducto.Size = new Size(28, 22);
            btnMnzProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzProducto.TabIndex = 28;
            btnMnzProducto.TabStop = false;
            btnMnzProducto.Click += btnMnzProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(116, 14);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 2;
            label1.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarProducto.Location = new Point(942, 402);
            btnEditarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(82, 22);
            btnEditarProducto.TabIndex = 28;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarProducto.Location = new Point(942, 436);
            btnActualizarProducto.Margin = new Padding(3, 2, 3, 2);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(82, 22);
            btnActualizarProducto.TabIndex = 29;
            btnActualizarProducto.Text = "Actualizar";
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnActualizar_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Crimson;
            btnEliminarProducto.FlatStyle = FlatStyle.System;
            btnEliminarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.Location = new Point(942, 462);
            btnEliminarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(82, 22);
            btnEliminarProducto.TabIndex = 30;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminar_Click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarProducto.Location = new Point(942, 488);
            btnCancelarProducto.Margin = new Padding(3, 2, 3, 2);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(82, 22);
            btnCancelarProducto.TabIndex = 31;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // btnVerProducto
            // 
            btnVerProducto.BackColor = Color.DarkTurquoise;
            btnVerProducto.FlatStyle = FlatStyle.System;
            btnVerProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerProducto.Location = new Point(584, 374);
            btnVerProducto.Margin = new Padding(3, 2, 3, 2);
            btnVerProducto.Name = "btnVerProducto";
            btnVerProducto.Size = new Size(130, 34);
            btnVerProducto.TabIndex = 32;
            btnVerProducto.Text = "Ver Productos";
            btnVerProducto.UseVisualStyleBackColor = false;
            btnVerProducto.Click += btnVerPedido_Click;
            // 
            // btnRegresarProducto
            // 
            btnRegresarProducto.BackColor = Color.PowderBlue;
            btnRegresarProducto.FlatStyle = FlatStyle.System;
            btnRegresarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarProducto.Location = new Point(21, 506);
            btnRegresarProducto.Margin = new Padding(3, 2, 3, 2);
            btnRegresarProducto.Name = "btnRegresarProducto";
            btnRegresarProducto.Size = new Size(82, 22);
            btnRegresarProducto.TabIndex = 33;
            btnRegresarProducto.Text = "Regresar";
            btnRegresarProducto.UseVisualStyleBackColor = false;
            btnRegresarProducto.Click += btnRegresarProducto_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(352, 71);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(149, 22);
            txtNombreProducto.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 41);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 27;
            label2.Text = "Productos Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 257);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 28;
            label3.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(19, 287);
            txtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(141, 22);
            txtPrecioVenta.TabIndex = 29;
            // 
            // cbOpciones
            // 
            cbOpciones.FormattingEnabled = true;
            cbOpciones.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbOpciones.Location = new Point(11, 186);
            cbOpciones.Margin = new Padding(3, 2, 3, 2);
            cbOpciones.Name = "cbOpciones";
            cbOpciones.Size = new Size(149, 25);
            cbOpciones.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 150);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 31;
            label6.Text = "Opciones";
            // 
            // EleccionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1111, 547);
            Controls.Add(btnRegresarProducto);
            Controls.Add(btnVerProducto);
            Controls.Add(btnCancelarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnActualizarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(panel1);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(dgvDatos);
            Controls.Add(grbDatosProducto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EleccionProducto";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += EleccionProducto_Load;
            grbDatosProducto.ResumeLayout(false);
            grbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatosProducto;
        private TextBox txtCantidad;
        private Label label11;
        private Label label10;
        private ComboBox cbProductosDefinidos;
        private Button btnAgregarProducto;
        private DataGridView dgvDatos;
        private Button btnRegistrarProducto;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnMnzProducto;
        private PictureBox btnCerrarProducto;
        private Button btnEditarProducto;
        private Button btnActualizarProducto;
        private Button btnEliminarProducto;
        private Button btnCancelarProducto;
        private Button btnVerProducto;
        private Button btnRegresarProducto;
        private Label label4;
        private TextBox txtLibra;
        private ComboBox cbProductosBase;
        private Label label5;
        private TextBox txtNombreProducto;
        private Label label2;
        private TextBox txtPrecioVenta;
        private Label label3;
        private Label label6;
        private ComboBox cbOpciones;
    }
}