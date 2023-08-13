namespace TrackerLibrary
{
    /// <summary>
    /// Contains global data & configurations.
    /// </summary>
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        /// <summary>
        /// Initialize the connections to the databases to save competition data.
        /// </summary>
        /// <param name="useDatabase">Use the SQL database for saving data.</param>
        /// <param name="useTextfiles">Use text files for saving data.</param>
        public static void InitializeConnections(bool useDatabase, bool useTextfiles)
        {
            if (useDatabase)
            {
                // TODO - Try to establish a connection with the SQL database.
            }

            if (useTextfiles)
            {
                // TODO - Create the text connection.
            }
        }
    }
}