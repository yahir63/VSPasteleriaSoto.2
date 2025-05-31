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
            txtNombreProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtUnidadMedida = new TextBox();
            txtCantidad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cbCategoriaProducto = new ComboBox();
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
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtProductoBase = new TextBox();
            label6 = new Label();
            txtTamano = new TextBox();
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
            grbDatosProducto.Controls.Add(txtTamano);
            grbDatosProducto.Controls.Add(label6);
            grbDatosProducto.Controls.Add(txtProductoBase);
            grbDatosProducto.Controls.Add(label3);
            grbDatosProducto.Controls.Add(label2);
            grbDatosProducto.Controls.Add(txtDescripcion);
            grbDatosProducto.Controls.Add(txtNombreProducto);
            grbDatosProducto.Controls.Add(label5);
            grbDatosProducto.Controls.Add(label4);
            grbDatosProducto.Controls.Add(txtUnidadMedida);
            grbDatosProducto.Controls.Add(txtCantidad);
            grbDatosProducto.Controls.Add(label11);
            grbDatosProducto.Controls.Add(label10);
            grbDatosProducto.Controls.Add(cbCategoriaProducto);
            grbDatosProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDatosProducto.Location = new Point(96, 137);
            grbDatosProducto.Name = "grbDatosProducto";
            grbDatosProducto.Size = new Size(448, 446);
            grbDatosProducto.TabIndex = 2;
            grbDatosProducto.TabStop = false;
            grbDatosProducto.Text = "Datos del producto";
            grbDatosProducto.Enter += grbDatosProducto_Enter;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(204, 47);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(212, 26);
            txtNombreProducto.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 53);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 25;
            label5.Text = "Nombre Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 216);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 24;
            label4.Text = "Unidad de Medida";
            // 
            // txtUnidadMedida
            // 
            txtUnidadMedida.Location = new Point(204, 210);
            txtUnidadMedida.Name = "txtUnidadMedida";
            txtUnidadMedida.Size = new Size(212, 26);
            txtUnidadMedida.TabIndex = 23;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(204, 327);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(212, 26);
            txtCantidad.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 333);
            label11.Name = "label11";
            label11.Size = new Size(181, 20);
            label11.TabIndex = 16;
            label11.Text = "Cantidad de productos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 267);
            label10.Name = "label10";
            label10.Size = new Size(175, 20);
            label10.TabIndex = 14;
            label10.Text = "Elección de Categoria";
            // 
            // cbCategoriaProducto
            // 
            cbCategoriaProducto.FormattingEnabled = true;
            cbCategoriaProducto.Items.AddRange(new object[] { "Pastel", "Gallleta", "Cupcake", "Bocadillo" });
            cbCategoriaProducto.Location = new Point(204, 264);
            cbCategoriaProducto.Name = "cbCategoriaProducto";
            cbCategoriaProducto.Size = new Size(212, 28);
            cbCategoriaProducto.TabIndex = 13;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.DarkCyan;
            btnAgregarProducto.FlatStyle = FlatStyle.System;
            btnAgregarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.Location = new Point(122, 616);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(119, 29);
            btnAgregarProducto.TabIndex = 23;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.Ivory;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(668, 137);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(506, 342);
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
            btnRegistrarProducto.Location = new Point(1077, 499);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(94, 31);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 75);
            panel1.TabIndex = 27;
            // 
            // btnCerrarProducto
            // 
            btnCerrarProducto.Image = (Image)resources.GetObject("btnCerrarProducto.Image");
            btnCerrarProducto.Location = new Point(1208, 19);
            btnCerrarProducto.Margin = new Padding(3, 4, 3, 4);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(25, 29);
            btnCerrarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarProducto.TabIndex = 29;
            btnCerrarProducto.TabStop = false;
            btnCerrarProducto.Click += btnCerrarProducto_Click;
            // 
            // btnMnzProducto
            // 
            btnMnzProducto.Image = (Image)resources.GetObject("btnMnzProducto.Image");
            btnMnzProducto.Location = new Point(1154, 19);
            btnMnzProducto.Margin = new Padding(3, 4, 3, 4);
            btnMnzProducto.Name = "btnMnzProducto";
            btnMnzProducto.Size = new Size(32, 29);
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
            label1.Location = new Point(133, 19);
            label1.Name = "label1";
            label1.Size = new Size(240, 35);
            label1.TabIndex = 2;
            label1.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarProducto.Location = new Point(1076, 536);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(94, 29);
            btnEditarProducto.TabIndex = 28;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarProducto.Location = new Point(1076, 581);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(94, 29);
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
            btnEliminarProducto.Location = new Point(1077, 616);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(94, 29);
            btnEliminarProducto.TabIndex = 30;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminar_Click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarProducto.Location = new Point(1076, 651);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(94, 29);
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
            btnVerProducto.Location = new Point(668, 499);
            btnVerProducto.Name = "btnVerProducto";
            btnVerProducto.Size = new Size(148, 45);
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
            btnRegresarProducto.Location = new Point(24, 675);
            btnRegresarProducto.Name = "btnRegresarProducto";
            btnRegresarProducto.Size = new Size(94, 29);
            btnRegresarProducto.TabIndex = 33;
            btnRegresarProducto.Text = "Regresar";
            btnRegresarProducto.UseVisualStyleBackColor = false;
            btnRegresarProducto.Click += btnRegresarProducto_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(204, 94);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 26);
            txtDescripcion.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 28;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 155);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 29;
            label3.Text = "Producto Base";
            // 
            // txtProductoBase
            // 
            txtProductoBase.Location = new Point(204, 149);
            txtProductoBase.Name = "txtProductoBase";
            txtProductoBase.Size = new Size(212, 26);
            txtProductoBase.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 399);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 31;
            label6.Text = "Tamaño";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(204, 393);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(212, 26);
            txtTamano.TabIndex = 32;
            // 
            // EleccionProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 729);
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
        private ComboBox cbCategoriaProducto;
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
        private TextBox txtUnidadMedida;
        private Label label5;
        private TextBox txtNombreProducto;
        private TextBox txtTamano;
        private Label label6;
        private TextBox txtProductoBase;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
    }
}