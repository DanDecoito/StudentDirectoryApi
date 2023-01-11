using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch6Controller : ControllerBase
{

    [HttpGet]
    [Route("Game/{number}")]
    public string Game(string number)
    {
        int num = int.Parse(number);
        return number = num % 2 == 0 ? "Your number is even" : "Your number is Odd";

    }

}

