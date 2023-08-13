namespace TrackerLibrary
{
    /// <summary>
    /// Represents a single match between two teams.
    /// </summary>
    public class MatchModel
    {
        /// <summary>
        /// Constructor of a match between two teams.
        /// </summary>
        /// <param name="matchEntries">The two teams</param>
        /// <param name="matchRoundNumber">The round this match takes places in.</param>
        public MatchModel(List<MatchEntryModel> matchEntries, int matchRoundNumber)
        {
            MatchEntries = matchEntries;
            RoundNumber = matchRoundNumber;
        }

        /// <summary>
        /// The two teams competing in this match.
        /// </summary>
        public List<MatchEntryModel> MatchEntries { get; set; }

        /// <summary>
        /// The winner of this match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round this match takes places in.
        /// </summary>
        public int RoundNumber { get; set; }
    }
}
