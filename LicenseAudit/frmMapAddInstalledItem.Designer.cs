namespace LicenseAudit
{
    partial class frmMapAddInstalledItem
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
            this.dgInstalledItems = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.textFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstalledItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInstalledItems
            // 
            this.dgInstalledItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstalledItems.Location = new System.Drawing.Point(12, 39);
            this.dgInstalledItems.Name = "dgInstalledItems";
            this.dgInstalledItems.Size = new System.Drawing.Size(575, 366);
            this.dgInstalledItems.TabIndex = 0;
            this.dgInstalledItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstalledItems_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Selected";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 412);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(60, 13);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "Row Count";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(17, 16);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(30, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Find:";
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(53, 13);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(533, 20);
            this.textFilter.TabIndex = 5;
            this.textFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // frmMapAddInstalledItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 447);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgInstalledItems);
            this.Name = "frmMapAddInstalledItem";
            this.Text = "Add Installed Items";
            this.Load += new System.EventHandler(this.frmMapAddInstalledItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstalledItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInstalledItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox textFilter;
    }
}