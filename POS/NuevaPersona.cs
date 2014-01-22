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
    public partial class NuevaPersona : Form
    {
        private bool validaCierre = true;
        public Persona Persona { get; set; }
        public NuevaPersona(string rut)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(rut))
                tbRut.Text = rut;
        }

        private void NuevaPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validaCierre)
            {
                if (MessageBox.Show("Esta seguro de cerrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona p = new POS.Persona()
            {
                RUT = tbRut.Text.Trim(),
                Nombre = tbNombre.Text.Trim(),
                Apellido = tbApellido.Text.Trim(),
                FechaNacimiento = dtNacimiento.Value.Date
            };
            if (!string.IsNullOrEmpty(tbEmail.Text))
                p.Email = tbEmail.Text.Trim();

            if (!p.RutValido)
            {
                MessageBox.Show("Rut invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DB db = new DB();
                    db.Personas.AddObject(p);
                    db.SaveChanges();

                    this.Persona = p;

                    p.ImprimeContrato();
                    validaCierre = false;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                catch(Exception ex) {
                    MessageBox.Show("Nos se pudo crear. RUT ya existe?:\n" + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
