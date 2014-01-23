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
    public partial class BuscarPersona : Form
    {
        public Persona Persona { get; set; }
        public BuscarPersona()
        {
            InitializeComponent();

            Cargar();
        }

        private void Cargar()
        {
            DB db = new DB();
            gv.DataSource = db.Personas.OrderBy(i => new { i.Apellido, i.Nombre }).ToArray();
        }

        private Persona PersonaSeleccionada
        {
            get { return (Persona)gv.SelectedRows[0].DataBoundItem; }
        }

        private void gv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Persona = PersonaSeleccionada;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void imprimeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonaSeleccionada.ImprimeContrato();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            gv_MouseDoubleClick(null, null);
        }
    }
}
