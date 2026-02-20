namespace pryDiFiniPromedios
{
    partial class frmAlumnos
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDatos = new Label();
            lblEdad = new Label();
            txtNota = new TextBox();
            lblNota = new Label();
            btnAceptar = new Button();
            btnSalir = new Button();
            txtEdad = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Location = new Point(12, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(70, 31);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(179, 30);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "Ingrese los datos";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = SystemColors.ActiveCaption;
            lblEdad.Location = new Point(12, 148);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(74, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Ingrese edad";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(110, 216);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(82, 23);
            txtNota.TabIndex = 6;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.BackColor = SystemColors.ActiveCaption;
            lblNota.Location = new Point(12, 219);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(72, 15);
            lblNota.TabIndex = 5;
            lblNota.Text = "Ingrese nota";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(163, 300);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 27);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(36, 300);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 27);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(110, 140);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(82, 23);
            txtEdad.TabIndex = 9;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 482);
            Controls.Add(txtEdad);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(txtNota);
            Controls.Add(lblNota);
            Controls.Add(lblEdad);
            Controls.Add(lblDatos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDatos;
        private Label lblEdad;
        private TextBox txtNota;
        private Label lblNota;
        private Button btnAceptar;
        private Button btnSalir;
        private TextBox txtEdad;
    }
}
