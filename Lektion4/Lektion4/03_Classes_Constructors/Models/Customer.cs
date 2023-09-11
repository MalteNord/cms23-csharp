namespace _03_Classes_Constructors.Models;

internal class Customer
{
    public Customer()
    {

    }
    public Customer(string name, string email, string phoneNumber)
    {

    }

    public Customer(string name, string email)
    {

    }


    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }
}

