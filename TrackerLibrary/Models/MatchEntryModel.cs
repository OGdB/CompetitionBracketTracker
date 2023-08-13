namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team in the competition.
    /// </summary>
    public class MatchEntryModel
    {

        /// <summary>
        /// Main constructor of match entry.
        /// </summary>
        /// <param name="competingTeam">This team</param>
        /// <param name="initialScore">The score of this team before the start of this round.</param>
        /// <param name="parentMatch">The match entry this team came from as the winner.</param>
        public MatchEntryModel(TeamModel competingTeam, double initialScore, MatchEntryModel parentMatch)
        {
            CompetingTeam = competingTeam;
            TeamScore = initialScore;
            ParentMatch = parentMatch;
        }

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
