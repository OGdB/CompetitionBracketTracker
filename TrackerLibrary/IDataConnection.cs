namespace TrackerLibrary;
using TrackerLibrary.Models;

/// <summary>
/// Interface for saving data.
/// </summary>
public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
}
