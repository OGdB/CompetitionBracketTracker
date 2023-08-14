namespace TrackerLibrary.DataAccess;

using System.ComponentModel;
using TrackerLibrary.Models;

/// <summary>
/// Interface for methods of saving data.
/// </summary>
public interface IDataConnection
{
    /// <summary>
    /// Create a prize and add it to the database.
    /// </summary>
    /// <param name="model">The prize to add.</param>
    /// <returns>The added prize.</returns>
    PrizeModel CreatePrize(PrizeModel model);

    /// <summary>
    /// Create a person and add it to the database.
    /// </summary>
    /// <param name="model">The person to add.</param>
    /// <returns>The added person.</returns>
    PersonModel CreatePerson(PersonModel model);

    /// <summary>
    /// Create a team and add it to the database.
    /// </summary>
    /// <param name="model">The team to add.</param>
    /// <returns>The added team.</returns>
    TeamModel CreateTeam(TeamModel model);

    /// <summary>
    /// Get all the persons from the database.
    /// </summary>
    /// <returns></returns>
    BindingList<PersonModel> GetPerson_All();
}
