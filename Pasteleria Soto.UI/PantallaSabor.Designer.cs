namespace Pasteleria_Soto.UI
{
    partial class PantallaSabor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSabor));
            groupBox1 = new GroupBox();
            txtSabor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            dgvSabor = new DataGridView();
            btnAgregarSabor = new Button();
            btnActualizarSabor = new Button();
            btnEditarSabor = new Button();
            btnEliminarSabor = new Button();
            btnCancelarSabor = new Button();
            panel1 = new Panel();
            btnCerrarProducto = new PictureBox();
            btnMnzProducto = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnRegistrarSabor = new Button();
            btnVerSabor = new Button();
            btnRegresarSabor = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSabor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSabor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(72, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 372);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selección de Sabor";
            // 
            // txtSabor
            // 
            txtSabor.Location = new Point(21, 106);
            txtSabor.Name = "txtSabor";
            txtSabor.Size = new Size(391, 27);
            txtSabor.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 174);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 59);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Sabor";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(21, 231);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(391, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // dgvSabor
            // 
            dgvSabor.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSabor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSabor.Location = new Point(586, 116);
            dgvSabor.Name = "dgvSabor";
            dgvSabor.RowHeadersWidth = 51;
            dgvSabor.Size = new Size(644, 357);
            dgvSabor.TabIndex = 1;
            dgvSabor.CellContentClick += dgvSabor_CellContentClick;
            dgvSabor.CellDoubleClick += dgvSabor_CellDoubleClick;
            // 
            // btnAgregarSabor
            // 
            btnAgregarSabor.FlatStyle = FlatStyle.System;
            btnAgregarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSabor.Location = new Point(238, 492);
            btnAgregarSabor.Name = "btnAgregarSabor";
            btnAgregarSabor.Size = new Size(94, 29);
            btnAgregarSabor.TabIndex = 3;
            btnAgregarSabor.Text = "Agregar";
            btnAgregarSabor.UseVisualStyleBackColor = true;
            btnAgregarSabor.Click += btnAgregarSabor_Click;
            // 
            // btnActualizarSabor
            // 
            btnActualizarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarSabor.Location = new Point(1136, 576);
            btnActualizarSabor.Name = "btnActualizarSabor";
            btnActualizarSabor.Size = new Size(96, 29);
            btnActualizarSabor.TabIndex = 31;
            btnActualizarSabor.Text = "Actualizar";
            btnActualizarSabor.UseVisualStyleBackColor = true;
            btnActualizarSabor.Click += btnActualizarSabor_Click;
            // 
            // btnEditarSabor
            // 
            btnEditarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarSabor.Location = new Point(1136, 541);
            btnEditarSabor.Name = "btnEditarSabor";
            btnEditarSabor.Size = new Size(94, 29);
            btnEditarSabor.TabIndex = 32;
            btnEditarSabor.Text = "Editar";
            btnEditarSabor.UseVisualStyleBackColor = true;
            btnEditarSabor.Click += btnEditarSabor_Click;
            // 
            // btnEliminarSabor
            // 
            btnEliminarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarSabor.Location = new Point(1136, 611);
            btnEliminarSabor.Name = "btnEliminarSabor";
            btnEliminarSabor.Size = new Size(94, 29);
            btnEliminarSabor.TabIndex = 33;
            btnEliminarSabor.Text = "Eliminar";
            btnEliminarSabor.UseVisualStyleBackColor = true;
            btnEliminarSabor.Click += btnEliminarSabor_Click;
            // 
            // btnCancelarSabor
            // 
            btnCancelarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarSabor.Location = new Point(1136, 646);
            btnCancelarSabor.Name = "btnCancelarSabor";
            btnCancelarSabor.Size = new Size(94, 29);
            btnCancelarSabor.TabIndex = 34;
            btnCancelarSabor.Text = "Cancelar";
            btnCancelarSabor.UseVisualStyleBackColor = true;
            btnCancelarSabor.Click += btnCancelarSabor_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarProducto);
            panel1.Controls.Add(btnMnzProducto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 67);
            panel1.TabIndex = 6;
            // 
            // btnCerrarProducto
            // 
            btnCerrarProducto.Image = (Image)resources.GetObject("btnCerrarProducto.Image");
            btnCerrarProducto.Location = new Point(1215, 16);
            btnCerrarProducto.Margin = new Padding(3, 4, 3, 4);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(25, 29);
            btnCerrarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarProducto.TabIndex = 35;
            btnCerrarProducto.TabStop = false;
            btnCerrarProducto.Click += btnCerrarProducto_Click;
            // 
            // btnMnzProducto
            // 
            btnMnzProducto.Image = (Image)resources.GetObject("btnMnzProducto.Image");
            btnMnzProducto.Location = new Point(1161, 16);
            btnMnzProducto.Margin = new Padding(3, 4, 3, 4);
            btnMnzProducto.Name = "btnMnzProducto";
            btnMnzProducto.Size = new Size(32, 29);
            btnMnzProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzProducto.TabIndex = 35;
            btnMnzProducto.TabStop = false;
            btnMnzProducto.Click += btnMnzProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(133, 16);
            label4.Name = "label4";
            label4.Size = new Size(240, 35);
            label4.TabIndex = 34;
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
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // btnRegistrarSabor
            // 
            btnRegistrarSabor.BackColor = Color.PaleTurquoise;
            btnRegistrarSabor.FlatStyle = FlatStyle.Popup;
            btnRegistrarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSabor.Location = new Point(1136, 490);
            btnRegistrarSabor.Name = "btnRegistrarSabor";
            btnRegistrarSabor.Size = new Size(94, 31);
            btnRegistrarSabor.TabIndex = 35;
            btnRegistrarSabor.Text = "Registrar ";
            btnRegistrarSabor.UseVisualStyleBackColor = false;
            btnRegistrarSabor.Click += btnRegistrarSabor_Click;
            // 
            // btnVerSabor
            // 
            btnVerSabor.BackColor = Color.DarkTurquoise;
            btnVerSabor.FlatStyle = FlatStyle.System;
            btnVerSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerSabor.Location = new Point(586, 492);
            btnVerSabor.Name = "btnVerSabor";
            btnVerSabor.Size = new Size(112, 29);
            btnVerSabor.TabIndex = 36;
            btnVerSabor.Text = "Ver Sabor";
            btnVerSabor.UseVisualStyleBackColor = false;
            btnVerSabor.Click += btnVerSabor_Click;
            // 
            // btnRegresarSabor
            // 
            btnRegresarSabor.BackColor = Color.PowderBlue;
            btnRegresarSabor.FlatStyle = FlatStyle.System;
            btnRegresarSabor.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarSabor.Location = new Point(53, 646);
            btnRegresarSabor.Name = "btnRegresarSabor";
            btnRegresarSabor.Size = new Size(94, 29);
            btnRegresarSabor.TabIndex = 37;
            btnRegresarSabor.Text = "Regresar";
            btnRegresarSabor.UseVisualStyleBackColor = false;
            btnRegresarSabor.Click += btnRegresarSabor_Click;
            // 
            // PantallaSabor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnRegresarSabor);
            Controls.Add(btnVerSabor);
            Controls.Add(btnRegistrarSabor);
            Controls.Add(panel1);
            Controls.Add(btnCancelarSabor);
            Controls.Add(btnEliminarSabor);
            Controls.Add(btnEditarSabor);
            Controls.Add(btnActualizarSabor);
            Controls.Add(btnAgregarSabor);
            Controls.Add(dgvSabor);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaSabor";
            Opacity = 0.88D;
            Text = " ";
            Load += PantallaSabor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSabor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private DataGridView dgvSabor;
        private Button btnAgregarSabor;
        private Button btnActualizarSabor;
        private Button btnEditarSabor;
        private Button btnEliminarSabor;
        private Button btnCancelarSabor;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox btnMnzProducto;
        private PictureBox btnCerrarProducto;
        private TextBox txtSabor;
        private Button btnRegistrarSabor;
        private Button btnVerSabor;
        private Button btnRegresarSabor;
    }
}