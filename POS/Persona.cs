using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;

namespace POS
{
    public partial class Persona
    {
        private static Regex regexRut = new Regex("^\\d{7,8}[0-9k]$", RegexOptions.IgnoreCase);
        public static bool ValidaRUT(string rut)
        {
            if (!string.IsNullOrEmpty(rut))
            {
                if (regexRut.Match(rut).Success)
                {
                    int total = 0;
                    int cur = 2;
                    for (int i = rut.Length - 2; i >= 0; i--)
                    {
                        total += ((int)rut[i] - 48) * cur;

                        if (++cur > 7)
                            cur = 2;
                    }

                    int verificador = 11 - (total % 11);
                    if (verificador == 10)
                        return rut[rut.Length - 1] == 'k';
                    else if (verificador == 11)
                        return rut[rut.Length - 1] == '0';
                    else
                        return rut[rut.Length - 1] == (char)(verificador + 48);
                }
            }

            return false;
        }

        public void ImprimeContrato()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);
            PrintDialog pd = new PrintDialog();
            pd.Document = doc;

            if (Properties.Settings.Default.PersonaPrintDialog)
            {
                if (pd.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }
            else
            {
                doc.Print();
            }
        }

        void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Logo
            Bitmap logo = new Bitmap("logo.png");
            float logoW = e.Graphics.VisibleClipBounds.Width * Properties.Settings.Default.CompraLogoProp;
            float logoH = logo.Height * logoW / logo.Width;
            e.Graphics.DrawImage(logo, 0, 0, logoW, logoH);

            //Texto
            Font fContrato = new Font(Properties.Settings.Default.ContratoFamily, Properties.Settings.Default.ContratoSize);
            SizeF sizeContrato = e.Graphics.MeasureString(Properties.Settings.Default.ContratoTexto, fContrato, (int)e.Graphics.VisibleClipBounds.Width);
            e.Graphics.DrawString(Properties.Settings.Default.ContratoTexto, fContrato, Brushes.Black, new RectangleF(0, logoH, sizeContrato.Width, sizeContrato.Height));

            //Firma
            StringFormat sfFirma = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            string tFirma = string.Concat("\n\n\n\n\n\n\n", Nombre, " ", Apellido, "\nRUT: ", RUT.Substring(0,RUT.Length-1),"-",RUT.Substring(RUT.Length-1));
            SizeF sFirma = e.Graphics.MeasureString(tFirma,fContrato);
            e.Graphics.DrawString(tFirma, fContrato, Brushes.Black, e.Graphics.VisibleClipBounds.Width, logoH + sizeContrato.Height,sfFirma);

        }

        public override string ToString()
        {
            return string.Concat(Apellido, ", ", Nombre);
        }

        public bool RutValido
        {
            get { return ValidaRUT(RUT); }
        }
    }
}
