using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VersionsApi.Atrributes;

namespace VersionsApi.Controllers.V2;

[NestedRoute("[controller]", typeof(TodosController))]
[ApiVersion("2.0")]
public class TodosController : ControllerApiBase
{
    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var tasks = new List<Todo>()
        {
            new(1, "Title 1"),
            new(2, "Title 2"),
            new(3, "Title 3"),
        };

        await Task.Delay(1000);

        return Ok(tasks);
    }
}


public record Todo(int Id, string Title);
