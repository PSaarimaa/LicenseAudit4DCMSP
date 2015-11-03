namespace LicenseAudit
{
    partial class frmRdImportLicenseData
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
            this.grpImport = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSelectLicCSV = new System.Windows.Forms.Button();
            this.dgLicenses = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblFilterSoftware = new System.Windows.Forms.Label();
            this.textFilterSoftware = new System.Windows.Forms.TextBox();
            this.lblFilterEntity = new System.Windows.Forms.Label();
            this.textFilterEntity = new System.Windows.Forms.TextBox();
            this.grpImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLicenses)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpImport
            // 
            this.grpImport.Controls.Add(this.btnImport);
            this.grpImport.Controls.Add(this.btnPreview);
            this.grpImport.Controls.Add(this.btnSelectLicCSV);
            this.grpImport.Location = new System.Drawing.Point(12, 12);
            this.grpImport.Name = "grpImport";
            this.grpImport.Size = new System.Drawing.Size(119, 107);
            this.grpImport.TabIndex = 0;
            this.grpImport.TabStop = false;
            this.grpImport.Text = "Import Licenses";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 77);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(6, 48);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSelectLicCSV
            // 
            this.btnSelectLicCSV.Location = new System.Drawing.Point(6, 19);
            this.btnSelectLicCSV.Name = "btnSelectLicCSV";
            this.btnSelectLicCSV.Size = new System.Drawing.Size(101, 23);
            this.btnSelectLicCSV.TabIndex = 0;
            this.btnSelectLicCSV.Text = "Browse CSV...";
            this.btnSelectLicCSV.UseVisualStyleBackColor = true;
            this.btnSelectLicCSV.Click += new System.EventHandler(this.btnSelectLicCSV_Click);
            // 
            // dgLicenses
            // 
            this.dgLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLicenses.Location = new System.Drawing.Point(18, 125);
            this.dgLicenses.Name = "dgLicenses";
            this.dgLicenses.Size = new System.Drawing.Size(762, 320);
            this.dgLicenses.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(9, 456);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(60, 13);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "Row Count";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblFilterSoftware);
            this.grpFilter.Controls.Add(this.textFilterSoftware);
            this.grpFilter.Controls.Add(this.lblFilterEntity);
            this.grpFilter.Controls.Add(this.textFilterEntity);
            this.grpFilter.Location = new System.Drawing.Point(137, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(643, 107);
            this.grpFilter.TabIndex = 4;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Licenses";
            // 
            // lblFilterSoftware
            // 
            this.lblFilterSoftware.AutoSize = true;
            this.lblFilterSoftware.Location = new System.Drawing.Point(6, 54);
            this.lblFilterSoftware.Name = "lblFilterSoftware";
            this.lblFilterSoftware.Size = new System.Drawing.Size(77, 13);
            this.lblFilterSoftware.TabIndex = 3;
            this.lblFilterSoftware.Text = "Filter Software:";
            // 
            // textFilterSoftware
            // 
            this.textFilterSoftware.Location = new System.Drawing.Point(89, 50);
            this.textFilterSoftware.Name = "textFilterSoftware";
            this.textFilterSoftware.Size = new System.Drawing.Size(235, 20);
            this.textFilterSoftware.TabIndex = 2;
            this.textFilterSoftware.TextChanged += new System.EventHandler(this.textFilterSoftware_TextChanged);
            // 
            // lblFilterEntity
            // 
            this.lblFilterEntity.AutoSize = true;
            this.lblFilterEntity.Location = new System.Drawing.Point(6, 25);
            this.lblFilterEntity.Name = "lblFilterEntity";
            this.lblFilterEntity.Size = new System.Drawing.Size(61, 13);
            this.lblFilterEntity.TabIndex = 1;
            this.lblFilterEntity.Text = "Filter Entity:";
            // 
            // textFilterEntity
            // 
            this.textFilterEntity.Location = new System.Drawing.Point(89, 22);
            this.textFilterEntity.Name = "textFilterEntity";
            this.textFilterEntity.Size = new System.Drawing.Size(235, 20);
            this.textFilterEntity.TabIndex = 0;
            this.textFilterEntity.TextChanged += new System.EventHandler(this.textFilterEntity_TextChanged);
            // 
            // frmRdImportLicenseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 486);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgLicenses);
            this.Controls.Add(this.grpImport);
            this.Name = "frmRdImportLicenseData";
            this.Text = "View and Import Licenses";
            this.Load += new System.EventHandler(this.frmRdImportLicenseData_Load);
            this.grpImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLicenses)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpImport;
        private System.Windows.Forms.Button btnSelectLicCSV;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgLicenses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TextBox textFilterEntity;
        private System.Windows.Forms.Label lblFilterEntity;
        private System.Windows.Forms.Label lblFilterSoftware;
        private System.Windows.Forms.TextBox textFilterSoftware;
    }
}