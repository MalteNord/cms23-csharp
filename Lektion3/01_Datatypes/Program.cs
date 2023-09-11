/* String - till för text

string firstName = "Malte";
var lastName = "Nordstrand";

string firstName = "Malte";
string lastName = "Nordstrand";

string sentence = "Jag är \"bäst\"";

string uri_1 = "c:\\users\\malte\\document";
string uri_2 = @"c:\users\malte\document";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);

string email = "Malte.Nordstrand@gmail.com";
Console.WriteLine($"Original: {email}");
Console.WriteLine($"ToUpper: {email.ToUpper()}");
Console.WriteLine($"ToLower: {email.ToLower()}");

string firstName = "Malte";
string lastName = "Nordstrand";
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");

string sentence = "Här har vi en stext på svenska";
Console.WriteLine(sentence.Replace("ä", "a"));

string name = "Malte Nordstrand";
string domain = "domain.com";
string emailaddress = $"{name}@{domain}";
Console.WriteLine(emailaddress);
emailaddress = emailaddress.Replace(" ", ".").ToLower();

 */


/* INTEGRALS & FLOATING POINTS
-------------------------------------------------------------------------------

Type          Bits                 Range (min,max)
-------------------------------------------------------------------------------
* byte        8                    0                   255
  sbyte       8                    -128                127
  short       16                   -32768              32767
  ushort      16                   0                   65535
* int         32                   -2147483648         2147483647
  uint        32                   0                   4294967295
* long        64                   -92233706854775808  9223372036854775807
  ulong       64                   0                   18446744073709551615

int age = 24;
long age = 24;


Type          Bytes                DECIMAL RANGE       SUFFIX
-------------------------------------------------------------------------------
  float         4                    6-9 digits          f eller F
  double        8                    15-16 digits        inget eller d eller D
* decimal       16                   28-29 digits        m eller M


float floatValue = 0.1f + 0.1f + 0.1f;     //0.3
Console.WriteLine(floatValue);

double doubleValue = 0.1 + 0.1 + 0.1;      //0.30000000004 ish
Console.WriteLine(doubleValue);

decimal decimalValue = 0.1m + 0.1m + 0.1m;
Console.WriteLine(decimalValue);

float = 1.123456789f;
double = 1.123456789012345;
decimal = 1234567890123456789012345678m;

*/


/* BOOLEAN - Sant/Falst

Type              Bits                   
-------------------------------------------------------------------------------
bool              0/1                        false/true

bool isEnabled = false;
bool isActive = true;

*/

/* GUID/UUID (Globally Unique Identifier)
-------------------------------------------------------------------------------
Guid          16 bytes      Guid.NewGuid();    8428f0a1-129e-4c57-a5aa-461bf5da84


Guid userId = Guid.NewGuid();
Console.WriteLine(userId);

 */















