namespace LicenseAudit
{
    partial class frmRdViewSoftwareItems
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
            this.btnImport = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgSoftwareItems = new System.Windows.Forms.DataGridView();
            this.textFilterName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftwareItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(94, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(72, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter sofware:";
            // 
            // dgSoftwareItems
            // 
            this.dgSoftwareItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoftwareItems.Location = new System.Drawing.Point(13, 42);
            this.dgSoftwareItems.Name = "dgSoftwareItems";
            this.dgSoftwareItems.Size = new System.Drawing.Size(633, 349);
            this.dgSoftwareItems.TabIndex = 2;
            // 
            // textFilterName
            // 
            this.textFilterName.Location = new System.Drawing.Point(177, 15);
            this.textFilterName.Name = "textFilterName";
            this.textFilterName.Size = new System.Drawing.Size(469, 20);
            this.textFilterName.TabIndex = 3;
            this.textFilterName.TextChanged += new System.EventHandler(this.textFilterName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(571, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(10, 402);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(60, 13);
            this.lblRowCount.TabIndex = 5;
            this.lblRowCount.Text = "Row Count";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(465, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmRdViewSoftwareItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 432);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textFilterName);
            this.Controls.Add(this.dgSoftwareItems);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnImport);
            this.Name = "frmRdViewSoftwareItems";
            this.Text = "Software Items";
            this.Load += new System.EventHandler(this.frmRdViewSoftwareItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftwareItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgSoftwareItems;
        private System.Windows.Forms.TextBox textFilterName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnDelete;
    }
}