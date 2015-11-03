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
    public partial class frmRdViewComputersWithInstalledItem : Form
    {

        public Database AuditDB
        {
            get { return this.auditDB; }
            set { this.auditDB = value; }
        }

        private Database auditDB;
        private SqlConnection auditConn;

        private DataTable computerDT;
        private DataSet computerDS;
        private DataView computerDV;

        private string filterEntity;

        public frmRdViewComputersWithInstalledItem()
        {
            InitializeComponent();
            this.computerDT = new DataTable("ComputersWithInstalledItem");
            this.computerDS = new DataSet("ComptutersWithInstalledItem");
            this.computerDV = new DataView();
        }

        public void LoadComputers(int software_id)
        {
            using(this.auditConn = this.auditDB.GetSQLConnection())
            {
                SqlCommand loadComputers = new SqlCommand("GetComputersWithInstalledItem", this.auditConn);
                loadComputers.CommandType = CommandType.StoredProcedure;

                SqlParameter p_softwareID = new SqlParameter("@item_id", SqlDbType.Int);
                p_softwareID.Value = software_id;
                loadComputers.Parameters.Add(p_softwareID);

                SqlDataAdapter adapter = new SqlDataAdapter(loadComputers);
                adapter.Fill(this.computerDS);
                this.computerDV.Table = this.computerDS.Tables[0];
                this.dgComputerList.DataSource = this.computerDV;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtFilterEntity_TextChanged(object sender, EventArgs e)
        {
            this.filterEntity = txtFilterEntity.Text;
        }
    }
}
