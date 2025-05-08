namespace Pasteleria_Soto.UI
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            panel1 = new Panel();
            btnDetalle = new Button();
            btnRelleno = new Button();
            btnSabor = new Button();
            btnProducto = new Button();
            btnCategoria = new Button();
            btnAgregarUsuario = new Button();
            btnNuevoPedido = new Button();
            pictureBox1 = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnDetalle);
            panel1.Controls.Add(btnRelleno);
            panel1.Controls.Add(btnSabor);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnCategoria);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(btnNuevoPedido);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 729);
            panel1.TabIndex = 0;
            // 
            // btnDetalle
            // 
            btnDetalle.FlatStyle = FlatStyle.Popup;
            btnDetalle.Location = new Point(0, 626);
            btnDetalle.Margin = new Padding(3, 4, 3, 4);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(280, 97);
            btnDetalle.TabIndex = 6;
            btnDetalle.Text = "Factura";
            btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnRelleno
            // 
            btnRelleno.FlatStyle = FlatStyle.Popup;
            btnRelleno.Location = new Point(0, 415);
            btnRelleno.Margin = new Padding(3, 4, 3, 4);
            btnRelleno.Name = "btnRelleno";
            btnRelleno.Size = new Size(280, 97);
            btnRelleno.TabIndex = 2;
            btnRelleno.Text = "Relleno";
            btnRelleno.UseVisualStyleBackColor = true;
            btnRelleno.Click += btnRelleno_Click;
            // 
            // btnSabor
            // 
            btnSabor.FlatStyle = FlatStyle.Popup;
            btnSabor.Location = new Point(0, 311);
            btnSabor.Margin = new Padding(3, 4, 3, 4);
            btnSabor.Name = "btnSabor";
            btnSabor.Size = new Size(280, 97);
            btnSabor.TabIndex = 5;
            btnSabor.Text = "Sabor";
            btnSabor.UseVisualStyleBackColor = true;
            btnSabor.Click += btnSabor_Click;
            // 
            // btnProducto
            // 
            btnProducto.FlatStyle = FlatStyle.Popup;
            btnProducto.Location = new Point(0, 105);
            btnProducto.Margin = new Padding(3, 4, 3, 4);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(280, 97);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.Location = new Point(0, 208);
            btnCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(280, 97);
            btnCategoria.TabIndex = 3;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.FlatStyle = FlatStyle.Popup;
            btnAgregarUsuario.Location = new Point(0, 519);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(280, 97);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Nuevo Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.FlatStyle = FlatStyle.Popup;
            btnNuevoPedido.Location = new Point(0, 4);
            btnNuevoPedido.Margin = new Padding(3, 4, 3, 4);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(280, 97);
            btnNuevoPedido.TabIndex = 1;
            btnNuevoPedido.Text = "Nuevo Cliente";
            btnNuevoPedido.UseVisualStyleBackColor = true;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1218, 13);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 29);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1166, 13);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio";
            Load += PantallaInicio_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoPedido;
        private Button btnAgregarUsuario;
        private PictureBox pictureBox1;
        private Button btnProducto;
        private Button btnCategoria;
        private Button btnRelleno;
        private Button btnSabor;
        private Button btnDetalle;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
    }
}
