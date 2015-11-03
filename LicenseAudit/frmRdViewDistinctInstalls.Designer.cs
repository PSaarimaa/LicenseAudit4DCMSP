namespace LicenseAudit
{
    partial class frmRdViewDistinctInstalls
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
            this.textFilterName = new System.Windows.Forms.TextBox();
            this.dgDistinctSoftware = new System.Windows.Forms.DataGridView();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFilterDate = new System.Windows.Forms.DateTimePicker();
            this.rbDateFilter = new System.Windows.Forms.RadioButton();
            this.rbDateAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoftwareItemFilter = new System.Windows.Forms.Label();
            this.comboFilterSoftwareItem = new System.Windows.Forms.ComboBox();
            this.grpHide = new System.Windows.Forms.GroupBox();
            this.btnUnhide = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.boxShowHidden = new System.Windows.Forms.CheckBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistinctSoftware)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpHide.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFilterName
            // 
            this.textFilterName.Location = new System.Drawing.Point(87, 44);
            this.textFilterName.Name = "textFilterName";
            this.textFilterName.Size = new System.Drawing.Size(232, 20);
            this.textFilterName.TabIndex = 1;
            this.textFilterName.TextChanged += new System.EventHandler(this.textFilterName_TextChanged);
            // 
            // dgDistinctSoftware
            // 
            this.dgDistinctSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDistinctSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDistinctSoftware.Location = new System.Drawing.Point(14, 99);
            this.dgDistinctSoftware.Name = "dgDistinctSoftware";
            this.dgDistinctSoftware.Size = new System.Drawing.Size(965, 419);
            this.dgDistinctSoftware.TabIndex = 2;
            this.dgDistinctSoftware.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDistinctSoftware_CellDoubleClick);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(14, 525);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(35, 13);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "label3";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(904, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtFilterDate);
            this.groupBox1.Controls.Add(this.rbDateFilter);
            this.groupBox1.Controls.Add(this.rbDateAll);
            this.groupBox1.Location = new System.Drawing.Point(670, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by Date";
            // 
            // dtFilterDate
            // 
            this.dtFilterDate.Enabled = false;
            this.dtFilterDate.Location = new System.Drawing.Point(103, 44);
            this.dtFilterDate.Name = "dtFilterDate";
            this.dtFilterDate.Size = new System.Drawing.Size(200, 20);
            this.dtFilterDate.TabIndex = 2;
            this.dtFilterDate.ValueChanged += new System.EventHandler(this.dtFilterDate_ValueChanged);
            // 
            // rbDateFilter
            // 
            this.rbDateFilter.AutoSize = true;
            this.rbDateFilter.Location = new System.Drawing.Point(7, 44);
            this.rbDateFilter.Name = "rbDateFilter";
            this.rbDateFilter.Size = new System.Drawing.Size(92, 17);
            this.rbDateFilter.TabIndex = 1;
            this.rbDateFilter.Text = "Specific Date:";
            this.rbDateFilter.UseVisualStyleBackColor = true;
            this.rbDateFilter.CheckedChanged += new System.EventHandler(this.rbDateFilter_CheckedChanged);
            // 
            // rbDateAll
            // 
            this.rbDateAll.AutoSize = true;
            this.rbDateAll.Checked = true;
            this.rbDateAll.Location = new System.Drawing.Point(7, 20);
            this.rbDateAll.Name = "rbDateAll";
            this.rbDateAll.Size = new System.Drawing.Size(119, 17);
            this.rbDateAll.TabIndex = 0;
            this.rbDateAll.TabStop = true;
            this.rbDateAll.Text = "Do not filter by Date";
            this.rbDateAll.UseVisualStyleBackColor = true;
            this.rbDateAll.CheckedChanged += new System.EventHandler(this.rbDateAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Software Name:";
            // 
            // lblSoftwareItemFilter
            // 
            this.lblSoftwareItemFilter.AutoSize = true;
            this.lblSoftwareItemFilter.Location = new System.Drawing.Point(6, 21);
            this.lblSoftwareItemFilter.Name = "lblSoftwareItemFilter";
            this.lblSoftwareItemFilter.Size = new System.Drawing.Size(37, 13);
            this.lblSoftwareItemFilter.TabIndex = 7;
            this.lblSoftwareItemFilter.Text = "Show:";
            // 
            // comboFilterSoftwareItem
            // 
            this.comboFilterSoftwareItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterSoftwareItem.FormattingEnabled = true;
            this.comboFilterSoftwareItem.Items.AddRange(new object[] {
            "All installed items",
            "Only installed items without a mapped Software item",
            "Only installed items with a mapped Software item"});
            this.comboFilterSoftwareItem.Location = new System.Drawing.Point(87, 16);
            this.comboFilterSoftwareItem.Name = "comboFilterSoftwareItem";
            this.comboFilterSoftwareItem.Size = new System.Drawing.Size(232, 21);
            this.comboFilterSoftwareItem.TabIndex = 8;
            this.comboFilterSoftwareItem.SelectedIndexChanged += new System.EventHandler(this.comboFilterSoftwareItem_SelectedIndexChanged);
            // 
            // grpHide
            // 
            this.grpHide.Controls.Add(this.btnUnhide);
            this.grpHide.Controls.Add(this.btnHide);
            this.grpHide.Controls.Add(this.boxShowHidden);
            this.grpHide.Location = new System.Drawing.Point(343, 15);
            this.grpHide.Name = "grpHide";
            this.grpHide.Size = new System.Drawing.Size(236, 78);
            this.grpHide.TabIndex = 9;
            this.grpHide.TabStop = false;
            this.grpHide.Text = "Hide Items";
            // 
            // btnUnhide
            // 
            this.btnUnhide.Location = new System.Drawing.Point(124, 44);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(106, 23);
            this.btnUnhide.TabIndex = 2;
            this.btnUnhide.Text = "Unhide Selected";
            this.btnUnhide.UseVisualStyleBackColor = true;
            this.btnUnhide.Click += new System.EventHandler(this.btnUnhide_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(124, 16);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(106, 23);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Hide Selected";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // boxShowHidden
            // 
            this.boxShowHidden.AutoSize = true;
            this.boxShowHidden.Location = new System.Drawing.Point(7, 20);
            this.boxShowHidden.Name = "boxShowHidden";
            this.boxShowHidden.Size = new System.Drawing.Size(90, 17);
            this.boxShowHidden.TabIndex = 0;
            this.boxShowHidden.Text = "Show Hidden";
            this.boxShowHidden.UseVisualStyleBackColor = true;
            this.boxShowHidden.CheckedChanged += new System.EventHandler(this.boxShowHidden_CheckedChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.comboFilterSoftwareItem);
            this.grpFilter.Controls.Add(this.textFilterName);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.lblSoftwareItemFilter);
            this.grpFilter.Location = new System.Drawing.Point(12, 15);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(325, 78);
            this.grpFilter.TabIndex = 10;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter by Status and Name";
            // 
            // frmRdViewDistinctInstalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 556);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpHide);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgDistinctSoftware);
            this.Name = "frmRdViewDistinctInstalls";
            this.Text = "View Distinct Software Items";
            this.Load += new System.EventHandler(this.frmRdViewDistinctSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDistinctSoftware)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpHide.ResumeLayout(false);
            this.grpHide.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFilterName;
        private System.Windows.Forms.DataGridView dgDistinctSoftware;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFilterDate;
        private System.Windows.Forms.RadioButton rbDateFilter;
        private System.Windows.Forms.RadioButton rbDateAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoftwareItemFilter;
        private System.Windows.Forms.ComboBox comboFilterSoftwareItem;
        private System.Windows.Forms.GroupBox grpHide;
        private System.Windows.Forms.Button btnUnhide;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.CheckBox boxShowHidden;
        private System.Windows.Forms.GroupBox grpFilter;
    }
}