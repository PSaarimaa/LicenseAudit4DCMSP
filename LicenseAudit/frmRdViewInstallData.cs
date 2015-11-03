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
    public partial class frmRdViewInstallData : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private DataTable installDataTable;
        private DataView installDataView;
        private DataSet installDataSet;
        private SqlConnection auditConn;
        private Database auditDB;

        private string filterEntity;
        private string filterSoftware;

        public frmRdViewInstallData()
        {
            InitializeComponent();
            this.installDataTable = new DataTable("InstallData");
            this.installDataView = new DataView();
            this.installDataSet = new DataSet("InstallData");

            this.filterSoftware = "";
            this.filterEntity = "";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmRdViewInstallData_Load(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand findSoftware = new SqlCommand("GetInstallData", this.auditConn);
                findSoftware.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(findSoftware);
                adapter.Fill(this.installDataSet);
                this.installDataView.Table = this.installDataSet.Tables[0];
                this.dgInstallData.DataSource = this.installDataView;
                this.dgInstallData.Columns["installed_name"].Width = 350;
                this.dgInstallData.Columns["entity_name"].Width = 200;
                this.dgInstallData.Columns["entity_name"].HeaderText = "Entity Name";
                this.dgInstallData.Columns["installed_name"].HeaderText = "Installed Software";
                this.dgInstallData.Columns["software_version"].HeaderText = "Version";
                this.dgInstallData.Columns["software_id"].Visible = false;
                this.lblRowCount.Text = "Rows: " + this.installDataView.Count;
                this.lblRowCount.Refresh();
            }
        }

        private void UpdateInstallDataView()
        {
            string rowFilter = "entity_name LIKE '%" + this.filterEntity + "%' AND installed_name LIKE '%" + this.filterSoftware +"%'";
            this.installDataView.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.installDataView.Count;
            this.lblRowCount.Refresh();
        }

        private void textEntity_TextChanged(object sender, EventArgs e)
        {
            this.filterEntity = textEntity.Text;
            UpdateInstallDataView();
        }

        private void textSoftware_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textSoftware.Text;
            UpdateInstallDataView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgInstallData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int installedItemID;
            string installedItemName;

            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                DataRow row = ((DataRowView)dgInstallData.Rows[e.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                installedItemID = Convert.ToInt32(row["software_id"]);
                installedItemName = row["installed_name"].ToString();
            }

            frmRdViewComputersWithInstalledItem computerView = new frmRdViewComputersWithInstalledItem();
            computerView.AuditDB = this.auditDB;
            computerView.Text = "Computers with " + installedItemName + " installed";
            computerView.LoadComputers(installedItemID);
            computerView.Show();
        }
    }
}
