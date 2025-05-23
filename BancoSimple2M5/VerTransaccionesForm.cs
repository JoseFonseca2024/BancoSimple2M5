using BancoSimple2M5.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2M5
{
    public partial class VerTransaccionesForm : Form
    {
        private BancoSimple2M5Context _context = new BancoSimple2M5Context();
        public VerTransaccionesForm()
        {
            InitializeComponent();
            CargarTransferencias();
        }

        private void CargarTransferencias()
        {
            dgvTransacciones.DataSource = _context.Transaccion.ToList();
        }

        private void Aceptar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
