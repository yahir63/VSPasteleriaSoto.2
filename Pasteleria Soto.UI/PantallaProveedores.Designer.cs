namespace Pasteleria_Soto.UI
{
    partial class PantallaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaProveedores));
            grpDatosProveedor = new GroupBox();
            txtUbicacionProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDatosProveedor = new DataGridView();
            btnRegresarCliente = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnEditar = new Button();
            btnVerProveedor = new Button();
            btnAgregarProveedor = new Button();
            btnRegistrarProveedor = new Button();
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            label4 = new Label();
            btnMnzcliente = new PictureBox();
            pictureBox1 = new PictureBox();
            grpDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosProveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpDatosProveedor
            // 
            grpDatosProveedor.BackColor = Color.LightCyan;
            grpDatosProveedor.Controls.Add(txtUbicacionProveedor);
            grpDatosProveedor.Controls.Add(txtTelefonoProveedor);
            grpDatosProveedor.Controls.Add(txtNombreProveedor);
            grpDatosProveedor.Controls.Add(label3);
            grpDatosProveedor.Controls.Add(label2);
            grpDatosProveedor.Controls.Add(label1);
            grpDatosProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosProveedor.Location = new Point(44, 94);
            grpDatosProveedor.Name = "grpDatosProveedor";
            grpDatosProveedor.Size = new Size(404, 440);
            grpDatosProveedor.TabIndex = 1;
            grpDatosProveedor.TabStop = false;
            grpDatosProveedor.Text = "Datos del Proveedor ";
            grpDatosProveedor.Enter += grpDatosProveedor_Enter;
            // 
            // txtUbicacionProveedor
            // 
            txtUbicacionProveedor.Location = new Point(46, 277);
            txtUbicacionProveedor.Name = "txtUbicacionProveedor";
            txtUbicacionProveedor.Size = new Size(286, 26);
            txtUbicacionProveedor.TabIndex = 11;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Location = new Point(46, 203);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(286, 26);
            txtTelefonoProveedor.TabIndex = 10;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(46, 137);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(286, 26);
            txtNombreProveedor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 243);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Ubicación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 177);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 109);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Proveedor";
            // 
            // dgvDatosProveedor
            // 
            dgvDatosProveedor.BackgroundColor = Color.Ivory;
            dgvDatosProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosProveedor.Location = new Point(492, 94);
            dgvDatosProveedor.Name = "dgvDatosProveedor";
            dgvDatosProveedor.RowHeadersWidth = 51;
            dgvDatosProveedor.Size = new Size(696, 440);
            dgvDatosProveedor.TabIndex = 24;
            dgvDatosProveedor.CellDoubleClick += dgvDatosProveedor_CellDoubleClick;
            // 
            // btnRegresarCliente
            // 
            btnRegresarCliente.BackColor = Color.PowderBlue;
            btnRegresarCliente.FlatStyle = FlatStyle.System;
            btnRegresarCliente.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarCliente.Location = new Point(20, 744);
            btnRegresarCliente.Name = "btnRegresarCliente";
            btnRegresarCliente.Size = new Size(94, 29);
            btnRegresarCliente.TabIndex = 25;
            btnRegresarCliente.Text = "Menú";
            btnRegresarCliente.UseVisualStyleBackColor = false;
            btnRegresarCliente.Click += btnRegresarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(1078, 731);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 29);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(1078, 696);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 29);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnActualizar.Location = new Point(1078, 661);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 29);
            btnActualizar.TabIndex = 33;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(1078, 626);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 29);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVerProveedor
            // 
            btnVerProveedor.BackColor = Color.PaleTurquoise;
            btnVerProveedor.FlatStyle = FlatStyle.Popup;
            btnVerProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnVerProveedor.Location = new Point(492, 573);
            btnVerProveedor.Name = "btnVerProveedor";
            btnVerProveedor.Size = new Size(166, 29);
            btnVerProveedor.TabIndex = 36;
            btnVerProveedor.Text = "Ver Proveedores";
            btnVerProveedor.UseVisualStyleBackColor = false;
            btnVerProveedor.Click += btnVerProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.PowderBlue;
            btnAgregarProveedor.FlatStyle = FlatStyle.System;
            btnAgregarProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnAgregarProveedor.Location = new Point(165, 573);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(94, 29);
            btnAgregarProveedor.TabIndex = 37;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnRegistrarProveedor
            // 
            btnRegistrarProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnRegistrarProveedor.Location = new Point(1078, 573);
            btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            btnRegistrarProveedor.Size = new Size(110, 29);
            btnRegistrarProveedor.TabIndex = 38;
            btnRegistrarProveedor.Text = "Registrar";
            btnRegistrarProveedor.UseVisualStyleBackColor = true;
            btnRegistrarProveedor.Click += btnRegistrarProveedor_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 63);
            panel1.TabIndex = 39;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1198, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 41;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(136, 16);
            label4.Name = "label4";
            label4.Size = new Size(240, 35);
            label4.TabIndex = 41;
            label4.Text = "Pastelería Soto";
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1149, 16);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 40;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // PantallaProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1252, 819);
            Controls.Add(panel1);
            Controls.Add(btnRegistrarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnVerProveedor);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegresarCliente);
            Controls.Add(dgvDatosProveedor);
            Controls.Add(grpDatosProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaProveedores";
            grpDatosProveedor.ResumeLayout(false);
            grpDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosProveedor;
        private TextBox txtCedula;
        private TextBox txtCiudad;
        private Label label5;
        private Label label4;
        private TextBox txtUbicacionProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtNombreProveedor;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatosProveedor;
        private Button btnRegresarCliente;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnEditar;
        private Button btnRegistrarCliente;
        private Button btnVerProveedor;
        private Button btnAgregarProveedor;
        private Button btnRegistrarProveedor;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox btnCerrarCliente;
        private PictureBox btnMnzcliente;
    }
}