using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentPlanCalculator

/* TO DO LIST...
 * Center Top DateTime
 * Add Regex to text boxes
 * Add Print Functionality
 * Add filepath functionality
 */

{
    public partial class AutoPay : Form
    {
        public string[] headerArray; // Declare headerArray
        string originalNotation;
        string entireNotation;
        string notationHeading;
        string notationBottom;
        bool saveButtonHasBeenPressed = false;
        string fullNotation;
        public AutoPay()
        {
            InitializeComponent();
            TestFieldsForValues();
            headerArray = new string[9]; //Instantiate headerArray
            rtxtNotate.LoadFile("notation.rtf"); // Load Rich Text File
            entireNotation = rtxtNotate.Text;
            originalNotation = rtxtNotate.Text;
        }

        public void HeaderInformation(string dateAndTime, string fileNumber, string nameOnCard, string callerName, string closerName,  string billingAddress, string cityStateZip,
            string phoneNumber, string emailAddress)
        {
            // Instantiate headerArray again for safety
            headerArray = new string[9];
            // Define array values
            headerArray[0] = DateTime.Now.ToString() + "\n";
            headerArray[1] = txtFileNumber.Text;
            headerArray[2] = $"Debtor: {txtNameOnCard.Text}\n";
            headerArray[3] = $"Caller: {txtCallerName.Text}";
            headerArray[4] = $"Closer: {txtCloserName.Text}";
            headerArray[5] = $"Name on Card: {txtNameOnCard.Text}\n{txtBillingAddress.Text}";
            headerArray[6] = txtCity.Text + ", " + txtState.Text + " " + txtZip.Text + "\n";
            headerArray[7] = $"Phone: {txtPhone.Text}";
            headerArray[8] = txtEmail.Text;
            
            //Create Variables in the event that they may be needed
            dateAndTime = $"Date: {DateTime.Now.ToString()}";
            fileNumber = $"File Number: {txtFileNumber.Text}";
            nameOnCard = $"Name on Card: {txtNameOnCard.Text}";
            billingAddress = $"Billing Address: {txtBillingAddress.Text}";
            cityStateZip = $"City: {txtCity.Text}";
            //billingState = $"State: {txtState.Text}"; //merged into 1
            //billingZip = $"Zip: {txtZip.Text}"; //merged into 1
            phoneNumber = $"Phone: {txtPhone.Text}";
            emailAddress = $"Email: {txtEmail.Text}";
            callerName = $"Caller: {txtCallerName.Text}";
            closerName = $"Closer: {txtCloserName.Text}";
        }


        public void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveButtonHasBeenPressed == true)
            {
                rtxtNotate.Clear();
                rtxtNotate.LoadFile("notation.rtf"); // Load Rich Text File
            }
            

            HeaderInformation(headerArray[0], headerArray[1], headerArray[2], headerArray[3],
                headerArray[4], headerArray[5], headerArray[6], headerArray[7], headerArray[8]);

            for (int i = 0; i < 5; i++)
            {
                notationHeading += headerArray[i] + "\n";
            }
            for (int i = 5; i < 9; i++)
            {
                notationBottom += headerArray[i] + "\n";
            }
            fullNotation = notationHeading + "\n" + entireNotation + "\n" + notationBottom;
            rtxtNotate.Text = fullNotation;
            saveButtonHasBeenPressed = true;
            fullNotation = "";
            notationBottom = "";
            notationHeading = "";
            // rtxtNotate.SaveFile($"{txtFileNumber}.rtf"); // UN-COMMENT THIS OUT FOR PRODUCTION - CREATE FILEPATH TO SHARED FOLDER
        }

        public void TestFieldsForValues()
        {
            if (txtBillingAddress.Text != "" && txtCallerName.Text != "" && txtCity.Text != "" && txtCloserName.Text != "" && txtEmail.Text != "" && 
                txtFileNumber.Text != "" && txtNameOnCard.Text != "" && txtPhone.Text != "" && txtState.Text != "" && txtZip.Text != "")
            {
                btnSave.Enabled = true;
            }
            else if (txtBillingAddress.Text == "" || txtCallerName.Text == "" || txtCity.Text == "" || txtCloserName.Text == "" || 
                txtEmail.Text == "" || txtFileNumber.Text == "" || txtNameOnCard.Text == "" || txtPhone.Text == "" || txtState.Text == "" || txtZip.Text == "")
            {
                btnSave.Enabled = false;
            }
        }

        public void TxtFileNumber_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtNameOnCard_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtBillingAddress_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtCity_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtState_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtZip_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtPhone_TextChanged_1(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtCallerName_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtCloserName_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }
    }
}