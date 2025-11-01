using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

using Janus.Windows.GridEX;

public class GridPrintColumn
{
    public float left, width;
    public string ColumnKey;
    public string Text;
    public StringFormat StrFormat;
    public StringFormat ContentStringFormat;

    public GridPrintColumn()
    {
        StrFormat = new StringFormat();
        StrFormat.LineAlignment = StringAlignment.Center;
        StrFormat.Alignment = StringAlignment.Center;
        StrFormat.Trimming = StringTrimming.None;

        ContentStringFormat = new StringFormat(StringFormatFlags.FitBlackBox);
        ContentStringFormat.LineAlignment = StringAlignment.Center;
        ContentStringFormat.Alignment = StringAlignment.Center;
        ContentStringFormat.Trimming = StringTrimming.None;
    }
}

public class GridPrintColumnCollection : List<GridPrintColumn>
{
    private float Width = 1000;
    private float Height = 10;
    public GridEX DataGrid;

    public float HeaderHeight = 26;
    public float RowHeight = 20;

    public SolidBrush HeaderBackgroundBrush = new SolidBrush(Color.DarkBlue);
    public SolidBrush HeaderTextBrush = new SolidBrush(Color.White);
    public Font HeaderFont = new Font("Tahoma", 9, FontStyle.Bold);
    public int HeaderBodyGap = 5;

    public SolidBrush RowBackgroundBrush = new SolidBrush(Color.White);
    public SolidBrush RowTextBrush = new SolidBrush(Color.Black);
    public Font RowFont = new Font("Tahoma", 9, FontStyle.Regular);

    public SolidBrush AlterRowBackgroundBrush = new SolidBrush(Color.FromArgb(255, 240, 240, 255));
    public SolidBrush AlterRowTextBrush = new SolidBrush(Color.Black);
    public Font AlterRowFont = new Font("Tahoma", 9, FontStyle.Regular);

    public string CompanyName, Comment, SystemDate;
    public Image CompanyImage;
    public Font CompanyInfoFont = new Font("Tahoma", 9, FontStyle.Regular);
    public SolidBrush CompanyInfoBrush = new SolidBrush(Color.Black);
    public float CompanyInfoLineHeight = 20;
    private List<int> lineIndexes = new List<int>();

    // PageBoundries در ابتدا کل فضای چاپ فرضی است و بعداً توسط InitPageBoundries تنظیم می‌شود.
    public RectangleF PageBoundries = new RectangleF(0, 0, 1000, 1000);

    public bool PageLocked = false;

    public PrintDocument Doc;

    // --- فیلدهای حاشیه‌های سفارشی و فوتر ---
    public float LeftRightMargin = 1; // حاشیه چپ و راست دلخواه
    public float TopBottomMargin = 1; // حاشیه بالا و پایین دلخواه
    public float FooterHeight = 10; // ارتفاع فوتر
    public string FooterText = "چاپ شده توسط سیستم"; // متن فوتر پیش فرض
    public Font FooterFont = new Font("Tahoma", 8, FontStyle.Italic);
    public SolidBrush FooterBrush = new SolidBrush(Color.Gray);
    // ----------------------------------------

    public GridPrintColumnCollection(PrintDocument document) : base()
    {
        Doc = document;
        Doc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
    }

    public void Print()
    {
        Doc.Print();
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        if (PageNum == 0)
        {
            tRow = 0;
            // ارسال حاشیه‌ها و ابعاد کاغذ پرینتر
            if (e.PageSettings.Landscape == true)
            {
                InitPageBoundries(e.PageSettings.Margins.Left, e.PageSettings.Margins.Top, e.PageSettings.PaperSize.Height - e.PageSettings.Margins.Right - e.PageSettings.Margins.Left, e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Bottom - e.PageSettings.Margins.Top);
            }
            else
            {
                InitPageBoundries(e.PageSettings.Margins.Left, e.PageSettings.Margins.Top, e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right - e.PageSettings.Margins.Left, e.PageSettings.PaperSize.Height - e.PageSettings.Margins.Bottom - e.PageSettings.Margins.Top);
            }
            PageLocked = true;
            PageNum = 1;
        }
        e.HasMorePages = Draw(e.Graphics, 0);
        Application.DoEvents();
        if (e.Cancel == true || e.HasMorePages == false)
        {
            PageNum = 0;
            tRow = 0;
            PageLocked = false;
        }
    }

