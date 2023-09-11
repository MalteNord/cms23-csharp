using _01_Classes.Models;

namespace _01_Classes.Services;

internal class CustomerService
{
    //fields

    private List<Customer> _customerList = null!;


    //Methods(propertyName)

    public void CreateCustomer(Customer customer)
    {
        if (!_customerList.Contains(customer))
        _customerList.Add(customer);
    }

    public void GetCustomer() { }

    public List<Customer> GetCustomers()
    {
        return _customerList;
    }

    public void UpdateCustomer() { }

    public void DeleteCustomer() { }

}

/*
service = 90% Methods

fields

Constructors

Properties

Methods
 */