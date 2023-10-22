using _01_Adressbok.Interfaces;
using _01_Adressbok.Models;
using System.ComponentModel.Design;

namespace _01_Adressbok.Services;

public class MenuService
{
    private static readonly ContactService _contactService = new ContactService();

    //Förstameny
    public static void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Adressbbok");
            Console.WriteLine("\n1. Lägg till ny kontakt");
            Console.WriteLine("2. Skriv ut alla kontakter");
            Console.WriteLine("3. Skriv ut en kontakt");
            Console.WriteLine("4. Redigera en kontakt");
            Console.WriteLine("5. Radera en kontakt");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett alternativ 0 - 5: ");

            var option = Console.ReadLine();
            Console.Clear();

            

            switch(option)
            {
                case "1":
                    AddContactMenu();
                    break;

                case "2":
                    ViewAllContactsMenu();
                    break;

                case "3":
                    ViewOneContactMenu();
                    break;

                case "4":
                    EditContactMenu();
                    break;

                case "5":
                    RemoveContactMenu();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;


            }

            Console.ReadKey();

            }while (true) ;
        
    }

    //Lägga till kontakter
    public static void AddContactMenu()
    {
        

        var contact = new Contact();

        Console.Write("Förnamn: ");
        contact.FirstName = Console.ReadLine()!;
        Console.Write("Efternamn: ");
        contact.LastName = Console.ReadLine()!;
        Console.Write("E-postadress: ");
        contact.Email = Console.ReadLine()!;

        contact.Address = new Address();
        Console.Write("Gata: ");
        contact.Address.Street = Console.ReadLine()!;
        Console.Write("Postnummer: ");
        contact.Address.PostalCode = Console.ReadLine()!;
        Console.Write("Stad/Ort: ");
        contact.Address.City = Console.ReadLine()!;

       _contactService.AddContact(contact);
        Console.WriteLine("Kontakten sparades!");
    }

    //Visa alla kontakter
    public static void ViewAllContactsMenu()
    {
        var contacts = _contactService.GetAllContacts();

        foreach (var contact in _contactService.GetAllContacts())

            Console.WriteLine($"{contact?.FullName}, {contact?.Address.FullAddress}");
   
    }

    //Sök efter en kontakt
    public static void ViewOneContactMenu()
    {
        Console.WriteLine("Sök efter kontakt via e-postadress");
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!;

        var contact = _contactService.GetOneContact(x => x.Email == email);

        if (contact != null)
        {
            Console.WriteLine(contact?.FullName);
            Console.WriteLine($"<{contact?.Email}>");
            Console.WriteLine(contact?.Address?.FullAddress);
        }
        else
        {
            Console.WriteLine($"Hittade ingen kontakt med e-postadressen {email} ");
        }
        
    }

    //Ta bort en kontakt
    public static void RemoveContactMenu()
    {
        Console.WriteLine("Sök efter kontakt via e-postadress");
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!;

        if (email != null)
        {
            _contactService.RemoveOneContact(x => x.Email == email);
        }
        else
        {
            Console.WriteLine($"Hittade ingen kontakt med e-postadressen {email} ");
        }
       
            
        
    }

    //Uppdatera en kontakt
    public static void EditContactMenu()
    {
        Console.WriteLine("Sök efter kontakt via e-postadress");
        Console.Write("E-postadress: ");
        var email = Console.ReadLine()!.Trim().ToLower();

        var contact = _contactService.GetOneContact(x => x.Email == email);

        if(contact != null)
        {
            Console.WriteLine("Kontakten hittades!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{contact?.FullName}");
            Console.WriteLine($"{contact?.Email}");
            Console.WriteLine($"{contact?.Address.FullAddress}");

            
           

            Console.Write("Ange nytt förnamn (lämna tomt om du inte vill ändra): ");
            string newFirstName = Console.ReadLine()!.Trim();

            Console.Write("Ange nytt efternamn (lämna tomt om du inte vill ändra): ");
            string newLastName = Console.ReadLine()!.Trim();

            Console.Write("Ange ny e-postadress (lämna tomt om du inte vill ändra): ");
            string newEmail = Console.ReadLine()!.Trim().ToLower();

            Console.Write("Ange ny gata (lämna tomt om du inte vill ändra): ");
            string newStreet = Console.ReadLine()!.Trim();

            Console.Write("Ange nytt postnummer (lämna tomt om du inte vill ändra): ");
            string newPostalCode = Console.ReadLine()!.Trim();

            Console.Write("Ange ny stad/ort (lämna tomt om du inte vill ändra): ");
            string newCity = Console.ReadLine()!.Trim();


            if (!string.IsNullOrEmpty(newFirstName))
            {
                contact!.FirstName = newFirstName;
            }

            if (!string.IsNullOrEmpty(newLastName))
            {
                contact!.LastName = newLastName;
            }

            if (!string.IsNullOrEmpty(newEmail))
            {
                contact!.Email = newEmail;
            }
            if (!string.IsNullOrEmpty(newStreet))
            {
                contact!.Address.Street = newStreet;
            }
            if (!string.IsNullOrEmpty(newPostalCode))
            {
                contact!.Address.PostalCode = newPostalCode;
            }
            if (!string.IsNullOrEmpty(newCity))
            {
                contact!.Address.City = newCity;
            }


            _contactService.EditOneContact(contact!);

            Console.WriteLine("Kontakten har uppdaterats!");
            
        }
        else
        {
            Console.WriteLine($"Hittade ingen kontakt med e-postadressen {email} ");
        }
    }
}
