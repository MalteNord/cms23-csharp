
/* Json = JavaScript Object Noatation 
 
    "key": "value" -pair

    {
        "firstName": "Malte"
        "lastName": "Nordstrand"
        "age": 24,
        "isActive": false,
        "skills": ["C#", "JS", "Python", "C"],
        "relatives": [
            { "firstName": "Malte", "lastName": "Nordstrand" },
            { "firstName": "Tommy", "lastName": "Nordstrand" }
        ]
    }
 
 */


using _01_SaveAndReadToFromFile.Models;
using _01_SaveAndReadToFromFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Malte",
    LastName = "Nordstrand",
    Email = "malte.nordstrand@gmail.com"
};


customerService.AddToList(customer);



Console.ReadKey();
