using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace MyClass
{
   static class  Save_File_InSql
    {
        public static byte[] OpenFile_ReadArray(int max_length, out string fileName)
        {
            
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = Directory.GetCurrentDirectory();
            byte[] fileData = null;
            fileName = "";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDlg.FileName);
                double mb = (fi.Length / 1024.0 / 1024.0);//مگابایت
                if (mb > max_length)
                {

                    MessageBox.Show("فایل انتخاب شده باید کمتر از " + max_length + " مگابایت باشد");
                    fileName = "";
                    return null;
                }
                FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BinaryReader rdr = new BinaryReader(fs);
                fileData = rdr.ReadBytes((int)fs.Length);
                rdr.Close();
                fs.Close();
                fileName = fi.Name;
            }
            return fileData;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________________________________________________________________________________
        public static void SaveFile_ReadArray(byte[] array, string masir)
        {
            FileStream fs = new FileStream(masir, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryWriter b = new BinaryWriter(fs);
            b.Write(array);
        }
    }
}
