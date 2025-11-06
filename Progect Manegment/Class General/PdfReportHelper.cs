using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Progect_Manegment;
using System.Globalization;

namespace MyClass
{
    public static class PdfReportHelper
    {
        /// <summary>
        /// ساخت گزارش PDF از Janus GridEX با پشتیبانی از فارسی، لوگو و پارامترهای سفارشی صفحه
        /// </summary>
        public static void ExportJanusGridToPDF(
            Janus.Windows.GridEX.GridEX grid,
            string filePath,
            string reportTitle,
            string companyName,
            byte[] logoBytes = null,
            bool isLandscape = false,
            float leftMargin = 30f,
            float rightMargin = 30f,
            float topMargin = 35f,
            float bottomMargin = 45f)
        {
            if (grid == null)
            {
                MessageBox.Show("Grid مقداردهی نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rows = grid.GetRows().Where(r => r.RowType == RowType.Record).ToList();
            if (rows.Count == 0)
            {
                MessageBox.Show("هیچ داده‌ای برای خروجی وجود ندارد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var visibleCols = grid.RootTable.Columns.Cast<GridEXColumn>()
                                .Where(c => c.Visible)
                                .ToList();

            if (visibleCols.Count == 0)
            {
                MessageBox.Show("هیچ ستونی برای خروجی مشخص نشده است.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string dir = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(dir))
                    Directory.CreateDirectory(dir);

                // 🟣 فونت فارسی
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "vazir FD.ttf");
                if (!File.Exists(fontPath))
                    fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "tahoma.ttf");

                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                iTextSharp.text.Font fTitle = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fCompany = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fHeader = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fCell = new iTextSharp.text.Font(bf, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    // 🟢 تنظیم جهت صفحه
                    iTextSharp.text.Rectangle pageSize = isLandscape ? PageSize.A4.Rotate() : PageSize.A4;

                    using (Document doc = new Document(pageSize, leftMargin, rightMargin, topMargin, bottomMargin))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        writer.PageEvent = new PersianPdfPageEventHelper(bf, reportTitle, companyName);

                        doc.Open();

                        // ✅ Header: لوگو + عنوان + تاریخ
                        PdfPTable headerTable = new PdfPTable(3)
                        {
                            WidthPercentage = 100,
                            SpacingBefore = -10f // نزدیک‌تر شدن سربرگ به بالای صفحه
                        };
                        headerTable.SetWidths(new float[] { 15f, 70f, 15f }); // ستون وسط بزرگ‌تر
                        // لوگو
                        if (logoBytes != null && logoBytes.Length > 0)
                        {
                            try
                            {
                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoBytes);
                                logo.ScaleToFit(70f, 70f);
                                PdfPCell logoCell = new PdfPCell(logo)
                                {
                                    Border = Rectangle.NO_BORDER,
                                    HorizontalAlignment = Element.ALIGN_LEFT,
                                    VerticalAlignment = Element.ALIGN_MIDDLE
                                };
                                headerTable.AddCell(logoCell);
                            }
                            catch
                            {
                                headerTable.AddCell(new PdfPCell(new Phrase("")) { Border = Rectangle.NO_BORDER });
                            }
                        }
                        else
                        {
                            headerTable.AddCell(new PdfPCell(new Phrase("")) { Border = Rectangle.NO_BORDER });
                        }

                        // وسط: عنوان و نام شرکت
                        //headerTable.SetWidths(new float[] { 15f, 70f, 15f }); // ستون وسط بزرگ‌تر

                        PdfPCell centerCell = new PdfPCell
                        {
                            Border = Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            VerticalAlignment = Element.ALIGN_MIDDLE, // این خط اضافه شود
                            RunDirection = PdfWriter.RUN_DIRECTION_RTL
                        };
                        centerCell.AddElement(new Paragraph(companyName, fCompany) { Alignment = Element.ALIGN_CENTER });
                        centerCell.AddElement(new Paragraph(reportTitle, fTitle) { Alignment = Element.ALIGN_CENTER });
                        headerTable.AddCell(centerCell);
                        // راست: تاریخ گزارش
                        //string today = PersianDate.NowPersianDate;

                        PersianCalendar pc = new PersianCalendar();
                        DateTime now = DateTime.Now;

                        string today = $"{pc.GetDayOfMonth(now):00}/{pc.GetMonth(now):00}/{pc.GetYear(now):0000}";

                        PdfPCell dateCell = new PdfPCell(new Phrase("تاریخ گزارش '\n'" + today, fCell))
                        {
                            Border = Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                            RunDirection = PdfWriter.RUN_DIRECTION_LTR
                        };
                        headerTable.AddCell(dateCell);

                        doc.Add(headerTable);
                        doc.Add(new Paragraph("\n"));

                        // ✅ جدول داده‌ها
                        PdfPTable pdfTable = new PdfPTable(visibleCols.Count)
                        {
                            WidthPercentage = 100,
                            RunDirection = PdfWriter.RUN_DIRECTION_RTL
                        };

                        // هدرها
                        foreach (var col in visibleCols)
                        {
                            PdfPCell hcell = new PdfPCell(new Phrase(col.Caption ?? col.Key, fHeader))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE,
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                RunDirection = PdfWriter.RUN_DIRECTION_RTL
                            };
                            pdfTable.AddCell(hcell);
                        }

                        // داده‌ها
                        bool odd = false;
                        foreach (var row in rows)
                        {
                            odd = !odd;
                            BaseColor bgColor = odd ? new BaseColor(255, 255, 255) : new BaseColor(245, 245, 245);

                            foreach (var col in visibleCols)
                            {
                                object val = row.Cells[col.Key].Value ?? "";
                                PdfPCell c = new PdfPCell(new Phrase(val.ToString(), fCell))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    BackgroundColor = bgColor,
                                    RunDirection = PdfWriter.RUN_DIRECTION_RTL
                                };
                                pdfTable.AddCell(c);
                            }
                        }

                        doc.Add(pdfTable);
                        doc.Close();
                    }
                }

                MessageBox.Show("فایل PDF با موفقیت ذخیره شد:\n" + filePath, "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ایجاد PDF: " + ex.Message);
            }
        }

