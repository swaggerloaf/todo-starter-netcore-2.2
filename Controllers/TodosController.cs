using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todo_starter_netcore_2.Data;

namespace todo_starter_netcore_2.Controllers
{
  public class TodosContoller : ControllerBase
  {
    public TodosContoller()
    {
    }

    public object Get()
    {
      return new { Id = 1, Title = "Call Fred" };
    }

  }
}
