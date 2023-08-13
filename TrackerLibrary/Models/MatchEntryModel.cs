namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in the competition.
    /// </summary>
    public class MatchEntryModel
    {
        /// <summary>
        /// The entry's related team.
        /// </summary>
        public TeamModel CompetingTeam { get; set; }

        /// <summary>
        /// The score of this team.
        /// </summary>
        public double TeamScore { get; set; }

        /// <summary>
        /// The Match Entry this team came out of as the winner the previous round.
        /// </summary>
        public MatchEntryModel ParentMatch { get; set; }
    }
}
