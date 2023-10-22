namespace _01_Adressbok.Interfaces
{
    public interface IAddress
    {
        string City { get; set; }
        string? FullAddress { get; }
        string PostalCode { get; set; }
        string Street { get; set; }
    }
}