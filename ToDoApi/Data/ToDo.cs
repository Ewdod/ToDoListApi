namespace ToDoApi.Data;

public class ToDo
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public bool Done { get; set; }

}
