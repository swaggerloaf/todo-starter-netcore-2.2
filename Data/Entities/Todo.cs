namespace todo_starter_netcore_2.Data.Entities
{
  public class Todo
  {
    public int Id { get; set; }
    public int? UserId { get; set; }
    public string Text { get; set; }
    public bool IsCompleted { get; set; }
  }

}