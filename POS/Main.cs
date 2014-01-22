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
    public partial class Main : Form
    {
        private Color ColorOK = Color.LightGreen;
        private Color ColorError = Color.Red;
        private Persona sPersona;
        private Item[] Items;
        private NumericUpDown[] NumItems;
        private Persona SelecPersona
        {
            get { return sPersona; }
            set
            {
                sPersona = value; //TODO
                if (sPersona != null)
                {
                    tbRUT.Text = sPersona.RUT;
                    lblNombreRes.Text = string.Concat(sPersona.Apellido, ", ", sPersona.Nombre);
                }
                else
                {
                    lblNombreRes.Text = "-";
                }
            }
        }

        public Main()
        {
            InitializeComponent();

            CargarItems();
        }

        private void CargarItems()
        {
            DB db = new DB();
            Items = db.Items
                .Where(i => i.Activo == true)
                .OrderBy(i => i.Nombre)
                .ToArray();
            NumItems = new NumericUpDown[Items.Length];

            

            //tlItems.ColumnCount = 4;
            //tlItems.ColumnStyles.Clear();
            //tlItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            //tlItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            //tlItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            //tlItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            //tlItems.RowCount = 1;
            tlItems.RowStyles.Clear();
            tlItems.RowStyles.Add(new RowStyle());
            
            tlItems.Controls.Clear();
            //tlItems.Controls.Add(lblItemID, 0, 0);
            tlItems.Controls.Add(lblItemNombre, 0, 0);
            tlItems.Controls.Add(lblItemValor, 1, 0);
            tlItems.Controls.Add(lblItemCantidad, 2, 0);


            tlItems.RowCount = Items.Length + 1;
            for (int i = 0; i < Items.Length; i++)
            {
                NumItems[i] = new NumericUpDown();
                NumItems[i].ValueChanged += new EventHandler(NumItemChange);
                tlItems.RowStyles.Add(new RowStyle());
                //tlItems.Controls.Add(new Label() { Text = Items[i].ID.ToString() }, 0, i + 1);
                tlItems.Controls.Add(new Label() { Text = Items[i].Nombre }, 0, i + 1);
                tlItems.Controls.Add(new Label() { Text = Items[i].Valor.ToString() }, 1, i + 1);
                tlItems.Controls.Add(NumItems[i], 2, i + 1);
            }

        }

        void NumItemChange(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < Items.Length; i++)
                total += Items[i].Valor * (int)NumItems[i].Value;

            lblTotal.Text = total.ToString("$#,0");
            btnPagar.Enabled = total > 0;
        }

        private void tbRUT_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (Persona.ValidaRUT(tb.Text))
            {
                tb.BackColor = ColorOK;
                try
                {
                    DB db = new DB();
                    Persona p = db.Personas.Where(i => i.RUT == tb.Text).Single();
                    this.SelecPersona = p;
                }
                catch
                {
                    // RUT valido, persona no ingresada
                    if (Properties.Settings.Default.PreguntaCrearPersona)
                    {
                        if (MessageBox.Show("RUT no ingresado. Crear?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            NuevaPersona frm = new NuevaPersona(tb.Text);
                            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                SelecPersona = frm.Persona;
                        }
                    }
                    
                }
            }
            else
            {
                tb.BackColor = ColorError;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaPersona frm = new NuevaPersona(tbRUT.Text);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SelecPersona = frm.Persona;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Limpiar();
        }

        private void Limpiar()
        {
            tbRUT.Text = string.Empty;

            SelecPersona = null;
            for (int i = 0; i < NumItems.Length; i++)
                NumItems[i].Value = 0M;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tbRUT.BackColor = ColorError;
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersona frm = new BuscarPersona();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SelecPersona = frm.Persona;
        }

        private void btnManItems_Click(object sender, EventArgs e)
        {
            MantItems frm = new MantItems();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CargarItems();
        }
    }
}
