using System.Diagnostics;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Triggered when the 'Create Prize' button is pressed, which should create the prize and save it to the configured databases.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            string placeNumber = PlaceNumberValue.Text;
            string placeName = PlaceNameValue.Text;
            string prizeAmount = PrizeAmountValue.Text;
            string prizePercentage = PrizePercentageValue.Text;

            // If any of the input isn't valid, return.
            if (!ValidateFormInput(placeNumber, placeName, prizeAmount, prizePercentage))
            {
                MessageBox.Show("The form contains invalid input, please check it and try again.", "Invalid Input");
                return;
            }

            PrizeModel model = new(placeNumber, placeName, prizeAmount, prizePercentage);

            // Save the prize model to the configured databases.
            GlobalConfig.Connection.CreatePrize(model);

            // Reset the values of the form.
            PlaceNumberValue.Text = string.Empty;
            PlaceNameValue.Text = string.Empty;
            PrizeAmountValue.Text = "0";
            PrizePercentageValue.Text = "0";
        }

        /// <summary>
        /// Checks whether the input in all fields are valid inputs.
        /// </summary>
        /// <returns>Is the input valid or not?</returns>
        private bool ValidateFormInput(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            // Place Number: actual number, and above 1?
            bool validPlace = int.TryParse(placeNumber, out int placeNumberValue) && placeNumberValue >= 1;
            Debug.WriteLine($"Valid place: {validPlace}");

            // Place Name: at least one letter?
            bool validPlaceName = placeName.Length > 0;
            Debug.WriteLine($"Valid place name: {validPlaceName}");

            // Prize Amount: equal or above 0?
            bool validPrizeAmount = decimal.TryParse(prizeAmount, out decimal prizeAmountValue)
                && prizeAmountValue > 0;
            Debug.WriteLine($"Valid prize amount: {validPrizeAmount}");

            // Prize Percentage: Actual number, between 0 and 100?
            bool validPrizePercentage =
                double.TryParse(prizePercentage, out double prizePercentageValue) // actual number
                && prizePercentageValue > 0 && prizePercentageValue <= 100; // Between 0 and 100 (%)
            Debug.WriteLine($"Valid prize percentage: {validPrizePercentage}");

            // At least one of the methods to set a prize amount/percentage should be set (above 0 and below/equal 100)
            bool validPrizeInput = validPrizeAmount || validPrizePercentage;
            if (!validPrizeInput) Debug.WriteLine("No valid prize was set!");


            // Is all input valid?
            bool validInput = validPlace && validPlaceName && validPrizeInput;
            Debug.WriteLine($"Valid input: {validInput}");

            return validInput;
        }
    }
}
