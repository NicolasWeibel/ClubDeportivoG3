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
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 489);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 30;
            label7.Text = "Cuota Mensual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 361);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 29;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 305);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 28;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 244);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 27;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 188);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 26;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 124);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 25;
            label1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(502, 556);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(357, 556);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudCuotaMensual
            // 
            nudCuotaMensual.Location = new Point(421, 487);
            nudCuotaMensual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCuotaMensual.Name = "nudCuotaMensual";
            nudCuotaMensual.Size = new Size(125, 27);
            nudCuotaMensual.TabIndex = 22;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(421, 429);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(105, 24);
            chkAptoFisico.TabIndex = 21;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(421, 358);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 20;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(421, 302);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(421, 185);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 18;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(421, 241);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 27);
            txtDNI.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(421, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 16;
            // 
            // FormAgregarSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 721);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudCuotaMensual);
            Controls.Add(chkAptoFisico);
            Controls.Add(txtTelefono);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Name = "FormAgregarSocios";
            Text = "FormAgregarSocios";
            Load += FormAgregarSocios_Load;
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}