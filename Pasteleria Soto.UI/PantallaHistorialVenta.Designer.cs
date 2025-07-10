namespace Pasteleria_Soto.UI
{
    partial class PantallaHistorialVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaHistorialVenta));
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dtpFechaFinalVenta = new DateTimePicker();
            dtpFechaInicialVenta = new DateTimePicker();
            btnVerVentas = new Button();
            btnCancelarVenta = new Button();
            label5 = new Label();
            label3 = new Label();
            dtvDetalleVenta = new DataGridView();
            dgvListVenta = new DataGridView();
            btnRegresarMenu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListVenta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label16);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 67);
            panel1.TabIndex = 0;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1191, 18);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 67;
            btnCerrarCliente.TabStop = false;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1136, 18);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 66;
            btnMnzcliente.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.LightSeaGreen;
            label16.Location = new Point(137, 18);
            label16.Name = "label16";
            label16.Size = new Size(240, 35);
            label16.TabIndex = 43;
            label16.Text = "Pastelería Soto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtpFechaFinalVenta);
            groupBox2.Controls.Add(dtpFechaInicialVenta);
            groupBox2.Controls.Add(btnVerVentas);
            groupBox2.Controls.Add(btnCancelarVenta);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(18, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1208, 169);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial De Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(636, 38);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 38;
            label2.Text = "Fecha Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 37;
            label1.Text = "Fecha Inicial";
            // 
            // dtpFechaFinalVenta
            // 
            dtpFechaFinalVenta.Location = new Point(636, 76);
            dtpFechaFinalVenta.Name = "dtpFechaFinalVenta";
            dtpFechaFinalVenta.Size = new Size(516, 26);
            dtpFechaFinalVenta.TabIndex = 1;
            // 
            // dtpFechaInicialVenta
            // 
            dtpFechaInicialVenta.Location = new Point(32, 76);
            dtpFechaInicialVenta.Name = "dtpFechaInicialVenta";
            dtpFechaInicialVenta.Size = new Size(516, 26);
            dtpFechaInicialVenta.TabIndex = 0;
            // 
            // btnVerVentas
            // 
            btnVerVentas.BackColor = Color.DarkTurquoise;
            btnVerVentas.FlatStyle = FlatStyle.System;
            btnVerVentas.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerVentas.Location = new Point(978, 118);
            btnVerVentas.Name = "btnVerVentas";
            btnVerVentas.Size = new Size(176, 29);
            btnVerVentas.TabIndex = 36;
            btnVerVentas.Text = "Mostrar Ventas";
            btnVerVentas.UseVisualStyleBackColor = false;
            btnVerVentas.Click += btnVerVentas_Click;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 513);
            label5.Name = "label5";
            label5.Size = new Size(133, 18);
            label5.TabIndex = 46;
            label5.Text = "Detalle de Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 270);
            label3.Name = "label3";
            label3.Size = new Size(144, 18);
            label3.TabIndex = 45;
            label3.Text = "Registro de Ventas";
            // 
            // dtvDetalleVenta
            // 
            dtvDetalleVenta.BackgroundColor = Color.Ivory;
            dtvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDetalleVenta.Location = new Point(18, 549);
            dtvDetalleVenta.Name = "dtvDetalleVenta";
            dtvDetalleVenta.RowHeadersWidth = 51;
            dtvDetalleVenta.Size = new Size(1208, 165);
            dtvDetalleVenta.TabIndex = 44;
            // 
            // dgvListVenta
            // 
            dgvListVenta.BackgroundColor = Color.Ivory;
            dgvListVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListVenta.Location = new Point(18, 324);
            dgvListVenta.Name = "dgvListVenta";
            dgvListVenta.RowHeadersWidth = 51;
            dgvListVenta.Size = new Size(1208, 167);
            dgvListVenta.TabIndex = 43;
            dgvListVenta.CellDoubleClick += dgvListVenta_CellDoubleClick;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.BackColor = Color.PowderBlue;
            btnRegresarMenu.FlatStyle = FlatStyle.System;
            btnRegresarMenu.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarMenu.Location = new Point(23, 762);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(94, 29);
            btnRegresarMenu.TabIndex = 48;
            btnRegresarMenu.Text = "Menú";
            btnRegresarMenu.UseVisualStyleBackColor = false;
            btnRegresarMenu.Click += btnRegresarMenu_Click;
            // 
            // PantallaHistorialVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1252, 819);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dtvDetalleVenta);
            Controls.Add(dgvListVenta);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaHistorialVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaHistorialVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label16;
        private PictureBox pictureBox1;
        private PictureBox btnCerrarCliente;
        private PictureBox btnMnzcliente;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaFinalVenta;
        private DateTimePicker dtpFechaInicialVenta;
        private Button btnVerVentas;
        private Button btnCancelarVenta;
        private Label label5;
        private Label label3;
        private DataGridView dtvDetalleVenta;
        private DataGridView dgvListVenta;
        private Button btnRegresarMenu;
    }
}