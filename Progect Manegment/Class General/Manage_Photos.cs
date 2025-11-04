using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing;

namespace MyClass
{
    class Manage_Photos
    {

        public static string CONNECTION_STRING = MyClass.SqlBankClass.CONNECTION_STRING;


        public static DataTable Read_TableFromBank_InsertToDataTable(string sqlString)
        {
            try
            {
                SqlConnection connection_ = new SqlConnection();
                connection_.ConnectionString = CONNECTION_STRING;
                connection_.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlString, connection_);
                da.Fill(dt);
                connection_.Close();
                return dt;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er); return null;
            }

        }
        //-------------------------------------------------------
        public static bool Insert_WithPictur(string tableName, System.Drawing.Image picture, params string[] otherFieldValues)
        {
            try
            {
                byte[] arrpic = null;
                MemoryStream mp = new MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();
                mp.Close();

                SqlConnection connect_ = new SqlConnection();
                connect_.ConnectionString = CONNECTION_STRING;
                connect_.Open();
                SqlCommand cm = new SqlCommand();
                string parameters = "";

                for (int i = 0; i < otherFieldValues.Length; i++)
                    parameters += "@Field" + i + ",";

                parameters += "@picture";
                cm.CommandText = "INSERT INTO " + tableName + " VALUES(" + parameters + ")";

                for (int i = 0; i < otherFieldValues.Length; i++)
                    cm.Parameters.AddWithValue("Field" + i, otherFieldValues[i].ToString());

                cm.Parameters.AddWithValue("picture", arrpic);
                cm.Connection = connect_;
                cm.ExecuteNonQuery();
                connect_.Close();
                return true;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er); return false;
            }

        }
        //-------------------------------------------------------
        /// <summary>
        /// (توضیحات):otherFieldValues: Filds0,FildValues0,Filds1,FildValues1, ...
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="picture"></param>
        /// <param name="otherFieldValues"></param>
        /// <returns></returns>
        public static bool Insert_WithPictur2(string tableName, System.Drawing.Image picture, params string[] otherFieldValues)
        {
            try
            {
                byte[] arrpic = null;
                MemoryStream mp = new MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();
                mp.Close();

                SqlConnection connect_ = new SqlConnection();
                connect_.ConnectionString = CONNECTION_STRING;
                connect_.Open();
                SqlCommand cm = new SqlCommand();
                string Filds = "";
                string FildValues = "";

                for (int i = 0; i < otherFieldValues.Length; i += 2)
                {
                    Filds += otherFieldValues[i] + ",";
                    FildValues += "@FieldV" + (i + 1) + ",";
                }

                //for (int i = 1; i < otherFieldValues.Length; i += 2)
                //    FildValues += "@FieldV" + i + ",";

                FildValues += "@pic";
                Filds += "pic";
                cm.CommandText = "INSERT INTO " + tableName + " (" + Filds + ") VALUES(" + FildValues + ")";

                for (int i = 1; i < otherFieldValues.Length; i += 2)
                    cm.Parameters.AddWithValue("FieldV" + i, otherFieldValues[i].ToString());

                cm.Parameters.AddWithValue("pic", arrpic);
                cm.Connection = connect_;
                cm.ExecuteNonQuery();
                connect_.Close();
                return true;
            }
            //catch (Exception er)
            //{

            //    MessageBox.Show(er.Message);
            //    return false;
            //}
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er); return false;
            }

        }




        //_______________________________________________________
        public static bool Update_WithPicture(string tableName, string picturFiald, System.Drawing.Image picture, string[] otherFieldName, string[] otherFieldValues, string criteria)
        {

            //مثال: MyClass.SqlBankClass.UpdateWithPicture("moshtariha", "pic", pcbPicMoshtari.Image, new string[] { "fName", "lName", "PedarName", "meliCod", "shsh", "tarikhTavalod", "mahalTavalod", "idgender", "idtaahol", "idtahsilat", "idjob", "tel", "mobile", "emaile", "addres", "codPsti", "CodEshterac", "TarikhOzviat" }, new string[] {txtname.Text,txtfamili.Text,txtnamePedar.Text,txtcodMeli.Text,txtShSh.Text,mtbTarikhTavalod.Text,txtMahalTavalod.Text,idgender,idtaahol,idtahsilat,idjob,txtTel.Text,txtMobil.Text,txtImailAdres.Text,txtAdrres.Text,mtbCodPsti.Text,CodSargoroh,mtbTarikhOzviat.Text }, "id="+ idMoshtari)

            try
            {
                byte[] arrpic = null;
                MemoryStream mp = new MemoryStream();
                picture.Save(mp, picture.RawFormat);
                arrpic = mp.GetBuffer();
                mp.Close();

                //**********@@@@*********

                SqlConnection connect_ = new SqlConnection();
                connect_.ConnectionString = CONNECTION_STRING;
                connect_.Open();
                SqlCommand cm = new SqlCommand();
                string parameters = "";
                for (int i = 0; i < otherFieldName.Length; i++)
                    parameters += otherFieldName[i] + "=@Field" + i + ",";
                parameters += picturFiald + "=@picture";

                cm.CommandText = "UPDATE " + tableName + "SET" + parameters + "WHERE (" + criteria + ")";
                for (int i = 0; i < otherFieldValues.Length; i++)
                    cm.Parameters.AddWithValue("Field" + i, otherFieldValues[i].ToString());
                cm.Parameters.AddWithValue("picture", arrpic);
                cm.Connection = connect_;
                cm.ExecuteNonQuery();
                connect_.Close();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }

        }
        //_______________________________________________________

        public static System.Drawing.Image GetImageFromeFieldValues(object fildValue)
        {
            try
            {
                byte[] arrpic = (byte[])fildValue;
                MemoryStream ms = new MemoryStream(arrpic);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static Image ShowImageToPicterBox(PictureBox picture)
        {
            try
            {
                OpenFileDialog openFileDialog_ = new OpenFileDialog();
                openFileDialog_.Title = "انتخاب تصویر";
                openFileDialog_.Filter =
                    "All Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff|" +
                    "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                    "PNG Files (*.png)|*.png|" +
                    "Bitmap Files (*.bmp)|*.bmp|" +
                    "TIFF Files (*.tif;*.tiff)|*.tif;*.tiff";
                openFileDialog_.FileName = "";

                if (openFileDialog_.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(openFileDialog_.FileName);
                }
                return null;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

    }

}
