using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


/* TO DO LIST...
 * ADD YEAR CODE FOR EXP DATE
 * IMPLIMENT BIN NUMBER BANK INFORMATION
 * IMPLIMENT HOLIDAY INFORMATION
 * ADD VALIDATION CODE FOR CVV
 */

namespace PaymentPlanCalculator
{
    public partial class paymentPlanCalculator : Form
    {
        // Create array to test for invalid characters (invalidChars)
        public readonly string[] invalidChars = { " ", "`", "-", "!", "#", "$", "%", "&", "(", ")", "*", "/", ":", ";", "@", "[", "\\", "]", "^", "_", "{", "|", "}", "~", "+",
            "<", "=", ">", "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O",
            "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z", "Z", "\"", "\'", "?" };
        public string RemoveNonNumeric(string input)
        {
            // 80 invalid characters, 80 indexes in array
            for (int i = 0; i < 83; i++) // i represents index for invalidChars
            {
                input = input.Replace(invalidChars[i], "");
            }
            return input;
        }

        // TEMPORARY SOLUTION, REPLACE WITH ACTUAL SAVE BUTTON
        public void saveButton()
        {
            MessageBox.Show("Save button not currently functional");
            /*
            txtBalanceInput.Text = "1,100.00";
            txtCreditCardNumber.Text = "4567456745614561";
            txtCVV.Text = "456";
            txtDownPayment.Text = "100.00";
            sliderRemainingPmtCount.Value = 11;
            slideSIFpercentage.Value = 75;
            cboxExpMonth.Text = "12";
            cboxExpYear.Text = "2020";
            dropDownPayCycle.ValueMember = "WEEKLY";
            */
        }

        /* **************** *
         *   CARD PARSING   *
         * **************** */
        public string ParseCard(string cardString)
        {
            if (txtCreditCardNumber.Text.Length == 16) // VISA MC and DISCOVER
            {
                cardString = txtCreditCardNumber.Text;
                int numberOfDigits = txtCreditCardNumber.Text.Length;
                string firstFour = cardString.Substring(0, 4);
                string secondfFour = cardString.Substring(4, 4);
                string thirdFour = cardString.Substring(8, 4);
                string fourthFour = cardString.Substring(12, 4);
                string cardNumberFormatted = $"{firstFour} {secondfFour} {thirdFour} {fourthFour}";
                return cardNumberFormatted;
            }
            else if (txtCreditCardNumber.Text.Length == 15) // AMEX 3234 123456 12345
            {
                cardString = txtCreditCardNumber.Text;
                int numberOfDigits = txtCreditCardNumber.Text.Length;
                string firstFour = cardString.Substring(0, 4);
                string secondfFour = cardString.Substring(4, 6);
                string thirdFour = cardString.Substring(10, 5);
                string cardNumberFormatted = $"{firstFour} {secondfFour} {thirdFour}";
                return cardNumberFormatted;
            }
            else
            {
                cardString = "";
                return cardString;
            }
        }
        public string ParseBIN(string cardString)
        {
            if (txtCreditCardNumber.Text.Length < 15 || txtCreditCardNumber.Text.Length > 16)
            {
                txtCreditCardNumber.Clear();
                //lblBIN.Text = "FIX CARD NUMBER";
                MessageBox.Show("Card number is wrong length\nPlease try again");
                string binNumber = "FIX CARD NUMBER"; //cardString.Substring(0, 6);
                return (binNumber);
            }
            else
            {
                cardString = txtCreditCardNumber.Text;
                int numberOfDigits = txtCreditCardNumber.Text.Length;
                string binNumber = cardString.Substring(0, 6); //---------------------------------------------------------------------------------- Throw exception if no CC Number in this place
                return (binNumber);
            }
        }
        string binNumber; // Instantiate BIN variable string
        string formattedCard; // Instantiate Formatted Card String

        public static bool IsValidCurrency(string currencyValue)
        {
            string pattern = @"\p{Sc}+\s*\d+";
            return Regex.IsMatch(currencyValue, pattern);
        }

        public paymentPlanCalculator()
        {
            InitializeComponent();
        }

