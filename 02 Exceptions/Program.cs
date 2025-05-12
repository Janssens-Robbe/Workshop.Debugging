using System.Diagnostics;
using Workshop.Debugging.DeepFryer;

var cook = new Cook();
while (true)
{
    Console.WriteLine("Select a number from the menu:");
    for (var i = 0; i < cook.Menu.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {cook.Menu[i]}");
    }

    var input = Console.ReadLine();
    if (int.TryParse(input, out var choice) && choice > 0 && choice <= cook.Menu.Count)
    {
        var food = cook.Menu[choice - 1];
        Console.WriteLine($"Preparing {food}...");
        try
        {
            cook.Prepare(food);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while preparing {food}: {ex.Message}");
            Debug.WriteLine(ex.StackTrace);
        }
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}