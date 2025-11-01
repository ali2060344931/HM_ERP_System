using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using HM_ERP_System;

namespace MyClass
{
    static class SqlServerBankClass
    {
        private static string CONNECTION_STRING ="";

        public static bool Insert(string tableName, params string[] fieldValues)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = MyClass.SqlBankClass.CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                string parameters = "";
                //create parameters
                for (int i = 0; i < fieldValues.Length; i++)
                    parameters += "@" + "Field" + i + ",";
                parameters = parameters.Remove(parameters.Length - 1);//end (,) remove
                command.CommandText = "insert into " + tableName + " values(" + parameters + ")";
                //set data with parameters
                for (int i = 0; i < fieldValues.Length; i++)
                    command.Parameters.AddWithValue("Field" + i, fieldValues[i].ToString());
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool InsertWithFields(string tableName, params string[] fieldNamesANDValues)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                //create names
                string names = "";
                for (int i = 0; i < fieldNamesANDValues.Length; i += 2)
                    names += fieldNamesANDValues[i] + ",";
                names = names.Remove(names.Length - 1);//end (,) remove
                //--
                string parameters = "";
                //create parameters
                for (int i = 1; i < fieldNamesANDValues.Length; i += 2)
                    parameters += "@" + "Field" + i + ",";
                parameters = parameters.Remove(parameters.Length - 1);//end (,) remove
                command.CommandText = "insert into " + tableName + " (" + names + ") values (" + parameters + ")";
                //set data with parameters
                for (int i = 1; i < fieldNamesANDValues.Length; i += 2)
                    command.Parameters.AddWithValue("Field" + i, fieldNamesANDValues[i].ToString());
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static System.Collections.ArrayList SearchOneRecord(string tableName, string criteria)
        {
            System.Collections.ArrayList record = new System.Collections.ArrayList();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from " + tableName + " where(" + criteria + ")";
                command.Connection = connection;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())  //yes find
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                        record.Add(dr[i].ToString());
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return record;
        }

