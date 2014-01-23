using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class PrepagoSaldoInsuficiente : Form
    {
        bool confirmar = true;

        public Pagos.RedCompra frmRedcompra = null;

        public PrepagoSaldoInsuficiente()
        {
            InitializeComponent();
        }

        private void PrepagoSaldoInsuficiente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmar)
                if (MessageBox.Show("Seguro?", "Cerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Efectivo?", "Efectivo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
