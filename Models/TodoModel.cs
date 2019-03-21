using System;

namespace todo_starter_netcore_2.Models
{
  public class TodoModel
  {
    public string Text { get; set; }
    public DateTime DueDate { get; set; } = DateTime.MinValue;
    public bool IsCompleted { get; set; }
  }
}