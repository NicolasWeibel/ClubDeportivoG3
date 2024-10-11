namespace ClubDeportivoG3
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.White;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(149, 259);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(127, 59);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AcceptsTab = true;
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(149, 150);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(127, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsTab = true;
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(149, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(127, 25);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(422, 399);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            DoubleBuffered = true;
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(64, 0, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInicio";
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}
