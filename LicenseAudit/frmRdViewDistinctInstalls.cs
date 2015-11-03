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
    public partial class frmRdViewDistinctInstalls : Form
    {
        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private DataTable softwareDataTable;
        private DataView softwareDataView;
        private DataSet softwareDataSet;
        private SqlConnection auditConn;
        private Database auditDB;

        private string filterSoftware;

        private bool bDateFilter;
        private bool bShowHidden;
        private string dateFilter;
        private string filterStatus;


        public frmRdViewDistinctInstalls()
        {
            InitializeComponent();
            this.softwareDataTable = new DataTable("DistinctInstallData");
            this.softwareDataView = new DataView();
            this.softwareDataSet = new DataSet("DistinctInstallData");
            this.bDateFilter = false;
            this.filterSoftware = "";
        }

        private void frmRdViewDistinctSoftware_Load(object sender, EventArgs e)
        {
            RefreshDistinctSoftwareView();

            this.comboFilterSoftwareItem.SelectedItem = this.comboFilterSoftwareItem.Items[0];

            UpdateDistictSoftwareView();

        }


        private void RefreshDistinctSoftwareView()
        {
            this.softwareDataSet.Clear();
            this.softwareDataTable.Clear();

            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand findSoftware = new SqlCommand("GetInstalledItems", this.auditConn);
                findSoftware.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(findSoftware);
                adapter.Fill(this.softwareDataSet);
                this.softwareDataView.Table = this.softwareDataSet.Tables[0];
                this.dgDistinctSoftware.DataSource = this.softwareDataView;
                this.lblRowCount.Text = "Rows: " + this.softwareDataView.Count;
                this.dgDistinctSoftware.Columns["name"].Width = 300;
                this.dgDistinctSoftware.Columns["software_name"].Width = 300;
                this.dgDistinctSoftware.Sort(this.dgDistinctSoftware.Columns["name"], ListSortDirection.Ascending);
                this.lblRowCount.Refresh();
            }
        }

        private void UpdateDistictSoftwareView()
        {
            string rowFilter = "name LIKE '%" + this.filterSoftware + "%'";
            if(bDateFilter) rowFilter += "AND date_added = '" + this.dateFilter + "'";
            if (this.filterStatus != "")
                rowFilter += " AND " + this.filterStatus;
            if (this.bShowHidden == false)
            { rowFilter += " AND hidden = 'No'"; }
            this.softwareDataView.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.softwareDataView.Count;
            this.lblRowCount.Refresh();
        }

        private void textFilterName_TextChanged(object sender, EventArgs e)
        {
            this.filterSoftware = textFilterName.Text;
            UpdateDistictSoftwareView();
        }

        private void dtFilterDate_ValueChanged(object sender, EventArgs e)
        {
            this.dateFilter = dtFilterDate.Value.Day + "." + dtFilterDate.Value.Month + "." + dtFilterDate.Value.Year;
            UpdateDistictSoftwareView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbDateAll_CheckedChanged(object sender, EventArgs e)
        {
            this.dtFilterDate.Enabled = false;
            this.bDateFilter = false;
            UpdateDistictSoftwareView();
        }

        private void rbDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            this.dtFilterDate.Enabled = true;
            this.bDateFilter = true;
            this.dateFilter = dtFilterDate.Value.Day + "." + dtFilterDate.Value.Month + "." + dtFilterDate.Value.Year;
            UpdateDistictSoftwareView();
        }

        private void comboFilterSoftwareItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Indexes:
            // 0 - Show All
            // 1 - Show Only Installed Items without Software Items
            // 2 - Show Only Items with Software Items
            switch (comboFilterSoftwareItem.SelectedIndex)
            {
                case 0:
                    this.filterStatus = "";
                    break;
                case 1:
                    this.filterStatus = "software_name = ''";
                    break;
                case 2:
                    this.filterStatus = "software_name <> ''";
                    break;
            }

            UpdateDistictSoftwareView();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {

                foreach (DataGridViewCell cell in dgDistinctSoftware.SelectedCells)
                {
                    DataRow row = ((DataRowView)dgDistinctSoftware.Rows[cell.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                    if(row["software_name"].ToString() != "")
                    {
                        MessageBox.Show("Cannot hide a row with an assigned software item");
                        return;
                    }
                    SetHideStatus(row, 1);
                }
            }

            RefreshDistinctSoftwareView();
        }

        private void SetHideStatus(DataRow row, int hideStatus)
        {
            SqlCommand setHideStatus = new SqlCommand("SetInstalledItemsHide", this.auditConn);
            setHideStatus.CommandType = CommandType.StoredProcedure;
            SqlParameter p_itemID = new SqlParameter("@item_id", SqlDbType.Int);
            SqlParameter p_hideStatus = new SqlParameter("@hide_status", SqlDbType.Int);

            p_itemID.Value = row["id"];
            p_hideStatus.Value = hideStatus;

            setHideStatus.Parameters.Add(p_itemID);
            setHideStatus.Parameters.Add(p_hideStatus);

            setHideStatus.ExecuteNonQuery();
        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {

                foreach (DataGridViewCell cell in dgDistinctSoftware.SelectedCells)
                {
                    DataRow row = ((DataRowView)dgDistinctSoftware.Rows[cell.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                    SetHideStatus(row, 0);
                }
            }

            RefreshDistinctSoftwareView();
        }

        private void boxShowHidden_CheckedChanged(object sender, EventArgs e)
        {
            this.bShowHidden = boxShowHidden.Checked;
            UpdateDistictSoftwareView();
        }

        private void dgDistinctSoftware_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int installedItemID;
            string installedItemName;

            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                DataRow row = ((DataRowView)dgDistinctSoftware.Rows[e.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                installedItemID = Convert.ToInt32(row["id"]);
                installedItemName = row["software_name"].ToString();
            }

            frmRdViewComputersWithInstalledItem computerView = new frmRdViewComputersWithInstalledItem();
            computerView.AuditDB = this.auditDB;
            computerView.Text = "Computers with " + installedItemName + " installed";
            computerView.LoadComputers(installedItemID);
            computerView.Show();
        }

    }
}
