using Microsoft.AspNetCore.Mvc;

namespace VersionsApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}")]
public class ControllerApiBase : ControllerBase
{ }