        public static void ExportJanusGridToPDF(Janus.Windows.GridEX.GridEX grid, string reportTitle)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var db = new DBcontextModel())
                {
                    var companyName = db.Settings.Where(c => c.Code==1).First().Subject;
                    byte[] logo = db.ImageCos.Where(c => c.Id==1).First().Image;

                    PdfReportHelper.ExportJanusGridToPDF(grid, sfd.FileName, reportTitle, companyName: companyName, logo,
        isLandscape: false,   // 👈 ایستاده
        leftMargin: 30f,
        rightMargin: 30f,
        topMargin: 15f,       // 👈 فاصله بالای کمتر
        bottomMargin: 45f
                        );
                }
            }

        }



        // ✳️ کلاس داخلی برای فوتر فارسی (شماره صفحه)
        private class PersianPdfPageEventHelper : PdfPageEventHelper
        {
            private readonly BaseFont _bf;
            private readonly string _reportTitle;
            private readonly string _companyName;

            public PersianPdfPageEventHelper(BaseFont bf, string reportTitle, string companyName)
            {
                _bf = bf;
                _reportTitle = reportTitle;
                _companyName = companyName;
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                try
                {
                    PdfContentByte cb = writer.DirectContent;
                    cb.BeginText();

                    iTextSharp.text.Font footerFont = new iTextSharp.text.Font(_bf, 9);
                    Phrase footerPhrase = new Phrase($"صفحه {writer.PageNumber}", footerFont);

                    ColumnText ct = new ColumnText(cb);
                    ct.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    float left = document.LeftMargin;
                    float right = document.PageSize.Width - document.RightMargin;
                    float bottom = document.BottomMargin / 2;

                    ct.SetSimpleColumn(footerPhrase, left, bottom, right, bottom + 20, 0, Element.ALIGN_RIGHT);
                    ct.Go();

                    cb.EndText();
                }
                catch
                {
                    // خطا در فوتر را نادیده بگیر
                }
            }
        }
    }
}