    public void InitPageBoundries(float Left, float Top, float Width, float Height)
    {
        if (!PageLocked)
        {
            // محاسبه ابعاد قابل استفاده با کسر حاشیه‌های سفارشی
            float usableWidth = Width - (2 * LeftRightMargin);
            float newLeft = Left + LeftRightMargin;
            float usableHeight = Height - (2 * TopBottomMargin);
            float newTop = Top + TopBottomMargin;

            float factor = usableWidth / PageBoundries.Width;

            foreach (GridPrintColumn c in this)
            {
                c.width = c.width * factor;
                c.left = (c.left - PageBoundries.Left) * factor + newLeft;
            }

            RowHeight *= factor;
            HeaderHeight *= factor;
            if (factor != 1)
            {
                RowFont = new Font(RowFont.FontFamily, RowFont.Size * factor, RowFont.Style);
                AlterRowFont = new Font(AlterRowFont.FontFamily, AlterRowFont.Size * factor, AlterRowFont.Style);
                HeaderFont = new Font(HeaderFont.FontFamily, HeaderFont.Size * factor, HeaderFont.Style);
            }

            // تنظیم PageBoundries به فضای قابل استفاده واقعی
            PageBoundries = new RectangleF(newLeft, newTop, usableWidth, usableHeight);
        }
    }

    public int tRow = 0;
    public int PageNum = 0;

    public bool Draw(Graphics G, int NumOfRows)
    {
        // tTop از ابتدای فضای قابل استفاده شروع می‌شود
        float tTop = PageBoundries.Top;

        // --- رسم سربرگ ---
        int h = (int)CompanyInfoLineHeight;
        StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft, 41);
        sf.Alignment = StringAlignment.Near;
        sf.LineAlignment = StringAlignment.Center;

        // استفاده از PageBoundries.Left و PageBoundries.Width برای رسم اطلاعات شرکت
        Rectangle r = new Rectangle((int)PageBoundries.Left, (int)tTop, (int)PageBoundries.Width, 20);

        SizeF s;
        // رسم اطلاعات شرکت (نام شرکت، تاریخ، توضیح، شماره صفحه)
        G.DrawString("نام شرکت : ", CompanyInfoFont, CompanyInfoBrush, r, sf);
        s = G.MeasureString("نام شرکت : ", CompanyInfoFont, r.Size, sf, out _, out _);
        G.DrawString(CompanyName, CompanyInfoFont, CompanyInfoBrush, new Rectangle(r.X, r.Y, (int)(r.Width - s.Width), r.Height), sf);
        tTop += h;
        r.Y += h;
        G.DrawString("تاریخ چاپ : ", CompanyInfoFont, CompanyInfoBrush, r, sf);
        s = G.MeasureString("تاریخ چاپ : ", CompanyInfoFont, r.Size, sf, out _, out _);
        G.DrawString(SystemDate, CompanyInfoFont, CompanyInfoBrush, new Rectangle(r.X, r.Y, (int)(r.Width - s.Width), r.Height), sf);
        tTop += h;
        r.Y += h;
        G.DrawString("توضیح : ", CompanyInfoFont, CompanyInfoBrush, r, sf);
        s = G.MeasureString("توضیح : ", CompanyInfoFont, r.Size, sf, out _, out _);
        G.DrawString(Comment, CompanyInfoFont, CompanyInfoBrush, new Rectangle(r.X, r.Y, (int)(r.Width - s.Width), r.Height), sf);
        tTop += h;
        r.Y += h;
        G.DrawString("شماره صفحه : ", CompanyInfoFont, CompanyInfoBrush, r, sf);
        s = G.MeasureString("شماره صفحه : ", CompanyInfoFont, r.Size, sf, out _, out _);
        G.DrawString(PageNum.ToString(), CompanyInfoFont, CompanyInfoBrush, new Rectangle(r.X, r.Y, (int)(r.Width - s.Width), r.Height), sf);
        tTop += h + HeaderBodyGap;


