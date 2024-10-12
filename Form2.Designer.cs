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
            btnInscribirSocio = new Button();
            SuspendLayout();
            // 
            // btnInscribirSocio
            // 
            btnInscribirSocio.Location = new Point(273, 125);
            btnInscribirSocio.Name = "btnInscribirSocio";
            btnInscribirSocio.Size = new Size(207, 126);
            btnInscribirSocio.TabIndex = 0;
            btnInscribirSocio.Text = "Inscribir Socio";
            btnInscribirSocio.UseVisualStyleBackColor = true;
            btnInscribirSocio.Click += button1_Click;
            // 
            // OpcionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInscribirSocio);
            Name = "OpcionesForm";
            Text = "Opciones";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscribirSocio;
    }
}