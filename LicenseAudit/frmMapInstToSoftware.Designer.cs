namespace LicenseAudit
{
    partial class frmMapInstToSoftware
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
            this.grpSoftwareItems = new System.Windows.Forms.GroupBox();
            this.lblSoftwareFilter = new System.Windows.Forms.Label();
            this.textSoftwareFilter = new System.Windows.Forms.TextBox();
            this.comboFilterSoftware = new System.Windows.Forms.ComboBox();
            this.dgSoftwareItems = new System.Windows.Forms.DataGridView();
            this.grpInstalledItems = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgInstalledItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSoftwareItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftwareItems)).BeginInit();
            this.grpInstalledItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstalledItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSoftwareItems
            // 
            this.grpSoftwareItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSoftwareItems.Controls.Add(this.lblSoftwareFilter);
            this.grpSoftwareItems.Controls.Add(this.textSoftwareFilter);
            this.grpSoftwareItems.Controls.Add(this.comboFilterSoftware);
            this.grpSoftwareItems.Controls.Add(this.dgSoftwareItems);
            this.grpSoftwareItems.Location = new System.Drawing.Point(12, 12);
            this.grpSoftwareItems.Name = "grpSoftwareItems";
            this.grpSoftwareItems.Size = new System.Drawing.Size(309, 412);
            this.grpSoftwareItems.TabIndex = 0;
            this.grpSoftwareItems.TabStop = false;
            this.grpSoftwareItems.Text = "Software Items";
            // 
            // lblSoftwareFilter
            // 
            this.lblSoftwareFilter.AutoSize = true;
            this.lblSoftwareFilter.Location = new System.Drawing.Point(6, 66);
            this.lblSoftwareFilter.Name = "lblSoftwareFilter";
            this.lblSoftwareFilter.Size = new System.Drawing.Size(32, 13);
            this.lblSoftwareFilter.TabIndex = 3;
            this.lblSoftwareFilter.Text = "Filter:";
            // 
            // textSoftwareFilter
            // 
            this.textSoftwareFilter.Location = new System.Drawing.Point(44, 63);
            this.textSoftwareFilter.Name = "textSoftwareFilter";
            this.textSoftwareFilter.Size = new System.Drawing.Size(259, 20);
            this.textSoftwareFilter.TabIndex = 2;
            this.textSoftwareFilter.TextChanged += new System.EventHandler(this.textSoftwareFilter_TextChanged);
            // 
            // comboFilterSoftware
            // 
            this.comboFilterSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterSoftware.FormattingEnabled = true;
            this.comboFilterSoftware.Items.AddRange(new object[] {
            "Show All ",
            "Show Only Items without Installatations",
            "Show Only Items with Installations"});
            this.comboFilterSoftware.Location = new System.Drawing.Point(7, 31);
            this.comboFilterSoftware.Name = "comboFilterSoftware";
            this.comboFilterSoftware.Size = new System.Drawing.Size(296, 21);
            this.comboFilterSoftware.TabIndex = 1;
            this.comboFilterSoftware.SelectedIndexChanged += new System.EventHandler(this.comboFilterSoftware_SelectedIndexChanged);
            // 
            // dgSoftwareItems
            // 
            this.dgSoftwareItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoftwareItems.Location = new System.Drawing.Point(7, 93);
            this.dgSoftwareItems.MultiSelect = false;
            this.dgSoftwareItems.Name = "dgSoftwareItems";
            this.dgSoftwareItems.Size = new System.Drawing.Size(296, 313);
            this.dgSoftwareItems.TabIndex = 0;
            this.dgSoftwareItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoftwareItems_CellClick);
            // 
            // grpInstalledItems
            // 
            this.grpInstalledItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInstalledItems.Controls.Add(this.btnRemove);
            this.grpInstalledItems.Controls.Add(this.btnAddItem);
            this.grpInstalledItems.Controls.Add(this.dgInstalledItems);
            this.grpInstalledItems.Location = new System.Drawing.Point(327, 12);
            this.grpInstalledItems.Name = "grpInstalledItems";
            this.grpInstalledItems.Size = new System.Drawing.Size(387, 412);
            this.grpInstalledItems.TabIndex = 1;
            this.grpInstalledItems.TabStop = false;
            this.grpInstalledItems.Text = "Installed Items";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(88, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(7, 29);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add...";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgInstalledItems
            // 
            this.dgInstalledItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstalledItems.Location = new System.Drawing.Point(6, 63);
            this.dgInstalledItems.Name = "dgInstalledItems";
            this.dgInstalledItems.Size = new System.Drawing.Size(375, 343);
            this.dgInstalledItems.TabIndex = 2;
            this.dgInstalledItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstalledItems_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(632, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMapInstToSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpInstalledItems);
            this.Controls.Add(this.grpSoftwareItems);
            this.Name = "frmMapInstToSoftware";
            this.Text = "Map Installed Items to Software Items";
            this.Load += new System.EventHandler(this.frmMapInstToSoftware_Load);
            this.grpSoftwareItems.ResumeLayout(false);
            this.grpSoftwareItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftwareItems)).EndInit();
            this.grpInstalledItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstalledItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoftwareItems;
        private System.Windows.Forms.DataGridView dgSoftwareItems;
        private System.Windows.Forms.ComboBox comboFilterSoftware;
        private System.Windows.Forms.GroupBox grpInstalledItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgInstalledItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSoftwareFilter;
        private System.Windows.Forms.TextBox textSoftwareFilter;
    }
}