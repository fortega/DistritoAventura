using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Pagos
{
    public partial class RedCompra : Form
    {
        public RedCompra()
        {
            InitializeComponent();

            cbTipo.SelectedIndex = 0;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbAutorizacion.Text);
                int.Parse(tbTransaccion.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Debe ingresar codigos");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
