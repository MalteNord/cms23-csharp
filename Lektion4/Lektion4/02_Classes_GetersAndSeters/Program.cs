using System.Text;
using _02_Classes_GetersAndSeters.Models;
var customer = new Customer();

//set - sätt ett värde
customer.FirstName = "Malte";
customer.LastName = "Nordstrand";

//get - hämta värdet
var name = customer.FullName;




var user = new User();
user.FirstName = "Malte";
user.LastName = "Nordstrand";
user.Email = "malte.nordstrand@gmail.com";


user.SetSecurePassword("BytMig!");

var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"Password: {password}");
Console.ReadKey();