        if (CompanyImage != null)
        {
            // رسم تصویر از گوشه فضای قابل استفاده
            G.DrawImage(CompanyImage, PageBoundries.Left + 1, PageBoundries.Top + 1, h * 4 - 2, h * 4 - 2);
        }

        // رسم ستون‌های جدول
        foreach (GridPrintColumn col in this)
        {
            // col.left و col.width قبلاً با LeftRightMargin تنظیم شده‌اند.
            r = new Rectangle((int)col.left, (int)tTop, (int)col.width, (int)HeaderHeight);
            G.FillRectangle(HeaderBackgroundBrush, r);
            G.DrawRectangle(Pens.White, r);
            G.DrawString(col.Text, HeaderFont, HeaderTextBrush, r, col.StrFormat);
        }
        tTop += HeaderHeight;
        // ----------------------------------------


        // --- رسم سطرها (Draw Rows) ---
        while (tRow < DataGrid.GetRows().Length)
        {
            int parity = 0;
            if (DataGrid.GetRows()[tRow].RowType == RowType.Record || DataGrid.GetRows()[tRow].RowType == RowType.TotalRow)
            {
                GridEXRow dgr = DataGrid.GetRows()[tRow];
                DrawRow(dgr, parity, G, tTop);
                tTop += RowHeight;

                // بررسی فضای صفحه: اگر فضای کافی تا انتهای فضای قابل استفاده (منهای ارتفاع فوتر) وجود نداشت
                if (tTop + RowHeight > PageBoundries.Bottom - FooterHeight)
                {
                    PageNum += 1;
                    tRow += 1;
                    return true;
                }
            }
            else
            {
                parity = (parity + 1) % 2;
            }
            tRow += 1;
            if (tRow == NumOfRows)
            {
                tRow = 0;
                break;
            }
        }

        if (DataGrid.GetTotalRow() != null)
        {
            DrawRow(DataGrid.GetTotalRow(), 0, G, tTop);
            G.DrawLine(Pens.Black, this[0].left, tTop, this[this.Count - 1].left + this[this.Count - 1].width, tTop);
        }
        // ----------------------------------------


        // --- رسم فوتر (Footer) ---
        // محدوده فوتر: از انتهای فضای قابل استفاده شروع می‌شود و کل عرض را پر می‌کند
        RectangleF footerRect = new RectangleF(
            PageBoundries.Left,
            PageBoundries.Bottom - FooterHeight,
            PageBoundries.Width,
            FooterHeight
        );

        StringFormat footerFormat = new StringFormat();
        footerFormat.Alignment = StringAlignment.Far;
        footerFormat.LineAlignment = StringAlignment.Center;

        string finalFooterText = $"{FooterText} | صفحه: {PageNum}";

        G.DrawString(
            finalFooterText,
            FooterFont,
            FooterBrush,
            footerRect,
            footerFormat
        );
        // ----------------------------------------

