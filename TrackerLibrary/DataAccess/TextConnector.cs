namespace TrackerLibrary.DataAccess;
using System.Diagnostics;
using TrackerLibrary.Models;

public class TextConnector : IDataConnection
{
    // TODO - Wire up the CreatePrize for text files.
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;
        Debug.WriteLine($"Save a prize as a text file with Id {model.Id}");
        return model;
    }
}
