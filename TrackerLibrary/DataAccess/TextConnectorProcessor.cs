using System.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers;

public static class TextConnectorProcessor
{
    /// <summary>
    /// Get the full file path to the folder to which to save the textfile saves.
    /// </summary>
    /// <param name="fileName">The name to give to the file to save.</param>
    /// <returns>The full filepath string.</returns>
    public static string FullFilePath(this string fileName) => $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";

    /// <summary>
    /// Retrieve the content of a text file as a list of strings.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <returns>The content of the file at the file path as a list of strings.</returns>
    public static List<string> LoadFile(this string filePath)
    {
        if (!File.Exists(filePath))  // if a file does NOT exist at the provided filepath...
        {
            return new List<string>();
        }

        return File.ReadAllLines(filePath).ToList();  // Otherwise, read all the lines from the file at the filepath.
    }

    /// <summary>
    /// Convert the content of a text file to a prize model.
    /// </summary>
    /// <param name="lines">List of strings of a text file to each convert to a prize model.</param>
    /// <returns>The list of strings converted to a list of prize models.</returns>
    public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
    {
        var output = new List<PrizeModel>();

        foreach (var line in lines) // Loop through every line in the text file.
        {
            string[] cols = line.Split(','); // Each line should have data separated by a comma.

            PrizeModel p = new(id: cols[0],
                               placeNumber: cols[1],
                               placeName: cols[2],
                               prizeAmount: cols[3],
                               prizePercentage: cols[4]);

            output.Add(p);
        }

        return output;
    }

    /// <summary>
    /// Convert the content of a text file to a prize model.
    /// </summary>
    /// <param name="lines">List of strings of a text file to each convert to a prize model.</param>
    /// <returns>The list of strings converted to a list of prize models.</returns>
    public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
    {
        var output = new List<PersonModel>();

        foreach (var line in lines) // Loop through every line in the text file.
        {
            string[] cols = line.Split(','); // Each line should have data separated by a comma.

            PersonModel p = new(id: cols[0],
                               firstName: cols[1],
                               lastName: cols[2],
                               emailAddress: cols[3],
                               phone: cols[4]);

            output.Add(p);
        }

        return output;
    }

    /// <summary>
    /// Save a list of prize models as a .csv file.
    /// </summary>
    /// <param name="prizeModels">The list of prize models to save.</param>
    /// <param name="fileName">the name to give to the save file</param>
    public static void SaveToTextFile(this List<PrizeModel> prizeModels, string fileName)
    {
        List<string> ToStringList = new();

        foreach (var p in prizeModels)
        {
            ToStringList.Add(
                $"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
        }

        File.WriteAllLines(fileName.FullFilePath(), ToStringList);
    }

    /// <summary>
    /// Save a list of person models as a .csv file.
    /// </summary>
    /// <param name="personModels">The list of person models to save.</param>
    /// <param name="fileName">the name to give to the save file</param>
    public static void SaveToTextFile(this List<PersonModel> personModels, string fileName)
    {
        List<string> ToStringList = new();

        foreach (var p in personModels)
        {
            ToStringList.Add(
                $"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
        }

        File.WriteAllLines(fileName.FullFilePath(), ToStringList);
    }

    // *Read what the current prizes are in the text file.
    // *Convert all saved prizes to a list of PrizeModel
    // Find the last-created ID.

    // Create the new ID

    // Convert the prizes back to a list of <string>

    // Save the list<string> to the text file.
}
