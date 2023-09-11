/* Namngivning av Klasser
-------------------------------------------------------------------------------
Customer, User, Product, Order, Case, Machine, Device, etc.

CustomerRequest, UserRequest, ProductRequest, CustomerResponse, UserResponse,
ProductResponse

CustomerDto, UserDto, ProductDto

CreateCustomer, CreateUser, CreateProduct, CustomerCreate, UserCreate,
Productreate
-------------------------------------------------------------------------------
Förklaring

Request           När du skickkar in något till systemet (data från reg.formulär)
Schema            När du skickkar in något till systemet (baseras på Swagger)

Response          När du skkickar något tilbakak från systemet (ex. en kund.)
Model             När du skkickar något tilbakak från systemet (baseras på MVC)
Customer          När du skkickar något tilbakak från systemet (objektets typ)

Dto               Data Transfer Objekt och kan vara när du skickar till eller
                  från ett system eller mellan olika delar i ett system (lite odefinerat)
*/

using _01_Classes.Services;
using _01_Classes.Models;


/* Access Modifiers
 ------------------------------------------------------------------------------
private          accessbara bara inom scopet(dvs { }) som variabeln ligger inom.
public           accessbara överallt i hela din solution, dvs även mellan olika projekt.
internal         accessbar överallt i hela ditt projekt, men inte mellan olika projekkt.
 
 */

//Vi gör en instans av en customerService så vi kan använda den.
var customerService = new CustomerService();

customerService.GetCustomers();
