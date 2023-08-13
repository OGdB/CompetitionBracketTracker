using System.Diagnostics;

namespace TrackerLibrary;

/// <summary>
/// Contains global data & configurations.
/// </summary>
public static class GlobalConfig
{
    public static List<IDataConnection> Connections { get; private set; } = new();

    /// <summary>
    /// Initialize the connections to the databases to save competition data.
    /// </summary>
    /// <param name="useDatabase">Use the SQL database for saving data.</param>
    /// <param name="useTextfiles">Use text files for saving data.</param>
    public static void InitializeConnections(bool useDatabase, bool useTextfiles)
    {
        // TODO - Set up the SQL-connector properly.
        if (useDatabase)
        {
            Debug.WriteLine("Establish SQL-database connection");
            SqlConnector sql = new();
            Connections.Add(sql);
        }

        // TODO - Create the text connection.
        if (useTextfiles)
        {
            Debug.WriteLine("Establish text-database connection");
            TextConnection textConnection = new();
            Connections.Add(textConnection);
        }
    }
}