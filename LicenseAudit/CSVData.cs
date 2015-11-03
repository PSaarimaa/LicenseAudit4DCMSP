using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LicenseAudit
{
    public static class CSVData
    {

        public static string OpenCSV()
        {
            return OpenCSV(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public static string OpenCSV(string folder)
        {
            OpenFileDialog dialogOpenCSV = new OpenFileDialog();
            dialogOpenCSV.Filter = "CSV files (*.csv)|*.csv";
            dialogOpenCSV.InitialDirectory = folder;

            if (dialogOpenCSV.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialogOpenCSV.FileName))
                    return dialogOpenCSV.FileName;
                else return "";
            }
            else return "";
        }

        public static DataTable ReadCSVToDataTable(string path)
        {
            string[] Lines = File.ReadAllLines(path, Encoding.Default);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ';' });
            int Cols = Fields.GetLength(0);
            DataTable dt = new DataTable();
            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(new char[] { ';' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = Fields[f];
                dt.Rows.Add(Row);
            }

            return dt;

        }
    }
}
