namespace Pasteleria_Soto.UI
{
    partial class PantallaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistro));
            grbRegistroPedido = new GroupBox();
            txtCedula = new TextBox();
            txtCiudad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegistrarCliente = new Button();
            btnRegresarCliente = new Button();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            btnVerCLiente = new Button();
            btnEditar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            grbRegistroPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            SuspendLayout();
            // 
            // grbRegistroPedido
            // 
            grbRegistroPedido.BackColor = Color.AliceBlue;
            grbRegistroPedido.Controls.Add(txtCedula);
            grbRegistroPedido.Controls.Add(txtCiudad);
            grbRegistroPedido.Controls.Add(label5);
            grbRegistroPedido.Controls.Add(label4);
            grbRegistroPedido.Controls.Add(txtDireccion);
            grbRegistroPedido.Controls.Add(txtTelefono);
            grbRegistroPedido.Controls.Add(txtNombre);
            grbRegistroPedido.Controls.Add(label3);
            grbRegistroPedido.Controls.Add(label2);
            grbRegistroPedido.Controls.Add(label1);
            grbRegistroPedido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbRegistroPedido.Location = new Point(82, 119);
            grbRegistroPedido.Name = "grbRegistroPedido";
            grbRegistroPedido.Size = new Size(339, 413);
            grbRegistroPedido.TabIndex = 0;
            grbRegistroPedido.TabStop = false;
            grbRegistroPedido.Text = "Datos del cliente";
            grbRegistroPedido.Enter += grbRegistroPedido_Enter;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(22, 373);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(286, 26);
            txtCedula.TabIndex = 15;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(22, 293);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(286, 26);
            txtCiudad.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 339);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 13;
            label5.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 261);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 12;
            label4.Text = "Ciudad";
            label4.Click += label4_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 215);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(286, 26);
            txtDireccion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 141);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(286, 26);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 26);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 181);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.PowderBlue;
            btnRegistrarCliente.FlatStyle = FlatStyle.System;
            btnRegistrarCliente.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCliente.Location = new Point(568, 532);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(151, 29);
            btnRegistrarCliente.TabIndex = 25;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnRegresarCliente
            // 
            btnRegresarCliente.BackColor = Color.PowderBlue;
            btnRegresarCliente.FlatStyle = FlatStyle.System;
            btnRegresarCliente.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarCliente.Location = new Point(35, 688);
            btnRegresarCliente.Name = "btnRegresarCliente";
            btnRegresarCliente.Size = new Size(94, 29);
            btnRegresarCliente.TabIndex = 24;
            btnRegresarCliente.Text = "Regresar";
            btnRegresarCliente.UseVisualStyleBackColor = false;
            btnRegresarCliente.Click += btnRegresarCliente_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.Ivory;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(568, 143);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(655, 372);
            dgvDatos.TabIndex = 23;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PowderBlue;
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(130, 562);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnVerCLiente
            // 
            btnVerCLiente.BackColor = Color.PaleTurquoise;
            btnVerCLiente.FlatStyle = FlatStyle.Popup;
            btnVerCLiente.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCLiente.Location = new Point(1108, 532);
            btnVerCLiente.Name = "btnVerCLiente";
            btnVerCLiente.Size = new Size(115, 29);
            btnVerCLiente.TabIndex = 26;
            btnVerCLiente.Text = "Ver Clientes";
            btnVerCLiente.UseVisualStyleBackColor = false;
            btnVerCLiente.Click += btnVerCLiente_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(1113, 583);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 29);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(1113, 618);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 29);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1113, 653);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 29);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(1113, 688);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 29);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 79);
            panel1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(130, 23);
            label6.Name = "label6";
            label6.Size = new Size(240, 35);
            label6.TabIndex = 33;
            label6.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1214, 29);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 32;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1176, 29);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 32;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // PantallaRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 729);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEditar);
            Controls.Add(btnVerCLiente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(btnRegresarCliente);
            Controls.Add(dgvDatos);
            Controls.Add(btnAgregar);
            Controls.Add(grbRegistroPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegistro";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Registro";
            Load += PantallaRegistro_Load;
            grbRegistroPedido.ResumeLayout(false);
            grbRegistroPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbRegistroPedido;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Button btnRegistrarCliente;
        private Button btnRegresarCliente;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private Button btnVerCLiente;
        private Label label5;
        private Label label4;
        private TextBox txtCiudad;
        private TextBox txtCedula;
        private Button btnEditar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Panel panel1;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private PictureBox pictureBox1;
        private Label label6;
    }
}