namespace ClubDeportivoG3
{
    partial class FormSocios
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
            dataGridViewSocios = new DataGridView();
            btnAgregarSocio = new Button();
            btnModificarSocio = new Button();
            btnEliminarSocio = new Button();
            lblListaSocios = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.Anchor = AnchorStyles.None;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(76, 80);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.RowHeadersWidth = 51;
            dataGridViewSocios.RowTemplate.Height = 29;
            dataGridViewSocios.Size = new Size(1179, 536);
            dataGridViewSocios.TabIndex = 0;
            dataGridViewSocios.CellContentClick += dataGridViewSocios_CellContentClick;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.Location = new Point(76, 23);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(235, 107);
            btnAgregarSocio.TabIndex = 1;
            btnAgregarSocio.Text = "Agregar Socio";
            btnAgregarSocio.UseVisualStyleBackColor = true;
            btnAgregarSocio.Click += btnAgregarSocio_Click_1;
            // 
            // btnModificarSocio
            // 
            btnModificarSocio.Location = new Point(548, 23);
            btnModificarSocio.Name = "btnModificarSocio";
            btnModificarSocio.Size = new Size(235, 107);
            btnModificarSocio.TabIndex = 2;
            btnModificarSocio.Text = "Modificar Socio";
            btnModificarSocio.UseVisualStyleBackColor = true;
            btnModificarSocio.Click += btnModificarSocio_Click_1;
            // 
            // btnEliminarSocio
            // 
            btnEliminarSocio.Location = new Point(1020, 23);
            btnEliminarSocio.Name = "btnEliminarSocio";
            btnEliminarSocio.Size = new Size(235, 107);
            btnEliminarSocio.TabIndex = 3;
            btnEliminarSocio.Text = "Eliminar Socio";
            btnEliminarSocio.UseVisualStyleBackColor = true;
            btnEliminarSocio.Click += btnEliminarSocio_Click_1;
            // 
            // lblListaSocios
            // 
            lblListaSocios.AutoSize = true;
            lblListaSocios.Location = new Point(548, 36);
            lblListaSocios.Name = "lblListaSocios";
            lblListaSocios.Size = new Size(114, 20);
            lblListaSocios.TabIndex = 4;
            lblListaSocios.Text = "Lista de Socios: ";
            lblListaSocios.Click += lblListaSocios_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewSocios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 774);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminarSocio);
            panel2.Controls.Add(btnAgregarSocio);
            panel2.Controls.Add(btnModificarSocio);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 622);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 152);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblListaSocios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1330, 74);
            panel3.TabIndex = 7;
            // 
            // FormSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 774);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormSocios";
            Text = "FormSocios";
            Load += FormSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSocios;
        private Button btnAgregarSocio;
        private Button btnModificarSocio;
        private Button btnEliminarSocio;
        private Label lblListaSocios;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}