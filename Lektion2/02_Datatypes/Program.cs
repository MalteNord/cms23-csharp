﻿/*
C# standard datatyper som används
------------------------------------------------------------------------------
* string        till för test             string name = "Malte";
* int           till för heltal           int age = 24;
  long          till för heltal           long age = 24;
* decimal       till för decimaltal       decimal length = 164.5m;
  double        till för decimaltal       double length = 164.5;
  float         till för decimaltal       float length = 165.6f;
* bool          till för sant/falskt      bool isHuman = true;
  char          till för enskilt tecken   char gender = 'M';
  dynamic       kan innehålla vad som     dynamic lastName = "Nordstrand"
                                          dynamic weight = 100.0;
* Guid          globalt unikt id          Guid id = Guid.NewGuid();
  byte
* null
  object

*/

/*
Deklarera variabler i C#
------------------------------------------------------------------------------

Hur skriver vi variabel namn:

camelCase        firstName                string firstName = "Malte";
Pascal           FirstName                string FirstName = "Malte";
kebab-case       first-name               string first-name = "Malte";
snake_case       first_name               string first_name = "Malte";

C# använder sig primärt av Pascal men även camelCase

Korrekt sätt att deklarera:              string firstName = "Malte";
Latmanssättet att deklarera:             var firstName = "Malte";

*/

/*

STRING - textbaserade värden
------------------------------------------------------------------------------

string firstName = "Malte";
var    lastName = "Nordstrand";

string firstName = "Malte";
var lastName = "Nordstrand";

string sentence_1 = "Jag heter Malte och jag är bäst.";
string sentence_2 = "Jag heter Malte och jag är \"bäst\".";

string url_1 = "c:\\education\\cms23-csharp";
string url_2 = @"c:\education\cms23-csharp";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}";
string placeholder_3 = string.Format("Hej jag heter {0} {1}", firstName, lastName);


*/

Console.Write("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Skriv ditt efternamn: ");
string lasttName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lasttName}.");
Console.ReadKey();






