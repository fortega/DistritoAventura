using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;

namespace POS
{
    public partial class Compra
    {
        public void ImprimeComprobante()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);

            PrintDialog dialog = new PrintDialog();
            dialog.Document = doc;

            if (Properties.Settings.Default.CompraPrintDialog)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }
            else
            {
                doc.Print();
            }
        }

        void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //LOGO
            Bitmap logo = new Bitmap("logo.png");
            float logoW = e.Graphics.VisibleClipBounds.Width * Properties.Settings.Default.CompraLogoProp;
            float logoH = logo.Height * logoW / logo.Width;
            e.Graphics.DrawImage(logo, 0, 0, logoW, logoH);

            //Texto
            Font fTexto = new Font(Properties.Settings.Default.CompraFontFamily, Properties.Settings.Default.CompraFontSize);
            StringBuilder sbTexto = new StringBuilder();
            sbTexto.Append("Fecha: ");
            sbTexto.Append(DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
            sbTexto.Append("\n\n");
            foreach (ItemCompra ic in Items)
            {
                sbTexto.Append(ic.Cantidad);
                sbTexto.Append("x\t");
                sbTexto.Append(ic.Item.Nombre);
                sbTexto.Append("\n");
            }

            string texto = sbTexto.ToString();
            SizeF sizeT = e.Graphics.MeasureString(texto, fTexto);
            e.Graphics.DrawString(texto, fTexto, Brushes.Black, 0, logoH);

            //QR
            StringBuilder sbQR = new StringBuilder();
            sbQR.Append("ID: ");
            sbQR.Append(ID);
            sbQR.Append("\n");

            sbQR.Append(Persona.ToString());
            sbQR.Append("\n");

            sbQR.Append("Gracias por su visita\nhttp://www.distritoaventura.cl");

            QRCodeEncoder qrEncoder = new QRCodeEncoder();
            Bitmap bmQR = qrEncoder.Encode(sbQR.ToString());

            e.Graphics.DrawImage(bmQR,
                e.Graphics.VisibleClipBounds.Width * (1f - Properties.Settings.Default.CompraQrProp) / 2,
                sizeT.Height + logoH,
                e.Graphics.VisibleClipBounds.Width * Properties.Settings.Default.CompraQrProp,
                e.Graphics.VisibleClipBounds.Width * Properties.Settings.Default.CompraQrProp);

            //Gracias
            Font fGracias = new Font(Properties.Settings.Default.CompraGraciasFamily, Properties.Settings.Default.CompraGraciasSize);
            string gracias = Properties.Settings.Default.CompraGraciasText;
            SizeF sizeGracias = e.Graphics.MeasureString(gracias, fGracias);
            e.Graphics.DrawString(gracias, fGracias, Brushes.Black,
                (e.Graphics.VisibleClipBounds.Width - sizeGracias.Width) / 2f,
                sizeT.Height + logoH + e.Graphics.VisibleClipBounds.Width * Properties.Settings.Default.CompraQrProp);
        }
    }
}