        // Test for payments being deleted
        bool paymentsDeleted = false;
        public void AddPaymentInfoToNotation()
        {
            // Add Payment Info Into Notation Log
            if (paymentsDeleted == false)
            {
                try
                {
                    string paymentPlan = rtxtNotate.Text;
                    //Test IF statement here
                    for (int i = 0; i < Convert.ToInt16(lblTotalPaymentCount.Text); i++)
                    {
                        paymentPlan += "\n";
                        paymentPlan += dataGridPPA.Rows[i].Cells[0].Value.ToString();
                        paymentPlan += " - ";
                        paymentPlan += dataGridPPA.Rows[i].Cells[1].Value.ToString();
                    }
                    //Add Credit Card Information
                    //paymentPlan += "\n" + "\n" + dropDownPayCycle.Text + "\n"; // Moved to Header
                    paymentPlan += "\n\n" + lblCardType.Text + " - " + lblCardValid.Text + "\n"; // Visa - Valid
                    paymentPlan += ParseCard(txtCreditCardNumber.Text) + "\n"; // 4000100020003004
                    //paymentPlan += cboxExpMonth.Text + "/" + cboxExpYear.Text + "\n"; // 01/2021
                    paymentPlan += cboxExpMonth.Text + "/" + cboxExpYear.Text + "       " + "CVV: " + txtCVV.Text + "\n"; // 01/2021  CVV: 234


                    //paymentPlan += "CVV: " + txtCVV.Text + "\n"; // 234
                    rtxtNotate.Text = paymentPlan; // Post PPA to Notation Log
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Populate PPA Grid First");
                    //throw;
                }
            }
            else if (paymentsDeleted == true)
            {
                try
                {
                    // This re-populates the data grid after rows have been deleted
                    string paymentPlan = rtxtNotate.Text;
                    for (int i = 0; i < (dataGridPPA.Rows.Count - 1); i++)
                    {
                        paymentPlan += "\n";
                        paymentPlan += dataGridPPA.Rows[i].Cells[0].Value.ToString();
                        paymentPlan += " - ";
                        paymentPlan += dataGridPPA.Rows[i].Cells[1].Value.ToString();
                    }
                    //Add Credit Card Information
                    paymentPlan += "\n" + "\n" + dropDownPayCycle.Text + "\n"; // PayCycle
                    paymentPlan += "\n" + lblCardType.Text + " - " + lblCardValid.Text + "\n"; // Visa - Valid
                    paymentPlan += txtCreditCardNumber.Text + "\n"; // 4000100020003004
                    paymentPlan += cboxExpMonth.Text + "/" + cboxExpYear.Text + "\n"; // 01/2021
                    paymentPlan += "CVV: " + txtCVV.Text + "\n"; // 234
                    rtxtNotate.Text = paymentPlan; // Post PPA to Notation Log
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Populate PPA Grid First");
                }
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            AddYearsToExpDate(); // When form loads, add years to exp date (in progress)
        }

        public void AddYearsToExpDate()
        {
            // CREATE AN ARRAY TO CALCULATE UPTO 10 YEARS INTO THE FUTURE FOR EXPDATE
        }

        /* ********************** *
         *    MAKE FIELD BLINK    *
         * ********************** */
        public void Blink()
        {
            dropDownPayCycle.Select();
            dropDownPayCycle.BackColor = Color.Yellow;
        }

        public void UpdateAll() // Method of all other methods (not sure if this works)
        {
            
            CalculateRemainingBalance();
            TestForPPA();
            CalculateSIF();
            DisplayPPAInfo();
            PaymentCount();
            CalculateNotations();
            CalculateInstallmentPayments();
            TestForRemainder();
            InstallmentCalendar();
            ZeroInstallmentCheck();
        }

        public void ZeroInstallmentCheck()
        {
            if (lblRemainingPmtCount.Text == "0" && txtDownPayment.Text != "0.00" &&
                ((Convert.ToDecimal(txtDownPayment.Text)) < (Convert.ToDecimal(txtBalanceInput.Text))))
            {
                sliderRemainingPmtCount.Value = 1;
            }
            /*
            if installment count is 0 and down payment < current balance
            update installment count to 1
            */
        }

        public void BinAPI() // ADD FUNCTIONALITY - RESOURCES FOR API INTEGRATION AND NUGET PACKAGES
        {
            // https://www.youtube.com/watch?v=aWePkE2ReGw // Tim Correy
            // https://www.youtube.com/watch?v=aMkQe9JrV-k // Newton API
            // BIN API https://www.freebinchecker.com/bin-api // Actual Website
            // BIN API Example https://api.freebinchecker.com/bin/370245 // Use to test
        }

        /* ********************************** *
         *     ARRAY PAYMENT DATE CREATION    *
         * ********************************** */
        #region // Payment date creation
        DateTime[] PPADates { get; set; } //Set payment dates on a global level
        public void CreateInstallmentDates(int payCycle)
        {
            //int payCycle; // Initialize Integer for PayCycle Days
            int numberOfPayments = Convert.ToInt16(lblTotalPaymentCount.Text); // Set number of payments
            DateTime downPaymentDate = monthCalendarDP.SelectionStart;
            DateTime[] paymentPlanDates = new DateTime[numberOfPayments];
            //DateTime[] paymentPlanDates = new DateTime[numberOfPayments];
            paymentPlanDates[0] = downPaymentDate;

            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 12)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
                DateTime seventhInstallmentDate = sixthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[7] = seventhInstallmentDate; // 8 Payments
                DateTime eighthInstallmentDate = seventhInstallmentDate.AddDays(payCycle);
                paymentPlanDates[8] = eighthInstallmentDate; // 9 Payments
                DateTime ninethInstallmentDate = eighthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[9] = ninethInstallmentDate; // 10 Payments
                DateTime tenthInstallmentDate = ninethInstallmentDate.AddDays(payCycle);
                paymentPlanDates[10] = tenthInstallmentDate; // 11 Payments
                DateTime eleventhInstallmentDate = tenthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[11] = eleventhInstallmentDate; // 12 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 11)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
                DateTime seventhInstallmentDate = sixthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[7] = seventhInstallmentDate; // 8 Payments
                DateTime eighthInstallmentDate = seventhInstallmentDate.AddDays(payCycle);
                paymentPlanDates[8] = eighthInstallmentDate; // 9 Payments
                DateTime ninethInstallmentDate = eighthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[9] = ninethInstallmentDate; // 10 Payments
                DateTime tenthInstallmentDate = ninethInstallmentDate.AddDays(payCycle);
                paymentPlanDates[10] = tenthInstallmentDate; // 11 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 10)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
                DateTime seventhInstallmentDate = sixthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[7] = seventhInstallmentDate; // 8 Payments
                DateTime eighthInstallmentDate = seventhInstallmentDate.AddDays(payCycle);
                paymentPlanDates[8] = eighthInstallmentDate; // 9 Payments
                DateTime ninethInstallmentDate = eighthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[9] = ninethInstallmentDate; // 10 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 9)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
                DateTime seventhInstallmentDate = sixthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[7] = seventhInstallmentDate; // 8 Payments
                DateTime eighthInstallmentDate = seventhInstallmentDate.AddDays(payCycle);
                paymentPlanDates[8] = eighthInstallmentDate; // 9 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 8)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
                DateTime seventhInstallmentDate = sixthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[7] = seventhInstallmentDate; // 8 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 7)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
                DateTime sixthInstallmentDate = fifthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[6] = sixthInstallmentDate; // 7 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 6)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
                DateTime fifthInstallmentDate = fourthInstallmentDate.AddDays(payCycle);
                paymentPlanDates[5] = fifthInstallmentDate; // 6 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 5)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
                DateTime fourthInstallmentDate = thirdInstallmentDate.AddDays(payCycle);
                paymentPlanDates[4] = fourthInstallmentDate; // 5 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 4)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
                DateTime thirdInstallmentDate = secondInstallmentDate.AddDays(payCycle);
                paymentPlanDates[3] = thirdInstallmentDate; // 4 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 3)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
                DateTime secondInstallmentDate = firstInstallmentDate.AddDays(payCycle);
                paymentPlanDates[2] = secondInstallmentDate; // 3 Payments
            }
            if (Convert.ToInt16(lblTotalPaymentCount.Text) == 2)
            {
                DateTime firstInstallmentDate = monthCalendarInstallmentStart.SelectionStart;
                paymentPlanDates[1] = firstInstallmentDate; // 2 Payments
            }
            PPADates = paymentPlanDates; // Set Local array to Global Array
        }
        #endregion

        public void CalculatePaymentDates() // Call to CreateInstallmentDates() Method with pay-cycle taken into account
        {
            /* ********************************* *
             *   CALL DATES BASED ON PAY CYCLE   *
             * ********************************* */

            if (dropDownPayCycle.Text == "WEEKLY")
            {
                CreateInstallmentDates(7);
            }
            else if (dropDownPayCycle.Text == "BI-WEEKLY")
            {
                CreateInstallmentDates(14);
            }
            else if (dropDownPayCycle.Text == "SEMI-MONTHLY")
            {
                CreateInstallmentDates(15);
            }
            else if (dropDownPayCycle.Text == "MONTHLY")
            {
                CreateInstallmentDates(30);
            }
            else
            {
                CreateInstallmentDates(1);
            }
        }

