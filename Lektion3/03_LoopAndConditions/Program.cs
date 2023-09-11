/* Operander
-------------------------------------------------------------------------------
==           lika med
!=           inte lia med
<            mindre än
>            större än
<=           mindre eller lika med
>=           större eller lika med
&&           och
||           eller
!            inte
??           om första värdet är null välj det andra



if (statement) {}

if (statement) {} else {}

if (statement) {} else if (statement) {} else {}

(statement) ? do_this : else_do_this;

string name = "Malte";
string firstName = "Tommy";

if ( !(name == firstName))
{
    Console.WriteLine("Namnen är lika.");
}
else
{
    Console.WriteLine("Namnen är inte lika.");
}
Console.ReadKey();

*/

/* IF-SATSER
-------------------------------------------------------------------------------

string firstName = "";

if (!string.IsNullOrEmpty(firstName))
{
    Console.WriteLine("Nu gör vi någonting med förnamnet.");
}
else
{
    Console.WriteLine("Det finns inget förnman.");
}
Console.ReadKey();

-------------------------------------------------------------------------------

string firstName = "Malte";
string lastName = null!;

if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("Något utav värdena är inte ifyllda.");
}

-------------------------------------------------------------------------------
*/

/* SWITCH
-------------------------------------------------------------------------------

string key = "black;

switch (key)
{
case "blue"
Console.WriteLine("Unlock blue door.");
break;

case "orange"
Console.WriteLine("Unlock orange door.");
break;

case "gray"
Console.WriteLine("Unlock gray door.");
break;

default:
Console.WriteLine"Go through white door.");
break;
}


 */

/* FOR-LOOP
-------------------------------------------------------------------------------
Vi loopar igenom en lista eller gör något ett givit antal gånger.

for (initialize value; condition; increment initialized value)
{

}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}


 */
/* FOREACH-LOOP 
 ------------------------------------------------------------------------------
Vi loopar igenom alla obbjekt i en lista

foreach (var object in list)
{
}


string[] names = new string[] { "Malte", "Tommy", "Joakim", "Jeanette" };
int[] numbers = new int[] { 1, 2, 3, 4 };

foreach(var name in names)
{
    Console.WriteLine(name);
}
Console.ReadKey();
 */
/* ARRAYS
 ------------------------------------------------------------------------------
En array är en sta
 
 */

/*  WHILE-LOOP
 ------------------------------------------------------------------------------
Gör en sak om och om igen tills ett tillstånd är uppnåt.
Varav kontrollen sker i början.

while (statement)
{
}


int number = 0;
while (number < 10)
{
    Console.WriteLine(number);
    number++;
}

 */

/* DO-WHILE 
-------------------------------------------------------------------------------
Gör loopen minst en gång sedan kollar den tillståndet

do
{
} while (statement);


int number = 0;

do
{
    Console.WriteLine(number);
    number++;

} while (number < 10);

*/