        return false;
    }

    public void DrawRow(GridEXRow dgr, int parity, Graphics g, float tTop)
    {
        for (int i = 0; i < this.Count; i++)
        {
            GridPrintColumn col = this[i];
            Rectangle rect = new Rectangle((int)col.left, (int)tTop, (int)col.width, (int)RowHeight);
            if (tRow % 2 == parity)
            {
                g.FillRectangle(RowBackgroundBrush, rect);
                g.DrawRectangle(Pens.White, rect);
                DrawCell(g, dgr.Cells[col.ColumnKey], RowFont, RowTextBrush, rect, col.ContentStringFormat);
            }
            else
            {
                g.FillRectangle(AlterRowBackgroundBrush, rect);
                g.DrawRectangle(Pens.White, rect);
                DrawCell(g, dgr.Cells[col.ColumnKey], AlterRowFont, AlterRowTextBrush, rect, col.ContentStringFormat);
            }
            if (lineIndexes.Contains(i))
            {
                // ...
            }
        }
    }

    public void DrawCell(Graphics g, GridEXCell cell, Font RowFont, Brush RowTextBrush, Rectangle rect, StringFormat stf)
    {
        if (cell.Column.Type == typeof(bool))
        {
            // رفع خطای unassigned local variable
            RectangleF r = new RectangleF();
            r.Width = Math.Min(rect.Width * 60f / 100f, rect.Height * 60f / 100f);
            r.Height = r.Width;
            if (stf.Alignment == StringAlignment.Center)
            {
                r.X = (rect.Left + (rect.Width / 2) - (r.Width / 2));
            }
            else if (stf.Alignment == StringAlignment.Far)
            {
                r.X = rect.Right - r.Width;
            }
            else
            {
                r.X = rect.Left;
            }
            if (stf.LineAlignment == StringAlignment.Center)
            {
                r.Y = rect.Y + (rect.Height / 2) - r.Height / 2;
            }
            else if (stf.LineAlignment == StringAlignment.Far)
            {
                r.Y = rect.Height - r.Height;
            }
            else
            {
                r.Y = rect.Y;
            }
            Image img;
            // جایگزین کردن My.Resources.Resource
            if ((bool)cell.Value == true)
            {
                // img = Properties.Resources.imgTrue; 
                img = new Bitmap(1, 1); // جایگزین موقت
            }
            else
            {
                // img = Properties.Resources.imgFalse; 
                img = new Bitmap(1, 1); // جایگزین موقت
            }
            g.DrawImage(img, r);
        }
        else
        {
            g.DrawString(cell.Text, RowFont, RowTextBrush, rect, stf);
        }
    }

    public void AddRange(GridEX Grid)
    {
        int ColCount = 0;
        for (int i = Grid.RootTable.Columns.Count - 1; i >= 0; i--)
        {
            GridEXColumn col = Grid.RootTable.Columns[i];
            if (col.Visible == true)
            {
                ColCount += 1;
            }
        }

        // استفاده از حاشیه برای تعیین نقطه شروع و عرض قابل استفاده
        float l = PageBoundries.Left;
        float usableWidth = PageBoundries.Width; // PageBoundries.Width قبلاً با حاشیه LeftRightMargin تنظیم شده است.

        int colix = 0;
        for (int i = Grid.RootTable.Columns.Count - 1; i >= 0; i--)
        {
            GridEXColumn col = Grid.RootTable.Columns[i];
            if (col.Visible == true)
            {
                GridPrintColumn gpc = new GridPrintColumn();

                gpc.ColumnKey = col.Key;
                gpc.Text = col.Caption;
                gpc.width = usableWidth / ColCount;
                gpc.left = l;
                gpc.StrFormat.Alignment = StringAlignment.Far;
                gpc.ContentStringFormat.Alignment = StringAlignment.Far;
                l += gpc.width;

                this.Add(gpc);
                this.lineIndexes.Add(colix);
                colix += 1;
            }
        }
    }

    public void SwapCollumns(int ix1, int ix2)
    {
        GridPrintColumn tcol = this[ix2];

        if (this[ix1].left < this[ix2].left)
        {
            this[ix2].left = this[ix1].left;
            this[ix1].left = this[ix2].left + this[ix2].width;
        }
        else
        {
            this[ix1].left = this[ix2].left;
            this[ix2].left = this[ix1].left + this[ix1].width;
        }

        this[ix2] = this[ix1];
        this[ix1] = tcol;

    }
}