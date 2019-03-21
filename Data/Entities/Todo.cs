using System;


namespace todo_starter_netcore_2.Data.Entities
{

  public enum PriorityType
  {
    None, Low, High
  }
  public class Todo
  {
    public int Id { get; set; }
    public int? UserId { get; set; }
    public string Text { get; set; }
    public DateTime DueDate { get; set; }

    public PriorityType Priority { get; set; }
    public bool IsCompleted { get; set; }
  }

}