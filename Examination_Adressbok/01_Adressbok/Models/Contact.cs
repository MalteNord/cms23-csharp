using _01_Adressbok.Interfaces;

namespace _01_Adressbok.Models;

public class Contact : IContact
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public Address Address { get; set; } = null!;

    public string FullName => $"{FirstName} {LastName}";

    
}
