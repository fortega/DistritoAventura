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
    public partial class Pago : Form
    {
        private Item[] items;
        private int[] cantidades;
        private Persona persona;
        private int total = 0;

        public Pago(Item[] items, int[] cantidades, Persona persona)
        {
            this.items = items;
            this.cantidades = cantidades;
            this.persona = persona;

            for (int i = 0; i < cantidades.Length; i++)
                total += items[i].Valor * cantidades[i];

            InitializeComponent();

            Cargar();
        }

        private void Cargar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Total");

            for (int i = 0; i < items.Length; i++)
            {
                dt.Rows.Add(
                    items[i].Nombre,
                    items[i].Valor.ToString(Properties.Settings.Default.FormatoPlata),
                    cantidades[i],
                    (items[i].Valor * cantidades[i]).ToString(Properties.Settings.Default.FormatoPlata));
            }

            dt.Rows.Add(null, null, null, total.ToString(Properties.Settings.Default.FormatoPlata));

            dg.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Compra HacerCompra()
        {
            DB db = new DB();

            Compra c = new Compra()
            {
                PersonaID = persona.ID,
                Total = total
            };
            db.Compras.AddObject(c);
            db.SaveChanges();

            for (int i = 0; i < items.Length; i++)
            {
                ItemCompra itemCompra = new ItemCompra()
                {
                    CompraID = c.ID,
                    ItemID = items[i].ID,
                    Valor = items[i].Valor,
                    Cantidad = (byte)cantidades[i]
                };
                db.ItemsCompra.AddObject(itemCompra);
            }

            db.SaveChanges();

            return c;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Pago en efectivo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Compra compra = HacerCompra();

                DB db = new DB();
                PagoEfectivo pago = new PagoEfectivo()
                {
                    CompraID = compra.ID,
                    Valor = compra.Total
                };
                db.PagosEfectivo.AddObject(pago);
                db.SaveChanges();

                compra.ImprimeComprobante();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnRedCompra_Click(object sender, EventArgs e)
        {
            Pagos.RedCompra frm = new Pagos.RedCompra();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Compra compra = HacerCompra();

                DB db = new DB();

                PagoRedcompra pago = new PagoRedcompra()
                {
                    CompraID = compra.ID,
                    Transaccion = int.Parse(frm.tbTransaccion.Text.Trim()),
                    Autorizacion = int.Parse(frm.tbAutorizacion.Text.Trim()),
                    Tipo = (frm.cbTipo.Text == "Debito") ? "D" : "C",
                    Valor = compra.Total
                };

                db.PagosRedcompra.AddObject(pago);
                db.SaveChanges();

                compra.ImprimeComprobante();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnPrepago_Click(object sender, EventArgs e)
        {
            Pagos.Prepago frm = new Pagos.Prepago();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Prepago p = frm.PrepagoSel;
                if (p.Saldo >= total)
                {
                    Compra compra = HacerCompra();

                    DB db = new DB();
                    db.Attach(p);

                    p.Saldo -= total;
                    db.SaveChanges();
                    p.MostrarSaldo();

                    compra.ImprimeComprobante();

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (p.Saldo > 0)
                    {
                        PrepagoSaldoInsuficiente frmSaldo = new PrepagoSaldoInsuficiente();
                        frmSaldo.lblSaldo.Text += (total - p.Saldo).ToString(Properties.Settings.Default.FormatoPlata);

                        if (frmSaldo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            Compra compra = HacerCompra();

                            DB db = new DB();
                            db.Attach(p);
                            if (frmSaldo.frmRedcompra == null) // efectivo
                            {
                                PagoEfectivo pe = new PagoEfectivo()
                                {
                                    CompraID = compra.ID,
                                    Valor = total - p.Saldo
                                };
                                db.PagosEfectivo.AddObject(pe);
                            }
                            else
                            {
                                PagoRedcompra pr = new PagoRedcompra()
                                {
                                    CompraID = compra.ID,
                                    Transaccion = int.Parse(frmSaldo.frmRedcompra.tbTransaccion.Text.Trim()),
                                    Autorizacion = int.Parse(frmSaldo.frmRedcompra.tbAutorizacion.Text.Trim()),
                                    Tipo = (frmSaldo.frmRedcompra.cbTipo.Text == "Debito") ? "D" : "C",
                                    Valor = total - p.Saldo
                                };
                                db.PagosRedcompra.AddObject(pr);
                            }
                            p.Saldo = 0;
                            db.SaveChanges();

                            compra.ImprimeComprobante();

                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Concat("Tarjeta sin saldo"), "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
