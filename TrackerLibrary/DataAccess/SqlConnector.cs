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
    /// Saves a new person to the SQL database.
    /// </summary>
    /// <param name="personModel">The person's information.</param>
    /// <returns>The person's information, including its unique identifier.</returns>
    public PersonModel CreatePerson(PersonModel personModel)
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@FirstName", personModel.FirstName);
        pars.Add("@LastName", personModel.LastName);
        pars.Add("@EmailAddress", personModel.EmailAddress);
        pars.Add("@CellphoneNumber", personModel.CellphoneNumber);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPeople_Insert", param: pars, commandType: CommandType.StoredProcedure);

        personModel.Id = pars.Get<int>("@id");

        Debug.WriteLine($"Inserted person model with Id: {personModel.Id}");

        return personModel;
    }

    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="prizeModel">The prize information.</param>
    /// <returns>The prize information, including an unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel prizeModel)
    {
        // Using statement ensures the database connection is properly closed.
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@PlaceNumber", prizeModel.PlaceNumber);
        pars.Add("@PlaceName", prizeModel.PlaceName);
        pars.Add("@PrizeAmount", prizeModel.PrizeAmount);
        pars.Add("@PrizePercentage", prizeModel.PrizePercentage);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_InsertPrize", param: pars, commandType: CommandType.StoredProcedure);

        prizeModel.Id = pars.Get<int>("@id");

        Debug.WriteLine($"Inserted prize model with Id: {prizeModel.Id}");

        return prizeModel;
    }
}