﻿namespace PaymentPlanCalculator
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardValid = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.rtxtNotate = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDollarSign5 = new System.Windows.Forms.Label();
            this.lblDollarSign4 = new System.Windows.Forms.Label();
            this.dropDownPayCycle = new System.Windows.Forms.ComboBox();
            this.lblDollarSign3 = new System.Windows.Forms.Label();
            this.lblDollarSign2 = new System.Windows.Forms.Label();
            this.lblRMG = new System.Windows.Forms.Label();
            this.sliderRemainingPmtCount = new System.Windows.Forms.TrackBar();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBalanceInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOneHundo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkSIF = new System.Windows.Forms.CheckBox();
            this.slideSIFpercentage = new System.Windows.Forms.TrackBar();
            this.lblPercentDollar = new System.Windows.Forms.Label();
            this.lblTotalPaymentCount = new System.Windows.Forms.Label();
            this.lblTtlPay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRemainingBalanceNotification = new System.Windows.Forms.Label();
            this.lblInstallmentAmt = new System.Windows.Forms.Label();
            this.lblPMTSREM = new System.Windows.Forms.Label();
            this.lblRemainingPmtCount = new System.Windows.Forms.Label();
            this.lblPCR = new System.Windows.Forms.Label();
            this.lblRemainingBal = new System.Windows.Forms.Label();
            this.lblRemBal = new System.Windows.Forms.Label();
            this.lblDownPmt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSIFpercent = new System.Windows.Forms.Label();
            this.lblSettlementRate = new System.Windows.Forms.Label();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRemainingPmtCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideSIFpercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1302, 25);
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
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDataEntry.Controls.Add(this.lblCardType);
            this.pnlDataEntry.Controls.Add(this.lblCardValid);
            this.pnlDataEntry.Controls.Add(this.btnValidate);
            this.pnlDataEntry.Controls.Add(this.lblCreditCardNumber);
            this.pnlDataEntry.Controls.Add(this.txtCreditCardNumber);
            this.pnlDataEntry.Controls.Add(this.rtxtNotate);
            this.pnlDataEntry.Controls.Add(this.monthCalendar1);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign5);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign4);
            this.pnlDataEntry.Controls.Add(this.dropDownPayCycle);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign3);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign2);
            this.pnlDataEntry.Controls.Add(this.lblRMG);
            this.pnlDataEntry.Controls.Add(this.sliderRemainingPmtCount);
            this.pnlDataEntry.Controls.Add(this.lblDollarSign);
            this.pnlDataEntry.Controls.Add(this.textBox1);
            this.pnlDataEntry.Controls.Add(this.txtBalanceInput);
            this.pnlDataEntry.Controls.Add(this.label16);
            this.pnlDataEntry.Controls.Add(this.label3);
            this.pnlDataEntry.Controls.Add(this.label2);
            this.pnlDataEntry.Controls.Add(this.label1);
            this.pnlDataEntry.Controls.Add(this.lblOneHundo);
            this.pnlDataEntry.Controls.Add(this.checkBox1);
            this.pnlDataEntry.Controls.Add(this.chkSIF);
            this.pnlDataEntry.Controls.Add(this.slideSIFpercentage);
            this.pnlDataEntry.Controls.Add(this.lblPercentDollar);
            this.pnlDataEntry.Controls.Add(this.lblTotalPaymentCount);
            this.pnlDataEntry.Controls.Add(this.lblTtlPay);
            this.pnlDataEntry.Controls.Add(this.label13);
            this.pnlDataEntry.Controls.Add(this.lblRemainingBalanceNotification);
            this.pnlDataEntry.Controls.Add(this.lblInstallmentAmt);
            this.pnlDataEntry.Controls.Add(this.lblPMTSREM);
            this.pnlDataEntry.Controls.Add(this.lblRemainingPmtCount);
            this.pnlDataEntry.Controls.Add(this.lblPCR);
            this.pnlDataEntry.Controls.Add(this.lblRemainingBal);
            this.pnlDataEntry.Controls.Add(this.lblRemBal);
            this.pnlDataEntry.Controls.Add(this.lblDownPmt);
            this.pnlDataEntry.Controls.Add(this.label4);
            this.pnlDataEntry.Controls.Add(this.lblSIFpercent);
            this.pnlDataEntry.Controls.Add(this.lblSettlementRate);
            this.pnlDataEntry.Controls.Add(this.lblCurrentBal);
            this.pnlDataEntry.Location = new System.Drawing.Point(12, 29);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(1278, 503);
            this.pnlDataEntry.TabIndex = 1;
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(264, 399);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(0, 21);
            this.lblCardType.TabIndex = 40;
            // 
            // lblCardValid
            // 
            this.lblCardValid.AutoSize = true;
            this.lblCardValid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardValid.Location = new System.Drawing.Point(109, 427);
            this.lblCardValid.Name = "lblCardValid";
            this.lblCardValid.Size = new System.Drawing.Size(52, 21);
            this.lblCardValid.TabIndex = 39;
            this.lblCardValid.Text = "Valid?";
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(8, 389);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(254, 31);
            this.btnValidate.TabIndex = 38;
            this.btnValidate.Text = "VALIDATE";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(4, 323);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(204, 21);
            this.lblCreditCardNumber.TabIndex = 37;
            this.lblCreditCardNumber.Text = "Credit/Debit Card Number";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.AllowDrop = true;
            this.txtCreditCardNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtCreditCardNumber.Location = new System.Drawing.Point(8, 346);
            this.txtCreditCardNumber.MaxLength = 20;
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(254, 36);
            this.txtCreditCardNumber.TabIndex = 36;
            this.txtCreditCardNumber.TextChanged += new System.EventHandler(this.TxtCreditCardNumber_TextChanged);
            // 
            // rtxtNotate
            // 
            this.rtxtNotate.Location = new System.Drawing.Point(403, 320);
            this.rtxtNotate.Name = "rtxtNotate";
            this.rtxtNotate.Size = new System.Drawing.Size(684, 175);
            this.rtxtNotate.TabIndex = 2;
            this.rtxtNotate.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(403, 5);
            this.monthCalendar1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 120;
            this.monthCalendar1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 35;
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
            this.dropDownPayCycle.Location = new System.Drawing.Point(6, 282);
            this.dropDownPayCycle.Name = "dropDownPayCycle";
            this.dropDownPayCycle.Size = new System.Drawing.Size(256, 38);
            this.dropDownPayCycle.TabIndex = 32;
            this.dropDownPayCycle.Text = "PAY CYCLE";
            // 
            // lblDollarSign3
            // 
            this.lblDollarSign3.AutoSize = true;
            this.lblDollarSign3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign3.Location = new System.Drawing.Point(152, 237);
            this.lblDollarSign3.Name = "lblDollarSign3";
            this.lblDollarSign3.Size = new System.Drawing.Size(19, 21);
            this.lblDollarSign3.TabIndex = 31;
            this.lblDollarSign3.Text = "$";
            // 
            // lblDollarSign2
            // 
            this.lblDollarSign2.AutoSize = true;
            this.lblDollarSign2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign2.Location = new System.Drawing.Point(111, 216);
            this.lblDollarSign2.Name = "lblDollarSign2";
            this.lblDollarSign2.Size = new System.Drawing.Size(19, 21);
            this.lblDollarSign2.TabIndex = 30;
            this.lblDollarSign2.Text = "$";
            // 
            // lblRMG
            // 
            this.lblRMG.AutoSize = true;
            this.lblRMG.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMG.Location = new System.Drawing.Point(224, 143);
            this.lblRMG.Name = "lblRMG";
            this.lblRMG.Size = new System.Drawing.Size(87, 21);
            this.lblRMG.TabIndex = 29;
            this.lblRMG.Text = "Remaining";
            // 
            // sliderRemainingPmtCount
            // 
            this.sliderRemainingPmtCount.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sliderRemainingPmtCount.LargeChange = 1;
            this.sliderRemainingPmtCount.Location = new System.Drawing.Point(8, 168);
            this.sliderRemainingPmtCount.Maximum = 11;
            this.sliderRemainingPmtCount.Name = "sliderRemainingPmtCount";
            this.sliderRemainingPmtCount.Size = new System.Drawing.Size(303, 45);
            this.sliderRemainingPmtCount.TabIndex = 28;
            this.sliderRemainingPmtCount.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 86);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 29);
            this.textBox1.TabIndex = 26;
            // 
            // txtBalanceInput
            // 
            this.txtBalanceInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceInput.Location = new System.Drawing.Point(156, 5);
            this.txtBalanceInput.MaxLength = 6;
            this.txtBalanceInput.Name = "txtBalanceInput";
            this.txtBalanceInput.Size = new System.Drawing.Size(125, 29);
            this.txtBalanceInput.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(311, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "25%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(311, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "75%";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(311, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "50%";
            // 
            // lblOneHundo
            // 
            this.lblOneHundo.AutoSize = true;
            this.lblOneHundo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOneHundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOneHundo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneHundo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOneHundo.Location = new System.Drawing.Point(305, 31);
            this.lblOneHundo.Name = "lblOneHundo";
            this.lblOneHundo.Size = new System.Drawing.Size(49, 23);
            this.lblOneHundo.TabIndex = 20;
            this.lblOneHundo.Text = "100%";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(287, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 25);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Settlement";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkSIF
            // 
            this.chkSIF.AutoSize = true;
            this.chkSIF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSIF.Location = new System.Drawing.Point(8, 61);
            this.chkSIF.Name = "chkSIF";
            this.chkSIF.Size = new System.Drawing.Size(126, 25);
            this.chkSIF.TabIndex = 18;
            this.chkSIF.Text = "Payment Plan";
            this.chkSIF.UseVisualStyleBackColor = true;
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
            this.slideSIFpercentage.TabIndex = 16;
            this.slideSIFpercentage.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.slideSIFpercentage.Value = 100;
            // 
            // lblPercentDollar
            // 
            this.lblPercentDollar.AutoSize = true;
            this.lblPercentDollar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentDollar.Location = new System.Drawing.Point(165, 37);
            this.lblPercentDollar.Name = "lblPercentDollar";
            this.lblPercentDollar.Size = new System.Drawing.Size(52, 21);
            this.lblPercentDollar.TabIndex = 15;
            this.lblPercentDollar.Text = "%:    $";
            // 
            // lblTotalPaymentCount
            // 
            this.lblTotalPaymentCount.AutoSize = true;
            this.lblTotalPaymentCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentCount.Location = new System.Drawing.Point(125, 258);
            this.lblTotalPaymentCount.Name = "lblTotalPaymentCount";
            this.lblTotalPaymentCount.Size = new System.Drawing.Size(16, 21);
            this.lblTotalPaymentCount.TabIndex = 14;
            this.lblTotalPaymentCount.Text = "1";
            // 
            // lblTtlPay
            // 
            this.lblTtlPay.AutoSize = true;
            this.lblTtlPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlPay.Location = new System.Drawing.Point(4, 258);
            this.lblTtlPay.Name = "lblTtlPay";
            this.lblTtlPay.Size = new System.Drawing.Size(123, 21);
            this.lblTtlPay.TabIndex = 13;
            this.lblTtlPay.Text = "Total Payments:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "0.00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemainingBalanceNotification
            // 
            this.lblRemainingBalanceNotification.AutoSize = true;
            this.lblRemainingBalanceNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalanceNotification.Location = new System.Drawing.Point(4, 237);
            this.lblRemainingBalanceNotification.Name = "lblRemainingBalanceNotification";
            this.lblRemainingBalanceNotification.Size = new System.Drawing.Size(151, 21);
            this.lblRemainingBalanceNotification.TabIndex = 11;
            this.lblRemainingBalanceNotification.Text = "Balance Remaining:";
            // 
            // lblInstallmentAmt
            // 
            this.lblInstallmentAmt.AutoSize = true;
            this.lblInstallmentAmt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentAmt.Location = new System.Drawing.Point(125, 216);
            this.lblInstallmentAmt.Name = "lblInstallmentAmt";
            this.lblInstallmentAmt.Size = new System.Drawing.Size(41, 21);
            this.lblInstallmentAmt.TabIndex = 10;
            this.lblInstallmentAmt.Text = "0.00";
            // 
            // lblPMTSREM
            // 
            this.lblPMTSREM.AutoSize = true;
            this.lblPMTSREM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMTSREM.Location = new System.Drawing.Point(4, 216);
            this.lblPMTSREM.Name = "lblPMTSREM";
            this.lblPMTSREM.Size = new System.Drawing.Size(105, 21);
            this.lblPMTSREM.TabIndex = 9;
            this.lblPMTSREM.Text = "Payments of:";
            // 
            // lblRemainingPmtCount
            // 
            this.lblRemainingPmtCount.AutoSize = true;
            this.lblRemainingPmtCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPmtCount.Location = new System.Drawing.Point(199, 143);
            this.lblRemainingPmtCount.Name = "lblRemainingPmtCount";
            this.lblRemainingPmtCount.Size = new System.Drawing.Size(19, 21);
            this.lblRemainingPmtCount.TabIndex = 8;
            this.lblRemainingPmtCount.Text = "0";
            // 
            // lblPCR
            // 
            this.lblPCR.AutoSize = true;
            this.lblPCR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCR.Location = new System.Drawing.Point(4, 143);
            this.lblPCR.Name = "lblPCR";
            this.lblPCR.Size = new System.Drawing.Size(189, 21);
            this.lblPCR.TabIndex = 7;
            this.lblPCR.Text = "Payment Count Request:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "0.00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // paymentPlanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 544);
            this.Controls.Add(this.pnlDataEntry);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public System.Windows.Forms.TrackBar slideSIFpercentage;
        private System.Windows.Forms.Label lblPercentDollar;
        private System.Windows.Forms.Label lblTtlPay;
        private System.Windows.Forms.Label lblRemainingBalanceNotification;
        private System.Windows.Forms.Label lblPMTSREM;
        private System.Windows.Forms.Label lblPCR;
        private System.Windows.Forms.Label lblRemBal;
        private System.Windows.Forms.Label lblDownPmt;
        private System.Windows.Forms.Label lblSettlementRate;
        private System.Windows.Forms.Label lblCurrentBal;
        public System.Windows.Forms.TextBox txtBalanceInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOneHundo;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDollarSign;
        public System.Windows.Forms.Label lblRemainingPmtCount;
        public System.Windows.Forms.Label lblRMG;
        public System.Windows.Forms.TrackBar sliderRemainingPmtCount;
        public System.Windows.Forms.Label lblInstallmentAmt;
        private System.Windows.Forms.Label lblDollarSign2;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblRemainingBal;
        private System.Windows.Forms.Label lblDollarSign3;
        public System.Windows.Forms.Label lblTotalPaymentCount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblSIFpercent;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox chkSIF;
        private System.Windows.Forms.Label lblDollarSign5;
        private System.Windows.Forms.Label lblDollarSign4;
        public System.Windows.Forms.ComboBox dropDownPayCycle;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox rtxtNotate;
        public System.Windows.Forms.TextBox txtCreditCardNumber;
        public System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Button btnValidate;
        public System.Windows.Forms.Label lblCardValid;
        public System.Windows.Forms.Label lblCardType;
    }
}

