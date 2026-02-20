namespace pryDiFiniPromedios
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        string Nombre;
        int Edad;
        double Nota; 
      

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Edad = Convert.ToInt32(txtEdad.Text);
            Edad = Edad + 5;
            Nota = Convert.ToDouble(txtNota.Text);
            Nota = Nota + 1;

            if (Edad >= 6)
            {
                MessageBox.Show("Este alumno está aprobado"); 
            }

            lblResultados.Text =
                Nombre.ToString() + " - " + 
                Edad.ToString() + " - " +
                Nota.ToString();

        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            e.Handled =
                !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                (e.KeyChar != ',' || t.Text.Contains(","));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
