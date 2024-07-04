using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VersionsApi.Atrributes;

namespace VersionsApi.Controllers.V1_5;


[NestedRoute("[controller]", typeof(TodosController))]
[ApiVersion("1.5", Deprecated = true)]
public class TodosController : ControllerApiBase
{
    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var tasks = new List<Todo>()
        {
            new(Guid.NewGuid(), "Title 1"),
            new(Guid.NewGuid(), "Title 2"),
            new(Guid.NewGuid(), "Title 3"),
        };

        await Task.Delay(1000);

        return Ok(tasks);
    }
}


public record Todo(Guid Id, string Title);