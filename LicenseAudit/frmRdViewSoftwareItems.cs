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
    public partial class frmRdViewSoftwareItems : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private Database auditDB;
        private SqlConnection auditConn;

        private DataTable softwareDataTable;
        private DataSet softwareDataSet;
        private DataView softwareDataView;

        private string filterSoftware;

        public frmRdViewSoftwareItems()
        {
            this.softwareDataTable = new DataTable("SoftwareData");
            this.softwareDataView = new DataView();
            this.softwareDataSet = new DataSet("SoftwareData");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string csvPath = CSVData.OpenCSV();
            if (csvPath != "")
            {
                try
                {
                    using(this.auditConn = this.AuditDB.GetSQLConnection())
                    {
                        int addedRows = 0;

                        DataTable importDt = CSVData.ReadCSVToDataTable(csvPath);
                        foreach (DataRow row in importDt.Rows)
                        {
                            // Prepare the SQL query
                            string software_name = row["Name"].ToString();
                            SqlCommand findItem = new SqlCommand("GetSoftwareItem", this.auditConn);
                            findItem.CommandType = CommandType.StoredProcedure;
                            SqlParameter itemName = new SqlParameter("@name", SqlDbType.NVarChar, 250);
                            itemName.Value = software_name;
                            findItem.Parameters.Add(itemName);

                            // Execute the query to find if a software already existed in the list
                            string findName = null;
                            findName = Convert.ToString(findItem.ExecuteScalar());

                            // Add a new row only if one did not exist before
                            if (findName == "")
                            {
                                SqlCommand insertItem = new SqlCommand("InsertIntoSoftwareItems", this.auditConn);
                                insertItem.CommandType = CommandType.StoredProcedure;
                                SqlParameter softwareName = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
                                softwareName.Value = software_name;
                                insertItem.Parameters.Add(softwareName);
                                SqlParameter vendorName = new SqlParameter("@Vendor", SqlDbType.NVarChar, 100);
                                vendorName.Value = row["Vendor"].ToString();
                                insertItem.Parameters.Add(vendorName);
                                insertItem.ExecuteNonQuery();

                                addedRows++;
                            }

                        }

                        if (addedRows > 0) MessageBox.Show(addedRows + " new software items added", "New items");
                        else MessageBox.Show("No new software items added", "No items added");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Could not parse M-Files CSV export");
                }
            }
            else MessageBox.Show("Error in opening M-Files CSV export!");
        }

        private void frmRdViewSoftwareItems_Load(object sender, EventArgs e)
        {
            this.filterSoftware = "";

            LoadSoftwareItems();
        }

        private void LoadSoftwareItems()
        {
            this.softwareDataSet.Clear();
            this.softwareDataTable.Clear();

            try
            {
                using (this.auditConn = this.AuditDB.GetSQLConnection())
                {
                    SqlCommand findSoftware = new SqlCommand("GetSoftwareItems", this.auditConn);
                    findSoftware.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(findSoftware);
                    adapter.Fill(this.softwareDataSet);
                    this.softwareDataView.Table = this.softwareDataSet.Tables[0];
                    this.dgSoftwareItems.DataSource = this.softwareDataView;
                    this.dgSoftwareItems.Columns["name"].Width = 300;
                    this.dgSoftwareItems.ReadOnly = true;
                    UpdateDistictSoftwareView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDistictSoftwareView()
        {
            string rowFilter = "name LIKE '%" + this.filterSoftware + "%'";
            this.softwareDataView.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.softwareDataView.Count;
            this.lblRowCount.Refresh();
        }

        private void textFilterName_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textFilterName.Text;
            UpdateDistictSoftwareView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {

                foreach (DataGridViewCell cell in dgSoftwareItems.SelectedCells)
                {
                    DataRow row = ((DataRowView)dgSoftwareItems.Rows[cell.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                    SqlCommand listInstalledItems = new SqlCommand("GetMappedInstallItems", this.auditConn);
                    SqlParameter SoftwareParam = new SqlParameter("@software_id", SqlDbType.Int);
                    SoftwareParam.Value = row["id"];
                    listInstalledItems.Parameters.Add(SoftwareParam);
                    listInstalledItems.CommandType = CommandType.StoredProcedure;
                    object mappedItem = listInstalledItems.ExecuteScalar();

                    if(mappedItem == null)
                    {
                        SqlCommand deleteSoftwareItem = new SqlCommand("DeleteSoftwareItem", this.auditConn);
                        SqlParameter software_id = new SqlParameter("@software_id", SqlDbType.Int);
                        deleteSoftwareItem.CommandType = CommandType.StoredProcedure;
                        software_id.Value = row["id"];
                        deleteSoftwareItem.Parameters.Add(software_id);
                        deleteSoftwareItem.ExecuteNonQuery();
                        LoadSoftwareItems();
                    } else
                    {
                        MessageBox.Show(row["name"] + " has one or more mapped install items. Cannot delete.");
                    }
                }
            }
        }
    }
}
