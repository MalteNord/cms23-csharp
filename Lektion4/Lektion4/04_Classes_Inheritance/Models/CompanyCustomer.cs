﻿namespace _04_Classes_Inheritance.Models;

internal class CompanyCustomer : Customer
{
    public string CompanyName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}

