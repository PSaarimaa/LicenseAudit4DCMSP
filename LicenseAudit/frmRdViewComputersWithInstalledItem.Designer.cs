namespace LicenseAudit
{
    partial class frmRdViewComputersWithInstalledItem
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
            this.dgComputerList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblEntity = new System.Windows.Forms.Label();
            this.txtFilterEntity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgComputerList)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgComputerList
            // 
            this.dgComputerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgComputerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComputerList.Location = new System.Drawing.Point(12, 69);
            this.dgComputerList.Name = "dgComputerList";
            this.dgComputerList.Size = new System.Drawing.Size(541, 395);
            this.dgComputerList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(478, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.txtFilterEntity);
            this.grpFilter.Controls.Add(this.lblEntity);
            this.grpFilter.Location = new System.Drawing.Point(12, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(541, 51);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(7, 20);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(36, 13);
            this.lblEntity.TabIndex = 0;
            this.lblEntity.Text = "Entity:";
            // 
            // txtFilterEntity
            // 
            this.txtFilterEntity.Location = new System.Drawing.Point(50, 20);
            this.txtFilterEntity.Name = "txtFilterEntity";
            this.txtFilterEntity.Size = new System.Drawing.Size(193, 20);
            this.txtFilterEntity.TabIndex = 1;
            this.txtFilterEntity.TextChanged += new System.EventHandler(this.txtFilterEntity_TextChanged);
            // 
            // frmRdViewComputersWithInstalledItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 505);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgComputerList);
            this.Name = "frmRdViewComputersWithInstalledItem";
            this.Text = "frmRdViewComputersWithInstalledItem";
            ((System.ComponentModel.ISupportInitialize)(this.dgComputerList)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgComputerList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TextBox txtFilterEntity;
        private System.Windows.Forms.Label lblEntity;
    }
}