using _01_Adressbok.Interfaces;
using _01_Adressbok.Models;
using _01_Adressbok.Services;

namespace _01_Adressbok_Test
{
    public class ContactServiceTests
    {
        [Fact]
        public void AddContact_ShouldAddContactToList()
        {
            // Arrange
            var contactService = new ContactService();
            var contact = new Contact { FirstName = "Malte", LastName = "Nordstrand" };

            // Act
            contactService.AddContact(contact);

            // Assert
            var allContacts = contactService.GetAllContacts();
            var addedContact = allContacts.FirstOrDefault(c => c.FirstName == "Malte" && c.LastName == "Nordstrand");
            Assert.NotNull(addedContact);
        }

    }
}