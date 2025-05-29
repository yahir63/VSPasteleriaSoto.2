namespace Pasteleria_Soto.UI
{
    partial class PantallaRelleno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRelleno));
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            txtRelleno = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDescripRelleno = new TextBox();
            dgvRelleno = new DataGridView();
            btnAgregarRelleno = new Button();
            btnVerRelleno = new Button();
            btnRegistrarRelleno = new Button();
            btnEditarRelleno = new Button();
            btnActualizarRelleno = new Button();
            btnEliminarRelleno = new Button();
            btnCancelarRelleno = new Button();
            btnRegresarRelleno = new Button();
            txtPrecioRelleno = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelleno).BeginInit();
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrecioRelleno);
            groupBox1.Controls.Add(txtRelleno);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripRelleno);
            groupBox1.Location = new Point(71, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 393);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selección de Relleno";
            // 
            // txtRelleno
            // 
            txtRelleno.Location = new Point(21, 127);
            txtRelleno.Name = "txtRelleno";
            txtRelleno.Size = new Size(391, 27);
            txtRelleno.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 207);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Relleno";
            // 
            // txtDescripRelleno
            // 
            txtDescripRelleno.Location = new Point(21, 259);
            txtDescripRelleno.Name = "txtDescripRelleno";
            txtDescripRelleno.Size = new Size(391, 27);
            txtDescripRelleno.TabIndex = 1;
            // 
            // dgvRelleno
            // 
            dgvRelleno.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRelleno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelleno.Location = new Point(587, 120);
            dgvRelleno.Name = "dgvRelleno";
            dgvRelleno.RowHeadersWidth = 51;
            dgvRelleno.Size = new Size(605, 357);
            dgvRelleno.TabIndex = 2;
            dgvRelleno.CellDoubleClick += dgvRelleno_CellDoubleClick;
            // 
            // btnAgregarRelleno
            // 
            btnAgregarRelleno.FlatStyle = FlatStyle.System;
            btnAgregarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRelleno.Location = new Point(223, 529);
            btnAgregarRelleno.Name = "btnAgregarRelleno";
            btnAgregarRelleno.Size = new Size(94, 29);
            btnAgregarRelleno.TabIndex = 4;
            btnAgregarRelleno.Text = "Agregar";
            btnAgregarRelleno.UseVisualStyleBackColor = true;
            btnAgregarRelleno.Click += btnAgregarRelleno_Click;
            // 
            // btnVerRelleno
            // 
            btnVerRelleno.BackColor = Color.DarkTurquoise;
            btnVerRelleno.FlatStyle = FlatStyle.System;
            btnVerRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerRelleno.Location = new Point(587, 493);
            btnVerRelleno.Name = "btnVerRelleno";
            btnVerRelleno.Size = new Size(112, 29);
            btnVerRelleno.TabIndex = 37;
            btnVerRelleno.Text = "Ver Relleno";
            btnVerRelleno.UseVisualStyleBackColor = false;
            btnVerRelleno.Click += btnVerRelleno_Click;
            // 
            // btnRegistrarRelleno
            // 
            btnRegistrarRelleno.BackColor = Color.PaleTurquoise;
            btnRegistrarRelleno.FlatStyle = FlatStyle.Popup;
            btnRegistrarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarRelleno.Location = new Point(1098, 491);
            btnRegistrarRelleno.Name = "btnRegistrarRelleno";
            btnRegistrarRelleno.Size = new Size(94, 31);
            btnRegistrarRelleno.TabIndex = 38;
            btnRegistrarRelleno.Text = "Registrar ";
            btnRegistrarRelleno.UseVisualStyleBackColor = false;
            btnRegistrarRelleno.Click += btnRegistrarRelleno_Click;
            // 
            // btnEditarRelleno
            // 
            btnEditarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarRelleno.Location = new Point(1098, 538);
            btnEditarRelleno.Name = "btnEditarRelleno";
            btnEditarRelleno.Size = new Size(94, 29);
            btnEditarRelleno.TabIndex = 39;
            btnEditarRelleno.Text = "Editar";
            btnEditarRelleno.UseVisualStyleBackColor = true;
            btnEditarRelleno.Click += btnEditarRelleno_Click;
            // 
            // btnActualizarRelleno
            // 
            btnActualizarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarRelleno.Location = new Point(1096, 573);
            btnActualizarRelleno.Name = "btnActualizarRelleno";
            btnActualizarRelleno.Size = new Size(96, 29);
            btnActualizarRelleno.TabIndex = 40;
            btnActualizarRelleno.Text = "Actualizar";
            btnActualizarRelleno.UseVisualStyleBackColor = true;
            btnActualizarRelleno.Click += btnActualizarRelleno_Click;
            // 
            // btnEliminarRelleno
            // 
            btnEliminarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarRelleno.Location = new Point(1098, 608);
            btnEliminarRelleno.Name = "btnEliminarRelleno";
            btnEliminarRelleno.Size = new Size(94, 29);
            btnEliminarRelleno.TabIndex = 41;
            btnEliminarRelleno.Text = "Eliminar";
            btnEliminarRelleno.UseVisualStyleBackColor = true;
            btnEliminarRelleno.Click += btnEliminarRelleno_Click;
            // 
            // btnCancelarRelleno
            // 
            btnCancelarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarRelleno.Location = new Point(1098, 643);
            btnCancelarRelleno.Name = "btnCancelarRelleno";
            btnCancelarRelleno.Size = new Size(94, 29);
            btnCancelarRelleno.TabIndex = 42;
            btnCancelarRelleno.Text = "Cancelar";
            btnCancelarRelleno.UseVisualStyleBackColor = true;
            btnCancelarRelleno.Click += btnCancelarRelleno_Click;
            // 
            // btnRegresarRelleno
            // 
            btnRegresarRelleno.BackColor = Color.PowderBlue;
            btnRegresarRelleno.FlatStyle = FlatStyle.System;
            btnRegresarRelleno.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarRelleno.Location = new Point(71, 643);
            btnRegresarRelleno.Name = "btnRegresarRelleno";
            btnRegresarRelleno.Size = new Size(94, 29);
            btnRegresarRelleno.TabIndex = 43;
            btnRegresarRelleno.Text = "Regresar";
            btnRegresarRelleno.UseVisualStyleBackColor = false;
            btnRegresarRelleno.Click += btnRegresarRelleno_Click;
            // 
            // txtPrecioRelleno
            // 
            txtPrecioRelleno.Location = new Point(21, 344);
            txtPrecioRelleno.Name = "txtPrecioRelleno";
            txtPrecioRelleno.Size = new Size(391, 27);
            txtPrecioRelleno.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 311);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // PantallaRelleno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnRegresarRelleno);
            Controls.Add(btnCancelarRelleno);
            Controls.Add(btnEliminarRelleno);
            Controls.Add(btnActualizarRelleno);
            Controls.Add(btnEditarRelleno);
            Controls.Add(btnRegistrarRelleno);
            Controls.Add(btnVerRelleno);
            Controls.Add(btnAgregarRelleno);
            Controls.Add(dgvRelleno);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRelleno";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaRelleno";
            Load += PantallaRelleno_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelleno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtRelleno;
        private Label label2;
        private Label label1;
        private TextBox txtDescripRelleno;
        private DataGridView dgvRelleno;
        private Button btnAgregarRelleno;
        private Button btnVerRelleno;
        private Button btnRegistrarRelleno;
        private Button btnEditarRelleno;
        private Button btnActualizarRelleno;
        private Button btnEliminarRelleno;
        private Button btnCancelarRelleno;
        private Button btnRegresarRelleno;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private Label label3;
        private TextBox txtPrecioRelleno;
    }
}