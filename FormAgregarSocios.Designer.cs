namespace ClubDeportivoG3
{
    partial class FormAgregarSocios
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
            panel1 = new Panel();
            lblTitulo = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lblEstadoPago = new Label();
            cmbEstadoPago = new ComboBox();
            chkCarnetEntrega = new CheckBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            nudCuotaMensual = new NumericUpDown();
            chkAptoFisico = new CheckBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 85);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(393, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de Registro";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 622);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 99);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblEstadoPago);
            panel3.Controls.Add(cmbEstadoPago);
            panel3.Controls.Add(chkCarnetEntrega);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(nudCuotaMensual);
            panel3.Controls.Add(chkAptoFisico);
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(txtMail);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(txtDNI);
            panel3.Controls.Add(txtNombre);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1069, 537);
            panel3.TabIndex = 2;
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.Location = new Point(259, 425);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(112, 20);
            lblEstadoPago.TabIndex = 48;
            lblEstadoPago.Text = "Estado de Pago";
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Items.AddRange(new object[] { "Pagado", "Pendiente" });
            cmbEstadoPago.Location = new Point(462, 417);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(151, 28);
            cmbEstadoPago.TabIndex = 39;
            cmbEstadoPago.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // chkCarnetEntrega
            // 
            chkCarnetEntrega.AutoSize = true;
            chkCarnetEntrega.Location = new Point(462, 372);
            chkCarnetEntrega.Name = "chkCarnetEntrega";
            chkCarnetEntrega.Size = new Size(151, 24);
            chkCarnetEntrega.TabIndex = 38;
            chkCarnetEntrega.Text = "Carnet Engregado";
            chkCarnetEntrega.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 323);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 46;
            label7.Text = "Cuota Mensual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 227);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 45;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 179);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 44;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 128);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 43;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 82);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 42;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(578, 485);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 29);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(344, 485);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 29);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // nudCuotaMensual
            // 
            nudCuotaMensual.Location = new Point(462, 321);
            nudCuotaMensual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCuotaMensual.Name = "nudCuotaMensual";
            nudCuotaMensual.Size = new Size(191, 27);
            nudCuotaMensual.TabIndex = 37;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(462, 276);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(105, 24);
            chkAptoFisico.TabIndex = 36;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(462, 224);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.TabIndex = 35;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(462, 176);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(191, 27);
            txtMail.TabIndex = 34;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(462, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(191, 27);
            txtApellido.TabIndex = 32;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(462, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(191, 27);
            txtDNI.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(462, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 31;
            // 
            // FormAgregarSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 721);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAgregarSocios";
            Text = "FormAgregarSocios";
            Load += FormAgregarSocios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private Panel panel3;
        private CheckBox chkCarnetEntrega;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown nudCuotaMensual;
        private CheckBox chkAptoFisico;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label lblEstadoPago;
        private ComboBox cmbEstadoPago;
    }
}