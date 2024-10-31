namespace ClubDeportivoG3
{
    partial class OpcionesForm
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
            btnSalir = new Button();
            pnl_Inferior = new Panel();
            lblUsuario = new Label();
            pnlSuperior = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnGestionActividades = new Button();
            btnGestionNoSocios = new Button();
            btnGestionSocios = new Button();
            pnl_Inferior.SuspendLayout();
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(517, 29);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnl_Inferior
            // 
            pnl_Inferior.BackColor = Color.AntiqueWhite;
            pnl_Inferior.Controls.Add(lblUsuario);
            pnl_Inferior.Controls.Add(btnSalir);
            pnl_Inferior.Dock = DockStyle.Bottom;
            pnl_Inferior.Location = new Point(0, 581);
            pnl_Inferior.Name = "pnl_Inferior";
            pnl_Inferior.Size = new Size(696, 100);
            pnl_Inferior.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(12, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 28);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario: ";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.AntiqueWhite;
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(696, 110);
            pnlSuperior.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(238, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Opciones de Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGestionActividades);
            panel1.Controls.Add(btnGestionNoSocios);
            panel1.Controls.Add(btnGestionSocios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 471);
            panel1.TabIndex = 7;
            // 
            // btnGestionActividades
            // 
            btnGestionActividades.Location = new Point(391, 106);
            btnGestionActividades.Name = "btnGestionActividades";
            btnGestionActividades.Size = new Size(141, 104);
            btnGestionActividades.TabIndex = 7;
            btnGestionActividades.Text = "Gestion Actividades";
            btnGestionActividades.UseVisualStyleBackColor = true;
            // 
            // btnGestionNoSocios
            // 
            btnGestionNoSocios.Location = new Point(144, 263);
            btnGestionNoSocios.Name = "btnGestionNoSocios";
            btnGestionNoSocios.Size = new Size(141, 104);
            btnGestionNoSocios.TabIndex = 6;
            btnGestionNoSocios.Text = "Gestion No Socios";
            btnGestionNoSocios.UseVisualStyleBackColor = true;
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.Location = new Point(144, 106);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(141, 104);
            btnGestionSocios.TabIndex = 5;
            btnGestionSocios.Text = "Gestion Socios";
            btnGestionSocios.UseVisualStyleBackColor = true;
            btnGestionSocios.Click += btnGestionSocios_Click_1;
            // 
            // OpcionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(696, 681);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Controls.Add(pnl_Inferior);
            Name = "OpcionesForm";
            Text = "Opciones";
            Load += Form2_Load;
            pnl_Inferior.ResumeLayout(false);
            pnl_Inferior.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnSalir;
        private Panel pnl_Inferior;
        private Label lblUsuario;
        private Panel pnlSuperior;
        private Label lblTitulo;
        private Panel panel1;
        private Button btnGestionActividades;
        private Button btnGestionNoSocios;
        private Button btnGestionSocios;
    }
}