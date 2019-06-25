using System;
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

        // Create array to test for invalid characters (invalidChars)
        public readonly string[] invalidChars = { " ", "`", "-", "!", "#", "$", "%", "&", "(", ")", "*", "/", ":", ";", "@", "[", "\\", "]", "^", "_", "{",
            "|", "}", "~", "+", "<", "=", ">", "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K",
            "l", "L", "m", "M", "n", "N", "o", "O", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z",
            "Z", "\"", "\'", "?", ".", "," };
        public string RemoveNonNumeric(string input)
        {
            // 85 invalid characters, 85 indexes in array
            for (int i = 0; i < 85; i++) // i represents index for invalidChars
            {
                input = input.Replace(invalidChars[i], "");
            }
            return input;
        }

        // Create array to test for letters in numeric spot
        public readonly string[] invalidNums = { "`", "!", "#", "$", "%", "&", "*", "/", ":", ";", "@", "[", "\\", "]", "^", "_", "{",
            "|", "}", "~", "+", "<", "=", ">", "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K",
            "l", "L", "m", "M", "n", "N", "o", "O", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z",
            "Z", "\"", "\'", "?", ".", "," };
        public string RemoveNonPhones(string input)
        {
            // 85 invalid characters, 81 indexes in array
            for (int i = 0; i < 81; i++) // i represents index for invalidChars
            {
                input = input.Replace(invalidNums[i], "");
            }
            return input;
        }

        public string[] headerArray; // Declare headerArray
        string originalNotation;
        string entireNotation;
        string notationHeading;
        string notationBottom;
        bool saveButtonHasBeenPressed = false;
        string fullNotation;
        string formattedPhoneNumber;
        bool phoneHasBeenFormatted = false;
        public AutoPay()
        {
            InitializeComponent();
            TestFieldsForValues();
            headerArray = new string[9]; //Instantiate headerArray
            rtxtNotate.LoadFile("notation.rtf"); // Load Rich Text File
            entireNotation = rtxtNotate.Text;
            originalNotation = rtxtNotate.Text;
        }

        #region Update Notations
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
            rtxtNotate.Text.TrimEnd();
            rtxtNotate.Select(0, DateTime.Now.ToString().Length);
            rtxtNotate.SelectionAlignment = HorizontalAlignment.Center;
            // rtxtNotate.SaveFile($"{txtFileNumber}.rtf"); // UN-COMMENT THIS OUT FOR PRODUCTION - CREATE FILEPATH TO SHARED FOLDER
        }
        #endregion
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

        #region // test textboxes for values
        public void TxtFileNumber_TextChanged(object sender, EventArgs e)
        {
            TestFieldsForValues();
        }

        public void TxtNameOnCard_TextChanged(object sender, EventArgs e)
        {
            // Name on Card
            txtNameOnCard.Text = txtNameOnCard.Text.ToUpper(); // Convert name to uppercase as you type
            txtNameOnCard.Select(txtNameOnCard.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtBillingAddress_TextChanged(object sender, EventArgs e)
        {
            // Address
            txtBillingAddress.Text = txtBillingAddress.Text.ToUpper(); // Convert to uppercase as you type
            txtBillingAddress.Select(txtBillingAddress.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtCity_TextChanged(object sender, EventArgs e)
        {
            // City
            txtCity.Text = txtCity.Text.ToUpper(); // Convert to uppercase as you type
            txtCity.Select(txtCity.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtState_TextChanged(object sender, EventArgs e)
        {
            // State
            txtState.Text = txtState.Text.ToUpper(); // Convert to uppercase as you type
            txtState.Select(txtState.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtZip_TextChanged(object sender, EventArgs e)
        {
            // Zip
            TestFieldsForValues();
        }

        public void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            // Email
            txtEmail.Text = txtEmail.Text.ToUpper(); // Convert to uppercase as you type
            txtEmail.Select(txtEmail.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtCallerName_TextChanged(object sender, EventArgs e)
        {
            // Caller
            txtCallerName.Text = txtCallerName.Text.ToUpper(); // Convert to uppercase as you type
            txtCallerName.Select(txtCallerName.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }

        public void TxtCloserName_TextChanged(object sender, EventArgs e)
        {
            // Closer
            txtCloserName.Text = txtCloserName.Text.ToUpper(); // Convert to uppercase as you type
            txtCloserName.Select(txtCloserName.Text.Length, 0); // Move I Beam to far right as you type
            TestFieldsForValues();
        }
        #endregion

        public void TxtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPhone.Text.Length > 0) // If there is text in this box and you click, highlight full string
            {
                txtPhone.SelectAll();
            }
        }

        public void TxtPhone_TextChanged_1(object sender, EventArgs e) // When value is changed
        {
            RemoveNonNumeric(txtPhone.Text);
            txtPhone.Text = RemoveNonPhones(txtPhone.Text);
            // Move cursor to end (REMOVE THIS LINE IF ERRORS)
            txtPhone.Select(txtPhone.Text.Length, 0);

            if (txtPhone.Text.Length > 10) // Just added, if over 10 chars, highlught all
            {
                // Calculates length to locate starting point and how much to highlight, Phone Input
                txtPhone.Select(0, txtPhone.Text.Length);
            }
            

            TestFieldsForValues();
        }

        public void TxtPhone_Leave(object sender, EventArgs e) // Test out numbers that start with "+1"
            /*
            716-983-2079
            (716) 983-2079
            716) 983-2079
            +17169832079
            */
        {
            if (txtPhone.Text.Length == 10 && phoneHasBeenFormatted == false)
            {
                txtPhone.Text = FormatPhone(txtPhone.Text);
                formattedPhoneNumber = txtPhone.Text;
                phoneHasBeenFormatted = true;
            }
            else if (txtPhone.Text.StartsWith("(") || txtPhone.Text.StartsWith(" (") || txtPhone.Text.Contains(")") || txtPhone.Text.StartsWith("+"))
            {
                RemoveNonNumeric(txtPhone.Text);
                FormatPhone(txtPhone.Text);
                phoneHasBeenFormatted = true;
            }
            else if (txtPhone.Text == formattedPhoneNumber && phoneHasBeenFormatted == true)
            {
                // Do nothing
            }
            else if (txtPhone.Text.Length > 9 && phoneHasBeenFormatted == true && txtPhone.Text != formattedPhoneNumber && !txtPhone.Text.Contains(")"))
            {
                txtPhone.Text = FormatPhone(txtPhone.Text);
                formattedPhoneNumber = txtPhone.Text;
            }
            else if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Phone Number can not be blank");
            }
            else if (txtPhone.Text.StartsWith(" ") && !txtPhone.Text.Contains("("))
            {
                RemoveNonPhones(txtPhone.Text);
                FormatPhone(txtPhone.Text);
                phoneHasBeenFormatted = true;
            }
            else
            {
                // Add more if else statements for additional contingencies
            }

        }

        public string FormatPhone(string phoneNumber)
        {
            string unformattedPhone;
            //string phoneNumber;
            string areaCode;
            string secondThree;
            string lastFour;
            unformattedPhone = txtPhone.Text;
            areaCode = unformattedPhone.Substring(0, 3);
            secondThree = unformattedPhone.Substring(3, 3);
            lastFour = unformattedPhone.Substring(6, 4);
            phoneNumber = "(" + areaCode + ") " + secondThree + "-" + lastFour;
            //txtPhone.Text = phoneNumber;
            return phoneNumber;
        }

        public void AutoPay_Load(object sender, EventArgs e)
        {
            // When form loads
        }
    }
}