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
            txtUnidadDeMedida = new TextBox();
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
            txtPrecioDeVenta = new TextBox();
            label5 = new Label();
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
            grpCategoria.Controls.Add(label5);
            grpCategoria.Controls.Add(txtPrecioDeVenta);
            grpCategoria.Controls.Add(txtIdCat);
            grpCategoria.Controls.Add(label3);
            grpCategoria.Controls.Add(label2);
            grpCategoria.Controls.Add(label1);
            grpCategoria.Controls.Add(txtUnidadDeMedida);
            grpCategoria.Controls.Add(txtNombreCat);
            grpCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCategoria.Location = new Point(22, 81);
            grpCategoria.Margin = new Padding(3, 2, 3, 2);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Padding = new Padding(3, 2, 3, 2);
            grpCategoria.Size = new Size(434, 294);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Opciones";
            grpCategoria.Enter += grpCategoria_Enter;
            // 
            // txtIdCat
            // 
            txtIdCat.Location = new Point(28, 57);
            txtIdCat.Margin = new Padding(3, 2, 3, 2);
            txtIdCat.Name = "txtIdCat";
            txtIdCat.Size = new Size(97, 22);
            txtIdCat.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 92);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre Opcion";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 163);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 4;
            label2.Text = "Unidad de Medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 3;
            label1.Text = "Identificador";
            // 
            // txtUnidadDeMedida
            // 
            txtUnidadDeMedida.Location = new Point(28, 182);
            txtUnidadDeMedida.Margin = new Padding(3, 2, 3, 2);
            txtUnidadDeMedida.Name = "txtUnidadDeMedida";
            txtUnidadDeMedida.Size = new Size(329, 22);
            txtUnidadDeMedida.TabIndex = 2;
            // 
            // txtNombreCat
            // 
            txtNombreCat.Location = new Point(28, 111);
            txtNombreCat.Margin = new Padding(3, 2, 3, 2);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(329, 22);
            txtNombreCat.TabIndex = 1;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(489, 89);
            dgvCategoria.Margin = new Padding(3, 2, 3, 2);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.Size = new Size(558, 286);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dataGridView1_CellContentClick;
            dgvCategoria.CellDoubleClick += dgvCategoria_CellDoubleClick;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCategoria.Location = new Point(184, 395);
            btnAgregarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(82, 22);
            btnAgregarCategoria.TabIndex = 2;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCategoria.Location = new Point(965, 430);
            btnEditarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(82, 22);
            btnEditarCategoria.TabIndex = 29;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnActualizarCategoria
            // 
            btnActualizarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarCategoria.Location = new Point(965, 457);
            btnActualizarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnActualizarCategoria.Name = "btnActualizarCategoria";
            btnActualizarCategoria.Size = new Size(82, 22);
            btnActualizarCategoria.TabIndex = 30;
            btnActualizarCategoria.Text = "Actualizar";
            btnActualizarCategoria.UseVisualStyleBackColor = true;
            btnActualizarCategoria.Click += btnActualizarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCategoria.Location = new Point(965, 483);
            btnEliminarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(82, 22);
            btnEliminarCategoria.TabIndex = 31;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnCancelarCategoria
            // 
            btnCancelarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCategoria.Location = new Point(965, 509);
            btnCancelarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnCancelarCategoria.Name = "btnCancelarCategoria";
            btnCancelarCategoria.Size = new Size(82, 22);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 52);
            panel1.TabIndex = 33;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1068, 12);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(22, 22);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 38;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1019, 10);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(28, 22);
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
            label4.Location = new Point(119, 12);
            label4.Name = "label4";
            label4.Size = new Size(195, 28);
            label4.TabIndex = 35;
            label4.Text = "Pastelería Soto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btnVerPedido
            // 
            btnVerPedido.BackColor = Color.DarkTurquoise;
            btnVerPedido.FlatStyle = FlatStyle.System;
            btnVerPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerPedido.Location = new Point(489, 395);
            btnVerPedido.Margin = new Padding(3, 2, 3, 2);
            btnVerPedido.Name = "btnVerPedido";
            btnVerPedido.Size = new Size(113, 22);
            btnVerPedido.TabIndex = 34;
            btnVerPedido.Text = "Ver Categoria";
            btnVerPedido.UseVisualStyleBackColor = false;
            btnVerPedido.Click += btnVerPedido_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.PaleTurquoise;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(965, 394);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 23);
            btnRegistrar.TabIndex = 35;
            btnRegistrar.Text = "Registrar Categoria";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnRegresarCategoria
            // 
            btnRegresarCategoria.BackColor = Color.PowderBlue;
            btnRegresarCategoria.FlatStyle = FlatStyle.System;
            btnRegresarCategoria.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarCategoria.Location = new Point(18, 509);
            btnRegresarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnRegresarCategoria.Name = "btnRegresarCategoria";
            btnRegresarCategoria.Size = new Size(82, 22);
            btnRegresarCategoria.TabIndex = 36;
            btnRegresarCategoria.Text = "Regresar";
            btnRegresarCategoria.UseVisualStyleBackColor = false;
            btnRegresarCategoria.Click += btnRegresarCategoria_Click;
            // 
            // txtPrecioDeVenta
            // 
            txtPrecioDeVenta.Location = new Point(28, 241);
            txtPrecioDeVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioDeVenta.Name = "txtPrecioDeVenta";
            txtPrecioDeVenta.Size = new Size(181, 22);
            txtPrecioDeVenta.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 222);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 8;
            label5.Text = "Precio de Venta";
            // 
            // PantallaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1111, 547);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaCategoria";
            Opacity = 0.88D;
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
        private TextBox txtUnidadDeMedida;
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
        private Label label5;
        private TextBox txtPrecioDeVenta;
    }
}