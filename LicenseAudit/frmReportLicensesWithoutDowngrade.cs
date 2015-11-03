using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LicenseAudit
{
    public partial class frmReportLicensesWithoutDowngrade : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private DataTable reportDataTable;
        private DataView reportDataView;
        private DataSet reportDataSet;
        private SqlConnection auditConn;
        private Database auditDB;

        private string filterEntity;
        private string filterSoftware;

        public frmReportLicensesWithoutDowngrade()
        {
            this.reportDataSet = new DataSet("reportWithoutDowngrades");
            this.reportDataTable = new DataTable("reportWithoutDowngrades");
            this.reportDataView = new DataView();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportLicensesWithoutDowngrade_Load(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand findLicenseStatus = new SqlCommand("GetLicenseReportWithoutDowngrades", this.auditConn);
                findLicenseStatus.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(findLicenseStatus);
                adapter.Fill(this.reportDataSet);
                this.reportDataView.Table = this.reportDataSet.Tables[0];
                this.dgReportView.DataSource = this.reportDataView;
                this.dgReportView.Columns["entity_name"].Width = 200;
                this.dgReportView.Columns["software_name"].Width = 300;
                this.lblRowCount.Text = "Rows: " + this.reportDataView.Count;
                this.dgReportView.Columns["entity_id"].Visible = false;
                this.dgReportView.Columns["software_id"].Visible = false;
                this.lblRowCount.Refresh();
            }
        }

        private void UpdateLicenseDataView()
        {
            string rowFilter = "entity_name LIKE '%" + this.filterEntity + "%' AND software_name LIKE '%" + this.filterSoftware + "%'";
            this.reportDataView.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.reportDataView.Count;
            this.lblRowCount.Refresh();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveExcel = new SaveFileDialog();
            saveExcel.Filter = "Excel Workbook (*.xslx)|*.xlsx";
            saveExcel.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(saveExcel.ShowDialog() == DialogResult.OK)
            {
                DataSet exportDS = new DataSet("Export");
                DataTable exportDT = this.reportDataView.ToTable();
                if (exportDT != null & exportDT.Rows.Count > 0)
                {
                    exportDS.Tables.Add(exportDT);
                    this.auditDB.ExportDataSetToExcel(exportDS, saveExcel.FileName);
                }
                else MessageBox.Show("No rows to export!");
            }

            MessageBox.Show("Exported " + this.reportDataView.ToTable().Rows.Count + " rows to Excel.");
        }

        private void textFilterEntity_TextChanged(object sender, EventArgs e)
        {
            this.filterEntity = textFilterEntity.Text;
            UpdateLicenseDataView();
        }

        private void textFilterSoftware_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textFilterSoftware.Text;
            UpdateLicenseDataView();
        }
    }
}
