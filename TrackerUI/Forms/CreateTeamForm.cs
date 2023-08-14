using System.ComponentModel;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private BindingList<PersonModel> availableMembers = GlobalConfig.Connection.GetPerson_All();
        private BindingList<PersonModel> membersInTeam = new();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            RefreshMembersDisplay();
        }

        private void CreateSampleData()
        {
            PersonModel person1 = new("Oeds", "de Boer", "OG@Live.com", "0648186806");
            PersonModel person2 = new("Tim", "Smith", "Tim@Live.com", "143123123");
            availableMembers.Add(person1);
            availableMembers.Add(person2);

            PersonModel person3 = new("William", "van Dam", "William@Live.com", "34634566");
            PersonModel person4 = new("Taylor", "Swift", "Swift@Taylor.com", "525353433");
            membersInTeam.Add(person3);
            membersInTeam.Add(person4);
        }

        private void RefreshMembersDisplay()
        {
            // Wire up the team dropdown and the current teammembers list.
            SelectTeamMemberValue.DataSource = availableMembers;
            SelectTeamMemberValue.DisplayMember = "FullName";

            TeamsInTournamentList.DataSource = membersInTeam;
            TeamsInTournamentList.DisplayMember = "FullName";
        }

        /// <summary>
        /// Create a new team member; add to database & to current team.
        /// </summary>
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            // Get input
            string firstNameValue = FirstNameValue.Text;
            string lastNameValue = LastNameValue.Text;
            string emailValue = EmailValue.Text;
            string phoneValue = PhoneValue.Text;

            // Validate
            if (!ValidateFormInput(firstNameValue, lastNameValue))
            {
                MessageBox.Show("The form contains invalid input, please check it and try again.", "Invalid Input");
                return;
            }

            PersonModel personModel = new(firstNameValue, lastNameValue, emailValue, phoneValue);

            // Save To Database
            GlobalConfig.Connection.CreatePerson(personModel);

            // Add To Team.
            membersInTeam.Add(personModel);

            // Reset the values of the form.
            FirstNameValue.Text = string.Empty;
            LastNameValue.Text = string.Empty;
            EmailValue.Text = string.Empty;
            PhoneValue.Text = string.Empty;

            // The minimum is a full name put in.
            bool ValidateFormInput(string firstName, string lastName)
            {
                return firstName.Length > 0 && lastName.Length > 0;
            }
        }

        /// <summary>
        /// Called when removing member from team.
        /// </summary>
        private void RemoveSelectedFromTeam_Button(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int selectedIndex = TeamsInTournamentList.SelectedIndex;
            if (selectedIndex == -1) return;

            PersonModel selected = membersInTeam[selectedIndex];

            membersInTeam.RemoveAt(selectedIndex);  // More efficient method of removing as it does not iterate over entire list.

            availableMembers.Add(selected);
        }

        /// <summary>
        /// Called when adding team to team. 
        /// </summary>
        private void AddMemberToTeam_Button(object sender, EventArgs e)
        {
            int pIndex = SelectTeamMemberValue.SelectedIndex;
            if (pIndex == -1) return;

            PersonModel personModel = availableMembers[pIndex];

            availableMembers.RemoveAt(pIndex);  // More efficient method of removing as it does not iterate over entire list.
            membersInTeam.Add(personModel);
            RefreshMembersDisplay();
        }

        // TODO - Figure out whether the form closes, or more teams can be made.
        /// <summary>
        /// Called when the Create Team button is clicked.
        /// </summary>
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            string teamNameValue = TeamNameValue.Text;

            if (!ValidateFormInput()) return;

            // Create the team
            TeamModel newTeam = new(teamNameValue, membersInTeam.ToList());

            // Insert the team into the Teams Table in the database.
            GlobalConfig.Connection.CreateTeam(newTeam);
            ClearEntries();

            bool ValidateFormInput()
            {
                bool teamNameSet = teamNameValue.Length > 0;
                if (!teamNameSet)
                {
                    MessageBox.Show("Please enter a team name.", "Missing Team Name");
                    return false;
                }

                bool hasMembersInTeam = membersInTeam.Count > 0;
                if (!hasMembersInTeam)
                {
                    MessageBox.Show("No members in team.", "No Team Members");
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// Reset all the values of the team creation form.
        /// </summary>
        private void ClearEntries()
        {
            TeamNameValue.Clear();
            FirstNameValue.Clear();
            LastNameValue.Clear();
            EmailValue.Clear();
            PhoneValue.Clear();

            availableMembers = GlobalConfig.Connection.GetPerson_All();
            RefreshMembersDisplay();
            membersInTeam.Clear();
        }
    }
}