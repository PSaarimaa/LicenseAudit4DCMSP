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
    public partial class frmStart : Form
    {

        private Database dcentralDB;
        private Database auditDB;

        private SqlConnection dcentralConn;
        private SqlConnection auditConn;

        public frmStart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            // Prepare the database connections (but do not open them)
            this.dcentralDB = new Database("DCentralDB");
            this.dcentralDB.ApplicationName = "License Audit";
            this.auditDB = new Database("LicAuditDB");
            this.auditDB.ApplicationName = "License Audit";

            DialogResult update;
            update = MessageBox.Show("Update install data from Desktop Central?\nThis will take a few minutes." , "Database update", MessageBoxButtons.YesNo);

            if (update == DialogResult.Yes)
            {

                frmUpdateFromDC frmUpd = new frmUpdateFromDC();
                frmUpd.Show();
                //frmUpd.LabelStatus.Text = "";
                frmUpd.LabelStatus.Visible = true;

                try
                {

                    using (this.dcentralConn = this.dcentralDB.GetSQLConnection())
                    {
                        string selectCommand = "select customer_name as entity_name ,software_name, software_version, manufacturer_name, resource.name as computer_name,domain_netbios_name as domain_name from invcomputer inner join resource on resource.resource_id=invcomputer.computeR_Id inner join invcomponent on invcomponent.computer_id=resource.resource_id inner join invswinstalled on invswinstalled.component_id=invcomponent.component_id inner join invsw on invsw.software_id=invswinstalled.software_id inner join customerinfo on customerinfo.customer_id=resource.customer_id inner join invmanufacturer on invmanufacturer.manufacturer_id=invsw.manufacturer_id where manufacturer_name like '%Microsoft%' or manufacturer_name like '%Adobe%'";

                        frmUpd.LabelPhase.Text = "Phase 1/4 (Importing computer data from Desktop Central):";
                        frmUpd.LabelPhase.Refresh();
                        frmUpd.LabelStatus.Text = "Counting items to import...";
                        frmUpd.LabelStatus.Refresh();
                        SqlCommand getRows = new SqlCommand(selectCommand, this.dcentralConn);
                        int totalRows = 0;

                        using (SqlDataReader counter = getRows.ExecuteReader())
                        {
                            while (counter.Read())
                            { totalRows++; }
                        }

                        // Load data from Desktop Central
                        SqlCommand selectCmd = new SqlCommand(selectCommand, this.dcentralConn);
                        SqlDataReader reader = selectCmd.ExecuteReader();

                        // Write data into local dcInstallDataPerComputer table
                        using (this.auditConn = this.auditDB.GetSQLConnection())
                        {

                            // Create the dcInstallDataPerComputer table. This table will be populated with the
                            // installation data from Desktop Central.
                            SqlCommand clearTable = new SqlCommand("CreateDcInstallDataPerComputerTable", this.auditConn);
                            clearTable.CommandType = CommandType.StoredProcedure;
                            clearTable.ExecuteNonQuery();

                            int currentRow = 0;

                            // Populate the dcInstallDataPerComputer table with data loaded from Desktop Central
                            // This takes a LONG time (easily over 10 minutes)
                            while (reader.Read())
                            {
                                string entity = reader.GetString(0);
                                string software = reader.GetString(1);
                                string version = reader.GetString(2);
                                string manufacturer = reader.GetString(3);
                                string computer_name = reader.GetString(4);
                                string domain_name = reader.GetString(5);

                                SqlCommand insertCmd = new SqlCommand("INSERT INTO dcInstallDataPerComputer (entity_name,software_name,software_version,manufacturer_name,computer_name,domain_name) VALUES (@entity,@software,@version,@manufacturer,@computer_name,@domain_name)", this.auditConn);
                                SqlParameter p_entity = new SqlParameter("@entity", SqlDbType.NVarChar, 100);
                                SqlParameter p_software = new SqlParameter("@software", SqlDbType.NVarChar, 250);
                                SqlParameter p_version = new SqlParameter("@version", SqlDbType.NVarChar, 100);
                                SqlParameter p_manufacturer = new SqlParameter("@manufacturer", SqlDbType.NVarChar, 100);
                                SqlParameter p_computername = new SqlParameter("@computer_name", SqlDbType.NVarChar, 100);
                                SqlParameter p_domainname = new SqlParameter("@domain_name", SqlDbType.NVarChar, 50);

                                p_entity.Value = entity;
                                p_software.Value = software;
                                p_version.Value = version;
                                p_manufacturer.Value = manufacturer;
                                p_computername.Value = computer_name;
                                p_domainname.Value = domain_name;

                                insertCmd.Parameters.Add(p_entity);
                                insertCmd.Parameters.Add(p_software);
                                insertCmd.Parameters.Add(p_version);
                                insertCmd.Parameters.Add(p_manufacturer);
                                insertCmd.Parameters.Add(p_computername);
                                insertCmd.Parameters.Add(p_domainname);

                                insertCmd.ExecuteNonQuery();
                                currentRow++;

                                frmUpd.LabelStatus.Text = "Importing Row " + currentRow + "/" + totalRows;
                                frmUpd.LabelStatus.Refresh();

                            }
                        }

                        reader.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                try
                {

                    // Add items to the table of unique installed items from dcInstallData
                    using (this.auditConn = this.auditDB.GetSQLConnection())
                    {

                        // First read all unique installed items in dcInstallData table (SELECT DISTINCT)
                        DataTable tbInstalledItems = new DataTable("InstalledItems");
                        SqlCommand distictSel = new SqlCommand("SelectDistinctInstalledItems", this.auditConn);
                        distictSel.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(distictSel);
                        dataAdapter.Fill(tbInstalledItems);

                        int totalRows = tbInstalledItems.Rows.Count;
                        int currentRow = 0;
                        int addedCount = 0;

                        frmUpd.LabelPhase.Text = "Phase 2/4 (Adding new installed items):";
                        frmUpd.LabelPhase.Refresh();

                        frmUpd.LabelStatus.Text = "Processed Row 0/" + totalRows + ", added 0";
                        frmUpd.LabelStatus.Refresh();

                        // Iterate the unique items in dcInstallData and add those intems to installedItems table if they did not exist there before
                        foreach (DataRow row in tbInstalledItems.Rows)
                        {
                            // Try to find the unique item from installedItems
                            string software_name = row["software_name"].ToString();
                            SqlCommand findItem = new SqlCommand("SELECT name FROM installedItems WHERE name = @name", this.auditConn);
                            SqlParameter itemName = new SqlParameter("@name", SqlDbType.NVarChar, 250);
                            itemName.Value = software_name;
                            findItem.Parameters.Add(itemName);
                            currentRow++;

                            string findName = null;
                            findName = (string)findItem.ExecuteScalar();

                            // Add a new row to installedItems only if one did not exist before
                            if (findName == null)
                            {
                                SqlCommand insertItem = new SqlCommand("InsertIntoInstalledItems", this.auditConn);
                                insertItem.CommandType = CommandType.StoredProcedure;
                                SqlParameter installName = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
                                installName.Value = software_name;
                                insertItem.Parameters.Add(installName);
                                insertItem.ExecuteNonQuery();

                                addedCount++;
                            }

                            frmUpd.LabelStatus.Text = "Processed Row " + currentRow + "/" + totalRows + ", added " + addedCount;
                            frmUpd.LabelStatus.Refresh();

                        }

                        string textFinal = "";
                        string captionFinal = "";
                        if (addedCount > 0)
                        {
                            captionFinal = "Added new software items";
                            textFinal = "Added " + addedCount + " new software items. Go to 'Manage tracked items' and filter based on date to find them.";
                        }
                        else
                        {
                            captionFinal = "No new software items added";
                            textFinal = "The import did not detect newly installed software items since last update.";
                        }
                        MessageBox.Show(textFinal, captionFinal, MessageBoxButtons.OK);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                try
                {

                    // Add any new companies to the companies table (SELECT DISTINCT from dcInstallData)
                    using (this.auditConn = this.auditDB.GetSQLConnection())
                    {
                        DataTable tbCompanies = new DataTable("Companies");
                        SqlCommand distinctSel = new SqlCommand("SelectDistinctCompany", this.auditConn);
                        distinctSel.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(distinctSel);
                        dataAdapter.Fill(tbCompanies);

                        int totalRows = tbCompanies.Rows.Count;
                        int currentRow = 0;
                        int addedCount = 0;

                        frmUpd.LabelPhase.Text = "Phase 3/4 (Adding new companies):";
                        frmUpd.LabelPhase.Refresh();

                        frmUpd.LabelStatus.Text = "Processed Row 0/" + totalRows + ", added 0";
                        frmUpd.LabelStatus.Refresh();

                        // Iterate unique entities in dcInstallData and add those entities to fwEntities table if they did not exist there before
                        foreach (DataRow row in tbCompanies.Rows)
                        {
                            string entity_name = row["entity_name"].ToString();
                            SqlCommand findItem = new SqlCommand("SELECT name FROM fwEntities WHERE name = @name", this.auditConn);
                            SqlParameter itemName = new SqlParameter("@name", SqlDbType.NVarChar, 64);
                            itemName.Value = entity_name;
                            findItem.Parameters.Add(itemName);
                            currentRow++;

                            string findName = null;
                            findName = (string)findItem.ExecuteScalar();

                            // Add a new row only if one did not exist before
                            if (findName == null)
                            {
                                SqlCommand insertItem = new SqlCommand("InsertIntoEntities", this.auditConn);
                                insertItem.CommandType = CommandType.StoredProcedure;
                                SqlParameter entityName = new SqlParameter("@Name", SqlDbType.NVarChar, 64);
                                entityName.Value = entity_name;
                                insertItem.Parameters.Add(entityName);
                                insertItem.ExecuteNonQuery();

                                addedCount++;
                            }

                            frmUpd.LabelStatus.Text = "Processed Row " + currentRow + "/" + totalRows + ", added " + addedCount;
                            frmUpd.LabelStatus.Refresh();
                        }

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                try
                {
                    // Add new computers to the computers table
                    using (this.auditConn = this.auditDB.GetSQLConnection())
                    {
                        DataTable tblComputers = new DataTable("Computers");
                        SqlCommand selDistinctComp = new SqlCommand("GetDistinctComputers", this.auditConn);
                        selDistinctComp.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(selDistinctComp);
                        dataAdapter.Fill(tblComputers);

                        int totalRows = tblComputers.Rows.Count;
                        int currentRow = 0;
                        int addedCount = 0;

                        frmUpd.LabelPhase.Text = "Phase 4/4 (Adding new computers):";
                        frmUpd.LabelPhase.Refresh();

                        frmUpd.LabelStatus.Text = "Processed Row 0/" + totalRows + ", added 0";
                        frmUpd.LabelStatus.Refresh();

                        foreach (DataRow row in tblComputers.Rows)
                        {
                            string computer_name = row["computer_name"].ToString();
                            string domain_name = row["domain_name"].ToString();
                            SqlCommand findItem = new SqlCommand("SELECT name FROM computers WHERE name = @name AND domain = @domain", this.auditConn);
                            SqlParameter itemName = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                            itemName.Value = computer_name;
                            findItem.Parameters.Add(itemName);
                            SqlParameter domainName = new SqlParameter("@domain", SqlDbType.NVarChar, 50);
                            domainName.Value = domain_name;
                            findItem.Parameters.Add(domainName);
                            currentRow++;

                            string findName = null;
                            findName = (string)findItem.ExecuteScalar();

                            // Add a new row only if one did not exist before
                            if (findName == null)
                            {
                                SqlCommand insertItem = new SqlCommand("InsertIntoComputers", this.auditConn);
                                insertItem.CommandType = CommandType.StoredProcedure;
                                SqlParameter computerName = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                                computerName.Value = computer_name;
                                insertItem.Parameters.Add(computerName);
                                SqlParameter domName = new SqlParameter("@Domain", SqlDbType.NVarChar, 50);
                                domName.Value = domain_name;
                                insertItem.Parameters.Add(domName);
                                insertItem.ExecuteNonQuery();

                                addedCount++;
                            }

                            frmUpd.LabelStatus.Text = "Processed Row " + currentRow + "/" + totalRows + ", added " + addedCount;
                            frmUpd.LabelStatus.Refresh();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                try
                {

                    // Create a table with values for Software Item and Entity referencing to their respective tables
                    using (this.auditConn = this.auditDB.GetSQLConnection())
                    {
                        SqlCommand clearTable = new SqlCommand("CreateInstallDataPerComputer", this.auditConn);
                        clearTable.CommandType = CommandType.StoredProcedure;
                        clearTable.ExecuteNonQuery();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                frmUpd.Hide();

            }
        }

        /*
            Code for opening subforms from the main form
        */

        private void btnRDviewDCentral_Click(object sender, EventArgs e)
        {
            frmRdViewInstallData frmInstallDataView = new frmRdViewInstallData();
            frmInstallDataView.AuditDB = this.auditDB;
            frmInstallDataView.Show();
        }

        private void btnRDViewDistinct_Click(object sender, EventArgs e)
        {
            frmRdViewDistinctInstalls frmDistictSoftware = new frmRdViewDistinctInstalls();
            frmDistictSoftware.AuditDB = this.auditDB;
            frmDistictSoftware.Show();
        }

        private void btnRDviewMFiles_Click(object sender, EventArgs e)
        {
            frmRdImportLicenseData frmLicData = new frmRdImportLicenseData();
            frmLicData.AuditDB = this.auditDB;
            frmLicData.Show();
        }

        private void btRDViewSoftware_Click(object sender, EventArgs e)
        {
            frmRdViewSoftwareItems frmSoftwareItems = new frmRdViewSoftwareItems();
            frmSoftwareItems.AuditDB = this.auditDB;
            frmSoftwareItems.Show();
        }

        private void btnMapInst_Click(object sender, EventArgs e)
        {
            frmMapInstToSoftware frmMapSoftwareInst = new frmMapInstToSoftware();
            frmMapSoftwareInst.AuditDB = this.auditDB;
            frmMapSoftwareInst.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void frmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReportWithoutDowngrades_Click(object sender, EventArgs e)
        {
            frmReportLicensesWithoutDowngrade frmReportLicWODowngrade = new frmReportLicensesWithoutDowngrade();
            frmReportLicWODowngrade.AuditDB = this.auditDB;
            frmReportLicWODowngrade.Show();
        }
    }
}
