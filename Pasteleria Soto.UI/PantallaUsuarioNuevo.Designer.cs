namespace Pasteleria_Soto.UI
{
    partial class PantallaUsuarioNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaUsuarioNuevo));
            panel1 = new Panel();
            btnCerrarCliente = new PictureBox();
            btnMnzcliente = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtClaveUsuario = new TextBox();
            grpNuevoUsuario = new GroupBox();
            btnAgregarUsuario = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpNuevoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnCerrarCliente);
            panel1.Controls.Add(btnMnzcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 68);
            panel1.TabIndex = 0;
            // 
            // btnCerrarCliente
            // 
            btnCerrarCliente.Image = (Image)resources.GetObject("btnCerrarCliente.Image");
            btnCerrarCliente.Location = new Point(1215, 16);
            btnCerrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCerrarCliente.Name = "btnCerrarCliente";
            btnCerrarCliente.Size = new Size(25, 29);
            btnCerrarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarCliente.TabIndex = 34;
            btnCerrarCliente.TabStop = false;
            // 
            // btnMnzcliente
            // 
            btnMnzcliente.Image = (Image)resources.GetObject("btnMnzcliente.Image");
            btnMnzcliente.Location = new Point(1160, 16);
            btnMnzcliente.Margin = new Padding(3, 4, 3, 4);
            btnMnzcliente.Name = "btnMnzcliente";
            btnMnzcliente.Size = new Size(32, 29);
            btnMnzcliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMnzcliente.TabIndex = 33;
            btnMnzcliente.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(754, 129);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 215);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 104);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Usuario ";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(107, 144);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(286, 26);
            txtNombreUsuario.TabIndex = 10;
            // 
            // txtClaveUsuario
            // 
            txtClaveUsuario.Location = new Point(107, 261);
            txtClaveUsuario.Name = "txtClaveUsuario";
            txtClaveUsuario.Size = new Size(286, 26);
            txtClaveUsuario.TabIndex = 12;
            // 
            // grpNuevoUsuario
            // 
            grpNuevoUsuario.Controls.Add(label3);
            grpNuevoUsuario.Controls.Add(txtClaveUsuario);
            grpNuevoUsuario.Controls.Add(label2);
            grpNuevoUsuario.Controls.Add(txtNombreUsuario);
            grpNuevoUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpNuevoUsuario.Location = new Point(59, 123);
            grpNuevoUsuario.Margin = new Padding(3, 4, 3, 4);
            grpNuevoUsuario.Name = "grpNuevoUsuario";
            grpNuevoUsuario.Padding = new Padding(3, 4, 3, 4);
            grpNuevoUsuario.Size = new Size(504, 392);
            grpNuevoUsuario.TabIndex = 13;
            grpNuevoUsuario.TabStop = false;
            grpNuevoUsuario.Text = "Crear Usuario Nuevo";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(261, 544);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(110, 31);
            btnAgregarUsuario.TabIndex = 14;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // PantallaUsuarioNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1270, 729);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(grpNuevoUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaUsuarioNuevo";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaUsuarioNuevo";
            Load += PantallaUsuarioNuevo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMnzcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpNuevoUsuario.ResumeLayout(false);
            grpNuevoUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtClaveUsuario;
        private PictureBox btnMnzcliente;
        private PictureBox btnCerrarCliente;
        private GroupBox grpNuevoUsuario;
        private Button btnAgregarUsuario;
    }
}