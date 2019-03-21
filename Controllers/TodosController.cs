﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todo_starter_netcore_2.Data;

namespace todo_starter_netcore_2.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TodosController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {

      try
      {
        TodoContext context = new TodoContext();

        var todos = await context.Todos.ToArrayAsync();
        return Ok(todos);
      }
      catch (Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
