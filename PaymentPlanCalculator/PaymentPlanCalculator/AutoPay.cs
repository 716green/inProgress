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
{
    public partial class AutoPay : Form
    {

        public string[] headerArray; // Declare headerArray

        public AutoPay()
        {
            InitializeComponent();
            headerArray = new string[11]; //Instantiate headerArray
        }
                    
        public void HeaderInformation(string dateAndTime, string fileNumber, string nameOnCard, string billingAddress, string billingCity, string billingState, string billingZip,
            string phoneNumber, string emailAddress, string callerName, string closerName)
        {
            // Instantiate headerArray again for safety
            headerArray = new string[11]; 
            // Define array values
            headerArray[0] = DateTime.Now.ToString();
            headerArray[1] = txtFileNumber.Text;
            headerArray[2] = txtNameOnCard.Text;
            headerArray[3] = txtBillingAddress.Text;
            headerArray[4] = txtCity.Text;
            headerArray[5] = txtState.Text;
            headerArray[6] = txtZip.Text;
            headerArray[7] = txtPhone.Text;
            headerArray[8] = txtEmail.Text;
            headerArray[9] = txtCallerName.Text;
            headerArray[10] = txtCloserName.Text;
            //Create Variables in the event that they may be needed
            dateAndTime = DateTime.Now.ToString();
            fileNumber = txtFileNumber.Text;
            nameOnCard = txtNameOnCard.Text;
            billingAddress = txtBillingAddress.Text;
            billingCity = txtCity.Text;
            billingState = txtState.Text;
            billingZip = txtZip.Text;
            phoneNumber = txtPhone.Text;
            emailAddress = txtEmail.Text;
            callerName = txtCallerName.Text;
            closerName = txtCloserName.Text;
        }

        public void BtnSave_Click(object sender, EventArgs e)
        {
            HeaderInformation(headerArray[0], headerArray[1], headerArray[2], headerArray[3],
                headerArray[4], headerArray[5], headerArray[6], headerArray[7], headerArray[8], headerArray[9], headerArray[10]);
        }
    }
}
