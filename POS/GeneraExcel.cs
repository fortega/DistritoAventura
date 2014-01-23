using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace POS
{
    public class GeneraExcel
    {
        public static void Genera(string filename)
        {
            Genera(filename, true);
        }
        public static void Genera(string filename,bool detalle)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);

            DB db = new DB();
            int i = 2;

            Excel.Worksheet ws;

            if (detalle)
            {
                ws = wb.Worksheets.Add(Type.Missing, Type.Missing, 1, Excel.XlSheetType.xlWorksheet);
                ws.Name = "ItemCompra Detalle";
                ws.Cells[1, 1] = "CompraID"; ws.Cells[1, 2] = "Fecha Compra"; ws.Cells[1, 3] = "Item"; ws.Cells[1, 4] = "Valor Item Unitario"; ws.Cells[1, 5] = "Cantidad"; ws.Cells[1, 6] = "Valor Item Total";
                foreach (ItemCompraDetalle ic in db.ItemCompraDetalle)
                {
                    ws.Cells[i, 1] = ic.CompraID;
                    ws.Cells[i, 2] = ic.FechaCompra;
                    ws.Cells[i, 3] = ic.Item;
                    ws.Cells[i, 4] = ic.ValorItemUnitario;
                    ws.Cells[i, 5] = ic.Cantidad;
                    ws.Cells[i, 6] = ic.ValorItemTotal;
                    i++;
                }
                for (int j = 1; j <= 6; j++)
                {
                    ws.Cells[1, j].Font.Bold = true;
                    ws.Cells[1, j].EntireColumn.AutoFit();
                }

                i = 2;
                ws = wb.Worksheets.Add(Type.Missing, Type.Missing, 1, Excel.XlSheetType.xlWorksheet);
                ws.Name = "Compras Detalle";
                ws.Cells[1, 1] = "ID"; ws.Cells[1, 2] = "RUT"; ws.Cells[1, 3] = "Apellido"; ws.Cells[1, 4] = "Nombre"; ws.Cells[1, 5] = "Email"; ws.Cells[1, 6] = "Fecha Nacimiento"; ws.Cells[1, 7] = "Total";
                foreach (ComprasDetalle c in db.ComprasDetalle)
                {
                    ws.Cells[i, 1] = c.id;
                    ws.Cells[i, 2] = c.rut;
                    ws.Cells[i, 3] = c.apellido;
                    ws.Cells[i, 4] = c.nombre;
                    ws.Cells[i, 5] = c.email;
                    ws.Cells[i, 6] = c.fechanacimiento;
                    ws.Cells[i, 7] = c.total;
                    i++;
                }
                for (int j = 1; j <= 7; j++)
                {
                    ws.Cells[1, j].Font.Bold = true;
                    ws.Cells[1, j].EntireColumn.AutoFit();
                }
            }

            i = 2;
            ws = wb.Worksheets.Add(Type.Missing, Type.Missing, 1, Excel.XlSheetType.xlWorksheet);
            ws.Name = "ItemCompra Diario";
            ws.Cells[1, 1] = "Dia"; ws.Cells[1, 2] = "Item"; ws.Cells[1, 3] = "Num"; ws.Cells[1, 4] = "Total";
            foreach (ItemCompraDiaria ic in db.ItemCompraDiaria)
            {
                ws.Cells[i, 1] = ic.Dia;
                ws.Cells[i, 2] = ic.Item;
                ws.Cells[i, 3] = ic.Num;
                ws.Cells[i, 4] = ic.Total;
                i++;
            }
            for (int j = 1; j <= 4; j++)
            {
                ws.Cells[1, j].Font.Bold = true;
                ws.Cells[1, j].EntireColumn.AutoFit();
            }


            i = 2;
            ws = wb.Worksheets.Add(Type.Missing, Type.Missing, 1, Excel.XlSheetType.xlWorksheet);
            ws.Name = "Compras Diario";
            ws.Cells[1, 1] = "Dia"; ws.Cells[1, 2] = "Efectico"; ws.Cells[1, 3] = "RedCompra"; ws.Cells[1, 4] = "Prepago"; ws.Cells[1, 5] = "Total";
            foreach (ComprasDiaria c in db.ComprasDiaria)
            {
                ws.Cells[i, 1] = c.Dia;
                ws.Cells[i, 2] = c.Efectivo;
                ws.Cells[i, 3] = c.RedCompra;
                ws.Cells[i, 4] = c.PrePago;
                ws.Cells[i, 5] = c.Total;
                i++;
            }
            for (int j = 1; j <= 5; j++)
            {
                ws.Cells[1, j].Font.Bold = true;
                ws.Cells[1, j].EntireColumn.AutoFit();
            }

            wb.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook,
                          null, null, false, false, Excel.XlSaveAsAccessMode.xlShared,
                          false, false, null, null, null);
            wb.Close();
        }
    }
}
