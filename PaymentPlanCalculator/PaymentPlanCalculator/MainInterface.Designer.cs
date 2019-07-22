namespace PaymentPlanCalculator
{
    partial class paymentPlanCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentPlanCalculator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.apSheetExportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.txtSIFAmountOverwrite = new System.Windows.Forms.TextBox();
            this.txtSifPercentOverwrite = new System.Windows.Forms.TextBox();
            this.lblSeventy = new System.Windows.Forms.Label();
            this.lblFiftyFive = new System.Windows.Forms.Label();
            this.lblSixty = new System.Windows.Forms.Label();
            this.lblSixtyFive = new System.Windows.Forms.Label();
            this.lblNinetyFive = new System.Windows.Forms.Label();
            this.lblEighty = new System.Windows.Forms.Label();
            this.lblEightyFive = new System.Windows.Forms.Label();
            this.lblNinety = new System.Windows.Forms.Label();
            this.cboxExpYear = new System.Windows.Forms.ComboBox();
            this.cboxExpMonth = new System.Windows.Forms.ComboBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardValid = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblDollarSign5 = new System.Windows.Forms.Label();
            this.lblDollarSign4 = new System.Windows.Forms.Label();
            this.dropDownPayCycle = new System.Windows.Forms.ComboBox();
            this.lblRMG = new System.Windows.Forms.Label();
            this.sliderRemainingPmtCount = new System.Windows.Forms.TrackBar();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtBalanceInput = new System.Windows.Forms.TextBox();
            this.lblTwentyFive = new System.Windows.Forms.Label();
            this.lblSeventyFive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFifty = new System.Windows.Forms.Label();
            this.lblOneHundo = new System.Windows.Forms.Label();
            this.chkSettlement = new System.Windows.Forms.CheckBox();
            this.chkPPA = new System.Windows.Forms.CheckBox();
            this.slideSIFpercentage = new System.Windows.Forms.TrackBar();
            this.lblPercentSymbol = new System.Windows.Forms.Label();
            this.lblRemainingPmtCount = new System.Windows.Forms.Label();
            this.lblPCR = new System.Windows.Forms.Label();
            this.lblRemainingBal = new System.Windows.Forms.Label();
            this.lblRemBal = new System.Windows.Forms.Label();
            this.lblDownPmt = new System.Windows.Forms.Label();
            this.lblSifBalance = new System.Windows.Forms.Label();
            this.lblSIFpercent = new System.Windows.Forms.Label();
            this.lblSettlementRate = new System.Windows.Forms.Label();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.pnlPPA = new System.Windows.Forms.Panel();
            this.lblPMTSREM = new System.Windows.Forms.Label();
            this.lblInstallmentAmt = new System.Windows.Forms.Label();
            this.lblRemainingBalanceNotification = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.lblTtlPay = new System.Windows.Forms.Label();
            this.lblTotalPaymentCount = new System.Windows.Forms.Label();
            this.rtxtNotate = new System.Windows.Forms.RichTextBox();
            this.monthCalendarDP = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstallmentLabel = new System.Windows.Forms.Label();
            this.monthCalendarInstallmentStart = new System.Windows.Forms.MonthCalendar();
            this.label_downPaymentDate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataGridPPA = new System.Windows.Forms.DataGridView();
            this.pmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPaymentPlan = new System.Windows.Forms.Panel();
            this.btnNotateToLog = new System.Windows.Forms.Button();
            this.lblBIN = new System.Windows.Forms.Label();
            this.lblDebug2 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRemainingPmtCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideSIFpercentage)).BeginInit();
            this.pnlPPA.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPPA)).BeginInit();
            this.pnlPaymentPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripExport});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1520, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.resetToolStripMenuItem.Text = "Save";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripExport
            // 
            this.toolStripExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apSheetExportButton});
            this.toolStripExport.Enabled = false;
            this.toolStripExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExport.Name = "toolStripExport";
            this.toolStripExport.Size = new System.Drawing.Size(54, 22);
            this.toolStripExport.Text = "Export";
            // 
            // apSheetExportButton
            // 
            this.apSheetExportButton.Name = "apSheetExportButton";
            this.apSheetExportButton.Size = new System.Drawing.Size(121, 22);
            this.apSheetExportButton.Text = "AP Sheet";
            this.apSheetExportButton.Click += new System.EventHandler(this.APSheetToolStripMenuItem_Click);
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDataEntry.Controls.Add(this.txtSIFAmountOverwrite);
            this.pnlDataEntry.Controls.Add(this.txtSifPercentOverwrite);
            this.pnlDataEntry.Controls.Add(this.lblSeventy);
            this.pnlDataEntry.Controls.Add(this.lblFiftyFive);
            this.pnlDataEntry.Controls.Add(this.lblSixty);
            this.pnlDataEntry.Controls.Add(this.lblSixtyFive);
            this.pnlDataEntry.Controls.Add(this.lblNinetyFive);
            this.pnlDataEntry.Controls.Add(this.lblEighty);
            this.pnlDataEntry.Controls.Add(this.lblEightyFive);
            this.pnlDataEntry.Controls.Add(this.lblNinety);
            this.pnlDataEntry.Controls.Add(this.cboxExpYear);
            this.pnlDataEntry.Controls.Add(this.cboxExpMonth);
            this.pnlDataEntry.Controls.Add(this.txtCVV);
            this.pnlDataEntry.Controls.Add(this.lblCardType);
            this.pnlDataEntry.Controls.Add(this.lblCardValid);
            this.pnlDataEntry.Controls.Add(this.btnValidate);
            this.pnlDataEntry.Controls.Add(this.lblCreditCardNumber);
            this.pnlDataEntry.Controls.Add(this.txtCreditCardNumber);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign5);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign4);
            this.pnlDataEntry.Controls.Add(this.dropDownPayCycle);
            this.pnlDataEntry.Controls.Add(this.lblRMG);
            this.pnlDataEntry.Controls.Add(this.sliderRemainingPmtCount);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign);
            this.pnlDataEntry.Controls.Add(this.txtDownPayment);
            this.pnlDataEntry.Controls.Add(this.txtBalanceInput);
            this.pnlDataEntry.Controls.Add(this.lblTwentyFive);
            this.pnlDataEntry.Controls.Add(this.lblSeventyFive);
            this.pnlDataEntry.Controls.Add(this.label2);
            this.pnlDataEntry.Controls.Add(this.lblFifty);
            this.pnlDataEntry.Controls.Add(this.lblOneHundo);
            this.pnlDataEntry.Controls.Add(this.chkSettlement);
            this.pnlDataEntry.Controls.Add(this.chkPPA);
            this.pnlDataEntry.Controls.Add(this.slideSIFpercentage);
            this.pnlDataEntry.Controls.Add(this.lblPercentSymbol);
            this.pnlDataEntry.Controls.Add(this.lblRemainingPmtCount);
            this.pnlDataEntry.Controls.Add(this.lblPCR);
            this.pnlDataEntry.Controls.Add(this.lblRemainingBal);
            this.pnlDataEntry.Controls.Add(this.lblRemBal);
            this.pnlDataEntry.Controls.Add(this.lblDownPmt);
            this.pnlDataEntry.Controls.Add(this.lblSifBalance);
            this.pnlDataEntry.Controls.Add(this.lblSIFpercent);
            this.pnlDataEntry.Controls.Add(this.lblSettlementRate);
            this.pnlDataEntry.Controls.Add(this.lblCurrentBal);
            this.pnlDataEntry.Controls.Add(this.pnlPPA);
            this.pnlDataEntry.Location = new System.Drawing.Point(12, 29);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(397, 503);
            this.pnlDataEntry.TabIndex = 1;
            // 
            // txtSIFAmountOverwrite
            // 
            this.txtSIFAmountOverwrite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSIFAmountOverwrite.Location = new System.Drawing.Point(181, 57);
            this.txtSIFAmountOverwrite.Name = "txtSIFAmountOverwrite";
            this.txtSIFAmountOverwrite.Size = new System.Drawing.Size(100, 29);
            this.txtSIFAmountOverwrite.TabIndex = 51;
            this.txtSIFAmountOverwrite.Visible = false;
            // 
            // txtSifPercentOverwrite
            // 
            this.txtSifPercentOverwrite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifPercentOverwrite.Location = new System.Drawing.Point(156, 57);
            this.txtSifPercentOverwrite.Name = "txtSifPercentOverwrite";
            this.txtSifPercentOverwrite.Size = new System.Drawing.Size(100, 29);
            this.txtSifPercentOverwrite.TabIndex = 50;
            this.txtSifPercentOverwrite.Visible = false;
            // 
            // lblSeventy
            // 
            this.lblSeventy.AutoSize = true;
            this.lblSeventy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeventy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeventy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeventy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeventy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSeventy.Location = new System.Drawing.Point(311, 162);
            this.lblSeventy.Name = "lblSeventy";
            this.lblSeventy.Size = new System.Drawing.Size(43, 23);
            this.lblSeventy.TabIndex = 49;
            this.lblSeventy.Text = "70%";
            this.lblSeventy.Click += new System.EventHandler(this.LblSeventy_Click);
            // 
            // lblFiftyFive
            // 
            this.lblFiftyFive.AutoSize = true;
            this.lblFiftyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFiftyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFiftyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFiftyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiftyFive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFiftyFive.Location = new System.Drawing.Point(311, 231);
            this.lblFiftyFive.Name = "lblFiftyFive";
            this.lblFiftyFive.Size = new System.Drawing.Size(43, 23);
            this.lblFiftyFive.TabIndex = 48;
            this.lblFiftyFive.Text = "55%";
            this.lblFiftyFive.Click += new System.EventHandler(this.LblFiftyFive_Click);
            // 
            // lblSixty
            // 
            this.lblSixty.AutoSize = true;
            this.lblSixty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSixty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSixty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSixty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSixty.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSixty.Location = new System.Drawing.Point(311, 208);
            this.lblSixty.Name = "lblSixty";
            this.lblSixty.Size = new System.Drawing.Size(43, 23);
            this.lblSixty.TabIndex = 47;
            this.lblSixty.Text = "60%";
            this.lblSixty.Click += new System.EventHandler(this.LblSixty_Click);
            // 
            // lblSixtyFive
            // 
            this.lblSixtyFive.AutoSize = true;
            this.lblSixtyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSixtyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSixtyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSixtyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSixtyFive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSixtyFive.Location = new System.Drawing.Point(311, 185);
            this.lblSixtyFive.Name = "lblSixtyFive";
            this.lblSixtyFive.Size = new System.Drawing.Size(43, 23);
            this.lblSixtyFive.TabIndex = 46;
            this.lblSixtyFive.Text = "65%";
            this.lblSixtyFive.Click += new System.EventHandler(this.LblSixtyFive_Click);
            // 
            // lblNinetyFive
            // 
            this.lblNinetyFive.AutoSize = true;
            this.lblNinetyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNinetyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNinetyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNinetyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNinetyFive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNinetyFive.Location = new System.Drawing.Point(311, 47);
            this.lblNinetyFive.Name = "lblNinetyFive";
            this.lblNinetyFive.Size = new System.Drawing.Size(43, 23);
            this.lblNinetyFive.TabIndex = 45;
            this.lblNinetyFive.Text = "95%";
            this.lblNinetyFive.Click += new System.EventHandler(this.LblNinetyFive_Click);
            // 
            // lblEighty
            // 
            this.lblEighty.AutoSize = true;
            this.lblEighty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEighty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEighty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEighty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEighty.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEighty.Location = new System.Drawing.Point(311, 116);
            this.lblEighty.Name = "lblEighty";
            this.lblEighty.Size = new System.Drawing.Size(43, 23);
            this.lblEighty.TabIndex = 44;
            this.lblEighty.Text = "80%";
            this.lblEighty.Click += new System.EventHandler(this.LblEighty_Click);
            // 
            // lblEightyFive
            // 
            this.lblEightyFive.AutoSize = true;
            this.lblEightyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEightyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEightyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEightyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEightyFive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEightyFive.Location = new System.Drawing.Point(311, 93);
            this.lblEightyFive.Name = "lblEightyFive";
            this.lblEightyFive.Size = new System.Drawing.Size(43, 23);
            this.lblEightyFive.TabIndex = 43;
            this.lblEightyFive.Text = "85%";
            this.lblEightyFive.Click += new System.EventHandler(this.LblEightyFive_Click);
            // 
            // lblNinety
            // 
            this.lblNinety.AutoSize = true;
            this.lblNinety.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNinety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNinety.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNinety.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNinety.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNinety.Location = new System.Drawing.Point(311, 70);
            this.lblNinety.Name = "lblNinety";
            this.lblNinety.Size = new System.Drawing.Size(43, 23);
            this.lblNinety.TabIndex = 42;
            this.lblNinety.Text = "90%";
            this.lblNinety.Click += new System.EventHandler(this.LblNinety_Click);
            // 
            // cboxExpYear
            // 
            this.cboxExpYear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExpYear.FormattingEnabled = true;
            this.cboxExpYear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboxExpYear.Location = new System.Drawing.Point(93, 395);
            this.cboxExpYear.Name = "cboxExpYear";
            this.cboxExpYear.Size = new System.Drawing.Size(77, 38);
            this.cboxExpYear.TabIndex = 7;
            this.cboxExpYear.Text = "YYYY";
            // 
            // cboxExpMonth
            // 
            this.cboxExpMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExpMonth.FormattingEnabled = true;
            this.cboxExpMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboxExpMonth.Location = new System.Drawing.Point(9, 395);
            this.cboxExpMonth.Name = "cboxExpMonth";
            this.cboxExpMonth.Size = new System.Drawing.Size(70, 38);
            this.cboxExpMonth.TabIndex = 6;
            this.cboxExpMonth.Text = "MM";
            // 
            // txtCVV
            // 
            this.txtCVV.AllowDrop = true;
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtCVV.Location = new System.Drawing.Point(184, 395);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(79, 36);
            this.txtCVV.TabIndex = 8;
            this.txtCVV.Text = "CVV";
            this.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCVV.Click += new System.EventHandler(this.TxtCVV_Click);
            this.txtCVV.TextChanged += new System.EventHandler(this.TxtCVV_TextChanged);
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(264, 403);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(0, 21);
            this.lblCardType.TabIndex = 40;
            // 
            // lblCardValid
            // 
            this.lblCardValid.AutoSize = true;
            this.lblCardValid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardValid.Location = new System.Drawing.Point(107, 439);
            this.lblCardValid.Name = "lblCardValid";
            this.lblCardValid.Size = new System.Drawing.Size(52, 21);
            this.lblCardValid.TabIndex = 39;
            this.lblCardValid.Text = "Valid?";
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(6, 463);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(254, 31);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "VALIDATE";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(5, 326);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(204, 21);
            this.lblCreditCardNumber.TabIndex = 37;
            this.lblCreditCardNumber.Text = "Credit/Debit Card Number";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.AllowDrop = true;
            this.txtCreditCardNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtCreditCardNumber.Location = new System.Drawing.Point(8, 350);
            this.txtCreditCardNumber.MaxLength = 20;
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(254, 36);
            this.txtCreditCardNumber.TabIndex = 5;
            this.txtCreditCardNumber.TextChanged += new System.EventHandler(this.TxtCreditCardNumber_TextChanged);
            // 
            // lblDollarSign5
            // 
            this.lblDollarSign5.AutoSize = true;
            this.lblDollarSign5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign5.Location = new System.Drawing.Point(136, 89);
            this.lblDollarSign5.Name = "lblDollarSign5";
            this.lblDollarSign5.Size = new System.Drawing.Size(19, 21);
            this.lblDollarSign5.TabIndex = 34;
            this.lblDollarSign5.Text = "$";
            // 
            // lblDollarSign4
            // 
            this.lblDollarSign4.AutoSize = true;
            this.lblDollarSign4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign4.Location = new System.Drawing.Point(136, 8);
            this.lblDollarSign4.Name = "lblDollarSign4";
            this.lblDollarSign4.Size = new System.Drawing.Size(19, 21);
            this.lblDollarSign4.TabIndex = 33;
            this.lblDollarSign4.Text = "$";
            // 
            // dropDownPayCycle
            // 
            this.dropDownPayCycle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.dropDownPayCycle.FormattingEnabled = true;
            this.dropDownPayCycle.Items.AddRange(new object[] {
            "WEEKLY",
            "BI-WEEKLY",
            "SEMI-MONTHLY",
            "MONTHLY",
            "NOT ON A SCHEDULE"});
            this.dropDownPayCycle.Location = new System.Drawing.Point(6, 286);
            this.dropDownPayCycle.Name = "dropDownPayCycle";
            this.dropDownPayCycle.Size = new System.Drawing.Size(256, 38);
            this.dropDownPayCycle.TabIndex = 4;
            this.dropDownPayCycle.Text = "PAY CYCLE";
            this.dropDownPayCycle.SelectedIndexChanged += new System.EventHandler(this.DropDownPayCycle_SelectedIndexChanged);
            this.dropDownPayCycle.TextChanged += new System.EventHandler(this.DropDownPayCycle_TextChanged);
            this.dropDownPayCycle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DropDownPayCycle_MouseClick);
            this.dropDownPayCycle.MouseHover += new System.EventHandler(this.DropDownPayCycle_MouseHover);
            // 
            // lblRMG
            // 
            this.lblRMG.AutoSize = true;
            this.lblRMG.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMG.Location = new System.Drawing.Point(177, 143);
            this.lblRMG.Name = "lblRMG";
            this.lblRMG.Size = new System.Drawing.Size(73, 21);
            this.lblRMG.TabIndex = 29;
            this.lblRMG.Text = "Payment";
            // 
            // sliderRemainingPmtCount
            // 
            this.sliderRemainingPmtCount.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sliderRemainingPmtCount.LargeChange = 1;
            this.sliderRemainingPmtCount.Location = new System.Drawing.Point(8, 168);
            this.sliderRemainingPmtCount.Maximum = 11;
            this.sliderRemainingPmtCount.Minimum = 1;
            this.sliderRemainingPmtCount.Name = "sliderRemainingPmtCount";
            this.sliderRemainingPmtCount.Size = new System.Drawing.Size(303, 45);
            this.sliderRemainingPmtCount.TabIndex = 2;
            this.sliderRemainingPmtCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderRemainingPmtCount.Value = 1;
            this.sliderRemainingPmtCount.ValueChanged += new System.EventHandler(this.SliderRemainingPmtCount_ValueChanged);
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign.Location = new System.Drawing.Point(152, 120);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(19, 21);
            this.lblDollarSign.TabIndex = 27;
            this.lblDollarSign.Text = "$";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(156, 86);
            this.txtDownPayment.MaxLength = 12;
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(125, 29);
            this.txtDownPayment.TabIndex = 1;
            this.txtDownPayment.Text = "0.00";
            this.txtDownPayment.Click += new System.EventHandler(this.TxtDownPayment_Click);
            this.txtDownPayment.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtDownPayment.Leave += new System.EventHandler(this.TxtDownPayment_Leave);
            // 
            // txtBalanceInput
            // 
            this.txtBalanceInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceInput.Location = new System.Drawing.Point(156, 5);
            this.txtBalanceInput.MaxLength = 12;
            this.txtBalanceInput.Name = "txtBalanceInput";
            this.txtBalanceInput.Size = new System.Drawing.Size(125, 29);
            this.txtBalanceInput.TabIndex = 0;
            this.txtBalanceInput.Text = "0.00";
            this.txtBalanceInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBalanceInput_MouseClick);
            this.txtBalanceInput.TextChanged += new System.EventHandler(this.TxtBalanceInput_TextChanged);
            this.txtBalanceInput.Leave += new System.EventHandler(this.TxtBalanceInput_Leave);
            // 
            // lblTwentyFive
            // 
            this.lblTwentyFive.AutoSize = true;
            this.lblTwentyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTwentyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTwentyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTwentyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwentyFive.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTwentyFive.Location = new System.Drawing.Point(311, 367);
            this.lblTwentyFive.Name = "lblTwentyFive";
            this.lblTwentyFive.Size = new System.Drawing.Size(43, 23);
            this.lblTwentyFive.TabIndex = 24;
            this.lblTwentyFive.Text = "25%";
            this.lblTwentyFive.Click += new System.EventHandler(this.LblTwentyFive_Click);
            // 
            // lblSeventyFive
            // 
            this.lblSeventyFive.AutoSize = true;
            this.lblSeventyFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeventyFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeventyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeventyFive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeventyFive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSeventyFive.Location = new System.Drawing.Point(311, 139);
            this.lblSeventyFive.Name = "lblSeventyFive";
            this.lblSeventyFive.Size = new System.Drawing.Size(43, 23);
            this.lblSeventyFive.TabIndex = 23;
            this.lblSeventyFive.Text = "75%";
            this.lblSeventyFive.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(320, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "0%";
            // 
            // lblFifty
            // 
            this.lblFifty.AutoSize = true;
            this.lblFifty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFifty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFifty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFifty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifty.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFifty.Location = new System.Drawing.Point(311, 254);
            this.lblFifty.Name = "lblFifty";
            this.lblFifty.Size = new System.Drawing.Size(43, 23);
            this.lblFifty.TabIndex = 21;
            this.lblFifty.Text = "50%";
            this.lblFifty.Click += new System.EventHandler(this.LblFifty_Click);
            // 
            // lblOneHundo
            // 
            this.lblOneHundo.AutoSize = true;
            this.lblOneHundo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOneHundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOneHundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOneHundo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneHundo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOneHundo.Location = new System.Drawing.Point(305, 24);
            this.lblOneHundo.Name = "lblOneHundo";
            this.lblOneHundo.Size = new System.Drawing.Size(49, 23);
            this.lblOneHundo.TabIndex = 20;
            this.lblOneHundo.Text = "100%";
            this.lblOneHundo.Click += new System.EventHandler(this.LblOneHundo_Click);
            // 
            // chkSettlement
            // 
            this.chkSettlement.AutoSize = true;
            this.chkSettlement.Enabled = false;
            this.chkSettlement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSettlement.Location = new System.Drawing.Point(287, 3);
            this.chkSettlement.Name = "chkSettlement";
            this.chkSettlement.Size = new System.Drawing.Size(110, 25);
            this.chkSettlement.TabIndex = 19;
            this.chkSettlement.Text = "Settlement";
            this.chkSettlement.UseVisualStyleBackColor = true;
            // 
            // chkPPA
            // 
            this.chkPPA.AutoSize = true;
            this.chkPPA.Enabled = false;
            this.chkPPA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPPA.Location = new System.Drawing.Point(8, 61);
            this.chkPPA.Name = "chkPPA";
            this.chkPPA.Size = new System.Drawing.Size(126, 25);
            this.chkPPA.TabIndex = 18;
            this.chkPPA.Text = "Payment Plan";
            this.chkPPA.UseVisualStyleBackColor = true;
            // 
            // slideSIFpercentage
            // 
            this.slideSIFpercentage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.slideSIFpercentage.Location = new System.Drawing.Point(352, 25);
            this.slideSIFpercentage.Maximum = 100;
            this.slideSIFpercentage.Minimum = 1;
            this.slideSIFpercentage.Name = "slideSIFpercentage";
            this.slideSIFpercentage.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.slideSIFpercentage.Size = new System.Drawing.Size(45, 475);
            this.slideSIFpercentage.TabIndex = 3;
            this.slideSIFpercentage.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.slideSIFpercentage.Value = 100;
            this.slideSIFpercentage.ValueChanged += new System.EventHandler(this.SlideSIFpercentage_ValueChanged_1);
            this.slideSIFpercentage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SlideSIFpercentage_MouseDown);
            // 
            // lblPercentSymbol
            // 
            this.lblPercentSymbol.AutoSize = true;
            this.lblPercentSymbol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentSymbol.Location = new System.Drawing.Point(165, 37);
            this.lblPercentSymbol.Name = "lblPercentSymbol";
            this.lblPercentSymbol.Size = new System.Drawing.Size(27, 21);
            this.lblPercentSymbol.TabIndex = 15;
            this.lblPercentSymbol.Text = "%:";
            // 
            // lblRemainingPmtCount
            // 
            this.lblRemainingPmtCount.AutoSize = true;
            this.lblRemainingPmtCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPmtCount.Location = new System.Drawing.Point(152, 143);
            this.lblRemainingPmtCount.Name = "lblRemainingPmtCount";
            this.lblRemainingPmtCount.Size = new System.Drawing.Size(16, 21);
            this.lblRemainingPmtCount.TabIndex = 8;
            this.lblRemainingPmtCount.Text = "1";
            this.lblRemainingPmtCount.TextChanged += new System.EventHandler(this.LblRemainingPmtCount_TextChanged);
            // 
            // lblPCR
            // 
            this.lblPCR.AutoSize = true;
            this.lblPCR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCR.Location = new System.Drawing.Point(4, 143);
            this.lblPCR.Name = "lblPCR";
            this.lblPCR.Size = new System.Drawing.Size(143, 21);
            this.lblPCR.TabIndex = 7;
            this.lblPCR.Text = "Installment Count:";
            // 
            // lblRemainingBal
            // 
            this.lblRemainingBal.AutoSize = true;
            this.lblRemainingBal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBal.Location = new System.Drawing.Point(177, 120);
            this.lblRemainingBal.Name = "lblRemainingBal";
            this.lblRemainingBal.Size = new System.Drawing.Size(41, 21);
            this.lblRemainingBal.TabIndex = 6;
            this.lblRemainingBal.Text = "0.00";
            this.lblRemainingBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemBal
            // 
            this.lblRemBal.AutoSize = true;
            this.lblRemBal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemBal.Location = new System.Drawing.Point(4, 120);
            this.lblRemBal.Name = "lblRemBal";
            this.lblRemBal.Size = new System.Drawing.Size(151, 21);
            this.lblRemBal.TabIndex = 5;
            this.lblRemBal.Text = "Remaining Balance:";
            // 
            // lblDownPmt
            // 
            this.lblDownPmt.AutoSize = true;
            this.lblDownPmt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPmt.Location = new System.Drawing.Point(4, 89);
            this.lblDownPmt.Name = "lblDownPmt";
            this.lblDownPmt.Size = new System.Drawing.Size(123, 21);
            this.lblDownPmt.TabIndex = 4;
            this.lblDownPmt.Text = "Down Payment:";
            // 
            // lblSifBalance
            // 
            this.lblSifBalance.AutoSize = true;
            this.lblSifBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifBalance.Location = new System.Drawing.Point(213, 37);
            this.lblSifBalance.Name = "lblSifBalance";
            this.lblSifBalance.Size = new System.Drawing.Size(41, 21);
            this.lblSifBalance.TabIndex = 3;
            this.lblSifBalance.Text = "0.00";
            this.lblSifBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSIFpercent
            // 
            this.lblSIFpercent.AutoSize = true;
            this.lblSIFpercent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIFpercent.Location = new System.Drawing.Point(137, 37);
            this.lblSIFpercent.Name = "lblSIFpercent";
            this.lblSIFpercent.Size = new System.Drawing.Size(34, 21);
            this.lblSIFpercent.TabIndex = 2;
            this.lblSIFpercent.Text = "100";
            // 
            // lblSettlementRate
            // 
            this.lblSettlementRate.AutoSize = true;
            this.lblSettlementRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettlementRate.Location = new System.Drawing.Point(4, 37);
            this.lblSettlementRate.Name = "lblSettlementRate";
            this.lblSettlementRate.Size = new System.Drawing.Size(132, 21);
            this.lblSettlementRate.TabIndex = 1;
            this.lblSettlementRate.Text = "Settlement Rate:";
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.Location = new System.Drawing.Point(4, 8);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(129, 21);
            this.lblCurrentBal.TabIndex = 0;
            this.lblCurrentBal.Text = "Current Balance:";
            // 
            // pnlPPA
            // 
            this.pnlPPA.Controls.Add(this.lblPMTSREM);
            this.pnlPPA.Controls.Add(this.lblInstallmentAmt);
            this.pnlPPA.Controls.Add(this.lblRemainingBalanceNotification);
            this.pnlPPA.Controls.Add(this.lblRemainder);
            this.pnlPPA.Controls.Add(this.lblTtlPay);
            this.pnlPPA.Controls.Add(this.lblTotalPaymentCount);
            this.pnlPPA.Location = new System.Drawing.Point(2, 209);
            this.pnlPPA.Name = "pnlPPA";
            this.pnlPPA.Size = new System.Drawing.Size(300, 75);
            this.pnlPPA.TabIndex = 41;
            // 
            // lblPMTSREM
            // 
            this.lblPMTSREM.AutoSize = true;
            this.lblPMTSREM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMTSREM.Location = new System.Drawing.Point(3, 0);
            this.lblPMTSREM.Name = "lblPMTSREM";
            this.lblPMTSREM.Size = new System.Drawing.Size(158, 21);
            this.lblPMTSREM.TabIndex = 9;
            this.lblPMTSREM.Text = "Installment Amount:";
            // 
            // lblInstallmentAmt
            // 
            this.lblInstallmentAmt.AutoSize = true;
            this.lblInstallmentAmt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentAmt.Location = new System.Drawing.Point(163, 0);
            this.lblInstallmentAmt.Name = "lblInstallmentAmt";
            this.lblInstallmentAmt.Size = new System.Drawing.Size(41, 21);
            this.lblInstallmentAmt.TabIndex = 10;
            this.lblInstallmentAmt.Text = "0.00";
            // 
            // lblRemainingBalanceNotification
            // 
            this.lblRemainingBalanceNotification.AutoSize = true;
            this.lblRemainingBalanceNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalanceNotification.Location = new System.Drawing.Point(3, 21);
            this.lblRemainingBalanceNotification.Name = "lblRemainingBalanceNotification";
            this.lblRemainingBalanceNotification.Size = new System.Drawing.Size(114, 21);
            this.lblRemainingBalanceNotification.TabIndex = 11;
            this.lblRemainingBalanceNotification.Text = "Final Payment:";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainder.Location = new System.Drawing.Point(163, 21);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(41, 21);
            this.lblRemainder.TabIndex = 12;
            this.lblRemainder.Text = "0.00";
            this.lblRemainder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTtlPay
            // 
            this.lblTtlPay.AutoSize = true;
            this.lblTtlPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlPay.Location = new System.Drawing.Point(3, 42);
            this.lblTtlPay.Name = "lblTtlPay";
            this.lblTtlPay.Size = new System.Drawing.Size(123, 21);
            this.lblTtlPay.TabIndex = 13;
            this.lblTtlPay.Text = "Total Payments:";
            // 
            // lblTotalPaymentCount
            // 
            this.lblTotalPaymentCount.AutoSize = true;
            this.lblTotalPaymentCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentCount.Location = new System.Drawing.Point(124, 42);
            this.lblTotalPaymentCount.Name = "lblTotalPaymentCount";
            this.lblTotalPaymentCount.Size = new System.Drawing.Size(16, 21);
            this.lblTotalPaymentCount.TabIndex = 14;
            this.lblTotalPaymentCount.Text = "1";
            // 
            // rtxtNotate
            // 
            this.rtxtNotate.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotate.Location = new System.Drawing.Point(11, 210);
            this.rtxtNotate.Name = "rtxtNotate";
            this.rtxtNotate.Size = new System.Drawing.Size(691, 285);
            this.rtxtNotate.TabIndex = 1;
            this.rtxtNotate.Text = "";
            // 
            // monthCalendarDP
            // 
            this.monthCalendarDP.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2019, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2019, 7, 4, 0, 0, 0, 0),
        new System.DateTime(2019, 11, 11, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 24, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 31, 0, 0, 0, 0)};
            this.monthCalendarDP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarDP.Location = new System.Drawing.Point(11, 38);
            this.monthCalendarDP.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.monthCalendarDP.MaxSelectionCount = 365;
            this.monthCalendarDP.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendarDP.Name = "monthCalendarDP";
            this.monthCalendarDP.TabIndex = 35;
            this.monthCalendarDP.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInstallmentLabel);
            this.panel1.Controls.Add(this.monthCalendarInstallmentStart);
            this.panel1.Controls.Add(this.label_downPaymentDate);
            this.panel1.Controls.Add(this.rtxtNotate);
            this.panel1.Controls.Add(this.monthCalendarDP);
            this.panel1.Location = new System.Drawing.Point(416, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 504);
            this.panel1.TabIndex = 36;
            // 
            // lblInstallmentLabel
            // 
            this.lblInstallmentLabel.AutoSize = true;
            this.lblInstallmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentLabel.Location = new System.Drawing.Point(260, 9);
            this.lblInstallmentLabel.Name = "lblInstallmentLabel";
            this.lblInstallmentLabel.Size = new System.Drawing.Size(195, 25);
            this.lblInstallmentLabel.TabIndex = 39;
            this.lblInstallmentLabel.Text = "INSTALLMENT START";
            this.lblInstallmentLabel.Visible = false;
            // 
            // monthCalendarInstallmentStart
            // 
            this.monthCalendarInstallmentStart.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2019, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2019, 7, 4, 0, 0, 0, 0),
        new System.DateTime(2019, 11, 11, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 24, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2019, 12, 31, 0, 0, 0, 0)};
            this.monthCalendarInstallmentStart.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendarInstallmentStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarInstallmentStart.Location = new System.Drawing.Point(244, 38);
            this.monthCalendarInstallmentStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.monthCalendarInstallmentStart.MaxSelectionCount = 365;
            this.monthCalendarInstallmentStart.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendarInstallmentStart.Name = "monthCalendarInstallmentStart";
            this.monthCalendarInstallmentStart.TabIndex = 38;
            this.monthCalendarInstallmentStart.TabStop = false;
            this.monthCalendarInstallmentStart.Visible = false;
            // 
            // label_downPaymentDate
            // 
            this.label_downPaymentDate.AutoSize = true;
            this.label_downPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_downPaymentDate.Location = new System.Drawing.Point(16, 9);
            this.label_downPaymentDate.Name = "label_downPaymentDate";
            this.label_downPaymentDate.Size = new System.Drawing.Size(215, 25);
            this.label_downPaymentDate.TabIndex = 37;
            this.label_downPaymentDate.Text = "DOWN PAYMENT DATE";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(1139, 379);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(369, 46);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // dataGridPPA
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPPA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pmtDate,
            this.pmtAmount});
            this.dataGridPPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPPA.Location = new System.Drawing.Point(0, 0);
            this.dataGridPPA.Name = "dataGridPPA";
            this.dataGridPPA.Size = new System.Drawing.Size(369, 341);
            this.dataGridPPA.TabIndex = 0;
            this.dataGridPPA.TabStop = false;
            this.dataGridPPA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridPPA_RowsRemoved);
            // 
            // pmtDate
            // 
            this.pmtDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pmtDate.HeaderText = "Date";
            this.pmtDate.Name = "pmtDate";
            // 
            // pmtAmount
            // 
            this.pmtAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pmtAmount.HeaderText = "Amount";
            this.pmtAmount.Name = "pmtAmount";
            // 
            // pnlPaymentPlan
            // 
            this.pnlPaymentPlan.Controls.Add(this.dataGridPPA);
            this.pnlPaymentPlan.Location = new System.Drawing.Point(1139, 28);
            this.pnlPaymentPlan.Name = "pnlPaymentPlan";
            this.pnlPaymentPlan.Size = new System.Drawing.Size(369, 341);
            this.pnlPaymentPlan.TabIndex = 37;
            // 
            // btnNotateToLog
            // 
            this.btnNotateToLog.Enabled = false;
            this.btnNotateToLog.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotateToLog.Location = new System.Drawing.Point(1139, 431);
            this.btnNotateToLog.Name = "btnNotateToLog";
            this.btnNotateToLog.Size = new System.Drawing.Size(369, 46);
            this.btnNotateToLog.TabIndex = 38;
            this.btnNotateToLog.Text = "Add Payments to Notation";
            this.btnNotateToLog.UseVisualStyleBackColor = true;
            this.btnNotateToLog.Click += new System.EventHandler(this.BtnNotateToLog_Click);
            // 
            // lblBIN
            // 
            this.lblBIN.AutoSize = true;
            this.lblBIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBIN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBIN.Location = new System.Drawing.Point(1139, 487);
            this.lblBIN.Name = "lblBIN";
            this.lblBIN.Size = new System.Drawing.Size(101, 21);
            this.lblBIN.TabIndex = 39;
            this.lblBIN.Text = "BIN Number";
            this.lblBIN.Click += new System.EventHandler(this.LblDebug_Click);
            // 
            // lblDebug2
            // 
            this.lblDebug2.AutoSize = true;
            this.lblDebug2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDebug2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug2.Location = new System.Drawing.Point(1139, 510);
            this.lblDebug2.Name = "lblDebug2";
            this.lblDebug2.Size = new System.Drawing.Size(164, 21);
            this.lblDebug2.TabIndex = 40;
            this.lblDebug2.Text = "Card Number Format";
            // 
            // paymentPlanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1520, 544);
            this.Controls.Add(this.lblDebug2);
            this.Controls.Add(this.lblBIN);
            this.Controls.Add(this.btnNotateToLog);
            this.Controls.Add(this.pnlPaymentPlan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDataEntry);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paymentPlanCalculator";
            this.Text = "Payment Plan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlDataEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRemainingPmtCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideSIFpercentage)).EndInit();
            this.pnlPPA.ResumeLayout(false);
            this.pnlPPA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPPA)).EndInit();
            this.pnlPaymentPlan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TrackBar slideSIFpercentage;
        public System.Windows.Forms.TextBox txtBalanceInput;
        public System.Windows.Forms.TextBox txtDownPayment;
        public System.Windows.Forms.Label lblRemainingPmtCount;
        public System.Windows.Forms.Label lblRMG;
        public System.Windows.Forms.TrackBar sliderRemainingPmtCount;
        public System.Windows.Forms.Label lblInstallmentAmt;
        public System.Windows.Forms.Label lblRemainder;
        public System.Windows.Forms.Label lblRemainingBal;
        public System.Windows.Forms.Label lblTotalPaymentCount;
        public System.Windows.Forms.Label lblSifBalance;
        public System.Windows.Forms.Label lblSIFpercent;
        public System.Windows.Forms.CheckBox chkSettlement;
        public System.Windows.Forms.CheckBox chkPPA;
        public System.Windows.Forms.ComboBox dropDownPayCycle;
        public System.Windows.Forms.MonthCalendar monthCalendarDP;
        public System.Windows.Forms.TextBox txtCreditCardNumber;
        public System.Windows.Forms.Label lblCreditCardNumber;
        public System.Windows.Forms.Label lblCardValid;
        public System.Windows.Forms.Label lblCardType;
        public System.Windows.Forms.Label lblPMTSREM;
        public System.Windows.Forms.TextBox txtCVV;
        public System.Windows.Forms.ComboBox cboxExpMonth;
        public System.Windows.Forms.ComboBox cboxExpYear;
        public System.Windows.Forms.MonthCalendar monthCalendarInstallmentStart;
        public System.Windows.Forms.Label lblTwentyFive;
        public System.Windows.Forms.Label lblSeventyFive;
        public System.Windows.Forms.Label lblFifty;
        public System.Windows.Forms.Label lblOneHundo;
        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.Panel pnlDataEntry;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public System.Windows.Forms.Label lblPercentSymbol;
        public System.Windows.Forms.Label lblTtlPay;
        public System.Windows.Forms.Label lblRemainingBalanceNotification;
        public System.Windows.Forms.Label lblPCR;
        public System.Windows.Forms.Label lblRemBal;
        public System.Windows.Forms.Label lblDownPmt;
        public System.Windows.Forms.Label lblSettlementRate;
        public System.Windows.Forms.Label lblCurrentBal;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblDollarSign;
        public System.Windows.Forms.Label lblDollarSign5;
        public System.Windows.Forms.Label lblDollarSign4;
        public System.Windows.Forms.RichTextBox rtxtNotate;
        public System.Windows.Forms.Button btnValidate;
        public System.Windows.Forms.Panel pnlPPA;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridPPA;
        public System.Windows.Forms.DataGridViewTextBoxColumn pmtDate;
        public System.Windows.Forms.DataGridViewTextBoxColumn pmtAmount;
        public System.Windows.Forms.Panel pnlPaymentPlan;
        public System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Label label_downPaymentDate;
        public System.Windows.Forms.Label lblInstallmentLabel;
        public System.Windows.Forms.ToolStripSeparator toolStripButton1;
        public System.Windows.Forms.ToolStripDropDownButton toolStripExport;
        public System.Windows.Forms.ToolStripMenuItem apSheetExportButton;
        public System.Windows.Forms.Button btnNotateToLog;
        public System.Windows.Forms.Label lblBIN;
        public System.Windows.Forms.Label lblDebug2;
        public System.Windows.Forms.Label lblSeventy;
        public System.Windows.Forms.Label lblFiftyFive;
        public System.Windows.Forms.Label lblSixty;
        public System.Windows.Forms.Label lblSixtyFive;
        public System.Windows.Forms.Label lblNinetyFive;
        public System.Windows.Forms.Label lblEighty;
        public System.Windows.Forms.Label lblEightyFive;
        public System.Windows.Forms.Label lblNinety;
        public System.Windows.Forms.TextBox txtSifPercentOverwrite;
        public System.Windows.Forms.TextBox txtSIFAmountOverwrite;
    }
}

