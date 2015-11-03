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
    public partial class frmMapInstToSoftware : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private Database auditDB;
        private SqlConnection auditConn;

        private DataTable softwareItemsDT;
        private DataView softwareItemsDV;
        private DataSet softwareItemsDS;

        private DataTable installedItemsDT;
        private DataView installedItemsDV;
        private DataSet installedItemsDS;

        private int software_id;

        private string filterSoftware;
        private string filterStatus;

        public frmMapInstToSoftware()
        {
            this.softwareItemsDS = new DataSet("MapInstSoftwareItems");
            this.softwareItemsDV = new DataView();
            this.softwareItemsDT = new DataTable("MapInstSoftwareItems");
            this.installedItemsDS = new DataSet("MapInstInstalledItems");
            this.installedItemsDV = new DataView();
            this.installedItemsDT = new DataTable("MapInstInstalledItems");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmMapInstToSoftware_Load(object sender, EventArgs e)
        {

            this.btnAddItem.Enabled = false;
            this.btnRemove.Enabled = false;

            UpdateSoftwareItemList();

            // Set the default filter selection to "Show All"
            this.comboFilterSoftware.SelectedItem = this.comboFilterSoftware.Items[0];
        }

        public void UpdateSoftwareItemList()
        {
            this.softwareItemsDT.Clear();
            this.softwareItemsDS.Clear();
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand listSoftwareItems = new SqlCommand("GetSoftwareItemsWithInstCount", this.auditConn);
                listSoftwareItems.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(listSoftwareItems);
                adapter.Fill(this.softwareItemsDS);
                this.softwareItemsDV.Table = this.softwareItemsDS.Tables[0];
                this.dgSoftwareItems.DataSource = this.softwareItemsDV;
                this.dgSoftwareItems.Columns["id"].Visible = false;
                this.dgSoftwareItems.Columns["Name"].Width = 200;
                this.dgSoftwareItems.Columns["Count"].Width = 30;
                this.dgSoftwareItems.Sort(this.dgSoftwareItems.Columns["Name"], ListSortDirection.Ascending);
                this.dgSoftwareItems.ReadOnly = true;
            }
        }

        private void comboFilterSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddItem.Enabled = false;
            this.btnRemove.Enabled = false;

            // Indexes:
            // 0 - Show All
            // 1 - Show Only Software Items without Installed Items
            // 2 - Show Only Software Items with Installed Items
            switch (comboFilterSoftware.SelectedIndex)
            {
                case 0:
                    this.filterStatus = "";
                    break;
                case 1:
                    this.filterStatus = "count = 0";
                    break;
                case 2:
                    this.filterStatus = "count > 0";
                    break;
            }

            RefreshSoftwareList();
        }

        private void RefreshSoftwareList()
        {
            string rowFilter = "name LIKE '%" + this.filterSoftware + "%'";
            if (this.filterStatus != "")
                rowFilter += " AND " + this.filterStatus;
            this.softwareItemsDV.RowFilter = rowFilter;
        }

        private void dgSoftwareItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.software_id = (int)dgSoftwareItems.Rows[e.RowIndex].Cells["id"].Value;
            UpdateInstalledItemsList(this.software_id);
            this.btnAddItem.Enabled = true;
            this.btnRemove.Enabled = false;
            this.grpInstalledItems.Text = "Installed items for " + dgSoftwareItems.Rows[e.RowIndex].Cells["name"].Value.ToString();
        }

        public void UpdateInstalledItemsList(int software_id)
        {
            this.installedItemsDS.Clear();
            this.installedItemsDT.Clear();

            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand listInstalledItems = new SqlCommand("GetMappedInstallItems", this.auditConn);
                SqlParameter SoftwareParam = new SqlParameter("@software_id", SqlDbType.Int);
                SoftwareParam.Value = software_id;
                listInstalledItems.Parameters.Add(SoftwareParam);
                listInstalledItems.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(listInstalledItems);
                adapter.Fill(this.installedItemsDS);
                this.installedItemsDV.Table = this.installedItemsDS.Tables[0];
                this.dgInstalledItems.DataSource = this.installedItemsDV;
                this.dgInstalledItems.Columns["id"].Visible = false;
                this.dgInstalledItems.Columns["name"].Width = 300;
                this.dgInstalledItems.ReadOnly = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmMapAddInstalledItem frmAddItems = new frmMapAddInstalledItem();
            frmAddItems.AuditDB = this.auditDB;
            frmAddItems.Owner = this;
            frmAddItems.Software_id = this.software_id;
            frmAddItems.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgInstalledItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                foreach (DataGridViewCell cell in dgInstalledItems.SelectedCells)
                {
                    DataRow row = ((DataRowView)dgInstalledItems.Rows[cell.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                    SqlCommand addInstMapping = new SqlCommand("DeleteMappedInstallItem", this.auditConn);
                    addInstMapping.CommandType = CommandType.StoredProcedure;
                    SqlParameter softwareParam = new SqlParameter("@software_id", SqlDbType.Int);
                    softwareParam.Value = this.software_id;
                    addInstMapping.Parameters.Add(softwareParam);
                    SqlParameter installedParam = new SqlParameter("@installed_id", SqlDbType.Int);
                    installedParam.Value = row["id"];
                    addInstMapping.Parameters.Add(installedParam);
                    addInstMapping.ExecuteNonQuery();
                }
            }

            UpdateInstalledItemsList(this.software_id);
            UpdateSoftwareItemList();
        }

        private void textSoftwareFilter_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textSoftwareFilter.Text;
            RefreshSoftwareList();
        }
    }
}
