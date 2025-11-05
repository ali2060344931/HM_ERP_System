using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Janus.Windows.GridEX;
using System.Collections.Generic;
using System.Linq;

namespace MyClass
{
    /// <summary>
    /// تبدیل لیست دیتاگرید به گزارش
    /// </summary>
    public static class ReportHelper
    {
        /// <summary>
        ///Janus GridEX استخراج داده‌های فیلتر شده از
        /// </summary>
        public static DataTable GetFilteredDataFromJanus(Janus.Windows.GridEX.GridEX grid)
        {
            try
            {
                DataTable dt = new DataTable();

                // اگر هیچ ردیفی وجود نداشت
                if (grid.GetRows().Count() == 0)
                    return dt;

                // ساخت ستون‌ها بر اساس ستون‌های GridEX
                foreach (Janus.Windows.GridEX.GridEXColumn col in grid.RootTable.Columns)
                {
                    if (col.Visible)
                        dt.Columns.Add(col.Key, typeof(object));
                }

                // پیمایش رکوردهای فیلتر شده‌ی قابل مشاهده در گرید
                foreach (Janus.Windows.GridEX.GridEXRow row in grid.GetRows())
                {
                    if (row.RowType == Janus.Windows.GridEX.RowType.Record)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (Janus.Windows.GridEX.GridEXColumn col in grid.RootTable.Columns)
                        {
                            if (col.Visible)
                                dr[col.Key] = row.Cells[col.Key].Value ?? DBNull.Value;
                        }
                        dt.Rows.Add(dr);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در استخراج داده‌های فیلترشده از GridEX: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        ///DataTable نمایش گزارش از یک یا چند
        /// </summary>
        /// <param name="reportName">نام گزارش (مسیر Embedded Report)</param>
        /// <param name="reportViewer">کنترل ReportViewer</param>
        /// <param name="dataSources">لیست جفت‌های (DataTable, DataSetName)</param>
        /// <param name="parameters">پارامترهای گزارش</param>
        public static void ShowReportFromDataTables(
            string reportName,
            ReportViewer reportViewer,
            List<(DataTable Table, string DataSetName)> dataSources,
            params ReportParameter[] parameters)
        {
            try
            {
                if (dataSources == null || dataSources.Count == 0)
                {
                    MessageBox.Show("هیچ داده‌ای برای نمایش گزارش ارسال نشده است.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                reportViewer.LocalReport.DataSources.Clear();

                foreach (var ds in dataSources)
                {
                    if (ds.Table == null || ds.Table.Rows.Count == 0)
                        continue;

                    var reportDataSource = new ReportDataSource(ds.DataSetName, ds.Table);
                    reportViewer.LocalReport.DataSources.Add(reportDataSource);
                }

                reportViewer.LocalReport.ReportEmbeddedResource = reportName;

                if (parameters != null && parameters.Length > 0)
                    reportViewer.LocalReport.SetParameters(parameters);

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در نمایش گزارش: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// نمایش گزارش از GridEX به همراه چند DataTable جانبی (مثلاً لوگو یا اطلاعات شرکت)
        /// </summary>
        public static void ShowReportFromGridEX(
            GridEX grid,
            string reportName,
            ReportViewer reportViewer,
            string mainDataSetName,
            List<(DataTable Table, string DataSetName)> extraDataSources = null,
            params ReportParameter[] parameters)
        {
            DataTable filteredTable = GetFilteredDataFromJanus(grid);
            var allSources = new List<(DataTable, string)>
            {
                (filteredTable, mainDataSetName)
            };

            if (extraDataSources != null && extraDataSources.Count > 0)
                allSources.AddRange(extraDataSources);

            ShowReportFromDataTables(reportName, reportViewer, allSources, parameters);
        }
    }
}
