using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class Prepago
    {
        public void MostrarSaldo()
        {
            MessageBox.Show(string.Concat("Saldo restante: ", Saldo.ToString(Properties.Settings.Default.FormatoPlata)), "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
