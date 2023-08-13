using System.Diagnostics;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            Debug.WriteLine($"Save a prize as a text file with Id {model.Id}");
            return model;
        }
    }
}
