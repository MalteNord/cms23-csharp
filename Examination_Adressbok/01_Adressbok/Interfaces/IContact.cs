using _01_Adressbok.Models;

namespace _01_Adressbok.Interfaces
{ 
    public interface IContact
    {
        
        Address Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        
    }
}