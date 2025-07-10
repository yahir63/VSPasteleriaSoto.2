namespace Pasteleria_Soto.UI
{
    partial class PantallaListaPedidosVigentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaListaPedidosVigentes));
            btnCancelarVenta = new Button();
            panel1 = new Panel();
            btnCerrarProducto = new PictureBox();
            btnMnzProducto = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnRegistrarVenta = new Button();
            btnVerPedidos = new Button();
            btnRegresarSabor = new Button();
            dgvListPedidos = new DataGridView();
            dtvDetalleVenta = new DataGridView();
            groupBox2 = new GroupBox();
            btnCancelados = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            btnFacturar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvDetalleVenta).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarVenta.Location = new Point(569, 172);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(94, 29);
            btnCancelarVenta.TabIndex = 34;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarSabor_Click;
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
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.PaleTurquoise;
            btnRegistrarVenta.FlatStyle = FlatStyle.Popup;
            btnRegistrarVenta.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnRegistrarVenta.Location = new Point(1099, 732);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(141, 31);
            btnRegistrarVenta.TabIndex = 35;
            btnRegistrarVenta.Text = "Ver Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarSabor_Click;
            // 
            // btnVerPedidos
            // 
            btnVerPedidos.BackColor = Color.DarkTurquoise;
            btnVerPedidos.FlatStyle = FlatStyle.System;
            btnVerPedidos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerPedidos.Location = new Point(978, 118);
            btnVerPedidos.Name = "btnVerPedidos";
            btnVerPedidos.Size = new Size(176, 29);
            btnVerPedidos.TabIndex = 36;
            btnVerPedidos.Text = "Mostrar Pedidos";
            btnVerPedidos.UseVisualStyleBackColor = false;
            btnVerPedidos.Click += btnVerSabor_Click;
            // 
            // btnRegresarSabor
            // 
            btnRegresarSabor.BackColor = Color.PowderBlue;
            btnRegresarSabor.FlatStyle = FlatStyle.System;
            btnRegresarSabor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnRegresarSabor.Location = new Point(32, 747);
            btnRegresarSabor.Name = "btnRegresarSabor";
            btnRegresarSabor.Size = new Size(94, 29);
            btnRegresarSabor.TabIndex = 37;
            btnRegresarSabor.Text = "Menú";
            btnRegresarSabor.UseVisualStyleBackColor = false;
            btnRegresarSabor.Click += btnRegresarSabor_Click;
            // 
            // dgvListPedidos
            // 
            dgvListPedidos.BackgroundColor = Color.Ivory;
            dgvListPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPedidos.Location = new Point(32, 318);
            dgvListPedidos.Name = "dgvListPedidos";
            dgvListPedidos.RowHeadersWidth = 51;
            dgvListPedidos.Size = new Size(1208, 167);
            dgvListPedidos.TabIndex = 38;
            dgvListPedidos.CellContentClick += dgvListPedidos_CellContentClick;
            dgvListPedidos.CellDoubleClick += dgvListPedidos_CellDoubleClick;
            // 
            // dtvDetalleVenta
            // 
            dtvDetalleVenta.BackgroundColor = Color.Ivory;
            dtvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDetalleVenta.Location = new Point(32, 543);
            dtvDetalleVenta.Name = "dtvDetalleVenta";
            dtvDetalleVenta.RowHeadersWidth = 51;
            dtvDetalleVenta.Size = new Size(1208, 165);
            dtvDetalleVenta.TabIndex = 39;
            dtvDetalleVenta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelados);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtpFechaFinal);
            groupBox2.Controls.Add(dtpFechaInicial);
            groupBox2.Controls.Add(btnVerPedidos);
            groupBox2.Controls.Add(btnCancelarVenta);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1208, 169);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial de Ventas";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnCancelados
            // 
            btnCancelados.BackColor = Color.DarkTurquoise;
            btnCancelados.FlatStyle = FlatStyle.System;
            btnCancelados.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelados.Location = new Point(58, 118);
            btnCancelados.Name = "btnCancelados";
            btnCancelados.Size = new Size(176, 29);
            btnCancelados.TabIndex = 44;
            btnCancelados.Text = "Mostrar Cancelados";
            btnCancelados.UseVisualStyleBackColor = false;
            btnCancelados.Click += btnCancelados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(636, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 38;
            label2.Text = "Fecha Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 37;
            label1.Text = "Fecha Inicial";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(636, 76);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(516, 26);
            dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(32, 76);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(516, 26);
            dtpFechaInicial.TabIndex = 0;
            dtpFechaInicial.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 264);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 41;
            label3.Text = "Registro de Ventas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 507);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 42;
            label5.Text = "Detalle de Venta";
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.PaleTurquoise;
            btnFacturar.FlatStyle = FlatStyle.Popup;
            btnFacturar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnFacturar.Location = new Point(925, 732);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(141, 31);
            btnFacturar.TabIndex = 43;
            btnFacturar.Text = "Facutrar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // PantallaListaPedidosVigentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 788);
            Controls.Add(btnFacturar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(dtvDetalleVenta);
            Controls.Add(dgvListPedidos);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(btnRegresarSabor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaListaPedidosVigentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += PantallaSabor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvDetalleVenta).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private DataGridView dgvSabor;
        private Button btnAgregarSabor;
        private Button btnCancelarVenta;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox btnMnzProducto;
        private PictureBox btnCerrarProducto;
        private TextBox txtSabor;
        private Button btnRegistrarVenta;
        private Button btnVerPedidos;
        private Button btnRegresarSabor;
        private Label label3;
        private TextBox txtPrecioSabor;
        private DataGridView dgvListPedidos;
        private DataGridView dtvDetalleVenta;
        private GroupBox groupBox2;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
        private Label label5;
        private Button btnFacturar;
        private Button btnCancelados;
    }
}