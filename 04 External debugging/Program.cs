using Microsoft.EntityFrameworkCore;

var dbContext = new AppDbContext();
dbContext.Database.EnsureCreated();
var toDoList = new ToDoList
{
    Id = 5,
    Name = "MVP Workshop May 20225",
    Description = "Workshop debugging"
};
dbContext.Add(toDoList);

dbContext.Add(new ToDoListItem
{
    Id = 11,
    ToDoListId = 5,
    Name = "External debugging",
    Description = "Learn how to debug external code, such as EF"
});

dbContext.SaveChanges();

var toListItems = dbContext.ToDoListItems
    .Where(x => x.ToDoList.Name.Contains("Workshop"))
    .ToList();

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
    }

    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<ToDoListItem> ToDoListItems { get; set; }
}

public class ToDoList
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<ToDoListItem> Items { get; set; } = [];
}

public class ToDoListItem
{
    public int Id { get; set; }
    public int ToDoListId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoList ToDoList { get; set; }
}