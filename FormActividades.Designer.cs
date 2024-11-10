namespace ClubDeportivoG3
{
    partial class FormActividades
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
            dataGridView1 = new DataGridView();
            btnAgregarActividad = new Button();
            btnEliminarActividad = new Button();
            txtNombre = new TextBox();
            txtDia = new TextBox();
            txtHorario = new TextBox();
            txtMonto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregarActividad
            // 
            btnAgregarActividad.Location = new Point(213, 375);
            btnAgregarActividad.Name = "btnAgregarActividad";
            btnAgregarActividad.Size = new Size(160, 77);
            btnAgregarActividad.TabIndex = 1;
            btnAgregarActividad.Text = "Agregar Actividad";
            btnAgregarActividad.UseVisualStyleBackColor = true;
            btnAgregarActividad.Click += btnAgregarActividad_Click;
            // 
            // btnEliminarActividad
            // 
            btnEliminarActividad.Location = new Point(439, 375);
            btnEliminarActividad.Name = "btnEliminarActividad";
            btnEliminarActividad.Size = new Size(160, 77);
            btnEliminarActividad.TabIndex = 2;
            btnEliminarActividad.Text = "Eliminar Actividad";
            btnEliminarActividad.UseVisualStyleBackColor = true;
            btnEliminarActividad.Click += btnEliminarActividad_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(314, 238);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 3;
            txtNombre.Text = "NOMBRE ACTIVIDAD";
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(314, 271);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(185, 27);
            txtDia.TabIndex = 4;
            txtDia.Text = "DIA ACTIVIDAD";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(314, 304);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(185, 27);
            txtHorario.TabIndex = 5;
            txtHorario.Text = "HORARIO ACTIVIDAD";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(314, 342);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(185, 27);
            txtMonto.TabIndex = 6;
            txtMonto.Text = "MONTO ACTIVIDAD";
            // 
            // FormActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 464);
            Controls.Add(txtMonto);
            Controls.Add(txtHorario);
            Controls.Add(txtDia);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminarActividad);
            Controls.Add(btnAgregarActividad);
            Controls.Add(dataGridView1);
            Name = "FormActividades";
            Text = "Actividades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarActividad;
        private Button btnEliminarActividad;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCupo;
        private TextBox txtDia;
        private TextBox txtHorario;
        private TextBox textBox1;
        private TextBox txtMonto;
    }
}