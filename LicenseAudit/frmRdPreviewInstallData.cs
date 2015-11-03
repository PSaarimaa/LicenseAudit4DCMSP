using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseAudit
{
    public partial class frmRdPreviewInstallData : Form
    {
        public frmRdPreviewInstallData()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void LoadData(DataTable dtLicense)
        {
            DataView dvLicenses = new DataView();

            dvLicenses.Table = dtLicense;
            this.dgLicensesPreview.DataSource = dvLicenses;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
