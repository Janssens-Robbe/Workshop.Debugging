namespace CommonLib;

public static class TermpratureAsserter
{
    public static void ThrowIfFreezingFreezing(decimal temperature)
    {
        if (temperature < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(temperature), "Temperature cannot be below freezing.");
        }
    }
}
