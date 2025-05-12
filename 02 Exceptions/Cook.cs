namespace Workshop.Debugging.DeepFryer;
public class Cook
{
    private readonly DeepFryer _deepFryer = new();

    public List<string> Menu { get; } = [
        "French fries",
        "Belgian fries",
        "Freeze fried chicken",
        "Room temperature oil soaked waterballoon",
        "Burt onions"
    ];

    public void Prepare(string food)
    {
        var temperature = food switch
        {
            "Freeze fried chicken" => -20,
            "Room temperature oil soaked waterballoon" => 20,
            "Burt onions" => 350,
            _ => 170
        };
        _deepFryer.Heat(temperature);

        try
        {
            _deepFryer.Fry(food);
        }
        catch (DisallowedProductException ex) when (food.Contains("french", StringComparison.CurrentCultureIgnoreCase))
        {
            throw new InvalidOperationException("We don't fry anything french food", ex);
        }
        catch (DisallowedProductException ex)
        {
            Console.WriteLine($"Oops, it seems I cannont cook that: {ex.Message}");
        }
        catch (FryerToColdException) when (temperature > 0)
        {
            _deepFryer.Heat(100);
            _deepFryer.Fry(food);
        }
    }
}
