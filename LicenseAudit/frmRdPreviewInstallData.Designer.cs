namespace LicenseAudit
{
    partial class frmRdPreviewInstallData
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
            this.dgLicensesPreview = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLicensesPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLicensesPreview
            // 
            this.dgLicensesPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLicensesPreview.Location = new System.Drawing.Point(12, 12);
            this.dgLicensesPreview.Name = "dgLicensesPreview";
            this.dgLicensesPreview.Size = new System.Drawing.Size(908, 464);
            this.dgLicensesPreview.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(844, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRdPreviewInstallData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 518);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgLicensesPreview);
            this.Name = "frmRdPreviewInstallData";
            this.Text = "frmRdPreviewInstallData";
            ((System.ComponentModel.ISupportInitialize)(this.dgLicensesPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLicensesPreview;
        private System.Windows.Forms.Button btnClose;
    }
}