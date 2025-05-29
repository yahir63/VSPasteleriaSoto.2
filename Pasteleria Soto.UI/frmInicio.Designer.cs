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
            btnPedido = new Button();
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
            panel1.Controls.Add(btnPedido);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnCategoria);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(btnNuevoPedido);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 482);
            panel1.TabIndex = 0;
            // 
            // btnPedido
            // 
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.Location = new Point(0, 312);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(245, 56);
            btnPedido.TabIndex = 6;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnProducto
            // 
            btnProducto.FlatStyle = FlatStyle.Popup;
            btnProducto.Location = new Point(0, 75);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(245, 56);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Nuevo Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.Location = new Point(0, 151);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(245, 56);
            btnCategoria.TabIndex = 3;
            btnCategoria.Text = "Nueva Opcion";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.FlatStyle = FlatStyle.Popup;
            btnAgregarUsuario.Location = new Point(0, 232);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(245, 56);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Nuevo Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.FlatStyle = FlatStyle.Popup;
            btnNuevoPedido.Location = new Point(0, 3);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(245, 56);
            btnNuevoPedido.TabIndex = 1;
            btnNuevoPedido.Text = "Nuevo Cliente";
            btnNuevoPedido.UseVisualStyleBackColor = true;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1066, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(22, 22);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1020, 10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 22);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1111, 482);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnPedido;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
    }
}
