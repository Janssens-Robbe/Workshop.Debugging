var objects = new List<SimpleObject>();
while (true)
{
    if (objects.Count > 1000)
    {
        var deleteCount = RandomFunctions.RemoveRange(objects);
        Console.WriteLine($"Removed {deleteCount} items");
    }

    objects.Add(RandomFunctions.GetNewSimpleObject());
}

public static class RandomFunctions
{
    public static SimpleObject GetNewSimpleObject()
    {
        if (Random.Shared.NextDouble() > 0.8)
        {
            Thread.Sleep(1);
        }
        return new SimpleObject
        {
            Number = Random.Shared.NextDouble() > 0.8 ? null : Random.Shared.Next(),
            Text = Random.Shared.NextDouble() > 0.8 ? null : Guid.NewGuid().ToString()
        };
    }

    public static int RemoveRange(this List<SimpleObject> list)
    {
        var toDelete = Random.Shared.Next(10, 30);
        for (int i = 0; i < toDelete; i++)
        {
            list.RemoveAt(Random.Shared.Next(0, list.Count));
        }
        Thread.Sleep((int)(Random.Shared.NextDouble() * 10));
        return toDelete;
    }
}

public class SimpleObject
{
    public int? Number { get; set; }
    public string? Text { get; set; }
}