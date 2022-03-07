using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequestercs callingForm;
        public CreatePrizeForm(IPrizeRequestercs caller)
        {
            InitializeComponent();

            callingForm = caller;
        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                placeNameValue.Text,
                placeNumberValue.Text,
                prizeAmountValue.Text,
                pricePercentageValue.Text);
            
                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
           
                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //pricePercentageValue.Text = "0";
            }
            else
            { 
                MessageBox.Show("This form has invalid information. Please check and try again.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);


            if (!placeNumberValidNumber)
            {
                Console.WriteLine("Not a valid Placer Number");
                output = false;
            }

            if (placeNumber < 1)
            {
                Console.WriteLine("Not a valid Placer Number");
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                Console.WriteLine("Name needs to be filled");
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(pricePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                Console.WriteLine("Not a valid prize Amount or prize Percentage");
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                Console.WriteLine("Not a valid prize Amount or prize Percentage");
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                Console.WriteLine("Not a valid prize Amount or prize Percentage");
                output = false;
            }

            return output;
        }

        private void prizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}