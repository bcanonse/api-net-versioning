using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VersionsApi.Atrributes;

namespace VersionsApi.Controllers.V1;

// [NestedRoute("[controller]", typeof(TodosController))]
// [ApiVersion("1.0")]
[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var tasks = new List<Todo>()
        {
            new(1, "Title 1", "Description 1"),
            new(2, "Title 2", "Description 2"),
            new(3, "Title 3", "Description 3"),
        };

        await Task.Delay(1000);

        return Ok(tasks);
    }
}


public record Todo(int Id, string Title, string Description);
