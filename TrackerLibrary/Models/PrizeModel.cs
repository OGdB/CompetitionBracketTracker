namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize of a tournament.
    /// </summary>
    public class PrizeModel
    {
        public PrizeModel(int placeNumber, string placeName, double prizeAmount, double prizePercentage)
        {
            PlaceNumber = placeNumber;
            PlaceName = placeName;
            PrizeAmount = prizeAmount;
            PrizePercentage = prizePercentage;
        }

        /// <summary>
        /// The place-number this prize is awarded to.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name this place-number will be referred to as.
        /// </summary>
        public string PlaceName { get; set; }
 
        /// <summary>
        /// The height of the prize.
        /// </summary>
        public double PrizeAmount{ get; set; }

        /// <summary>
        /// The percentage of this prize relative to the total prize money.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
