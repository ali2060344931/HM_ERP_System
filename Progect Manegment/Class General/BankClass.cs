using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace MyClass
{
    /// <summary>
    /// کلاس برای ثبت اطلاعات در بانک داده ها
    /// </summary>
    static class SqlBankClass
    {
        //public static string txtAdres1 = @"D:\BankSekeh\BankSekeh.mdf";

        //public const string CONNECTION_STRING_ = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" +Application.StartupPath+@"\Bank\ReportManagBanck.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        //string AdresBank= File.ReadAllText("AdresBanck.txt");

        static string AdresBank
        {
            get
            {
                //return Application.StartupPath + @"\Banck_School\School_management_Banck.mdf";
                return "";

            }
        }
        //public static string CONNECTION_STRING
        //{
        //    get
        //    {
        //        return @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + AdresBank + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
        //        //return @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Banck_Restaurant_management\Restaurant_management_Banck.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //        //return @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Banck_Restaurant_management\Restaurant_management_Banck.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        //    }
        //}

        public static string CONNECTION_STRING
        {
            get
            {
                    return "";
                    //return "Data Source=localhost;user id=root;database=library1;password=00000 ;"; 
            }
        }


        //--------------------------------------------------------------------------------
        public static string SerchOnCellString(string steSql, string CONNECTION_STRING_)
        {
            SqlConnection connection = new SqlConnection();
            string m = "";
            try
            {
                connection.ConnectionString = CONNECTION_STRING_;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = steSql;
                    m = cmd.ExecuteScalar().ToString();
                }
                connection.Close();
                return m.ToString();
            }
            catch (Exception)
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m.ToString();
            }
        }

        //-------------------------------------------------------
        /*
        public static bool Update()
        {
            SqlConnection c = new SqlConnection();
            try
            {
                c.ConnectionString = CONNECTION_STRING_;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = "UPDATE TblActivBanc SET txtAdres='" + txtAdres1 + "',Name='BankSekeh'";

                    cmd.ExecuteNonQuery();
                }
                c.Close();
                return true;
            }
            catch (Exception err)
            {
                c.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //_______________________________________________________________________________________________________________________
*/
        /// <summary>
        /// متد درج اطلاعات در بانک
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool Insert(string tableName, params object[] values)
        {
            SqlConnection c = new SqlConnection();
            try
            {
                c.ConnectionString = CONNECTION_STRING;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = "INSERT INTO " + tableName + " VALUES (";
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (i == values.Length - 1)
                            cmd.CommandText += "@f" + i + ")";
                        else
                            cmd.CommandText += "@f" + i + ",";
                        cmd.Parameters.AddWithValue("@f" + i, values[i]);
                    }
                    cmd.ExecuteNonQuery();
                }
                c.Close();
                return true;
            }
            catch (Exception err)
            {
                c.Close();
                MessageBox.Show(err.Message, "ERROR_1235", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        //_______________________________________________________
        /// <summary>
        /// Insert Into TableName (Coli1,Col2,...) Values (Val1,Val2,...)
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static bool Insert(string sqlString)
        {
            SqlConnection c = new SqlConnection();
            try
            {
                c.ConnectionString = CONNECTION_STRING;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = sqlString;
                    cmd.ExecuteNonQuery();
                }
                c.Close();
                return true;
            }
            catch (Exception err)
            {
                c.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //_______________________________________________________________________________________________________________________

        /// <summary>
        /// متد جستجو در بانک
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="tableName"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        /// 

        public static System.Collections.ArrayList SearchOnRecordArrayList(string tableName, string criteria)
        {
            System.Collections.ArrayList record = new System.Collections.ArrayList();
            SqlConnection conection = new SqlConnection();
            try
            {
                conection.ConnectionString = CONNECTION_STRING;
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM " + tableName + (criteria == "" ? "" : " WHERE(" + criteria + ")");
                command.Connection = conection;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                        record.Add(dr[i].ToString());
                }
                conection.Close();
            }
            catch (Exception err)
            {
                conection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                record = null;
            }
            return record;
        }
        //_______________________________________________________________________________________________________________________
        public static System.Collections.ArrayList SearchOnRecordArrayList(string sqlString)
        {
            System.Collections.ArrayList record = new System.Collections.ArrayList();
            SqlConnection conection = new SqlConnection();
            try
            {
                conection.ConnectionString = CONNECTION_STRING;
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = sqlString;
                command.Connection = conection;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                        record.Add(dr[i].ToString());
                }
                conection.Close();
            }
            catch (Exception err)
            {
                conection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                record = null;
            }
            return record;
        }
        //_______________________________________________________________________________________________________________________
        public static System.Collections.Hashtable SearchOnRecordHashTable(string tableName, string criteria)
        {
            System.Collections.Hashtable record = new System.Collections.Hashtable();
            SqlConnection conection = new SqlConnection();
            try
            {
                conection.ConnectionString = CONNECTION_STRING;
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM " + tableName + (criteria == "" ? "" : " WHERE(" + criteria + ")");
                command.Connection = conection;
                SqlDataReader dr = command.ExecuteReader();
                
                if (dr.Read())
                    for (int i = 0; i < dr.FieldCount; i++)
                        record.Add(dr.GetName(i), dr[i].ToString());
                conection.Close();
            }

            catch (Exception err)
            {
                conection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                record = null;
            }
            return record;
        }
        //_______________________________________________________________________________________________________________________
        public static System.Collections.Hashtable SearchOnRecordHashTable(string sqlString)
        // System.Collections.Hashtable h =  SqlBankClass.SearchOnRecordHashTable("select name from tblTnzimat where idTanzimat=1");
        //string a= h["name"].ToString(); 
        {

            System.Collections.Hashtable record = new System.Collections.Hashtable();
            SqlConnection conection = new SqlConnection();
            try
            {
                conection.ConnectionString = CONNECTION_STRING;
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = sqlString;
                command.Connection = conection;
                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                    for (int i = 0; i < dr.FieldCount; i++)
                        record.Add(dr.GetName(i), dr[i].ToString());
                conection.Close();
            }

            catch (Exception err)
            {
                conection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                record = null;
            }
            return record;
        }
        //_______________________________________________________________________________________________________________________
        /// <summary>
        /// متد آپدیت کردن بانک
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="tableName"></param>
        /// <param name="fildnames"></param>
        /// <param name="fildValues"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        /// 
        public static bool Update(string tableName, string condition, params object[] field_values)
        {
            SqlConnection c = new SqlConnection();
            try
            {
                c.ConnectionString = CONNECTION_STRING;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = "UPDATE " + tableName + " SET ";

                    for (int i = 0; i < field_values.Length; i += 2)
                    {
                        cmd.CommandText += field_values[i] + "=@f" + i + ",";
                        cmd.Parameters.AddWithValue("@f" + i, field_values[i + 1]);
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1);//remove ending comma
                    //where
                    cmd.CommandText += (condition == "" ? "" : " WHERE " + condition);
                    cmd.ExecuteNonQuery();
                }
                c.Close();
                return true;
            }
            catch (Exception err)
            {
                c.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //_______________________________________________________________________________________________________________________

        /// <summary>
        ///  متد حذف رکورد در بانک
        /// </summary>
        /// <param name="bankNaame"></param>
        /// <param name="tableName"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public static bool Delete(string tableName, string criteria)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETE FROM " + tableName + " WHERE(" + criteria + ")";
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception )
            {
                connection.Close();
                 PublicClass.StopMesseg("بدلیل وجود اطلاعات در جداول دیگر، مجاز به حذف نمی باشید");
                return false;
            }
        }
        //_______________________________________________________________________________________________________________________
        public static bool DeleteAll(string tableName)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETE FROM " + tableName;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //_______________________________________________________________________________________________________________________
        /// <summary>
        /// متد نمایش دیتا گریدویو
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="sqlString"></param>
        /// <param name="dgrView"></param>
        /// 
        public static void ShowTableInDataGridView(string sqlString, DataGridView dgrView)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                dgrView.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //_______________________________________________________


        public static void ShowTableInDataGridView(string tableName, string showFields, string conditionPart, DataGridView dgrView)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT " + showFields + " FROM " + tableName + (conditionPart == "" ? "" : " WHERE " + conditionPart), connection);
                da.Fill(dt);
                dgrView.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //_______________________________________________________________________________________________________________________

        public static int SerchOnCells(string tableName, string fieldName, string valueField, string op)
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM " + tableName + " WHERE " + fieldName + op + "@f1";
                    cmd.Parameters.AddWithValue("@f1", valueField);
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (int)m;
            }
        }

        //_______________________________________________________
        public static int SerchOnCells(string steSql)
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = steSql;
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception)
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (int)m;
            }
        }

        //--------------------------------------------------------------------------------
        public static string SerchOnCellString(string steSql)
        {
            SqlConnection connection = new SqlConnection();
            string m = "";
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = steSql;
                    m = cmd.ExecuteScalar().ToString();
                }
                connection.Close();
                return m.ToString();
            }
            catch (Exception)
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m.ToString();
            }
        }
        //_______________________________________________________
        public static int CountValueIn1Field_Repeat(string tableName, string fieldName, string valueField, string op)
        //("peymankar", "namepeymankar", txtname.Text, "=")
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT COUNT(" + fieldName + ") FROM " + tableName + " WHERE " + fieldName + op + "@f1";
                    cmd.Parameters.AddWithValue("@f1", valueField);
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (int)m;
            }
        }

        //_______________________________________________________
        /// <summary>
        /// "select COUNT(fName) from moshtariha where fName='" + txtName.Text + "'"
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static int CountValueIn1Field_Repeat(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR -111 خطـــا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (int)m;
            }
        }

        //_______________________________________________________
        /// <summary>
        /// "sqlString= select Max(fName) from moshtariha where fName='" + txtName.Text + "'"
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static int MaxValueIn1Field(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception)
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR1221", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (int)m;
            }
        }
        //-------------------------------------------------------
        public static long MaxValueIn1Field_Long(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            long m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (long)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (long)m;
            }
        }
        public static double MaxValueIn1Field_double(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            double m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (double)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (double)m;
            }
        }


        //_______________________________________________________
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static long SumValueIn1Field(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            long m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (long)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception )
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m;
            }
        }
        //-------------------------------------------------------
        public static decimal SumValueIn1Field_float(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            decimal m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = Convert.ToDecimal(cmd.ExecuteScalar()); // Decimal sum
                }
                connection.Close();
                return m;
            }
            catch (Exception )
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m;
            }
        }
        //-------------------------------------------------------
        public static int SumValueIn1Field_(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            int m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (int)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m;
            }
        }
        //-------------------------------------------------------
        public static double SumValueIn1Field_Double(string sqlString)
        {
            SqlConnection connection = new SqlConnection();
            double m = 0;
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = sqlString;
                    m = (double)cmd.ExecuteScalar();
                }
                connection.Close();
                return m;
            }
            catch (Exception)
            {
                connection.Close();
                //MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return m;
            }
        }

        //_______________________________________________________________________________________________________________________
        public static void ShowTableInComboORList(string sqlString, ListControl ctrl, string fieldName)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                ctrl.DataSource = dt;
                ctrl.DisplayMember = fieldName;
                connection.Close();
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //_______________________________________________________________________________________________________________________
        public static void ShowTableInComboORList(string tableName, string showFields, string conditionPart, ListControl ctrl, string fieldName)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT " + showFields + " FROM " + tableName + (conditionPart == "" ? "" : " WHERE " + conditionPart), connection);
                da.Fill(dt);
                ctrl.DataSource = dt;
                ctrl.DisplayMember = fieldName;
                connection.Close();
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //____________________________آزمایشی___________________________

        public static void ShowTableInDataTable(string sqlString, DataTable dt1)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection);
                da.Fill(dt);
                dt1 = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                connection.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //_______________________________________________________________________________________________________________________

        public static void ConvertEAtoEf(string tableName, params  string[] fildname)
        {
            SqlConnection c = new SqlConnection();
            try
            {
                c.ConnectionString = CONNECTION_STRING;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    //string t = "";
                    cmd.CommandText += "UPDATE " + tableName + " SET ";
                    for (int i = 0; i < fildname.Length; i++)
                    {
                        cmd.CommandText += fildname[i] + " = REPLACE(" + fildname[i] + ", N'ی', N'ي'),";
                    }

                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1);//remove ending comma
                    cmd.ExecuteNonQuery();
                }
                c.Close();
            }
            catch (Exception err)
            {
                c.Close();
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //_______________________________________________________


        public static System.Drawing.Image GetImageFromFieldValue(object fieldValue)
        {
            try
            {
                byte[] arrpic = (byte[])fieldValue;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(arrpic);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        //_______________________________________________________


        public static bool UpdateWithPicture(string tableName, string pictureField, System.Drawing.Image picture, string[] otherFieldNames, string[] otherFieldValues, string criteria)


            //مثال:  SqlBankClass.UpdateWithPicture("moshtariha", "pic", pcbPicMoshtari.Image, new string[] { "fName", "lName", "PedarName", "meliCod", "shsh", "tarikhTavalod", "mahalTavalod", "idgender", "idtaahol", "idtahsilat", "idjob", "tel", "mobile", "emaile", "addres", "codPsti", "CodEshterac", "TarikhOzviat" }, new string[] {txtname.Text,txtfamili.Text,txtnamePedar.Text,txtcodMeli.Text,txtShSh.Text,mtbTarikhTavalod.Text,txtMahalTavalod.Text,idgender,idtaahol,idtahsilat,idjob,txtTel.Text,txtMobil.Text,txtImailAdres.Text,txtAdrres.Text,mtbCodPsti.Text,CodSargoroh,mtbTarikhOzviat.Text }, "id="+ idMoshtari)
        {
            try
            {
                //set picture
                byte[] arrpic = null;
                System.IO.MemoryStream mp = new System.IO.MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();
                mp.Close();
                //----------------
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                string parameters = "";
                for (int i = 0; i < otherFieldNames.Length; i++)
                    parameters += otherFieldNames[i] + "=@" + "Field" + i + ",";

                parameters += pictureField + "=@Picture";
                command.CommandText = "update " + tableName + " set " + parameters + " where (" + criteria + ")";

                for (int i = 0; i < otherFieldValues.Length; i++)
                    command.Parameters.AddWithValue("Field" + i, otherFieldValues[i].ToString());

                command.Parameters.AddWithValue("Picture", arrpic);
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //_______________________________________________________

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="picture"></param>
        /// <param name="otherFieldValues"></param>
        /// <returns></returns>
        public static bool InsertWithPicture(string tableName, System.Drawing.Image picture, params string[] otherFieldValues)
        {
            //picture field should there is end of table
            try
            {
                //set picture
                byte[] arrpic = null;
                System.IO.MemoryStream mp = new System.IO.MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();
                mp.Close();
                //----------------
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                SqlCommand command = new SqlCommand();
                string parameters = "";
                for (int i = 0; i < otherFieldValues.Length; i++)
                    parameters += "@" + "Field" + i + ",";
                parameters += "@Picture";
                command.CommandText = "insert into " + tableName + " values(" + parameters + ")";
                for (int i = 0; i < otherFieldValues.Length; i++)
                    command.Parameters.AddWithValue("Field" + i, otherFieldValues[i].ToString());

                command.Parameters.AddWithValue("Picture", arrpic);
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //_______________________________________________________


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
                MessageBox.Show(e.Message);
                return null;
            }
        }
        //_______________________________________________________

        //_______________________________________________________
        /// <summary>
        ///Exampel: "Create Table Test (StudentID int identity primary key, FirstName varchar(50), LastName varchar(50), Gender varchar(10), Age int, Address varchar(50) NOT NULL)"
        /// </summary>
        /// <param name="sqlstring"></param>
        public static void CeratTable(string sqlstring)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING);
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = sqlstring;
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("جدول مورد نظر قبل ایجاد گردید");

            }

        }
        //_______________________________________________________
        /// <summary>
        /// Exampel: "ALTER TABLE table_name ADD column_name datatype:varchar(50) NOT NULL‏"
        /// </summary>
        /// <param name="sqlstring"></param>
        public static void AddColumnInTable(string sqlstring)
        {

            try
            {
                SqlConnection c = new SqlConnection();
                c.ConnectionString = CONNECTION_STRING;
                c.Open();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = sqlstring;
                    cmd.ExecuteNonQuery();
                }
                c.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("عملیات مورد نظر قبلا انجام گردید");
                //MessageBox.Show(err.Message);
            }
        }
        //_______________________________________________________
        /// <summary>
        /// اجرای هر دستور اسکیوال
        /// </summary>
        /// <param name="sqlstring"></param>
        public static bool RunSqlCommand(string Sqlstring)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = Sqlstring;
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery(); //command.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("دستور اسکیوال مورد نظر ناقص می باشد");
                return false;
            }
        }

        //-------------------------------------------------------
        public static void InputExcelToDataDataGridView(string AdresFit, DataTable  dgrView)
        {
            try
            {
                // برای نسخه 2003
                //string ConnectionString_ = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + AdresFit + ";Extended properties=\"Excel 8.0; HDR=yes;\";";
                
                //برای نسخه 2007 به بالا
                string ConnectionString_ = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AdresFit + ";Extended properties=\"Excel 12.0 Xml; HDR=yes;\";";

                OleDbConnection con = new OleDbConnection(ConnectionString_);
                OleDbDataAdapter adp = new OleDbDataAdapter("Select * from[Sheet1$]", con);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                //dgrView.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }





    }
}
