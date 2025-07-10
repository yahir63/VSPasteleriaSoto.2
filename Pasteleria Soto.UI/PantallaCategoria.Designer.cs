namespace Pasteleria_Soto.UI
{
    partial class PantallaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCategoria));
            grpCategoria = new GroupBox();
            txtIdCat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtNombreCat = new TextBox();
            dgvCategoria = new DataGridView();
            btnAgregarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnActualizarCategoria = new Button();
            btnEliminarCategoria = new Button();
            btnCancelarCategoria = new Button();
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnVerPedido = new Button();
            btnRegistrar = new Button();
            btnRegresarCategoria = new Button();
            grpCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpCategoria
            // 
            grpCategoria.Controls.Add(txtIdCat);
            grpCategoria.Controls.Add(label3);
            grpCategoria.Controls.Add(label2);
            grpCategoria.Controls.Add(label1);
            grpCategoria.Controls.Add(txtDescripcion);
            grpCategoria.Controls.Add(txtNombreCat);
            grpCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCategoria.Location = new Point(25, 108);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(496, 392);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Selección de Categoria";
            grpCategoria.Enter += grpCategoria_Enter;
            // 
            // txtIdCat
            // 
            txtIdCat.Location = new Point(32, 76);
            txtIdCat.Name = "txtIdCat";
            txtIdCat.Size = new Size(110, 26);
            txtIdCat.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 157);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre Categoria";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 271);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Identificador";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(32, 319);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(375, 26);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombreCat
            // 
            txtNombreCat.Location = new Point(32, 195);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(375, 26);
            txtNombreCat.TabIndex = 1;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(559, 119);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.Size = new Size(638, 381);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dataGridView1_CellContentClick;
            dgvCategoria.CellDoubleClick += dgvCategoria_CellDoubleClick;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCategoria.Location = new Point(210, 527);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(94, 29);
            btnAgregarCategoria.TabIndex = 2;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEditarCategoria.Location = new Point(1103, 574);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(94, 29);
            btnEditarCategoria.TabIndex = 29;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnActualizarCategoria
            // 
            btnActualizarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnActualizarCategoria.Location = new Point(1103, 609);
            btnActualizarCategoria.Name = "btnActualizarCategoria";
            btnActualizarCategoria.Size = new Size(94, 29);
            btnActualizarCategoria.TabIndex = 30;
            btnActualizarCategoria.Text = "Actualizar";
            btnActualizarCategoria.UseVisualStyleBackColor = true;
            btnActualizarCategoria.Click += btnActualizarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEliminarCategoria.Location = new Point(1103, 644);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(94, 29);
            btnEliminarCategoria.TabIndex = 31;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnCancelarCategoria
            // 
            btnCancelarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnCancelarCategoria.Location = new Point(1103, 679);
            btnCancelarCategoria.Name = "btnCancelarCategoria";
            btnCancelarCategoria.Size = new Size(94, 29);
            btnCancelarCategoria.TabIndex = 32;
            btnCancelarCategoria.Text = "Cancelar";
            btnCancelarCategoria.UseVisualStyleBackColor = true;
            btnCancelarCategoria.Click += btnCancelarCategoria_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 69);
            panel1.TabIndex = 33;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1220, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 38;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1165, 13);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 37;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(136, 16);
            label4.Name = "label4";
            label4.Size = new Size(240, 35);
            label4.TabIndex = 35;
            label4.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btnVerPedido
            // 
            btnVerPedido.BackColor = Color.DarkTurquoise;
            btnVerPedido.FlatStyle = FlatStyle.System;
            btnVerPedido.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerPedido.Location = new Point(559, 527);
            btnVerPedido.Name = "btnVerPedido";
            btnVerPedido.Size = new Size(129, 29);
            btnVerPedido.TabIndex = 34;
            btnVerPedido.Text = "Ver Categoria";
            btnVerPedido.UseVisualStyleBackColor = false;
            btnVerPedido.Click += btnVerPedido_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.PaleTurquoise;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(1103, 525);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 31);
            btnRegistrar.TabIndex = 35;
            btnRegistrar.Text = "Registrar Categoria";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnRegresarCategoria
            // 
            btnRegresarCategoria.BackColor = Color.PowderBlue;
            btnRegresarCategoria.FlatStyle = FlatStyle.System;
            btnRegresarCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarCategoria.Location = new Point(20, 679);
            btnRegresarCategoria.Name = "btnRegresarCategoria";
            btnRegresarCategoria.Size = new Size(94, 29);
            btnRegresarCategoria.TabIndex = 36;
            btnRegresarCategoria.Text = "Menú";
            btnRegresarCategoria.UseVisualStyleBackColor = false;
            btnRegresarCategoria.Click += btnRegresarCategoria_Click;
            // 
            // PantallaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 717);
            Controls.Add(btnRegresarCategoria);
            Controls.Add(btnRegistrar);
            Controls.Add(btnVerPedido);
            Controls.Add(panel1);
            Controls.Add(btnCancelarCategoria);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnActualizarCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(dgvCategoria);
            Controls.Add(grpCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaCategoria";
            Load += PantallaCategoria_Load;
            grpCategoria.ResumeLayout(false);
            grpCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCategoria;
        private TextBox txtDescripcion;
        private TextBox txtNombreCat;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCategoria;
        private Button btnAgregarCategoria;
        private Button btnEditarCategoria;
        private Button btnActualizarCategoria;
        private Button btnEliminarCategoria;
        private Button btnCancelarCategoria;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnVerPedido;
        private Button btnRegistrar;
        private Button btnRegresarCategoria;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private TextBox txtIdCat;
    }
}