        public void InstallmentCalendar() // Make the installment calendar visible or invisible
        {
            if (lblRemainingBal.Text == "0.00" )
            {
                monthCalendarInstallmentStart.Visible = false;
                lblInstallmentLabel.Visible = false;
            }
            else if (lblRemainingBal.Text != "0.00" )
            {
                monthCalendarInstallmentStart.Visible = true;
                lblInstallmentLabel.Visible = true;
            }
            else if (Convert.ToDouble(lblRemainingBal.Text) <= 0 || Convert.ToDouble(lblInstallmentAmt.Text) <= 0)
            {
                monthCalendarInstallmentStart.Visible = false;
                lblInstallmentLabel.Visible = false;
            }
        }

        public void CalculateSIF() // Calculate Settlement based on slider
        {
            // Calculate Settlement
            lblSifBalance.Text = (Convert.ToDouble(txtBalanceInput.Text) * (slideSIFpercentage.Value * 0.01)).ToString("C");
        }

            public void DisplayPPAInfo()
        {
            lblRemainingPmtCount.Text = sliderRemainingPmtCount.Value.ToString(); // Set installment count to slider value
                                                                                  // Show or hide PPA info based on if PPA exists as set
            if (sliderRemainingPmtCount.Value > 0)
            {
                pnlPPA.Visible = true;
            }
            else
            {
                chkPPA.Checked = false;
                pnlPPA.Visible = false;
            }

            if (txtDownPayment.Text == "0.00")
            {
                lblTotalPaymentCount.Text = sliderRemainingPmtCount.Value.ToString();
            }
            else
            {
                lblTotalPaymentCount.Text = (sliderRemainingPmtCount.Value + 1).ToString();
            }
        }
        public void CalculateInstallmentPayments()
        {
            decimal currentBalance = Convert.ToDecimal(txtBalanceInput.Text); // Current Balance
            decimal settlementBalance = Convert.ToDecimal(Convert.ToString(currentBalance).Replace("$", "")) * (Convert.ToDecimal(slideSIFpercentage.Value) / 100);
            decimal downPayment = Convert.ToDecimal(txtDownPayment.Text); // Down Payment
            decimal installmentCount = sliderRemainingPmtCount.Value; // Installment Count
            decimal balanceAfterDP = settlementBalance - downPayment; // Balance After Down Payment
            decimal installmentAmount; // Define Installment Amount Variable
            if (installmentCount > 0) // Prevent divide by Zero error
            {
                installmentAmount = Math.Round((balanceAfterDP / installmentCount), 2); // Installment Amount
            }
            else
            {
                installmentAmount = 0; // Installment amount for 0 installments
            }
            // Calculate Final Payment
            decimal remainderPayment = Math.Round((balanceAfterDP - (installmentAmount * (installmentCount - 1))), 2); // Final Payment (Remainder)
            // Using Rich Text box as a 'Console' for debugging

            rtxtNotate.Text = ($"Balance: {currentBalance.ToString("C")}" +
                $" | Settlement Balance: {settlementBalance.ToString("C")} ({slideSIFpercentage.Value.ToString()}%)" +
                $"\nTotal Payments: {lblTotalPaymentCount.Text} | {dropDownPayCycle.Text}" +
                $"\nDown Payment: {downPayment.ToString("C")}" +
                $" | Remaining Due: {balanceAfterDP.ToString("C")}" +
                $"\n{installmentCount.ToString()}" +
                $"x installments: {installmentAmount.ToString("C")}");
                if (installmentAmount != remainderPayment)
                    {
                        rtxtNotate.Text +=
                        $" (Final Payment: {remainderPayment.ToString("C")})" +
                        $"\n";
                    }
                else
                    {
                        rtxtNotate.Text +=
                        $"\n";
                    };
                
            // Installment labels to formatted numbers            
            lblInstallmentAmt.Text = installmentAmount.ToString("C"); // ToString("C") converts to currency
            lblRemainder.Text = remainderPayment.ToString("C");

        }

        public void TestForRemainder()
        {
            if (Convert.ToDouble(lblTotalPaymentCount.Text) < 2) // If total payment count is less than 2
            {
                lblRemainingBalanceNotification.Visible = false; // Hide remainder labels
                lblRemainder.Visible = false;
            }
            else if (lblRemainder.Text == lblInstallmentAmt.Text) // If installment and remainder are the same
            {
                lblRemainingBalanceNotification.Visible = false; // Hide remainder
                lblRemainder.Visible = false;
            }
            else if (lblRemainder.Text != lblInstallmentAmt.Text) // If remainder does not match installment amount
            {
                lblRemainingBalanceNotification.Visible = true; // Show remainder
                lblRemainder.Visible = true;
            }
            else if (Convert.ToDouble(lblRemainder.Text) == Convert.ToDouble(lblInstallmentAmt.Text))
            {
                lblRemainingBalanceNotification.Visible = false;
                lblRemainder.Visible = false;
            }
            else // This should never have to be used
            {
                lblRemainingBalanceNotification.Visible = true;
                lblRemainder.Visible = true;
            }
        }

        public void TestForPPA()
        {
            if (Convert.ToDouble(lblTotalPaymentCount.Text) > 1)
            {
                chkPPA.Checked = true;
            }
            else
            {
                chkPPA.Checked = false;
            }
        }
        
        public void CalculateRemainingBalance()
        {
            try
            {
                decimal currentBalance = Convert.ToDecimal(txtBalanceInput.Text);
                decimal downPayment = Convert.ToDecimal(txtDownPayment.Text);
                decimal settlementAmount = Convert.ToDecimal(txtBalanceInput.Text) * ((Convert.ToDecimal(slideSIFpercentage.Value) / 100));
                decimal sifAfterDownPayment = settlementAmount - downPayment;
                decimal pmtAfterDownPayent = currentBalance - downPayment;
                // These statements are mostly for error handling for checkboxes
                if (chkSettlement.Checked == true)
                {
                    lblRemainingBal.Text = sifAfterDownPayment.ToString("N");
                }
                else if (chkSettlement.Checked == false)
                {
                    lblRemainingBal.Text = pmtAfterDownPayent.ToString("N");
                }
                else
                {
                    txtDownPayment.Text = "0.00";
                    txtBalanceInput.Text = currentBalance.ToString("C");
                    lblRemainingBal.Text = txtBalanceInput.Text;
                }
            }
            catch (Exception)
            {
                txtDownPayment.Text = "0.00";
            }
        }

        /* ******************************************** *
         *            CALCULATE NOTATIONS               *
         * ******************************************** */
        public void CalculateNotations() //WORKING ON AS OF SUNDAY 5/26/2019 AT NOON
        {
            // Current Balance
            string notationOverview = $"Dbtr owes ${txtBalanceInput.Text:C}";
            // // Debtor owes $1,234.56

            /* All possible scenarios */




        /* CHECK FOR CARD NUMBER */
            if (txtCreditCardNumber.Text != "")
            {
                notationOverview += $"\nDbtr is using {lblCardType.Text} card. Card number is {txtCreditCardNumber.Text}";
            }
            // // Dbtr is using Visa card. Card number is 4444555566667777

        /* PRINT NOTATION IN RICH TEXT BOX */
            rtxtNotate.Text = notationOverview;
        }

