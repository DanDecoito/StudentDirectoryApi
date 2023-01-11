using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch1Controller : ControllerBase
{
   
[HttpGet]
[Route("Hello/{name}")]

public string Hello(string name)
{
    return $"Hello {name} how are you today?";

}
}
