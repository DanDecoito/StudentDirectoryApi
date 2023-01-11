using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch3Controller : ControllerBase
{
    [HttpGet]
    [Route("Question/{name}/{time}")]

    public string Question(string name, string time)
    {
        return $"Hello {name} you woke up at {time} today";
    }

}

