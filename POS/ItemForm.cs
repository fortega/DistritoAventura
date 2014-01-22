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
    public partial class ItemForm : Form
    {
        int id = -1;
        bool confirmar = true;
        public ItemForm(Item i)
        {
            InitializeComponent();

            if (i != null)
            {
                id = i.ID;
                tbNombre.Text = i.Nombre;
                tbValor.Text = i.Valor.ToString();

                tbNombre.Enabled = false;
                btnCrear.Text = "Editar";
            }
        }

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmar)
            {
                if (MessageBox.Show("Seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (id != -1)
            {
                Item i = db.Items.Where(j => j.ID == id).Single();
                i.Valor = int.Parse(tbValor.Text);
                i.Activo = ckActivo.Checked;
            }
            else
            {
                Item i = new Item()
                {
                    Nombre = tbNombre.Text,
                    Valor = int.Parse(tbValor.Text),
                    Activo = ckActivo.Checked
                };

                db.Items.AddObject(i);
            }

            db.SaveChanges();
            confirmar = false;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
