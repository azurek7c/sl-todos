using System.IO;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace api.ToDo
{
  public static class CreateTodo
  {
    [FunctionName("CreateToDo")]
    public static async Task<IActionResult> Run(
      [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]
      HttpRequest req,
      ILogger log)
    {
      var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
      var data = JsonConvert.DeserializeObject<CreateToDoRequest>(requestBody);

      log.LogInformation($"Create a ToDo with Name: {data.Name}");

      return new CreatedResult("createtodo", data);
    }
  }
}