        public static bool Update(string tableName, string[] fieldNames, string[] fieldValues, string criteria)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                string parameters = "";
                //create parameters
                for (int i = 0; i < fieldNames.Length; i++)
                    parameters += fieldNames[i] + "=@" + "Field" + i + ",";
                parameters = parameters.Remove(parameters.Length - 1);//end (,) remove
                command.CommandText = "update " + tableName + " set " + parameters + " where (" + criteria + ")";
                //set data with parameters
                for (int i = 0; i < fieldValues.Length; i++)
                    command.Parameters.AddWithValue("Field" + i, fieldValues[i].ToString());
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateWithSqlFunctionOrOperator(string sqlstring)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = sqlstring;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Delete(string tableName, string criteria)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from " + tableName + " where(" + criteria + ")";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteAll(string tableName)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from " + tableName;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void ShowTableInDataGridView(string sqlString, DataGridView dgrView)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                dgrView.DataSource = dt;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ShowTableFieldToComboBox(string sqlString, ComboBox combo, string field, params string[] otherValues)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                //---
                if (otherValues.Length != 0)
                {
                    DataTable dt1 = new DataTable();
                    for (int i = 0; i < dt.Columns.Count; i++)
                        dt1.Columns.Add(dt.Columns[i].ColumnName);
                    DataRow dr = dt1.NewRow();
                    dr[field] = otherValues[0];
                    dt1.Rows.Add(dr);
                    dt1.Merge(dt);
                    dt = dt1;
                }
                //------
                combo.DataSource = dt;
                combo.DisplayMember = field;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ShowTableFieldToListBox(string sqlString, ListBox list, string field)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                //for (int i = 0; i < dt.Rows.Count; i++)
                //    dt.Rows[i][field1] += "   (" + dt.Rows[i][field2] + ")";
                list.DataSource = dt;
                list.DisplayMember = field;
                if (list.SelectionMode != SelectionMode.None)
                    list.SelectedIndex = -1;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ShowTableInBindingNavigator(string tableName, BindingNavigator bindingNavigator1)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + tableName, connection);
                da.Fill(dt);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = dt;
                bindingNavigator1.BindingSource = bindingSource1;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool BackupWithDataSet(params string[] tableNames)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet dataSet1 = new DataSet();
                foreach (string tablename in tableNames)
                {
                    DataTable table = new DataTable(tablename);
                    da.SelectCommand = new SqlCommand("select * from " + tablename, connection);
                    da.Fill(table);
                    dataSet1.Tables.Add(table);
                }
                connection.Close();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Xml Files (*.xml)|*.xml";
                int d1, m1, y1;
                StaticClass.MiladyToShamsy(DateTime.Now, out d1, out m1, out y1);
                saveFileDialog1.FileName = y1 + "-" + ((m1 <= 9) ? "0" + m1 : m1.ToString()) + "-" + ((d1 <= 9) ? "0" + d1 : d1.ToString());//default
                //saveFileDialog1.FileName = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;//default
                DialogResult d = saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "" && d != DialogResult.Cancel)
                {
                    dataSet1.WriteXml(saveFileDialog1.FileName);
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool RestoreWithDataSet()
        {
            try
            {
                DataSet dataSet1 = new DataSet();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.Filter = "Xml Files (*.xml)|*.xml";
                openFileDialog1.FileName = "";
                DialogResult d = openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "" && d != DialogResult.Cancel)
                {
                    dataSet1.ReadXml(openFileDialog1.FileName);
                }
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                foreach (DataTable table in dataSet1.Tables)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.DeleteCommand = new SqlCommand("delete from " + table.TableName, connection);
                    da.DeleteCommand.ExecuteNonQuery();
                    da.SelectCommand = new SqlCommand("select * from " + table.TableName, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dataSet1, table.TableName);
                }
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void ShowReportRDLC(string tableName, string condition, string dataSetName, string reportName, ReportViewer reportViewer, params string[] a)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + tableName + " " + condition, connection);
                DataTable table1 = new DataTable();
                da.Fill(table1);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = table1;
                ReportDataSource reportDataSource1 = new ReportDataSource(dataSetName);
                reportDataSource1.Value = bindingSource1;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                reportViewer.LocalReport.ReportEmbeddedResource = reportName;
                //فقط برای ارسال پارامترها به گزارش
                if (a.Length != 0)//
                {
                    ReportParameter[] p = new ReportParameter[a.Length / 2];
                    for (int i = 0, j = 0; j < a.Length; i++, j += 2)
                        p[i] = new ReportParameter(a[j], a[j + 1]);
                    reportViewer.LocalReport.SetParameters(p);
                }
                //-----
                reportViewer.RefreshReport();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+'\n'+"خطا در محاسبه گزارش-کد1996", ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ShowReportRDLC_More_Than_One(string reportName, ReportViewer reportViewer, int n, params string[] a)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                int Len = a.Length - n * 3;

                for (int i = 0; i < n * 3; i += 3)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + a[i] + " " + a[i + 1], connection);
                    DataTable table1 = new DataTable();
                    da.Fill(table1);
                    BindingSource bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = table1;
                    ReportDataSource reportDataSource = new ReportDataSource(a[i + 2]);
                    reportDataSource.Value = bindingSource1;
                    if (i == 0) reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.DataSources.Add(reportDataSource);
                }
                reportViewer.LocalReport.ReportEmbeddedResource = reportName;
                //فقط برای ارسال پارامترها به گزارش

                if (Len != 0)//
                {
                    ReportParameter[] p = new ReportParameter[Len / 2];
                    for (int i = 0, j = n * 3; j < a.Length; i++, j += 2)
                        p[i] = new ReportParameter(a[j], a[j + 1]);
                    reportViewer.LocalReport.SetParameters(p);
                }

                reportViewer.RefreshReport();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

/// <summary>
        /// dt = MyClass.SqlServerBankClass.ReadTableFromBank_InsertToDataTable("Select * from TblSabtNobatVam");
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static DataTable ReadTableFromBank_InsertToDataTable(string sqlString)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void ShowReportRDLCWithStoredProcedure(string storedProcedureName, string dataSetName, string reportName, ReportViewer reportViewer, string[] paramNameAndValue, params string[] a)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = CommandType.StoredProcedure;
                command1.CommandText = storedProcedureName;
                for (int i = 0; i < paramNameAndValue.Length; i += 2)
                {
                    command1.Parameters.AddWithValue(paramNameAndValue[i], paramNameAndValue[i + 1]);
                }
                SqlDataAdapter da = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                da.Fill(table1);
                //-------set report--------------
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = table1;
                ReportDataSource reportDataSource1 = new ReportDataSource(dataSetName);
                reportDataSource1.Value = bindingSource1;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                reportViewer.LocalReport.ReportEmbeddedResource = reportName;
                //فقط برای ارسال پارامترها به گزارش
                if (a.Length != 0)//
                {
                    ReportParameter[] p = new ReportParameter[a.Length / 2];
                    for (int i = 0, j = 0; j < a.Length; i++, j += 2)
                        p[i] = new ReportParameter(a[j], a[j + 1]);
                    reportViewer.LocalReport.SetParameters(p);
                }
                reportViewer.RefreshReport();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, ResourceCode.ProgName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}