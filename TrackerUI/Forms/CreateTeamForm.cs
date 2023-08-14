using System.Reflection;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            // Get input
            string firstNameValue = FirstNameValue.Text;
            string lastNameValue = LastNameValue.Text;
            string emailValue = EmailValue.Text;
            string phoneValue = PhoneValue.Text;

            // Validate
            if (!ValidateFormInput(firstNameValue, lastNameValue, emailValue, phoneValue))
            {
                MessageBox.Show("The form contains invalid input, please check it and try again.", "Invalid Input");
                return;
            }

            PersonModel personModel = new(firstNameValue, lastNameValue, emailValue, phoneValue);

            // Save To Database
            GlobalConfig.Connection.CreatePerson(personModel);

            // Add To Team.

            // Reset the values of the form.
            FirstNameValue.Text = string.Empty;
            LastNameValue.Text = string.Empty;
            EmailValue.Text = string.Empty;
            PhoneValue.Text = string.Empty;
        }

        /// <summary>
        /// Checks whether the input in all fields are valid inputs.
        /// </summary>
        /// <returns>Is the input valid or not?</returns>
        private bool ValidateFormInput(string firstName, string lastName, string email, string phone)
        {
            return firstName.Length > 0 && lastName.Length > 0 && email.Length > 0;
        }
    }
}
