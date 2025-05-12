using CommonLib;

namespace Workshop.Debugging.DeepFryer;
public class DeepFryer
{
    public decimal Temperature { get; set; } = 20;

    public void Heat(decimal targetTemperature)
    {
        TermpratureAsserter.ThrowIfFreezingFreezing(targetTemperature);
        if (targetTemperature > 200)
        {
            throw new ArgumentOutOfRangeException(nameof(targetTemperature), "Temperature cannot exceed 200 degrees.");
        }
        Temperature = targetTemperature;
    }

    public void Fry(string food)
    {
        if (Temperature < 100)
        {
            throw new FryerToColdException("The oil is not hot enough to fry.");
        }
        if (food.Contains("fries", StringComparison.CurrentCultureIgnoreCase) && food.Contains("french", StringComparison.CurrentCultureIgnoreCase))
        {
            throw new DisallowedProductException("French fries are not allowed in this fryer.");
        }
        if (food.Contains("water", StringComparison.CurrentCultureIgnoreCase))
        {
            throw new DisallowedProductException("You should never put water in hot oil, you dummy");
        }
        Console.WriteLine($"Frying {food} at {Temperature} degrees.");
    }
}