using iTextSharp.text;
using iTextSharp.text.pdf;

using System;
using System.IO;
using System.Windows.Forms;

public static class GridExporter
{
    public static void ExportJanusGridToPDF(Janus.Windows.GridEX.GridEX grid, string filePath)
    {
        try
        {
            if (grid == null || grid.RowCount == 0)
            {
                MessageBox.Show("داده‌ای برای خروجی وجود ندارد.");
                return;
            }

            // ایجاد سند PDF
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
            pdfDoc.Open();

            // عنوان گزارش
            Paragraph title = new Paragraph("گزارش اطلاعات جدول", FontFactory.GetFont("Tahoma", 14, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(title);
            pdfDoc.Add(new Paragraph("\n"));

            // ساخت جدول PDF با تعداد ستون‌ها
            PdfPTable pdfTable = new PdfPTable(grid.RootTable.Columns.Count);
            pdfTable.WidthPercentage = 100;

            // هدر ستون‌ها
            foreach (Janus.Windows.GridEX.GridEXColumn col in grid.RootTable.Columns)
            {
                if (!col.Visible) continue;
                PdfPCell cell = new PdfPCell(new Phrase(col.Caption, FontFactory.GetFont("Tahoma", 10, Font.BOLD)));
                cell.BackgroundColor = new BaseColor(230, 230, 230);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }

            // داده‌های ردیف‌ها
            foreach (Janus.Windows.GridEX.GridEXRow row in grid.GetRows())
            {
                if (row.RowType == Janus.Windows.GridEX.RowType.Record)
                {
                    foreach (Janus.Windows.GridEX.GridEXColumn col in grid.RootTable.Columns)
                    {
                        if (!col.Visible) continue;
                        object value = row.Cells[col.Key].Value ?? "";
                        PdfPCell cell = new PdfPCell(new Phrase(value.ToString(), FontFactory.GetFont("Tahoma", 9)));
                        pdfTable.AddCell(cell);
                    }
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();

            MessageBox.Show("فایل PDF با موفقیت ذخیره شد:\n" + filePath, "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطا در ساخت PDF: " + ex.Message);
        }
    }
}
