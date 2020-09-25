using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace api.ToDo
{
  public static class GetToDos
  {
    [FunctionName("GetTodos")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("Get ToDos");



      List<TodoResponse> todos = new List<TodoResponse>
      {
        new TodoResponse { Name = "t1", Done = false },
        new TodoResponse { Name = "t2", Done = false }
      };


      return new OkObjectResult(todos);
    }
  }
}
