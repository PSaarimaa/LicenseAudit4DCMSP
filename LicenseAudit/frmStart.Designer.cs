namespace LicenseAudit
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRDViewSoftware = new System.Windows.Forms.Button();
            this.btnRDviewMFiles = new System.Windows.Forms.Button();
            this.btnRDViewDistinct = new System.Windows.Forms.Button();
            this.btnRDviewDCentral = new System.Windows.Forms.Button();
            this.grpMaps = new System.Windows.Forms.GroupBox();
            this.btnMapInst = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.btnReportWithoutDowngrades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.grpMaps.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRDViewSoftware);
            this.groupBox1.Controls.Add(this.btnRDviewMFiles);
            this.groupBox1.Controls.Add(this.btnRDViewDistinct);
            this.groupBox1.Controls.Add(this.btnRDviewDCentral);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Data";
            // 
            // btRDViewSoftware
            // 
            this.btRDViewSoftware.Location = new System.Drawing.Point(225, 19);
            this.btRDViewSoftware.Name = "btRDViewSoftware";
            this.btRDViewSoftware.Size = new System.Drawing.Size(103, 55);
            this.btRDViewSoftware.TabIndex = 3;
            this.btRDViewSoftware.Text = "View and Import Software Items from CSV";
            this.btRDViewSoftware.UseVisualStyleBackColor = true;
            this.btRDViewSoftware.Click += new System.EventHandler(this.btRDViewSoftware_Click);
            // 
            // btnRDviewMFiles
            // 
            this.btnRDviewMFiles.Location = new System.Drawing.Point(334, 19);
            this.btnRDviewMFiles.Name = "btnRDviewMFiles";
            this.btnRDviewMFiles.Size = new System.Drawing.Size(103, 55);
            this.btnRDviewMFiles.TabIndex = 2;
            this.btnRDviewMFiles.Text = "View and Import License Data from CSV";
            this.btnRDviewMFiles.UseVisualStyleBackColor = true;
            this.btnRDviewMFiles.Click += new System.EventHandler(this.btnRDviewMFiles_Click);
            // 
            // btnRDViewDistinct
            // 
            this.btnRDViewDistinct.Location = new System.Drawing.Point(116, 20);
            this.btnRDViewDistinct.Name = "btnRDViewDistinct";
            this.btnRDViewDistinct.Size = new System.Drawing.Size(103, 55);
            this.btnRDViewDistinct.TabIndex = 1;
            this.btnRDViewDistinct.Text = "View Distinct Installed Items";
            this.btnRDViewDistinct.UseVisualStyleBackColor = true;
            this.btnRDViewDistinct.Click += new System.EventHandler(this.btnRDViewDistinct_Click);
            // 
            // btnRDviewDCentral
            // 
            this.btnRDviewDCentral.Location = new System.Drawing.Point(7, 20);
            this.btnRDviewDCentral.Name = "btnRDviewDCentral";
            this.btnRDviewDCentral.Size = new System.Drawing.Size(103, 55);
            this.btnRDviewDCentral.TabIndex = 0;
            this.btnRDviewDCentral.Text = "View Desktop Central Install Data";
            this.btnRDviewDCentral.UseVisualStyleBackColor = true;
            this.btnRDviewDCentral.Click += new System.EventHandler(this.btnRDviewDCentral_Click);
            // 
            // grpMaps
            // 
            this.grpMaps.Controls.Add(this.btnMapInst);
            this.grpMaps.Location = new System.Drawing.Point(13, 100);
            this.grpMaps.Name = "grpMaps";
            this.grpMaps.Size = new System.Drawing.Size(444, 85);
            this.grpMaps.TabIndex = 1;
            this.grpMaps.TabStop = false;
            this.grpMaps.Text = "Edit Mappings";
            // 
            // btnMapInst
            // 
            this.btnMapInst.Location = new System.Drawing.Point(7, 19);
            this.btnMapInst.Name = "btnMapInst";
            this.btnMapInst.Size = new System.Drawing.Size(103, 55);
            this.btnMapInst.TabIndex = 4;
            this.btnMapInst.Text = "Map Installed Items to Software Items";
            this.btnMapInst.UseVisualStyleBackColor = true;
            this.btnMapInst.Click += new System.EventHandler(this.btnMapInst_Click);
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.btnReportWithoutDowngrades);
            this.grpReports.Location = new System.Drawing.Point(12, 191);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(445, 91);
            this.grpReports.TabIndex = 2;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // btnReportWithoutDowngrades
            // 
            this.btnReportWithoutDowngrades.Location = new System.Drawing.Point(8, 19);
            this.btnReportWithoutDowngrades.Name = "btnReportWithoutDowngrades";
            this.btnReportWithoutDowngrades.Size = new System.Drawing.Size(103, 55);
            this.btnReportWithoutDowngrades.TabIndex = 5;
            this.btnReportWithoutDowngrades.Text = "Report License Status without Down/Upgrades";
            this.btnReportWithoutDowngrades.UseVisualStyleBackColor = true;
            this.btnReportWithoutDowngrades.Click += new System.EventHandler(this.btnReportWithoutDowngrades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(C) Fläkt Woods Group 2015, Pekka Saarimaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Licensed under MIT license:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(160, 306);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://opensource.org/licenses/MIT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.grpMaps);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStart";
            this.Text = "Desktop Central MSP License Audit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStart_FormClosed);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpMaps.ResumeLayout(false);
            this.grpReports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRDviewMFiles;
        private System.Windows.Forms.Button btnRDViewDistinct;
        private System.Windows.Forms.Button btnRDviewDCentral;
        private System.Windows.Forms.Button btRDViewSoftware;
        private System.Windows.Forms.GroupBox grpMaps;
        private System.Windows.Forms.Button btnMapInst;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.Button btnReportWithoutDowngrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}