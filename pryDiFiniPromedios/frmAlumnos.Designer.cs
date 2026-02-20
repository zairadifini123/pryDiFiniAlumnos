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
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Location = new Point(12, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 1;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
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
    }
}
