var hiddenValue = Random.Shared.Next(1, 101);
var guessedNumber = 0;
int tries = 0;
Console.WriteLine("Lower or higher, guess the number between 1 and 100");
do
{
    var guess = Console.ReadLine();
    if (int.TryParse(guess, out guessedNumber))
    {
        if (guessedNumber < hiddenValue)
        {
            Console.WriteLine("Higher");
        }
        else if (guessedNumber > hiddenValue)
        {
            Console.WriteLine("Lower");
        }
        tries--;
    }
    else
    {
        Console.WriteLine("Invalid input, please enter a number.");
    }
} while (guessedNumber != hiddenValue);

Console.WriteLine($"You guess the number in {tries} tries");