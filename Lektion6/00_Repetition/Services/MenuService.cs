using _00_Repetition.Interfaces;
using _00_Repetition.Models;

namespace _00_Repetition.Services;

internal class MenuService : IMenuService
{

    private readonly ITodoService _todoService = new TodoService();
    public void AddMenu()
    {
        try
        {
            var todo = new Todo();

            Console.Clear();
            Console.Write("Ange aktivitet: ");
            todo.Activity = Console.ReadLine()!;

            _todoService.Add(todo);
        }

        catch { }
    }

    public void DeleteMenu()
    {
        
        try
        {
            Console.Clear();
            Console.WriteLine("ATT GÖRA-LISTAN");
            Console.WriteLine("--------------------------");
            Console.Write("Ange id: ");
            var id = Console.ReadLine()!;
            _todoService.Delete(new Guid(id));
        }

        catch { }
        
    }

    public void ListMenu()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("ATT GÖRA-LISTAN");
            Console.WriteLine("--------------------------");

            foreach (var todo in _todoService.GetAll())
            {
                Console.WriteLine($"{todo.Activity}");
                Console.WriteLine($"{todo.Id} - {todo.Created}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        catch { }
    }

    public void MainMenu()
    {
        var repeat = true;
        do
        {
            Console.Clear();
            Console.WriteLine("ATT GÖRA-LISTAN");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Lägg till ny aktivitet");
            Console.WriteLine("2. Visa alla akktiviteter");
            Console.WriteLine("3. Ta bort aktivitet");
            Console.WriteLine("0. Avsluta");
            Console.Write("Ange ett alternativ ovan: ");

            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    AddMenu();
                    break;

                    case "2":
                    ListMenu();
                    break;

                    case "3":
                    DeleteMenu();
                    break;

                case "0":
                    Console.WriteLine("Avslutar... Tryck på valfri tangent för att gå vidare.");
                    repeat = false;
                    Console.ReadKey();
                    break;


                    
            }

        } while (repeat);
    }
}
