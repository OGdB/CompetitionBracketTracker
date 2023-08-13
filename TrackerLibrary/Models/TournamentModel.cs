namespace TrackerLibrary
{
    /// <summary>
    /// Represents a tournament.
    /// </summary>
    public class TournamentModel
    {
        public TournamentModel(string tournamentName, decimal entryFee, List<TeamModel> enteredTeams, List<PrizeModel> prizes, List<List<MatchEntryModel>> matchEntries)
        {
            TournamentName = tournamentName;
            EntryFee = entryFee;
            EnteredTeams = enteredTeams;
            Prizes = prizes;
            MatchEntries = matchEntries;
        }

        /// <summary>
        /// The name of this tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The entry fee to enter this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The list of teams that are competing in this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new();

        /// <summary>
        /// The prizes of this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new();

        /// <summary>
        /// The generated matches of this tournament.
        /// </summary>
        public List<List<MatchEntryModel>> MatchEntries { get; set; } = new();
    }
}
