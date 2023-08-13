namespace TrackerLibrary.DataAccess;

using Dapper;
using System.Data;
using System.Diagnostics;
using TrackerLibrary.Models;

/// <summary>
/// Data saving class using the SQL database.
/// </summary>
public class SqlConnector : IDataConnection
{
    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize information, including an unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
        // Using statement ensures the database connection is properly closed.
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@PlaceNumber", model.PlaceNumber);
        pars.Add("@PlaceName", model.PlaceName);
        pars.Add("@PrizeAmount", model.PrizeAmount);
        pars.Add("@PrizePercentage", model.PrizePercentage);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_InsertPrize", param: pars, commandType: CommandType.StoredProcedure);

        model.Id = pars.Get<int>("@id");

        Debug.WriteLine($"Retrieved model with Id: {model.Id}");

        return model;
    }
}