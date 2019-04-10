using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace todo_starter_netcore_2.Data.Entities
{

  public class TodoAppUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }

}