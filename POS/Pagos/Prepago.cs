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
    public partial class Prepago : Form
    {
        public POS.Prepago PrepagoSel { get; set; }

        public Prepago()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                this.PrepagoSel = db.Prepagos.Where(i => i.ID == int.Parse(tbCodigo.Text)).Single();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Codigo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCodigo.Text = string.Empty;
            }
        }
    }
}
