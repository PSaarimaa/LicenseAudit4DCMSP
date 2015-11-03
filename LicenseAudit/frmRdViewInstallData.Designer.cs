namespace LicenseAudit
{
    partial class frmRdViewInstallData
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgInstallData = new System.Windows.Forms.DataGridView();
            this.textEntity = new System.Windows.Forms.TextBox();
            this.textSoftware = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Entity";
            // 
            // dgInstallData
            // 
            this.dgInstallData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInstallData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstallData.Location = new System.Drawing.Point(12, 82);
            this.dgInstallData.Name = "dgInstallData";
            this.dgInstallData.Size = new System.Drawing.Size(1031, 425);
            this.dgInstallData.TabIndex = 1;
            this.dgInstallData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstallData_CellDoubleClick);
            // 
            // textEntity
            // 
            this.textEntity.Location = new System.Drawing.Point(6, 38);
            this.textEntity.Name = "textEntity";
            this.textEntity.Size = new System.Drawing.Size(287, 20);
            this.textEntity.TabIndex = 2;
            this.textEntity.TextChanged += new System.EventHandler(this.textEntity_TextChanged);
            // 
            // textSoftware
            // 
            this.textSoftware.Location = new System.Drawing.Point(316, 38);
            this.textSoftware.Name = "textSoftware";
            this.textSoftware.Size = new System.Drawing.Size(328, 20);
            this.textSoftware.TabIndex = 3;
            this.textSoftware.TextChanged += new System.EventHandler(this.textSoftware_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Software Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEntity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textSoftware);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(968, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 514);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(46, 13);
            this.lblRowCount.TabIndex = 7;
            this.lblRowCount.Text = "Rows: 0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last import date:";
            // 
            // frmRdViewInstallData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgInstallData);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRdViewInstallData";
            this.Text = "View Desktop Central Installation Data";
            this.Load += new System.EventHandler(this.frmRdViewInstallData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInstallData;
        private System.Windows.Forms.TextBox textEntity;
        private System.Windows.Forms.TextBox textSoftware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label3;
    }
}