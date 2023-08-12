namespace TrackerLibrary
{
    /// <summary>
    /// Represents a team in a tournament.
    /// </summary>
    internal class TeamModel
    {
        public TeamModel(List<PersonModel> persons, string teamName)
        {
            Persons = persons;
            TeamName = teamName;
        }

        /// <summary>
        /// The persons in this team.
        /// </summary>
        public List<PersonModel> Persons { get; set; } = new();

        /// <summary>
        /// This team's name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
