namespace pryDiFiniPromedios
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            e.Handled =
                !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                (e.KeyChar != ',' || t.Text.Contains(","));
        }
    }
}
