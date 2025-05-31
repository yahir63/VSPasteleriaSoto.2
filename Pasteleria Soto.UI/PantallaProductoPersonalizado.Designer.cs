namespace Pasteleria_Soto.UI
{
    partial class PantallaProductoPersonalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaProductoPersonalizado));
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            lblPrecioVta = new Label();
            label7 = new Label();
            cbProductoBase = new ComboBox();
            label2 = new Label();
            cbCliente = new ComboBox();
            label5 = new Label();
            txtNombreIdentificador = new TextBox();
            label1 = new Label();
            btnAgregarRelleno = new Button();
            btnPersonalizado = new Button();
            btnEditarPer = new Button();
            btnActualizarPer = new Button();
            btnEliminarPer = new Button();
            btnCancelarPer = new Button();
            btnRegresarRelleno = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtCantidad = new TextBox();
            btnAgregarOpcion = new Button();
            label6 = new Label();
            cbOpciones = new ComboBox();
            dgvOpciones = new DataGridView();
            btnRegistrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOpciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 69);
            panel1.TabIndex = 0;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1221, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 44;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1160, 16);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 44;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(137, 16);
            label4.Name = "label4";
            label4.Size = new Size(240, 35);
            label4.TabIndex = 35;
            label4.Text = "Pastelería Soto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPrecioVta);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbProductoBase);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombreIdentificador);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(71, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 365);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selección de Personalizado";
            // 
            // lblPrecioVta
            // 
            lblPrecioVta.AutoSize = true;
            lblPrecioVta.Location = new Point(327, 253);
            lblPrecioVta.Name = "lblPrecioVta";
            lblPrecioVta.Size = new Size(50, 20);
            lblPrecioVta.TabIndex = 16;
            lblPrecioVta.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 221);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 15;
            label7.Text = "Precio Final";
            // 
            // cbProductoBase
            // 
            cbProductoBase.FormattingEnabled = true;
            cbProductoBase.Location = new Point(27, 245);
            cbProductoBase.Name = "cbProductoBase";
            cbProductoBase.Size = new Size(218, 28);
            cbProductoBase.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 211);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 13;
            label2.Text = "Producto base";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(21, 73);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(224, 28);
            cbCliente.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 39);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // txtNombreIdentificador
            // 
            txtNombreIdentificador.Location = new Point(21, 164);
            txtNombreIdentificador.Name = "txtNombreIdentificador";
            txtNombreIdentificador.Size = new Size(285, 27);
            txtNombreIdentificador.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 130);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // btnAgregarRelleno
            // 
            btnAgregarRelleno.FlatStyle = FlatStyle.System;
            btnAgregarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRelleno.Location = new Point(418, 475);
            btnAgregarRelleno.Name = "btnAgregarRelleno";
            btnAgregarRelleno.Size = new Size(94, 29);
            btnAgregarRelleno.TabIndex = 4;
            btnAgregarRelleno.Text = "Agregar";
            btnAgregarRelleno.UseVisualStyleBackColor = true;
            btnAgregarRelleno.Click += btnAgregarRelleno_Click;
            // 
            // btnPersonalizado
            // 
            btnPersonalizado.BackColor = Color.DarkTurquoise;
            btnPersonalizado.FlatStyle = FlatStyle.System;
            btnPersonalizado.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonalizado.Location = new Point(587, 537);
            btnPersonalizado.Name = "btnPersonalizado";
            btnPersonalizado.Size = new Size(133, 29);
            btnPersonalizado.TabIndex = 37;
            btnPersonalizado.Text = "Ver Personal";
            btnPersonalizado.UseVisualStyleBackColor = false;
            btnPersonalizado.Click += btnVerRelleno_Click;
            // 
            // btnEditarPer
            // 
            btnEditarPer.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPer.Location = new Point(1098, 583);
            btnEditarPer.Name = "btnEditarPer";
            btnEditarPer.Size = new Size(94, 29);
            btnEditarPer.TabIndex = 39;
            btnEditarPer.Text = "Editar";
            btnEditarPer.UseVisualStyleBackColor = true;
            btnEditarPer.Click += btnEditarRelleno_Click;
            // 
            // btnActualizarPer
            // 
            btnActualizarPer.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarPer.Location = new Point(1096, 618);
            btnActualizarPer.Name = "btnActualizarPer";
            btnActualizarPer.Size = new Size(96, 29);
            btnActualizarPer.TabIndex = 40;
            btnActualizarPer.Text = "Actualizar";
            btnActualizarPer.UseVisualStyleBackColor = true;
            btnActualizarPer.Click += btnActualizarRelleno_Click;
            // 
            // btnEliminarPer
            // 
            btnEliminarPer.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPer.Location = new Point(1098, 653);
            btnEliminarPer.Name = "btnEliminarPer";
            btnEliminarPer.Size = new Size(94, 29);
            btnEliminarPer.TabIndex = 41;
            btnEliminarPer.Text = "Eliminar";
            btnEliminarPer.UseVisualStyleBackColor = true;
            btnEliminarPer.Click += btnEliminarRelleno_Click;
            // 
            // btnCancelarPer
            // 
            btnCancelarPer.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPer.Location = new Point(1098, 688);
            btnCancelarPer.Name = "btnCancelarPer";
            btnCancelarPer.Size = new Size(94, 29);
            btnCancelarPer.TabIndex = 42;
            btnCancelarPer.Text = "Cancelar";
            btnCancelarPer.UseVisualStyleBackColor = true;
            // 
            // btnRegresarRelleno
            // 
            btnRegresarRelleno.BackColor = Color.PowderBlue;
            btnRegresarRelleno.FlatStyle = FlatStyle.System;
            btnRegresarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarRelleno.Location = new Point(33, 653);
            btnRegresarRelleno.Name = "btnRegresarRelleno";
            btnRegresarRelleno.Size = new Size(94, 29);
            btnRegresarRelleno.TabIndex = 43;
            btnRegresarRelleno.Text = "Regresar";
            btnRegresarRelleno.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(btnAgregarOpcion);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbOpciones);
            groupBox2.Controls.Add(dgvOpciones);
            groupBox2.Location = new Point(532, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(660, 389);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personalización";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 46);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 50;
            label8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(324, 81);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 49;
            // 
            // btnAgregarOpcion
            // 
            btnAgregarOpcion.FlatStyle = FlatStyle.System;
            btnAgregarOpcion.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarOpcion.Location = new Point(482, 81);
            btnAgregarOpcion.Name = "btnAgregarOpcion";
            btnAgregarOpcion.Size = new Size(147, 29);
            btnAgregarOpcion.TabIndex = 48;
            btnAgregarOpcion.Text = "Agregar opción";
            btnAgregarOpcion.UseVisualStyleBackColor = true;
            btnAgregarOpcion.Click += btnAgregarOpcion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 46);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 47;
            label6.Text = "Opciones";
            // 
            // cbOpciones
            // 
            cbOpciones.FormattingEnabled = true;
            cbOpciones.Location = new Point(24, 81);
            cbOpciones.Name = "cbOpciones";
            cbOpciones.Size = new Size(285, 28);
            cbOpciones.TabIndex = 46;
            // 
            // dgvOpciones
            // 
            dgvOpciones.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOpciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOpciones.Location = new Point(24, 136);
            dgvOpciones.Name = "dgvOpciones";
            dgvOpciones.RowHeadersWidth = 51;
            dgvOpciones.Size = new Size(605, 225);
            dgvOpciones.TabIndex = 45;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1098, 510);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 45;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // PantallaProductoPersonalizado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            Controls.Add(btnRegresarRelleno);
            Controls.Add(btnCancelarPer);
            Controls.Add(btnEliminarPer);
            Controls.Add(btnActualizarPer);
            Controls.Add(btnEditarPer);
            Controls.Add(btnPersonalizado);
            Controls.Add(btnAgregarRelleno);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaProductoPersonalizado";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaRelleno";
            Load += PantallaProductoPersonalizado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOpciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtNombreIdentificador;
        private Label label1;
        private TextBox txtFecha;
        private Button btnAgregarRelleno;
        private Button btnPersonalizado;
        private Button btnEditarPer;
        private Button btnActualizarPer;
        private Button btnEliminarPer;
        private Button btnCancelarPer;
        private Button btnRegresarRelleno;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private ComboBox cbCliente;
        private Label label5;
        private ComboBox cbProductoBase;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnAgregarOpcion;
        private Label label6;
        private ComboBox cbOpciones;
        private DataGridView dgvOpciones;
        private Label lblPrecioVta;
        private Label label7;
        private Button btnRegistrar;
        private Label label8;
        private TextBox txtCantidad;
    }
}