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
    public partial class UltimasVentas : Form
    {
        public UltimasVentas()
        {
            InitializeComponent();

            Cargar();
        }

        public void Cargar()
        {
            DB db = new DB();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(long));
            dt.Columns.Add("Hora");
            dt.Columns.Add("Persona");
            dt.Columns.Add("Total");

            foreach(Compra compra in db.Compras.OrderByDescending(i => i.Fecha).Take(100))
                dt.Rows.Add(compra.ID, compra.Fecha, compra.Persona.ToString(), compra.Total.ToString(Properties.Settings.Default.FormatoPlata));

            dg.DataSource = dt;
        }

        private Compra CompraSel
        {
            get
            {
                long id = (long)dg.SelectedRows[0].Cells["ID"].Value;
                DB db = new DB();
                return db.Compras.Where(i => i.ID == id).Single();
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            Compra c = CompraSel;
            TimeSpan ts = DateTime.Now - c.Fecha;

            if (ts.TotalMinutes > Properties.Settings.Default.MaxMin)
                MessageBox.Show(string.Concat("No se puede reimprimir ticket mas antiguos de ", Properties.Settings.Default.MaxMin, " minutos."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                CompraSel.ImprimeComprobante();
        }
    }
}
