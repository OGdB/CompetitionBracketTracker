namespace TrackerLibrary;

using System.Configuration;
using System.Diagnostics;
using TrackerLibrary.DataAccess;

/// <summary>
/// Contains global data & configurations.
/// </summary>
public static class GlobalConfig
{
    public static IDataConnection Connection { get; private set; }

    /// <summary>
    /// Initialize the connections to the databases to save competition data.
    /// </summary>
    /// <param name="useDatabase">Use the SQL database for saving data.</param>
    /// <param name="useTextfiles">Use text files for saving data.</param>
    public static void InitializeConnections(DatabaseType db)
    {
        switch (db)
        {
            case DatabaseType.SqlDatabase:
                Debug.WriteLine("Establish SQL-database connection");
                Connection = new SqlConnector();
                break;

            case DatabaseType.TextFile:
                Debug.WriteLine("Establish text-database connection");
                Connection = new TextConnector();
                break;
        }
    }

    /// <summary>
    /// Retrieve the connection string to the SQL database.
    /// </summary>
    /// <param name="databaseName">The database to connect to.</param>
    /// <returns>The connection string to the database.</returns>
    public static string CnnString(string databaseName) => ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
}
