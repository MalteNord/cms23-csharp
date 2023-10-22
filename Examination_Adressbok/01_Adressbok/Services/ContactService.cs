using _01_Adressbok.Handlers;
using _01_Adressbok.Interfaces;
using _01_Adressbok.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace _01_Adressbok.Services;

public class ContactService
    
{
    private readonly string path = @"Z:\Desktop\contacts.json";
    private List<Contact> _contacts = new List<Contact>();
    public Contact? CurrentContact { get; set; }
    public event Action ContactUpdated;

    public ContactService()
    {
        GetAllContacts();
        ContactUpdated += () => {
            if (CurrentContact != null)
                UpdateCurrentContact(CurrentContact.Id);
        };
    }

    public void AddContact(Contact contact)
    {
        try
        {
            _contacts.Add(contact);
            FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_contacts));
            ContactUpdated.Invoke();
        }
        catch { }
    }

    public IEnumerable<Contact> GetAllContacts()
    {
        try
        {
            var contacts = FileHandler.ReadFromFile(path);
            if (!string.IsNullOrEmpty(contacts))
            {
                _contacts = JsonConvert.DeserializeObject<List<Contact>>(contacts)!;
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return _contacts;
    }

    public Contact GetOneContact(Func<Contact, bool> expression)
    {
        try
        {
            var contact = _contacts.FirstOrDefault(expression);
            if (contact != null)
                return contact;

        } catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public bool RemoveOneContact(Func<Contact, bool> expression)
    {
        var contact = GetOneContact(expression);
        if (contact != null)
        {
            _contacts.Remove(contact);
            FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_contacts));
            ContactUpdated.Invoke();
            return true;
        }

        return false;
    }

    public Contact EditOneContact(Contact contact)
    {
        var _contact = _contacts.FirstOrDefault(x => x.Id == contact.Id);

        if (_contact != null)
        {
            if (_contact.FirstName != contact.FirstName)
                _contact.FirstName = contact.FirstName;

            if (_contact.LastName != contact.LastName)
                _contact.LastName = contact.LastName;

            if (_contact.Address.Street != contact.Address.Street)
                _contact.Address.Street = contact.Address.Street;

            if (_contact.Address.PostalCode != contact.Address.PostalCode)
                _contact.Address.PostalCode = contact.Address.PostalCode;

            if (_contact.Address.City != contact.Address.City)
                _contact.Address.City = contact.Address.City;


            FileHandler.SaveToFile(path, JsonConvert.SerializeObject(_contacts));
            ContactUpdated.Invoke();
            return _contact;
        }

        return null!;
    }

    private void UpdateCurrentContact(string id)
    {
        CurrentContact = GetOneContact(x => x.Id == id);
    }


}
