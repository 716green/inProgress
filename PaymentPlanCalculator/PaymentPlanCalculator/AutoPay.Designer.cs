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
            this.pnlAutoPay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAutoPay
            // 
            this.pnlAutoPay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlAutoPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAutoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAutoPay.Location = new System.Drawing.Point(12, 12);
            this.pnlAutoPay.Name = "pnlAutoPay";
            this.pnlAutoPay.Size = new System.Drawing.Size(727, 505);
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

        public System.Windows.Forms.Panel pnlAutoPay;
    }
}