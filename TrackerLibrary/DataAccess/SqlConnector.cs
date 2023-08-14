namespace TrackerLibrary.DataAccess;

using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using TrackerLibrary.Models;

/// <summary>
/// Data saving class using the SQL database.
/// </summary>
public class SqlConnector : IDataConnection
{
    private const string db = "Tournaments";

    /// <summary>
    /// Saves a new person to the SQL database.
    /// </summary>
    /// <param name="personModel">The person's information.</param>
    /// <returns>The person's information, including its unique identifier.</returns>
    public PersonModel CreatePerson(PersonModel personModel)
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@FirstName", personModel.FirstName);
        pars.Add("@LastName", personModel.LastName);
        pars.Add("@EmailAddress", personModel.EmailAddress);
        pars.Add("@CellphoneNumber", personModel.CellphoneNumber);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPeople_Insert", param: pars, commandType: CommandType.StoredProcedure);

        personModel.Id = pars.Get<int>("@id");

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
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@PlaceNumber", prizeModel.PlaceNumber);
        pars.Add("@PlaceName", prizeModel.PlaceName);
        pars.Add("@PrizeAmount", prizeModel.PrizeAmount);
        pars.Add("@PrizePercentage", prizeModel.PrizePercentage);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_InsertPrize", param: pars, commandType: CommandType.StoredProcedure);

        prizeModel.Id = pars.Get<int>("@id");

        return prizeModel;
    }

    /// <summary>
    /// Retrieve all stored persons from the database.
    /// </summary>
    /// <returns>The created person with an assigned ID.</returns>
    public BindingList<PersonModel> GetPerson_All()
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)); // Establish the connection.

        BindingList<PersonModel> output = new(connection.Query<PersonModel>("dbo.spPeople_GetAll", commandType: CommandType.StoredProcedure).ToList());

        return output;
    }

    /// <summary>
    /// Add a team to the database and link its members to the team.
    /// </summary>
    /// <returns>The created team with an assigned ID.</returns>
    public TeamModel CreateTeam(TeamModel teamModel)
    {
        using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)); // Establish the connection.

        DynamicParameters pars = new();
        pars.Add("@TeamName", teamModel.TeamName);
        pars.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
        connection.Execute("dbo.spTeams_Insert", param: pars, commandType: CommandType.StoredProcedure);

        teamModel.Id = pars.Get<int>("@id");

        foreach (PersonModel p in teamModel.TeamMembers)
        {
            pars = new();
            pars.Add("@TeamId", teamModel.Id);
            pars.Add("@PersonId", p.Id);
            connection.Execute("dbo.spTeamMembers_Insert", param: pars, commandType: CommandType.StoredProcedure);
        }

        return teamModel;
    }
}