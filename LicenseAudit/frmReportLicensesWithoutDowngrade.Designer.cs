namespace LicenseAudit
{
    partial class frmReportLicensesWithoutDowngrade
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
            this.dgReportView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.textFilterSoftware = new System.Windows.Forms.TextBox();
            this.lblFilterSoftware = new System.Windows.Forms.Label();
            this.textFilterEntity = new System.Windows.Forms.TextBox();
            this.lblFilterEntity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportView)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgReportView
            // 
            this.dgReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportView.Location = new System.Drawing.Point(12, 71);
            this.dgReportView.Name = "dgReportView";
            this.dgReportView.Size = new System.Drawing.Size(983, 335);
            this.dgReportView.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(920, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(813, 412);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to Excel...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 413);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(60, 13);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "Row Count";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.textFilterSoftware);
            this.grpFilter.Controls.Add(this.lblFilterSoftware);
            this.grpFilter.Controls.Add(this.textFilterEntity);
            this.grpFilter.Controls.Add(this.lblFilterEntity);
            this.grpFilter.Location = new System.Drawing.Point(16, 13);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(979, 52);
            this.grpFilter.TabIndex = 4;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // textFilterSoftware
            // 
            this.textFilterSoftware.Location = new System.Drawing.Point(299, 20);
            this.textFilterSoftware.Name = "textFilterSoftware";
            this.textFilterSoftware.Size = new System.Drawing.Size(227, 20);
            this.textFilterSoftware.TabIndex = 3;
            this.textFilterSoftware.TextChanged += new System.EventHandler(this.textFilterSoftware_TextChanged);
            // 
            // lblFilterSoftware
            // 
            this.lblFilterSoftware.AutoSize = true;
            this.lblFilterSoftware.Location = new System.Drawing.Point(241, 23);
            this.lblFilterSoftware.Name = "lblFilterSoftware";
            this.lblFilterSoftware.Size = new System.Drawing.Size(52, 13);
            this.lblFilterSoftware.TabIndex = 2;
            this.lblFilterSoftware.Text = "Software:";
            // 
            // textFilterEntity
            // 
            this.textFilterEntity.Location = new System.Drawing.Point(49, 20);
            this.textFilterEntity.Name = "textFilterEntity";
            this.textFilterEntity.Size = new System.Drawing.Size(186, 20);
            this.textFilterEntity.TabIndex = 1;
            this.textFilterEntity.TextChanged += new System.EventHandler(this.textFilterEntity_TextChanged);
            // 
            // lblFilterEntity
            // 
            this.lblFilterEntity.AutoSize = true;
            this.lblFilterEntity.Location = new System.Drawing.Point(7, 23);
            this.lblFilterEntity.Name = "lblFilterEntity";
            this.lblFilterEntity.Size = new System.Drawing.Size(36, 13);
            this.lblFilterEntity.TabIndex = 0;
            this.lblFilterEntity.Text = "Entity:";
            // 
            // frmReportLicensesWithoutDowngrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgReportView);
            this.Name = "frmReportLicensesWithoutDowngrade";
            this.Text = "Report Licenses with Down/Upgrades";
            this.Load += new System.EventHandler(this.frmReportLicensesWithoutDowngrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReportView)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReportView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TextBox textFilterSoftware;
        private System.Windows.Forms.Label lblFilterSoftware;
        private System.Windows.Forms.TextBox textFilterEntity;
        private System.Windows.Forms.Label lblFilterEntity;
    }
}