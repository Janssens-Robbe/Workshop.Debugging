var toDoList = new ToDoList("Breakfast", "The classic async breakfast");

Console.WriteLine("Would you like coffee with your breakfast? (y/n)");
var answer = Console.ReadLine();
if (answer?.ToLower() == "y")
{
    toDoList.AddItem(new("Coffee", "Pour coffee"));
}

Console.WriteLine("Would you like eggs? (y/n)");
if (Console.ReadLine()?.ToLower() == "y")
{
    toDoList.AddItem(new("Preheat", "Heat pan"));
    toDoList.AddItem(new("Eggs", "Fry eggs"));
}

Console.WriteLine("Would you like bacon? (y/n)");
if (Console.ReadLine()?.ToLower() == "y")
{
    var preHeat = toDoList.Items.FirstOrDefault(i => i.Name == "Preheat");
    if (preHeat == null)
    {
        toDoList.AddItem(new("Preheat", "Heat pan"));
    }
    toDoList.AddItem(new("Bacon", "Fry bacon"));
}

Console.WriteLine("Would you like toast? (y/n)");
if (Console.ReadLine()?.ToLower() == "y")
{
    toDoList.AddItem(new("Toast", "Toast bread"));
    Console.WriteLine("Would you like jam? (y/n)");
    if (Console.ReadLine()?.ToLower() == "y")
    {
        toDoList.AddItem(new("Jam", "Spread jam on toast"));
    }
}

Console.WriteLine("Would you like juice? (y/n)");
if (Console.ReadLine()?.ToLower() == "y")
{
    toDoList.AddItem(new("Juice", "Pour juice"));
}

// Prepare breakfast
for (int i = 0; i < toDoList.Items.Count; i++)
{
    var item = toDoList.Items[i];
    Console.WriteLine($"Preparing {item.Name}...");
    if (item.IsCompleted)
    {
        throw new InvalidOperationException($"The task {item.Name} has already been completed somehow!");
    }
    else
    {
        item.Complete();
        Console.WriteLine($"{item.Name} is now completed.");
    }
}

public class ToDoList(string name)
{
    public ToDoList(string name, string description)
        : this(name)
    {
        Description = description;
    }

    public string Name { get; private set; } = name;
    public string? Description { get; private set; } = null;
    public List<ToDoListItem> Items { get; private set; } = [];

    public void AddItem(ToDoListItem item)
    {
        Items.Add(item);
    }
}

public class ToDoListItem(string name)
{
    public ToDoListItem(string name, string description)
        : this(name)
    {
        Description = description;
    }

    public string Name { get; private set; } = name;
    public string? Description { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    public DateTime? CompletedAt { get; private set; } = null;
    public bool IsCompleted { get; private set; } = false;

    public void Complete()
    {
        IsCompleted = true;
        CompletedAt = DateTime.Now;
    }
}