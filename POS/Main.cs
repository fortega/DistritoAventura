using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace POS
{
    public partial class Main : Form
    {
        private Color ColorOK = Color.LightGreen;
        private Color ColorError = Color.White;
        private Persona sPersona;
        private Item[] Items;
        private NumericUpDown[] NumItems;
        private Persona SelecPersona
        {
            get { return sPersona; }
            set
            {
                sPersona = value; //TODO

                if (value != null)
                {
                    tbRUT.Text = value.RUT;
                    lblNombreRes.Text = value.ToString();
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
                tlItems.Controls.Add(new Label() { Text = Items[i].Valor.ToString(Properties.Settings.Default.FormatoPlata) }, 1, i + 1);
                tlItems.Controls.Add(NumItems[i], 2, i + 1);
            }

        }

        void NumItemChange(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                total += Items[i].Valor * (int)NumItems[i].Value;

                NumItems[i].BackColor = NumItems[i].Value > 0 ? ColorOK : ColorError;
            }

            lblTotal.Text = total.ToString(Properties.Settings.Default.FormatoPlata);
            btnPagar.Enabled = total > 0 && SelecPersona != null;
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
                    this.SelecPersona = null;
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
                SelecPersona = null;
                tb.BackColor = ColorError;
            }

            NumItemChange(null, null);
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
            {
                CargarItems();
                NumItemChange(null, null);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            List<Item> curItems = new List<Item>();
            List<int> curCantidades = new List<int>();

            for (int i = 0; i < NumItems.Length; i++)
            {
                if (NumItems[i].Value > 0)
                {
                    curItems.Add(this.Items[i]);
                    curCantidades.Add((int)this.NumItems[i].Value);
                }
            }

            Pago frm = new Pago(curItems.ToArray(), curCantidades.ToArray(), SelecPersona);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Limpiar();
        }

        private void btnUltimasVentas_Click(object sender, EventArgs e)
        {
            UltimasVentas frm = new UltimasVentas();
            frm.ShowDialog();
        }

        private void btnMantPrepago_Click(object sender, EventArgs e)
        {
            MantPrepago frm = new MantPrepago();
            frm.ShowDialog();
        }

        private void btnEnvioReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.CheckPathExists = true;
            sfd.DefaultExt = "xlsx";
            sfd.FileName = DateTime.Now.ToString("yyyMMdd-HHmm");
            sfd.Filter = "Excel|*.xlsx";
            
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                bool incluyeDetalle = MessageBox.Show("Incluir detalle?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes;
                GeneraExcel.Genera(sfd.FileName, incluyeDetalle);
                this.Cursor = Cursors.Default;

                if (MessageBox.Show("Enviar por mail?", "Mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        MailMessage message = new MailMessage();
                        message.Subject = "POS DistritoAventura";
                        message.From = new MailAddress(Properties.Settings.Default.GmailUser);
                        foreach (string to in Properties.Settings.Default.GmailTo.Split(','))
                            message.To.Add(new MailAddress(to));
                        message.Attachments.Add(new Attachment(sfd.FileName));

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            Credentials = new NetworkCredential(Properties.Settings.Default.GmailUser, Properties.Settings.Default.GmailPass)
                        };
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }

                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
    }
}
