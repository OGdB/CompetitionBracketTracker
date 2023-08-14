namespace TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

/// <summary>
/// Interface for methods of saving data.
/// </summary>
public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
    PersonModel CreatePerson(PersonModel model);
}
