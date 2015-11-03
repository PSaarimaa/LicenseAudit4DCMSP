namespace LicenseAudit
{
    partial class frmUpdateFromDC
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Current Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(12, 9);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(57, 13);
            this.lblPhase.TabIndex = 1;
            this.lblPhase.Text = "Phase 1/2";
            // 
            // frmUpdateFromDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 51);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.lblStatus);
            this.Name = "frmUpdateFromDC";
            this.Text = "Desktop Cental Data Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPhase;
    }
}