namespace TrackerLibrary.Models;

/// <summary>
/// Represents a team in a tournament.
/// </summary>
public class TeamModel
{
    #region Constructors
    // Constructors
    public TeamModel()
    {
    }

    public TeamModel(string id, string teamName, List<PersonModel> teamMembers)
    {
        Id = int.Parse(id);
        TeamName = teamName;
        TeamMembers = teamMembers;
    }
    public TeamModel(string teamName, List<PersonModel> teamMembers)
    {
        TeamName = teamName;        
        TeamMembers = teamMembers;
    }
    public TeamModel(string id, string teamName)
    {
        Id = int.Parse(id);
        TeamName = teamName;
    }
    #endregion

    /// <summary>
    /// The unique identifier of the team.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// This team's name.
    /// </summary>
    public string TeamName { get; set; }

    /// <summary>
    /// The persons in this team.
    /// </summary>
    public List<PersonModel> TeamMembers { get; set; } = new();
}
