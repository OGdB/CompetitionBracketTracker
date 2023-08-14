namespace TrackerLibrary.Models;

/// <summary>
/// Represents a prize of a tournament.
/// </summary>
public class PrizeModel
{
    #region Constructors
    // Constructors
    public PrizeModel()
    {

    }
    public PrizeModel(int placeNumber, string placeName, decimal prizeAmount = 0, double prizePercentage = 0)
    {
        PlaceNumber = placeNumber;
        PlaceName = placeName;
        PrizeAmount = prizeAmount;
        PrizePercentage = prizePercentage;
    }
    public PrizeModel(string placeNumber, string placeName, string prizeAmount = "0", string prizePercentage = "0")
    {
        int.TryParse(placeNumber, out int placeNumberValue);
        PlaceNumber = placeNumberValue;

        if (placeName.Length > 0)
            PlaceName = placeName;

        decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
        PrizeAmount = prizeAmountValue;

        double.TryParse(prizePercentage, out double prizePercentageValue);
        PrizePercentage = prizePercentageValue;
    }

    /// <summary>
    /// Constructor used for text-file saving. Should throw exception if parse fails.
    /// </summary>
    public PrizeModel(string id, string placeNumber, string placeName, string prizeAmount = "0", string prizePercentage = "0")
    {
        Id = int.Parse(id);

        PlaceNumber = int.Parse(placeNumber);

        if (placeName.Length > 0)
            PlaceName = placeName;

        PrizeAmount = decimal.Parse(prizeAmount);

        PrizePercentage = double.Parse(prizePercentage);
    }
    #endregion

    /// <summary>
    /// The unique identifier of the prize.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The place-number this prize is awarded to.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// The name this place-number will be referred to as.
    /// </summary>
    public string? PlaceName { get; set; }

    /// <summary>
    /// The height of the prize.
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// The percentage of this prize relative to the total prize money.
    /// </summary>
    public double PrizePercentage { get; set; }
}
