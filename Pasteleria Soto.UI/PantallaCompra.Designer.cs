namespace Pasteleria_Soto.UI
{
    partial class PantallaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCompra));
            grpCompra = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtNumeroFactura = new TextBox();
            cbProveedores = new ComboBox();
            grpDetalleCompra = new GroupBox();
            btnAgregarCompra = new Button();
            label6 = new Label();
            txtCantidadCompra = new TextBox();
            label5 = new Label();
            txtPrecioVenta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPrecioCompra = new TextBox();
            cbProductosGen = new ComboBox();
            dgvCompra = new DataGridView();
            btnGuardar = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            label8 = new Label();
            btnMnzcliente = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            grpCompra.SuspendLayout();
            grpDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpCompra
            // 
            grpCompra.Controls.Add(label2);
            grpCompra.Controls.Add(label1);
            grpCompra.Controls.Add(txtNumeroFactura);
            grpCompra.Controls.Add(cbProveedores);
            grpCompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCompra.Location = new Point(45, 135);
            grpCompra.Name = "grpCompra";
            grpCompra.Size = new Size(509, 202);
            grpCompra.TabIndex = 0;
            grpCompra.TabStop = false;
            grpCompra.Text = "Datos de la Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 46);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 3;
            label2.Text = "Número Factura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Proveedores";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(227, 79);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(125, 26);
            txtNumeroFactura.TabIndex = 1;
            // 
            // cbProveedores
            // 
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Location = new Point(29, 78);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(151, 28);
            cbProveedores.TabIndex = 0;
            // 
            // grpDetalleCompra
            // 
            grpDetalleCompra.Controls.Add(btnAgregarCompra);
            grpDetalleCompra.Controls.Add(label6);
            grpDetalleCompra.Controls.Add(txtCantidadCompra);
            grpDetalleCompra.Controls.Add(label5);
            grpDetalleCompra.Controls.Add(txtPrecioVenta);
            grpDetalleCompra.Controls.Add(label3);
            grpDetalleCompra.Controls.Add(label4);
            grpDetalleCompra.Controls.Add(txtPrecioCompra);
            grpDetalleCompra.Controls.Add(cbProductosGen);
            grpDetalleCompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetalleCompra.Location = new Point(615, 135);
            grpDetalleCompra.Name = "grpDetalleCompra";
            grpDetalleCompra.Size = new Size(562, 202);
            grpDetalleCompra.TabIndex = 1;
            grpDetalleCompra.TabStop = false;
            grpDetalleCompra.Text = "Datos de la Compra";
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.BackColor = Color.PaleTurquoise;
            btnAgregarCompra.FlatStyle = FlatStyle.Flat;
            btnAgregarCompra.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCompra.Location = new Point(227, 150);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(101, 31);
            btnAgregarCompra.TabIndex = 59;
            btnAgregarCompra.Text = "Agregar ";
            btnAgregarCompra.UseVisualStyleBackColor = false;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 129);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 7;
            label6.Text = "Cantidad ";
            // 
            // txtCantidadCompra
            // 
            txtCantidadCompra.Location = new Point(29, 152);
            txtCantidadCompra.Name = "txtCantidadCompra";
            txtCantidadCompra.Size = new Size(125, 26);
            txtCantidadCompra.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 46);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 5;
            label5.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(394, 79);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(125, 26);
            txtPrecioVenta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 46);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Precio Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 46);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "Productos ";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(227, 79);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(125, 26);
            txtPrecioCompra.TabIndex = 1;
            // 
            // cbProductosGen
            // 
            cbProductosGen.FormattingEnabled = true;
            cbProductosGen.Location = new Point(29, 78);
            cbProductosGen.Name = "cbProductosGen";
            cbProductosGen.Size = new Size(151, 28);
            cbProductosGen.TabIndex = 0;
            // 
            // dgvCompra
            // 
            dgvCompra.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(45, 382);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowHeadersWidth = 51;
            dgvCompra.Size = new Size(1132, 188);
            dgvCompra.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.PaleTurquoise;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1076, 653);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 31);
            btnGuardar.TabIndex = 60;
            btnGuardar.Text = "Facturar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(189, 580);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 583);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 62;
            label7.Text = "Total de la compra ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 68);
            panel1.TabIndex = 63;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1200, 20);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 65;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(139, 20);
            label8.Name = "label8";
            label8.Size = new Size(240, 35);
            label8.TabIndex = 65;
            label8.Text = "Pastelería Soto";
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1145, 20);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 64;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.PaleTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 654);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 64;
            button1.Text = "Menú";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PantallaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 717);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(dgvCompra);
            Controls.Add(btnGuardar);
            Controls.Add(grpDetalleCompra);
            Controls.Add(grpCompra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaCompra";
            Load += PantallaCompra_Load;
            grpCompra.ResumeLayout(false);
            grpCompra.PerformLayout();
            grpDetalleCompra.ResumeLayout(false);
            grpDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpCompra;
        private TextBox txtNumeroFactura;
        private ComboBox cbProveedores;
        private Label label2;
        private Label label1;
        private GroupBox grpDetalleCompra;
        private Label label3;
        private Label label4;
        private TextBox txtPrecioCompra;
        private ComboBox cbProductosGen;
        private Label label6;
        private TextBox txtCantidadCompra;
        private Label label5;
        private TextBox txtPrecioVenta;
        private Button btnAgregarCompra;
        private DataGridView dgvCompra;
        private Button btnGuardar;
        private TextBox txtTotal;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox btnCerrarCliente;
        private PictureBox btnMnzcliente;
        private Button button1;
    }
}