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
    public partial class frmMapAddInstalledItem : Form
    {
        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        public int Software_id;

        private Database auditDB;
        private SqlConnection auditConn;

        private DataTable installedItemsDT;
        private DataView installedItemsDV;
        private DataSet installedItemsDS;

        public frmMapAddInstalledItem()
        {
            this.installedItemsDS = new DataSet("AddInstalledItems");
            this.installedItemsDT = new DataTable("AddInstalledItems");
            this.installedItemsDV = new DataView();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMapAddInstalledItem_Load(object sender, EventArgs e)
        {
            // Populate the datatable with all possible installed items that can be added to a software
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand findInstalledItems = new SqlCommand("GetUnassigedInstalledItems", this.auditConn);
                findInstalledItems.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(findInstalledItems);
                adapter.Fill(this.installedItemsDS);
                this.installedItemsDV.Table = this.installedItemsDS.Tables[0];
                this.dgInstalledItems.DataSource = this.installedItemsDV;
                this.dgInstalledItems.Columns["id"].Visible = false;
                this.dgInstalledItems.Columns["name"].Width = 400;
                this.lblRowCount.Text = "Rows: " + this.installedItemsDV.Count;
                this.dgInstalledItems.ReadOnly = true;
                this.lblRowCount.Refresh();
            }
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = "name LIKE '%" + this.textFilter.Text + "%'";
            this.installedItemsDV.RowFilter = rowFilter;
            this.lblRowCount.Text = "Rows: " + this.installedItemsDV.Count;
            this.lblRowCount.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {

                foreach (DataGridViewCell cell in dgInstalledItems.SelectedCells)
                {
                    DataRow row = ((DataRowView)dgInstalledItems.Rows[cell.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                    MapSelectedRow(row);
                }
            }

            CloseFormAndUpdateParent();
        }

        private void dgInstalledItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (this.auditConn = this.auditDB.GetSQLConnection())
            {
                DataRow row = ((DataRowView)dgInstalledItems.Rows[e.RowIndex].DataBoundItem).Row;   //Get datarow from the datagridcell
                MapSelectedRow(row);
            }

            CloseFormAndUpdateParent();
        }

        private void MapSelectedRow(DataRow row)
        {
            SqlCommand addInstMapping = new SqlCommand("AddInstMapping", this.auditConn);
            addInstMapping.CommandType = CommandType.StoredProcedure;
            SqlParameter softwareParam = new SqlParameter("@software_item", SqlDbType.Int);
            softwareParam.Value = this.Software_id;
            addInstMapping.Parameters.Add(softwareParam);
            SqlParameter installedParam = new SqlParameter("@installed_item", SqlDbType.Int);
            installedParam.Value = row["id"];
            addInstMapping.Parameters.Add(installedParam);
            addInstMapping.ExecuteNonQuery();
        }

        private void CloseFormAndUpdateParent()
        {
            frmMapInstToSoftware parent = (frmMapInstToSoftware)this.Owner;
            parent.UpdateInstalledItemsList(this.Software_id);
            parent.UpdateSoftwareItemList();
            this.Close();
        }
    }

}
