using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LicenseAudit
{
    public partial class frmRdImportLicenseData : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }
        private Database auditDB;
        private DataTable tbNewLicenses;
        private string newLicDataPath;

        private SqlConnection auditConn;

        private DataTable licensesDataTable;
        private DataSet licensesDataSet;
        private DataView licensesDataView;

        private string filterSoftware;
        private string filterEntity;

        public frmRdImportLicenseData()
        {
            InitializeComponent();
            this.licensesDataTable = new DataTable("LicensesData");
            this.licensesDataView = new DataView();
            this.licensesDataSet = new DataSet("LicensesData");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnSelectLicCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpenCSV = new OpenFileDialog();
            dialogOpenCSV.Filter = "CSV files (*.csv)|*.csv";
            dialogOpenCSV.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(dialogOpenCSV.ShowDialog() == DialogResult.OK)
            {
                StreamReader csvStream;

                try
                {
                    if(File.Exists(dialogOpenCSV.FileName))
                    {
                        using(csvStream = new StreamReader(dialogOpenCSV.FileName))
                        {
                            string newLine = csvStream.ReadLine();
                            if (newLine == "Name;# of Licenses;Entity;Software Item;Vendor")
                            {
                                this.newLicDataPath = dialogOpenCSV.FileName;
                                this.btnSelectLicCSV.Enabled = false;
                                this.btnPreview.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("File " + dialogOpenCSV.FileName + " is not a valid M-Files license export.");
                            }
                            
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void frmRdImportLicenseData_Load(object sender, EventArgs e)
        {
            this.btnPreview.Enabled = false;
            this.btnImport.Enabled = false;

            LoadLicenseDataView();
        }

        private void LoadLicenseDataView()
        {
            // Populate the license view
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand findLicenses = new SqlCommand("GetEntityLicensesWithNames", this.auditConn);
                findLicenses.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(findLicenses);
                adapter.Fill(this.licensesDataSet);
                this.licensesDataView.Table = this.licensesDataSet.Tables[0];
                this.dgLicenses.DataSource = this.licensesDataView;
                this.lblRowCount.Text = "Rows: " + this.licensesDataView.Count;
                this.dgLicenses.Columns["software_name"].Width = 300;
                this.dgLicenses.Columns["entity_name"].Width = 200;
                this.dgLicenses.ReadOnly = true;
                this.lblRowCount.Refresh();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.tbNewLicenses = CSVData.ReadCSVToDataTable(this.newLicDataPath);
            this.tbNewLicenses.TableName = "NewLicenses";
            frmRdPreviewInstallData frmPreview = new frmRdPreviewInstallData();
            frmPreview.LoadData(this.tbNewLicenses);
            frmPreview.Show();
            this.btnPreview.Enabled = false;
            this.btnImport.Enabled = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {

                // Set existing license counts to 0, otherwise subsequent license imports will keep incrementing license counts
                SqlCommand resetLicenseCounts = new SqlCommand("ResetLicenseCounts", this.auditConn);
                resetLicenseCounts.CommandType = CommandType.StoredProcedure;
                resetLicenseCounts.ExecuteNonQuery();

                DataTable tbSoftwareItems = new DataTable("SoftwareItems");
                SqlCommand selectItems = new SqlCommand("SelectAllSoftwareItems", this.auditConn);
                selectItems.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectItems);
                dataAdapter.Fill(tbSoftwareItems);

                // Add and update new licenses
                foreach (DataRow row in this.tbNewLicenses.Rows)
                {
                    SqlCommand insertLicense = new SqlCommand("UpdateLicense", this.auditConn);
                    insertLicense.CommandType = CommandType.StoredProcedure;

                    SqlParameter entityName = new SqlParameter("@entity_name", SqlDbType.NVarChar, 64);
                    entityName.Value = row["Entity"];
                    insertLicense.Parameters.Add(entityName);

                    SqlParameter softwareName = new SqlParameter("@software_name", SqlDbType.NVarChar, 250);
                    softwareName.Value = row["Software Item"];
                    insertLicense.Parameters.Add(softwareName);

                    SqlParameter licenseCount = new SqlParameter("@license_count", SqlDbType.Int);
                    licenseCount.Value = row["# of Licenses"];
                    insertLicense.Parameters.Add(licenseCount);

                    insertLicense.ExecuteNonQuery();
                }

                // Clean up the database of old licenses
                SqlCommand cleanupLicenses = new SqlCommand("CleanupEntityLicenses", this.auditConn);
                cleanupLicenses.CommandType = CommandType.StoredProcedure;
                cleanupLicenses.ExecuteNonQuery();
            }

            LoadLicenseDataView();

            this.btnImport.Enabled = false;
            this.btnSelectLicCSV.Enabled = true;
            MessageBox.Show("Licenses imported successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void UpdateLicenseView()
        {
            string rowFilter = "software_name LIKE '%" + this.filterSoftware + "%' AND entity_name LIKE '%" + this.filterEntity + "%'";
            this.licensesDataView.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.licensesDataView.Count;
            this.lblRowCount.Refresh();
        }

        private void textFilterSoftware_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textFilterSoftware.Text;
            UpdateLicenseView();
        }

        private void textFilterEntity_TextChanged(object sender, EventArgs e)
        {
            this.filterEntity = textFilterEntity.Text;
            UpdateLicenseView();
        }
    }
}
