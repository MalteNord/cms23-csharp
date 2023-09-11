/* Lists 
-------------------------------------------------------------------------------
En lista är en dynamisk lista som gör att det går att lägga till och ta bort
objekt ifrån ifrån listan. Det går även att sortera om den.
Det finns lika olika typer av listor för olika ändamål.

Instansiera en ny lista
-------------------------------------------------------------------------------
var list = new List<string>();
var list = new List<string>();
List<string> list = new();

List<>           ReadWrite    lägga till, ta bort, sortera
IEnumerable<>    Read         sortera
ICollection      ReadWrite    lägga till, ta bort, sortera

* I betyder Interface och har då en uppsättning av funktioner vi kan komma
åt och göra något med.

using System.Collections.ObjectModel;

List<string> list_1 = new List<string>();
list_1.Add("1");
list_1.Remove("1");
list_1.OrderByDescending(x => x);
list_1.Clear();
list_1.FirstOrDefault();
list_1.LastOrDefault();
list_1.Insert(0, "1");

IEnumerable<string> list_2 = new List<string>();
list_2.Add("1");
list_2.Remove("1");
list_2.OrderByDescending(x => x);
list_2.Clear();
list_2.FirstOrDefault();
list_2.LastOrDefault();
list_2.Insert(0, "1");

ICollection<string> list_3 = new List<string>();
list_3.Add("1");
list_3.Remove("1");
list_3.OrderByDescending(x => x);
list_3.Clear();
list_3.FirstOrDefault();
list_3.LastOrDefault();
list_3.Insert(0, "1");

ObservableCollection<string> list_4 = new List<string>();
list_4.Add("1");
list_4.Remove("1");
list_4.OrderByDescending(x => x);
list_4.Clear();
list_4.FirstOrDefault();
list_4.LastOrDefault();
list_4.Insert(0, "1");

var names = new List<string>();

names.Add("Malte");
names.Add("Tommy");
names.Add("Joakim");

foreach(var name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine();
var user = names.FirstOrDefault(name => name == "Tommy");
Console.WriteLine(user);
if (user != null)
    Console.WriteLine(user);
else
    Console.WriteLine("Användaren hittades inte.");



Console.ReadKey();
 
 */

/* Classes 
-------------------------------------------------------------------------------
Klasser är en del av objetorienterad programmering.
En klass är alltså ett objekt och en klass kan innehålla flera olika saker.
Se en lkass som en mall över hur något ser ut eller hur något är.

En användare, en kund, en order, en produkt, en prislista, en adress, etc.


class ContactPerson
{
    //Properties och skrivs med Pascal
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }
    


}

 */

using _04_ClassesAndLists.Models;

var contactPersons = new List<ContactPerson>();
var answer = "n";
do
{

    Console.Clear();

    var contactPerson = new ContactPerson();

    Console.Write("Förnamn: ");
    contactPerson.FirstName = Console.ReadLine() ?? "";

    Console.Write("Efternamn: ");
    contactPerson.LastName = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    contactPerson.Email = Console.ReadLine() ?? "";

    Console.Write("Mobilnummer: ");
    contactPerson.Phonenumber = Console.ReadLine() ?? "";

    contactPersons.Add(contactPerson);

    // Lägg till kontaktperson i listan.
    Console.Write("Vill du lägga till en till person? (y/n)");
    answer = Console.ReadLine();

} while (answer.ToLower() == "y");

Console.Clear();

Console.WriteLine("Här är alla kontaktpersoner");

foreach(var contact in contactPersons)
{
    Console.WriteLine($"<{contact.FirstName} {contact.LastName} {contact.Email}>");
}
Console.ReadKey();
