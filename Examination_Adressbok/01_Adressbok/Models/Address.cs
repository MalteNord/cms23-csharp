using _01_Adressbok.Interfaces;

namespace _01_Adressbok.Models;

public class Address : IAddress
{
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string? FullAddress => $"{Street}, {PostalCode} {City}";
}
