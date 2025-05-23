using BancoSimple2M5.Models;


namespace BancoSimple2M5
{
    public partial class AgregarClienteForm : Form
    {
        public Cliente NuevoCliente { get; private set; }

        public AgregarClienteForm()
        {
            InitializeComponent();
        }

        private void AceptarRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtIdentificación.Text))
            {
                MessageBox.Show("Todos los campos tiene que estar completos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                NuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Identificación = txtIdentificación.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelarRegistro(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
