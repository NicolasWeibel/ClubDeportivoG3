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
            btnGestionSocios = new Button();
            btnGestionNoSocios = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.Location = new Point(156, 95);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(116, 74);
            btnGestionSocios.TabIndex = 0;
            btnGestionSocios.Text = "Gestion Socios";
            btnGestionSocios.UseVisualStyleBackColor = true;
            btnGestionSocios.Click += button1_Click;
            // 
            // btnGestionNoSocios
            // 
            btnGestionNoSocios.Location = new Point(394, 95);
            btnGestionNoSocios.Name = "btnGestionNoSocios";
            btnGestionNoSocios.Size = new Size(116, 74);
            btnGestionNoSocios.TabIndex = 2;
            btnGestionNoSocios.Text = "Gestion No Socios";
            btnGestionNoSocios.UseVisualStyleBackColor = true;
            btnGestionNoSocios.Click += btnGestionNoSocios_Click;
            // 
            // button3
            // 
            button3.Location = new Point(394, 305);
            button3.Name = "button3";
            button3.Size = new Size(116, 36);
            button3.TabIndex = 3;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // OpcionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnGestionNoSocios);
            Controls.Add(btnGestionSocios);
            Name = "OpcionesForm";
            Text = "Opciones";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionSocios;
        private Button button1;
        private Button btnGestionNoSocios;
        private Button button3;
    }
}