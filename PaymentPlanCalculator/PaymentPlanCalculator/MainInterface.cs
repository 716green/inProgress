using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/* Removed Using Statements
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

Research to learn about each one*/

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

        //HAS NOT BEEN USED YET, COME BACK TO THIS
        //Attempting to use to prevent more than 1 period from being used
        // Copied from docs.microsoft.com (hurry up and learn regex)
        public static bool IsValidCurrency(string currencyValue)
        {
            string pattern = @"\p{Sc}+\s*\d+";
            return Regex.IsMatch(currencyValue, pattern);
        }


        public paymentPlanCalculator()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

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
            else if (cardType == "3")
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

            //FOR TESTING PURPOSES- CLICKING VALIDATE RUNS CALCULATE PAYMENT COUNT METHOD
            PaymentCount();

            /* ****************** *
             *   NOTATE ACCOUNT   *
             * ****************** */
            string notationOverview = $"Dbtr owes {txtBalanceInput.Text:C}";

            if (chkSettlement.Checked == true)
            {
                notationOverview += $"\n{slideSIFpercentage.Value}% SIF authorized";
            }
            else
            {
                notationOverview += $"\nno SIF authorized";
            }
            if (chkPPA.Checked == true)
            {
                notationOverview += $"\nPPA Authorized over {lblTotalPaymentCount.Text} payments";
            }
            else
            {
                notationOverview += $"\nto be paid in 1 payment ";

                if (slideSIFpercentage.Value == 100)
                {
                    notationOverview += $"for balance in full of {txtBalanceInput.Text:C}";
                }
                else
                {
                    notationOverview += $"for {slideSIFpercentage.Value}% SIF of {lblSifBalance:C}";
                }
            }
            if (txtDownPayment.Text != "0.00")
            {
                notationOverview += $"\nDown payment of {txtDownPayment.Text:C} to leave a remaining balance of {lblRemainingBal.Text:C}" +
                    $"\nover {sliderRemainingPmtCount.Value - 1} payments of {lblInstallmentAmt:C} and 1 " +
                    //$"\nover {(Convert.ToDouble(lblTotalPaymentCount.Text) - 1).ToString()} payments of {lblInstallmentAmt:C} and 1 " +
                    $"final payment of {lblRemainder.Text:C}";
            }
            else
            {
                notationOverview += $"\nover { (Convert.ToDouble(lblTotalPaymentCount.Text) - 1).ToString()} payments of { lblInstallmentAmt: C} " +
                $"and 1 final payment of {lblRemainder.Text:C}";
            }
            if (txtCreditCardNumber.Text != "")
            {
                notationOverview += $"\nDbtr is using {lblCardType.Text} card. Card number is {txtCreditCardNumber.Text}";
            }
            rtxtNotate.Text = notationOverview;
            
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
         ********************************************* */
        public void SlideSIFpercentage_ValueChanged_1(object sender, EventArgs e)
        {
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
                //string curBal = "0"; //can probably be deleted
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

        /****************************************************** *
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
         ****************************************************** */

        /* **************************************************** *
         *    Calc Remaining Balance based on SIF Checkbox      *
         * **************************************************** */
        public void TextBox1_TextChanged(object sender, EventArgs e) // Current Balance Textbox
        {
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

            /* ************************************************ *
             *    Calculates Math for Down Payment and SIF      *
             ************************************************** */
            decimal currentBalance = Convert.ToDecimal(txtBalanceInput.Text);
            decimal downPayment = Convert.ToDecimal(txtDownPayment.Text);
            decimal settlementAmount = Convert.ToDecimal(txtBalanceInput.Text) * ((Convert.ToDecimal(slideSIFpercentage.Value) / 100));
            decimal sifAfterDownPayment = settlementAmount - downPayment;
            decimal pmtAfterDownPayent = currentBalance - downPayment;
            // These statements are mostly for error handling for checkboxes
            if (chkSettlement.Checked == true)
            {
                lblRemainingBal.Text = sifAfterDownPayment.ToString();
            }
            else if (chkSettlement.Checked == false)
            {
                lblRemainingBal.Text = pmtAfterDownPayent.ToString();
            }
            else
            {
                txtDownPayment.Text = "0.00";
                txtBalanceInput.Text = currentBalance.ToString();
                lblRemainingBal.Text = txtBalanceInput.Text;
            }
        }

        /* *************************************************** *
         *    Calculate PPA Based on Installment Slider        *
         * *************************************************** */
        public void SliderRemainingPmtCount_ValueChanged(object sender, EventArgs e)
        {
            double remainingBalance = Convert.ToDouble(lblRemainingBal.Text);
            double remainingPaymentCountRequest = sliderRemainingPmtCount.Value;
            lblRemainingPmtCount.Text = sliderRemainingPmtCount.Value.ToString();
            double installmentAmount = remainingBalance / remainingPaymentCountRequest;
            double installmentRemainder = ((remainingBalance % remainingPaymentCountRequest) / 100) + installmentAmount;
            lblInstallmentAmt.Text = installmentAmount.ToString("C"); // ToString("C") converts to currency
            lblRemainder.Text = installmentRemainder.ToString("C");

            // Show or hide PPA info based on if PPA exists as set
            if (sliderRemainingPmtCount.Value > 0)
            {
                chkPPA.Checked = true;
                pnlPPA.Visible = true;
            }
            else
            {
                chkPPA.Checked = false;
                pnlPPA.Visible = false;
            }
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
                decimal formattedBalInput = Convert.ToDecimal(txtBalanceInput.Text);
                // ToString("N") converts to number to 2 decimal places according to Format syntax
                txtBalanceInput.Text = String.Format("{0:00}", formattedBalInput.ToString("N"));
            }
        }

        /* **************************************************** *
         *    Format Down Payment Input to 2 Decimal Places     *
         ****************************************************** */
        public void TxtDownPayment_Leave(object sender, EventArgs e)
        {
            decimal formattedDPInput = Convert.ToDecimal(txtDownPayment.Text);
            txtDownPayment.Text = String.Format("{0:00}", formattedDPInput.ToString("N"));
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

        // WORKING EXAMPLE FOR NUMERIC VALIDATION IN RICH TEXT BOX -- Can be commented out or deleted at any time
        // this can be deleted after it is referenced elsewhere -- Remember to delete the corresponding code on the back-end if removed
        
        /*
        public void RtxtNotate_TextChanged(object sender, EventArgs e)
        {
            rtxtNotate.Text = RemoveNonNumeric(rtxtNotate.Text); // Pure use of RemoveNonNumeric Method (in real time) prevents spaces, allows commas and decimals
            rtxtNotate.Select(rtxtNotate.Text.Length, 0); // Move cursor to far right 
        }
        */

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
    }
}
