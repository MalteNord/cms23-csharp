
namespace _02_Classes_GetersAndSeters.Models;

internal class Customer
{
    private string firstName = null!;

    public string FirstName

    {
        get { return firstName; }
        set { firstName = value.Trim(); }
    }

    public string LastName { get; set; } = null!;

    public string FullName => $"{FirstName} {LastName}";
}

