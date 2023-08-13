namespace TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using System.Diagnostics;

public class SqlConnector : IDataConnection
{
    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize information, including an unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
        // TODO - Make the Create Prize Method actually save to the database.

        model.Id = 1;
        Debug.WriteLine($"Save a prize in the SQL database with Id {model.Id}");
        return model;
    }
}
