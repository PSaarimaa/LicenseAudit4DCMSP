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
    public partial class frmUpdateFromDC : Form
    {
        public frmUpdateFromDC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public Label LabelStatus
        {
            get { return this.lblStatus; }
            set { this.lblStatus = value; }
        }

        public Label LabelPhase
        {
            get { return this.lblPhase; }
            set { this.lblPhase = value; }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
