namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a single match between two teams.
    /// </summary>
    public class MatchModel
    {
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
