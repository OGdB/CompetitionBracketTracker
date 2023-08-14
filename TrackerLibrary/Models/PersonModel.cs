namespace TrackerLibrary.Models;

/// <summary>
/// Represents a single person.
/// </summary>
public class PersonModel
{
    #region Constructors
    // Constructors
    public PersonModel()
    {
    }

    public PersonModel(string firstName, string lastName, string emailAddress, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        CellphoneNumber = phoneNumber;
    }
    
    /// <summary>
    /// Constructor for text-file saving
    /// </summary>
    public PersonModel(string id, string firstName, string lastName, string emailAddress, string phone)
    {
        Id = int.Parse(id);
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        CellphoneNumber = phone;
    }

    #endregion

    /// <summary>
    /// The unique identifier of the person.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The first name of this person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of this person.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The e-mail address to contact this person with.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The phone number to text to this person.
    /// </summary>
    public string CellphoneNumber { get; set; }
}
