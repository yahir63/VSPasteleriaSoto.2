namespace Pasteleria_Soto.UI
{
    partial class PantallaBaño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBaño));
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            pictureBox1 = new PictureBox();
            grpBano = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombreBano = new TextBox();
            dgvBano = new DataGridView();
            btnAgregarBano = new Button();
            btnVerBano = new Button();
            btnRegistrarBano = new Button();
            btnEditarBano = new Button();
            btnActualizarBano = new Button();
            btnEliminarBano = new Button();
            btnCancelarBano = new Button();
            btnRegresarBano = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBano).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 76);
            panel1.TabIndex = 0;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1141, 22);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 39;
            btnCerrarCliente.TabStop = false;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1091, 22);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 38;
            btnMnzcliente.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // grpBano
            // 
            grpBano.Controls.Add(label3);
            grpBano.Controls.Add(label2);
            grpBano.Controls.Add(label1);
            grpBano.Controls.Add(txtPrecio);
            grpBano.Controls.Add(txtDescripcion);
            grpBano.Controls.Add(txtNombreBano);
            grpBano.Location = new Point(137, 116);
            grpBano.Name = "grpBano";
            grpBano.Size = new Size(442, 258);
            grpBano.TabIndex = 1;
            grpBano.TabStop = false;
            grpBano.Text = "Selección de Baño";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 173);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 107);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripción\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre Baño";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(57, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(328, 27);
            txtPrecio.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(57, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(328, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombreBano
            // 
            txtNombreBano.Location = new Point(56, 62);
            txtNombreBano.Name = "txtNombreBano";
            txtNombreBano.Size = new Size(328, 27);
            txtNombreBano.TabIndex = 0;
            // 
            // dgvBano
            // 
            dgvBano.BackgroundColor = SystemColors.ControlLightLight;
            dgvBano.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBano.Location = new Point(651, 125);
            dgvBano.Name = "dgvBano";
            dgvBano.RowHeadersWidth = 51;
            dgvBano.Size = new Size(484, 249);
            dgvBano.TabIndex = 2;
            dgvBano.CellDoubleClick += dgvBano_CellDoubleClick;
            // 
            // btnAgregarBano
            // 
            btnAgregarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarBano.Location = new Point(286, 399);
            btnAgregarBano.Name = "btnAgregarBano";
            btnAgregarBano.Size = new Size(94, 29);
            btnAgregarBano.TabIndex = 3;
            btnAgregarBano.Text = "Agregar";
            btnAgregarBano.UseVisualStyleBackColor = true;
            btnAgregarBano.Click += btnAgregarBano_Click;
            // 
            // btnVerBano
            // 
            btnVerBano.BackColor = Color.DarkTurquoise;
            btnVerBano.FlatStyle = FlatStyle.System;
            btnVerBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerBano.Location = new Point(651, 389);
            btnVerBano.Name = "btnVerBano";
            btnVerBano.Size = new Size(112, 29);
            btnVerBano.TabIndex = 35;
            btnVerBano.Text = "Ver Baño";
            btnVerBano.UseVisualStyleBackColor = false;
            btnVerBano.Click += btnVerBano_Click;
            // 
            // btnRegistrarBano
            // 
            btnRegistrarBano.BackColor = Color.PaleTurquoise;
            btnRegistrarBano.FlatStyle = FlatStyle.Popup;
            btnRegistrarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarBano.Location = new Point(1051, 389);
            btnRegistrarBano.Name = "btnRegistrarBano";
            btnRegistrarBano.Size = new Size(94, 31);
            btnRegistrarBano.TabIndex = 36;
            btnRegistrarBano.Text = "Registrar Baño";
            btnRegistrarBano.UseVisualStyleBackColor = false;
            btnRegistrarBano.Click += btnRegistrarBano_Click;
            // 
            // btnEditarBano
            // 
            btnEditarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarBano.Location = new Point(1051, 441);
            btnEditarBano.Name = "btnEditarBano";
            btnEditarBano.Size = new Size(94, 29);
            btnEditarBano.TabIndex = 37;
            btnEditarBano.Text = "Editar";
            btnEditarBano.UseVisualStyleBackColor = true;
            btnEditarBano.Click += btnEditarBano_Click;
            // 
            // btnActualizarBano
            // 
            btnActualizarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarBano.Location = new Point(1051, 476);
            btnActualizarBano.Name = "btnActualizarBano";
            btnActualizarBano.Size = new Size(94, 29);
            btnActualizarBano.TabIndex = 38;
            btnActualizarBano.Text = "Actualizar";
            btnActualizarBano.UseVisualStyleBackColor = true;
            btnActualizarBano.Click += btnActualizarBano_Click;
            // 
            // btnEliminarBano
            // 
            btnEliminarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarBano.Location = new Point(1051, 511);
            btnEliminarBano.Name = "btnEliminarBano";
            btnEliminarBano.Size = new Size(94, 29);
            btnEliminarBano.TabIndex = 39;
            btnEliminarBano.Text = "Eliminar";
            btnEliminarBano.UseVisualStyleBackColor = true;
            btnEliminarBano.Click += btnEliminarBano_Click;
            // 
            // btnCancelarBano
            // 
            btnCancelarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarBano.Location = new Point(1051, 546);
            btnCancelarBano.Name = "btnCancelarBano";
            btnCancelarBano.Size = new Size(94, 29);
            btnCancelarBano.TabIndex = 40;
            btnCancelarBano.Text = "Cancelar";
            btnCancelarBano.UseVisualStyleBackColor = true;
            btnCancelarBano.Click += btnCancelarBano_Click;
            // 
            // btnRegresarBano
            // 
            btnRegresarBano.BackColor = Color.PowderBlue;
            btnRegresarBano.FlatStyle = FlatStyle.System;
            btnRegresarBano.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarBano.Location = new Point(40, 546);
            btnRegresarBano.Name = "btnRegresarBano";
            btnRegresarBano.Size = new Size(94, 29);
            btnRegresarBano.TabIndex = 41;
            btnRegresarBano.Text = "Regresar";
            btnRegresarBano.UseVisualStyleBackColor = false;
            btnRegresarBano.Click += btnRegresarBano_Click;
            // 
            // PantallaBaño
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1192, 654);
            Controls.Add(btnRegresarBano);
            Controls.Add(btnCancelarBano);
            Controls.Add(btnEliminarBano);
            Controls.Add(btnActualizarBano);
            Controls.Add(btnEditarBano);
            Controls.Add(btnRegistrarBano);
            Controls.Add(btnVerBano);
            Controls.Add(btnAgregarBano);
            Controls.Add(dgvBano);
            Controls.Add(grpBano);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaBaño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaBano";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBano.ResumeLayout(false);
            grpBano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBano).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpBano;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombreBano;
        private DataGridView dgvBano;
        private PictureBox pictureBox1;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private Button btnAgregarBano;
        private Button btnVerBano;
        private Button btnRegistrarBano;
        private Button btnEditarBano;
        private Button btnActualizarBano;
        private Button btnEliminarBano;
        private Button btnCancelarBano;
        private Button btnRegresarBano;
    }
}