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
            panelCatalogos = new Panel();
            button2 = new Button();
            btnCategoria = new Button();
            btnProducto = new Button();
            btnBaño = new Button();
            btnSabor = new Button();
            btnAgregarUsuario = new Button();
            btnNuevoPedido = new Button();
            btnCatalogos = new Button();
            btnProveedores = new Button();
            btnPedido = new Button();
            pictureBox1 = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            btnPedidos = new Button();
            btnCompra = new Button();
            panelPedidos = new Panel();
            panelCompra = new Panel();
            panel1.SuspendLayout();
            panelCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel2.SuspendLayout();
            panelPedidos.SuspendLayout();
            panelCompra.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(panelCatalogos);
            panel1.Controls.Add(btnCatalogos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 717);
            panel1.TabIndex = 0;
            // 
            // panelCatalogos
            // 
            panelCatalogos.BackColor = Color.Teal;
            panelCatalogos.Controls.Add(button2);
            panelCatalogos.Controls.Add(btnNuevoPedido);
            panelCatalogos.Controls.Add(btnCategoria);
            panelCatalogos.Controls.Add(btnSabor);
            panelCatalogos.Controls.Add(btnAgregarUsuario);
            panelCatalogos.Controls.Add(btnProducto);
            panelCatalogos.Controls.Add(btnBaño);
            panelCatalogos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelCatalogos.Location = new Point(0, 105);
            panelCatalogos.Name = "panelCatalogos";
            panelCatalogos.Size = new Size(280, 612);
            panelCatalogos.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Turquoise;
            button2.Location = new Point(2, 524);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(277, 90);
            button2.TabIndex = 8;
            button2.Text = "Proveedores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.ForeColor = Color.Turquoise;
            btnCategoria.Location = new Point(2, 169);
            btnCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(277, 94);
            btnCategoria.TabIndex = 3;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnProducto
            // 
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatStyle = FlatStyle.Popup;
            btnProducto.ForeColor = Color.Turquoise;
            btnProducto.Location = new Point(3, 83);
            btnProducto.Margin = new Padding(3, 4, 3, 4);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(277, 84);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnBaño
            // 
            btnBaño.FlatAppearance.BorderSize = 0;
            btnBaño.FlatStyle = FlatStyle.Popup;
            btnBaño.ForeColor = Color.Turquoise;
            btnBaño.Location = new Point(3, 351);
            btnBaño.Margin = new Padding(3, 4, 3, 4);
            btnBaño.Name = "btnBaño";
            btnBaño.Size = new Size(277, 81);
            btnBaño.TabIndex = 5;
            btnBaño.Text = "Opciones";
            btnBaño.UseVisualStyleBackColor = true;
            btnBaño.Click += btnBaño_Click;
            // 
            // btnSabor
            // 
            btnSabor.FlatAppearance.BorderSize = 0;
            btnSabor.FlatStyle = FlatStyle.Popup;
            btnSabor.ForeColor = Color.Turquoise;
            btnSabor.Location = new Point(3, 260);
            btnSabor.Margin = new Padding(3, 4, 3, 4);
            btnSabor.Name = "btnSabor";
            btnSabor.Size = new Size(277, 86);
            btnSabor.TabIndex = 5;
            btnSabor.Text = "Personalizado";
            btnSabor.UseVisualStyleBackColor = true;
            btnSabor.Click += btnSabor_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatStyle = FlatStyle.Popup;
            btnAgregarUsuario.ForeColor = Color.Turquoise;
            btnAgregarUsuario.Location = new Point(2, 437);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(277, 85);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Nuevo Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.FlatAppearance.BorderSize = 0;
            btnNuevoPedido.FlatStyle = FlatStyle.Popup;
            btnNuevoPedido.ForeColor = Color.Turquoise;
            btnNuevoPedido.Location = new Point(0, 0);
            btnNuevoPedido.Margin = new Padding(3, 4, 3, 4);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(277, 84);
            btnNuevoPedido.TabIndex = 1;
            btnNuevoPedido.Text = "Cliente";
            btnNuevoPedido.UseVisualStyleBackColor = true;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // btnCatalogos
            // 
            btnCatalogos.BackColor = Color.Turquoise;
            btnCatalogos.FlatAppearance.BorderSize = 0;
            btnCatalogos.FlatStyle = FlatStyle.Popup;
            btnCatalogos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCatalogos.ForeColor = SystemColors.ActiveCaptionText;
            btnCatalogos.Location = new Point(0, 12);
            btnCatalogos.Name = "btnCatalogos";
            btnCatalogos.Size = new Size(280, 93);
            btnCatalogos.TabIndex = 0;
            btnCatalogos.Text = "Gestion de Catálogos";
            btnCatalogos.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatStyle = FlatStyle.Popup;
            btnProveedores.ForeColor = Color.Turquoise;
            btnProveedores.Location = new Point(3, 281);
            btnProveedores.Margin = new Padding(3, 4, 3, 4);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(267, 114);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "Historial de Venta";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnPedido
            // 
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.Turquoise;
            btnPedido.Location = new Point(0, 38);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(267, 116);
            btnPedido.TabIndex = 6;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(472, 119);
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
            btnCerrar.Location = new Point(230, 25);
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
            btnMinimizar.Location = new Point(178, 25);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Turquoise;
            button1.Location = new Point(2, 154);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(267, 125);
            button1.TabIndex = 7;
            button1.Text = "Historial de Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.Turquoise;
            button3.Location = new Point(0, 2);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(267, 94);
            button3.TabIndex = 8;
            button3.Text = "Compra";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(btnPedidos);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnCompra);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(panelPedidos);
            panel2.Controls.Add(panelCompra);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1003, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 717);
            panel2.TabIndex = 9;
            // 
            // btnPedidos
            // 
            btnPedidos.FlatStyle = FlatStyle.Popup;
            btnPedidos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(0, 248);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(267, 117);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Gestion de Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCompra
            // 
            btnCompra.FlatStyle = FlatStyle.Popup;
            btnCompra.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompra.Location = new Point(0, 61);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(267, 90);
            btnCompra.TabIndex = 2;
            btnCompra.Text = "Gestion de Compras";
            btnCompra.UseVisualStyleBackColor = true;
            // 
            // panelPedidos
            // 
            panelPedidos.BackColor = Color.Teal;
            panelPedidos.Controls.Add(btnPedido);
            panelPedidos.Controls.Add(btnProveedores);
            panelPedidos.Controls.Add(button1);
            panelPedidos.Location = new Point(0, 327);
            panelPedidos.Name = "panelPedidos";
            panelPedidos.Size = new Size(267, 390);
            panelPedidos.TabIndex = 1;
            // 
            // panelCompra
            // 
            panelCompra.BackColor = Color.Teal;
            panelCompra.Controls.Add(button3);
            panelCompra.Location = new Point(0, 150);
            panelCompra.Name = "panelCompra";
            panelCompra.Size = new Size(267, 102);
            panelCompra.TabIndex = 0;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1270, 717);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio";
            Load += PantallaInicio_Load;
            panel1.ResumeLayout(false);
            panelCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel2.ResumeLayout(false);
            panelPedidos.ResumeLayout(false);
            panelCompra.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoPedido;
        private Button btnAgregarUsuario;
        private PictureBox pictureBox1;
        private Button btnProducto;
        private Button btnCategoria;
        private Button btnSabor;
        private Button btnPedido;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Button btnBaño;
        private Button btnProveedores;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button btnCatalogos;
        private Panel panelCatalogos;
        private Panel panel2;
        private Button btnPedidos;
        private Button btnCompra;
        private Panel panelPedidos;
        private Panel panelCompra;
    }
}
