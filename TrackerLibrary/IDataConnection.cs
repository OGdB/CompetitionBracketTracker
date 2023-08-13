using TrackerLibrary.Models;

namespace TrackerLibrary
{
    /// <summary>
    /// Interface for saving data.
    /// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
