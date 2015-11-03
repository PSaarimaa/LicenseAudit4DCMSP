using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ClosedXML.Excel;

namespace LicenseAudit
{
    public class Database
    {

        private string applicationName;
        private int connectionTimeout;
        private string databaseName;

        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        public int ConnectionTimeout
        {
            get { return this.connectionTimeout; }
            set { this.connectionTimeout = value; }
        }

        public string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings[this.databaseName].ToString();
                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder(connStr);

                // Override connection string application name and connection timeout if they have been set in the class
                stringBuilder.ApplicationName = this.applicationName ?? stringBuilder.ApplicationName;
                stringBuilder.ConnectTimeout = (this.connectionTimeout > 0) ? this.connectionTimeout : stringBuilder.ConnectTimeout;

                return stringBuilder.ToString();
            }
        }

        public Database(string dbName)
        {
            this.databaseName = dbName;
        }

        /// <summary>
        /// Opens a database connection and returns the connection object.
        /// </summary>
        /// <returns>Open database connection</returns>
        public SqlConnection GetSQLConnection()
        {
            SqlConnection conn = new SqlConnection(this.ConnectionString);
            conn.Open();
            return conn;
        }

        public void ExportDataSetToExcel(DataSet sourceDS, string pathToExcel)
        {
            XLWorkbook exportWB = new XLWorkbook();
            exportWB.Worksheets.Add(sourceDS);
            exportWB.SaveAs(pathToExcel);
        }

    }

}
