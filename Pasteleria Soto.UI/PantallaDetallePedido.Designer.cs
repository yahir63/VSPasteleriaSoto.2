namespace Pasteleria_Soto.UI
{
    partial class PantallaDetallePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDetallePedido));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            v = new Label();
            label5 = new Label();
            label4 = new Label();
            txtSubTotal = new TextBox();
            txtAdelanto = new TextBox();
            txtTotal = new TextBox();
            txtCedula = new TextBox();
            txtDireccion = new TextBox();
            txtCantDP = new TextBox();
            label3 = new Label();
            txtHoraEntrega = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtFecha = new TextBox();
            dgvDetallePedido = new DataGridView();
            btnAgregarPedido = new Button();
            btnVerDPedido = new Button();
            btnRegistrarPedido = new Button();
            btnEditarPedido = new Button();
            btnActualizarPedido = new Button();
            btnEliminarPedido = new Button();
            btnCancelarPedido = new Button();
            btnRegresarPedido = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 67);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1215, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 40;
            btnCerrarCliente.TabStop = false;
            btnCerrarCliente.Click += btnCerrarCliente_Click;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1167, 16);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 40;
            btnMnzcliente.TabStop = false;
            btnMnzcliente.Click += btnMnzcliente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(v);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(txtAdelanto);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCantDP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoraEntrega);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Location = new Point(36, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 359);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Pedido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 268);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 18;
            label7.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 197);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 17;
            label6.Text = "Adelanto";
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(21, 268);
            v.Name = "v";
            v.Size = new Size(72, 20);
            v.TabIndex = 16;
            v.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 36);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 15;
            label5.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 116);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 14;
            label4.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(271, 297);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(117, 27);
            txtSubTotal.TabIndex = 13;
            // 
            // txtAdelanto
            // 
            txtAdelanto.Location = new Point(271, 223);
            txtAdelanto.Name = "txtAdelanto";
            txtAdelanto.Size = new Size(117, 27);
            txtAdelanto.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(271, 144);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(117, 27);
            txtTotal.TabIndex = 11;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(271, 67);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(117, 27);
            txtCedula.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(21, 297);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(117, 27);
            txtDireccion.TabIndex = 9;
            // 
            // txtCantDP
            // 
            txtCantDP.Location = new Point(21, 223);
            txtCantDP.Name = "txtCantDP";
            txtCantDP.Size = new Size(117, 27);
            txtCantDP.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 197);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // txtHoraEntrega
            // 
            txtHoraEntrega.Location = new Point(21, 144);
            txtHoraEntrega.Name = "txtHoraEntrega";
            txtHoraEntrega.Size = new Size(117, 27);
            txtHoraEntrega.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 113);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Hora de Entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 2;
            label1.Text = "Fecha de Entrega";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(21, 67);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(117, 27);
            txtFecha.TabIndex = 1;
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.BackgroundColor = Color.Ivory;
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(511, 113);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(688, 359);
            dgvDetallePedido.TabIndex = 25;
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.BackColor = Color.DarkCyan;
            btnAgregarPedido.FlatStyle = FlatStyle.System;
            btnAgregarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPedido.Location = new Point(147, 507);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(130, 31);
            btnAgregarPedido.TabIndex = 26;
            btnAgregarPedido.Text = "Agregar ";
            btnAgregarPedido.UseVisualStyleBackColor = false;
            // 
            // btnVerDPedido
            // 
            btnVerDPedido.BackColor = Color.DarkTurquoise;
            btnVerDPedido.FlatStyle = FlatStyle.System;
            btnVerDPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDPedido.Location = new Point(511, 508);
            btnVerDPedido.Name = "btnVerDPedido";
            btnVerDPedido.Size = new Size(112, 29);
            btnVerDPedido.TabIndex = 33;
            btnVerDPedido.Text = "Ver Pedidos";
            btnVerDPedido.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPedido
            // 
            btnRegistrarPedido.BackColor = Color.PaleTurquoise;
            btnRegistrarPedido.FlatStyle = FlatStyle.Popup;
            btnRegistrarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPedido.Location = new Point(1105, 508);
            btnRegistrarPedido.Name = "btnRegistrarPedido";
            btnRegistrarPedido.Size = new Size(94, 31);
            btnRegistrarPedido.TabIndex = 34;
            btnRegistrarPedido.Text = "Registrar Pedido";
            btnRegistrarPedido.UseVisualStyleBackColor = false;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPedido.Location = new Point(1105, 560);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(94, 29);
            btnEditarPedido.TabIndex = 35;
            btnEditarPedido.Text = "Editar";
            btnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPedido
            // 
            btnActualizarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarPedido.Location = new Point(1105, 595);
            btnActualizarPedido.Name = "btnActualizarPedido";
            btnActualizarPedido.Size = new Size(94, 29);
            btnActualizarPedido.TabIndex = 36;
            btnActualizarPedido.Text = "Actualizar";
            btnActualizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPedido.Location = new Point(1105, 630);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(94, 29);
            btnEliminarPedido.TabIndex = 37;
            btnEliminarPedido.Text = "Eliminar";
            btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPedido.Location = new Point(1105, 665);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(94, 29);
            btnCancelarPedido.TabIndex = 38;
            btnCancelarPedido.Text = "Cancelar";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRegresarPedido
            // 
            btnRegresarPedido.BackColor = Color.PowderBlue;
            btnRegresarPedido.FlatStyle = FlatStyle.System;
            btnRegresarPedido.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarPedido.Location = new Point(14, 665);
            btnRegresarPedido.Name = "btnRegresarPedido";
            btnRegresarPedido.Size = new Size(126, 29);
            btnRegresarPedido.TabIndex = 39;
            btnRegresarPedido.Text = "Regresar ";
            btnRegresarPedido.UseVisualStyleBackColor = false;
            // 
            // PantallaDetallePedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnRegresarPedido);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnEliminarPedido);
            Controls.Add(btnActualizarPedido);
            Controls.Add(btnEditarPedido);
            Controls.Add(btnRegistrarPedido);
            Controls.Add(btnVerDPedido);
            Controls.Add(btnAgregarPedido);
            Controls.Add(dgvDetallePedido);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaDetallePedido";
            Opacity = 0.88D;
            Text = "PantallaDetallePedido";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtHoraEntrega;
        private Label label2;
        private Label label1;
        private TextBox txtFecha;
        private TextBox txtCedula;
        private TextBox txtDireccion;
        private TextBox txtCantDP;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label v;
        private Label label5;
        private Label label4;
        private TextBox txtSubTotal;
        private TextBox txtAdelanto;
        private TextBox txtTotal;
        private DataGridView dgvDetallePedido;
        private Button btnAgregarPedido;
        private Button btnVerDPedido;
        private Button btnRegistrarPedido;
        private Button btnEditarPedido;
        private Button btnActualizarPedido;
        private Button btnEliminarPedido;
        private Button btnCancelarPedido;
        private Button btnRegresarPedido;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private PictureBox pictureBox1;
    }
}