        /* ****************************************** *
         *             Count all Payments             *
         * ****************************************** */

        //CREATE RULE TO ACCOUNT FOR PAYMENT COUNT SLIDER BEING SET TO 0 PAYMENTS

        public void PaymentCount()
        {
            double totalPaymentCount = 0; // This will be the 'Master Variable' in this Method

            /* ****************************************** *
             *          Down Payment Calculation          *
             * ****************************************** */

            // Test if there is a down payment and then add to the total paymeent count

            // Is there a down payment to use for the calculation?
            // -Yes? downPaymentCount is 1
            // -No? downPaymentCount is 0

            double downPaymentCount;
            if (txtDownPayment.Text != "0.00")
            {
                downPaymentCount = 1;
            }
            else if (Convert.ToDouble(txtDownPayment.Text) == 0)
            {
                downPaymentCount = 0;
            }
            else
            {
                downPaymentCount = 1; // This should never be used
            }

            // Add 1 to totalPaymentCount if downPaymentCount = 1
            if (downPaymentCount == 1)
            {
                totalPaymentCount += downPaymentCount;
            }
            else
            {
                totalPaymentCount += downPaymentCount; // This should never be used
            }

            // Calculate total payment count
            totalPaymentCount =+ downPaymentCount + sliderRemainingPmtCount.Value;
            lblTotalPaymentCount.Text = totalPaymentCount.ToString(); // Method works
        }

