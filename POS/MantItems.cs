﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class MantItems : Form
    {
        private bool edit = false;

        public MantItems()
        {
            InitializeComponent();

            Cargar();
        }

        private void Cargar()
        {
            DB db = new DB();
            dg.DataSource = db.Items.OrderBy(i => i.Nombre).ToArray();
        }

        private void MantItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edit)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                Item i = (Item)dg.SelectedRows[0].DataBoundItem;

                ItemForm form = new ItemForm(i);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    edit = true;
                    Cargar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ItemForm frm = new ItemForm(null);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                edit = true;
                Cargar();
            }
        }
    }
}
