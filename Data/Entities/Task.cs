using System;


namespace todo_starter_netcore_2.Data.Entities
{
  public class Task
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int difficulty { get; set; }

  }
}