namespace PaymentPlanCalculator
{
    partial class AutoPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPay));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlAutoPay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnlAutoPay
            // 
            this.pnlAutoPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAutoPay.Location = new System.Drawing.Point(0, 0);
            this.pnlAutoPay.Name = "pnlAutoPay";
            this.pnlAutoPay.Size = new System.Drawing.Size(1343, 529);
            this.pnlAutoPay.TabIndex = 0;
            // 
            // AutoPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 529);
            this.Controls.Add(this.pnlAutoPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoPay";
            this.Text = "AutoPay";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlAutoPay;
    }
}