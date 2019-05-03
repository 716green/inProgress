using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentPlanCalculator
{
    public partial class paymentPlanCalculator : Form
    {
        public paymentPlanCalculator()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Review Program

            /****************************************** //
            /*             DEFINE VARIABLES             //
            /****************************************** */
            decimal curBal = 0;
            bool sifOffer = false;
            bool pmtPlan = false;
            decimal sifPercent = 1;
            decimal sifBal = curBal * (sifPercent * 100);
            decimal downPmt = 0; // if downPmt != 0, totalCount = totalCount + 1
            decimal remainingBal = sifBal - downPmt;
            //at this point, remainingBal is the current balance
            decimal pmtCountRequest = 0;
            decimal pmtCountRemainder = 0; // remainingBal % pmtCountRequest
            bool hasRemainder = false;
            decimal installmentCount = 1; // if/else if/ else statement with(downPmt, pmtCountRequest, hasRemainder)
            decimal installmentAmt = 0; // remainingBal / pmtCountRequest
            decimal finalPmt = remainingBal - (installmentCount * installmentAmt);
            //final payment with modulus % ?;
            decimal totalCount = 0;
            string[] payCycleArray = { "Weekly", "Bi-Weekly", "Semi-Monthly", "Monthly", "Other" };
            string payCycle = payCycleArray[0];
            //string creditCardNumber = txtCreditCardNumber.Text; //remove if problematic
            DateTime startDate = DateTime.Today; //DateTime.Today.ToString("dd-MM-yyyy");
                                                 //DateTime[] paymentDates = { var payment1, payment2, payment3, payment4, payment5, payment6, payment7, payment8, payment9, payment10, payment11, payment12, };

        }

        /********************************************************* //
        /*             Luhn Method for CC Verification             //
        /********************************************************* */
        public static bool Luhn(string digits)
        {
            return digits.All(char.IsDigit) && digits.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0
                    ? thisNum
                    : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum)
                ).Sum() % 10 == 0;
        }

        /********************************************** //
        /*             Card Type Validation             //
        /********************************************** */
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

        /********************************************** //
        /*             Test Card Validation             //
        /********************************************** */
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
        }

        public void TxtCreditCardNumber_TextChanged(object sender, EventArgs e)
        {
            string creditCardNumber = txtCreditCardNumber.Text;
            txtCreditCardNumber.Text = Regex.Replace(creditCardNumber, @"[^0-9]", "");
            //Test StringToArray Method:
            StringToArray(creditCardNumber); //This can be deleted
        }

        //This is not in use yet and can still be refined or deleted
        public void StringToArray(string breakApart)
        {
            char[] brokenApart = breakApart.ToCharArray();
            rtxtNotate.Text = breakApart;
        }
    }
}
