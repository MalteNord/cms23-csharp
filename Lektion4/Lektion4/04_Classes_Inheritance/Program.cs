﻿using _04_Classes_Inheritance.Models;
using _04_Classes_Inheritance.Services;
var runAgain = false;

do
{
    Console.Clear();
    Console.Write("Vad för typ av kund vill du skapa? (p = privatperson, f = företag) ");
    var option = Console.ReadLine();

    switch (option!.ToLower())
    {
        case "p":
            CustomerService.CreatePrivateCustomer();
            break;

        case "f":
            CustomerService.CreateCompanyCustomer();
            break;

        default:
            break;
    }
    Console.WriteLine("Vill du fortsätta? j/n");
    runAgain = (Console.ReadLine()!.ToLower() == "j") ? true : false;

}
while (runAgain);
