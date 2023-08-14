namespace TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

/// <summary>
/// Data saving class using a text file.
/// </summary>
public class TextConnector : IDataConnection
{
    private const string PrizesFile = "PrizeModels.csv"; // csv == Comma-Separated-Values
    private const string PersonsFile = "PersonModels.csv";

    public PersonModel CreatePerson(PersonModel model)
    {
        // Read what the current prizes are in the text file.
        List<PersonModel> personModels = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModel();

        // Find the last-created ID.
        // Convert all saved prizes to a list of PrizeModel
        // Order the list of prize models descending by Id.
        int currentId = personModels.Count > 0 ? personModels.OrderByDescending(x => x.Id).First().Id + 1 : 1;

        // Create the new ID
        model.Id = currentId;

        personModels.Add(model);

        // Save the list<string> to the text file as a list of strings.
        personModels.SaveToTextFile(fileName: PersonsFile);

        return model;
    }

    public PrizeModel CreatePrize(PrizeModel model)
    {
        // Read what the current prizes are in the text file.
        List<PrizeModel> prizeModels = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

        // Find the last-created ID.
        // Convert all saved prizes to a list of PrizeModel
            // Order the list of prize models descending by Id.
        int currentId = prizeModels.Count > 0 ? prizeModels.OrderByDescending(x => x.Id).First().Id + 1 : 1;

        // Create the new ID
        model.Id = currentId;

        prizeModels.Add(model);
        
        // Save the list<string> to the text file as a list of strings.
        prizeModels.SaveToTextFile(fileName: PrizesFile);

        return model;
    }
}