        /* ******************************************************* *
         *             Luhn Method for CC Verification             *
         * ******************************************************* */
        public static bool Luhn(string digits)
        {
            return digits.All(char.IsDigit) && digits.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0
                    ? thisNum
                    : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum)
                ).Sum() % 10 == 0;
        }

        /* ****************************************** *
         *             Card Type Validation           *
         * ****************************************** */
        public void CardType(string cardType)
        {
            if (txtCreditCardNumber.Text.Length > 0)
            {
                cardType = txtCreditCardNumber.Text.Substring(0, 1);
            }
            else
            {
                cardType = "0";
            }

            if (cardType == "0")
            {
                cardType = "null";
            }
            else if (cardType == "3" && txtCreditCardNumber.Text.Length == 15)
            {
                cardType = "AMEX";
            }
            else if (cardType == "4")
            {
                cardType = "VISA";
            }
            else if (cardType == "5")
            {
                cardType = "MASTERCARD";
            }
            else if (cardType == "6")
            {
                cardType = "DISCOVER";
            }
            else
            {
                cardType = "INVALID";
            }
            lblCardType.Text = cardType;
        }

        /* ******************************************** *
         *             Test Card Validation             *
         * ******************************************** */
        public void Button1_Click(object sender, EventArgs e)
        {
            string creditCardNumber = txtCreditCardNumber.Text;
            CardType(creditCardNumber);
            //add check for card length
            if (Luhn(creditCardNumber))
            {
                lblCardValid.BackColor = Color.White;
                lblCardValid.ForeColor = Color.Green;
                lblCardValid.Text = "VALID!";
            }
            else
            {
                lblCardValid.BackColor = Color.White;
                lblCardValid.ForeColor = Color.Red;
                lblCardValid.Text = "INVALID!";
            }
            #region Old Antiquated Notation Code
            /* ******************************************** *
             *            CALCULATE NOTATIONS               *
             * ******************************************** */

            /* MAP OUT THE REST OF THIS AND RE-DO IT FROM BEGINNING FOLLOWING PATTERN ... closes at line 317
            /* ****************** *
             *   NOTATE ACCOUNT   *
             * ****************** *

            // Account Notation
            // Current Balance
            string notationOverview = $"Dbtr owes ${txtBalanceInput.Text:C}";

            // // Debtor owes $1,234.56

            // Account Notation
            // SIF Yes/No
            if (chkSettlement.Checked == true) // If SIF box is checked, add SIF info to notation
            {
                notationOverview += $"\n{slideSIFpercentage.Value}% SIF authorized for {((slideSIFpercentage.Value * 0.01) * Convert.ToDouble(txtBalanceInput.Text)).ToString("C")}";
            }
            else // State that there is no SIF authorized
            {
                notationOverview += $"\nno SIF authorized";
            }

            // // 75% SIF authorized
            // // no SIF authorized

            // Account Notation
            // PPA Yes/No
            if (chkPPA.Checked == true && chkSettlement.Checked == false) // If PPA Box is checked, add PPA info to notation
            {
                notationOverview += $"\nPPA Authorized over {lblTotalPaymentCount.Text} payments";
            }
            // // PPA Authorized over 3 payments

            else if (chkPPA.Checked == false && txtDownPayment.Text != "0.00") // If PPA box is not checked BUT down payment IS entered
            {
                if (chkSettlement.Checked == true) // and there is a settlement
                {
                    notationOverview += $"\nto be paid in 2 payments\nDown payment of ${txtDownPayment.Text}\nRemaining SIF balance of " +
                        $"{((((slideSIFpercentage.Value * 0.01) * Convert.ToDouble(txtBalanceInput.Text)) - Convert.ToDouble(txtDownPayment.Text)).ToString("C"))}";
                }
                else // and there is no settlement
                {
                    notationOverview += $"\nto be paid in 2 payments";
                }
            }
            else if (chkPPA.Checked == true && chkSettlement.Checked == true) // If PPA and SIF are both checked, add to notation
            {
                notationOverview += $"\nto be paid in {sliderRemainingPmtCount.Value} payments\nDown payment of ${txtDownPayment.Text}\nRemaining SIF balance of " +
                        $"{((((slideSIFpercentage.Value * 0.01) * Convert.ToDouble(txtBalanceInput.Text)) - Convert.ToDouble(txtDownPayment.Text)).ToString("C"))}";
            }
            else // If no PPA, decide if it is BIF or SIF and notate as such (Nested IF/ELSE)
            {
                notationOverview += $"\nto be paid in 1 payment "; // No PPA means 1 payment

                // // to be paid in 1 payment

                if (slideSIFpercentage.Value == 100) // If settlement is 100%, state balance in full
                {
                    notationOverview += $"for balance in full of ${txtBalanceInput.Text:C}";
                }
                else // If SIF = true, state SIF amount
                {
                    notationOverview += $"for {slideSIFpercentage.Value}% SIF of {lblSifBalance:C}";
                }

                // // for the balance in full of $1,234.56
                // // for 75%
            }
            // Account Notation
            // Down Payment Yes/No
            if (txtDownPayment.Text != "0.00") // If there is a down payment then (Follow nested tree to check if installment = remainder amount)

                // Yes, down payment (nested statement)
            {
                if (lblInstallmentAmt.Text != lblRemainder.Text) // If DP = true and If installment and remainder are different, display notation as follows:
                {
                    notationOverview += $"\nDown payment of ${txtDownPayment.Text:C} \nto leave a remaining balance of ${lblRemainingBal.Text:C}" +
                    $"\nover {(sliderRemainingPmtCount.Value - 1)} payments of {lblInstallmentAmt.Text:C} and 1 " +
                    $"final payment of {lblRemainder.Text:C}";
                }
                // // Down payment of $250.56 to leave a remaining balance of $984.00
                // // // over 3 payments of 246.02 and 1 final payment of $245.94
                // // // (This is not an actual example, just the concept)
                else // If installment and remainder are the same, display notation as follows:
                {
                    if (chkPPA.Checked == false && chkSettlement.Checked == false) // If installment and remainder are the same with no PPA or SIF
                    {
                        notationOverview += $"\nDown payment of ${txtDownPayment.Text:C} to leave a remaining balance of ${lblRemainingBal.Text:C}";
                    }
                    else if (chkPPA.Checked == true && chkSettlement.Checked == false)
                    {
                        notationOverview += $"\nDown payment of ${txtDownPayment.Text:C} to leave a remaining balance of ${lblRemainingBal.Text:C}" +
                        $"\nover {sliderRemainingPmtCount.Value} payments of {lblInstallmentAmt.Text:C}";
                    }
                    else if (chkPPA.Checked == true && chkSettlement.Checked == true)
                    {
                        notationOverview += $"\nDown payment of ${txtDownPayment.Text:C} \nRemaining SIF balance of " +
                        $"{((((slideSIFpercentage.Value * 0.01) * Convert.ToDouble(txtBalanceInput.Text)) - Convert.ToDouble(txtDownPayment.Text)).ToString("C"))}" +
                        $"\nover {sliderRemainingPmtCount.Value} payments of {lblInstallmentAmt.Text:C}";
                    }
                    else
                    {
                        // Nothing
                    }
                }
                // // Down payment of $250.56 to leave a remaining balance of $984.00
                // // // over 4 payments of $246.00
            }
            else // If there is no down payment
            {
                if (lblInstallmentAmt.Text != lblRemainder.Text) // If installment and remainder are different, display notation as follows:
                {
                    notationOverview += $"\nover { (Convert.ToDouble(lblTotalPaymentCount.Text) - 1)} payments of {lblInstallmentAmt.Text:C} " +
                    $"and 1 final payment of {lblRemainder.Text:C}";
                }
                // // over 3 payments of 309.00 and 1 final payment of $307.56
                else // If installment and remainder are the same
                {
                    if (lblInstallmentAmt.Text == "0.00") // If there is no down payment, the installment and remainder are the same, and they are both "0.00"
                                                          // Example: $2500 down, no down payment, no settlement. (Prevents "over 1 payments of 0.00 " from being added)
                    {
                        // notationOverview += $"\n [ON SELECTED PAYMENT DATE];  //UPDATE THIS ONCE DATES ARE IMPLIMENTED
                    }
                    else
                    {
                        notationOverview += $"\nover {Convert.ToDouble(lblTotalPaymentCount.Text)} payments of {lblInstallmentAmt.Text:C} ";
                    }
                    // // over 4 payments of $308.64
                }
            }
            */

            // OLD NOTATION CALCULATED CODE TO BE DELETED COLLAPSED //THIS WHOLE SECTION NEEDS TO BE DELETED AFTER WORKING VERSION SET

            //FOR TESTING PURPOSES- clicking validate calculates payments and prints notations
            //THESE 'CALL TO METHODS' may need to be moved
            #endregion
            lblBIN.Text = ParseBIN(txtCreditCardNumber.Text); // BIN NUMBER
            binNumber = lblBIN.Text;
            lblDebug2.Text = ParseCard(txtCreditCardNumber.Text); // CARD NUMBER
            formattedCard = lblDebug2.Text;

            UpdateAll();
        }

        public void PopulateDataGrid() // THESE ALL NEED THE ADDRESSES TO ADD
        {
            dataGridPPA.Rows.Clear();
            CalculatePaymentDates(); // Call to calculate dates
            int numberOfPayments = Convert.ToInt16(lblTotalPaymentCount.Text);

            /* ************************* *
             * With Down Payment and PPA *
             * DP and PPA W/ or W/O SIF  *
             * ************************* */ 
            if (txtDownPayment.Text != "0.00" && lblInstallmentAmt.Text != "0.00" && sliderRemainingPmtCount.Value > 1) // If PPA has down payment and PPA
            {
                dataGridPPA.Rows.Add(); // Add row
                dataGridPPA["pmtDate", 0].Value = monthCalendarDP.SelectionStart.ToShortDateString(); // Which date is selected (set it to a string)
                dataGridPPA["pmtAmount", 0].Value = String.Format("${0:00}", txtDownPayment.Text); // Take payment amount in Down Payment and add to grid
                // FILL THE INSTALLMENT PAYMENTS
                for (int ppaRow = 1; ppaRow < (numberOfPayments - 1); ppaRow++) // Select second row
                {
                    dataGridPPA.Rows.Add(); // Add row
                    dataGridPPA["pmtDate", ppaRow].Value = PPADates[ppaRow].ToShortDateString(); // Select Date from PPA Dates Array
                    dataGridPPA["pmtAmount", ppaRow].Value = lblInstallmentAmt.Text; // Set installment amount to sting
                }
                // FILL THE FINAL INSTALLMENT PAYMENT
                dataGridPPA.Rows.Add(); // Add final row // Error when not set to schedule - Likely Fixed
                dataGridPPA["pmtDate", numberOfPayments - 1].Value = PPADates[numberOfPayments - 1].ToShortDateString(); // Select Final Date from PPA Date Array
                dataGridPPA["pmtAmount", numberOfPayments - 1].Value = lblRemainder.Text; // Adds remainder amount (after date in previous row)
            }

            /* *********************************** *
             * Down Payment and then Final Payment *
             * *********************************** */
            else if (txtDownPayment.Text != "0.00" && sliderRemainingPmtCount.Value == 1) // If PPA has down payment and no PPA - DOWN PAYMENT and FINAL PAYMENT
            {
                // ADD DOWN PAYMENT
                dataGridPPA.Rows.Add(); // Add row
                dataGridPPA["pmtDate", 0].Value = monthCalendarDP.SelectionStart.ToShortDateString(); // Set row 1 as first selection
                dataGridPPA["pmtAmount", 0].Value = String.Format("${0:00}", txtDownPayment.Text); // Set first payment (Down Payment)

                // FILL THE FINAL INSTALLMENT PAYMENT
                dataGridPPA.Rows.Add(); // Add final row
                dataGridPPA["pmtDate", (numberOfPayments - 1)].Value = monthCalendarInstallmentStart.SelectionStart.ToShortDateString(); // numberOfPayments - 1 sets final row
                dataGridPPA["pmtAmount", (numberOfPayments - 1)].Value = (Convert.ToDecimal(txtBalanceInput.Text) - Convert.ToDecimal(txtDownPayment.Text)).ToString("C");
            }

            /* *********************************** *
             * Down Payment and then Final Payment *
             *           Slider at Zeros           *
             * *********************************** */
            else if (txtDownPayment.Text != "0.00" && sliderRemainingPmtCount.Value == 0) // If PPA With Slider of Zero
            {
                // ADD DOWN PAYMENT
                dataGridPPA.Rows.Add(); // Add row
                dataGridPPA["pmtDate", 0].Value = monthCalendarDP.SelectionStart.ToShortDateString(); // Set row 1 as first selection
                dataGridPPA["pmtAmount", 0].Value = String.Format("${0:00}", txtDownPayment.Text); // Set first payment (Down Payment)

                // FILL THE FINAL INSTALLMENT PAYMENT
                dataGridPPA.Rows.Add(); // Add final row
                dataGridPPA["pmtDate", 1].Value = monthCalendarInstallmentStart.SelectionStart.ToShortDateString(); // numberOfPayments - 1 sets final row
                dataGridPPA["pmtAmount", 1].Value = ((Convert.ToDecimal(txtBalanceInput.Text) * (Convert.ToDecimal(slideSIFpercentage.Value) / 100))
                    - Convert.ToDecimal(txtDownPayment.Text)).ToString("C"); //THROWS ERROR
            }

            /* *********************************** *
             *      No Down Payment, yes PPA       *
             * *********************************** */
            else if (txtDownPayment.Text == "0.00" && lblInstallmentAmt.Text != "0.00" && sliderRemainingPmtCount.Value != 0) // If PPA has down payment and PPA
            {
                // FILL THE INSTALLMENT PAYMENTS
                for (int ppaRow = 0; ppaRow < (numberOfPayments - 1); ppaRow++) // Select second row
                {
                    dataGridPPA.Rows.Add(); // Add row
                    dataGridPPA["pmtDate", ppaRow].Value = PPADates[ppaRow].ToShortDateString(); // Select Date from PPA Dates Array
                    dataGridPPA["pmtAmount", ppaRow].Value = lblInstallmentAmt.Text; // Set installment amount to sting
                }
                // FILL THE FINAL INSTALLMENT PAYMENT
                dataGridPPA.Rows.Add(); // Add final row
                dataGridPPA["pmtDate", (numberOfPayments - 1)].Value = PPADates[(numberOfPayments - 1)].ToShortDateString(); // Select Date from PPA Dates Array
                dataGridPPA["pmtAmount", (numberOfPayments - 1)].Value = lblRemainder.Text; // Adds remainder amount (after date in previous row)
            }

            /* *********************************** *
             *  Down Payment, Ramaining as Final   *
             * *********************************** */
            else if (sliderRemainingPmtCount.Value == 1 && ((Convert.ToDouble(txtDownPayment.Text)) < (Convert.ToDouble(txtBalanceInput.Text))))
            {
                // ADD DOWN PAYMENT
                dataGridPPA.Rows.Add(); // Add row
                dataGridPPA["pmtDate", 0].Value = monthCalendarDP.SelectionStart.ToShortDateString(); // Set row 1 as first selection
                dataGridPPA["pmtAmount", 0].Value = String.Format("${0:00}", txtDownPayment.Text); // Set first payment (Down Payment)

                // FILL THE FINAL INSTALLMENT PAYMENT
                dataGridPPA.Rows.Add(); // Add final row
                dataGridPPA["pmtDate", 1].Value = monthCalendarInstallmentStart.SelectionStart.ToShortDateString(); // numberOfPayments - 1 sets final row
                dataGridPPA["pmtAmount", 1].Value = ((Convert.ToDecimal(txtBalanceInput.Text) * (Convert.ToDecimal(slideSIFpercentage.Value) / 100))
                    - Convert.ToDecimal(txtDownPayment.Text)).ToString("C");
            }            
        }

        public void TxtCreditCardNumber_TextChanged(object sender, EventArgs e)
        {
            string creditCardNumber = txtCreditCardNumber.Text;
            txtCreditCardNumber.Text = Regex.Replace(creditCardNumber, @"[^0-9]", "");
            // After Space Cursor to End of TxtBox
            // Keep the cursor at the end (prevent snapping to beginning)
            txtCreditCardNumber.Select(txtCreditCardNumber.Text.Length + 1, 0);
        }

        /* ******************************************* *
         *             Calculate Settlement            *
         * ******************************************* */
        public void SlideSIFpercentage_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateAll();
            if (slideSIFpercentage.Value < 100)
            {
                chkSettlement.Checked = true;
            }
            else
            {
                chkSettlement.Checked = false;
            }

            // Takes the User Input current balance (AGAIN) and sets the curBalNum variable as a 'decimal' type

            if (Convert.ToDecimal(txtBalanceInput.Text) < 0)
            {
                slideSIFpercentage.Value = 100;
                txtBalanceInput.Text = "0.00";
                string alertError = "Enter a balance first";
                string alertTitle = "Balance is Blank";
                MessageBox.Show(alertError, alertTitle);
            }
            else
            {
                string curBal = txtBalanceInput.Text;
                decimal curBalNum = Convert.ToDecimal(curBal);
                // Define 2 variables, sifPercent (actual decimal value as percentage) and sifPercentNumber (Convert to string for label on UI)
                decimal sifPercentNumber = slideSIFpercentage.Value;//converting decimal to int seems to work
                decimal sifPercent = (sifPercentNumber / 100);
                lblSIFpercent.Text = Convert.ToString(sifPercentNumber);
                // Set the SIF balance formatted as USD
                decimal settlementAmount = (curBalNum * sifPercent);
                lblSifBalance.Text = (settlementAmount).ToString("C");
            }
        }

        /* **************************************************** *
         *   Fixes Null Value Balance Error on Mouse Click      *
         * **************************************************** */
        public void SlideSIFpercentage_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtBalanceInput.Text == "")
            {
                txtBalanceInput.Text = "0.00";
            }
            else
            {
                decimal curBalNum = Convert.ToDecimal(txtBalanceInput.Text);
            }
        }

        /* **************************************************** *
         *              Current Balance Textbox                 *
         *          Validate Inputs to Prevent Crashing         *
         * **************************************************** */

        /* **************************************************** *
         *    Calc Remaining Balance based on SIF Checkbox      *
         * **************************************************** */
        public void TextBox1_TextChanged(object sender, EventArgs e) // Current Balance Textbox
        {
            UpdateAll();
            //CalculateSIF();
            /* ************************************************ *
             *    Allow UserInput in Down Payment Text Box      *
             * ************************************************ */

            // Prevents first character being entered from being '.' or ','
            txtDownPayment.Text = txtDownPayment.Text.TrimStart('.', ',');

            // Uses method to prevent non-numeric which crashes app
            txtDownPayment.Text = RemoveNonNumeric(txtDownPayment.Text);
            // Move cursor to far right 
            txtDownPayment.Select(txtDownPayment.Text.Length, 0);

            // Test for blank field and replace with $0.00
            if (txtDownPayment.Text == "")
            {
                txtDownPayment.Text = "0.00";
            }
            if (txtDownPayment.Text == "0.00")
            {
                txtDownPayment.SelectAll();
            }
        }

        /* *************************************************** *
         *    Calculate PPA Based on Installment Slider        *
         * *************************************************** */
        public void SliderRemainingPmtCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        /* **************************************************** *
         *     Change UI Text based on Number of Payments       *
         * **************************************************** */
        public void LblRemainingPmtCount_TextChanged(object sender, EventArgs e)
        {
            // Set label for Payment(s) to singular for 1 payment for correct grammar
            if (lblRemainingPmtCount.Text == "1")
            {
                lblRMG.Text = "Payment";
            }
            else
            {
                // Makes 0, 2-11 all plural
                lblRMG.Text = "Payments";
            }
        }

        /* ***************************************************** *
         *      Format Balance Input to 2 Decimal Places         *
         * ***************************************************** */
        public void TxtBalanceInput_Leave(object sender, EventArgs e)
        {
            if (txtBalanceInput.Text == "")
            {
                txtBalanceInput.Text = "0.00";
            }
            else
            {
                try
                {
                    decimal formattedBalInput = Convert.ToDecimal(txtBalanceInput.Text);
                    // ToString("N") converts to number to 2 decimal places according to Format syntax
                    txtBalanceInput.Text = String.Format("{0:00}", formattedBalInput.ToString("N"));
                }
                catch (Exception)
                {
                    txtBalanceInput.Text = "0.00";
                    //throw;
                }
            }
            UpdateAll();
        }

        /* **************************************************** *
         *    Format Down Payment Input to 2 Decimal Places     *
         * **************************************************** */
        public void TxtDownPayment_Leave(object sender, EventArgs e)
        {
            
            decimal formattedDPInput = Convert.ToDecimal(txtDownPayment.Text);
            txtDownPayment.Text = String.Format("{0:00}", formattedDPInput.ToString("N"));

            if (txtDownPayment.Text != "0.00")
            {
                lblTotalPaymentCount.Text = (Convert.ToDouble(lblTotalPaymentCount.Text) + 1).ToString();
            }
            else
            {
                chkPPA.Checked = false;
                lblTotalPaymentCount.Text = "1";
            }
            UpdateAll();
        }

        /* ***************************************************** *
         *    Select all characters when textbox clicked         *
         * ***************************************************** */

        public void TxtBalanceInput_MouseClick(object sender, MouseEventArgs e)
        {
            // Highlight full number when single clicked
            // Calculates length to locate starting point and how much to highlight
            // Balance Input
            txtBalanceInput.Select(0, txtBalanceInput.Text.Length);
        }

        public void TxtDownPayment_Click(object sender, EventArgs e)
        {
            // Highlight full number when single clicked
            // Down Payment
            txtDownPayment.Select(0, txtDownPayment.Text.Length);
        }

        public void TxtCVV_Click(object sender, EventArgs e)
        {
            // Highlight full number when single clicked
            // CVV Input
            txtCVV.Select(0, txtCVV.Text.Length);
        }

        #region Sample Code for Numeric Validation (Commented Out)
        /*WORKING EXAMPLE FOR NUMERIC VALIDATION IN RICH TEXT BOX -- Can be commented out or deleted at any time
        this can be deleted after it is referenced elsewhere -- Remember to delete the corresponding code on the back-end if removed

        public void RtxtNotate_TextChanged(object sender, EventArgs e)
        {
            rtxtNotate.Text = RemoveNonNumeric(rtxtNotate.Text); // Pure use of RemoveNonNumeric Method (in real time) prevents spaces, allows commas and decimals
            rtxtNotate.Select(rtxtNotate.Text.Length, 0); // Move cursor to far right 
        }*/
        #endregion
        /* **************************************************** *
         *              Current Balance Textbox                 *
         *          Validate Inputs to Prevent Crashing         *
         * **************************************************** */
        public void TxtBalanceInput_TextChanged(object sender, EventArgs e) // Current Balance Textbox
        {
            txtBalanceInput.Text = RemoveNonNumeric(txtBalanceInput.Text); // Pure use of RemoveNonNumeric Method (in real time) prevents spaces, allows commas and decimals
            txtBalanceInput.Select(txtBalanceInput.Text.Length, 0); // Move cursor to far right

            if (txtBalanceInput.Text == "")
            {
                txtBalanceInput.Text = "0.00";
            }

            // Keep 0.00 highlighted when it is the value of the TextBox
            if (txtBalanceInput.Text == "0.00")
            {
                txtBalanceInput.SelectAll();
            }
            // Prevents first character being entered from being period or comma
            txtBalanceInput.Text = txtBalanceInput.Text.TrimStart('.', ',');
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        /* *********************** *
         *   POPULATE DATA GRID    *
         * *********************** */
        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            /* ***************************************** *
             *            CHECK FOR PAY CYCLE            *
             *   CHECK TO MAKE SURE DATES ARE IN ORDER   *
             * ***************************************** */
            if (dropDownPayCycle.Text == "PAY CYCLE")
            {
                MessageBox.Show("Please Select Pay-Cycle");
                Blink();
            }
            // CHECK TO MAKE SURE DATES ARE IN ORDER
            else if ((monthCalendarInstallmentStart.SelectionStart == monthCalendarDP.SelectionStart) && 
                (Convert.ToDouble(lblTotalPaymentCount.Text) > 1) &&
                    (monthCalendarInstallmentStart.Visible == true))
            {
                MessageBox.Show("Down Payment and Installment Date \n Are the same date");
                PopulateDataGrid(); // Populate Data Grid
                btnNotateToLog.Enabled = true;
            }
            else if ((monthCalendarInstallmentStart.SelectionStart < monthCalendarDP.SelectionStart) && (Convert.ToDouble(lblTotalPaymentCount.Text) > 1))
            {
                MessageBox.Show("Down Payment Date is AFTER Installment Date \n Please Fix");
            }
            else if (txtBalanceInput.Text == "0.00")
            {
                MessageBox.Show("Enter Current Balance");
            }
            else
            {
                PopulateDataGrid(); // Populate Data Grid
                btnNotateToLog.Enabled = true;
            }
        }

        /* **************************************************************************************************** *
         *               TEST FOR HOLIDAYS - NOT YET IMPLIMENTED - ADD FUNCTIONALITY LATER ON                   *
         * **************************************************************************************************** */

        public static HashSet<DateTime> GetHolidays(int year)
        {
            HashSet<DateTime> holidays = new HashSet<DateTime>();

            // New Years
            DateTime newYearsDate = AdjustForWeekendHoliday(new DateTime(year, 1, 1));
            holidays.Add(newYearsDate);

            // Memorial Day -- last monday in May 
            DateTime memorialDay = new DateTime(year, 5, 31);
            DayOfWeek dayOfWeek = memorialDay.DayOfWeek;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                memorialDay = memorialDay.AddDays(-1);
                dayOfWeek = memorialDay.DayOfWeek;
            }
            holidays.Add(memorialDay);

            // Independence Day
            DateTime independenceDay = AdjustForWeekendHoliday(new DateTime(year, 7, 4));
            holidays.Add(independenceDay);

            // Labor Day -- 1st Monday in September 
            DateTime laborDay = new DateTime(year, 9, 1);
            dayOfWeek = laborDay.DayOfWeek;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                laborDay = laborDay.AddDays(1);
                dayOfWeek = laborDay.DayOfWeek;
            }
            holidays.Add(laborDay);

            // Thanksgiving Day -- 4th Thursday in November 
            var thanksgiving = (from day in Enumerable.Range(1, 30)
                                where new DateTime(year, 11, day).DayOfWeek == DayOfWeek.Thursday
                                select day).ElementAt(3);
            DateTime thanksgivingDay = new DateTime(year, 11, thanksgiving);
            holidays.Add(thanksgivingDay);

            // Christmas Day 
            DateTime christmasDay = AdjustForWeekendHoliday(new DateTime(year, 12, 25));
            holidays.Add(christmasDay);

            // Next year's new years check
            DateTime nextYearNewYearsDate = AdjustForWeekendHoliday(new DateTime(year + 1, 1, 1));
            if (nextYearNewYearsDate.Year == year)
                holidays.Add(nextYearNewYearsDate);

            return holidays;
        }

        public static DateTime AdjustForWeekendHoliday(DateTime holiday)
        {
            if (holiday.DayOfWeek == DayOfWeek.Saturday)
            {
                return holiday.AddDays(-1);
            }
            else if (holiday.DayOfWeek == DayOfWeek.Sunday)
            {
                return holiday.AddDays(1);
            }
            else
            {
                return holiday;
            }
        }

        
        public void DropDownPayCycle_TextChanged(object sender, EventArgs e) // Ensure user can not change value of ComboBox
        {
            dropDownPayCycle.Text = "PAY CYCLE";
        }

        public void TxtCVV_TextChanged(object sender, EventArgs e)
        {
            /* ************************************************ *
             *    Allow UserInput in Down Payment CVV Box       *
             * ************************************************ */

            // Prevents first character being entered from being '.' or ','
            txtCVV.Text = txtCVV.Text.TrimStart('.', ',');

            // Uses method to prevent non-numeric which crashes app
            txtCVV.Text = RemoveNonNumeric(txtCVV.Text);
            // Move cursor to far right 
            txtCVV.Select(txtCVV.Text.Length, 0);

            // Test for blank field and replace with '000'
            if (txtCVV.Text == "")
            {
                txtCVV.Text = "000";
            }
            if (txtCVV.Text == "000")
            {
                txtCVV.SelectAll();
            }
        }
        #region Settlement Percentage Links
        /* ***************************** *
         *    CLICK TO SET PERCENTAGES   *
         * ***************************** */

        // 100% (NO SIF)
        public void LblOneHundo_Click(object sender, EventArgs e)
        {
            slideSIFpercentage.Value = 100;
        }
        // 75% (NO SIF)
        public void Label3_Click(object sender, EventArgs e)
        {
            slideSIFpercentage.Value = 75;
        }
        // 50% (NO SIF)
        public void LblFifty_Click(object sender, EventArgs e)
        {
            slideSIFpercentage.Value = 50;
        }
        // 25% (NO SIF)
        public void LblTwentyFive_Click(object sender, EventArgs e)
        {
            slideSIFpercentage.Value = 25;
        }
        #endregion

        #region Call New AP Sheet Window
        public void APSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //entireNotation = rtxtNotate.Text; //not in use
            rtxtNotate.SaveFile("notation.rtf");
            AutoPay autoPay = new AutoPay();
            autoPay.Show();
        }
        #endregion

        public void BtnNotateToLog_Click(object sender, EventArgs e)
        {
            // Prevents notation log from double notating by testing line count
            if (rtxtNotate.Text.Contains("*Installment Count: *"))
            {
                AddPaymentInfoToNotation(); // Add payment notation
            }
            else
            {
                // If line count is over 10, clear notation before re-notating
                rtxtNotate.Clear();
                CalculateInstallmentPayments();
                AddPaymentInfoToNotation();
            }
            toolStripExport.Enabled = true;
        }

        public void DropDownPayCycle_MouseHover(object sender, EventArgs e)
        {
            if (dropDownPayCycle.BackColor != Color.White)
            {
                dropDownPayCycle.BackColor = Color.White;
            }
        }

        public void DropDownPayCycle_MouseClick(object sender, MouseEventArgs e) // Fix color after alert
        {
            if (dropDownPayCycle.BackColor != Color.White)
            {
                dropDownPayCycle.BackColor = Color.White;
            }
        }

        public void DataGridPPA_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Count number of rows and change the total payment count to the new number
            if (dataGridPPA.Rows.Count != 0)
            {
                int newTotalPaymentCount = dataGridPPA.Rows.Count;
                lblTotalPaymentCount.Text = Convert.ToString(newTotalPaymentCount);
                paymentsDeleted = true; // Bool to test if payments are deleted
            }
        }

        public void DropDownPayCycle_SelectedIndexChanged(object sender, EventArgs e) // Update notation after changing pay cycle
        {
            UpdateAll();
        }

        public void LblDebug_Click(object sender, EventArgs e)
        {
            if (lblCardValid.Text == "VALID!" && txtCreditCardNumber.Text != "")
            {
                string urlPrefixOne = "https://binlists.com/";
                string binPrefixTwo = "https://www.bankbinlist.com/search.html?bin=";
                string binPrefixThree = "https://checkb.in/number-";
                string binPrefixFour = "https://free-bin-checker.com/cards/bin-";
                string urlAppend = lblBIN.Text;
                string fullURL = urlPrefixOne + urlAppend;
                ProcessStartInfo binWebAddress = new ProcessStartInfo(fullURL);
                Process.Start(binWebAddress);
            }
            else
            {
                MessageBox.Show("Validate a Valid Card Number First");
            }
            
        }

        public void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton(); //currently pops up message box and has debug functionality commented out
            //UpdateAll();
        }
    }
}